using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uczelnia
{
    class Dodaj
    {
        public string myMsg;
        public Dodaj(string msg)
        {
            myMsg = msg;
            MessageBox.Show("Pomyślnie dodano studenta!");
        }
    }
    class Dodaj2
    {
        public string myMsg;
        public Dodaj2(string msg)
        {
            myMsg = msg;
            MessageBox.Show("Pomyślnie dodano pracownika!");
        }
    }
    class Update
    {
        public string myMsg;
        public Update(string msg)
        {
            myMsg = msg;
            MessageBox.Show("Pomyślnie zaktualizowano dane studenta!");
        }
    }
    class Usun
    {
        public string myMsg;
        public Usun(string msg)
        {
            myMsg = msg;
            MessageBox.Show("Pomyślnie usunięto studenta!");
        }
    }
    class Usun2
    {
        public string myMsg;
        public Usun2(string msg)
        {
            myMsg = msg;
            MessageBox.Show("Pomyślnie usunięto pracownika!");
        }
    }
    class Update2
    {
        public string myMsg;
        public Update2(string msg)
        {
            myMsg = msg;
            MessageBox.Show("Pomyślnie zaktualizowano dane pracownika!");
        }
    }
}
