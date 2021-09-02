using AutoMapper;
using EventBus.Messages.Events;
using Masdr.API.Models;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Masdr.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ContractController : ControllerBase
    {
        private readonly ILogger<ContractController> _logger;
        private readonly IMapper _mapper;
        private readonly IPublishEndpoint _publisher;

        public ContractController(ILogger<ContractController> logger, IMapper mapper, IPublishEndpoint publishEndpoint)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _publisher = publishEndpoint ?? throw new ArgumentNullException(nameof(publishEndpoint));
        }



        [Route("[action]")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Accepted)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> UploadContracts([FromBody] Contract contract)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest();

                _logger.LogTrace($"Object to be invoked ", contract);

                //Create UploadContractEvent -
                //Send event to RabbitMQ using massTranist
                //Return To Dynamics365 Accepted
                var eventMessage = _mapper.Map<UploadContractsEvent>(contract);
                await _publisher.Publish(eventMessage);

                return Accepted();
            }
            catch (Exception ex)
            {
                var mes = ex.Message;
                return BadRequest("An error has occurred");
            }
        }
    }
}
