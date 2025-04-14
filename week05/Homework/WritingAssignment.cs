using System;

public class WritingAssignment : Assignment
{
    // Atributo específico
    private string _title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Método específico
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}
