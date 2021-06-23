using System;
using System.Threading.Tasks;

namespace Web.Services.Interfaces
{
    public interface IClientCredentialTokenService
    {
        Task<String> GetToken();
    }
}