using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data.SqlClient;
using Dapper;

namespace FlashCards
{
    /*
     * Database operations classes
     */

    internal static class DbOperations
    {
        private static readonly string connstr = "Data Source=fcrd.db;Version=3;";
        private static readonly SQLiteConnection dbconn = new SQLiteConnection(connstr);
        
        public static List<VocabStack> GetAllStacks()
        //return all existing stacks 
        {
            string query = "SELECT * FROM stacks ORDER BY name ASC";
            return dbconn.Query<VocabStack>(query).AsList();
        }

        public static int CardsCountInStack(int stack_id)
        {
            string query = "SELECT COUNT(*) FROM cards WHERE stack_id = @stackid";
            return dbconn.ExecuteScalar<int>(query, new { stackid = stack_id });
        }

        public static int UpdateStack(VocabStack modifiedstack)
        {
            DynamicParameters parameters = new DynamicParameters();
            string query = "UPDATE stacks SET name = @name, native_lang = @native_lang, foreign_lang = @foreign_lang, comment = @comment, picture = @picture WHERE id = @stackid";
            parameters.Add("name", modifiedstack.Name);
            parameters.Add("native_lang", modifiedstack.NativeLang);
            parameters.Add("foreign_lang", modifiedstack.ForeignLang);
            parameters.Add("comment", modifiedstack.Comment);
            parameters.Add("picture", ImageConversion.ImgToByte(modifiedstack.Picture));
            parameters.Add("stackid", modifiedstack.Id);
            return dbconn.ExecuteScalar<int>(query, parameters);
        }

        public static int AddStack(VocabStack modifiedstack)
        {
            DynamicParameters parameters = new DynamicParameters();
            string query = "INSERT INTO stacks (name, native_lang, foreign_lang, comment, picture) VALUES (@name, @native_lang, @foreign_lang, @comment, @picture)";
            parameters.Add("name", modifiedstack.Name);
            parameters.Add("native_lang", modifiedstack.NativeLang);
            parameters.Add("foreign_lang", modifiedstack.ForeignLang);
            parameters.Add("comment", modifiedstack.Comment);
            parameters.Add("picture", ImageConversion.ImgToByte(modifiedstack.Picture));
            return dbconn.ExecuteScalar<int>(query, parameters);
            /*string query = "INSERT INTO stacks (name, native_lang, foreign_lang, comment) VALUES ('";
            query += modifiedstack.Name + "', '";
            query += modifiedstack.NativeLang + "', '";
            query += modifiedstack.ForeignLang +"', '";
            query += modifiedstack.Comment + "')";
            //picture
            return dbconn.ExecuteScalar<int>(query);*/
        }
    }
}
