using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOybek.Services.ViewModels
{
    public class ChangePasswordViewModel
    {
        public long UserId { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
    }
}
