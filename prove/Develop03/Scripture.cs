using System;
public class Scripture
{

    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();
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

    }

    public bool IsCompletelyHidden()
    {

    }

}