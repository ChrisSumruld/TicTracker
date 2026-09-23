using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicTracker.Components.Models
{
    public class QuoteEntry
    {
        //public 

        public int Id { get; set; }
        public int EntryType { get; set; }
        public DateTime EntryTime { get; set; }
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
