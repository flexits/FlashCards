using System;
using System.Collections.Generic;
using System.Drawing;

namespace FlashCards
{
    /*
     * Cards, stacks and related stuff
     */

    public class VocabStack
    {
        int id;
        string name;
        string comment;
        string native_lang;
        string foreign_lang;
        //Image stackimg;
        //byte[] dblob;
        int stacklength;

        bool errorflag = false;
        int[] card_ids;

        public VocabStack()
        {
            /*
             * A parameterless default constructor or 
             * one matching signature (System.Int64 id, System.String name, 
             * System.String native_lang, System.String foreign_lang, 
             * System.Byte[] picture, System.String comment, 
             * System.Int64 member_count) is required for 
             * FlashCards.VocabStack materialization
             */
        }

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
            get { return name; }
            set { name = value; }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public string NativeLang
        {
            get { return native_lang; }
            set { native_lang = value; }
        }

        public string ForeignLang
        {
            get { return foreign_lang; }
            set { foreign_lang = value; }
        }

        public int StackLength
        {
            get { return stacklength; }
            set
            {
                if (value >= 0)
                {
                    stacklength = value;
                }
            }
        }

        public bool ErrorFlag
        {
            get { return errorflag; }
        }
    }

    public class VocabCard
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
