﻿using System.Collections.Generic;
using System.Net;
using Gemography.Crosscut.Localization;
using Gemography.Crosscut.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Gemography.APIs.Setups.Bases
{
    public class CoreController : Controller
    {
        private ISender _mediator;
        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
        public ObjectResult NewResult<T>(OutputResponse<T> response)
        {
            switch (response.StatusCode)
            {
                case HttpStatusCode.OK: //200
                    return new OkObjectResult(response);
                case HttpStatusCode.Created: //201
                    return new CreatedResult(string.Empty, response);
                case HttpStatusCode.BadRequest: //400
                    return new BadRequestObjectResult(response);
                case HttpStatusCode.Unauthorized: //401
                    return new UnauthorizedObjectResult(response);
                case HttpStatusCode.Forbidden: //403
                    return new UnauthorizedObjectResult(new OutputResponse<T>()
                    {
                        Errors = new List<ErrorModel>
                        {
                            new()
                            {
                                ErrorCode = "Unauthorized",
                                Message = ResponseMessageTranslator.Unauthorized,
                                Property = "Overall"
                            }
                        },
                        Message = ResponseMessageTranslator.Unauthorized,
                        Success = false
                    });
                case HttpStatusCode.NotFound: //404
                    return new NotFoundObjectResult(response);
                case HttpStatusCode.Accepted:
                    return new AcceptedResult(string.Empty, response);
                default:
                    return new BadRequestObjectResult(response);
            }
        }

        public ObjectResult ReturnResult<T>(OutputResponse<T> value)
        {
            return NewResult(value);
        }
  
    }
}
