using System.Diagnostics.CodeAnalysis;
using AutoMatech.DataRepository.Interface;
using AutoMatech.DataRepository.Models;

namespace AutoMatech.DataRepository.Implements;

public class StudentRepository : IDataRepository<Student,int>
{
    private IList<Student> _students;
    
    public StudentRepository()
    {
        _students = new List<Student>();
        
        for (int i = 0; i < 10; i++)
        {
           _students.Add(new Student(){StudentId = i, Name = $"学生{i}", Sex = true, Age  = 11 + i});
        }
    }

    public void Load()
    {
        return;
    }

    public void Save()
    {
       return;
    }

    public IEnumerable<Student> GetAll()
    {
        return _students;
    }

    public bool Add(Student model)
    {
        if (model == null)
        {
            return false;
        }
        
        if (!_students.Contains(model))
        {
            _students.Add(model);
            return true;
        }

        return false;
    }

    public bool Remove(Student model)
    {
        if (model == null)
        {
            return false;
        }
        
        if (_students.Contains(model))
        {
            _students.Remove(model);
            return true;
        }

        return false;
    }

    public Student Get(int key)
    {
        return _students.FirstOrDefault(m => m.StudentId == key);
    }

    public bool Update(Student model)
    {
        if (model == null)
        {
            return false;
        }
        
        Student student = _students.FirstOrDefault(m => m.StudentId == model.StudentId);
        if (student != null)
        {
            student.Name = model.Name;
            student.Age = model.Age;
            student.Sex = model.Sex;
            return true;
        }

        return false;
    }
}