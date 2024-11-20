namespace ScriptureMemorizer
{
    class Reference
    {
        public string Book { get; }
        public int Chapter { get; }
        public int StartVerse { get; }
        public int EndVerse { get; }

        public Reference(string book, int chapter, int startVerse, int endVerse = 0)
        {
            Book = book;
            Chapter = chapter;
            StartVerse = startVerse;
            EndVerse = endVerse == 0 ? startVerse : endVerse;
        }

        public string Display()
        {
            return EndVerse == StartVerse
                ? $"{Book} {Chapter}:{StartVerse}"
                : $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        }
    }
}
