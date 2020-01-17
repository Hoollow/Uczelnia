using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//SQLite użyte do podłączenia lokalnej bazy
using System.Data.SQLite;

namespace Uczelnia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
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
            string CommandText = "select * from Pracownicy";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        //dodaj
        private void Bdodaj_Click(object sender, EventArgs e)
        {
            if(textBoxID.Text=="0")
            {
                MessageBox.Show("Nie można dodać ID. Prosze wybrać inna wartość niż 0!");
            }
            else
            {
                string txtQuery = "insert into Pracownicy (ID,Imie,Nazwisko,NumerT,Adres,Wyksztalcenie,Zatrudnienie)values('" + textBoxID.Text + "','" + TextBoxImie.Text + "','" + TextBoxNazwisko.Text + "','" + textBoxNumerTelefonu.Text + "','" + textBoxAdres.Text + "','" + textBoxWyksztalcenie.Text + "','" + textBoxZatrudnienie.Text + "')";
                Execquery(txtQuery);
                LoadData();
                Dodaj2 p_pracownik = new Dodaj2("");
            }
  
        }
        //usun
        private void Busun_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from Pracownicy where ID= '" + textBoxID.Text + "'";
            Execquery(txtQuery);
            LoadData();
            Usun2 p_pracownik = new Usun2("");
        }
        //update
        private void Bupdate_Click(object sender, EventArgs e)
        {
            string txtQuery = "update Pracownicy set Imie='" + TextBoxImie.Text + "' where ID='" + textBoxID.Text + "'";
            string txtQuery2 = "update Pracownicy set Nazwisko='" + TextBoxNazwisko.Text + "' where ID='" + textBoxID.Text + "'";
            string txtQuery3 = "update Pracownicy set NumerT='" + textBoxNumerTelefonu.Text + "' where ID='" + textBoxID.Text + "'";
            string txtQuery4 = "update Pracownicy set Adres='" + textBoxAdres.Text + "' where ID='" + textBoxID.Text + "'";
            string txtQuery5 = "update Pracownicy set Wyksztalcenie='" + textBoxAdres.Text + "' where ID='" + textBoxID.Text + "'";
            string txtQuery6 = "update Pracownicy set Zatrudnienie='" + textBoxAdres.Text + "' where ID='" + textBoxID.Text + "'";

            Execquery(txtQuery);
            Execquery(txtQuery2);
            Execquery(txtQuery3);
            Execquery(txtQuery4);
            Execquery(txtQuery5);
            Execquery(txtQuery6);
            LoadData();
            Update2 p_pracownik = new Update2("");

        }
        //clear
        private void Bclear_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            TextBoxImie.Clear();
            TextBoxNazwisko.Clear();
            textBoxNumerTelefonu.Clear();
            textBoxAdres.Clear();
            textBoxWyksztalcenie.Clear();
            textBoxZatrudnienie.Clear();

        }

        //Wyszukiwanie po ID
        private void textBoxszukaj_TextChanged(object sender, EventArgs e)
        {
            SetConnect();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from Pracownicy where Id = '" + textBoxszukaj.Text + "'";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            TextBoxImie.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            TextBoxNazwisko.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxNumerTelefonu.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBoxAdres.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBoxWyksztalcenie.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBoxZatrudnienie.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
