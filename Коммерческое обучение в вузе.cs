using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (СПЕЦИАЛЬНОСТИ ventanaСпец = new СПЕЦИАЛЬНОСТИ())
                ventanaСпец.ShowDialog();
        }

        private void СТУДЕНТЫ_Click(object sender, EventArgs e)
        {
            using (СТУДЕНТЫ ventanaСтуде = new СТУДЕНТЫ())
                ventanaСтуде.ShowDialog();
        }

        private void ОБУЧЕНИЕ_Click(object sender, EventArgs e)
        {
            using (ОБУЧЕНИЕ ventanaОбу = new ОБУЧЕНИЕ())
                ventanaОбу.ShowDialog();
        }
    }
}
