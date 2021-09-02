using AutoMapper;
using EventBus.Messages.Events;
using Masdr.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Masdr.API.Mappers
{
    public class MasdrProfile:Profile
    {
        public MasdrProfile()
        {
            CreateMap<Contract, UploadContractsEvent>().ReverseMap();
            CreateMap<AdditionalClause, AdditionalClauseEvent>().ReverseMap();

        }
    }
}
