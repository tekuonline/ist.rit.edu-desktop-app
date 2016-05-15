namespace project_3
{
    partial class form_browser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btn_Browser_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 13);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1233, 630);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // btn_Browser_close
            // 
            this.btn_Browser_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Browser_close.Location = new System.Drawing.Point(537, 655);
            this.btn_Browser_close.Name = "btn_Browser_close";
            this.btn_Browser_close.Size = new System.Drawing.Size(163, 23);
            this.btn_Browser_close.TabIndex = 1;
            this.btn_Browser_close.Text = "Close";
            this.btn_Browser_close.UseVisualStyleBackColor = true;
            this.btn_Browser_close.Click += new System.EventHandler(this.btn_Browser_close_Click);
            // 
            // form_browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Browser_close;
            this.ClientSize = new System.Drawing.Size(1239, 690);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Browser_close);
            this.Controls.Add(this.webBrowser1);
            this.Name = "form_browser";
            this.ShowIcon = false;
            this.Text = "Browser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn_Browser_close;
    }
}