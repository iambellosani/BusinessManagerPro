namespace Business_Manager_Pro
{
    partial class AccessControl
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.bnlogin = new System.Windows.Forms.Button();
            this.bncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(46, 34);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(329, 38);
            this.txtusername.TabIndex = 0;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(46, 108);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = 'O';
            this.txtpassword.Size = new System.Drawing.Size(329, 29);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bnlogin
            // 
            this.bnlogin.BackColor = System.Drawing.Color.White;
            this.bnlogin.Image = global::Business_Manager_Pro.Properties.Resources.tick_32;
            this.bnlogin.Location = new System.Drawing.Point(136, 156);
            this.bnlogin.Name = "bnlogin";
            this.bnlogin.Size = new System.Drawing.Size(102, 49);
            this.bnlogin.TabIndex = 4;
            this.bnlogin.UseVisualStyleBackColor = false;
            this.bnlogin.Click += new System.EventHandler(this.bnlogin_Click);
            // 
            // bncancel
            // 
            this.bncancel.BackColor = System.Drawing.Color.White;
            this.bncancel.Image = global::Business_Manager_Pro.Properties.Resources.Delete;
            this.bncancel.Location = new System.Drawing.Point(244, 156);
            this.bncancel.Name = "bncancel";
            this.bncancel.Size = new System.Drawing.Size(50, 49);
            this.bncancel.TabIndex = 5;
            this.bncancel.UseVisualStyleBackColor = false;
            this.bncancel.Click += new System.EventHandler(this.bncancel_Click);
            // 
            // AccessControl
            // 
            this.AcceptButton = this.bnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 227);
            this.ControlBox = false;
            this.Controls.Add(this.bncancel);
            this.Controls.Add(this.bnlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccessControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Access Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button bnlogin;
        private System.Windows.Forms.Button bncancel;
    }
}