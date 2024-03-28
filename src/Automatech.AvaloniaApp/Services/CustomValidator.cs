using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Automatech.AvaloniaApp.Services;

public class CustomValidator : INotifyPropertyChanged, INotifyDataErrorInfo
{
    
    private Dictionary<string, List<ValidationAttribute>> _errorMessages = new Dictionary<string, List<ValidationAttribute>>();
    
    public event PropertyChangedEventHandler? PropertyChanged;
    
    public IEnumerable GetErrors(string? propertyName)
    {
        if (propertyName == null)
            return _errorMessages;
       
        return _errorMessages;
    }

    public bool HasErrors => _errorMessages.Count > 0;
    
    public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;
}