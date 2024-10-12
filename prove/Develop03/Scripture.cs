using System;
using System.Runtime.CompilerServices;
public class Scripture
{

    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();
        // Need to split the scripture, so each word will be an element of the list
        string[] wordsArray = text.Split(' ');

        foreach (string wordText in wordsArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int numbersHidden = 0;

        while (numbersHidden < numberToHide)
        {
            int randomIndex = random.Next(0, _words.Count);
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                numbersHidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return scriptureText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}