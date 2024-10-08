namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMail = new Button();
            txtemail = new TextBox();
            txtsifre = new TextBox();
            SuspendLayout();
            // 
            // btnMail
            // 
            btnMail.Location = new Point(315, 292);
            btnMail.Name = "btnMail";
            btnMail.Size = new Size(219, 29);
            btnMail.TabIndex = 0;
            btnMail.Text = "Mail Gönder";
            btnMail.UseVisualStyleBackColor = true;
            btnMail.Click += btnMail_Click;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(324, 114);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(125, 27);
            txtemail.TabIndex = 1;
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(324, 171);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(125, 27);
            txtsifre.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtsifre);
            Controls.Add(txtemail);
            Controls.Add(btnMail);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMail;
        private TextBox txtemail;
        private TextBox txtsifre;
    }
}
