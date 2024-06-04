using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminService.DBContext;
using AdminService.Models;
using AdminService.Services;
using Microsoft.AspNetCore.Mvc;

namespace AdminService.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/")]
    public class MenuGroupController : Controller
    {
        private IAdminService _service;

        public MenuGroupController(IAdminService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post(MenuGroupModel Model)
        {
            try
            {
                return Ok(await _service.CreateMenuGroup(Model));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(MenuGroupModel Model)
        {
            try
            {
                return Ok(await _service.EditMenuGroup(Model));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Get(Guid ID)
        {
            try
            {
                return Ok(await _service.GetMenuGroup(ID));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("MenuGroupSort")]
        public async Task<IActionResult> UpdateMenuGroupSort(List<MenuGroupModel> Model)
        {
            try
            {
                return Ok(await _service.SaveMenuGroupSort(Model));
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
                return Ok(await _service.DeleteMenuGroup(ID, ModifiedBy));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
