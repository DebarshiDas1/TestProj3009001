using Microsoft.AspNetCore.Mvc;
using TestProj3009001.Helpers.Extensions;

namespace TestProj3009001.Helpers
{
    /// <summary>
/// Base class of API controller
/// </summary>
    public class BaseApiController : ControllerBase
    {
        /// <summary>
/// User id
/// </summary>
        protected Guid UserId { get => HttpContext.User.Identity.GetUserId(); }
        /// <summary>
/// Tenant id
/// </summary>
        protected Guid TenantId { get => HttpContext.User.Identity.GetTenantId(); }
    }
}