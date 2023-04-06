using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace winformbd
{
	public partial class Form1 : Form
	{
		SqliteConnection connection;
		SqliteCommand cmd;
		string status = "Не готов";
		string qu;
		public Form1()
		{
			InitializeComponent();
			connection = new SqliteConnection("Data Source=dbavto.db");
		}
		private void zacaz_Click(object sender, EventArgs e)
		{	
		    qu = ("INSERT INTO 'avtodata' ('name','surname','middlname','number','mark','numberavto','region','type','status') VALUES (@name, @surname, @middlname, @number, @mark, @numberavto, @region, @type, @status)");
			cmd = new SqliteCommand(qu, connection);
			cmd.Parameters.AddWithValue("@name", nametxt.Text);
			cmd.Parameters.AddWithValue("@surname", surnametxt.Text);
			cmd.Parameters.AddWithValue("@middlname", middlnametxtbox.Text);
			cmd.Parameters.AddWithValue("@number", numberphone.Text);
			cmd.Parameters.AddWithValue("@mark", markavto.Text);
			cmd.Parameters.AddWithValue("@numberavto", numberavto.Text);
			cmd.Parameters.AddWithValue("@region", reg.Text);
			cmd.Parameters.AddWithValue("@type", type.Text);
            cmd.Parameters.AddWithValue("@status",status);
            connection.Open();
			cmd.ExecuteNonQuery();
			connection.Close();
			this.Hide();
			reg box = new reg();
			box.Show();
		}
	}
}