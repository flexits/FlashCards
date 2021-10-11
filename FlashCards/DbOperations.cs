﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data.SqlClient;
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

        /* not needed anymore
        public static int CardsCountInStack(int stack_id)
        //return the number of cards relevant to a particular stack
        {
            string query = "SELECT COUNT(*) FROM cards WHERE stack_id = @stackid";
            return dbconn.ExecuteScalar<int>(query, new { stackid = stack_id });
        }*/

        public static List<VocabCard> GetAllCardsInStack(int stack_id)
        //return all cards relevant to a particular stack
        {
            string query = "SELECT * FROM cards WHERE stack_id = @stackid ORDER BY id ASC";
            return dbconn.Query<VocabCard>(query, new { stackid = stack_id }).AsList();
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
        //update the stack record
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
        //insert new stack record
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
