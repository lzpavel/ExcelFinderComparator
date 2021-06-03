using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace ExcelFinderComparator
{
    public partial class FormDebug : Form
    {
        public FormDebug()
        {
            InitializeComponent();
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            /*int cnt = 0;
            string str = textBox_debug.Text;
            if(str == null)
            {
                cnt++;
            }
            else if(str == "")
            {
                cnt++;
            }*/
            //Tools.ParsedRange ParsedRange = new Tools.ParsedRange(textBox1.Text);
            //richTextBox1.Text = ParsedRange.getColumn(0).ToString() + "\r\n";
            //richTextBox1.Text += ParsedRange.getColumn(1).ToString();
            /*Regex regexFormat = new Regex(@"[A-Z]+\d+:[A-Z]+\d+");
            Regex regex = new Regex(@"[A-Z]+\d+:[A-Z]+\d+");
            
            
            MatchCollection matchCollection = regex.Matches(textBox1.Text);
            string result = "";
            foreach(Match match in matchCollection)
            {
                result += match.Value + "\r\n";
            }
            richTextBox1.Text = result;*/
        }

        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
