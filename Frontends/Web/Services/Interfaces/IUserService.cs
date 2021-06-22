﻿using System.Threading.Tasks;
using Web.Models;

namespace Web.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserViewModel> GetUser();
    }
}