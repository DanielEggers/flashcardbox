using nsimpleeventstore;

namespace flashcardbox.events
{
    public class CardFoundMissing : Event
    {
        public string CardId;
    }
}