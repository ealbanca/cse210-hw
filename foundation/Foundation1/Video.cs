using System;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private double _duration;

    private List<Comment> _comments;


    public Video(string title, string author, double duration, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _duration = duration;
        _comments = comments ?? new List<Comment>();
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public double GetDuration()
    {
        return _duration;
    }

    public int GetCommentsCount()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}

