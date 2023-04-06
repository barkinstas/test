using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace winformbd
{
	public partial class edit : Form
	{
        SqliteCommand cmd;
        SqliteConnection connection;
		public edit()
		{
			InitializeComponent();
			connection = new SqliteConnection("Data Source=dbavto.db");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (password.Text == "123")
			{
                string qu = $"UPDATE avtodata SET name ='{nametxt.Text}',surname ='{surnametxt.Text}', middlname = '{middlname.Text}',number = '{numberphone.Text}',mark = '{marktxt.Text}',numberavto = '{numberavto.Text}',region = '{regiontxt.Text}',type = '{typetxt.Text}' WHERE numberavto ='{numberavto.Text}'";
				cmd = new SqliteCommand(qu, connection);
				connection.Open();
				cmd.ExecuteNonQuery();
				connection.Close();
				MessageBox.Show("Данные изменены");
				this.Hide();
				reg box = new reg();
				box.Show();
			}
			else 
			{
				txt.Text = string.Format("Не верный пароль"); 
			}
		}
	}
}
