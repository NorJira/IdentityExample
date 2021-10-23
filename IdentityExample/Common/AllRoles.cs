using System;
using System.Collections.Generic;
using System.Linq;
using IdentityExample.Models;
using Microsoft.AspNetCore.Identity;

namespace IdentityExample.Common
{
    public class AllRoles
    {
        private RoleManager<IdentityRole> _roleManager;

        public AllRoles(RoleManager<IdentityRole> roleManager)
        {
            this._roleManager = roleManager;
        }

        public List<string> GetAllRoles()
        {
            return _roleManager.Roles.Select(r => r.Name).ToList();
        }
    }
}