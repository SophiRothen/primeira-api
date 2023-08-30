using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPI.Controllers
{

    [ApiExplorerSettings(IgnoreApi =true)]  //notaçao para nao aparecer no swagger
    public class ThrowController : ControllerBase
    {
        [Route("/error")]     //problema no ambiente de producao
        public IActionResult HandleError() =>
            Problem();

        [Route("/error-development")]   //problema no ambiente de desenvolvimento

        public IActionResult HandleErrorDevelopment(
            [FromServices] IHostEnvironment hostEnvironment)
        {
            if(!hostEnvironment.IsDevelopment())
            {
                return NotFound();
            }

            var exceptionHandlerFeature = 
                HttpContext.Features.Get<IExceptionHandlerFeature>()!;

            return Problem(
                detail: exceptionHandlerFeature.Error.StackTrace,
                title: exceptionHandlerFeature.Error.Message);
        }

    }
}
