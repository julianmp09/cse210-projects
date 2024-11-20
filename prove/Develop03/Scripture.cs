using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizer
{
    class Scripture
    {
        public Reference Reference { get; }
        private List<Word> Words { get; }

        public Scripture(Reference reference, string text)
        {
            Reference = reference;
            Words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public string Display()
        {
            string wordsDisplay = string.Join(" ", Words.Select(word => word.Display()));
            return $"{Reference.Display()}\n{wordsDisplay}";
        }

        public bool HideRandomWords()
        {
            var visibleWords = Words.Where(word => !word.IsHidden).ToList();
            if (!visibleWords.Any()) return false;

            Random random = new Random();
            int wordsToHide = Math.Min(3, visibleWords.Count);
            foreach (var word in visibleWords.OrderBy(_ => random.Next()).Take(wordsToHide))
            {
                word.Hide();
            }

            return true;
        }

        // "Hint" functionality: Reveals a hidden word randomly as a hint for the user.
        public bool RevealHint()
        {
            var hiddenWords = Words.Where(word => word.IsHidden).ToList();
            if (!hiddenWords.Any()) return false;

            Random random = new Random();
            hiddenWords[random.Next(hiddenWords.Count)].Reveal();
            return true;
        }
    }
}
