namespace Fire_and_Plan_Builder_V2
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.compilerPathTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.compilaBGLbtn = new System.Windows.Forms.Button();
            this.selezionaTuttiCB = new System.Windows.Forms.CheckBox();
            this.eliminaSelezionatiBtn = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.singoloEffettoCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.altezzaUpDn = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.aggiungiScenarioBtn = new System.Windows.Forms.Button();
            this.creaWaypointBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.singoloLonTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.singoloLatTB = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lineaCreaBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lineaEffettoCB = new System.Windows.Forms.ComboBox();
            this.lineaP2RB = new System.Windows.Forms.RadioButton();
            this.lineaP1RB = new System.Windows.Forms.RadioButton();
            this.lineaGB2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lineaLon2TB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lineaLat2TB = new System.Windows.Forms.TextBox();
            this.lineaGB1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lineaLon1TB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lineaLat1TB = new System.Windows.Forms.TextBox();
            this.cercaAreaBtn = new System.Windows.Forms.Button();
            this.areaTB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.satelliteRB = new System.Windows.Forms.RadioButton();
            this.stradeRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gMC = new GMap.NET.WindowsForms.GMapControl();
            this.panelOverIncendio = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impostaCompilatoreBGLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiNuovoEffettoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altezzaUpDn)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.lineaGB2.SuspendLayout();
            this.lineaGB1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelOverIncendio.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 24);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(889, 565);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panelOverIncendio);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(881, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Incendio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.compilerPathTB);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.compilaBGLbtn);
            this.panel2.Controls.Add(this.selezionaTuttiCB);
            this.panel2.Controls.Add(this.eliminaSelezionatiBtn);
            this.panel2.Controls.Add(this.listBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tabControl2);
            this.panel2.Controls.Add(this.cercaAreaBtn);
            this.panel2.Controls.Add(this.areaTB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 533);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Area:";
            // 
            // compilerPathTB
            // 
            this.compilerPathTB.Location = new System.Drawing.Point(11, 508);
            this.compilerPathTB.Name = "compilerPathTB";
            this.compilerPathTB.ReadOnly = true;
            this.compilerPathTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.compilerPathTB.Size = new System.Drawing.Size(296, 20);
            this.compilerPathTB.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(8, 484);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(298, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Percorso compilatore BGL (VERIFICARE SEMPRE!)";
            // 
            // compilaBGLbtn
            // 
            this.compilaBGLbtn.Enabled = false;
            this.compilaBGLbtn.Location = new System.Drawing.Point(11, 445);
            this.compilaBGLbtn.Name = "compilaBGLbtn";
            this.compilaBGLbtn.Size = new System.Drawing.Size(296, 23);
            this.compilaBGLbtn.TabIndex = 8;
            this.compilaBGLbtn.Text = "Compila BGL";
            this.compilaBGLbtn.UseVisualStyleBackColor = true;
            this.compilaBGLbtn.Click += new System.EventHandler(this.compilaBGLbtn_Click);
            // 
            // selezionaTuttiCB
            // 
            this.selezionaTuttiCB.AutoSize = true;
            this.selezionaTuttiCB.Enabled = false;
            this.selezionaTuttiCB.Location = new System.Drawing.Point(163, 420);
            this.selezionaTuttiCB.Name = "selezionaTuttiCB";
            this.selezionaTuttiCB.Size = new System.Drawing.Size(92, 17);
            this.selezionaTuttiCB.TabIndex = 10;
            this.selezionaTuttiCB.Text = "Seleziona tutti";
            this.selezionaTuttiCB.UseVisualStyleBackColor = true;
            this.selezionaTuttiCB.CheckedChanged += new System.EventHandler(this.selezionaTuttiCB_CheckedChanged);
            // 
            // eliminaSelezionatiBtn
            // 
            this.eliminaSelezionatiBtn.Enabled = false;
            this.eliminaSelezionatiBtn.Location = new System.Drawing.Point(11, 416);
            this.eliminaSelezionatiBtn.Name = "eliminaSelezionatiBtn";
            this.eliminaSelezionatiBtn.Size = new System.Drawing.Size(131, 23);
            this.eliminaSelezionatiBtn.TabIndex = 9;
            this.eliminaSelezionatiBtn.Text = "Elimina selezionati";
            this.eliminaSelezionatiBtn.UseVisualStyleBackColor = true;
            this.eliminaSelezionatiBtn.Click += new System.EventHandler(this.eliminaSelezionatiBtn_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(11, 275);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox.Size = new System.Drawing.Size(296, 134);
            this.listBox.TabIndex = 5;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBox_Format);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Oggetti inseriti:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(3, 46);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(308, 209);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.singoloEffettoCB);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.altezzaUpDn);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.aggiungiScenarioBtn);
            this.tabPage3.Controls.Add(this.creaWaypointBtn);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.singoloLonTB);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.singoloLatTB);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(300, 183);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Singolo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // singoloEffettoCB
            // 
            this.singoloEffettoCB.FormattingEnabled = true;
            this.singoloEffettoCB.Location = new System.Drawing.Point(123, 100);
            this.singoloEffettoCB.Name = "singoloEffettoCB";
            this.singoloEffettoCB.Size = new System.Drawing.Size(148, 21);
            this.singoloEffettoCB.TabIndex = 5;
            this.singoloEffettoCB.SelectedIndexChanged += new System.EventHandler(this.singoloEffettoCB_SelectedIndexChanged);
            this.singoloEffettoCB.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.singoloEffettoCB_Format);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Effetto:";
            // 
            // altezzaUpDn
            // 
            this.altezzaUpDn.Enabled = false;
            this.altezzaUpDn.Location = new System.Drawing.Point(123, 74);
            this.altezzaUpDn.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.altezzaUpDn.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.altezzaUpDn.Name = "altezzaUpDn";
            this.altezzaUpDn.Size = new System.Drawing.Size(148, 20);
            this.altezzaUpDn.TabIndex = 4;
            this.altezzaUpDn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.altezzaUpDn.Value = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Altezza (solo per fumo):";
            // 
            // aggiungiScenarioBtn
            // 
            this.aggiungiScenarioBtn.Enabled = false;
            this.aggiungiScenarioBtn.Location = new System.Drawing.Point(24, 143);
            this.aggiungiScenarioBtn.Name = "aggiungiScenarioBtn";
            this.aggiungiScenarioBtn.Size = new System.Drawing.Size(126, 34);
            this.aggiungiScenarioBtn.TabIndex = 6;
            this.aggiungiScenarioBtn.Text = "Aggiungi oggetto scenario";
            this.aggiungiScenarioBtn.UseVisualStyleBackColor = true;
            this.aggiungiScenarioBtn.Click += new System.EventHandler(this.aggiungiScenarioBtn_Click);
            // 
            // creaWaypointBtn
            // 
            this.creaWaypointBtn.Enabled = false;
            this.creaWaypointBtn.Location = new System.Drawing.Point(156, 143);
            this.creaWaypointBtn.Name = "creaWaypointBtn";
            this.creaWaypointBtn.Size = new System.Drawing.Size(126, 34);
            this.creaWaypointBtn.TabIndex = 7;
            this.creaWaypointBtn.Text = "Crea Waypoint";
            this.creaWaypointBtn.UseVisualStyleBackColor = true;
            this.creaWaypointBtn.Click += new System.EventHandler(this.creaWaypointBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Longitudine:";
            // 
            // singoloLonTB
            // 
            this.singoloLonTB.Enabled = false;
            this.singoloLonTB.Location = new System.Drawing.Point(123, 42);
            this.singoloLonTB.Name = "singoloLonTB";
            this.singoloLonTB.Size = new System.Drawing.Size(148, 20);
            this.singoloLonTB.TabIndex = 3;
            this.singoloLonTB.TextChanged += new System.EventHandler(this.SingoloTBtextChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Latitudine:";
            // 
            // singoloLatTB
            // 
            this.singoloLatTB.Enabled = false;
            this.singoloLatTB.Location = new System.Drawing.Point(123, 12);
            this.singoloLatTB.Name = "singoloLatTB";
            this.singoloLatTB.Size = new System.Drawing.Size(148, 20);
            this.singoloLatTB.TabIndex = 2;
            this.singoloLatTB.TextChanged += new System.EventHandler(this.SingoloTBtextChange);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lineaCreaBtn);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.lineaEffettoCB);
            this.tabPage4.Controls.Add(this.lineaP2RB);
            this.tabPage4.Controls.Add(this.lineaP1RB);
            this.tabPage4.Controls.Add(this.lineaGB2);
            this.tabPage4.Controls.Add(this.lineaGB1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(300, 183);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Linea";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lineaCreaBtn
            // 
            this.lineaCreaBtn.Enabled = false;
            this.lineaCreaBtn.Location = new System.Drawing.Point(197, 104);
            this.lineaCreaBtn.Name = "lineaCreaBtn";
            this.lineaCreaBtn.Size = new System.Drawing.Size(75, 23);
            this.lineaCreaBtn.TabIndex = 8;
            this.lineaCreaBtn.Text = "Crea";
            this.lineaCreaBtn.UseVisualStyleBackColor = true;
            this.lineaCreaBtn.Click += new System.EventHandler(this.lineaCreaBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(207, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Effetto:";
            // 
            // lineaEffettoCB
            // 
            this.lineaEffettoCB.Enabled = false;
            this.lineaEffettoCB.FormattingEnabled = true;
            this.lineaEffettoCB.Location = new System.Drawing.Point(186, 35);
            this.lineaEffettoCB.Name = "lineaEffettoCB";
            this.lineaEffettoCB.Size = new System.Drawing.Size(108, 21);
            this.lineaEffettoCB.TabIndex = 7;
            this.lineaEffettoCB.SelectedIndexChanged += new System.EventHandler(this.lineaEffettoCB_SelectedIndexChanged);
            // 
            // lineaP2RB
            // 
            this.lineaP2RB.AutoSize = true;
            this.lineaP2RB.Location = new System.Drawing.Point(161, 104);
            this.lineaP2RB.Name = "lineaP2RB";
            this.lineaP2RB.Size = new System.Drawing.Size(14, 13);
            this.lineaP2RB.TabIndex = 4;
            this.lineaP2RB.UseVisualStyleBackColor = true;
            this.lineaP2RB.CheckedChanged += new System.EventHandler(this.LineaCheckRadioButton);
            // 
            // lineaP1RB
            // 
            this.lineaP1RB.AutoSize = true;
            this.lineaP1RB.Checked = true;
            this.lineaP1RB.Location = new System.Drawing.Point(161, 16);
            this.lineaP1RB.Name = "lineaP1RB";
            this.lineaP1RB.Size = new System.Drawing.Size(14, 13);
            this.lineaP1RB.TabIndex = 5;
            this.lineaP1RB.TabStop = true;
            this.lineaP1RB.UseVisualStyleBackColor = true;
            this.lineaP1RB.CheckedChanged += new System.EventHandler(this.LineaCheckRadioButton);
            // 
            // lineaGB2
            // 
            this.lineaGB2.Controls.Add(this.label10);
            this.lineaGB2.Controls.Add(this.lineaLon2TB);
            this.lineaGB2.Controls.Add(this.label11);
            this.lineaGB2.Controls.Add(this.lineaLat2TB);
            this.lineaGB2.Enabled = false;
            this.lineaGB2.Location = new System.Drawing.Point(6, 93);
            this.lineaGB2.Name = "lineaGB2";
            this.lineaGB2.Size = new System.Drawing.Size(149, 84);
            this.lineaGB2.TabIndex = 4;
            this.lineaGB2.TabStop = false;
            this.lineaGB2.Text = "Fine";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "lon:";
            // 
            // lineaLon2TB
            // 
            this.lineaLon2TB.Enabled = false;
            this.lineaLon2TB.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineaLon2TB.Location = new System.Drawing.Point(33, 49);
            this.lineaLon2TB.Name = "lineaLon2TB";
            this.lineaLon2TB.Size = new System.Drawing.Size(100, 20);
            this.lineaLon2TB.TabIndex = 6;
            this.lineaLon2TB.TextChanged += new System.EventHandler(this.LineaCheckTextBox);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "lat:";
            // 
            // lineaLat2TB
            // 
            this.lineaLat2TB.Enabled = false;
            this.lineaLat2TB.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineaLat2TB.Location = new System.Drawing.Point(33, 23);
            this.lineaLat2TB.Name = "lineaLat2TB";
            this.lineaLat2TB.Size = new System.Drawing.Size(100, 20);
            this.lineaLat2TB.TabIndex = 5;
            this.lineaLat2TB.TextChanged += new System.EventHandler(this.LineaCheckTextBox);
            // 
            // lineaGB1
            // 
            this.lineaGB1.Controls.Add(this.label9);
            this.lineaGB1.Controls.Add(this.lineaLon1TB);
            this.lineaGB1.Controls.Add(this.label8);
            this.lineaGB1.Controls.Add(this.lineaLat1TB);
            this.lineaGB1.Location = new System.Drawing.Point(6, 6);
            this.lineaGB1.Name = "lineaGB1";
            this.lineaGB1.Size = new System.Drawing.Size(149, 84);
            this.lineaGB1.TabIndex = 0;
            this.lineaGB1.TabStop = false;
            this.lineaGB1.Text = "Inizio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "lon:";
            // 
            // lineaLon1TB
            // 
            this.lineaLon1TB.Enabled = false;
            this.lineaLon1TB.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineaLon1TB.Location = new System.Drawing.Point(33, 49);
            this.lineaLon1TB.Name = "lineaLon1TB";
            this.lineaLon1TB.Size = new System.Drawing.Size(100, 20);
            this.lineaLon1TB.TabIndex = 3;
            this.lineaLon1TB.TextChanged += new System.EventHandler(this.LineaCheckTextBox);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "lat:";
            // 
            // lineaLat1TB
            // 
            this.lineaLat1TB.Enabled = false;
            this.lineaLat1TB.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineaLat1TB.Location = new System.Drawing.Point(33, 23);
            this.lineaLat1TB.Name = "lineaLat1TB";
            this.lineaLat1TB.Size = new System.Drawing.Size(100, 20);
            this.lineaLat1TB.TabIndex = 2;
            this.lineaLat1TB.TextChanged += new System.EventHandler(this.LineaCheckTextBox);
            // 
            // cercaAreaBtn
            // 
            this.cercaAreaBtn.Location = new System.Drawing.Point(214, 8);
            this.cercaAreaBtn.Name = "cercaAreaBtn";
            this.cercaAreaBtn.Size = new System.Drawing.Size(75, 23);
            this.cercaAreaBtn.TabIndex = 1;
            this.cercaAreaBtn.Text = "Cerca";
            this.cercaAreaBtn.UseVisualStyleBackColor = true;
            this.cercaAreaBtn.Click += new System.EventHandler(this.cercaAreaBtn_Click);
            // 
            // areaTB
            // 
            this.areaTB.Location = new System.Drawing.Point(43, 10);
            this.areaTB.Name = "areaTB";
            this.areaTB.Size = new System.Drawing.Size(148, 20);
            this.areaTB.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.gMC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(320, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 533);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.satelliteRB);
            this.panel3.Controls.Add(this.stradeRB);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 33);
            this.panel3.TabIndex = 2;
            // 
            // satelliteRB
            // 
            this.satelliteRB.AutoSize = true;
            this.satelliteRB.Location = new System.Drawing.Point(284, 8);
            this.satelliteRB.Name = "satelliteRB";
            this.satelliteRB.Size = new System.Drawing.Size(62, 17);
            this.satelliteRB.TabIndex = 3;
            this.satelliteRB.Text = "Satellite";
            this.satelliteRB.UseVisualStyleBackColor = true;
            this.satelliteRB.CheckedChanged += new System.EventHandler(this.StradeSatelliteRadioButtonChange);
            // 
            // stradeRB
            // 
            this.stradeRB.AutoSize = true;
            this.stradeRB.Checked = true;
            this.stradeRB.Location = new System.Drawing.Point(193, 8);
            this.stradeRB.Name = "stradeRB";
            this.stradeRB.Size = new System.Drawing.Size(56, 17);
            this.stradeRB.TabIndex = 2;
            this.stradeRB.TabStop = true;
            this.stradeRB.Text = "Strade";
            this.stradeRB.UseVisualStyleBackColor = true;
            this.stradeRB.CheckedChanged += new System.EventHandler(this.StradeSatelliteRadioButtonChange);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Google Map";
            // 
            // gMC
            // 
            this.gMC.Bearing = 0F;
            this.gMC.CanDragMap = true;
            this.gMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMC.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMC.GrayScaleMode = false;
            this.gMC.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMC.LevelsKeepInMemmory = 5;
            this.gMC.Location = new System.Drawing.Point(0, 0);
            this.gMC.MarkersEnabled = true;
            this.gMC.MaxZoom = 25;
            this.gMC.MinZoom = 0;
            this.gMC.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMC.Name = "gMC";
            this.gMC.NegativeMode = false;
            this.gMC.PolygonsEnabled = true;
            this.gMC.RetryLoadTile = 0;
            this.gMC.RoutesEnabled = true;
            this.gMC.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMC.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMC.ShowTileGridLines = false;
            this.gMC.Size = new System.Drawing.Size(558, 533);
            this.gMC.TabIndex = 0;
            this.gMC.Zoom = 0D;
            this.gMC.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMC_OnMarkerClick);
            this.gMC.OnPositionChanged += new GMap.NET.PositionChanged(this.gMC_OnPositionChanged);
            this.gMC.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMC_MouseDoubleClick);
            // 
            // panelOverIncendio
            // 
            this.panelOverIncendio.Controls.Add(this.button2);
            this.panelOverIncendio.Controls.Add(this.button1);
            this.panelOverIncendio.Controls.Add(this.label15);
            this.panelOverIncendio.Controls.Add(this.label14);
            this.panelOverIncendio.Location = new System.Drawing.Point(3, 6);
            this.panelOverIncendio.Name = "panelOverIncendio";
            this.panelOverIncendio.Size = new System.Drawing.Size(872, 533);
            this.panelOverIncendio.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(497, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 111);
            this.button2.TabIndex = 3;
            this.button2.Text = "Apri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 111);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nuovo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(96, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(683, 38);
            this.label15.TabIndex = 1;
            this.label15.Text = "Per accedere in quest\'area creane o caricane uno:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(119, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(636, 38);
            this.label14.TabIndex = 0;
            this.label14.Text = "Non è stato creato o caricato nessun file XML";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(881, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Piano di volo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aggiungiNuovoEffettoToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuovoToolStripMenuItem,
            this.apriToolStripMenuItem,
            this.impostaCompilatoreBGLToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // nuovoToolStripMenuItem
            // 
            this.nuovoToolStripMenuItem.Name = "nuovoToolStripMenuItem";
            this.nuovoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.nuovoToolStripMenuItem.Text = "Nuovo";
            this.nuovoToolStripMenuItem.Click += new System.EventHandler(this.nuovoToolStripMenuItem_Click);
            // 
            // apriToolStripMenuItem
            // 
            this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.apriToolStripMenuItem.Text = "Apri";
            this.apriToolStripMenuItem.Click += new System.EventHandler(this.apriToolStripMenuItem_Click);
            // 
            // impostaCompilatoreBGLToolStripMenuItem
            // 
            this.impostaCompilatoreBGLToolStripMenuItem.Name = "impostaCompilatoreBGLToolStripMenuItem";
            this.impostaCompilatoreBGLToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.impostaCompilatoreBGLToolStripMenuItem.Text = "Imposta compilatore BGL";
            this.impostaCompilatoreBGLToolStripMenuItem.Click += new System.EventHandler(this.impostaCompilatoreBGLToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // aggiungiNuovoEffettoToolStripMenuItem
            // 
            this.aggiungiNuovoEffettoToolStripMenuItem.Name = "aggiungiNuovoEffettoToolStripMenuItem";
            this.aggiungiNuovoEffettoToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.aggiungiNuovoEffettoToolStripMenuItem.Text = "Gestisci Effetti";
            this.aggiungiNuovoEffettoToolStripMenuItem.Click += new System.EventHandler(this.aggiungiNuovoEffettoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 589);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fire and Plan Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altezzaUpDn)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.lineaGB2.ResumeLayout(false);
            this.lineaGB2.PerformLayout();
            this.lineaGB1.ResumeLayout(false);
            this.lineaGB1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelOverIncendio.ResumeLayout(false);
            this.panelOverIncendio.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cercaAreaBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox areaTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private GMap.NET.WindowsForms.GMapControl gMC;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button aggiungiScenarioBtn;
        private System.Windows.Forms.Button creaWaypointBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox singoloLonTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox singoloLatTB;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox singoloEffettoCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown altezzaUpDn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button compilaBGLbtn;
        private System.Windows.Forms.CheckBox selezionaTuttiCB;
        private System.Windows.Forms.Button eliminaSelezionatiBtn;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton satelliteRB;
        private System.Windows.Forms.RadioButton stradeRB;
        private System.Windows.Forms.Button lineaCreaBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox lineaEffettoCB;
        private System.Windows.Forms.RadioButton lineaP2RB;
        private System.Windows.Forms.RadioButton lineaP1RB;
        private System.Windows.Forms.GroupBox lineaGB2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox lineaLon2TB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox lineaLat2TB;
        private System.Windows.Forms.GroupBox lineaGB1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lineaLon1TB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lineaLat1TB;
        private System.Windows.Forms.TextBox compilerPathTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolStripMenuItem impostaCompilatoreBGLToolStripMenuItem;
        private System.Windows.Forms.Panel panelOverIncendio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem aggiungiNuovoEffettoToolStripMenuItem;
    }
}

