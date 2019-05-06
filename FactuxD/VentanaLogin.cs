using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiLibreria;
using FactuxD.Models;




namespace FactuxD
{
    public partial class VentanaLogin : Form
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }

        public bool LoginCorrecto = false;

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                Usuario us = new Usuario
                {
                    Account = txtNomAcc.Text,
                    Password = txtNomPass.Text
                };


                DataTable ds = us.Login();

                string cuenta = ds.Rows[0]["Account"].ToString().Trim();
                string contra = ds.Rows[0]["Password"].ToString().Trim();
                
                if(cuenta == txtNomAcc.Text.Trim() && contra == txtNomPass.Text.Trim())
                {
                   if(Convert.ToBoolean(ds.Rows[0]["Status_Admin"])==true)
                    {
                        VentanaAdmin VenAd = new VentanaAdmin();
                        this.Hide();
                        VenAd.Show();
                    }
                    else
                    {
                        VentanaUser VenUser = new VentanaUser();
                        this.Hide();
                        VenUser.Show();
                    }
                }
                
            }
            catch (Exception error)
            {
                MessageBox.Show("Usuario o Contraseña incorrecta!!.." + error.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
