﻿using DronTaxi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronTaxi.Services.Interfaces
{
    interface IUserService
    {
        List<User> GetUsers();

        List<Role> GetRoles();

        List<Right> GetRights();
    }
}
