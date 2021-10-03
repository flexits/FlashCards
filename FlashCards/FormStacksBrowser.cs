using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using Dapper;

namespace FlashCards
{
    public partial class FormStacksBrowser : Form
    {
        public FormStacksBrowser()
        {
            InitializeComponent();

            string connstr = "Data Source=fcrd.db;Version=3;";
            string query = "SELECT * FROM stacks";
            SQLiteConnection conn = new SQLiteConnection(connstr);
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            List<VocabStack> lst = (List<VocabStack>)conn.Query<VocabStack>(query);
            foreach (VocabStack vst in lst)
            {
                StackItem sti = new StackItem(vst);
                flowLayoutPanel1.Controls.Add(sti);
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
    }
}
