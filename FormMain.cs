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

        string filePath = null;
        
        

        private void button_src_open_Click(object sender, EventArgs e)
        {
            openFileDialog_src.ShowDialog();
        }

        private void openFileDialog_src_FileOk(object sender, CancelEventArgs e)
        {
            filePath = openFileDialog_src.FileName;
            textBox_path1.Text = filePath;
            FormLog.log = "File selected.";
        }

        private void button_execute_Click(object sender, EventArgs e)
        {
            
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            
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
            Comparator comparator = new Comparator();
            comparator.Compare(textBox_path1.Text, textBox_range1.Text, textBox_range2.Text);
        }
    }
}
