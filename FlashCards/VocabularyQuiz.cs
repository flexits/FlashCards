using System;
using System.Collections.Generic;
using System.Text;

namespace FlashCards
{
    public class VocabQuiz
    {
        public VocabQuiz(int[] card_ids)
        {
            //make list of cardss (ids) and populate it
            allcards = new List<int>(card_ids);
            //make empty list of returned cards
            returnedcards = new List<int>(card_ids.Length);
            //init random
            rnd = new Random();
        }

        private List<int> allcards;
        private List<int> returnedcards;
        private Random rnd;

        public VocabCard PopRandomCard()
        {
            //random select card id from allcards
            //return corresponding card and remove id from list
            //if list is empty - populate it from returnedcards
            //if both are empty - return null
            //DbOperations.GetCardById(id)
            //
            int index;
            VocabCard vcard;

            if (allcards.Count <= 0)
            {
                if (returnedcards.Count > 0)
                {
                    allcards.Clear();
                    foreach (int id in returnedcards)
                    {
                        allcards.Add(id);
                    }
                    returnedcards.Clear();
                }
                else
                {
                    return null;
                }
            }
            index = rnd.Next(0, allcards.Count - 1);
            vcard = DbOperations.GetCardById(allcards[index]);
            allcards.RemoveAt(index);
            return vcard;
        }

        public void PushCardBack(VocabCard vcard)
        {
            //add card id to the list of returned cards
            if (!returnedcards.Contains(vcard.Id))
            {
                returnedcards.Add(vcard.Id);
            }
        }
    }
}
