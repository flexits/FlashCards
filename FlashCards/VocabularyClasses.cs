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
        private readonly int id;
        private string name;
        private string comment;
        private string native_lang;
        private string foreign_lang;
        private byte[] picture;

        public VocabStack()
        //parameterless constructor for deserialization
        {
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
            get { return DbOperations.CardsCountInStack(id); }
        }

        public byte[] Picture { get; set; }
    }

    public class VocabCard
    {
        private int id;
        private int stack_id;
        private string native_word;
        private string foreign_word;
        private string comment;
        private string hyperlink;
        private byte[] picture;
        private byte[] sound;

        public VocabCard()
        {

        }

        public VocabCard(int stack_id)
        //constructs an empty card belonging to a particular stack
        //negative id is the distinctive feature of a new card absent in database
        {
            this.id = -1;
            this.stack_id = stack_id;
        }

        public int Id
        {
            get { return id; }
        }

        public int StackId
        {
            get { return stack_id; }
            set
            {
                if (value >= 0)
                {
                    stack_id = value;
                }
            }
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

        public byte[] Picture { get; set; }
    }

    public enum CardFaceLanguages : int
    {
        Foreign = 0,
        Native = 1
    }
}
