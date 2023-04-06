using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformbd
{
    public partial class delete : Form
    {
        SqliteConnection connection;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public delete()
        {
            InitializeComponent();
            connection = new SqliteConnection("Data Source=dbavto.db");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passworddeltxt.Text == "123")
            {
                qu = $"DELETE FROM avtodata WHERE numberavto='{deletetxt.Text}',region='{regtxt}'";
                cmd = new SqliteCommand(qu, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                this.Hide();
                reg box = new reg();
                box.Show();
            }
            else 
            {
                pass.Text = "Не верный пароль";
            }
        }
    }
}