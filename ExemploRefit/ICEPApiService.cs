using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExemploRefit
{
    public interface ICEPApiService
    {
        [Get("/ws/{cep}/json")]
        Task <CEPResponse> GetInfoCepAsync(string cep);
    }
}


//--REF: https://viacep.com.br/