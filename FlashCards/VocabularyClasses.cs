using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace FlashCards
{
    /*
     * Cards, stacks and related stuff
     */

    public class VocabStack
    {
        private readonly int id;
        private string name;
        private string comment;
        private string native_lang;
        private string foreign_lang;
        private Image picture;
        private int stacklength;

        bool errorflag = false;
        int[] card_ids;

        public VocabStack(long id, string name, string native_lang, string foreign_lang, byte[] picture, string comment)
        //constructor for database object materialization
        {
            if (id >= 0)
            {
                this.id = Convert.ToInt32(id);
            }
            this.name = name;
            this.native_lang = native_lang;
            this.foreign_lang = foreign_lang;
            this.comment = comment;
            this.picture = ImageConversion.ByteToImg(picture);
            stacklength = DbOperations.CardsCountInStack(this.id);
            //get relevant cards from db by stack_id and their count
            card_ids = new int[stacklength];
            for (int i = 0; i < stacklength; i++)
            {
                //actual ids from db here
                //card_ids[i] = i;
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

        private bool CheckIndex(int index)
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

        public int Id
        {
            get { return id; }
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
        }

        public Image Picture
        {
            get { return picture; }
            set { picture = value; }
        }

        public bool ErrorFlag
        {
            get { return errorflag; }
        }
    }

    public class VocabCard
    {
        private readonly int id;
        private int stack_id;
        private string native_word;
        private string foreign_word;
        private string comment;
        private string hyperlink;
        //Image cardimg;
        private byte[] dblobimage;
        private byte[] dblobsound;

        public VocabCard(long id, long stack_id, string native_word, string foreign_word, string comment, byte[] dblobimage, byte[] dblobsound, string hyperlink)
        //constructor for database object materialization
        {
            if (id >= 0)
            {
                this.id = Convert.ToInt32(id);
            }
            if (stack_id >= 0)
            {
                this.stack_id = Convert.ToInt32(id);
            }
            this.native_word = native_word;
            this.foreign_word = foreign_word;
            this.comment = comment;
            this.dblobimage = dblobimage;
            this.dblobsound = dblobsound;
            this.hyperlink = hyperlink;
        }

        public VocabCard(int stack_id, int card_id)
        {
            this.id = card_id;
            this.stack_id = stack_id;
            foreign_word = "Example 1";
            native_word = "Пример1";
            comment = "comment1";
        }

        public string WordForeign
        {
            get { return foreign_word; }
            set { foreign_word = value; }
        }
        public string WordNative
        {
            get { return native_word; }
            set { native_word = value; }
        }
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public string Hyperlink
        {
            get { return hyperlink; }
            set { hyperlink = value; }
        }
    }
}
