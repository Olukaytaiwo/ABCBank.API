﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCBank.Data
{
    public class ApplicationUser : IdentityUser<long>
    {
        public ApplicationUser()
        {
            IsDeleted = false;
            CreatedOn = DateTime.Now;
            LastLogOn = DateTime.Now;
        }
        public long Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string BVN { get; set; }
        public string Address { get; set; }
    }
}
