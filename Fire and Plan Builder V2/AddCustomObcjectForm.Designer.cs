namespace Fire_and_Plan_Builder_V2
{
    partial class AddCustomObcjectForm
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeTB = new System.Windows.Forms.TextBox();
            this.singoloRB = new System.Windows.Forms.RadioButton();
            this.lineaRB = new System.Windows.Forms.RadioButton();
            this.entrambiRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorMarkerCB = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxEffettiSingolo = new System.Windows.Forms.ListBox();
            this.listBoxEffettiLinea = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAnnulla2 = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(132, 13);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(120, 20);
            this.nameTB.TabIndex = 0;
            this.nameTB.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo:";
            // 
            // typeTB
            // 
            this.typeTB.Location = new System.Drawing.Point(132, 39);
            this.typeTB.Name = "typeTB";
            this.typeTB.Size = new System.Drawing.Size(120, 20);
            this.typeTB.TabIndex = 1;
            this.typeTB.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // singoloRB
            // 
            this.singoloRB.AutoSize = true;
            this.singoloRB.Location = new System.Drawing.Point(26, 45);
            this.singoloRB.Name = "singoloRB";
            this.singoloRB.Size = new System.Drawing.Size(90, 17);
            this.singoloRB.TabIndex = 3;
            this.singoloRB.Text = "Panel Singolo";
            this.singoloRB.UseVisualStyleBackColor = true;
            this.singoloRB.CheckedChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // lineaRB
            // 
            this.lineaRB.AutoSize = true;
            this.lineaRB.Location = new System.Drawing.Point(119, 45);
            this.lineaRB.Name = "lineaRB";
            this.lineaRB.Size = new System.Drawing.Size(81, 17);
            this.lineaRB.TabIndex = 4;
            this.lineaRB.Text = "Panel Linea";
            this.lineaRB.UseVisualStyleBackColor = true;
            this.lineaRB.CheckedChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // entrambiRB
            // 
            this.entrambiRB.AutoSize = true;
            this.entrambiRB.Location = new System.Drawing.Point(203, 45);
            this.entrambiRB.Name = "entrambiRB";
            this.entrambiRB.Size = new System.Drawing.Size(66, 17);
            this.entrambiRB.TabIndex = 5;
            this.entrambiRB.Text = "Entrambi";
            this.entrambiRB.UseVisualStyleBackColor = true;
            this.entrambiRB.CheckedChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.entrambiRB);
            this.groupBox1.Controls.Add(this.singoloRB);
            this.groupBox1.Controls.Add(this.lineaRB);
            this.groupBox1.Location = new System.Drawing.Point(13, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 85);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "In quale combo vuoi aggiungere l\'effetto?";
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Enabled = false;
            this.btnAggiungi.Location = new System.Drawing.Point(82, 196);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 8;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.UseVisualStyleBackColor = true;
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(163, 195);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla.TabIndex = 9;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Colore marker:";
            // 
            // ColorMarkerCB
            // 
            this.ColorMarkerCB.FormattingEnabled = true;
            this.ColorMarkerCB.Location = new System.Drawing.Point(132, 68);
            this.ColorMarkerCB.Name = "ColorMarkerCB";
            this.ColorMarkerCB.Size = new System.Drawing.Size(120, 21);
            this.ColorMarkerCB.TabIndex = 2;
            this.ColorMarkerCB.SelectedIndexChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ColorMarkerCB);
            this.groupBox2.Controls.Add(this.nameTB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.typeTB);
            this.groupBox2.Controls.Add(this.btnAnnulla);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnAggiungi);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 224);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aggiungi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAnnulla2);
            this.groupBox3.Controls.Add(this.btnElimina);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.listBoxEffettiLinea);
            this.groupBox3.Controls.Add(this.listBoxEffettiSingolo);
            this.groupBox3.Location = new System.Drawing.Point(331, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 224);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elimina";
            // 
            // listBoxEffettiSingolo
            // 
            this.listBoxEffettiSingolo.FormattingEnabled = true;
            this.listBoxEffettiSingolo.Location = new System.Drawing.Point(8, 39);
            this.listBoxEffettiSingolo.Name = "listBoxEffettiSingolo";
            this.listBoxEffettiSingolo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxEffettiSingolo.Size = new System.Drawing.Size(184, 147);
            this.listBoxEffettiSingolo.TabIndex = 0;
            this.listBoxEffettiSingolo.SelectedIndexChanged += new System.EventHandler(this.listBoxesSelectedIndexChanged);
            // 
            // listBoxEffettiLinea
            // 
            this.listBoxEffettiLinea.FormattingEnabled = true;
            this.listBoxEffettiLinea.Location = new System.Drawing.Point(198, 39);
            this.listBoxEffettiLinea.Name = "listBoxEffettiLinea";
            this.listBoxEffettiLinea.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxEffettiLinea.Size = new System.Drawing.Size(190, 147);
            this.listBoxEffettiLinea.TabIndex = 1;
            this.listBoxEffettiLinea.SelectedIndexChanged += new System.EventHandler(this.listBoxesSelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Combo Singolo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Combo Linea";
            // 
            // btnAnnulla2
            // 
            this.btnAnnulla2.Location = new System.Drawing.Point(198, 195);
            this.btnAnnulla2.Name = "btnAnnulla2";
            this.btnAnnulla2.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla2.TabIndex = 13;
            this.btnAnnulla2.Text = "Annulla";
            this.btnAnnulla2.UseVisualStyleBackColor = true;
            this.btnAnnulla2.Click += new System.EventHandler(this.btnAnnulla2_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Enabled = false;
            this.btnElimina.Location = new System.Drawing.Point(117, 196);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(75, 23);
            this.btnElimina.TabIndex = 12;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // AddCustomObcjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 244);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddCustomObcjectForm";
            this.Text = "Gestisci combo effetti";
            this.Load += new System.EventHandler(this.AddCustomObcjectForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox typeTB;
        private System.Windows.Forms.RadioButton singoloRB;
        private System.Windows.Forms.RadioButton lineaRB;
        private System.Windows.Forms.RadioButton entrambiRB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ColorMarkerCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAnnulla2;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxEffettiLinea;
        private System.Windows.Forms.ListBox listBoxEffettiSingolo;
    }
}