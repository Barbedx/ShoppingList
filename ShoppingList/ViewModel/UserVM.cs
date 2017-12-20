using BaseVM.Custom;
using ShoppingList.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.ViewModel
{
    public class UserVM : EditableDataVM<User>
    {
        public UserVM(User innerValue) : base(innerValue)
        {
        }

        public override Task SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
