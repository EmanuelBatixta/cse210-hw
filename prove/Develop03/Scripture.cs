using System.Text;
class Scripture
{
    private Reference _reference;
    private List <Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    private HashSet<int> randomNum = new HashSet<int>();
    public void HideRandomWords(int numberToHide)
    {
        Random randomWords = new Random();
        for (int i = 0; i < numberToHide; i++)
        {              
            int index = randomWords.Next(_words.Count);
            if (randomNum.Contains(index))
            {
               while(randomNum.Contains(index) && randomNum.Count != _words.Count)
               {
                    index = randomWords.Next(_words.Count);
               }   
            }
            _words[index].Hide();
            randomNum.Add(index);
        }
    }

    public string GetDisplayText()
    {   
        StringBuilder displayText = new StringBuilder();

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                foreach (char item in word.GetDisplayText())
                {
                    displayText.Append("_");
                }
            }
            else
            {
                displayText.Append(word.GetDisplayText());
            }
            displayText.Append(" ");
        }
        return $"{_reference.GetDisplayText()} {displayText.ToString().Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return true;
            }
        }
        return false;
    }
}