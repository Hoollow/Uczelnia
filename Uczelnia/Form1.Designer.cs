namespace Uczelnia
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Imie = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Nazwisko = new System.Windows.Forms.Label();
            this.NumerT = new System.Windows.Forms.Label();
            this.AdresZamie = new System.Windows.Forms.Label();
            this.Zatrudnienie = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.TextBoxImie = new System.Windows.Forms.TextBox();
            this.TextBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxNumerTelefonu = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxWyksztalcenie = new System.Windows.Forms.TextBox();
            this.textBoxZatrudnienie = new System.Windows.Forms.TextBox();
            this.wykszt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Szuk = new System.Windows.Forms.Label();
            this.textBoxszukaj = new System.Windows.Forms.TextBox();
            this.Bszukaj = new System.Windows.Forms.Button();
            this.Bdodaj = new System.Windows.Forms.Button();
            this.Busun = new System.Windows.Forms.Button();
            this.Bupdate = new System.Windows.Forms.Button();
            this.Bclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Imie
            // 
            this.Imie.AutoSize = true;
            this.Imie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Imie.Location = new System.Drawing.Point(17, 102);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(39, 20);
            this.Imie.TabIndex = 1;
            this.Imie.Text = "Imię";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ID.Location = new System.Drawing.Point(17, 60);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // Nazwisko
            // 
            this.Nazwisko.AutoSize = true;
            this.Nazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nazwisko.Location = new System.Drawing.Point(17, 142);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(76, 20);
            this.Nazwisko.TabIndex = 3;
            this.Nazwisko.Text = "Nazwisko";
            // 
            // NumerT
            // 
            this.NumerT.AutoSize = true;
            this.NumerT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumerT.Location = new System.Drawing.Point(17, 187);
            this.NumerT.Name = "NumerT";
            this.NumerT.Size = new System.Drawing.Size(122, 20);
            this.NumerT.TabIndex = 4;
            this.NumerT.Text = "Numer Telefonu";
            // 
            // AdresZamie
            // 
            this.AdresZamie.AutoSize = true;
            this.AdresZamie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AdresZamie.Location = new System.Drawing.Point(12, 236);
            this.AdresZamie.Name = "AdresZamie";
            this.AdresZamie.Size = new System.Drawing.Size(153, 20);
            this.AdresZamie.TabIndex = 5;
            this.AdresZamie.Text = "Adres Zamieszkania";
            // 
            // Zatrudnienie
            // 
            this.Zatrudnienie.AutoSize = true;
            this.Zatrudnienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zatrudnienie.Location = new System.Drawing.Point(17, 401);
            this.Zatrudnienie.Name = "Zatrudnienie";
            this.Zatrudnienie.Size = new System.Drawing.Size(98, 20);
            this.Zatrudnienie.TabIndex = 6;
            this.Zatrudnienie.Text = "Zatrudnienie";
            this.Zatrudnienie.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(171, 62);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(164, 20);
            this.textBoxID.TabIndex = 7;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // TextBoxImie
            // 
            this.TextBoxImie.Location = new System.Drawing.Point(171, 104);
            this.TextBoxImie.Name = "TextBoxImie";
            this.TextBoxImie.Size = new System.Drawing.Size(164, 20);
            this.TextBoxImie.TabIndex = 8;
            // 
            // TextBoxNazwisko
            // 
            this.TextBoxNazwisko.Location = new System.Drawing.Point(171, 144);
            this.TextBoxNazwisko.Name = "TextBoxNazwisko";
            this.TextBoxNazwisko.Size = new System.Drawing.Size(164, 20);
            this.TextBoxNazwisko.TabIndex = 9;
            // 
            // textBoxNumerTelefonu
            // 
            this.textBoxNumerTelefonu.Location = new System.Drawing.Point(171, 189);
            this.textBoxNumerTelefonu.Name = "textBoxNumerTelefonu";
            this.textBoxNumerTelefonu.Size = new System.Drawing.Size(164, 20);
            this.textBoxNumerTelefonu.TabIndex = 10;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(171, 236);
            this.textBoxAdres.Multiline = true;
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(164, 82);
            this.textBoxAdres.TabIndex = 11;
            // 
            // textBoxWyksztalcenie
            // 
            this.textBoxWyksztalcenie.Location = new System.Drawing.Point(171, 362);
            this.textBoxWyksztalcenie.Name = "textBoxWyksztalcenie";
            this.textBoxWyksztalcenie.Size = new System.Drawing.Size(164, 20);
            this.textBoxWyksztalcenie.TabIndex = 12;
            // 
            // textBoxZatrudnienie
            // 
            this.textBoxZatrudnienie.Location = new System.Drawing.Point(171, 401);
            this.textBoxZatrudnienie.Name = "textBoxZatrudnienie";
            this.textBoxZatrudnienie.Size = new System.Drawing.Size(164, 20);
            this.textBoxZatrudnienie.TabIndex = 13;
            // 
            // wykszt
            // 
            this.wykszt.AutoSize = true;
            this.wykszt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wykszt.Location = new System.Drawing.Point(12, 362);
            this.wykszt.Name = "wykszt";
            this.wykszt.Size = new System.Drawing.Size(111, 20);
            this.wykszt.TabIndex = 14;
            this.wykszt.Text = "Wykształcenie";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(486, 305);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Szuk
            // 
            this.Szuk.AutoSize = true;
            this.Szuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Szuk.Location = new System.Drawing.Point(428, 125);
            this.Szuk.Name = "Szuk";
            this.Szuk.Size = new System.Drawing.Size(57, 20);
            this.Szuk.TabIndex = 16;
            this.Szuk.Text = "Szukaj";
            // 
            // textBoxszukaj
            // 
            this.textBoxszukaj.Location = new System.Drawing.Point(502, 127);
            this.textBoxszukaj.Name = "textBoxszukaj";
            this.textBoxszukaj.Size = new System.Drawing.Size(223, 20);
            this.textBoxszukaj.TabIndex = 17;
            this.textBoxszukaj.TextChanged += new System.EventHandler(this.textBoxszukaj_TextChanged);
            // 
            // Bszukaj
            // 
            this.Bszukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bszukaj.Location = new System.Drawing.Point(762, 120);
            this.Bszukaj.Name = "Bszukaj";
            this.Bszukaj.Size = new System.Drawing.Size(69, 31);
            this.Bszukaj.TabIndex = 18;
            this.Bszukaj.Text = "Szukaj";
            this.Bszukaj.UseVisualStyleBackColor = true;
            // 
            // Bdodaj
            // 
            this.Bdodaj.BackColor = System.Drawing.Color.Bisque;
            this.Bdodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bdodaj.Location = new System.Drawing.Point(432, 522);
            this.Bdodaj.Name = "Bdodaj";
            this.Bdodaj.Size = new System.Drawing.Size(98, 50);
            this.Bdodaj.TabIndex = 19;
            this.Bdodaj.Text = "Dodaj";
            this.Bdodaj.UseVisualStyleBackColor = false;
            this.Bdodaj.Click += new System.EventHandler(this.Bdodaj_Click);
            // 
            // Busun
            // 
            this.Busun.BackColor = System.Drawing.Color.Gold;
            this.Busun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Busun.Location = new System.Drawing.Point(565, 522);
            this.Busun.Name = "Busun";
            this.Busun.Size = new System.Drawing.Size(97, 50);
            this.Busun.TabIndex = 20;
            this.Busun.Text = "Usuń";
            this.Busun.UseVisualStyleBackColor = false;
            this.Busun.Click += new System.EventHandler(this.Busun_Click);
            // 
            // Bupdate
            // 
            this.Bupdate.BackColor = System.Drawing.Color.LemonChiffon;
            this.Bupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bupdate.Location = new System.Drawing.Point(691, 522);
            this.Bupdate.Name = "Bupdate";
            this.Bupdate.Size = new System.Drawing.Size(97, 50);
            this.Bupdate.TabIndex = 21;
            this.Bupdate.Text = "Aktualizuj";
            this.Bupdate.UseVisualStyleBackColor = false;
            this.Bupdate.Click += new System.EventHandler(this.Bupdate_Click);
            // 
            // Bclear
            // 
            this.Bclear.BackColor = System.Drawing.Color.Yellow;
            this.Bclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bclear.Location = new System.Drawing.Point(821, 522);
            this.Bclear.Name = "Bclear";
            this.Bclear.Size = new System.Drawing.Size(97, 50);
            this.Bclear.TabIndex = 22;
            this.Bclear.Text = "Wyczyść";
            this.Bclear.UseVisualStyleBackColor = false;
            this.Bclear.Click += new System.EventHandler(this.Bclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 584);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Bclear);
            this.Controls.Add(this.Bupdate);
            this.Controls.Add(this.Busun);
            this.Controls.Add(this.Bdodaj);
            this.Controls.Add(this.Bszukaj);
            this.Controls.Add(this.textBoxszukaj);
            this.Controls.Add(this.Szuk);
            this.Controls.Add(this.wykszt);
            this.Controls.Add(this.textBoxZatrudnienie);
            this.Controls.Add(this.textBoxWyksztalcenie);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.textBoxNumerTelefonu);
            this.Controls.Add(this.TextBoxNazwisko);
            this.Controls.Add(this.TextBoxImie);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.Zatrudnienie);
            this.Controls.Add(this.AdresZamie);
            this.Controls.Add(this.NumerT);
            this.Controls.Add(this.Nazwisko);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Imie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pracownicy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Imie;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Nazwisko;
        private System.Windows.Forms.Label NumerT;
        private System.Windows.Forms.Label AdresZamie;
        private System.Windows.Forms.Label Zatrudnienie;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox TextBoxImie;
        private System.Windows.Forms.TextBox TextBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxNumerTelefonu;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxWyksztalcenie;
        private System.Windows.Forms.TextBox textBoxZatrudnienie;
        private System.Windows.Forms.Label wykszt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Szuk;
        private System.Windows.Forms.TextBox textBoxszukaj;
        private System.Windows.Forms.Button Bszukaj;
        private System.Windows.Forms.Button Bdodaj;
        private System.Windows.Forms.Button Busun;
        private System.Windows.Forms.Button Bupdate;
        private System.Windows.Forms.Button Bclear;
    }
}