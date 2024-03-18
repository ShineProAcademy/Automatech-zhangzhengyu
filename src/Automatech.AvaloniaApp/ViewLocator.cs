using System;
using Automatech.AvaloniaApp.ViewModels;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;

namespace Automatech.AvaloniaApp;

/// <summary>
/// 根据ViewModel自动创建View
/// 约定优于配置
/// </summary>
public class ViewLocator : IDataTemplate
{
    public Control? Build(object? param)
    {
        if (param is null)
        {
            return null;
        }

        string name = param.GetType().FullName?.Replace("ViewModel", "View", StringComparison.Ordinal);

        Type type = Type.GetType(name);

        if (type is not null)
        {
            Control obj = (Control)Activator.CreateInstance(type);
            obj.DataContext = param;
            return obj;
        }
        
        return new TextBlock() { Text = "test" };
    }

    public bool Match(object? data)
    {
        if (data is ViewModelBase)
        {
            return true;
        }

        return false;
    }
}