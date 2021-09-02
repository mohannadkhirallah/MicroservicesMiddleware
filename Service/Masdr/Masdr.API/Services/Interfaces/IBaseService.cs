using Masdr.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Masdr.API.Services.Interfaces
{
  public  interface IBaseService: IDisposable
    {
        Task<T> SendAsync<T>(ApiRequest apiRequest);

    }
}
