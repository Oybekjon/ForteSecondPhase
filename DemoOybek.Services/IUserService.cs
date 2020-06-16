using DemoOybek.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOybek.Services
{
    public interface IUserService
    {
        UserViewModel UpdatePassword(ChangePasswordViewModel viewModel);
        UserViewModel SaveUser(UserViewModel user);
        ListViewModel<UserViewModel> GetUsers(UserQueryViewModel query);
        void DeleteUser(long id);
    }
}
