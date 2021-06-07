namespace ExcelFinderComparator
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_open_file1 = new System.Windows.Forms.Button();
            this.textBox_path1 = new System.Windows.Forms.TextBox();
            this.groupBox_range1 = new System.Windows.Forms.GroupBox();
            this.textBox_sheet1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_range1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog_file1 = new System.Windows.Forms.OpenFileDialog();
            this.button_execute = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.groupBox_range2 = new System.Windows.Forms.GroupBox();
            this.checkBox_path_as_range1 = new System.Windows.Forms.CheckBox();
            this.textBox_path2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_sheet2 = new System.Windows.Forms.TextBox();
            this.button_open_file2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_range2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_debug = new System.Windows.Forms.Button();
            this.button_log = new System.Windows.Forms.Button();
            this.tabControl_action = new System.Windows.Forms.TabControl();
            this.tabPage_comparator = new System.Windows.Forms.TabPage();
            this.checkBox_each_in_range2 = new System.Windows.Forms.CheckBox();
            this.checkBox_each_in_range1 = new System.Windows.Forms.CheckBox();
            this.button_compare = new System.Windows.Forms.Button();
            this.tabPage_finder = new System.Windows.Forms.TabPage();
            this.groupBox_settings = new System.Windows.Forms.GroupBox();
            this.textBox_regex = new System.Windows.Forms.TextBox();
            this.checkBox_regex_en = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog_file2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox_range1.SuspendLayout();
            this.groupBox_range2.SuspendLayout();
            this.tabControl_action.SuspendLayout();
            this.tabPage_comparator.SuspendLayout();
            this.groupBox_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_open_file1
            // 
            this.button_open_file1.Location = new System.Drawing.Point(221, 27);
            this.button_open_file1.Margin = new System.Windows.Forms.Padding(4);
            this.button_open_file1.Name = "button_open_file1";
            this.button_open_file1.Size = new System.Drawing.Size(28, 22);
            this.button_open_file1.TabIndex = 0;
            this.button_open_file1.Text = "...";
            this.button_open_file1.UseVisualStyleBackColor = true;
            this.button_open_file1.Click += new System.EventHandler(this.button_open_file1_Click);
            // 
            // textBox_path1
            // 
            this.textBox_path1.Location = new System.Drawing.Point(61, 27);
            this.textBox_path1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_path1.Name = "textBox_path1";
            this.textBox_path1.Size = new System.Drawing.Size(152, 22);
            this.textBox_path1.TabIndex = 1;
            // 
            // groupBox_range1
            // 
            this.groupBox_range1.Controls.Add(this.textBox_sheet1);
            this.groupBox_range1.Controls.Add(this.label3);
            this.groupBox_range1.Controls.Add(this.textBox_range1);
            this.groupBox_range1.Controls.Add(this.label2);
            this.groupBox_range1.Controls.Add(this.textBox_path1);
            this.groupBox_range1.Controls.Add(this.label1);
            this.groupBox_range1.Controls.Add(this.button_open_file1);
            this.groupBox_range1.Location = new System.Drawing.Point(16, 13);
            this.groupBox_range1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_range1.Name = "groupBox_range1";
            this.groupBox_range1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_range1.Size = new System.Drawing.Size(259, 127);
            this.groupBox_range1.TabIndex = 2;
            this.groupBox_range1.TabStop = false;
            this.groupBox_range1.Text = "Range1";
            // 
            // textBox_sheet1
            // 
            this.textBox_sheet1.Location = new System.Drawing.Point(104, 57);
            this.textBox_sheet1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_sheet1.Name = "textBox_sheet1";
            this.textBox_sheet1.Size = new System.Drawing.Size(132, 22);
            this.textBox_sheet1.TabIndex = 5;
            this.textBox_sheet1.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sheet:";
            // 
            // textBox_range1
            // 
            this.textBox_range1.Location = new System.Drawing.Point(104, 87);
            this.textBox_range1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_range1.Name = "textBox_range1";
            this.textBox_range1.Size = new System.Drawing.Size(132, 22);
            this.textBox_range1.TabIndex = 3;
            this.textBox_range1.Text = "A1:A2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data range:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path:";
            // 
            // openFileDialog_file1
            // 
            this.openFileDialog_file1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_file1_FileOk);
            // 
            // button_execute
            // 
            this.button_execute.Location = new System.Drawing.Point(13, 563);
            this.button_execute.Margin = new System.Windows.Forms.Padding(4);
            this.button_execute.Name = "button_execute";
            this.button_execute.Size = new System.Drawing.Size(100, 28);
            this.button_execute.TabIndex = 6;
            this.button_execute.Text = "Execute";
            this.button_execute.UseVisualStyleBackColor = true;
            this.button_execute.Click += new System.EventHandler(this.button_execute_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(460, 563);
            this.button_close.Margin = new System.Windows.Forms.Padding(4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(100, 28);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // groupBox_range2
            // 
            this.groupBox_range2.Controls.Add(this.checkBox_path_as_range1);
            this.groupBox_range2.Controls.Add(this.textBox_path2);
            this.groupBox_range2.Controls.Add(this.label6);
            this.groupBox_range2.Controls.Add(this.textBox_sheet2);
            this.groupBox_range2.Controls.Add(this.button_open_file2);
            this.groupBox_range2.Controls.Add(this.label4);
            this.groupBox_range2.Controls.Add(this.textBox_range2);
            this.groupBox_range2.Controls.Add(this.label5);
            this.groupBox_range2.Location = new System.Drawing.Point(283, 13);
            this.groupBox_range2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_range2.Name = "groupBox_range2";
            this.groupBox_range2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_range2.Size = new System.Drawing.Size(313, 127);
            this.groupBox_range2.TabIndex = 6;
            this.groupBox_range2.TabStop = false;
            this.groupBox_range2.Text = "Range2";
            // 
            // checkBox_path_as_range1
            // 
            this.checkBox_path_as_range1.AutoSize = true;
            this.checkBox_path_as_range1.Checked = true;
            this.checkBox_path_as_range1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_path_as_range1.Location = new System.Drawing.Point(200, 29);
            this.checkBox_path_as_range1.Name = "checkBox_path_as_range1";
            this.checkBox_path_as_range1.Size = new System.Drawing.Size(99, 21);
            this.checkBox_path_as_range1.TabIndex = 14;
            this.checkBox_path_as_range1.Text = "As range 1";
            this.checkBox_path_as_range1.UseVisualStyleBackColor = true;
            // 
            // textBox_path2
            // 
            this.textBox_path2.Location = new System.Drawing.Point(57, 27);
            this.textBox_path2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_path2.Name = "textBox_path2";
            this.textBox_path2.Size = new System.Drawing.Size(100, 22);
            this.textBox_path2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Path:";
            // 
            // textBox_sheet2
            // 
            this.textBox_sheet2.Location = new System.Drawing.Point(100, 55);
            this.textBox_sheet2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_sheet2.Name = "textBox_sheet2";
            this.textBox_sheet2.Size = new System.Drawing.Size(132, 22);
            this.textBox_sheet2.TabIndex = 5;
            this.textBox_sheet2.Text = "1";
            // 
            // button_open_file2
            // 
            this.button_open_file2.Location = new System.Drawing.Point(165, 27);
            this.button_open_file2.Margin = new System.Windows.Forms.Padding(4);
            this.button_open_file2.Name = "button_open_file2";
            this.button_open_file2.Size = new System.Drawing.Size(28, 22);
            this.button_open_file2.TabIndex = 12;
            this.button_open_file2.Text = "...";
            this.button_open_file2.UseVisualStyleBackColor = true;
            this.button_open_file2.Click += new System.EventHandler(this.button_open_file2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sheet:";
            // 
            // textBox_range2
            // 
            this.textBox_range2.Location = new System.Drawing.Point(100, 87);
            this.textBox_range2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_range2.Name = "textBox_range2";
            this.textBox_range2.Size = new System.Drawing.Size(132, 22);
            this.textBox_range2.TabIndex = 3;
            this.textBox_range2.Text = "A1:A2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data range:";
            // 
            // button_debug
            // 
            this.button_debug.Location = new System.Drawing.Point(120, 563);
            this.button_debug.Name = "button_debug";
            this.button_debug.Size = new System.Drawing.Size(96, 28);
            this.button_debug.TabIndex = 8;
            this.button_debug.Text = "Debug";
            this.button_debug.UseVisualStyleBackColor = true;
            this.button_debug.Click += new System.EventHandler(this.button_debug_Click);
            // 
            // button_log
            // 
            this.button_log.Location = new System.Drawing.Point(222, 563);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(75, 28);
            this.button_log.TabIndex = 9;
            this.button_log.Text = "Log";
            this.button_log.UseVisualStyleBackColor = true;
            this.button_log.Click += new System.EventHandler(this.button_log_Click);
            // 
            // tabControl_action
            // 
            this.tabControl_action.Controls.Add(this.tabPage_comparator);
            this.tabControl_action.Controls.Add(this.tabPage_finder);
            this.tabControl_action.Location = new System.Drawing.Point(12, 237);
            this.tabControl_action.Name = "tabControl_action";
            this.tabControl_action.SelectedIndex = 0;
            this.tabControl_action.Size = new System.Drawing.Size(529, 319);
            this.tabControl_action.TabIndex = 10;
            // 
            // tabPage_comparator
            // 
            this.tabPage_comparator.Controls.Add(this.checkBox_each_in_range2);
            this.tabPage_comparator.Controls.Add(this.checkBox_each_in_range1);
            this.tabPage_comparator.Controls.Add(this.button_compare);
            this.tabPage_comparator.Location = new System.Drawing.Point(4, 25);
            this.tabPage_comparator.Name = "tabPage_comparator";
            this.tabPage_comparator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_comparator.Size = new System.Drawing.Size(521, 290);
            this.tabPage_comparator.TabIndex = 0;
            this.tabPage_comparator.Text = "Comparator";
            this.tabPage_comparator.UseVisualStyleBackColor = true;
            // 
            // checkBox_each_in_range2
            // 
            this.checkBox_each_in_range2.AutoSize = true;
            this.checkBox_each_in_range2.Location = new System.Drawing.Point(365, 6);
            this.checkBox_each_in_range2.Name = "checkBox_each_in_range2";
            this.checkBox_each_in_range2.Size = new System.Drawing.Size(150, 38);
            this.checkBox_each_in_range2.TabIndex = 2;
            this.checkBox_each_in_range2.Text = "For each in range2\r\nsearch in range1";
            this.checkBox_each_in_range2.UseVisualStyleBackColor = true;
            // 
            // checkBox_each_in_range1
            // 
            this.checkBox_each_in_range1.AutoSize = true;
            this.checkBox_each_in_range1.Checked = true;
            this.checkBox_each_in_range1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_each_in_range1.Location = new System.Drawing.Point(6, 6);
            this.checkBox_each_in_range1.Name = "checkBox_each_in_range1";
            this.checkBox_each_in_range1.Size = new System.Drawing.Size(150, 38);
            this.checkBox_each_in_range1.TabIndex = 1;
            this.checkBox_each_in_range1.Text = "For each in range1\r\nsearch in range2";
            this.checkBox_each_in_range1.UseVisualStyleBackColor = true;
            // 
            // button_compare
            // 
            this.button_compare.Location = new System.Drawing.Point(6, 256);
            this.button_compare.Name = "button_compare";
            this.button_compare.Size = new System.Drawing.Size(100, 28);
            this.button_compare.TabIndex = 0;
            this.button_compare.Text = "Compare";
            this.button_compare.UseVisualStyleBackColor = true;
            this.button_compare.Click += new System.EventHandler(this.button_compare_Click);
            // 
            // tabPage_finder
            // 
            this.tabPage_finder.Location = new System.Drawing.Point(4, 25);
            this.tabPage_finder.Name = "tabPage_finder";
            this.tabPage_finder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_finder.Size = new System.Drawing.Size(521, 290);
            this.tabPage_finder.TabIndex = 1;
            this.tabPage_finder.Text = "Finder";
            this.tabPage_finder.UseVisualStyleBackColor = true;
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.Controls.Add(this.textBox_regex);
            this.groupBox_settings.Controls.Add(this.checkBox_regex_en);
            this.groupBox_settings.Location = new System.Drawing.Point(16, 147);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Size = new System.Drawing.Size(526, 84);
            this.groupBox_settings.TabIndex = 11;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "Settings";
            // 
            // textBox_regex
            // 
            this.textBox_regex.Location = new System.Drawing.Point(6, 48);
            this.textBox_regex.Name = "textBox_regex";
            this.textBox_regex.Size = new System.Drawing.Size(514, 22);
            this.textBox_regex.TabIndex = 1;
            // 
            // checkBox_regex_en
            // 
            this.checkBox_regex_en.AutoSize = true;
            this.checkBox_regex_en.Location = new System.Drawing.Point(6, 21);
            this.checkBox_regex_en.Name = "checkBox_regex_en";
            this.checkBox_regex_en.Size = new System.Drawing.Size(152, 21);
            this.checkBox_regex_en.TabIndex = 0;
            this.checkBox_regex_en.Text = "Regular expression";
            this.checkBox_regex_en.UseVisualStyleBackColor = true;
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Red;
            // 
            // openFileDialog_file2
            // 
            this.openFileDialog_file2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_file2_FileOk);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 633);
            this.Controls.Add(this.groupBox_settings);
            this.Controls.Add(this.tabControl_action);
            this.Controls.Add(this.button_log);
            this.Controls.Add(this.button_debug);
            this.Controls.Add(this.groupBox_range2);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_execute);
            this.Controls.Add(this.groupBox_range1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Finder & Comparator";
            this.groupBox_range1.ResumeLayout(false);
            this.groupBox_range1.PerformLayout();
            this.groupBox_range2.ResumeLayout(false);
            this.groupBox_range2.PerformLayout();
            this.tabControl_action.ResumeLayout(false);
            this.tabPage_comparator.ResumeLayout(false);
            this.tabPage_comparator.PerformLayout();
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_open_file1;
        private System.Windows.Forms.TextBox textBox_path1;
        private System.Windows.Forms.GroupBox groupBox_range1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_file1;
        private System.Windows.Forms.TextBox textBox_sheet1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_range1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_execute;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.GroupBox groupBox_range2;
        private System.Windows.Forms.TextBox textBox_sheet2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_range2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_debug;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.TabControl tabControl_action;
        private System.Windows.Forms.TabPage tabPage_comparator;
        private System.Windows.Forms.TabPage tabPage_finder;
        private System.Windows.Forms.TextBox textBox_path2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_open_file2;
        private System.Windows.Forms.GroupBox groupBox_settings;
        private System.Windows.Forms.TextBox textBox_regex;
        private System.Windows.Forms.CheckBox checkBox_regex_en;
        private System.Windows.Forms.Button button_compare;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox checkBox_each_in_range2;
        private System.Windows.Forms.CheckBox checkBox_each_in_range1;
        private System.Windows.Forms.CheckBox checkBox_path_as_range1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_file2;
    }
}

