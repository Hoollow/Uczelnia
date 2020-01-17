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
            this.Close();
        }
        //dodaj
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (TextBoxID.Text == "0")
            {
                MessageBox.Show("Nie można dodać ID. Prosze wybrać inna wartość niż 0!");
            }
            else
            {
                string txtQuery = "insert into Studenci (ID,Imie,Nazwisko,NumerTelefonu,AdresZamieszkania,Plec,Wydzial,Kierunek,Semestr)values('" + TextBoxID.Text + "','" + TextBoxImie.Text + "','" + TextBoxNazwisko.Text + "','" + textBoxNumerTelefonu.Text + "','" + textBoxAdres.Text + "','" + comboBoxPlec.Text + "','" + comboBoxWydzial.Text + "','" + comboBoxKierunek.Text + "','" + comboBoxSemestr.Text + "')";
                Execquery(txtQuery);
                LoadData();
                Dodaj p_studenta = new Dodaj("");
            }

        }
        //usun
        private void buttonUsun_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from Studenci where ID= '" + TextBoxID.Text + "'";
            Execquery(txtQuery);
            LoadData();
            Usun p_studenta = new Usun("");
        }
        //aktualizuj
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
          string txtQuery = "update Studenci set Imie='"+TextBoxImie.Text+"' where ID='"+TextBoxID.Text+"'";
            string txtQuery2 = "update Studenci set Nazwisko='" + TextBoxNazwisko.Text + "' where ID='" + TextBoxID.Text + "'";
            string txtQuery3 = "update Studenci set NumerTelefonu='" + textBoxNumerTelefonu.Text + "' where ID='" + TextBoxID.Text + "'";
            string txtQuery4 = "update Studenci set AdresZamieszkania='" + textBoxAdres.Text + "' where ID='" + TextBoxID.Text + "'";
            string txtQuery5 = "update Studenci set Semestr='" + comboBoxSemestr.Text + "' where ID='" + TextBoxID.Text + "'";
            Execquery(txtQuery);
            Execquery(txtQuery2);
            Execquery(txtQuery3);
            Execquery(txtQuery4);
            Execquery(txtQuery5);
            LoadData();
            Update p_studenta = new Update("");
        }
        //clearrrr
        private void buttonClear_Click(object sender, EventArgs e)
        {
            TextBoxID.Clear();
            TextBoxImie.Clear();
            TextBoxNazwisko.Clear();
            textBoxNumerTelefonu.Clear();
            textBoxAdres.Clear();
            comboBoxPlec.SelectedIndex = -1;
            comboBoxWydzial.SelectedIndex = -1;
            comboBoxSemestr.SelectedIndex = -1;
            comboBoxKierunek.SelectedIndex = -1;

        }


        private void textBoxSzukaj_TextChanged(object sender, EventArgs e)
        {
            string txtQuery = "Select * from Studenci Where ID= '" + TextBoxID.Text + "'";
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TextBoxID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            TextBoxImie.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            TextBoxNazwisko.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBoxNumerTelefonu.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBoxAdres.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comboBoxWydzial.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comboBoxKierunek.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comboBoxSemestr.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }
        //Wyszukiwanie po ID
        private void buttonSzukaj_Click(object sender, EventArgs e)
        {
            SetConnect();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from Studenci where Id = '"+ textBoxSzukaj.Text+"'";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 secondForm = new Form1();
            secondForm.Show();
        }

        private void Uczelnia_Load(object sender, EventArgs e)
        {

        }

        private void Semestr_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
