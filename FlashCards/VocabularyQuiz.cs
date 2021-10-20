using System;
using System.Collections.Generic;

namespace FlashCards
{
    /*
     * Implemetation of card learning algorythm
     * 
     * It's like a stack. We pop a random card, show it to the user.
     * If user confirms that they know the meaning, the card is gone.
     * If user doesn't know the meaning, they return card and 
     * the card is pushed back so therefore it'll pop again eventually.
     * When/If there's no cards left, we pop null.
     */
    public class VocabQuiz
    {
        public VocabQuiz(int stack_id)
        {
            allcards = DbOperations.GetAllCardsIDsInStack(stack_id);
            returnedcards = new List<int>(allcards.Count);
            rnd = new Random();
        }

        private readonly List<int> allcards;
        private readonly List<int> returnedcards;
        private readonly Random rnd;

        public VocabCard PopRandomCard()
        {
            //random select card id from allcards
            //return corresponding card and remove id from list
            //if list is empty - populate it from returnedcards
            //if both are empty - return null
            int index;
            VocabCard vcard;

            if (allcards.Count <= 0)
            {
                if (returnedcards.Count <= 0)
                {
                    return null;
                }
                else
                {
                    allcards.Clear();
                    foreach (int id in returnedcards)
                    {
                        allcards.Add(id);
                    }
                    returnedcards.Clear();
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
