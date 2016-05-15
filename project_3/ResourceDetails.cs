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
    public partial class ResourceDetails : Form
    {


        Form parent = null;
        Resources res;
        Object tag;
        private System.Windows.Forms.Label resDeatil_type;
        private System.Windows.Forms.Label subTitle_lbl;
        private System.Windows.Forms.Label nameofPlace1;
        private System.Windows.Forms.Label place_des1;
        private System.Windows.Forms.Label nameofPlace2;
        private System.Windows.Forms.Label place_des2;
        private System.Windows.Forms.Label place_lbl;
        private System.Windows.Forms.Label lbl_advisor;
        private System.Windows.Forms.Label adv_des;
        private System.Windows.Forms.LinkLabel AdvisingFAQ;
        private System.Windows.Forms.Label professonalAdvisors;
        private System.Windows.Forms.Label fac_advisors_lbl;
        private System.Windows.Forms.DataGridView data_profAdv;
        private System.Windows.Forms.Label fac_adv_lbl;
        private System.Windows.Forms.Label lbl_Minor_Advising;
        private System.Windows.Forms.DataGridView dataGridView_minorAdvisorInformation;
        private System.Windows.Forms.Label tutorsAndLabInformation_des;
        private System.Windows.Forms.LinkLabel tutoringLabHoursLink_lbl;
        private System.Windows.Forms.Label graduateForms;
        private System.Windows.Forms.Label undergraduateForms_title;
        private System.Windows.Forms.ListBox graduateForms_list;
        private System.Windows.Forms.ListBox undergraduateForms_list;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Label desc1;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Label desc2;
        private System.Windows.Forms.Label title3;
        private System.Windows.Forms.Label desc3;
        private System.Windows.Forms.LinkLabel RITJobZoneGuidelink;
        private System.Windows.Forms.Label subSectionContent1;
        private System.Windows.Forms.PictureBox ambassadorsImageSource;
        private System.Windows.Forms.Label subSectionContent_des1;
        private System.Windows.Forms.Label subSectionContent2;
        private System.Windows.Forms.Label subSectionContent_des2;
        private System.Windows.Forms.Label subSectionContent_des3;
        private System.Windows.Forms.Label subSectionContent3;
        private System.Windows.Forms.Label subSectionContent_des4;
        private System.Windows.Forms.Label subSectionContent4;
        private System.Windows.Forms.Label subSectionContent_des5;
        private System.Windows.Forms.Label subSectionContent5;
        private System.Windows.Forms.Label subSectionContent_des6;
        private System.Windows.Forms.Label subSectionContent6;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.LinkLabel apply_lbl;

        public ResourceDetails(Object tag, Resources res, Form that)
        {
            InitializeComponent();
            this.parent = that;
            this.tag = tag;
            this.res = res;


            int TagNum = Int32.Parse(tag.ToString());

            lbl_res_detail_title.Text = res.title;


            switch (TagNum)
            {
                case 1:
                    title_lbl.Text = res.studyAbroad.title;
                    //create subtitle
                    
                    this.subTitle_lbl.Location = new System.Drawing.Point(14, 78);
                    this.subTitle_lbl.Name = "subTitle_lbl";
                    this.subTitle_lbl.Size = new System.Drawing.Size(807, 90);
                    this.subTitle_lbl.TabIndex = 7;
                    subTitle_lbl.Text = res.studyAbroad.description;

                    this.nameofPlace1.AutoSize = true;
                    this.nameofPlace1.Location = new System.Drawing.Point(16, 269);
                    this.nameofPlace1.Name = "nameofPlace1";
                    this.nameofPlace1.Size = new System.Drawing.Size(35, 13);
                    this.nameofPlace1.TabIndex = 7;
                    this.nameofPlace1.Text = "label1";
                    // 
                    // place_des1
                    // 
                    this.place_des1.Location = new System.Drawing.Point(16, 282);
                    this.place_des1.Name = "place_des1";
                    this.place_des1.Size = new System.Drawing.Size(807, 90);
                    this.place_des1.TabIndex = 8;
                    this.place_des1.Text = "label2";
                    // 
                    // nameofPlace2
                    // 
                    this.nameofPlace2.AutoSize = true;
                    this.nameofPlace2.Location = new System.Drawing.Point(16, 394);
                    this.nameofPlace2.Name = "nameofPlace2";
                    this.nameofPlace2.Size = new System.Drawing.Size(35, 13);
                    this.nameofPlace2.TabIndex = 9;
                    this.nameofPlace2.Text = "label3";
                    // 
                    // place_des2
                    // 
                    this.place_des2.Location = new System.Drawing.Point(16, 407);
                    this.place_des2.Name = "place_des2";
                    this.place_des2.Size = new System.Drawing.Size(809, 110);
                    this.place_des2.TabIndex = 10;
                    this.place_des2.Text = "label4";
                    // 
                    // place_lbl
                    // 
                    this.place_lbl.AutoSize = true;
                    this.place_lbl.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.place_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    this.place_lbl.Location = new System.Drawing.Point(12, 233);
                    this.place_lbl.Name = "place_lbl";
                    this.place_lbl.Size = new System.Drawing.Size(66, 26);
                    this.place_lbl.TabIndex = 7;
                    this.place_lbl.Text = "Places";


                    nameofPlace1.Text = res.studyAbroad.places[0].nameOfPlace;
                    nameofPlace2.Text = res.studyAbroad.places[1].nameOfPlace;
                    place_des1.Text = res.studyAbroad.places[0].description;
                    place_des2.Text = res.studyAbroad.places[1].description;
                    break;
                case 2:
                    // 
                    // tutorsAndLabInformation_des
                    // 
                    this.tutorsAndLabInformation_des.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.tutorsAndLabInformation_des.Location = new System.Drawing.Point(16, 66);
                    this.tutorsAndLabInformation_des.Name = "tutorsAndLabInformation_des";
                    this.tutorsAndLabInformation_des.Size = new System.Drawing.Size(1178, 223);
                    this.tutorsAndLabInformation_des.TabIndex = 17;
                    this.tutorsAndLabInformation_des.Text = "label1";
                    // 
                    // tutoringLabHoursLink_lbl
                    // 
                    this.tutoringLabHoursLink_lbl.AutoSize = true;
                    this.tutoringLabHoursLink_lbl.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.tutoringLabHoursLink_lbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                    this.tutoringLabHoursLink_lbl.Location = new System.Drawing.Point(15, 316);
                    this.tutoringLabHoursLink_lbl.Name = "tutoringLabHoursLink_lbl";
                    this.tutoringLabHoursLink_lbl.Size = new System.Drawing.Size(105, 24);
                    this.tutoringLabHoursLink_lbl.TabIndex = 18;
                    this.tutoringLabHoursLink_lbl.TabStop = true;
                    this.tutoringLabHoursLink_lbl.Text = "linkLabel1";
                    this.tutoringLabHoursLink_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tutoringLabHoursLink_lbl_LinkClicked);
                    title_lbl.Text = res.tutorsAndLabInformation.title;
                    tutorsAndLabInformation_des.Text = res.tutorsAndLabInformation.description;
                    tutoringLabHoursLink_lbl.Text = "Tutoring & Lab Hours";

                    //lbl_res_des2.Text = res.tutorsAndLabInformation.description;
                    //lbl_res_des2.Text = res.tutorsAndLabInformation.tutoringLabHoursLink;
                    break;
                case 3:
                    // 
                    // title1
                    // 
                    this.title1.AutoSize = true;
                    this.title1.Location = new System.Drawing.Point(19, 80);
                    this.title1.Name = "title1";
                    this.title1.Size = new System.Drawing.Size(38, 15);
                    this.title1.TabIndex = 16;
                    this.title1.Text = "label1";
                    // 
                    // desc1
                    // 
                    this.desc1.Location = new System.Drawing.Point(21, 100);
                    this.desc1.Name = "desc1";
                    this.desc1.Size = new System.Drawing.Size(1169, 173);
                    this.desc1.TabIndex = 17;
                    this.desc1.Text = "label2";
                    // 
                    // title2
                    // 
                    this.title2.AutoSize = true;
                    this.title2.Location = new System.Drawing.Point(25, 276);
                    this.title2.Name = "title2";
                    this.title2.Size = new System.Drawing.Size(38, 15);
                    this.title2.TabIndex = 18;
                    this.title2.Text = "label3";
                    // 
                    // desc2
                    // 
                    this.desc2.Location = new System.Drawing.Point(25, 295);
                    this.desc2.Name = "desc2";
                    this.desc2.Size = new System.Drawing.Size(1165, 168);
                    this.desc2.TabIndex = 19;
                    this.desc2.Text = "label4";
                    // 
                    // title3
                    // 
                    this.title3.AutoSize = true;
                    this.title3.Location = new System.Drawing.Point(25, 485);
                    this.title3.Name = "title3";
                    this.title3.Size = new System.Drawing.Size(38, 15);
                    this.title3.TabIndex = 20;
                    this.title3.Text = "label5";
                    // 
                    // desc3
                    // 
                    this.desc3.Location = new System.Drawing.Point(25, 500);
                    this.desc3.Name = "desc3";
                    this.desc3.Size = new System.Drawing.Size(1176, 133);
                    this.desc3.TabIndex = 21;
                    this.desc3.Text = "label6";
                    // 
                    // RITJobZoneGuidelink
                    // 
                    this.RITJobZoneGuidelink.AutoSize = true;
                    this.RITJobZoneGuidelink.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.RITJobZoneGuidelink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    this.RITJobZoneGuidelink.Location = new System.Drawing.Point(21, 642);
                    this.RITJobZoneGuidelink.Name = "RITJobZoneGuidelink";
                    this.RITJobZoneGuidelink.Size = new System.Drawing.Size(96, 21);
                    this.RITJobZoneGuidelink.TabIndex = 22;
                    this.RITJobZoneGuidelink.TabStop = true;
                    this.RITJobZoneGuidelink.Text = "linkLabel1";
                    this.RITJobZoneGuidelink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RITJobZoneGuidelink_LinkClicked);
                    title_lbl.Text = res.coopEnrollment.title;
                    title1.Text = res.coopEnrollment.enrollmentInformationContent[0].title;
                    title2.Text = res.coopEnrollment.enrollmentInformationContent[1].title;
                    title3.Text = res.coopEnrollment.enrollmentInformationContent[2].title;
                    desc1.Text = res.coopEnrollment.enrollmentInformationContent[0].description;
                    desc2.Text = res.coopEnrollment.enrollmentInformationContent[1].description;
                    desc3.Text = res.coopEnrollment.enrollmentInformationContent[2].description;
                    RITJobZoneGuidelink.Text = "RIT JobZone Guide";

                    break;
                case 4:
                    //this.data_profAdv = new System.Windows.Forms.DataGridView();
                    this.subTitle_lbl.Location = new System.Drawing.Point(0, 0);
                    this.subTitle_lbl.Name = "subTitle_lbl";
                    this.subTitle_lbl.Size = new System.Drawing.Size(117, 27);
                    this.subTitle_lbl.TabIndex = 0;
                    // 
                    // nameofPlace1
                    // 
                    this.nameofPlace1.Location = new System.Drawing.Point(0, 0);
                    this.nameofPlace1.Name = "nameofPlace1";
                    this.nameofPlace1.Size = new System.Drawing.Size(117, 27);
                    this.nameofPlace1.TabIndex = 3;
                    // 
                    // place_des1
                    // 
                    this.place_des1.Location = new System.Drawing.Point(0, 0);
                    this.place_des1.Name = "place_des1";
                    this.place_des1.Size = new System.Drawing.Size(117, 27);
                    this.place_des1.TabIndex = 2;
                    // 
                    // nameofPlace2
                    // 
                    this.nameofPlace2.Location = new System.Drawing.Point(0, 0);
                    this.nameofPlace2.Name = "nameofPlace2";
                    this.nameofPlace2.Size = new System.Drawing.Size(117, 27);
                    this.nameofPlace2.TabIndex = 1;
                    // 
                    // place_des2
                    // 
                    this.place_des2.Location = new System.Drawing.Point(0, 0);
                    this.place_des2.Name = "place_des2";
                    this.place_des2.Size = new System.Drawing.Size(117, 27);
                    this.place_des2.TabIndex = 0;
                    // 
                    // place_lbl
                    // 
                    this.place_lbl.Location = new System.Drawing.Point(0, 0);
                    this.place_lbl.Name = "place_lbl";
                    this.place_lbl.Size = new System.Drawing.Size(117, 27);
                    this.place_lbl.TabIndex = 0;
                    // 
                    // lbl_advisor
                    // 
                    this.lbl_advisor.AutoSize = true;
                    this.lbl_advisor.Location = new System.Drawing.Point(16, 53);
                    this.lbl_advisor.Name = "lbl_advisor";
                    this.lbl_advisor.Size = new System.Drawing.Size(0, 15);
                    this.lbl_advisor.TabIndex = 7;
                    // 
                    // adv_des
                    // 
                    this.adv_des.Location = new System.Drawing.Point(19, 68);
                    this.adv_des.Name = "adv_des";
                    this.adv_des.Size = new System.Drawing.Size(1182, 96);
                    this.adv_des.TabIndex = 8;
                    // 
                    // AdvisingFAQ
                    // 
                    this.AdvisingFAQ.AutoSize = true;
                    this.AdvisingFAQ.LinkColor = System.Drawing.Color.Violet;
                    this.AdvisingFAQ.Location = new System.Drawing.Point(19, 164);
                    this.AdvisingFAQ.Name = "AdvisingFAQ";
                    this.AdvisingFAQ.Size = new System.Drawing.Size(0, 15);
                    this.AdvisingFAQ.TabIndex = 9;
                    this.AdvisingFAQ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AdvisingFAQ_LinkClicked);
                    // 
                    // professonalAdvisors
                    // 
                    this.professonalAdvisors.AutoSize = true;
                    this.professonalAdvisors.Location = new System.Drawing.Point(19, 179);
                    this.professonalAdvisors.Name = "professonalAdvisors";
                    this.professonalAdvisors.Size = new System.Drawing.Size(0, 15);
                    this.professonalAdvisors.TabIndex = 10;
                    // 
                    // fac_advisors_lbl
                    // 
                    this.fac_advisors_lbl.AutoSize = true;
                    this.fac_advisors_lbl.Location = new System.Drawing.Point(19, 309);
                    this.fac_advisors_lbl.Name = "fac_advisors_lbl";
                    this.fac_advisors_lbl.Size = new System.Drawing.Size(0, 15);
                    this.fac_advisors_lbl.TabIndex = 12;
                    // 
                    // data_profAdv
                    // 
                    this.data_profAdv.AllowUserToAddRows = false;
                    this.data_profAdv.AllowUserToDeleteRows = false;
                    this.data_profAdv.AllowUserToResizeColumns = false;
                    this.data_profAdv.AllowUserToResizeRows = false;
                    this.data_profAdv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    this.data_profAdv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
                    this.data_profAdv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
                    this.data_profAdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    this.data_profAdv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
                    this.data_profAdv.Location = new System.Drawing.Point(19, 197);
                    this.data_profAdv.MultiSelect = false;
                    this.data_profAdv.Name = "data_profAdv";
                    this.data_profAdv.ReadOnly = true;
                    this.data_profAdv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                    this.data_profAdv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    this.data_profAdv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
                    this.data_profAdv.RowTemplate.ReadOnly = true;
                    this.data_profAdv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                    this.data_profAdv.Size = new System.Drawing.Size(1176, 91);
                    this.data_profAdv.TabIndex = 13;
                    // 
                    // fac_adv_lbl
                    // 
                    this.fac_adv_lbl.Location = new System.Drawing.Point(20, 324);
                    this.fac_adv_lbl.Name = "fac_adv_lbl";
                    this.fac_adv_lbl.Size = new System.Drawing.Size(1182, 163);
                    this.fac_adv_lbl.TabIndex = 15;
                    // 
                    // lbl_Minor_Advising
                    // 
                    this.lbl_Minor_Advising.AutoSize = true;
                    this.lbl_Minor_Advising.Location = new System.Drawing.Point(20, 500);
                    this.lbl_Minor_Advising.Name = "lbl_Minor_Advising";
                    this.lbl_Minor_Advising.Size = new System.Drawing.Size(0, 15);
                    this.lbl_Minor_Advising.TabIndex = 16;
                    // 
                    // dataGridView_minorAdvisorInformation
                    // 
                    this.dataGridView_minorAdvisorInformation.AllowUserToAddRows = false;
                    this.dataGridView_minorAdvisorInformation.AllowUserToDeleteRows = false;
                    this.dataGridView_minorAdvisorInformation.AllowUserToResizeColumns = false;
                    this.dataGridView_minorAdvisorInformation.AllowUserToResizeRows = false;
                    this.dataGridView_minorAdvisorInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                    this.dataGridView_minorAdvisorInformation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
                    this.dataGridView_minorAdvisorInformation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
                    this.dataGridView_minorAdvisorInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    this.dataGridView_minorAdvisorInformation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
                    this.dataGridView_minorAdvisorInformation.Location = new System.Drawing.Point(19, 518);
                    this.dataGridView_minorAdvisorInformation.MultiSelect = false;
                    this.dataGridView_minorAdvisorInformation.Name = "dataGridView_minorAdvisorInformation";
                    this.dataGridView_minorAdvisorInformation.ReadOnly = true;
                    this.dataGridView_minorAdvisorInformation.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                    this.dataGridView_minorAdvisorInformation.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    this.dataGridView_minorAdvisorInformation.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
                    this.dataGridView_minorAdvisorInformation.RowTemplate.ReadOnly = true;
                    this.dataGridView_minorAdvisorInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                    this.dataGridView_minorAdvisorInformation.Size = new System.Drawing.Size(1176, 157);
                    this.dataGridView_minorAdvisorInformation.TabIndex = 17;
                    title_lbl.Text = res.studentServices.title;
                    lbl_advisor.Text = res.studentServices.academicAdvisors.title;
                    adv_des.Text = res.studentServices.academicAdvisors.description;
                    AdvisingFAQ.Text = res.studentServices.academicAdvisors.faq.title;
                    data_profAdv.BackgroundColor = Color.White;
                    data_profAdv.RowHeadersVisible = false;
                    professonalAdvisors.Text = res.studentServices.professonalAdvisors.title;
                    data_profAdv.DataSource = res.studentServices.professonalAdvisors.advisorInformation;
                    fac_advisors_lbl.Text = res.studentServices.facultyAdvisors.title;
                    fac_adv_lbl.Text = res.studentServices.facultyAdvisors.description;
                    lbl_Minor_Advising.Text = res.studentServices.istMinorAdvising.title;
                    dataGridView_minorAdvisorInformation.BackgroundColor = Color.White;
                    dataGridView_minorAdvisorInformation.RowHeadersVisible = false;
                    dataGridView_minorAdvisorInformation.DataSource = res.studentServices.istMinorAdvising.minorAdvisorInformation;

                    break;
                case 5:
                    // 
                    // graduateForms
                    // 
                    this.graduateForms.AutoSize = true;
                    this.graduateForms.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.graduateForms.Location = new System.Drawing.Point(19, 74);
                    this.graduateForms.Name = "graduateForms";
                    this.graduateForms.Size = new System.Drawing.Size(62, 24);
                    this.graduateForms.TabIndex = 16;
                    this.graduateForms.Text = "label1";
                    // 
                    // undergraduateForms_title
                    // 
                    this.undergraduateForms_title.AutoSize = true;
                    this.undergraduateForms_title.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.undergraduateForms_title.Location = new System.Drawing.Point(22, 437);
                    this.undergraduateForms_title.Name = "undergraduateForms_title";
                    this.undergraduateForms_title.Size = new System.Drawing.Size(62, 24);
                    this.undergraduateForms_title.TabIndex = 17;
                    this.undergraduateForms_title.Text = "label1";
                    // 
                    // graduateForms_list
                    // 
                    this.graduateForms_list.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.graduateForms_list.FormattingEnabled = true;
                    this.graduateForms_list.ItemHeight = 22;
                    this.graduateForms_list.Location = new System.Drawing.Point(26, 101);
                    this.graduateForms_list.Name = "graduateForms_list";
                    this.graduateForms_list.Size = new System.Drawing.Size(412, 312);
                    this.graduateForms_list.TabIndex = 18;
                    this.graduateForms_list.Click += new System.EventHandler(this.graduateForms_list_Click);
                    // 
                    // undergraduateForms_list
                    // 
                    this.undergraduateForms_list.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.undergraduateForms_list.FormattingEnabled = true;
                    this.undergraduateForms_list.ItemHeight = 22;
                    this.undergraduateForms_list.Location = new System.Drawing.Point(26, 464);
                    this.undergraduateForms_list.Name = "undergraduateForms_list";
                    this.undergraduateForms_list.Size = new System.Drawing.Size(412, 224);
                    this.undergraduateForms_list.TabIndex = 19;
                    this.undergraduateForms_list.SelectedIndexChanged += new System.EventHandler(this.undergraduateForms_list_SelectedIndexChanged);
                    // 
                    title_lbl.Text = "Forms";
                    graduateForms.Text = "Graduate Forms";
                    undergraduateForms_title.Text = "Undergraduate Forms";
                    for (int i = 0; i < res.forms.graduateForms.Count; i++)
                    {
                        graduateForms_list.Items.Add(res.forms.graduateForms[i].formName);
                    }
                    for (int i = 0; i < res.forms.undergraduateForms.Count; i++)
                    {
                        undergraduateForms_list.Items.Add(res.forms.undergraduateForms[i].formName);
                    }
                    break;
                case 6:
                    // 
                    // subSectionContent1
                    // 
                    this.subSectionContent1.AutoSize = true;
                    this.subSectionContent1.Location = new System.Drawing.Point(191, 52);
                    this.subSectionContent1.Name = "subSectionContent1";
                    this.subSectionContent1.Size = new System.Drawing.Size(38, 15);
                    this.subSectionContent1.TabIndex = 16;
                    this.subSectionContent1.Text = "label1";
                    // 
                    // ambassadorsImageSource
                    // 
                    this.ambassadorsImageSource.Location = new System.Drawing.Point(3, 52);
                    this.ambassadorsImageSource.Name = "ambassadorsImageSource";
                    this.ambassadorsImageSource.Size = new System.Drawing.Size(182, 219);
                    this.ambassadorsImageSource.TabIndex = 17;
                    this.ambassadorsImageSource.TabStop = false;
                    // 
                    // subSectionContent_des1
                    // 
                    this.subSectionContent_des1.Location = new System.Drawing.Point(190, 64);
                    this.subSectionContent_des1.Name = "subSectionContent_des1";
                    this.subSectionContent_des1.Size = new System.Drawing.Size(1011, 54);
                    this.subSectionContent_des1.TabIndex = 18;
                    this.subSectionContent_des1.Text = "label1";
                    // 
                    // subSectionContent2
                    // 
                    this.subSectionContent2.AutoSize = true;
                    this.subSectionContent2.Location = new System.Drawing.Point(190, 118);
                    this.subSectionContent2.Name = "subSectionContent2";
                    this.subSectionContent2.Size = new System.Drawing.Size(38, 15);
                    this.subSectionContent2.TabIndex = 19;
                    this.subSectionContent2.Text = "label1";
                    // 
                    // subSectionContent_des2
                    // 
                    this.subSectionContent_des2.Location = new System.Drawing.Point(190, 133);
                    this.subSectionContent_des2.Name = "subSectionContent_des2";
                    this.subSectionContent_des2.Size = new System.Drawing.Size(1019, 45);
                    this.subSectionContent_des2.TabIndex = 20;
                    this.subSectionContent_des2.Text = "label3";
                    // 
                    // subSectionContent_des3
                    // 
                    this.subSectionContent_des3.Location = new System.Drawing.Point(190, 207);
                    this.subSectionContent_des3.Name = "subSectionContent_des3";
                    this.subSectionContent_des3.Size = new System.Drawing.Size(1019, 64);
                    this.subSectionContent_des3.TabIndex = 22;
                    this.subSectionContent_des3.Text = "label4";
                    // 
                    // subSectionContent3
                    // 
                    this.subSectionContent3.AutoSize = true;
                    this.subSectionContent3.Location = new System.Drawing.Point(190, 192);
                    this.subSectionContent3.Name = "subSectionContent3";
                    this.subSectionContent3.Size = new System.Drawing.Size(38, 15);
                    this.subSectionContent3.TabIndex = 21;
                    this.subSectionContent3.Text = "label1";
                    // 
                    // subSectionContent_des4
                    // 
                    this.subSectionContent_des4.Location = new System.Drawing.Point(13, 291);
                    this.subSectionContent_des4.Name = "subSectionContent_des4";
                    this.subSectionContent_des4.Size = new System.Drawing.Size(1196, 82);
                    this.subSectionContent_des4.TabIndex = 24;
                    this.subSectionContent_des4.Text = "label6";
                    // 
                    // subSectionContent4
                    // 
                    this.subSectionContent4.AutoSize = true;
                    this.subSectionContent4.Location = new System.Drawing.Point(12, 274);
                    this.subSectionContent4.Name = "subSectionContent4";
                    this.subSectionContent4.Size = new System.Drawing.Size(38, 15);
                    this.subSectionContent4.TabIndex = 23;
                    this.subSectionContent4.Text = "label1";
                    // 
                    // subSectionContent_des5
                    // 
                    this.subSectionContent_des5.Location = new System.Drawing.Point(12, 395);
                    this.subSectionContent_des5.Name = "subSectionContent_des5";
                    this.subSectionContent_des5.Size = new System.Drawing.Size(1185, 82);
                    this.subSectionContent_des5.TabIndex = 28;
                    this.subSectionContent_des5.Text = "label10";
                    // 
                    // subSectionContent5
                    // 
                    this.subSectionContent5.AutoSize = true;
                    this.subSectionContent5.Location = new System.Drawing.Point(12, 378);
                    this.subSectionContent5.Name = "subSectionContent5";
                    this.subSectionContent5.Size = new System.Drawing.Size(38, 15);
                    this.subSectionContent5.TabIndex = 27;
                    this.subSectionContent5.Text = "label1";
                    // 
                    // subSectionContent_des6
                    // 
                    this.subSectionContent_des6.Location = new System.Drawing.Point(12, 506);
                    this.subSectionContent_des6.Name = "subSectionContent_des6";
                    this.subSectionContent_des6.Size = new System.Drawing.Size(1185, 82);
                    this.subSectionContent_des6.TabIndex = 30;
                    this.subSectionContent_des6.Text = "label12";
                    // 
                    // subSectionContent6
                    // 
                    this.subSectionContent6.AutoSize = true;
                    this.subSectionContent6.Location = new System.Drawing.Point(13, 487);
                    this.subSectionContent6.Name = "subSectionContent6";
                    this.subSectionContent6.Size = new System.Drawing.Size(38, 15);
                    this.subSectionContent6.TabIndex = 29;
                    this.subSectionContent6.Text = "label1";
                    // 
                    // lbl_note
                    // 
                    this.lbl_note.AutoSize = true;
                    this.lbl_note.Location = new System.Drawing.Point(3, 667);
                    this.lbl_note.Name = "lbl_note";
                    this.lbl_note.Size = new System.Drawing.Size(38, 15);
                    this.lbl_note.TabIndex = 31;
                    this.lbl_note.Text = "label1";
                    // 
                    // apply_lbl
                    // 
                    this.apply_lbl.AutoSize = true;
                    this.apply_lbl.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.apply_lbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                    this.apply_lbl.Location = new System.Drawing.Point(472, 600);
                    this.apply_lbl.Name = "apply_lbl";
                    this.apply_lbl.Size = new System.Drawing.Size(123, 27);
                    this.apply_lbl.TabIndex = 32;
                    this.apply_lbl.TabStop = true;
                    this.apply_lbl.Text = "linkLabel1";
                    this.apply_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.apply_lbl_LinkClicked);
                    title_lbl.Text = res.studentAmbassadors.title;
                    ambassadorsImageSource.ImageLocation = res.studentAmbassadors.ambassadorsImageSource;
                    subSectionContent1.Text = res.studentAmbassadors.subSectionContent[0].title;
                    subSectionContent2.Text = res.studentAmbassadors.subSectionContent[1].title;
                    subSectionContent3.Text = res.studentAmbassadors.subSectionContent[2].title;
                    subSectionContent4.Text = res.studentAmbassadors.subSectionContent[3].title;
                    subSectionContent5.Text = res.studentAmbassadors.subSectionContent[4].title;
                    subSectionContent6.Text = res.studentAmbassadors.subSectionContent[5].title;
                    subSectionContent_des1.Text = res.studentAmbassadors.subSectionContent[0].description;
                    subSectionContent_des2.Text = res.studentAmbassadors.subSectionContent[1].description;
                    subSectionContent_des3.Text = res.studentAmbassadors.subSectionContent[2].description;
                    subSectionContent_des4.Text = res.studentAmbassadors.subSectionContent[3].description;
                    subSectionContent_des5.Text = res.studentAmbassadors.subSectionContent[4].description;
                    subSectionContent_des6.Text = res.studentAmbassadors.subSectionContent[5].description;
                    apply_lbl.Text = "Apply Today";
                    lbl_note.Text = res.studentAmbassadors.note;
                    break;
                default:
                    title_lbl.Text = "Error";
                    break;
            }


        }
        public ResourceDetails()
        {
            InitializeComponent();
        }

        private void btn_res_close_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void AdvisingFAQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Uri uri = new Uri(res.studentServices.academicAdvisors.faq.contentHref);
            form_browser br = new form_browser(uri, this);
            br.Show();
        }

        private void tutoringLabHoursLink_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Uri uri = new Uri(res.tutorsAndLabInformation.tutoringLabHoursLink);
            form_browser br = new form_browser(uri, this);
            br.Show();
        }

        private void graduateForms_list_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ist.rit.edu/"+res.forms.graduateForms[graduateForms_list.SelectedIndex].href);
        }

        private void undergraduateForms_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ist.rit.edu/" + res.forms.undergraduateForms[undergraduateForms_list.SelectedIndex].href);
        }

        private void RITJobZoneGuidelink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Uri uri = new Uri(res.coopEnrollment.RITJobZoneGuidelink);
            form_browser br = new form_browser(uri, this);
            br.Show();
        }

        private void apply_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Uri uri = new Uri(res.studentAmbassadors.applicationFormLink);
            form_browser br = new form_browser(uri, this);
            br.Show();
        }
    }
}
