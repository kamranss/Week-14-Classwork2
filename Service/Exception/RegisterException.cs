﻿using Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    internal class RegisterException:Exception
    {
        public RegisterException(string message) :base (message)
        {
            
        }
    }
}
