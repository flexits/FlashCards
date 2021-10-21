using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FlashCards
{
    class StackWrapper
    //this class encapsulates a stack object and all related cards objects
    //for (de)serialization and provides methods to work with JSON strings
    {
        private VocabStack stack;
        private List<VocabCard> cards;

        public StackWrapper(int stack_id)
        {
            stack = DbOperations.GetStackById(stack_id);
            cards = DbOperations.GetAllCardsInStack(stack_id);
        }

        public StackWrapper()
        {
            stack = null;
            cards = new List<VocabCard>();
        }

        public static StackWrapper Deserialize(string jsonstring)
        {
            return JsonSerializer.Deserialize<StackWrapper>(jsonstring);
        }

        public string Serialize()
        {
            return JsonSerializer.Serialize<StackWrapper>(this);
        }

        public int FlushToDb()
        {
            int stackid = DbOperations.AddStack(stack);
            foreach (VocabCard vc in cards)
            {
                vc.StackId = stackid;
                _ = DbOperations.AddCard(vc);
            }
            return stackid;
        }

        public VocabStack Stack { get => stack; set => stack = value; }
        public List<VocabCard> Cards { get => cards; set => cards = value; }
    }
}
