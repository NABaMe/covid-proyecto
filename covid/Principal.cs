using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Net;
using System.Resources;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using System.IO;
using System.Drawing.Imaging;
using System.Globalization;
namespace covid
{

    //se llaman a todos lo que se va a usar, creo q es un poquito obvio xd
    
    public partial class Covid : Form
    {

        //Ésta parte se genera solo cuando tocas la parte gráfica.
        
        public Covid()
        {
            InitializeComponent();
            Datos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            
        }

        //Acá voy a poner todas las variables y que hacen
        /*lPs= el texto que muestra  el nombre Países en el grafico
         *lCd= el texto que muestra  el numero de Confirmados en el grafico
         *lDd= el texto que muestra  el numero de muertos en el grafico
         *lAct= el texto que muestra el numero de casos activos en el grafico
         *lRd= el texto que muestra  el numero de recuperados en el grafico
         *
         *
         *datos= es textLabel donde se ingresa el nombre del país
         *error= un label en el programa que se hace visible si no se ingresa nada en Datos
         *rsp/rs2= resultado del json
         */

        String pais;
        public void No() { Datos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList; }
        private void Label1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Éste es lo que pasa cuando apretás el botón de revisar en el programa
            //.Text es lo que contiene el cuadrito del gráfico, donde se seleccionan los paises.
            pais = Datos.Text;
            //pregunta si esta vacio/no tiene longitud, las propiedades se pueden cambiar al hacer click
            //sobre los graficos, las mismas propiedades se usan en el codigo, ej:error.Visible=Enabled
            if (pais == null || pais.Length == 0)
            {
                error.Visible = Enabled;
            }
            else {

                error.Visible = false;
                //Este es el del grafico de las estadisticas, el primero elimina todo lo que ya está en
                //grafico, puse por si se usa mas de una vez para que no se encime
                Cases.Series["CASOS ACTIVOS"].Points.Clear();
                //Quita los Titulos del grafico
                Cases.Titles.Clear();
                //Acá esta el error no me funciona todavía el código.
                if (pais.Contains("United-States"))
                {
                    //Cases.Titles.Add("Estados Unidos");
                    //Desde aquí es para leer los json y los transforma en objetos, este es otro
                    //porque no funciona Estados Unidos
                    var jsonss = "https://api.covidtracking.com/v1/us/daily.json";
                    WebClient wcc = new WebClient();
                    var datoss = wcc.DownloadString(jsonss);
                    var rsp = JsonConvert.DeserializeObject <List< US.Estados_Unidos>>(datoss, new JsonSerializerSettings 
                    { NullValueHandling = NullValueHandling.Ignore });


                    //Aca recorre todo el json
                    var i = 0;
                    var j = 0;
                    

                    var title = Cases.Titles.Add("Estados Unidos");
                    title.Font = new System.Drawing.Font("Console", 16, FontStyle.Bold);
                    title.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);

                    
                    foreach (var obj in rsp)
                    {
                        j++;
                    }
                    int[] Positive_Data = new int[j];
                    var x = 0;
                    foreach (var obj in rsp)
                    {
                        //Voy a explocar este en el sgte. xd
                        i++;


                        Positive_Data[x] = obj.positiveIncrease;

                        x++;

                        Cases.Series["CASOS ACTIVOS"].BorderWidth = 2;
                        //Cases.Series["CASOS ACTIVOS"].Points.AddY(obj.positiveIncrease);
                        if (i == 1)
                        {
                            lPs.Text = "Estados Unidos";
                            lCd.Text = Convert.ToString(obj.positive);
                            lDd.Text = Convert.ToString(obj.death);
                            lAct.Text = Convert.ToString(obj.positiveIncrease);
                            lRd.Text = Convert.ToString(obj.recovered);


                            Stream StreamImagen;
                            string elError = "";
                            StreamImagen = getUrl("https://disease.sh/assets/img/flags/us.png");
                            if (elError == "")
                            {
                                CountryFlag.Image = System.Drawing.Image.FromStream(StreamImagen);
                            }



                          /*  WebClient webClient = new WebClient();
                            {
                                webClient.DownloadFile("https://disease.sh/assets/img/flags/al.png", @"\al.png.bmp");
                            } */


                        //    CountryFlag.Image = Image.FromFile("https://disease.sh/assets/img/flags/al.png");
                            //lRd.Text = Convert.ToString(obj.);
                        }

                    }

                    int aux;
                    int medio;
                    medio = Positive_Data.Length / 2;
                    for (int f = 0; f < medio; f++)
                    {
                        aux = Positive_Data[f];
                        Positive_Data[f] = Positive_Data[Positive_Data.Length - 1 - f];
                        Positive_Data[Positive_Data.Length - 1 - f] = aux;
                    }


                    for (x=0;x<Positive_Data.Length;x++)
                    {

                        Cases.Series["CASOS ACTIVOS"].Points.AddY(Positive_Data[x]);

                    }
                }
                else
                {
                    //sino es estados unidos va a salir el link del pais osea 
                    //https://api.covid19api.com/country/paraguay por ejemplo



                    var jsons = "https://api.covid19api.com/country/" + pais;
                    WebClient wc = new WebClient();
                    var datos2 = wc.DownloadString(jsons);
                    var rs2 = JsonConvert.DeserializeObject<List<Class2.Application>>(datos2);
                    var x = 0;


                    /*char[] charArray = datos.ToCharArray();
                    Array.Reverse(charArray);
                    var datos2= new string(charArray);*/

                    /*var datos2 = Class2.Reverse(datos);*/






                    //Éste es para leer la clase1, osea aca esta la mayoria de los datos pero 
                    //es suficiente para los graficos

                    /* var json = "https://api.covid19api.com/summary";
                     WebClient wc2 = new WebClient();

                     var datos = wc.DownloadString(json);

                     var rs = JsonConvert.DeserializeObject<Class1.Result>(datos);
                     foreach(var rp in rs.countries) { 
                     Console.WriteLine(rp.Slug);
                     }*/

                    DateTime[] Fecha1 = new DateTime[2];
                    int[] Confirmed = new int[2];
                    var title = Cases.Titles.Add(pais);
                    title.Font = new System.Drawing.Font("Console", 16, FontStyle.Bold);
                    title.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                   
                    foreach (Class2.Application obj in rs2)
                     {
                     x++;
                        if () { 
                        if (Fecha1[0] == Fecha1[1])
                        {
                            Fecha1[0] = obj.Date;
                            Confirmed[0] = obj.Confirmed;
                        }
                        else
                        {
                            Fecha1[0] = Fecha1[1];
                            Confirmed[0] = Confirmed[1];
                            Fecha1[1] = obj.Date;
                            Confirmed[1] = obj.Confirmed;
                            if (Fecha1[1]>=desde&&Fecha1[0]<=desde && obj.Date<hasta) { 

                            }
                            Cases.Series["CASOS ACTIVOS"].Points.AddY(obj.Active);
                            
                        }
                    }
                    }
                    Cases.Series["CASOS ACTIVOS"].BorderWidth = 2;


                    var y = 0;
                    //aca añade un titulo al grafico de la estadistica

                    //Series.Titles.pais.Font("Calibri");


                    foreach (Class2.Application obj in rs2)
                    {
                        y++;


                        
                        

                        if (y == x)
                        {

                            //Acá se reciben los datos que se añadieron en 
                            //public override string ToString()
                            //de la clase2
                            CountryFlag.Visible = true;
                            lPs.Text = obj.Country;
                            lCd.Text = Convert.ToString(obj.Confirmed);
                            lDd.Text = Convert.ToString(obj.Deaths);
                            lAct.Text = Convert.ToString(obj.Active);
                            lRd.Text = Convert.ToString(obj.Recovered);
                            Stream StreamImagen;
                            string elError = "";
                            
                            StreamImagen = getUrl("https://disease.sh/assets/img/flags/"+ obj.CountryCode.ToLower() + ".png");
                            if (elError == "")
                            {
                                CountryFlag.Image = System.Drawing.Image.FromStream(StreamImagen);
                                CountryFlag.SizeMode = PictureBoxSizeMode.StretchImage;
                            }




                            //ToLower()
                            //Devuelve una copia de esta cadena convertida en minúsculas.
                        }
                    }

                }


            }
    }
        //Estos son los botones/textos/grafico del proyecto
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Este es para que no se pueda escribir en ese donde se selecciona el país
            if (Datos.Text == null || Datos.Text.Length == 0 || Datos.Text.Contains("United-States"))
            {
                if (Datos.Text.Contains("United-States"))
                {
                    error.Visible = false;
                }
            }
            else
            {
                filter_button.Visible = true;
                error.Visible = false;
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lRd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hasta.ToString());
        }

        private void Cases_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //codigo de los botones cerrar, minimizar, maximizar y restaurar 
        private void Minimize_Click(object sender, EventArgs e)
        {
            
            WindowState = FormWindowState.Minimized;

        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximize.Visible = false;
            RestoreWindow.Visible = true;
        }

        private void RestoreWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            RestoreWindow.Visible = false;
            Maximize.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SideBarWrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lPs_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuSideBar_Click(object sender, EventArgs e)
        {
     
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {

        }
        private Stream getUrl(string URL)
        {

            HttpWebRequest request = ((HttpWebRequest)WebRequest.Create(URL));

            HttpWebResponse response = ((HttpWebResponse)request.GetResponse());

            try
            {

                return response.GetResponseStream();

            }
            catch
            {
                return response.GetResponseStream();
 
            }

        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            // Class2.filtrado = true;
            //covid.DateTimePicker.ActiveForm;

           
            using (DateTimePicker frm = new DateTimePicker())
            {
                frm.ShowDialog();

                desde = frm.fecha1;
                hasta = frm.fecha2;
                filtrado = frm.filtro;
                reseteo = frm.rss;
  
                Console.WriteLine(desde.ToString());
                Console.WriteLine(hasta.ToString());
            }
        }
        public DateTime desde;
        public DateTime hasta = DateTime.Now;
        bool filtrado;
        bool reseteo;
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

