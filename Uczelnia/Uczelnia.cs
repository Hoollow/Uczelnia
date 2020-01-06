using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Uczelnia
{
    public partial class Uczelnia : Form
    {
        public Uczelnia()
        {
            InitializeComponent();
            LoadData();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //ustawienie polaczenia
        private void SetConnect()
        {
            sql_con = new SQLiteConnection("Data Source=Studenci.db;version=3;New=False;Compress=True");
        }
        //polaczenie
        private void Execquery(string txtQuery)
        {
            SetConnect();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }
        //wczytanie bazy
        private void LoadData()
        {
            SetConnect();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from Studenci";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBoxWydzial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //dodaj
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            string txtQuery = "insert into Studenci (ID,Imie,Nazwisko,NumerTelefonu,AdresZamieszkania,Plec,Wydzial,Kierunek,Semestr)values('" + TextBoxID.Text + "','" + TextBoxImie.Text + "','" + TextBoxNazwisko.Text + "','" + textBoxNumerTelefonu.Text + "','" + textBoxAdres.Text + "','" + comboBoxPlec.Text + "','" + comboBoxWydzial.Text + "','" + comboBoxKierunek.Text + "','" + comboBoxSemestr.Text + "')";
            Execquery(txtQuery);
            LoadData();
        }
        //usun
        private void buttonUsun_Click(object sender, EventArgs e)
        {
            
        }
        //aktualizuj
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
          
        }
        //clearrrr
        private void buttonClear_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
    }
}
