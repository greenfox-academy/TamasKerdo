﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripChat.Repositories;

namespace TripChat.Services
{
    public class LoginService
    {
        public LoginRepository Repository { get; set; }

        public LoginService(LoginRepository repository)
        {
            Repository = repository;
        }

        internal long? CreateNewUser(string userName)
        {
            return 1;
        }

        internal long? CheckUser(string userName)
        {
            return 1;
        }
    }
}
