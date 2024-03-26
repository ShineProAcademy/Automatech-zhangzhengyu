using Automatech.AvaloniaApp.ViewModels;
using AutoMatech.DataRepository.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Automatech.AvaloniaApp.Models;

public class ObservableStudent : ViewModelBase
{
    private Student _student;
    
    public ObservableStudent(Student student)
    {
        this._student = student;
    }

    public int StudentId
    {
        get => _student.StudentId;
        set => SetProperty(ref _student.StudentId, value);
    }

    public string Name
    {
        get => _student.Name;
        set => SetProperty(ref _student.Name, value);
    }

    public int Age
    {
        get => _student.Age;
        set => SetProperty(ref _student.Age, value);
    }

    public bool Sex
    {
        get => _student.Sex;
        set => SetProperty(ref _student.Sex, value);
    }
}