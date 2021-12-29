using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BaseVM
{
       
    public abstract class ViewModelBase : INotifyPropertyChanged, IDataErrorInfo //INotifyDataErrorInfo, 
    { 

        #region INotifyPropertyChanged members
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
        protected Dictionary<string, List<string>> _errors = new Dictionary<string, List<string>>();
        private CommandHolder _commands;
        public CommandHolder Commands
        {
            get { return _commands ?? (_commands = new CommandHolder()); }
        }

        public virtual string Error => string.Empty;

        public virtual string this[string columnName] => string.Empty;
    }
}
