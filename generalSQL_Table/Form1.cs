using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generalSQL_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ColumnAmountControl(2);
        }

        private void ColumnTextAndLabelHide(Label[] labels, TextBox[] textBoxs)
        {
            for(int i = 0; i < labels.Length; i++)
            {
                labels[i].Visible = false;
                textBoxs[i].Visible = false;
            }
        }

        private void ColumnAmountControl(int AmountToShow)
        {
            Label[] labels = { FirstLabel, SecondLabel, ThirdLabel, FourthLabel, FifthLabel, SixthLabel, SeventhLabel, EigthLabel };
            TextBox[] textBoxs = { FirstColBox, SecondColBox, ThirdColBox, FourthColBox, FifthColBox, SixthColBox, SeventhColBox, EightColBox };

            ColumnTextAndLabelHide(labels, textBoxs);
            for(int i = 0; i <= AmountToShow; i++)
            {
                labels[i].Visible = true;
                textBoxs[i].Visible = true;
            }
        }

        private void ColumnNumberBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColumnAmountControl(ColumnNumberBox.SelectedIndex);
        }

        private void ColumnNumberBox_TextUpdate(object sender, EventArgs e)
        {
            if (string.Compare(ColumnNumberBox.Text.ToString(), "1") < 0 || string.Compare(ColumnNumberBox.Text.ToString(), "8") > 0) 
            {
                MessageBox.Show("Only a number between 8 and 1", "Wrong Column number", MessageBoxButtons.OK);
                ColumnNumberBox.Text = ColumnNumberBox.SelectedItem.ToString();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
