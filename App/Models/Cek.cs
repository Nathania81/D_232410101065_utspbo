﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace B_232410101065.App.Model
{
    internal class M_Login
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
    }
}
Form 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COBA2.App.Model;
using COBA2.App.Context;

namespace COBA2
{
    public partial class Form1 : Form
    {
        private string username;
        private string password;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox3.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Masukkan username dan password terlebih dahulu");
            }
            else
            {
                var loginSuccess = C_Login.login(username, password);

                if (loginSuccess == 1)
                {
                    MessageBox.Show("Login berhasil!");
                    // Tambahkan logika setelah login berhasil, seperti membuka form baru
                }
                else if (loginSuccess == 0)
                {
                    MessageBox.Show("Username atau password salah!");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Logika untuk label2 jika diperlukan
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Logika untuk textBox2 jika diperlukan
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

