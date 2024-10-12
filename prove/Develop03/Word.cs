using System;

public class Word
{
    private string _text;
    public bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        //Console.Write(_text);
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (IsHidden)
        {

            return "______";
        }
        else
        {
            return _text;
        }

    }

}