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
        static SQLiteConnection dbconn = new SQLiteConnection(connstr);
        public static List<VocabStack> GetAllStacks()
        //return all existing stacks 
        {
            string query = "SELECT * FROM stacks ORDER BY name ASC";
            return dbconn.Query<VocabStack>(query).AsList();
        }

        public static int CardsCountInStack(int stack_id)
        {
            string query = "SELECT COUNT(*) FROM cards WHERE stack_id = " + stack_id;
            return dbconn.ExecuteScalar<int>(query);
        }

        public static int UpdateStack(VocabStack modifiedstack)
        {
            string query = "UPDATE stacks ";
            query += "SET name = '" + modifiedstack.Name;
            query += "', native_lang = '" + modifiedstack.NativeLang;
            query += "', foreign_lang = '" + modifiedstack.ForeignLang;
            query += "', comment = '" + modifiedstack.Comment;
            //picture
            query += "' WHERE id = " + modifiedstack.Id;
            return dbconn.ExecuteScalar<int>(query);
        }

        public static int AddStack(VocabStack modifiedstack)
        {
            string query = "INSERT INTO stacks (name, native_lang, foreign_lang, comment) VALUES ('";
            query += modifiedstack.Name + "', '";
            query += modifiedstack.NativeLang + "', '";
            query += modifiedstack.ForeignLang +"', '";
            query += modifiedstack.Comment + "')";
            //picture
            return dbconn.ExecuteScalar<int>(query);
        }

        //TODO:
        //get stack by id
        //get cards ids by stack id
        //get card by id
    }
}
