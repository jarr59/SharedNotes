using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ShareNotes.Exceptions;

public class CustomExceptions : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        if (context.Exception is BaseException ex)
        {
            if (ex.HttpErrorCodeHttpErrorCode == HttpErrorCode.BadRequest)
                context.Result = new BadRequestObjectResult(new { });

            if (ex.HttpErrorCodeHttpErrorCode == HttpErrorCode.NotFound)
                context.Result = new BadRequestObjectResult(new { });
        }
    }
}
