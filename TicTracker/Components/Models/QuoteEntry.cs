using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicTracker.Components.Models
{
    public class QuoteEntry
    {
        //public 

        public int Id { get; set; }
        public int EntryType { get; set; }
        public TimeOnly EntryTime { get; set; }
        public DateOnly EntryDate { get; set; }
        public int DailyCounter { get; set; }
        private static readonly Dictionary<int, string> entryToQuoteTranslation = new()
        {
            {1, "It's Cal 1/College Algebra"},
            {2, "Am I Right?"},
            {3, "Hello?"},
            {4, "Come up?"},
            {5, "Ack"},
            {6, "Let's Go"}
        };

        public string GetQuote()
        {
            return entryToQuoteTranslation[this.EntryType];
        }
    }
}
