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

    static class DbOperations
    {
        static string connstr = "Data Source=fcrd.db;Version=3;";
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

        //TODO:
        //get stack by id
        //get cards ids by stack id
        //get card by id
    }



    /*
            //https://metanit.com/sharp/adonetcore/4.1.php
            string connstr = "Data Source=fcrd.db;Version=3;";
            string query = "SELECT COUNT(*) FROM stacks";
            SQLiteConnection conn = new SQLiteConnection(connstr);
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {

            }
            //long response = cmd.ExecuteScalar();
            SQLiteDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (reader.HasRows)
            {
                reader.Read();
            }
            int stackcounter = reader.GetInt32(0);
            reader.Close();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            //get stack_ids from database
            //populate panel with stackitems
            int[] stack_ids = new int[stackcounter];
            foreach (int stack_id in stack_ids)
            {
                //lets better pass the stack object instead of id!
                StackItem sti = new StackItem(stack_id);
                flowLayoutPanel1.Controls.Add(sti);
            }
            */
}
