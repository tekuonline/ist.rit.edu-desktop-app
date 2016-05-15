namespace project_3
{
    partial class UnderGradDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_minor_name = new System.Windows.Forms.Label();
            this.btn_close_underGradDetails = new System.Windows.Forms.Button();
            this.lbl_minor_title = new System.Windows.Forms.Label();
            this.lbl_minor_description = new System.Windows.Forms.Label();
            this.lbl_minor_note = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grid_course = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_course)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_minor_name
            // 
            this.lbl_minor_name.AutoSize = true;
            this.lbl_minor_name.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minor_name.Location = new System.Drawing.Point(326, 9);
            this.lbl_minor_name.Name = "lbl_minor_name";
            this.lbl_minor_name.Size = new System.Drawing.Size(0, 21);
            this.lbl_minor_name.TabIndex = 0;
            // 
            // btn_close_underGradDetails
            // 
            this.btn_close_underGradDetails.Location = new System.Drawing.Point(381, 588);
            this.btn_close_underGradDetails.Name = "btn_close_underGradDetails";
            this.btn_close_underGradDetails.Size = new System.Drawing.Size(75, 23);
            this.btn_close_underGradDetails.TabIndex = 1;
            this.btn_close_underGradDetails.Text = "Done";
            this.btn_close_underGradDetails.UseVisualStyleBackColor = true;
            this.btn_close_underGradDetails.Click += new System.EventHandler(this.btn_close_underGradDetails_Click);
            // 
            // lbl_minor_title
            // 
            this.lbl_minor_title.Location = new System.Drawing.Point(12, 30);
            this.lbl_minor_title.Name = "lbl_minor_title";
            this.lbl_minor_title.Size = new System.Drawing.Size(771, 29);
            this.lbl_minor_title.TabIndex = 2;
            this.lbl_minor_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_minor_description
            // 
            this.lbl_minor_description.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minor_description.Location = new System.Drawing.Point(12, 50);
            this.lbl_minor_description.Name = "lbl_minor_description";
            this.lbl_minor_description.Size = new System.Drawing.Size(771, 295);
            this.lbl_minor_description.TabIndex = 3;
            // 
            // lbl_minor_note
            // 
            this.lbl_minor_note.Location = new System.Drawing.Point(12, 523);
            this.lbl_minor_note.Name = "lbl_minor_note";
            this.lbl_minor_note.Size = new System.Drawing.Size(768, 62);
            this.lbl_minor_note.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Courses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Note:";
            // 
            // grid_course
            // 
            this.grid_course.AllowUserToResizeColumns = false;
            this.grid_course.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grid_course.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_course.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid_course.BackgroundColor = System.Drawing.Color.Silver;
            this.grid_course.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_course.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_course.Cursor = System.Windows.Forms.Cursors.Help;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_course.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_course.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid_course.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.grid_course.Location = new System.Drawing.Point(0, 379);
            this.grid_course.Name = "grid_course";
            this.grid_course.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_course.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_course.RowHeadersWidth = 44;
            this.grid_course.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.grid_course.RowTemplate.ReadOnly = true;
            this.grid_course.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid_course.Size = new System.Drawing.Size(793, 45);
            this.grid_course.TabIndex = 14;
            // 
            // UnderGradDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(795, 623);
            this.ControlBox = false;
            this.Controls.Add(this.grid_course);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_minor_note);
            this.Controls.Add(this.lbl_minor_description);
            this.Controls.Add(this.lbl_minor_title);
            this.Controls.Add(this.btn_close_underGradDetails);
            this.Controls.Add(this.lbl_minor_name);
            this.Name = "UnderGradDetails";
            this.ShowIcon = false;
            this.Text = "UnderGradDetails";
            ((System.ComponentModel.ISupportInitialize)(this.grid_course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_minor_name;
        private System.Windows.Forms.Button btn_close_underGradDetails;
        private System.Windows.Forms.Label lbl_minor_title;
        private System.Windows.Forms.Label lbl_minor_description;
        private System.Windows.Forms.Label lbl_minor_note;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grid_course;
    }
}