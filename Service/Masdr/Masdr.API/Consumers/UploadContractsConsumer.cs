using AutoMapper;
using EventBus.Messages.Events;
using Masdr.API.Models;
using Masdr.API.Services.Interfaces;
using MassTransit;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Masdr.API.Consumers
{
    public class UploadContractsConsumer : IConsumer<UploadContractsEvent>
    {
        private readonly IMapper _mapper;
        private readonly ILogger<UploadContractsConsumer> _logger;
        private readonly IBaseService _service;

        public UploadContractsConsumer(IMapper mapper, ILogger<UploadContractsConsumer> logger, IBaseService service)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _service = service ?? throw new ArgumentNullException(nameof(service));
        }


        public async Task Consume(ConsumeContext<UploadContractsEvent> context)
        {
            var message = _mapper.Map<Contract>(context.Message);
            _logger.LogTrace($"Messages received from queue {message.ID}",message);

            //Call Masdar API
            var masdarResponse = await _service.SendAsync<ApiResponse>(new ApiRequest
            {
                Method = ApiType.POST,
                Url = "",
                Data = message,
                AccessToken = ""
            });

            if(masdarResponse !=null && masdarResponse.IsSucess)
            {
                // CALL AX endpoints
            }

            // Handler errors in serilog with retry over monog db;

        }
    }
}
