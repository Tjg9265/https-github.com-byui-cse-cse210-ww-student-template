using System.Collections.Generic;

public class Video
{
    // Member variables (underscoreCamelCase)
    private string _title;
    private string _author;
    private int _length;

    // Composition: List of Comment objects
    private List<Comment> _comments = new List<Comment>();

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Behaviors — rubric says method must return count directly from storage
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Getters so Program.cs can print values
    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}
