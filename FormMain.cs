using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using Microsoft.Office.Interop.Excel;
//using Microsoft.Office.Interop;

namespace ExcelFinderComparator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        Excel excel = null;

        private void button_open_file1_Click(object sender, EventArgs e)
        {
            openFileDialog_file1.ShowDialog();
        }

        private void button_open_file2_Click(object sender, EventArgs e)
        {
            openFileDialog_file2.ShowDialog();
        }

        private void openFileDialog_file1_FileOk(object sender, CancelEventArgs e)
        {
            textBox_path1.Text = openFileDialog_file1.FileName;
        }
        private void openFileDialog_file2_FileOk(object sender, CancelEventArgs e)
        {
            textBox_path2.Text = openFileDialog_file2.FileName;
        }

        private void button_src_open_Click(object sender, EventArgs e)
        {
            
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_debug_Click(object sender, EventArgs e)
        {
            FormDebug formDebug = new FormDebug();
            formDebug.Show();
        }

        private void button_log_Click(object sender, EventArgs e)
        {
            FormLog formLog = new FormLog();
            formLog.Show();
        }

        private void button_compare_Click(object sender, EventArgs e)
        {
            Compare();

            //Comparator comparator = new Comparator();
            //comparator.Compare(textBox_path1.Text, textBox_range1.Text, textBox_range2.Text);
        }

        void Compare()
        {
            string path2;
            if (checkBox_path_as_range1.Checked)
            {
                path2 = textBox_path1.Text;
            }
            else
            {
                path2 = textBox_path2.Text;
            }



            Excel.Config[] excelConfigs = { new Excel.Config(textBox_range1.Text, textBox_sheet1.Text, textBox_path1.Text),
                new Excel.Config(textBox_range2.Text, textBox_sheet2.Text, path2) };

            Comparator.Config comparatorConfig = new Comparator.Config();
            comparatorConfig.isMore1matches = checkBox_mark_more_1.Checked;

            excel = new Excel(excelConfigs);
            Comparator comparator = new Comparator(excel.sheets, excel.configs, comparatorConfig);
            comparator.CompareForEach1in2();
            excel.Close();
            MessageBox.Show("Completed");



        }

        private void button_find_Click(object sender, EventArgs e)
        {
            Find();
        }

        void Find()
        {
            string path2;
            if (checkBox_path_as_range1.Checked)
            {
                path2 = textBox_path1.Text;
            }
            else
            {
                path2 = textBox_path2.Text;
            }



            Excel.Config[] excelConfigs = { new Excel.Config(textBox_range1.Text, textBox_sheet1.Text, textBox_path1.Text),
                new Excel.Config(textBox_range2.Text, textBox_sheet2.Text, path2) };

            DataFinder.Config.isGetDataFrom1 = radioButton_get_data_range1.Checked;
            DataFinder.Config.isSetDataTo1 = radioButton_set_data_range1.Checked;

            if(int.TryParse(textBox_get_data_column.Text, out int getCol))
            {
                DataFinder.Config.getDataColumn = getCol;
            }
            else
            {
                DataFinder.Config.getDataColumn = textBox_get_data_column.Text;
            }

            if (int.TryParse(textBox_set_data_column.Text, out int setCol))
            {
                DataFinder.Config.setDataColumn = setCol;
            }
            else
            {
                DataFinder.Config.setDataColumn = textBox_set_data_column.Text;
            }

            excel = new Excel(excelConfigs);
            DataFinder dataFinder = new DataFinder(excel.sheets, excel.configs);
            dataFinder.Find();
            excel.Close();
            MessageBox.Show("Completed");

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (excel != null)
            {
                excel.DisconnectExcel();
            }
        }

        private void checkBox_path_as_range1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_path_as_range1.Checked)
            {
                textBox_path2.Enabled = false;
                button_open_file2.Enabled = false;
            }
            else
            {
                textBox_path2.Enabled = true;
                button_open_file2.Enabled = true;
            }
        }
    }
}
