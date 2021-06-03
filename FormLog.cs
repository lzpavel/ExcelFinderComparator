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

        public static string log = "";

        private void FormLog_Activated(object sender, EventArgs e)
        {
            richTextBox_log.Text = log;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            richTextBox_log.Text = log;
        }
    }
}
