﻿using System;
using System.Windows.Input;

namespace CookBook.App.Commands;

public class LambdaCommand : ICommand
{
    private readonly Predicate<object> _canExecute;
    private readonly Action<object> _execute;

    public LambdaCommand(Action<object> execute, Predicate<object> canExecute)
    {
        _canExecute = canExecute;
        _execute = execute;
    }

    public bool CanExecute(object parameter)
    {
        return _canExecute.Invoke(parameter);
    }

    public void Execute(object parameter)
    {
        _execute.Invoke(parameter);
    }

    public event EventHandler CanExecuteChanged;
}
