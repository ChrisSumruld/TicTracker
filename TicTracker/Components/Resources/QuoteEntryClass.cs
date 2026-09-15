namespace TicTracker.Components.Resources
{
    public class QuoteEntry
    {
        //public 
        public QuoteEntry(int entryType)
        {
            this.entryType = entryType;
            this.entryTime = DateTime.Now;
        }

        int entryType;
        DateTime entryTime;
        private readonly Dictionary<int, string> entryToQuoteTranslation = new()
        {
            {1, "It's Cal 1/College Algebra"},
            {2, "Am I Right?"},
            {3, "Hello?"},
            {4, "Come up?"},
            {5, "Ack"},
            {6, "Lets Go"}
        };
    }
}
