using System;
using System.Collections.Generic;
using System.Drawing;

namespace FlashCards
{
    /*
     * Cards, stacks and related stuff
     */

    class VocabStack
    {
        int id;
        string name;
        string comment;
        string lang_native;
        string lang_foreign;
        Image stackimg;
        

        bool errorflag = false;

        int stacklength;
        int[] card_ids;

        public VocabStack(int id)
        {
            this.id = id;

            //get info from db
            name = "Stack_name_"+id.ToString();
            comment = "Stack_comment";

            //get relevant cards from db by stack_id and their count
            stacklength = 1;
            card_ids = new int[stacklength];
            for (int i = 0; i < stacklength; i++)
            {
                //actual ids from db here
                card_ids[i] = i;
            }
        }

        public VocabCard this[int index]
        {
            get
            {
                if (CheckIndex(index))
                {
                    //get card from db by its id
                    return new VocabCard(id, card_ids[index]);
                }
                return null;
            }
        }

        bool CheckIndex(int index)
        {
            if (index >= 0 & index < stacklength)
            {
                return true;
            }
            errorflag = true;
            return false;
        }

        public VocabCard GetUniqCard()
        //the method returns random cards from the stack 
        //until there's no more unique cads left
        {
            return null;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Comment
        {
            get
            {
                return comment;
            }
        }

        public int StackLength
        {
            get
            {
                return stacklength;
            }
        }

        public bool ErrorFlag
        {
            get
            {
                return errorflag;
            }
        }
    }

    class VocabCard
    {
        int id;
        int stack_id;
        string word_foreign;
        string word_native;
        string comment;
        Image cardimg;

        public VocabCard(int stack_id, int card_id)
        {
            this.id = card_id;
            this.stack_id = stack_id;
            word_foreign = "Example 1";
            word_native = "Пример1";
            comment = "comment1";
        }

        public string WordForeign
        {
            get
            {
                return word_foreign;
            }
        }

        public string WordNative
        {
            get
            {
                return word_native;
            }
        }

        public string Comment
        {
            get
            {
                return comment;
            }
        }
    }
}
