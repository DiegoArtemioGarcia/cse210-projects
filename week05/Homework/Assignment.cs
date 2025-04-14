using System;

public class Assignment
{
    // Atributos comunes protegidos (para que las clases hijas puedan acceder)
    protected string _studentName;
    protected string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Método GetSummary
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Getter opcional si quieres encapsular más aún
    public string GetStudentName()
    {
        return _studentName;
    }
}
