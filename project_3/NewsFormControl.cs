using Newtonsoft.Json.Linq;
using RestUtil;
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
    public partial class NewsFormControl : Form
    {
        Form parent = null;
        Rest rj = new Rest("http://ist.rit.edu/api");
        News News;


        public NewsFormControl(Form that)
        {
            InitializeComponent();
            this.parent = that;
            string news = rj.GET("/news/");
            News = JToken.Parse(news).ToObject<News>();
           // for (int i = 0; i < News.year.Count; i++)
            //{
              //  news_box.Text = News.year[i].date + News.year[i].title + News.year[i].description;
            //}
        }

        public NewsFormControl()
        {
            InitializeComponent();
        }

        private void btn_News_close_Click(object sender, EventArgs e)
        {
            parent.Visible = true;
            this.Close();
        }
    }
}
