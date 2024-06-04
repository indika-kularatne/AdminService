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
    public class NavigationMenuController : Controller
    {
        private IAdminService _service;

        public NavigationMenuController(IAdminService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index(Guid UserID)
        {
            try
            {
                return Ok(await _service.GetMenuByUser(UserID));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> Index()
        {
            try
            {
                return Ok(await _service.GetAllMenu());
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
    }
}
