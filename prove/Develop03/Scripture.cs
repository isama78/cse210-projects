using System.Text.RegularExpressions;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordsList = text.Split(" ");
        foreach(string word in wordsList)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for(int i = 0;i < _words.Count;i++)
        {
            if(numberToHide - 1 == i)
            {
                _words[i].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string newSentence = "";
        foreach(Word word in _words)
        {
            //It creates a separation between verses by replacing the number of verse with ;
            newSentence += Regex.Replace(word.GetDisplayText(), @"\b\d+\b", ";") + " ";
        }
        return $"{_reference.GetDisplayText()} {newSentence}";
    }

    public bool IsCompletlyHidden()
    {
        return _words.All(word => word.GetDisplayText().Contains("_"));
    }

    public int GetLength()
    {
        return _words.Count;
    }
}