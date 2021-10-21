using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data.SQLite;
using Dapper;

namespace FlashCards
{
    internal static class DbOperations
    /*
     * Database operations classes
     */
    {
        private static readonly string connstr = "Data Source=fcrd.db;Version=3;";
        private static readonly SQLiteConnection dbconn = new SQLiteConnection(connstr);
        
        public static List<VocabStack> GetAllStacks()
        //return all existing stacks 
        {
            string query = "SELECT * FROM stacks ORDER BY name ASC";
            return dbconn.Query<VocabStack>(query).AsList();
        }

        public static VocabStack GetStackById(int stack_id)
        //return particular card
        {
            string query = "SELECT * FROM stacks WHERE id = @stackid";
            return dbconn.QuerySingleOrDefault<VocabStack>(query, new { stackid = stack_id });
        }

        public static int CardsCountInStack(int stack_id)
        //return the number of cards relevant to a particular stack
        {
            string query = "SELECT COUNT(*) FROM cards WHERE stack_id = @stackid";
            return dbconn.ExecuteScalar<int>(query, new { stackid = stack_id });
        }

        public static List<VocabCard> GetAllCardsInStack(int stack_id)
        //return all cards relevant to a particular stack
        {
            string query = "SELECT * FROM cards WHERE stack_id = @stackid ORDER BY id ASC";
            return dbconn.Query<VocabCard>(query, new { stackid = stack_id }).AsList();
        }

        public static List<int> GetAllCardsIDsInStack(int stack_id)
        //return all cards ids relevant to a particular stack
        {
            string query = "SELECT id FROM cards WHERE stack_id = @stackid ORDER BY id ASC";
            return dbconn.Query<int>(query, new { stackid = stack_id }).AsList();
        }

        public static int[] GetCardIdsInStack(int stack_id)
        //return all cards' ids relevant to a particular stack
        {
            string query = "SELECT id FROM cards WHERE stack_id = @stackid ORDER BY id ASC";
            List<long> cards = dbconn.Query<long>(query, new { stackid = stack_id }).AsList();
            int[] result = new int[cards.Count];
            for (int i=0; i<cards.Count; i++)
            {
                result[i] = Convert.ToInt32(cards[i]);
            }
            return result;
        }

        public static VocabCard GetCardById(int card_id)
        //return particular card
        {
            string query = "SELECT * FROM cards WHERE id = @cardid";
            return dbconn.QuerySingleOrDefault<VocabCard>(query, new { cardid = card_id });
        }

        public static int UpdateStack(VocabStack modifiedstack)
        {
            DynamicParameters parameters = new DynamicParameters();
            string query = "UPDATE stacks SET name = @name, native_lang = @native_lang, foreign_lang = @foreign_lang, comment = @comment, picture = @picture WHERE id = @stackid";
            parameters.Add("name", modifiedstack.Name);
            parameters.Add("native_lang", modifiedstack.NativeLang);
            parameters.Add("foreign_lang", modifiedstack.ForeignLang);
            parameters.Add("comment", modifiedstack.Comment);
            parameters.Add("picture", modifiedstack.Picture);
            parameters.Add("stackid", modifiedstack.Id);
            return dbconn.ExecuteScalar<int>(query, parameters); //returns stack id
        }

        public static int AddStack(VocabStack newstack)
        {
            DynamicParameters parameters = new DynamicParameters();
            string query = "INSERT INTO stacks (name, native_lang, foreign_lang, comment, picture) VALUES (@name, @native_lang, @foreign_lang, @comment, @picture)";
            parameters.Add("name", newstack.Name);
            parameters.Add("native_lang", newstack.NativeLang);
            parameters.Add("foreign_lang", newstack.ForeignLang);
            parameters.Add("comment", newstack.Comment);
            parameters.Add("picture", newstack.Picture);
            return dbconn.ExecuteScalar<int>(query, parameters); //returns stack id
        }

        public static int AddStack(string name, string native_lang, string foreign_lang, Image picture, string comment)
        {
            DynamicParameters parameters = new DynamicParameters();
            string query = "INSERT INTO stacks (name, native_lang, foreign_lang, comment, picture) VALUES (@name, @native_lang, @foreign_lang, @comment, @picture)";
            parameters.Add("name", name);
            parameters.Add("native_lang", native_lang);
            parameters.Add("foreign_lang", foreign_lang);
            parameters.Add("comment", comment);
            parameters.Add("picture", ImageConversion.ImgToByte(picture));
            return dbconn.ExecuteScalar<int>(query, parameters); //returns stack id
        }

        public static int RemoveStack(int stack_id)
        {
            if (stack_id < 0)
            {
                return 0;
            }
            string query = "DELETE FROM cards WHERE stack_id = @stackid";
            int affectedrows = dbconn.Execute(query, new { stackid = stack_id });
            query = "DELETE FROM stacks WHERE id = @stackid";
            affectedrows += dbconn.Execute(query, new { stackid = stack_id });
            return affectedrows;
        }

        public static int UpdateCard(VocabCard modifiedcard)
        {
            DynamicParameters parameters = new DynamicParameters();
            string query = "UPDATE cards SET native_word = @native_word, foreign_word = @foreign_word, comment = @comment, picture = @picture WHERE id = @cardid";
            parameters.Add("native_word", modifiedcard.WordNative);
            parameters.Add("foreign_word", modifiedcard.WordForeign);
            parameters.Add("comment", modifiedcard.Comment);
            parameters.Add("picture", modifiedcard.Picture);
            parameters.Add("cardid", modifiedcard.Id);
            return dbconn.ExecuteScalar<int>(query, parameters); //returns card id
        }

        public static int AddCard(VocabCard newcard)
        {
            DynamicParameters parameters = new DynamicParameters();
            string query = "INSERT INTO cards (stack_id, native_word, foreign_word, comment, picture) VALUES (@stack_id, @native_word, @foreign_word, @comment, @picture)";
            parameters.Add("native_word", newcard.WordNative);
            parameters.Add("foreign_word", newcard.WordForeign);
            parameters.Add("comment", newcard.Comment);
            parameters.Add("picture", newcard.Picture);
            parameters.Add("stack_id", newcard.StackId);
            return dbconn.ExecuteScalar<int>(query, parameters); //returns card id
        }

        public static int AddCard(int stack_id, string native_word, string foreign_word, string comment, Image picture)
        {
            DynamicParameters parameters = new DynamicParameters();
            string query = "INSERT INTO cards (stack_id, native_word, foreign_word, comment, picture) VALUES (@stack_id, @native_word, @foreign_word, @comment, @picture)";
            parameters.Add("native_word", native_word);
            parameters.Add("foreign_word", foreign_word);
            parameters.Add("comment", comment);
            parameters.Add("picture", ImageConversion.ImgToByte(picture));
            parameters.Add("stack_id", stack_id);
            return dbconn.ExecuteScalar<int>(query, parameters); //returns card id
        }

        public static int RemoveCard(int card_id)
        {
            if (card_id < 0)
            {
                return 0;
            }
            string query = "DELETE FROM cards WHERE id = @cardid";
            return dbconn.Execute(query, new { cardid = card_id });
        }
    }
}
