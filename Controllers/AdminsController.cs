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
    public class AdminsController : Controller
    {
        private IAdminService _service;

        public AdminsController(IAdminService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            List<AdminModel> result = new List<AdminModel>();

            try
            {
                result = await _service.GetAdmins();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (result.Count > 0)
                return Ok(result);
            else
                return NotFound();
        }
    }
}
