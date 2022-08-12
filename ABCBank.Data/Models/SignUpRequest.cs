using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCBank.Data
{
    public class SignUpRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string AccountNumber { get; set; }
        public string CardPan { get; set; }
        public string OTP { get; set; }
    }


}
