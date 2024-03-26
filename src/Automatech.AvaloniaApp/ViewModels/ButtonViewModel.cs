using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Platform.Storage;

namespace Automatech.AvaloniaApp.ViewModels;

public class ButtonViewModel : ViewModelBase
{
    public async void OpenFile(object obj)
    {
        if (obj is not Control)
        {
            return;
        }

        
        TopLevel topLevel = TopLevel.GetTopLevel((Control)obj);
        var list = await topLevel.StorageProvider.OpenFolderPickerAsync(new FolderPickerOpenOptions()
        {
            Title = "打开文件",
            AllowMultiple = false
        });

        if (list.Count >= 1)
        {
            
        }
        
        return;
    }

    public async void SaveFile(object obj)
    {
        if (obj is not Control)
        {
            return;
        }

        TopLevel topLevel = TopLevel.GetTopLevel((Control)obj);
        var file = await topLevel.StorageProvider.SaveFilePickerAsync(new ()
        {
            Title = "打开文件"
        });

        if (file is not null)
        {
            
        }
        
        return;
    }
}