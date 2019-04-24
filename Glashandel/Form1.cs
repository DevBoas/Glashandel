using System;
using System.Windows.Forms;

namespace Glashandel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Decimal rest = 0;

        private void Bereken_Click(object sender, EventArgs e)
        {
            int glasCost = 30;
            int snijCost = 10;

            Decimal glasMaat = 0;
            Decimal price = 0;
            Decimal storedValue = 0;
            Decimal overSpill = 0;
            if (Decimal.TryParse(TextBoxMaat.Text, out glasMaat))
            {
                storedValue = glasMaat;
                glasMaat = Math.Ceiling(glasMaat);
                overSpill = glasMaat - storedValue;
                // Overspill not working yet
                MessageBox.Show("overSpill = " + overSpill.ToString());
                if (rest >= overSpill)
                {
                    //MessageBox.Show("Enough rest to make the overspill");
                    //rest -= overSpill;
                }
                else
                    rest += overSpill;
                MessageBox.Show("Rest = " + rest.ToString());
                if (RadioSoort2.Checked)
                {
                    glasCost = 55;
                    snijCost = 25;
                }
                price = glasCost * glasMaat;
                if (price < 145)
                    price += snijCost;
                else if (price >= 250)
                    price = price * 0.95m;
                Output.Text = "Kosten: €" + price.ToString("0.##");
            }
        }
    }
}
