﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databastestLocal
{
    class Admin:User
    {
        private int userName;
        private int acesslevel = 3;



        public Admin(int uname)
        {
            uname = UserName;
        }

        public int UserName { get; set; }

    }
}
