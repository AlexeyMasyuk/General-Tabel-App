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
        private TextBox[] ColumnsNames;
        private Label[] ColumnmLabels;
        private int lastSelectedIndex = 1;

        public Form1()
        {
            InitializeComponent();
            ColumnsNames = BoxToArr();
            ColumnmLabels = LabelsToArr();
            ColumnTextAndLabelHideAndShow(2, true);
        }

        private TextBox[] BoxToArr()
        {
            TextBox[] textBoxs = {
                FirstColBox,
                SecondColBox,
                ThirdColBox,
                FourthColBox,
                FifthColBox,
                SixthColBox,
                SeventhColBox,
                EightColBox
            };
            return textBoxs;
        }

        private Label[] LabelsToArr()
        {
            Label[] labels = { FirstLabel,
                SecondLabel,
                ThirdLabel,
                FourthLabel,
                FifthLabel,
                SixthLabel,
                SeventhLabel,
                EigthLabel
            };
            return labels;
        }

        private void ColumnTextAndLabelHideAndShow(int amount, bool show)
        {
            for(int i = 0; i < amount; i++)
            {
                ColumnsNames[i].Visible = show;
                ColumnmLabels[i].Visible = show;
            }
        }

        private void ColumnControl(int AmountToShow)
        {
            ColumnTextAndLabelHideAndShow(ColumnsNames.Length, false);
            ColumnTextAndLabelHideAndShow(AmountToShow, true);
        }

        private void ColumnNumberBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColumnControl(ColumnNumberBox.SelectedIndex + 1);
            lastSelectedIndex = ColumnNumberBox.SelectedIndex;
        }

        private void ColumnNumberBox_TextUpdate(object sender, EventArgs e)
        {
            if (string.Compare(ColumnNumberBox.Text.ToString(), "1") < 0 || string.Compare(ColumnNumberBox.Text.ToString(), "8") > 0) 
            {
                MessageBox.Show("Only a number between 8 and 1", "Wrong Column number", MessageBoxButtons.OK);
                ColumnNumberBox.SelectedIndex = lastSelectedIndex;
                ColumnNumberBox.Text = ColumnNumberBox.Items[lastSelectedIndex].ToString();
            }
        }

        private bool NamesBoxValidation()
        {
            for (int i = int.Parse(ColumnNumberBox.SelectedItem.ToString()) - 1; i >= 0; i--) 
                if (ColumnsNames[i].Text.ToString().Length == 0)
                    return false;
            return true;
        }

        private string[] FieldsToString()
        {            
            int amount = int.Parse(ColumnNumberBox.SelectedItem.ToString());
            string[] s_columnsNames = new string[amount];
            for (int i = 0; i < amount; i++)
                s_columnsNames[i] = ColumnsNames[i].Text.ToString();
            return s_columnsNames;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (NamesBoxValidation() && TableNameBox.Text.Length > 0) 
            {
                DBhandler.ConnectionString = "test";
                DBhandler DB = DBhandler.Instance;
                DB.TableBuilder(TableNameBox.Text.ToString(), FieldsToString());
            }
            else
                MessageBox.Show("Column Name field cannot be empty", "Empty Field", MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
