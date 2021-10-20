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
        private Image picture;
        private int[] card_ids;

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
            card_ids = DbOperations.GetCardIdsInStack(this.id);
        }

        public IEnumerator<VocabCard> GetEnumerator()
        {
            foreach (int cid in card_ids)
            {
                yield return DbOperations.GetCardById(cid);
            }
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
            get { return card_ids.Length; }
        }

        public Image Picture
        {
            get { return picture; }
            set { picture = value; }
        }

        public VocabQuiz Quiz()
        {
            return new VocabQuiz(card_ids);
        }
    }

    public class VocabCard
    {
        private int id;
        private int stack_id;
        private string native_word;
        private string foreign_word;
        private string comment;
        private string hyperlink;
        private Image picture;
        private byte[] sound;

        public VocabCard(long id, long stack_id, string native_word, string foreign_word, string comment, byte[] picture, byte[] sound, string hyperlink)
        //constructor for database object materialization
        {
            if (id >= 0)
            {
                this.id = Convert.ToInt32(id);
            }
            if (stack_id >= 0)
            {
                this.stack_id = Convert.ToInt32(stack_id);
            }
            this.native_word = native_word;
            this.foreign_word = foreign_word;
            this.comment = comment;
            this.picture = ImageConversion.ByteToImg(picture);
            this.sound = sound;
            this.hyperlink = hyperlink;
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

        public Image Picture
        {
            get { return picture; }
            set { picture = value; }
        }
    }

    public enum CardFaceLanguages : int
    {
        Foreign = 0,
        Native = 1
    }
}
