using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace covid
{
    public partial class DateTimePicker : Form
    {
        public DateTimePicker()
        {
            InitializeComponent();
        }

        public DateTime fecha1;
        public DateTime fecha2;
        public String hola = "Paraguay";
        public bool filtro = false;
        public bool rss= true;

        private void DateTimePicker_Load(object sender, EventArgs e)
        {
            
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            // Form1.filtrado = false ;
            rss = true;
            filtro = false;
            this.Close();
            this.Close();
        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            fecha1 = Datepicker1.Value;
            fecha2 = Datepicker2.Value;
            rss = false;
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            filtro = false;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            filtro = false;
            this.Close();
        }

        private void reset_button_Click_1(object sender, EventArgs e)
        {
            rss = true;
            filtro = false;
            this.Close();
        }
    }
}
