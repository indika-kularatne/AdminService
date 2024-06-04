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
    public class MenuController : Controller
    {
        private IAdminService _service;

        public MenuController(IAdminService service)
        {
            _service = service;
        }


        [HttpGet]
        [Route("bymenugroup")]
        public async Task<IActionResult> GetByMenuGroup(Guid MenuGroupID)
        {
            try
            {
                return Ok(await _service.GetMenuByGroup(MenuGroupID));
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
                return Ok(await _service.GetMenu(ID));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(MenuModel Model)
        {
            try
            {
                return Ok(await _service.CreateMenu(Model));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("sort")]
        public async Task<IActionResult> UpdateSorting(List<MenuModel> Model)
        {
            try
            {
                return Ok(await _service.UpdateMenuSort(Model));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(MenuModel Model)
        {
            try
            {
                return Ok(await _service.EditMenu(Model));
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
                return Ok(await _service.DeleteMenu(ID, ModifiedBy));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
