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
    public partial class Faculty_Staff_Details : Form
    {
        Form parent = null;
        int id;
        People p;
        String facStaff;
        public Faculty_Staff_Details(int id, People p, Form that, string facStaff)
        {
            InitializeComponent();
            this.parent = that;
            this.id = id;
            this.p = p;
            this.facStaff = facStaff;
            if (facStaff.Equals("faculty"))
            {
                loadStufffac();
            }
            else
            {
                loadStuffstaff();
            }
            
        }
        public Faculty_Staff_Details()
        {
            InitializeComponent();
        }

        private void btndone_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
        private void loadStufffac()
        {
            lbl_name.Text = p.faculty[id].name;
            lbl_about.Text = p.faculty[id].tagline;
            lbl_email.Text = p.faculty[id].email;
            lbl_phone.Text = p.faculty[id].phone;
            lbl_office.Text = p.faculty[id].office;
            lbl_title.Text = p.faculty[id].title;
            lbl_website.Text = p.faculty[id].website;
            Pic_box.ImageLocation = p.faculty[id].imagePath;
            InterestArea_lbl.Text = p.faculty[id].interestArea;

        }
        private void loadStuffstaff()
        {
            lbl_name.Text = p.staff[id].name;
            lbl_about.Text = p.staff[id].tagline;
            lbl_email.Text = p.staff[id].email;
            lbl_phone.Text = p.staff[id].phone;
            lbl_office.Text = p.staff[id].office;
            lbl_title.Text = p.staff[id].title;
            lbl_website.Text = p.staff[id].website;
            Pic_box.ImageLocation = p.staff[id].imagePath;
            InterestArea_lbl.Text = p.staff[id].interestArea;

        }

        private void picture_facebook_Click(object sender, EventArgs e)
        {
            if (facStaff.Equals("faculty"))
            {
                loadBrowser("https://www.facebook.com/" + p.faculty[id].facebook);
            }
            else
            {
                loadBrowser("https://www.facebook.com/" + p.staff[id].facebook);
            }
        }

        public void loadBrowser(String URL)
        {
            this.Visible = false;
            Uri uri = new Uri(URL);
            form_browser br = new form_browser(uri, this);
            br.Visible = true;
        }

        private void picture_twitte_Click(object sender, EventArgs e)
        {
            if (facStaff.Equals("faculty"))
            {
                loadBrowser("https://twitter.com/" + p.faculty[id].twitter);
            }
            else
            {
                loadBrowser("https://twitter.com/" + p.staff[id].twitter);
            }
        }
    }
}
