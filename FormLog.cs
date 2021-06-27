using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelFinderComparator
{
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }



        void UpdateLog()
        {
            richTextBox_log.Clear();
            foreach (string s in Log.listMessages)
            {
                richTextBox_log.AppendText(s);
            }
        }





        private void FormLog_Activated(object sender, EventArgs e)
        {
            UpdateLog();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            UpdateLog();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Log.listMessages.Clear();
            richTextBox_log.Clear();
        }

        private void button_close_log_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
