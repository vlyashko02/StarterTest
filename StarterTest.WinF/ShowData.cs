﻿using StarterTest.BL.Model;
using System;
using System.Windows.Forms;

namespace StarterTest.WinF
{
    public partial class ShowData : Form
    {
        public User User { get; set; }
        public ShowData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new User();
            if (textBox2.Text != "")
                u.Name = textBox2.Text;
            else
                u.Name = null;
            if (textBox5.Text != "")
                u.Surname = textBox5.Text;
            else
                u.Surname = null;
            if (textBox4.Text != "")
                u.MiddleName = textBox4.Text;
            else
                u.MiddleName = null;
            u.DateTime = DateTime.Parse(dateTimePicker1.Text);
            if (textBox3.Text != "")
                u.City = textBox3.Text;
            else
                u.City = null;
            if (textBox6.Text != "")
                u.Country = textBox6.Text;
            else
                u.Country = null;

            User = u;
            Close();
        }
    }
}
