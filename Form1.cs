using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkTracker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Label temp = new Label();
            temp.Text = "You clicked a button";
            temp.Size = new System.Drawing.Size(600, 20);
            temp.Location = new System.Drawing.Point(10, this.CompletedPanel.Controls.Count * 20);
            this.CompletedPanel.Controls.Add(temp);
        }

        private void Demo_Click(object sender, EventArgs e)
        {

            this.Demo.Visible = false;

            Label temp = new Label();
            temp.Text = "CS 3300";
            this.CourseDropDown.Items.Add(temp.Text);
            temp.Text = "CS 4100";
            this.CourseDropDown.Items.Add(temp.Text);
            temp.Text = "HUM 3990";
            this.CourseDropDown.Items.Add(temp.Text);
            temp.Text = "Standard";
            this.SortDropDown.Items.Add(temp.Text);
            this.SortDropDown.Text = temp.Text;

            this.CourseDropDown.Text = "CS 3300";
            temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            temp.Size = new System.Drawing.Size(600, 20);
            temp.Text = "Project Ideas                                Software                 Sep  6, 2019                On-Time";
            temp.Location = new System.Drawing.Point(10, this.CompletedPanel.Controls.Count * 30);

            this.CompletedPanel.Controls.Add(temp);
            Label temp1 = new Label();
            temp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            temp1.Text = "Project Concept/Charter             Software                 Sep 24, 2019               On-Time";
            temp1.Location = new System.Drawing.Point(10, this.CompletedPanel.Controls.Count * 30);
            temp1.Size = new System.Drawing.Size(600, 20);
            this.CompletedPanel.Controls.Add(temp1);

            Label temp2 = new Label();
            temp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            temp2.Text = "Cosine Project                              Pre-Calc                  Oct   5, 2019                Late!";
            temp2.Location = new System.Drawing.Point(10, this.CompletedPanel.Controls.Count * 30);
            temp2.Size = new System.Drawing.Size(600, 20);
            this.CompletedPanel.Controls.Add(temp2);

            Label temp3 = new Label();
            temp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            temp3.Text = "Project SDD Presentation                       Software                  Nov   5, 2019        Late!";
            temp3.Location = new System.Drawing.Point(10, this.HomeworkPanel.Controls.Count * 30);
            temp3.Size = new System.Drawing.Size(600, 20);
            this.HomeworkPanel.Controls.Add(temp3);
        }
    }
}
