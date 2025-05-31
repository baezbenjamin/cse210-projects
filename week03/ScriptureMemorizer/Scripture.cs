public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = [];
        string[] wordList = text.Split(" ");
        for (int i = 0; i < wordList.Length; i++)
        {
            Word word = new Word(wordList[i]);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            Random random = new Random();
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }

    }

    public string GetDisplayText()
    {
        string fullText = $"{ _reference.GetDisplayText()}";
        foreach (Word word in _words) {
            fullText = fullText + " " + word.GetDisplayText();
        }
        return fullText;
    }

    public bool IsCompletelyHidden()
    {
        bool completelyHidden = false;
        List<bool> conditions = new List<bool>{};
        for (int i = 0; i < _words.Count; i++)
        {
            conditions.Add(_words[i].IsHidden());
        }
        if (conditions.All(c => c))
        {
            completelyHidden = true;
        }
        return completelyHidden;
    }
}