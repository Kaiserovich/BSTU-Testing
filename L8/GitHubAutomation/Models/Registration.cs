using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Models
{
    class Registration
    {
        public string EMail { get; set; }

        public Registration(string eMail)
        {
            EMail = eMail;
        }
    }
}