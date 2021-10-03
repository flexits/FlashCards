using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FlashCards
{
    public partial class FormStacksBrowser : Form
    {
        public FormStacksBrowser()
        {
            //https://metanit.com/sharp/adonetcore/4.1.php

            InitializeComponent();
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
            int result = reader.GetInt32(0);
            reader.Close();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            //get stack_ids from database
            //populate panel with stackitems
            int stackcounter = result;
            int[] stack_ids = new int[stackcounter];
            stack_ids[0] = 0;
            stack_ids[1] = 1;
            stack_ids[2] = 2;
            foreach (int stack_id in stack_ids)
            {
                StackItem sti = new StackItem(stack_id);
                flowLayoutPanel1.Controls.Add(sti);
            }
        }
    }
}
