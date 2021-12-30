using BaseVM;

using ShoppingList.BLL;
using ShoppingList.BLL.Model;

using System.Collections.Generic;
using System.Windows.Input;

namespace ShoppingList.ViewModel
{
    public class ChangeUserVM : ViewModelBase
    {

        private List<User> _availableUsers;
        public List<User> AvailableUsers => _availableUsers ?? (_availableUsers = Manager.Instance.GetAllUsers());


        private User _selectedUser;

        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                if (_selectedUser != value)
                {
                    _selectedUser = value;
                    OnPropertyChanged(nameof(SelectedUser));
                }
            }
        }

        private bool CanChangeUser()
        {
            return SelectedUser != null;
        }

        private void ChangeUser()
        {
            Manager.Instance.CurrentUser = SelectedUser;
        }

        public ICommand ChangeUserCommand
        {
            get { return Commands.GetOrCreateCommand(() => ChangeUserCommand, ChangeUser, CanChangeUser); }
        }


    }
}
