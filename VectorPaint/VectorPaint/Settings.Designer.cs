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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_form));
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
            resources.ApplyResources(this.Ok_btn, "Ok_btn");
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.UseVisualStyleBackColor = true;
            // 
            // Cancel_btn
            // 
            resources.ApplyResources(this.Cancel_btn, "Cancel_btn");
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // Lang_cb
            // 
            this.Lang_cb.FormattingEnabled = true;
            this.Lang_cb.Items.AddRange(new object[] {
            resources.GetString("Lang_cb.Items"),
            resources.GetString("Lang_cb.Items1"),
            resources.GetString("Lang_cb.Items2")});
            resources.ApplyResources(this.Lang_cb, "Lang_cb");
            this.Lang_cb.Name = "Lang_cb";
            // 
            // lang_lb
            // 
            resources.ApplyResources(this.lang_lb, "lang_lb");
            this.lang_lb.Name = "lang_lb";
            // 
            // theme_lb
            // 
            resources.ApplyResources(this.theme_lb, "theme_lb");
            this.theme_lb.Name = "theme_lb";
            // 
            // Theme_cb
            // 
            this.Theme_cb.FormattingEnabled = true;
            resources.ApplyResources(this.Theme_cb, "Theme_cb");
            this.Theme_cb.Name = "Theme_cb";
            // 
            // Settings_form
            // 
            this.AcceptButton = this.Ok_btn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Theme_cb);
            this.Controls.Add(this.theme_lb);
            this.Controls.Add(this.lang_lb);
            this.Controls.Add(this.Lang_cb);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Ok_btn);
            this.Name = "Settings_form";
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