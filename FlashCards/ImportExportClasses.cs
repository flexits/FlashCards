using System;
using System.Collections.Generic;
using System.Text.Json;

namespace FlashCards
{
    class StackWrapper
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

        public VocabStack Stack { get => stack; set => stack = value; }
        public List<VocabCard> Cards { get => cards; set => cards = value; }
    }
}
