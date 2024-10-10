using System;

public class Word
{
    private string _text;
    public bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = true;
    }

    public void Hide()
    {

    }

    public void Show()
    {

    }

    public bool IsHidden()
    {
        _isHidden = false;
    }

    public string GetDisplayText()
    {

    }

}