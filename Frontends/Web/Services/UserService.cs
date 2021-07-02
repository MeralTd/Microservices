using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Web.Models;
using Web.Services.Interfaces;

namespace Web.Services
{
    public class UserService : IUserService
    {
        public readonly HttpClient _client;

        public UserService(HttpClient client)
        {
            _client = client;
        }
        public async Task<UserViewModel> GetUser()
        {
            return await _client.GetFromJsonAsync<UserViewModel>("/api/user/getuser");
        }

    }
}
