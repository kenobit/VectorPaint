namespace VectorPaint
{
    partial class Settings_form
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
            this.Ok_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Lang_cb = new System.Windows.Forms.ComboBox();
            this.lang_lb = new System.Windows.Forms.Label();
            this.theme_lb = new System.Windows.Forms.Label();
            this.Theme_cb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Ok_btn
            // 
            this.Ok_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok_btn.Location = new System.Drawing.Point(197, 111);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(75, 23);
            this.Ok_btn.TabIndex = 0;
            this.Ok_btn.Text = "Ok";
            this.Ok_btn.UseVisualStyleBackColor = true;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(12, 111);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.Cancel_btn.TabIndex = 1;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Lang_cb
            // 
            this.Lang_cb.FormattingEnabled = true;
            this.Lang_cb.Location = new System.Drawing.Point(132, 12);
            this.Lang_cb.Name = "Lang_cb";
            this.Lang_cb.Size = new System.Drawing.Size(140, 21);
            this.Lang_cb.TabIndex = 2;
            // 
            // lang_lb
            // 
            this.lang_lb.AutoSize = true;
            this.lang_lb.Location = new System.Drawing.Point(12, 15);
            this.lang_lb.Name = "lang_lb";
            this.lang_lb.Size = new System.Drawing.Size(88, 13);
            this.lang_lb.TabIndex = 3;
            this.lang_lb.Text = "System language";
            // 
            // theme_lb
            // 
            this.theme_lb.AutoSize = true;
            this.theme_lb.Location = new System.Drawing.Point(15, 49);
            this.theme_lb.Name = "theme_lb";
            this.theme_lb.Size = new System.Drawing.Size(40, 13);
            this.theme_lb.TabIndex = 4;
            this.theme_lb.Text = "Theme";
            // 
            // Theme_cb
            // 
            this.Theme_cb.FormattingEnabled = true;
            this.Theme_cb.Location = new System.Drawing.Point(132, 46);
            this.Theme_cb.Name = "Theme_cb";
            this.Theme_cb.Size = new System.Drawing.Size(140, 21);
            this.Theme_cb.TabIndex = 5;
            // 
            // Settings_form
            // 
            this.AcceptButton = this.Ok_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 148);
            this.Controls.Add(this.Theme_cb);
            this.Controls.Add(this.theme_lb);
            this.Controls.Add(this.lang_lb);
            this.Controls.Add(this.Lang_cb);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Ok_btn);
            this.Name = "Settings_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.ComboBox Lang_cb;
        private System.Windows.Forms.Label lang_lb;
        private System.Windows.Forms.Label theme_lb;
        private System.Windows.Forms.ComboBox Theme_cb;
    }
}