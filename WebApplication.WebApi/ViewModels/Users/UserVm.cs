﻿using System;
using System.Collections.Generic;

namespace WebApplication.WebApi.ViewModels.Users
{
    public class UserVm
    {
        public Guid Id { set; get; }
        public string UserName { set; get; }
        public string FullName { set; get; }
        public string Address { set; get; }
        public string ImagePath { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public IList<string> Roles { set; get; }
    }
}