using System.Collections.ObjectModel;
using AutoMatech.DataRepository.Interface;
using AutoMatech.DataRepository.Models;

namespace Automatech.AvaloniaApp.ViewModels;

public class ListViewModel : ViewModelBase
{
    public ObservableCollection<Student> DataSource { get; set; }

    public ListViewModel(IDataRepository<Student, int> repository)
    {
        DataSource = new ObservableCollection<Student>(repository.GetAll());
    }
}