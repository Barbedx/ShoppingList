using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BaseVM
{
        /// Если честно, раньше не приходилось работать с INotifyDataErroInfo, Только с IDataError, 
        /// про существование INotify узнал только на днях.
        /// сейчас уже поджимают сроки, поэтому пишу на IDataError.
    public abstract class ViewModelBase : INotifyPropertyChanged, IDataErrorInfo //INotifyDataErrorInfo, 
    {
        //public bool HasErrors => _errors.Values.Any(r => r.Count>0) ;// throw new NotImplementedException();

        //public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
        //public void OnErrorChanged([CallerMemberName] string propertyName = "")
        //{
        //    ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        //}

        //public IEnumerable GetErrors([CallerMemberName] string propertyName="")
        //{
        //    if (propertyName!=null)
        //    {
        //        _errors.TryGetValue(propertyName, out List<string> errors);
        //        return errors;
        //    }
        //    return null;
        //}


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
