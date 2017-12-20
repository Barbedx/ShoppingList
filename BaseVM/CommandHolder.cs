using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Input;

namespace BaseVM
{
    public class CommandHolder
    {
        private Dictionary<string, ICommand> _commands = new Dictionary<string, ICommand>();

        public ICommand GetOrCreateCommand<T>(Expression<Func<T>> commandNameExpression, Action<object> executeCommandAction)
        {
            var commandName = SymbolHelpers.GetPropertyName(commandNameExpression);

            if (!_commands.ContainsKey(commandName))
            {
                var command = new RelayCommand(executeCommandAction);
                _commands.Add(commandName, command);
            }

            return _commands[commandName];
        }

        public ICommand GetOrCreateCommand<T>(Expression<Func<T>> commandNameExpression, Action<object> executeCommandAction, Func<object, bool> canExecutePredicate)
        {
            var commandName = SymbolHelpers.GetPropertyName(commandNameExpression);

            if (!_commands.ContainsKey(commandName))
            {
                var command = new RelayCommand(executeCommandAction, canExecutePredicate);
                _commands.Add(commandName, command);
            }

            return _commands[commandName];
        }

        public ICommand GetOrCreateCommand<T>(Expression<Func<T>> commandNameExpression, Action executeCommandAction, Func<bool> canExecutePredicate)
        {
            return GetOrCreateCommand(commandNameExpression, parameter => executeCommandAction(), parameter => canExecutePredicate());
        }

        public ICommand GetOrCreateCommand<T>(Expression<Func<T>> commandNameExpression, Action executeCommandAction)
        {
            return GetOrCreateCommand(commandNameExpression, executeCommandAction, () => true);
        }
    }
}
