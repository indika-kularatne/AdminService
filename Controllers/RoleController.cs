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
    public class RoleController : Controller
    {
        private IAdminService _service;

        public RoleController(IAdminService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> Index()
        {
            try
            {
                return Ok(await _service.GetRoles());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Index(Guid ID)
        {
            try
            {
                return Ok(await _service.GetRole(ID));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoleModel Model)
        {
            try
            {
                return Ok(await _service.CreateRole(Model));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Edit(RoleModel Model)
        {
            try
            {
                return Ok(await _service.EditRole(Model));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid ID, Guid ModifiedBy)
        {
            try
            {
                return Ok(await _service.DeleteRole(ID, ModifiedBy));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpGet]
        [Route("userclaimpermission")]
        public async Task<IActionResult> UserClaimPermission(Guid userId)
        {
            try
            {
                return Ok(await _service.GetUserPermissions(userId));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
