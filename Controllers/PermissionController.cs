using AdminService.Models.PermissionModel.Request;
using AdminService.Services;
using AdminService.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdminService.Controllers
{
	[ApiController]
	[Route("api/v1/[controller]/")]
	public class PermissionController : Controller
	{
		private IAdminService _service;
		private readonly IPermissionService _permissionService;
		public PermissionController(IAdminService service, IPermissionService permissionService)
		{
			_service = service;
			_permissionService = permissionService;
		}

		[HttpGet]
		public async Task<IActionResult> Get(Guid userID)
		{
			try
			{
				return Ok(await _service.GetRoleControllerPermissionByUserId(userID));
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		[HttpPost]
		public async Task<IActionResult> Create([FromBody] IList<CreatePermissionModel> model)
		{
			try
			{
				return Ok(await _permissionService.CreateAsync(model));
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		[HttpGet("GetByRole/{roleId}")]
		public async Task<IActionResult> GetListPermissionByRoleId(Guid roleId)
		{
			try
			{
				return Ok(await _permissionService.GetListPermissionByRoleIdAsync(roleId));
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		[HttpPut("UpdateRolePermissions")]
		public async Task<IActionResult> UpdateRolePermissions([FromBody] IList<UpdateRolePermissionModel> models)
		{
			try
			{
				return Ok(await _permissionService.UpdateRolePermissionsAsync(models));
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(Guid id)
		{
			try
			{
				return Ok(await _permissionService.DeleteRolePermissionAsync(id));
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
