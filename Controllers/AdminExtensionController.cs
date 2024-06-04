using AdminService.Helpers;
using AdminService.Models;
using AdminService.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace AdminService.Controllers
{
    public class AdminExtensionController : Controller
    {
        private IAdminService _service;
        private PasswordSetting _passwordSetting;

        public AdminExtensionController(IAdminService service, IOptions<PasswordSetting> passwordSetting)
        {
            _service = service;
            _passwordSetting = passwordSetting.Value;
        }

        [HttpPost]
        [Route("api/v1/resetpassword/")]
        public async Task<IActionResult> ResetPassword(Guid ID)
        {
            bool reset = false;
            ResponseModel result = new ResponseModel();

            try
            {
                reset = await _service.ResetPassword(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (!reset)
            {
                result.ErrorCode = 90000;
                result.ErrorMessage = "Error when reseting password";
            }

            return Ok(result);
        }

        [HttpPost]
        [Route("api/v1/login/")]
        public async Task<IActionResult> Login(string Username, string Password)
        {
            ResponseModel result = new ResponseModel();

            try
            {
                result.Admin = await _service.ValidateAccess(Username, Password);
            }
            catch (ApplicationException es)
            {
                if (es.Message == ErrorMessages.ACCOUNT_IS_LOCKED)
                {
                    result.ErrorCode = 90001;
                    result.ErrorMessage = es.Message;
                }
            }
            catch
            {
                throw;
            }

            return Ok(result);
        }

        [HttpPost]
        [Route("api/v1/changepassword/")]
        public async Task<IActionResult> ChangePassword(string Username, string OldPassword, string NewPassword)
        {
            bool reset = false;
            ResponseModel result = new ResponseModel();

            try
            {
                reset = await _service.ChangePassword(Username, OldPassword, NewPassword);
                result.Admin = new AdminModel();
                result.Admin.Username = Username;
            }
            catch (ApplicationException ex)
            {
                if (ex.Message.StartsWith(ErrorMessages.NOT_ALLOWED_PREVIOUS_PASSWORD))
                {
                    result.ErrorCode = 90002;
                    result.ErrorMessage = ex.Message;
                }
                else if (ex.Message.StartsWith(ErrorMessages.FAILED_MIN_PASSWORD_AGE))
                {
                    result.ErrorCode = 90003;
                    result.ErrorMessage = ex.Message;
                }

                return Ok(result);
            }
            catch
            {
                throw;
            }

            if (!reset)
            {
                result.ErrorCode = 90000;
                result.ErrorMessage = "Error when changing password";
            }

            return Ok(result);
        }

        [HttpGet]
        [Route("api/v1/GetPasswordSetting")]
        public IActionResult GetPasswordSetting()
        {
            return Ok(_passwordSetting);
        }

        [HttpPost]
        [Route("api/v1/UnlockUser")]
        public async Task<IActionResult> UnlockUser(Guid userId, Guid actionUserId)
        {
            ResponseModel model = new ResponseModel();

            if (userId == actionUserId)
            {
                model.ErrorCode = 90003;
                model.ErrorMessage = ErrorMessages.NOT_ALLOWED_UNLOCK_OWN_ACCOUNT;

                return Ok(model);
            }

            bool isUnlocked = await _service.UnlockUserAsync(userId, actionUserId);
            if (!isUnlocked)
            {
                model.ErrorCode = 90000;
                model.ErrorMessage = ErrorMessages.ERROR_IN_UNLOCK_ACCOUNT;
            }

            return Ok(model);
        }
    }
}