﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Model.Request
{
    public class LoginModel
    {
        public string UserName { get; set;}=string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
