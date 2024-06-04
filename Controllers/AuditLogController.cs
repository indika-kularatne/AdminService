using AdminService.Services.Interfaces;
using AdminService.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminService.Models.AuditLogModel.Request;

namespace AdminService.Controllers
{
    [ApiController]
    [Route("api/v1/audit-log/")]
    public class AuditLogController : Controller
    {
        private IAuditLogService _service;
        public AuditLogController(IAuditLogService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult> Index([FromQuery]AuditLogRequestModel model)
        {
           var result =  await _service.GetAuditLog(model);
            return Ok(result);
        }
    }
}
