using System;
using System.Collections.Generic;
using System.Text;

namespace FlashCards
{
    public class VocabQuiz
    {
        public VocabQuiz(int[] card_ids)
        {
            //make list of ids and populate it
            //make list of returned cards (empty)
        }

        public VocabCard PopRandomCard()
        {
            //random selection of id from list
            //if list is empty - populate it from returned cards
            //if both are empty - return null
            //DbOperations.GetCardById(id)
            //remove id from list
            VocabCard vcard = null; ;
            return vcard;
        }

        public void PushCardBack(VocabCard vcard)
        {
            //add card id to the list of returned cards
        }
    }
}
