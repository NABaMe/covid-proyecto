namespace covid
{
    partial class Covid
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Covid));
            this.Check = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lConfirmed = new System.Windows.Forms.Label();
            this.lpais = new System.Windows.Forms.Label();
            this.lDeath = new System.Windows.Forms.Label();
            this.lActive = new System.Windows.Forms.Label();
            this.lPs = new System.Windows.Forms.Label();
            this.lCd = new System.Windows.Forms.Label();
            this.lDd = new System.Windows.Forms.Label();
            this.lAct = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lRd = new System.Windows.Forms.Label();
            this.Cases = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.error = new System.Windows.Forms.Label();
            this.MenuTop = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RestoreWindow = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Maximize = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.MenuSideBar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SideBarWrapper = new System.Windows.Forms.Panel();
            this.SideBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.CountryFlag = new System.Windows.Forms.PictureBox();
            this.SideBarLine = new Bunifu.Framework.UI.BunifuSeparator();
            this.CovidIcon2 = new System.Windows.Forms.PictureBox();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.PanelChart = new System.Windows.Forms.Panel();
            this.filter_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SideBarCurve = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelChartCurve = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CheckCurve = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FilterCurve = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LabelCurve = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Cases)).BeginInit();
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSideBar)).BeginInit();
            this.SideBarWrapper.SuspendLayout();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountryFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CovidIcon2)).BeginInit();
            this.Wrapper.SuspendLayout();
            this.PanelChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Check.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(41)))), ((int)(((byte)(165)))));
            this.Check.FlatAppearance.BorderSize = 0;
            this.Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check.ForeColor = System.Drawing.Color.White;
            this.Check.Location = new System.Drawing.Point(343, 82);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(121, 36);
            this.Check.TabIndex = 0;
            this.Check.Text = "REVISAR";
            this.Check.UseVisualStyleBackColor = false;
            this.Check.Click += new System.EventHandler(this.button1_Click);
            // 
            // Datos
            // 
            this.Datos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Datos.BackColor = System.Drawing.Color.White;
            this.Datos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.FormattingEnabled = true;
            this.Datos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Datos.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua-And-Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia-And-Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina-Faso",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape-Verde",
            "Central-African-Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo-Brazzaville",
            "Congo-Kinshasa",
            "Costa-Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech-Republic",
            "Cote-Divoire",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican-Republic",
            "Ecuador",
            "Egypt",
            "El-Salvador",
            "Equatorial-Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Holy-See-Vatican-City-State",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Korea-South",
            "Kuwait",
            "Kyrgyzstan",
            "Lao-Pdr",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar",
            "Namibia",
            "Nepal",
            "Netherlands",
            "New-Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norway",
            "Oman",
            "Pakistan",
            "Palestine",
            "Panama",
            "Papua-New-Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Kosovo",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint-Kitts-And-Nevis",
            "Saint-Lucia",
            "Saint-Vincent-And-The-Grenadines",
            "San-Marino",
            "Sao-Tome-And-Principe",
            "Saudi-Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra-Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Somalia",
            "South-Africa",
            "South-Sudan",
            "Spain",
            "Sri-Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Trinidad-And-Tobago",
            "Tunisia",
            "Turkey",
            "Uganda",
            "Ukraine",
            "United-Arab-Emirates",
            "United-Kingdom",
            "United-States",
            "Uruguay",
            "Uzbekistan",
            "Venezuela",
            "Vietnam",
            "Western-Sahara",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.Datos.Location = new System.Drawing.Point(53, 84);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(256, 27);
            this.Datos.TabIndex = 3;
            this.Datos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(332, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "ESTADÍSTICAS MUNDIALES SOBRE EL COVID-19";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lConfirmed
            // 
            this.lConfirmed.AutoSize = true;
            this.lConfirmed.BackColor = System.Drawing.Color.Transparent;
            this.lConfirmed.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lConfirmed.ForeColor = System.Drawing.Color.White;
            this.lConfirmed.Location = new System.Drawing.Point(3, 303);
            this.lConfirmed.Name = "lConfirmed";
            this.lConfirmed.Size = new System.Drawing.Size(171, 19);
            this.lConfirmed.TabIndex = 5;
            this.lConfirmed.Text = "CASOS CONFIRMADOS:";
            // 
            // lpais
            // 
            this.lpais.AutoSize = true;
            this.lpais.BackColor = System.Drawing.Color.Transparent;
            this.lpais.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpais.ForeColor = System.Drawing.Color.White;
            this.lpais.Location = new System.Drawing.Point(88, 34);
            this.lpais.Name = "lpais";
            this.lpais.Size = new System.Drawing.Size(54, 19);
            this.lpais.TabIndex = 6;
            this.lpais.Text = "PAÍS:";
            // 
            // lDeath
            // 
            this.lDeath.AutoSize = true;
            this.lDeath.BackColor = System.Drawing.Color.Transparent;
            this.lDeath.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDeath.ForeColor = System.Drawing.Color.White;
            this.lDeath.Location = new System.Drawing.Point(3, 353);
            this.lDeath.Name = "lDeath";
            this.lDeath.Size = new System.Drawing.Size(117, 19);
            this.lDeath.TabIndex = 7;
            this.lDeath.Text = "FALLECIDOS: ";
            // 
            // lActive
            // 
            this.lActive.AutoSize = true;
            this.lActive.BackColor = System.Drawing.Color.Transparent;
            this.lActive.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lActive.ForeColor = System.Drawing.Color.White;
            this.lActive.Location = new System.Drawing.Point(3, 400);
            this.lActive.Name = "lActive";
            this.lActive.Size = new System.Drawing.Size(135, 19);
            this.lActive.TabIndex = 8;
            this.lActive.Text = "CASOS ACTIVOS:";
            // 
            // lPs
            // 
            this.lPs.BackColor = System.Drawing.Color.Transparent;
            this.lPs.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPs.ForeColor = System.Drawing.Color.White;
            this.lPs.Location = new System.Drawing.Point(146, 34);
            this.lPs.Name = "lPs";
            this.lPs.Size = new System.Drawing.Size(241, 23);
            this.lPs.TabIndex = 9;
            this.lPs.Click += new System.EventHandler(this.lPs_Click);
            // 
            // lCd
            // 
            this.lCd.BackColor = System.Drawing.Color.Transparent;
            this.lCd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCd.ForeColor = System.Drawing.Color.White;
            this.lCd.Location = new System.Drawing.Point(180, 303);
            this.lCd.Name = "lCd";
            this.lCd.Size = new System.Drawing.Size(184, 23);
            this.lCd.TabIndex = 10;
            this.lCd.Click += new System.EventHandler(this.label7_Click);
            // 
            // lDd
            // 
            this.lDd.BackColor = System.Drawing.Color.Transparent;
            this.lDd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDd.ForeColor = System.Drawing.Color.White;
            this.lDd.Location = new System.Drawing.Point(180, 353);
            this.lDd.Name = "lDd";
            this.lDd.Size = new System.Drawing.Size(184, 23);
            this.lDd.TabIndex = 11;
            // 
            // lAct
            // 
            this.lAct.BackColor = System.Drawing.Color.Transparent;
            this.lAct.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAct.ForeColor = System.Drawing.Color.White;
            this.lAct.Location = new System.Drawing.Point(180, 400);
            this.lAct.Name = "lAct";
            this.lAct.Size = new System.Drawing.Size(184, 23);
            this.lAct.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "RECUPERADOS:";
            // 
            // lRd
            // 
            this.lRd.BackColor = System.Drawing.Color.Transparent;
            this.lRd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRd.ForeColor = System.Drawing.Color.White;
            this.lRd.Location = new System.Drawing.Point(180, 445);
            this.lRd.Name = "lRd";
            this.lRd.Size = new System.Drawing.Size(184, 23);
            this.lRd.TabIndex = 14;
            this.lRd.Click += new System.EventHandler(this.lRd_Click);
            // 
            // Cases
            // 
            this.Cases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Cases.BorderlineWidth = 0;
            this.Cases.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.Cases.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.HeaderSeparatorColor = System.Drawing.Color.White;
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.White;
            legend1.TitleFont = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.TitleForeColor = System.Drawing.Color.White;
            legend1.TitleSeparatorColor = System.Drawing.Color.White;
            this.Cases.Legends.Add(legend1);
            this.Cases.Location = new System.Drawing.Point(68, 206);
            this.Cases.Name = "Cases";
            this.Cases.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.BorderWidth = 7;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(41)))), ((int)(((byte)(165)))));
            series1.EmptyPointStyle.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "CASOS ACTIVOS";
            series1.YValuesPerPoint = 2;
            this.Cases.Series.Add(series1);
            this.Cases.Size = new System.Drawing.Size(465, 339);
            this.Cases.TabIndex = 15;
            this.Cases.Text = "Covid_Cases";
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Transparent;
            title1.Name = "titulo";
            this.Cases.Titles.Add(title1);
            this.Cases.Click += new System.EventHandler(this.Cases_Click);
            // 
            // error
            // 
            this.error.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.error.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(21, 182);
            this.error.Name = "error";
            this.error.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.error.Size = new System.Drawing.Size(259, 21);
            this.error.TabIndex = 16;
            this.error.Text = "*POR FAVOR SELECCIONE UN PAÍS*";
            this.error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.error.Visible = false;
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuTop.Controls.Add(this.bunifuSeparator1);
            this.MenuTop.Controls.Add(this.pictureBox1);
            this.MenuTop.Controls.Add(this.RestoreWindow);
            this.MenuTop.Controls.Add(this.Minimize);
            this.MenuTop.Controls.Add(this.Maximize);
            this.MenuTop.Controls.Add(this.Exit);
            this.MenuTop.Controls.Add(this.MenuSideBar);
            this.MenuTop.Controls.Add(this.label1);
            this.MenuTop.Controls.Add(this.panel2);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(1075, 72);
            this.MenuTop.TabIndex = 17;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 44);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1050, 17);
            this.bunifuSeparator1.TabIndex = 20;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(886, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // RestoreWindow
            // 
            this.RestoreWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreWindow.Image = ((System.Drawing.Image)(resources.GetObject("RestoreWindow.Image")));
            this.RestoreWindow.Location = new System.Drawing.Point(997, 12);
            this.RestoreWindow.Name = "RestoreWindow";
            this.RestoreWindow.Size = new System.Drawing.Size(30, 28);
            this.RestoreWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RestoreWindow.TabIndex = 23;
            this.RestoreWindow.TabStop = false;
            this.RestoreWindow.Visible = false;
            this.RestoreWindow.Click += new System.EventHandler(this.RestoreWindow_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(961, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(30, 28);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize.TabIndex = 22;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Maximize
            // 
            this.Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize.Image = ((System.Drawing.Image)(resources.GetObject("Maximize.Image")));
            this.Maximize.Location = new System.Drawing.Point(997, 12);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(30, 28);
            this.Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximize.TabIndex = 21;
            this.Maximize.TabStop = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(1033, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 28);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 20;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MenuSideBar
            // 
            this.MenuSideBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MenuSideBar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSideBar.Image")));
            this.MenuSideBar.Location = new System.Drawing.Point(288, 11);
            this.MenuSideBar.Name = "MenuSideBar";
            this.MenuSideBar.Size = new System.Drawing.Size(38, 41);
            this.MenuSideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSideBar.TabIndex = 17;
            this.MenuSideBar.TabStop = false;
            this.MenuSideBar.Click += new System.EventHandler(this.MenuSideBar_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 779);
            this.panel2.TabIndex = 18;
            // 
            // SideBarWrapper
            // 
            this.SideBarWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SideBarWrapper.Controls.Add(this.SideBar);
            this.SideBarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarWrapper.Location = new System.Drawing.Point(0, 72);
            this.SideBarWrapper.Name = "SideBarWrapper";
            this.SideBarWrapper.Size = new System.Drawing.Size(428, 659);
            this.SideBarWrapper.TabIndex = 20;
            this.SideBarWrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.SideBarWrapper_Paint);
            // 
            // SideBar
            // 
            this.SideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SideBar.BackgroundImage")));
            this.SideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SideBar.Controls.Add(this.CountryFlag);
            this.SideBar.Controls.Add(this.lConfirmed);
            this.SideBar.Controls.Add(this.lpais);
            this.SideBar.Controls.Add(this.lDeath);
            this.SideBar.Controls.Add(this.SideBarLine);
            this.SideBar.Controls.Add(this.lRd);
            this.SideBar.Controls.Add(this.CovidIcon2);
            this.SideBar.Controls.Add(this.lAct);
            this.SideBar.Controls.Add(this.lActive);
            this.SideBar.Controls.Add(this.lCd);
            this.SideBar.Controls.Add(this.lDd);
            this.SideBar.Controls.Add(this.lPs);
            this.SideBar.Controls.Add(this.label2);
            this.SideBar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(165)))));
            this.SideBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(41)))), ((int)(((byte)(165)))));
            this.SideBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(41)))), ((int)(((byte)(165)))));
            this.SideBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.SideBar.Location = new System.Drawing.Point(26, 3);
            this.SideBar.Name = "SideBar";
            this.SideBar.Quality = 10;
            this.SideBar.Size = new System.Drawing.Size(390, 618);
            this.SideBar.TabIndex = 24;
            this.SideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // CountryFlag
            // 
            this.CountryFlag.Location = new System.Drawing.Point(65, 102);
            this.CountryFlag.Name = "CountryFlag";
            this.CountryFlag.Size = new System.Drawing.Size(250, 179);
            this.CountryFlag.TabIndex = 20;
            this.CountryFlag.TabStop = false;
            this.CountryFlag.Visible = false;
            this.CountryFlag.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // SideBarLine
            // 
            this.SideBarLine.BackColor = System.Drawing.Color.Transparent;
            this.SideBarLine.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.SideBarLine.LineThickness = 1;
            this.SideBarLine.Location = new System.Drawing.Point(0, 69);
            this.SideBarLine.Margin = new System.Windows.Forms.Padding(4);
            this.SideBarLine.Name = "SideBarLine";
            this.SideBarLine.Size = new System.Drawing.Size(390, 10);
            this.SideBarLine.TabIndex = 17;
            this.SideBarLine.Transparency = 255;
            this.SideBarLine.Vertical = false;
            // 
            // CovidIcon2
            // 
            this.CovidIcon2.BackColor = System.Drawing.Color.Transparent;
            this.CovidIcon2.Image = ((System.Drawing.Image)(resources.GetObject("CovidIcon2.Image")));
            this.CovidIcon2.Location = new System.Drawing.Point(28, 21);
            this.CovidIcon2.Name = "CovidIcon2";
            this.CovidIcon2.Size = new System.Drawing.Size(44, 41);
            this.CovidIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CovidIcon2.TabIndex = 19;
            this.CovidIcon2.TabStop = false;
            // 
            // Wrapper
            // 
            this.Wrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.Wrapper.Controls.Add(this.PanelChart);
            this.Wrapper.ForeColor = System.Drawing.Color.Black;
            this.Wrapper.Location = new System.Drawing.Point(423, 72);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(652, 659);
            this.Wrapper.TabIndex = 21;
            this.Wrapper.Enter += new System.EventHandler(this.button1_Click);
            // 
            // PanelChart
            // 
            this.PanelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelChart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.PanelChart.Controls.Add(this.filter_button);
            this.PanelChart.Controls.Add(this.label3);
            this.PanelChart.Controls.Add(this.Datos);
            this.PanelChart.Controls.Add(this.error);
            this.PanelChart.Controls.Add(this.Check);
            this.PanelChart.Controls.Add(this.Cases);
            this.PanelChart.Location = new System.Drawing.Point(53, 21);
            this.PanelChart.Margin = new System.Windows.Forms.Padding(2);
            this.PanelChart.Name = "PanelChart";
            this.PanelChart.Size = new System.Drawing.Size(564, 638);
            this.PanelChart.TabIndex = 0;
            this.PanelChart.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelChart_Paint);
            // 
            // filter_button
            // 
            this.filter_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filter_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.filter_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.filter_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filter_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(41)))), ((int)(((byte)(165)))));
            this.filter_button.FlatAppearance.BorderSize = 0;
            this.filter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filter_button.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_button.ForeColor = System.Drawing.Color.White;
            this.filter_button.Location = new System.Drawing.Point(343, 124);
            this.filter_button.Name = "filter_button";
            this.filter_button.Size = new System.Drawing.Size(121, 36);
            this.filter_button.TabIndex = 25;
            this.filter_button.Text = "FILTRAR";
            this.filter_button.UseVisualStyleBackColor = false;
            this.filter_button.Visible = false;
            this.filter_button.Click += new System.EventHandler(this.filter_button_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.label3.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(48, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 34);
            this.label3.TabIndex = 24;
            this.label3.Text = "SELECCIONE UN PAÍS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SideBarCurve
            // 
            this.SideBarCurve.ElipseRadius = 7;
            this.SideBarCurve.TargetControl = this.SideBar;
            // 
            // PanelChartCurve
            // 
            this.PanelChartCurve.ElipseRadius = 7;
            this.PanelChartCurve.TargetControl = this.PanelChart;
            // 
            // CheckCurve
            // 
            this.CheckCurve.ElipseRadius = 7;
            this.CheckCurve.TargetControl = this.Check;
            // 
            // FilterCurve
            // 
            this.FilterCurve.ElipseRadius = 7;
            this.FilterCurve.TargetControl = this.filter_button;
            // 
            // LabelCurve
            // 
            this.LabelCurve.ElipseRadius = 7;
            this.LabelCurve.TargetControl = this.label3;
            // 
            // Covid
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 731);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SideBarWrapper);
            this.Controls.Add(this.MenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Covid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "COVID-19";
            this.Text = "Covid-19";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cases)).EndInit();
            this.MenuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestoreWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSideBar)).EndInit();
            this.SideBarWrapper.ResumeLayout(false);
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountryFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CovidIcon2)).EndInit();
            this.Wrapper.ResumeLayout(false);
            this.PanelChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.ComboBox Datos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lConfirmed;
        private System.Windows.Forms.Label lpais;
        private System.Windows.Forms.Label lDeath;
        private System.Windows.Forms.Label lActive;
        private System.Windows.Forms.Label lPs;
        private System.Windows.Forms.Label lCd;
        private System.Windows.Forms.Label lDd;
        private System.Windows.Forms.Label lAct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lRd;
        public System.Windows.Forms.Label error;
        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel SideBarWrapper;
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.PictureBox RestoreWindow;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox Maximize;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox MenuSideBar;
        private Bunifu.Framework.UI.BunifuGradientPanel SideBar;
        private System.Windows.Forms.PictureBox CovidIcon2;
        private Bunifu.Framework.UI.BunifuSeparator SideBarLine;
        private System.Windows.Forms.Panel PanelChart;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse SideBarCurve;
        private Bunifu.Framework.UI.BunifuElipse PanelChartCurve;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox CountryFlag;
        public System.Windows.Forms.DataVisualization.Charting.Chart Cases;
        private System.Windows.Forms.Button filter_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuElipse CheckCurve;
        private Bunifu.Framework.UI.BunifuElipse FilterCurve;
        private Bunifu.Framework.UI.BunifuElipse LabelCurve;
    }
}

