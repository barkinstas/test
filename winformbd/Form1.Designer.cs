namespace winformbd
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.zacaz = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.middlname = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.surnametxt = new System.Windows.Forms.TextBox();
            this.middlnametxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberphone = new System.Windows.Forms.TextBox();
            this.markavto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberavto = new System.Windows.Forms.TextBox();
            this.reg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zacaz
            // 
            this.zacaz.Location = new System.Drawing.Point(586, 492);
            this.zacaz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zacaz.Name = "zacaz";
            this.zacaz.Size = new System.Drawing.Size(112, 35);
            this.zacaz.TabIndex = 0;
            this.zacaz.Text = "Заказать";
            this.zacaz.UseVisualStyleBackColor = true;
            this.zacaz.Click += new System.EventHandler(this.zacaz_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(158, 43);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(40, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Имя";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.Location = new System.Drawing.Point(117, 92);
            this.surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(81, 20);
            this.surname.TabIndex = 2;
            this.surname.Text = "Фамилия";
            // 
            // middlname
            // 
            this.middlname.AutoSize = true;
            this.middlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middlname.Location = new System.Drawing.Point(120, 175);
            this.middlname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.middlname.Name = "middlname";
            this.middlname.Size = new System.Drawing.Size(83, 20);
            this.middlname.TabIndex = 3;
            this.middlname.Text = "Отчество";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(231, 38);
            this.nametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(148, 26);
            this.nametxt.TabIndex = 4;
            // 
            // surnametxt
            // 
            this.surnametxt.Location = new System.Drawing.Point(231, 106);
            this.surnametxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.surnametxt.Name = "surnametxt";
            this.surnametxt.Size = new System.Drawing.Size(148, 26);
            this.surnametxt.TabIndex = 5;
            // 
            // middlnametxtbox
            // 
            this.middlnametxtbox.Location = new System.Drawing.Point(231, 175);
            this.middlnametxtbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.middlnametxtbox.Name = "middlnametxtbox";
            this.middlnametxtbox.Size = new System.Drawing.Size(148, 26);
            this.middlnametxtbox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Номер телефона";
            // 
            // numberphone
            // 
            this.numberphone.Location = new System.Drawing.Point(231, 240);
            this.numberphone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberphone.Name = "numberphone";
            this.numberphone.Size = new System.Drawing.Size(148, 26);
            this.numberphone.TabIndex = 8;
            // 
            // markavto
            // 
            this.markavto.Location = new System.Drawing.Point(231, 302);
            this.markavto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.markavto.Name = "markavto";
            this.markavto.Size = new System.Drawing.Size(148, 26);
            this.markavto.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(74, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Марка машины";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(62, 374);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Номер машины/регион";
            // 
            // numberavto
            // 
            this.numberavto.Location = new System.Drawing.Point(260, 374);
            this.numberavto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberavto.Name = "numberavto";
            this.numberavto.Size = new System.Drawing.Size(148, 26);
            this.numberavto.TabIndex = 12;
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(418, 374);
            this.reg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(48, 26);
            this.reg.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(92, 438);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Тип поломки";
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(210, 438);
            this.type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.type.Multiline = true;
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(148, 20);
            this.type.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.numberavto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.markavto);
            this.Controls.Add(this.numberphone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.middlnametxtbox);
            this.Controls.Add(this.surnametxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.middlname);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.zacaz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button zacaz;
		private System.Windows.Forms.Label name;
		private System.Windows.Forms.Label surname;
		private System.Windows.Forms.Label middlname;
		private System.Windows.Forms.TextBox nametxt;
		private System.Windows.Forms.TextBox surnametxt;
		private System.Windows.Forms.TextBox middlnametxtbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox numberphone;
		private System.Windows.Forms.TextBox markavto;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox numberavto;
		private System.Windows.Forms.TextBox reg;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox type;
	}
}

