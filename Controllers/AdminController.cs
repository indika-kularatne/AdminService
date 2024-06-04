using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminService.Models;
using AdminService.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdminService.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/")]
    public class AdminController : Controller
    {
        private IAdminService _service;

        public AdminController(IAdminService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index(Guid ID)
        {
            AdminModel result = new AdminModel();

            try
            {
                result = await _service.GetAdmin(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (result != null && result.ID != Guid.Empty)
                return Ok(result);
            else
                return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Post(AdminModel Model)
        {
            ResponseModel result = new ResponseModel();

            try
            {
                result = await _service.CreateAdmin(Model);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (result != null && result.Admin != null && result.Admin.ID != Guid.Empty)
                return Ok(result);
            else
                return NotFound();
        }

        [HttpPut]
        public async Task<IActionResult> Update(AdminModel Model)
        {
            ResponseModel result = new ResponseModel();

            try
            {
                result = await _service.UpdateAdmin(Model);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (result != null && result.Admin != null && result.Admin.ID != Guid.Empty)
                return Ok(result);
            else
                return NotFound();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid ID, Guid ModifiedBy)
        {
            ResponseModel result = new ResponseModel();

            try
            {
                result = await _service.DeleteAdmin(ID, ModifiedBy);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (result != null && result.Admin != null && result.Admin.ID != Guid.Empty)
                return Ok(result);
            else
                return NotFound();
        }


        
    }
}
