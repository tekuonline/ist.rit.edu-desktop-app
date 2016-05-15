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
    public partial class UnderGradDetails : Form
    {
        Form parent = null;
        Object test;
        Minors mn;
        public UnderGradDetails(Object test, Minors mn, Form that)
        {
            InitializeComponent();
            this.parent = that;
            this.test = test;
            this.mn = mn;


            int TagNum = Int32.Parse(test.ToString()) - 1;  //subtract one as the array is 0 based
            lbl_minor_name.Text = 
               mn.UgMinors[TagNum].name;
            lbl_minor_title.Text =
               mn.UgMinors[TagNum].title;
            lbl_minor_description.Text =
               mn.UgMinors[TagNum].description;
            lbl_minor_note.Text =
              mn.UgMinors[TagNum].note;

            grid_course.BackgroundColor = Color.White;
            grid_course.RowHeadersVisible = false;
            for (int i = 0; i < mn.UgMinors[TagNum].courses.Count; i++)
            {
                grid_course.Columns.Add(null, mn.UgMinors[TagNum].courses[i]);
            }
            /*
            ListViewItem item = new ListViewItem();
            for (int i = 0; i < mn.UgMinors[TagNum].courses.Count; i++)
            {
                item.Text = mn.UgMinors[TagNum].courses[i];
                item.Tag = mn.UgMinors[TagNum].courses;
            }
            listViewMinors.Items.Add(item);
            */
        }
        public UnderGradDetails()
        {
            InitializeComponent();
        }

        private void btn_close_underGradDetails_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
