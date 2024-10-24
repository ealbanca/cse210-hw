using System;

public class WritingAssignmnet : Assignment
{
    private string _title;

    public WritingAssignmnet(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";

    }

}