namespace ScriptureMemorizer
{
    class Word
    {
        private string Text { get; }
        public bool IsHidden { get; private set; }

        public Word(string text)
        {
            Text = text;
            IsHidden = false;
        }

        public void Hide()
        {
            IsHidden = true;
        }

        public void Reveal()
        {
            IsHidden = false;
        }

        public string Display()
        {
            return IsHidden ? new string('_', Text.Length) : Text;
        }
    }
}
