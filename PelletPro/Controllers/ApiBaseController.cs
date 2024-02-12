using MediatR;
using Microsoft.AspNetCore.Mvc;
using PelletPro.Application.Models;

namespace PelletPro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]

    public class ApiBaseController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ?? HttpContext.RequestServices.GetService<IMediator>();
        protected ObjectResult Response(ViewModelBase modelBase) 
        {
            if(modelBase.Status != System.Net.HttpStatusCode.OK)
            {
                return StatusCode((int)modelBase.Status, modelBase);
            }
            return Ok(modelBase);
        }
    }
}
