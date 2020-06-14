using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {

#pragma warning disable 0649
        private IMediator _mediator;
#pragma warning restore 0649
        protected IMediator Mediator => _mediator ?? (HttpContext.RequestServices.GetService<IMediator>());
    }
}