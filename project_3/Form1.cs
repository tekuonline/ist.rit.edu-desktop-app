using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestUtil;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace project_3
{
    public partial class Form1 : Form
    {
        People People;
        About About;
        Degree Degree;
        Employment Employment;
        Footer Foo;
        Research Research;
        Minors Minors;
        Resources Resources;

        Rest rj = new Rest("http://ist.rit.edu/api");

        public Form1()
        {
            InitializeComponent();
            #region getData
            //get the data  
            string about = rj.GET("/about/");
            string courses = rj.GET("/courses/");
            string degree = rj.GET("/degrees/");
            string people = rj.GET("/people/");
            string research = rj.GET("/research/");
            string employment = rj.GET("/employment/");
            //convert data to objects 
            Employment = JToken.Parse(employment).ToObject<Employment>();
            About = JToken.Parse(about).ToObject<About>();
            Degree = JToken.Parse(degree).ToObject<Degree>();    
            People = JToken.Parse(people).ToObject<People>(); 
            Research = JToken.Parse(research).ToObject<Research>();
            #endregion getData
        }
        #region initial setup
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_title.Text = About.title;
            lbl_description.Text = '"' + About.description + '"';
            lbl_quote.Text = '"' + About.quote + '"';
            lbl_quoteAuthor.Text = "---" + About.quoteAuthor;

            //degree --undergrad
            lbl_undergrad_1.Text = Degree.undergraduate[0].degreeName.ToUpper();
            lbl_undergrad_2.Text = Degree.undergraduate[1].degreeName.ToUpper();
            lbl_undergrad_3.Text = Degree.undergraduate[2].degreeName.ToUpper();
            lbl_title1.Text = Degree.undergraduate[0].title;
            lbl_title2.Text = Degree.undergraduate[1].title;
            lbl_title3.Text = Degree.undergraduate[2].title;
            lbl_description1.Text = Degree.undergraduate[0].description;
            lbl_description2.Text = Degree.undergraduate[1].description;
            lbl_description3.Text = Degree.undergraduate[2].description;

            //concentrations 
            con_1_1.Text = Degree.undergraduate[0].concentrations[0];
            con_1_2.Text = Degree.undergraduate[0].concentrations[1];
            con_1_3.Text = Degree.undergraduate[0].concentrations[2];
            con_1_4.Text = Degree.undergraduate[0].concentrations[3];

            con_2_1.Text = Degree.undergraduate[1].concentrations[0];
            con_2_2.Text = Degree.undergraduate[1].concentrations[1];
            con_2_3.Text = Degree.undergraduate[1].concentrations[2];
            con_2_4.Text = Degree.undergraduate[1].concentrations[3];
            con_2_5.Text = Degree.undergraduate[1].concentrations[4];

            con_3_1.Text = Degree.undergraduate[2].concentrations[0];
            con_3_2.Text = Degree.undergraduate[2].concentrations[1];
            con_3_3.Text = Degree.undergraduate[2].concentrations[2];
            con_3_4.Text = Degree.undergraduate[2].concentrations[3];
            con_3_5.Text = Degree.undergraduate[2].concentrations[4];
            //degree --grad
            lbl_grad1.Text = Degree.graduate[0].degreeName.ToUpper();
            lbl_grad2.Text = Degree.graduate[1].degreeName.ToUpper();
            lbl_grad3.Text = Degree.graduate[2].degreeName.ToUpper();
            lbl_grad4.Text = Degree.graduate[3].degreeName.ToUpper();
            
            lbl_grad_title1.Text = Degree.graduate[0].title;
            lbl_grad_title2.Text = Degree.graduate[1].title;
            lbl_grad_title3.Text = Degree.graduate[2].title;
            lbl_AviliableCert.Text = Degree.graduate[3].title;
            
            lbl_grad_des1.Text = Degree.graduate[0].description;
            lbl_grad_des2.Text = Degree.graduate[1].description;
            lbl_grad_des3.Text = Degree.graduate[2].description;
            lbl_grad_des4.Text = Degree.graduate[3].availableCertificates[0];
            lbl_grad_des5.Text = Degree.graduate[3].availableCertificates[1];

            lbl_grad_con1_1.Text = Degree.graduate[0].concentrations[0];
            lbl_grad_con1_2.Text = Degree.graduate[0].concentrations[1];
            lbl_grad_con1_3.Text = Degree.graduate[0].concentrations[2];

            lbl_grad_con2_1.Text = Degree.graduate[1].concentrations[0];
            lbl_grad_con2_2.Text = Degree.graduate[1].concentrations[1];
            lbl_grad_con2_3.Text = Degree.graduate[1].concentrations[2];
            lbl_grad_con2_4.Text = Degree.graduate[1].concentrations[3];
            lbl_grad_con2_5.Text = Degree.graduate[1].concentrations[4];
            //lbl_grad_con2_6.Text = Degree.graduate[1].concentrations[5];

            lbl_grad_con3_1.Text = Degree.graduate[2].concentrations[0];
            lbl_grad_con3_2.Text = Degree.graduate[2].concentrations[1];
            lbl_grad_con3_3.Text = Degree.graduate[2].concentrations[2];
        }

        private void btn_con_learnMore1_Click(object sender, EventArgs e)
        {
            loadBrowser("http://wmc.rit.edu");
        }

        private void btn_con_learnMore2_Click(object sender, EventArgs e)
        {
            loadBrowser("http://hcc.rit.edu");
        }

        private void btn_con_learnMore3_Click(object sender, EventArgs e)
        {
            loadBrowser("http://cit.rit.edu");
        }
        #endregion initial setup

        #region Social tab
        private void tab_social_Enter(object sender, EventArgs e)
        {
            string footer = rj.GET("/footer/");
            Foo = JToken.Parse(footer).ToObject<Footer>();

            lbltweet.Text = Foo.social.tweet;
            lbl_tweet_by.Text = Foo.social.by;
            lbl_quick1.Text = Foo.quickLinks[0].title;
            lbl_quick2.Text = Foo.quickLinks[1].title;
            lbl_quick3.Text = Foo.quickLinks[2].title;
            lbl_quick4.Text = Foo.quickLinks[3].title;
            lbl_copyright.Text = Foo.copyright.title;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadBrowser(Foo.social.facebook);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadBrowser(Foo.social.twitter);
        }
        private void label6_Click(object sender, EventArgs e)
        {
            loadBrowser(Foo.quickLinks[1].href);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            loadBrowser(Foo.quickLinks[3].href);
        }

        private void lbl_quick1_Click(object sender, EventArgs e)
        {
            loadBrowser(Foo.quickLinks[0].href);
        }

        private void lbl_quick3_Click(object sender, EventArgs e)
        {
            loadBrowser(Foo.quickLinks[2].href);
        }

        private void lblNews_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            NewsFormControl ns = new NewsFormControl(this);
            ns.Visible = true;
        }
        #endregion Social tab

        #region Grad
        private void btn_grad_learn1_Click(object sender, EventArgs e)
        {
            loadBrowser("http://it.rit.edu");
        }

        private void btn_grad_learn2_Click(object sender, EventArgs e)
        {
            loadBrowser("http://hci.rit.edu");
        }

        private void btn_grad_learn3_Click(object sender, EventArgs e)
        {
            loadBrowser("http://nsa.rit.edu");
        }

        private void btn_grad_learn4_Click(object sender, EventArgs e)
        {
            loadBrowser("http://www.rit.edu/programs/networking-planning-and-design-adv-cert");
           
        }
        private void btn_grad_learn5_Click(object sender, EventArgs e)
        {
            loadBrowser("http://www.rit.edu/programs/web-development-adv-cert");
        }


        #endregion Grad

        #region Minors
        //minor enter 

        private void tab_underMinor_Enter(object sender, EventArgs e)
        {
            string minors = rj.GET("/minors/");
            Minors = JToken.Parse(minors).ToObject<Minors>();
            lbl_min_name1.Text = Minors.UgMinors[0].name;
            lbl_min_title1.Text = Minors.UgMinors[0].title;
            lbl_min_name2.Text = Minors.UgMinors[1].name;
            lbl_min_title2.Text = Minors.UgMinors[1].title;
            lbl_min_name3.Text = Minors.UgMinors[2].name;
            lbl_min_title3.Text = Minors.UgMinors[2].title;
            lbl_min_name4.Text = Minors.UgMinors[3].name;
            lbl_min_title4.Text = Minors.UgMinors[3].title;
            lbl_min_name5.Text = Minors.UgMinors[4].name;
            lbl_min_title5.Text = Minors.UgMinors[4].title;
            lbl_min_name6.Text = Minors.UgMinors[5].name;
            lbl_min_title6.Text = Minors.UgMinors[5].title;
            lbl_min_name7.Text = Minors.UgMinors[6].name;
            lbl_min_title7.Text = Minors.UgMinors[6].title;
            lbl_min_name8.Text = Minors.UgMinors[7].name;
            lbl_min_title8.Text = Minors.UgMinors[7].title;

        }
       

       
   
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            openUgradMinor(pictureBox12.Tag);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            openUgradMinor(pictureBox14.Tag);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            openUgradMinor(pictureBox13.Tag);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            openUgradMinor(pictureBox15.Tag);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            openUgradMinor(pictureBox17.Tag);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            openUgradMinor(pictureBox18.Tag);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            openUgradMinor(pictureBox19.Tag);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {  
            openUgradMinor(pictureBox16.Tag);   
        }
        #endregion Minors

        #region resources
        private void tab_resources_Enter(object sender, EventArgs e)
        {
            string resources = rj.GET("/resources/");

            Resources = JToken.Parse(resources).ToObject<Resources>();

            lbl_res1.Text = Resources.studyAbroad.title;
            lbl_res2.Text = Resources.tutorsAndLabInformation.title;
            lbl_res3.Text = Resources.coopEnrollment.title;
            lbl_res4.Text = Resources.studentServices.title;
            lbl_res5.Text = "Forms";
            lbl_res6.Text = Resources.studentAmbassadors.title;
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            openresource(pnl_res1.Tag);

        }
        private void pnl_res3_Click(object sender, EventArgs e)
        {
            openresource(pnl_res3.Tag);
        }

        private void pnl_res5_Click(object sender, EventArgs e)
        {
            openresource(pnl_res5.Tag);
        }

        private void pnl_res6_Click(object sender, EventArgs e)
        {
            openresource(pnl_res6.Tag);
        }

        private void pnl_res4_Click(object sender, EventArgs e)
        {
            openresource(pnl_res4.Tag);
        }

        private void pnl_res2_Click(object sender, EventArgs e)
        {
            openresource(pnl_res2.Tag);
        }
        #endregion resources

        #region Statstics
        private void tab_stat_Enter(object sender, EventArgs e)
        { 
            lbl_stat_title.Text = Employment.introduction.title;
            lbl_stat_emp_des.Text = Employment.introduction.content[0].description;
            lbl_stat_employment.Text = Employment.introduction.content[0].title;
            lbl_stat_coop_des.Text = Employment.introduction.content[1].description;
            lbl_stat_coop_tile.Text = Employment.introduction.content[1].title;

            lbl_stat_1_1.Text = Employment.degreeStatistics.statistics[0].value;
            lbl_stat_1_2.Text = Employment.degreeStatistics.statistics[0].description;
            lbl_stat_2_1.Text = Employment.degreeStatistics.statistics[1].value;
            lbl_stat_2_2.Text = Employment.degreeStatistics.statistics[1].description;
            lbl_stat_3_1.Text = Employment.degreeStatistics.statistics[2].value + "%";
            lbl_stat_3_2.Text = Employment.degreeStatistics.statistics[2].description;
            lbl_stat_4_1.Text = Employment.degreeStatistics.statistics[3].value;
            lbl_stat_4_2.Text = Employment.degreeStatistics.statistics[3].description;

            emp_grid.BackgroundColor = Color.White;
            emp_grid.RowHeadersVisible = false;
            coop_grid.BackgroundColor = Color.White;
            coop_grid.RowHeadersVisible = false;
            emp_grid.Columns.Clear();
            coop_grid.Columns.Clear();
            for (int i = 0; i < Employment.employers.employerNames.Count; i++)
            {
                emp_grid.Columns.Add(null, Employment.employers.employerNames[i]);
            }
            for (int i = 0; i < Employment.careers.careerNames.Count; i++)
            {
                coop_grid.Columns.Add(null, Employment.careers.careerNames[i]);
            }
        }
        #endregion Statstics

        #region Staff
        private void Test_Enter(object sender, EventArgs e)
        {
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.DataSource = People.staff;
            dataGridView2.Columns["username"].Visible = false;
            dataGridView2.Columns["twitter"].Visible = false;
            dataGridView2.Columns["facebook"].Visible = false;
            dataGridView2.Columns["tagline"].Visible = false;
            dataGridView2.Columns["imagepath"].Visible = false;
            dataGridView2.Columns["website"].Visible = false;
            dataGridView2.Columns["interestarea"].Visible = false;    
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex == -1) return;
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
            {
                OpenFaculty_Staff_Details(e.RowIndex, "faculty");
            }
        }
        

        private void tabControlStaffFAC_Enter(object sender, EventArgs e)
        {   
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (dataGridView2.CurrentCell != null && dataGridView2.CurrentCell.Value != null)
            {
                OpenFaculty_Staff_Details(e.RowIndex, "staff");
            }
        }
        #endregion Staff

        #region Faculty

        private void tab_people_Enter(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DataSource = People.faculty;
            dataGridView1.Columns["username"].Visible = false;
            dataGridView1.Columns["twitter"].Visible = false;
            dataGridView1.Columns["facebook"].Visible = false;
            dataGridView1.Columns["tagline"].Visible = false;
            dataGridView1.Columns["imagepath"].Visible = false;
            dataGridView1.Columns["website"].Visible = false;
            dataGridView1.Columns["interestarea"].Visible = false;
        }
        #endregion Faculty

        #region Employment
        private void tabPage2_Enter(object sender, EventArgs e)
        {
            dataGridemp.BackgroundColor = Color.White;
            dataGridemp.RowHeadersVisible = false;
            dataGridemp.DataSource = Employment.employmentTable.professionalEmploymentInformation;
        }

        private void tab_employment_Enter(object sender, EventArgs e)
        {
            dataGrid_coop.BackgroundColor = Color.White;
            dataGrid_coop.RowHeadersVisible = false;
            dataGrid_coop.DataSource = Employment.coopTable.coopInformation;
        }
        #endregion Employment

        #region Research

        private void tab_research_Enter(object sender, EventArgs e)
        {
            lookUpByInterest.Items.Clear();
            lookUp_byFac.Items.Clear();
            for (int i = 0; i < Research.byFaculty.Count; i++)
            {
                lookUp_byFac.Items.Add(Research.byFaculty[i].facultyName);
            }

            for (int i = 0; i < Research.byInterestArea.Count; i++)
            {
                lookUpByInterest.Items.Add(Research.byInterestArea[i].areaName);
            }

        }
        private void lookUp_byFac_Click(object sender, EventArgs e)
        {
            LoadResaarch(lookUp_byFac.SelectedIndex, "faculty");
        }

        private void lookUpByInterest_Click(object sender, EventArgs e)
        {
            if (lookUpByInterest.SelectedIndex != -1)
            {
                LoadResaarch(lookUpByInterest.SelectedIndex, "interest");
            }
            else {
            }
        }
        #endregion Research

        #region helper methods
        //helper method to load research details
        public void LoadResaarch(int id, String type)
        {
            this.Visible = false;
            ResearchDetails researchDetails = new ResearchDetails(id, Research, this, type);
            researchDetails.Show();
        }
        public void loadBrowser(String URL)
        {
            this.Visible = false;
            Uri uri = new Uri(URL);
            form_browser br = new form_browser(uri, this);
            br.Visible = true;
        }
        //Helper Method to open underGraduate minor detail
        public void openUgradMinor(Object id)
        {
            this.Visible = false;
            UnderGradDetails ugrad = new UnderGradDetails(id, Minors, this);
            ugrad.Visible = true;
        }
        //Helper Method to open OpenFaculty_Staff_Details
        private void OpenFaculty_Staff_Details(int id, String facStaff)
        {
            this.Visible = false;
            Faculty_Staff_Details fs = new Faculty_Staff_Details(id, People, this, facStaff);
            fs.Visible = true;
        }
        //Helper Method to open resource details page
        private void openresource(Object id)
        {
            this.Visible = false;
            ResourceDetails rd = new ResourceDetails(id, Resources, this);
            rd.Visible = true;
        }
        //clean the nulls?
        private string clean(string sent)
        {
            return (sent == "null") ? "" : sent;
        }

        #endregion helper methods

        #region copyright
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadBrowser("http://www.rit.edu/copyright.html");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadBrowser("http://www.rit.edu/nondiscrimination.html");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadBrowser("http://www.rit.edu/privacystatement.html");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadBrowser("http://www.rit.edu/disclaimer.html");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadBrowser("http://www.rit.edu/");
        }
        #endregion copyright
         
        #region menuItemAbout
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            this.SendToBack();
            ab.ShowDialog();
        }
        //exit button click 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion menuItemAbout

        #region ExtraClicks
        //click on main title label to open IST website on browser!
        private void label1_Click(object sender, EventArgs e)
        {
            loadBrowser("http://ist.rit.edu");
        }

        private void label15_Click(object sender, EventArgs e)
        {
            loadBrowser("http://www.rit.edu/ask/");
        }
        #endregion ExtraClicks

        #region Contact
        private void tabContact_Enter(object sender, EventArgs e)
        {
            Uri ur = new Uri("http://ist.rit.edu/api/contactForm/");
            webBrowser2.Url = ur;
        }
        #endregion Contact

        private void lbl_grad3_Click(object sender, EventArgs e)
        {

        }
    }

}
