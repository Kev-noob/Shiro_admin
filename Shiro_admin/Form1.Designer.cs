namespace Super_Admin_Rolly
{
    partial class Form1
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
            this.ID_ = new System.Windows.Forms.TextBox();
            this.Password_ = new System.Windows.Forms.TextBox();
            this.Login_ = new System.Windows.Forms.Button();
            this.Close_ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_
            // 
            this.ID_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_.Location = new System.Drawing.Point(38, 244);
            this.ID_.Multiline = true;
            this.ID_.Name = "ID_";
            this.ID_.Size = new System.Drawing.Size(292, 28);
            this.ID_.TabIndex = 2;
            // 
            // Password_
            // 
            this.Password_.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_.Location = new System.Drawing.Point(38, 350);
            this.Password_.Multiline = true;
            this.Password_.Name = "Password_";
            this.Password_.Size = new System.Drawing.Size(292, 28);
            this.Password_.TabIndex = 4;
            // 
            // Login_
            // 
            this.Login_.BackColor = System.Drawing.Color.Transparent;
            this.Login_.FlatAppearance.BorderSize = 0;
            this.Login_.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Login_.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Login_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_.ForeColor = System.Drawing.Color.Black;
            this.Login_.Location = new System.Drawing.Point(118, 435);
            this.Login_.Name = "Login_";
            this.Login_.Size = new System.Drawing.Size(140, 90);
            this.Login_.TabIndex = 6;
            this.Login_.Text = "Login";
            this.Login_.UseVisualStyleBackColor = false;
            this.Login_.Click += new System.EventHandler(this.Login__Click);
            // 
            // Close_
            // 
            this.Close_.BackColor = System.Drawing.Color.Transparent;
            this.Close_.BackgroundImage = global::Super_Admin_Rolly.Properties.Resources.close_red;
            this.Close_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close_.FlatAppearance.BorderSize = 0;
            this.Close_.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Close_.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Close_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_.Location = new System.Drawing.Point(868, 2);
            this.Close_.Name = "Close_";
            this.Close_.Size = new System.Drawing.Size(32, 33);
            this.Close_.TabIndex = 7;
            this.Close_.UseVisualStyleBackColor = false;
            this.Close_.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Admin ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Admin Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(78, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "ADMIN LOGIN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Super_Admin_Rolly.Properties.Resources.form_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close_);
            this.Controls.Add(this.Login_);
            this.Controls.Add(this.Password_);
            this.Controls.Add(this.ID_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ID_;
        private System.Windows.Forms.TextBox Password_;
        private System.Windows.Forms.Button Login_;
        private System.Windows.Forms.Button Close_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

