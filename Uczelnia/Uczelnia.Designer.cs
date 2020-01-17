namespace Uczelnia
{
    partial class Uczelnia
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uczelnia));
            this.ID = new System.Windows.Forms.Label();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.TextBoxImie = new System.Windows.Forms.TextBox();
            this.Imie = new System.Windows.Forms.Label();
            this.TextBoxNazwisko = new System.Windows.Forms.TextBox();
            this.Nazwisko = new System.Windows.Forms.Label();
            this.textBoxNumerTelefonu = new System.Windows.Forms.TextBox();
            this.NumerTelefonu = new System.Windows.Forms.Label();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.Label();
            this.comboBoxPlec = new System.Windows.Forms.ComboBox();
            this.Plec = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.Wydzial = new System.Windows.Forms.Label();
            this.comboBoxWydzial = new System.Windows.Forms.ComboBox();
            this.Kierunek = new System.Windows.Forms.Label();
            this.comboBoxKierunek = new System.Windows.Forms.ComboBox();
            this.Szukaj = new System.Windows.Forms.Label();
            this.textBoxSzukaj = new System.Windows.Forms.TextBox();
            this.Semestr = new System.Windows.Forms.Label();
            this.comboBoxSemestr = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSzukaj = new System.Windows.Forms.Button();
            this.Pracownik = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ID.Location = new System.Drawing.Point(60, 82);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // TextBoxID
            // 
            this.TextBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxID.Location = new System.Drawing.Point(214, 82);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(193, 26);
            this.TextBoxID.TabIndex = 1;
            this.TextBoxID.TextChanged += new System.EventHandler(this.TextBoxID_TextChanged);
            // 
            // TextBoxImie
            // 
            this.TextBoxImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxImie.Location = new System.Drawing.Point(214, 114);
            this.TextBoxImie.Name = "TextBoxImie";
            this.TextBoxImie.Size = new System.Drawing.Size(193, 26);
            this.TextBoxImie.TabIndex = 3;
            // 
            // Imie
            // 
            this.Imie.AutoSize = true;
            this.Imie.BackColor = System.Drawing.Color.Transparent;
            this.Imie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Imie.Location = new System.Drawing.Point(60, 114);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(39, 20);
            this.Imie.TabIndex = 2;
            this.Imie.Text = "Imię";
            this.Imie.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBoxNazwisko
            // 
            this.TextBoxNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxNazwisko.Location = new System.Drawing.Point(214, 146);
            this.TextBoxNazwisko.Name = "TextBoxNazwisko";
            this.TextBoxNazwisko.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxNazwisko.Size = new System.Drawing.Size(193, 26);
            this.TextBoxNazwisko.TabIndex = 5;
            // 
            // Nazwisko
            // 
            this.Nazwisko.AutoSize = true;
            this.Nazwisko.BackColor = System.Drawing.Color.Transparent;
            this.Nazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nazwisko.Location = new System.Drawing.Point(60, 146);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(76, 20);
            this.Nazwisko.TabIndex = 4;
            this.Nazwisko.Text = "Nazwisko";
            // 
            // textBoxNumerTelefonu
            // 
            this.textBoxNumerTelefonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNumerTelefonu.Location = new System.Drawing.Point(214, 178);
            this.textBoxNumerTelefonu.Name = "textBoxNumerTelefonu";
            this.textBoxNumerTelefonu.Size = new System.Drawing.Size(193, 26);
            this.textBoxNumerTelefonu.TabIndex = 7;
            // 
            // NumerTelefonu
            // 
            this.NumerTelefonu.AutoSize = true;
            this.NumerTelefonu.BackColor = System.Drawing.Color.Transparent;
            this.NumerTelefonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumerTelefonu.Location = new System.Drawing.Point(60, 178);
            this.NumerTelefonu.Name = "NumerTelefonu";
            this.NumerTelefonu.Size = new System.Drawing.Size(122, 20);
            this.NumerTelefonu.TabIndex = 6;
            this.NumerTelefonu.Text = "Numer Telefonu";
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAdres.Location = new System.Drawing.Point(214, 210);
            this.textBoxAdres.Multiline = true;
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(193, 79);
            this.textBoxAdres.TabIndex = 9;
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.BackColor = System.Drawing.Color.Transparent;
            this.Adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Adres.Location = new System.Drawing.Point(60, 210);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(153, 20);
            this.Adres.TabIndex = 8;
            this.Adres.Text = "Adres Zamieszkania";
            // 
            // comboBoxPlec
            // 
            this.comboBoxPlec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPlec.FormattingEnabled = true;
            this.comboBoxPlec.Items.AddRange(new object[] {
            "Kobieta",
            "Mężczyzna"});
            this.comboBoxPlec.Location = new System.Drawing.Point(214, 295);
            this.comboBoxPlec.Name = "comboBoxPlec";
            this.comboBoxPlec.Size = new System.Drawing.Size(193, 28);
            this.comboBoxPlec.TabIndex = 10;
            // 
            // Plec
            // 
            this.Plec.AutoSize = true;
            this.Plec.BackColor = System.Drawing.Color.Transparent;
            this.Plec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Plec.Location = new System.Drawing.Point(59, 295);
            this.Plec.Name = "Plec";
            this.Plec.Size = new System.Drawing.Size(40, 20);
            this.Plec.TabIndex = 11;
            this.Plec.Text = "Płeć";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodaj.ForeColor = System.Drawing.Color.Brown;
            this.buttonDodaj.Location = new System.Drawing.Point(386, 553);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(118, 52);
            this.buttonDodaj.TabIndex = 12;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.BackColor = System.Drawing.Color.Peru;
            this.buttonUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUsun.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonUsun.Location = new System.Drawing.Point(526, 553);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(118, 52);
            this.buttonUsun.TabIndex = 13;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = false;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Brown;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.Location = new System.Drawing.Point(656, 553);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(118, 52);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Aktualizuj";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.buttonClear.Location = new System.Drawing.Point(798, 553);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(118, 52);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Wyczyść";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Wydzial
            // 
            this.Wydzial.AutoSize = true;
            this.Wydzial.BackColor = System.Drawing.Color.Transparent;
            this.Wydzial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wydzial.Location = new System.Drawing.Point(60, 329);
            this.Wydzial.Name = "Wydzial";
            this.Wydzial.Size = new System.Drawing.Size(64, 20);
            this.Wydzial.TabIndex = 17;
            this.Wydzial.Text = "Wydział";
            this.Wydzial.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBoxWydzial
            // 
            this.comboBoxWydzial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxWydzial.FormattingEnabled = true;
            this.comboBoxWydzial.Items.AddRange(new object[] {
            "Bioinżynierii Zwierząt",
            "Biologii i Biotechnologii",
            "Geoinżynierii",
            "Humanistyczny",
            "Kształtowania Środowiska i Rolnictwa",
            "Lekarski",
            "Matematyki i Informatyki",
            "Medycyny Weterynaryjnej",
            "Nauk Ekonomicznych",
            "Nauk Społecznych",
            "Nauk Technicznych",
            "Zdrowia Publicznego",
            "Nauki o Żywności",
            "Nauk o Środowisku",
            "Prawa i Administracji",
            "Sztuki",
            "Teologii"});
            this.comboBoxWydzial.Location = new System.Drawing.Point(214, 329);
            this.comboBoxWydzial.Name = "comboBoxWydzial";
            this.comboBoxWydzial.Size = new System.Drawing.Size(193, 28);
            this.comboBoxWydzial.TabIndex = 16;
            this.comboBoxWydzial.SelectedIndexChanged += new System.EventHandler(this.comboBoxWydzial_SelectedIndexChanged);
            // 
            // Kierunek
            // 
            this.Kierunek.AutoSize = true;
            this.Kierunek.BackColor = System.Drawing.Color.Transparent;
            this.Kierunek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kierunek.Location = new System.Drawing.Point(60, 363);
            this.Kierunek.Name = "Kierunek";
            this.Kierunek.Size = new System.Drawing.Size(71, 20);
            this.Kierunek.TabIndex = 19;
            this.Kierunek.Text = "Kierunek";
            this.Kierunek.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // comboBoxKierunek
            // 
            this.comboBoxKierunek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxKierunek.FormattingEnabled = true;
            this.comboBoxKierunek.Items.AddRange(new object[] {
            "Rybactwo",
            "Zootechnika",
            "Bioinżynieria Produkcji Żywności",
            "Zwierzęta w Rekreacji, Edukacji i Terapii",
            "Biologia",
            "Biotechnologia",
            "Mikrobiologia",
            "Budownictwo",
            "Geodezja i kartografia",
            "Gospodarka Przestrzenna",
            "Analiza i kreowanie trendów",
            "Dziedzictwo kulturowe i przyrodnicze",
            "Dziennikarstwo i komunikacja społeczna",
            "Filologia",
            "Filologia Polska",
            "Filozofia",
            "Historia",
            "Logopedia",
            "Stosunki międzynarodowe",
            "Wojskoznawstwo",
            "Leśnictwo",
            "Rolnictwo",
            "Ochrona środowiska",
            "Kierunek Lekarski",
            "Informatyka",
            "Matematyka",
            "Weterynaria",
            "Ekonomia",
            "Zarządzanie",
            "Pedagogika",
            "Politologia",
            "Praca socjalna",
            "Bezpieczeństwo narodowe",
            "Energetyka",
            "Inżyniera Bezpieczeństwa",
            "Mechatronika",
            "Pielęgniarstwo",
            "Położnictwo",
            "Gastronomia",
            "Towaroznawstwo",
            "Prawo",
            "Administracja",
            "Bezpieczeństwo wewnętrzne",
            "Edukacja artystyczna w zakresie sztuki muzycznej",
            "Edukacja artystyczna w zakresie sztuk plastycznych",
            "Teologia"});
            this.comboBoxKierunek.Location = new System.Drawing.Point(214, 363);
            this.comboBoxKierunek.Name = "comboBoxKierunek";
            this.comboBoxKierunek.Size = new System.Drawing.Size(193, 28);
            this.comboBoxKierunek.TabIndex = 18;
            this.comboBoxKierunek.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Szukaj
            // 
            this.Szukaj.AutoSize = true;
            this.Szukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Szukaj.Location = new System.Drawing.Point(447, 76);
            this.Szukaj.Name = "Szukaj";
            this.Szukaj.Size = new System.Drawing.Size(57, 20);
            this.Szukaj.TabIndex = 23;
            this.Szukaj.Text = "Szukaj";
            this.Szukaj.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxSzukaj
            // 
            this.textBoxSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSzukaj.Location = new System.Drawing.Point(526, 76);
            this.textBoxSzukaj.Name = "textBoxSzukaj";
            this.textBoxSzukaj.Size = new System.Drawing.Size(296, 26);
            this.textBoxSzukaj.TabIndex = 24;
            this.textBoxSzukaj.TextChanged += new System.EventHandler(this.textBoxSzukaj_TextChanged);
            // 
            // Semestr
            // 
            this.Semestr.AutoSize = true;
            this.Semestr.BackColor = System.Drawing.Color.Transparent;
            this.Semestr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Semestr.Location = new System.Drawing.Point(59, 397);
            this.Semestr.Name = "Semestr";
            this.Semestr.Size = new System.Drawing.Size(69, 20);
            this.Semestr.TabIndex = 29;
            this.Semestr.Text = "Semestr";
            this.Semestr.Click += new System.EventHandler(this.Semestr_Click);
            // 
            // comboBoxSemestr
            // 
            this.comboBoxSemestr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSemestr.FormattingEnabled = true;
            this.comboBoxSemestr.Items.AddRange(new object[] {
            "Pierwszy",
            "Drugi",
            "Trzeci",
            "Czwarty",
            "Piąty",
            "Szósty",
            "Siódmy"});
            this.comboBoxSemestr.Location = new System.Drawing.Point(214, 397);
            this.comboBoxSemestr.Name = "comboBoxSemestr";
            this.comboBoxSemestr.Size = new System.Drawing.Size(193, 28);
            this.comboBoxSemestr.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(427, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(489, 400);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonSzukaj
            // 
            this.buttonSzukaj.Location = new System.Drawing.Point(841, 76);
            this.buttonSzukaj.Name = "buttonSzukaj";
            this.buttonSzukaj.Size = new System.Drawing.Size(75, 23);
            this.buttonSzukaj.TabIndex = 31;
            this.buttonSzukaj.Text = "Szukaj";
            this.buttonSzukaj.UseVisualStyleBackColor = true;
            this.buttonSzukaj.Click += new System.EventHandler(this.buttonSzukaj_Click);
            // 
            // Pracownik
            // 
            this.Pracownik.BackColor = System.Drawing.Color.Coral;
            this.Pracownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pracownik.Location = new System.Drawing.Point(30, 553);
            this.Pracownik.Name = "Pracownik";
            this.Pracownik.Size = new System.Drawing.Size(118, 52);
            this.Pracownik.TabIndex = 32;
            this.Pracownik.Text = "Dodaj Pracownika";
            this.Pracownik.UseVisualStyleBackColor = false;
            this.Pracownik.Click += new System.EventHandler(this.button1_Click);
            // 
            // Uczelnia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(950, 629);
            this.Controls.Add(this.Pracownik);
            this.Controls.Add(this.buttonSzukaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Semestr);
            this.Controls.Add(this.comboBoxSemestr);
            this.Controls.Add(this.textBoxSzukaj);
            this.Controls.Add(this.Szukaj);
            this.Controls.Add(this.Kierunek);
            this.Controls.Add(this.comboBoxKierunek);
            this.Controls.Add(this.Wydzial);
            this.Controls.Add(this.comboBoxWydzial);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.Plec);
            this.Controls.Add(this.comboBoxPlec);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.textBoxNumerTelefonu);
            this.Controls.Add(this.NumerTelefonu);
            this.Controls.Add(this.TextBoxNazwisko);
            this.Controls.Add(this.Nazwisko);
            this.Controls.Add(this.TextBoxImie);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Uczelnia";
            this.Text = "Uczelnia";
            this.Load += new System.EventHandler(this.Uczelnia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.TextBox TextBoxImie;
        private System.Windows.Forms.Label Imie;
        private System.Windows.Forms.TextBox TextBoxNazwisko;
        private System.Windows.Forms.Label Nazwisko;
        private System.Windows.Forms.TextBox textBoxNumerTelefonu;
        private System.Windows.Forms.Label NumerTelefonu;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.ComboBox comboBoxPlec;
        private System.Windows.Forms.Label Plec;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label Wydzial;
        private System.Windows.Forms.ComboBox comboBoxWydzial;
        private System.Windows.Forms.Label Kierunek;
        private System.Windows.Forms.ComboBox comboBoxKierunek;
        private System.Windows.Forms.Label Szukaj;
        private System.Windows.Forms.TextBox textBoxSzukaj;
        private System.Windows.Forms.Label Semestr;
        private System.Windows.Forms.ComboBox comboBoxSemestr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSzukaj;
        private System.Windows.Forms.Button Pracownik;
    }
}

