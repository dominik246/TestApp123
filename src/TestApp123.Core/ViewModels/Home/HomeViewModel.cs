using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Commands;
using TestApp123.Core.Pocos;
using TestApp123.Core.Service;
using Xamarin.Forms;

namespace TestApp123.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        private IUserService _service;
        public HomeViewModel(IUserService service)
        {
            _service = service;
        }

        private ICommand _initUsers;
        public ICommand InitButton
        {
            get
            {
                _initUsers ??= new Command(async() => await InitUsers());
                return _initUsers;
            }
        }

        public ObservableCollection<IUserPoco> Users = new ObservableCollection<IUserPoco>();

        private async Task InitUsers()
        {
            var result = await _service.GetAllUsersAsync();
            result.ForEach(p => Users.Add(p));
        }
    }
}
