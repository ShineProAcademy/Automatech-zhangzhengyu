namespace AutoMatech.DataRepository.Models;

/// <summary>
/// 学生信息
/// </summary>
public class Student
{
    public int StudentId { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public bool Sex { get; set; }
}