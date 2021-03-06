﻿using StarterTest.BL.Model;
using System;
using System.Windows.Forms;

namespace StarterTest.WinF
{
    public partial class FormAddOrChangeUser : Form
    {
        public User User { get; set; }
        public FormAddOrChangeUser()
        {
            InitializeComponent();
        }

        public FormAddOrChangeUser(User user) : this()
        {
            User = user;
            dateTimePicker1.Text = user.DateTime.ToString("dd.MM.yyyy");
            textBox2.Text = user.Name;
            textBox5.Text = user.Surname;
            textBox4.Text = user.MiddleName;
            textBox3.Text = user.City;
            textBox6.Text = user.Country;
        }

        void button1_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void SaveChanges()
        {
            var u = User ?? new User();

            u.DateTime = DateTime.Parse(dateTimePicker1.Text);
            u.Name = textBox2.Text;
            u.Surname = textBox5.Text;
            u.MiddleName = textBox4.Text;
            u.City = textBox3.Text;
            u.Country = textBox6.Text;

            User = u;

            Close();
        }

        void textBoxLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b')
            {
                e.Handled = true;
            }
        }

        void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        bool TryParseDate(string date)
        {
            try
            {
                DateTime.Parse(date);
                return true;
            }
            catch
            {
                MessageBox.Show("Дата введена неверно.\nНеобходимый формат даты:\ndd.mm.yyyy\nЗапись не будет добавлена.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
