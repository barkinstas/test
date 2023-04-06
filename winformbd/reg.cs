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
	public partial class reg : Form
	{
		public reg()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 form = new Form1();
			form.Show();
		}

        private void editdata_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            edit edit = new edit();
            edit.Show();
        }

        private void deletbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            delete delete = new delete();
            delete.Show();
        }
    }
}
