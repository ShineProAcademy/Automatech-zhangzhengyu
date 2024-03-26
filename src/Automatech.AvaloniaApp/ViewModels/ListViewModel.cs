using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Automatech.AvaloniaApp.Models;
using AutoMatech.DataRepository.Interface;
using AutoMatech.DataRepository.Models;
using CommunityToolkit.Mvvm.Input;

namespace Automatech.AvaloniaApp.ViewModels;

public class ListViewModel : ViewModelBase
{
    public ObservableCollection<ObservableStudent> DataSource { get; set; }

  
    public ListViewModel(IDataRepository<Student, int> repository)
    {
        DataSource = new ObservableCollection<ObservableStudent>();
        IEnumerable<Student> students = repository.GetAll();
        foreach (var item in students)
        {
            DataSource.Add(new ObservableStudent(item));
        }
    }

    public void Modify()
    {
        DataSource.First().Name = "张珊";
    }
}