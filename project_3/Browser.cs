using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_3
{
    
    public partial class form_browser : Form
    {
        Uri Url = null;
        Form parent = null;
       
        public form_browser(Uri url, Form that)
        {
            InitializeComponent();
            this.Url = url;
            this.parent = that;
            webBrowser1.Url = Url;
           
        }

        public form_browser()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btn_Browser_close_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
            //Form1 f1 = new Form1();
           // f1.Visible = true;
        }
    }
}
