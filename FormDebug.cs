using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Sys = System.Windows.Forms;

using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;


namespace ExcelFinderComparator
{
    public partial class FormDebug : Form
    {
        public FormDebug()
        {
            InitializeComponent();
        }

        int cnt = 0;
        bool taskEn = false;

        private void button_apply_Click(object sender, EventArgs e)
        {



        }

        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button_debug_start_Click(object sender, EventArgs e)
        {
            taskEn = true;
            LoopAsync();
        }

        private void button_debug_stop_Click(object sender, EventArgs e)
        {
            taskEn = false;
        }

        async void LoopAsync()
        {
            await Task.Run(Loop);
        }

        void Loop()
        {
            while (taskEn)
            {
                cnt++;
                
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            richTextBox1.AppendText(cnt.ToString());
            textBox_debug.Text = cnt.ToString();
        }
    }
}
