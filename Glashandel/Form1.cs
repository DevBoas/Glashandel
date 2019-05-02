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
            Decimal realSpill = 0;

            if (Decimal.TryParse(TextBoxMaat.Text, out glasMaat))
            {
                storedValue = glasMaat;
                glasMaat = Math.Ceiling(glasMaat);
                overSpill = glasMaat - storedValue;
                realSpill = 1 - overSpill;

                MessageBox.Show("The realSpill = " + realSpill.ToString());
                MessageBox.Show("The overSpill = " + overSpill.ToString());
                if (rest >= realSpill)
                {

                    MessageBox.Show("Enough glass over to make the overspill");
                    rest -= realSpill;
                }
                else
                    rest += overSpill;

                MessageBox.Show("Glas over = " + rest.ToString());

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
