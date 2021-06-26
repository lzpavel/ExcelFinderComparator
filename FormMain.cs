using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
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

            Thread thread = new Thread(new ThreadStart(Compare));
            timer1.Enabled = true;
            thread.Start();

        }

        void LoadExcelConfig()
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

            Excel.configs = excelConfigs;
        }

        void LoadComparatorConfig()
        {
            Comparator.Config.isMore1matches = checkBox_mark_more_1.Checked;

            Comparator.excelConfigs = Excel.configs;
            Comparator.sheets = Excel.sheets;
        }

        void Compare()
        {
            LoadExcelConfig();
            Excel.OpenExcel();
            Excel.OpenDocuments();

            LoadComparatorConfig();
            Comparator.CompareForEach1in2();

            Excel.Save();
            Excel.CloseDocuments();
            
        }

        private void button_find_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(new ThreadStart(Find));
            timer1.Enabled = true;
            thread.Start();

        }



        void LoadFinderConfig()
        {
            Finder.Config.isGetDataFrom1 = radioButton_get_data_range1.Checked;
            Finder.Config.isSetDataTo1 = radioButton_set_data_range1.Checked;

            if (int.TryParse(textBox_get_data_column.Text, out int getCol))
            {
                Finder.Config.getDataColumn = getCol;
            }
            else
            {
                Finder.Config.getDataColumn = textBox_get_data_column.Text;
            }

            if (int.TryParse(textBox_set_data_column.Text, out int setCol))
            {
                Finder.Config.setDataColumn = setCol;
            }
            else
            {
                Finder.Config.setDataColumn = textBox_set_data_column.Text;
            }

            Finder.excelConfigs = Excel.configs;
            Finder.sheets = Excel.sheets;
        }

        void Find()
        {
            LoadExcelConfig();
            Excel.OpenExcel();
            Excel.OpenDocuments();

            LoadFinderConfig();
            Finder.Find();

            Excel.Save();
            Excel.CloseDocuments();

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Excel.CloseExcel();
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

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Progress.isReady)
            {
                progressBar1.Maximum = Progress.total;
                progressBar1.Value = 0;
                Progress.isReady = false;
                Progress.isRunning = true;
            }

            if (Progress.isRunning)
            {
                progressBar1.Value = Progress.now;
                label_progress.Text = Progress.now.ToString() + " / " + Progress.total.ToString();
            }

            if (Progress.isCompleted)
            {
                label_progress.Text = "Completed: " + Progress.now.ToString() + " / " + Progress.total.ToString();

                Progress.isRunning = false;
                Progress.isCompleted = false;

                timer1.Enabled = false;

            }
            
        }
    }
}
