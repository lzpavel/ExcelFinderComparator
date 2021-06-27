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
            this.components = new System.ComponentModel.Container();
            this.button_open_file1 = new System.Windows.Forms.Button();
            this.textBox_path1 = new System.Windows.Forms.TextBox();
            this.groupBox_range1 = new System.Windows.Forms.GroupBox();
            this.textBox_sheet1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_range1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog_file1 = new System.Windows.Forms.OpenFileDialog();
            this.button_close = new System.Windows.Forms.Button();
            this.groupBox_range2 = new System.Windows.Forms.GroupBox();
            this.checkBox_path_as_range1 = new System.Windows.Forms.CheckBox();
            this.textBox_path2 = new System.Windows.Forms.TextBox();
            this.button_open_file2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_sheet2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_range2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_debug = new System.Windows.Forms.Button();
            this.button_log = new System.Windows.Forms.Button();
            this.tabControl_action = new System.Windows.Forms.TabControl();
            this.tabPage_comparator = new System.Windows.Forms.TabPage();
            this.checkBox_mark_more_1 = new System.Windows.Forms.CheckBox();
            this.button_compare = new System.Windows.Forms.Button();
            this.tabPage_data_finder = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_set_data_column = new System.Windows.Forms.TextBox();
            this.radioButton_set_data_range2 = new System.Windows.Forms.RadioButton();
            this.radioButton_set_data_range1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_get_data_column = new System.Windows.Forms.TextBox();
            this.radioButton_get_data_range2 = new System.Windows.Forms.RadioButton();
            this.radioButton_get_data_range1 = new System.Windows.Forms.RadioButton();
            this.button_find = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog_file2 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_progress = new System.Windows.Forms.GroupBox();
            this.label_progress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label_color_match = new System.Windows.Forms.Label();
            this.label_color_match_more1 = new System.Windows.Forms.Label();
            this.groupBox_range1.SuspendLayout();
            this.groupBox_range2.SuspendLayout();
            this.tabControl_action.SuspendLayout();
            this.tabPage_comparator.SuspendLayout();
            this.tabPage_data_finder.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_progress.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_open_file1
            // 
            this.button_open_file1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_open_file1.Location = new System.Drawing.Point(190, 22);
            this.button_open_file1.Name = "button_open_file1";
            this.button_open_file1.Size = new System.Drawing.Size(27, 20);
            this.button_open_file1.TabIndex = 0;
            this.button_open_file1.Text = "...";
            this.button_open_file1.UseVisualStyleBackColor = true;
            this.button_open_file1.Click += new System.EventHandler(this.button_open_file1_Click);
            // 
            // textBox_path1
            // 
            this.textBox_path1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_path1.Location = new System.Drawing.Point(46, 22);
            this.textBox_path1.Name = "textBox_path1";
            this.textBox_path1.Size = new System.Drawing.Size(138, 20);
            this.textBox_path1.TabIndex = 1;
            // 
            // groupBox_range1
            // 
            this.groupBox_range1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_range1.Controls.Add(this.textBox_sheet1);
            this.groupBox_range1.Controls.Add(this.label3);
            this.groupBox_range1.Controls.Add(this.textBox_range1);
            this.groupBox_range1.Controls.Add(this.label2);
            this.groupBox_range1.Controls.Add(this.textBox_path1);
            this.groupBox_range1.Controls.Add(this.label1);
            this.groupBox_range1.Controls.Add(this.button_open_file1);
            this.groupBox_range1.Location = new System.Drawing.Point(3, 3);
            this.groupBox_range1.Name = "groupBox_range1";
            this.groupBox_range1.Size = new System.Drawing.Size(224, 97);
            this.groupBox_range1.TabIndex = 2;
            this.groupBox_range1.TabStop = false;
            this.groupBox_range1.Text = "Range1";
            // 
            // textBox_sheet1
            // 
            this.textBox_sheet1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_sheet1.Location = new System.Drawing.Point(78, 46);
            this.textBox_sheet1.Name = "textBox_sheet1";
            this.textBox_sheet1.Size = new System.Drawing.Size(140, 20);
            this.textBox_sheet1.TabIndex = 5;
            this.textBox_sheet1.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sheet:";
            // 
            // textBox_range1
            // 
            this.textBox_range1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_range1.Location = new System.Drawing.Point(78, 71);
            this.textBox_range1.Name = "textBox_range1";
            this.textBox_range1.Size = new System.Drawing.Size(140, 20);
            this.textBox_range1.TabIndex = 3;
            this.textBox_range1.Text = "A1:A2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data range:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path:";
            // 
            // openFileDialog_file1
            // 
            this.openFileDialog_file1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_file1_FileOk);
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.Location = new System.Drawing.Point(398, 390);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // groupBox_range2
            // 
            this.groupBox_range2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_range2.Controls.Add(this.checkBox_path_as_range1);
            this.groupBox_range2.Controls.Add(this.textBox_path2);
            this.groupBox_range2.Controls.Add(this.button_open_file2);
            this.groupBox_range2.Controls.Add(this.label6);
            this.groupBox_range2.Controls.Add(this.textBox_sheet2);
            this.groupBox_range2.Controls.Add(this.label4);
            this.groupBox_range2.Controls.Add(this.textBox_range2);
            this.groupBox_range2.Controls.Add(this.label5);
            this.groupBox_range2.Location = new System.Drawing.Point(3, 3);
            this.groupBox_range2.Name = "groupBox_range2";
            this.groupBox_range2.Size = new System.Drawing.Size(224, 97);
            this.groupBox_range2.TabIndex = 6;
            this.groupBox_range2.TabStop = false;
            this.groupBox_range2.Text = "Range2";
            // 
            // checkBox_path_as_range1
            // 
            this.checkBox_path_as_range1.AutoSize = true;
            this.checkBox_path_as_range1.Checked = true;
            this.checkBox_path_as_range1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_path_as_range1.Location = new System.Drawing.Point(42, 24);
            this.checkBox_path_as_range1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_path_as_range1.Name = "checkBox_path_as_range1";
            this.checkBox_path_as_range1.Size = new System.Drawing.Size(77, 17);
            this.checkBox_path_as_range1.TabIndex = 14;
            this.checkBox_path_as_range1.Text = "As range 1";
            this.checkBox_path_as_range1.UseVisualStyleBackColor = true;
            this.checkBox_path_as_range1.CheckedChanged += new System.EventHandler(this.checkBox_path_as_range1_CheckedChanged);
            // 
            // textBox_path2
            // 
            this.textBox_path2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_path2.Enabled = false;
            this.textBox_path2.Location = new System.Drawing.Point(122, 22);
            this.textBox_path2.Name = "textBox_path2";
            this.textBox_path2.Size = new System.Drawing.Size(63, 20);
            this.textBox_path2.TabIndex = 13;
            // 
            // button_open_file2
            // 
            this.button_open_file2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_open_file2.Enabled = false;
            this.button_open_file2.Location = new System.Drawing.Point(191, 22);
            this.button_open_file2.Name = "button_open_file2";
            this.button_open_file2.Size = new System.Drawing.Size(27, 20);
            this.button_open_file2.TabIndex = 12;
            this.button_open_file2.Text = "...";
            this.button_open_file2.UseVisualStyleBackColor = true;
            this.button_open_file2.Click += new System.EventHandler(this.button_open_file2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Path:";
            // 
            // textBox_sheet2
            // 
            this.textBox_sheet2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_sheet2.Location = new System.Drawing.Point(75, 45);
            this.textBox_sheet2.Name = "textBox_sheet2";
            this.textBox_sheet2.Size = new System.Drawing.Size(143, 20);
            this.textBox_sheet2.TabIndex = 5;
            this.textBox_sheet2.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sheet:";
            // 
            // textBox_range2
            // 
            this.textBox_range2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_range2.Location = new System.Drawing.Point(75, 71);
            this.textBox_range2.Name = "textBox_range2";
            this.textBox_range2.Size = new System.Drawing.Size(143, 20);
            this.textBox_range2.TabIndex = 3;
            this.textBox_range2.Text = "A1:A2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data range:";
            // 
            // button_debug
            // 
            this.button_debug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_debug.Location = new System.Drawing.Point(71, 390);
            this.button_debug.Margin = new System.Windows.Forms.Padding(2);
            this.button_debug.Name = "button_debug";
            this.button_debug.Size = new System.Drawing.Size(72, 23);
            this.button_debug.TabIndex = 8;
            this.button_debug.Text = "Debug";
            this.button_debug.UseVisualStyleBackColor = true;
            this.button_debug.Click += new System.EventHandler(this.button_debug_Click);
            // 
            // button_log
            // 
            this.button_log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_log.Location = new System.Drawing.Point(11, 390);
            this.button_log.Margin = new System.Windows.Forms.Padding(2);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(56, 23);
            this.button_log.TabIndex = 9;
            this.button_log.Text = "Log";
            this.button_log.UseVisualStyleBackColor = true;
            this.button_log.Click += new System.EventHandler(this.button_log_Click);
            // 
            // tabControl_action
            // 
            this.tabControl_action.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_action.Controls.Add(this.tabPage_comparator);
            this.tabControl_action.Controls.Add(this.tabPage_data_finder);
            this.tabControl_action.Location = new System.Drawing.Point(11, 119);
            this.tabControl_action.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl_action.Name = "tabControl_action";
            this.tabControl_action.SelectedIndex = 0;
            this.tabControl_action.Size = new System.Drawing.Size(463, 199);
            this.tabControl_action.TabIndex = 10;
            // 
            // tabPage_comparator
            // 
            this.tabPage_comparator.Controls.Add(this.label_color_match_more1);
            this.tabPage_comparator.Controls.Add(this.label_color_match);
            this.tabPage_comparator.Controls.Add(this.label9);
            this.tabPage_comparator.Controls.Add(this.checkBox_mark_more_1);
            this.tabPage_comparator.Controls.Add(this.button_compare);
            this.tabPage_comparator.Location = new System.Drawing.Point(4, 22);
            this.tabPage_comparator.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_comparator.Name = "tabPage_comparator";
            this.tabPage_comparator.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_comparator.Size = new System.Drawing.Size(455, 173);
            this.tabPage_comparator.TabIndex = 0;
            this.tabPage_comparator.Text = "Comparator";
            this.tabPage_comparator.UseVisualStyleBackColor = true;
            // 
            // checkBox_mark_more_1
            // 
            this.checkBox_mark_more_1.AutoSize = true;
            this.checkBox_mark_more_1.Checked = true;
            this.checkBox_mark_more_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_mark_more_1.Location = new System.Drawing.Point(4, 26);
            this.checkBox_mark_more_1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_mark_more_1.Name = "checkBox_mark_more_1";
            this.checkBox_mark_more_1.Size = new System.Drawing.Size(111, 17);
            this.checkBox_mark_more_1.TabIndex = 3;
            this.checkBox_mark_more_1.Text = "Mark > 1 matches";
            this.checkBox_mark_more_1.UseVisualStyleBackColor = true;
            // 
            // button_compare
            // 
            this.button_compare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_compare.Location = new System.Drawing.Point(4, 146);
            this.button_compare.Margin = new System.Windows.Forms.Padding(2);
            this.button_compare.Name = "button_compare";
            this.button_compare.Size = new System.Drawing.Size(75, 23);
            this.button_compare.TabIndex = 0;
            this.button_compare.Text = "Compare";
            this.button_compare.UseVisualStyleBackColor = true;
            this.button_compare.Click += new System.EventHandler(this.button_compare_Click);
            // 
            // tabPage_data_finder
            // 
            this.tabPage_data_finder.Controls.Add(this.groupBox3);
            this.tabPage_data_finder.Controls.Add(this.groupBox2);
            this.tabPage_data_finder.Controls.Add(this.button_find);
            this.tabPage_data_finder.Location = new System.Drawing.Point(4, 22);
            this.tabPage_data_finder.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_data_finder.Name = "tabPage_data_finder";
            this.tabPage_data_finder.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_data_finder.Size = new System.Drawing.Size(428, 153);
            this.tabPage_data_finder.TabIndex = 1;
            this.tabPage_data_finder.Text = "Data Finder";
            this.tabPage_data_finder.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_set_data_column);
            this.groupBox3.Controls.Add(this.radioButton_set_data_range2);
            this.groupBox3.Controls.Add(this.radioButton_set_data_range1);
            this.groupBox3.Location = new System.Drawing.Point(4, 57);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(421, 46);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set data:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Column:";
            // 
            // textBox_set_data_column
            // 
            this.textBox_set_data_column.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_set_data_column.Location = new System.Drawing.Point(158, 16);
            this.textBox_set_data_column.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_set_data_column.Name = "textBox_set_data_column";
            this.textBox_set_data_column.Size = new System.Drawing.Size(132, 20);
            this.textBox_set_data_column.TabIndex = 3;
            this.textBox_set_data_column.Text = "A";
            // 
            // radioButton_set_data_range2
            // 
            this.radioButton_set_data_range2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_set_data_range2.AutoSize = true;
            this.radioButton_set_data_range2.Location = new System.Drawing.Point(339, 17);
            this.radioButton_set_data_range2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_set_data_range2.Name = "radioButton_set_data_range2";
            this.radioButton_set_data_range2.Size = new System.Drawing.Size(77, 17);
            this.radioButton_set_data_range2.TabIndex = 1;
            this.radioButton_set_data_range2.Text = "To range 2";
            this.radioButton_set_data_range2.UseVisualStyleBackColor = true;
            // 
            // radioButton_set_data_range1
            // 
            this.radioButton_set_data_range1.AutoSize = true;
            this.radioButton_set_data_range1.Checked = true;
            this.radioButton_set_data_range1.Location = new System.Drawing.Point(4, 17);
            this.radioButton_set_data_range1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_set_data_range1.Name = "radioButton_set_data_range1";
            this.radioButton_set_data_range1.Size = new System.Drawing.Size(77, 17);
            this.radioButton_set_data_range1.TabIndex = 0;
            this.radioButton_set_data_range1.TabStop = true;
            this.radioButton_set_data_range1.Text = "To range 1";
            this.radioButton_set_data_range1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_get_data_column);
            this.groupBox2.Controls.Add(this.radioButton_get_data_range2);
            this.groupBox2.Controls.Add(this.radioButton_get_data_range1);
            this.groupBox2.Location = new System.Drawing.Point(4, 5);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(421, 47);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get data:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Column:";
            // 
            // textBox_get_data_column
            // 
            this.textBox_get_data_column.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_get_data_column.Location = new System.Drawing.Point(158, 16);
            this.textBox_get_data_column.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_get_data_column.Name = "textBox_get_data_column";
            this.textBox_get_data_column.Size = new System.Drawing.Size(132, 20);
            this.textBox_get_data_column.TabIndex = 3;
            this.textBox_get_data_column.Text = "A";
            // 
            // radioButton_get_data_range2
            // 
            this.radioButton_get_data_range2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_get_data_range2.AutoSize = true;
            this.radioButton_get_data_range2.Checked = true;
            this.radioButton_get_data_range2.Location = new System.Drawing.Point(328, 17);
            this.radioButton_get_data_range2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_get_data_range2.Name = "radioButton_get_data_range2";
            this.radioButton_get_data_range2.Size = new System.Drawing.Size(87, 17);
            this.radioButton_get_data_range2.TabIndex = 1;
            this.radioButton_get_data_range2.TabStop = true;
            this.radioButton_get_data_range2.Text = "From range 2";
            this.radioButton_get_data_range2.UseVisualStyleBackColor = true;
            // 
            // radioButton_get_data_range1
            // 
            this.radioButton_get_data_range1.AutoSize = true;
            this.radioButton_get_data_range1.Location = new System.Drawing.Point(4, 17);
            this.radioButton_get_data_range1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_get_data_range1.Name = "radioButton_get_data_range1";
            this.radioButton_get_data_range1.Size = new System.Drawing.Size(87, 17);
            this.radioButton_get_data_range1.TabIndex = 0;
            this.radioButton_get_data_range1.Text = "From range 1";
            this.radioButton_get_data_range1.UseVisualStyleBackColor = true;
            // 
            // button_find
            // 
            this.button_find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_find.Location = new System.Drawing.Point(4, 110);
            this.button_find.Margin = new System.Windows.Forms.Padding(2);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(75, 23);
            this.button_find.TabIndex = 0;
            this.button_find.Text = "Find";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.Color.Red;
            // 
            // openFileDialog_file2
            // 
            this.openFileDialog_file2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_file2_FileOk);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(11, 10);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_range1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_range2);
            this.splitContainer1.Size = new System.Drawing.Size(463, 105);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 12;
            // 
            // groupBox_progress
            // 
            this.groupBox_progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_progress.Controls.Add(this.label_progress);
            this.groupBox_progress.Controls.Add(this.progressBar1);
            this.groupBox_progress.Location = new System.Drawing.Point(12, 323);
            this.groupBox_progress.Name = "groupBox_progress";
            this.groupBox_progress.Size = new System.Drawing.Size(461, 62);
            this.groupBox_progress.TabIndex = 13;
            this.groupBox_progress.TabStop = false;
            this.groupBox_progress.Text = "Progress";
            // 
            // label_progress
            // 
            this.label_progress.AutoSize = true;
            this.label_progress.Location = new System.Drawing.Point(6, 16);
            this.label_progress.Name = "label_progress";
            this.label_progress.Size = new System.Drawing.Size(30, 13);
            this.label_progress.TabIndex = 1;
            this.label_progress.Text = "0 / 0";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(6, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(449, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Match color:";
            // 
            // label_color_match
            // 
            this.label_color_match.AutoSize = true;
            this.label_color_match.BackColor = System.Drawing.Color.Red;
            this.label_color_match.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_color_match.Location = new System.Drawing.Point(120, 8);
            this.label_color_match.MaximumSize = new System.Drawing.Size(16, 16);
            this.label_color_match.MinimumSize = new System.Drawing.Size(16, 16);
            this.label_color_match.Name = "label_color_match";
            this.label_color_match.Size = new System.Drawing.Size(16, 16);
            this.label_color_match.TabIndex = 5;
            this.label_color_match.Click += new System.EventHandler(this.label_color_match_Click);
            // 
            // label_color_match_more1
            // 
            this.label_color_match_more1.AutoSize = true;
            this.label_color_match_more1.BackColor = System.Drawing.Color.Blue;
            this.label_color_match_more1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_color_match_more1.Location = new System.Drawing.Point(120, 27);
            this.label_color_match_more1.MaximumSize = new System.Drawing.Size(16, 16);
            this.label_color_match_more1.MinimumSize = new System.Drawing.Size(16, 16);
            this.label_color_match_more1.Name = "label_color_match_more1";
            this.label_color_match_more1.Size = new System.Drawing.Size(16, 16);
            this.label_color_match_more1.TabIndex = 6;
            this.label_color_match_more1.Click += new System.EventHandler(this.label_color_match_more1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 428);
            this.Controls.Add(this.groupBox_progress);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tabControl_action);
            this.Controls.Add(this.button_log);
            this.Controls.Add(this.button_debug);
            this.Controls.Add(this.button_close);
            this.Name = "FormMain";
            this.Text = "Finder & Comparator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.groupBox_range1.ResumeLayout(false);
            this.groupBox_range1.PerformLayout();
            this.groupBox_range2.ResumeLayout(false);
            this.groupBox_range2.PerformLayout();
            this.tabControl_action.ResumeLayout(false);
            this.tabPage_comparator.ResumeLayout(false);
            this.tabPage_comparator.PerformLayout();
            this.tabPage_data_finder.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_progress.ResumeLayout(false);
            this.groupBox_progress.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage_data_finder;
        private System.Windows.Forms.TextBox textBox_path2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_open_file2;
        private System.Windows.Forms.Button button_compare;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.CheckBox checkBox_path_as_range1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_file2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckBox checkBox_mark_more_1;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_set_data_column;
        private System.Windows.Forms.RadioButton radioButton_set_data_range2;
        private System.Windows.Forms.RadioButton radioButton_set_data_range1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_get_data_column;
        private System.Windows.Forms.RadioButton radioButton_get_data_range2;
        private System.Windows.Forms.RadioButton radioButton_get_data_range1;
        private System.Windows.Forms.GroupBox groupBox_progress;
        private System.Windows.Forms.Label label_progress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_color_match;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_color_match_more1;
    }
}

