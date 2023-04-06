namespace winformbd
{
    partial class delete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deletetxt = new System.Windows.Forms.TextBox();
            this.delet = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.passworddel = new System.Windows.Forms.Label();
            this.passworddeltxt = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // deletetxt
            // 
            this.deletetxt.Location = new System.Drawing.Point(380, 120);
            this.deletetxt.Name = "deletetxt";
            this.deletetxt.Size = new System.Drawing.Size(100, 20);
            this.deletetxt.TabIndex = 0;
            // 
            // delet
            // 
            this.delet.AutoSize = true;
            this.delet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delet.Location = new System.Drawing.Point(193, 118);
            this.delet.Name = "delet";
            this.delet.Size = new System.Drawing.Size(181, 20);
            this.delet.TabIndex = 1;
            this.delet.Text = "Номер машины/регион";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(347, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passworddel
            // 
            this.passworddel.AutoSize = true;
            this.passworddel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passworddel.Location = new System.Drawing.Point(307, 174);
            this.passworddel.Name = "passworddel";
            this.passworddel.Size = new System.Drawing.Size(67, 20);
            this.passworddel.TabIndex = 3;
            this.passworddel.Text = "Пароль";
            // 
            // passworddeltxt
            // 
            this.passworddeltxt.Location = new System.Drawing.Point(380, 176);
            this.passworddeltxt.Name = "passworddeltxt";
            this.passworddeltxt.Size = new System.Drawing.Size(100, 20);
            this.passworddeltxt.TabIndex = 4;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(508, 182);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(0, 13);
            this.pass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(305, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Удалить данные";
            // 
            // regtxt
            // 
            this.regtxt.Location = new System.Drawing.Point(500, 120);
            this.regtxt.Name = "regtxt";
            this.regtxt.Size = new System.Drawing.Size(30, 20);
            this.regtxt.TabIndex = 7;
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.passworddeltxt);
            this.Controls.Add(this.passworddel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delet);
            this.Controls.Add(this.deletetxt);
            this.Name = "delete";
            this.Text = "delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox deletetxt;
        private System.Windows.Forms.Label delet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label passworddel;
        private System.Windows.Forms.TextBox passworddeltxt;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox regtxt;
    }
}