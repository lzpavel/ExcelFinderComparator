namespace ExcelFinderComparator
{
    partial class FormDebug
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_apply = new System.Windows.Forms.Button();
            this.textBox_debug = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_debug_start = new System.Windows.Forms.Button();
            this.button_debug_stop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_color = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog_debug = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(259, 7);
            this.button_apply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 0;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // textBox_debug
            // 
            this.textBox_debug.Location = new System.Drawing.Point(9, 10);
            this.textBox_debug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_debug.Name = "textBox_debug";
            this.textBox_debug.Size = new System.Drawing.Size(246, 20);
            this.textBox_debug.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 32);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(326, 149);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.DoubleClick += new System.EventHandler(this.richTextBox1_DoubleClick);
            // 
            // button_debug_start
            // 
            this.button_debug_start.Location = new System.Drawing.Point(12, 186);
            this.button_debug_start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_debug_start.Name = "button_debug_start";
            this.button_debug_start.Size = new System.Drawing.Size(75, 23);
            this.button_debug_start.TabIndex = 3;
            this.button_debug_start.Text = "Start";
            this.button_debug_start.UseVisualStyleBackColor = true;
            this.button_debug_start.Click += new System.EventHandler(this.button_debug_start_Click);
            // 
            // button_debug_stop
            // 
            this.button_debug_stop.Location = new System.Drawing.Point(260, 186);
            this.button_debug_stop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_debug_stop.Name = "button_debug_stop";
            this.button_debug_stop.Size = new System.Drawing.Size(75, 23);
            this.button_debug_stop.TabIndex = 4;
            this.button_debug_stop.Text = "Stop";
            this.button_debug_stop.UseVisualStyleBackColor = true;
            this.button_debug_stop.Click += new System.EventHandler(this.button_debug_stop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label_color
            // 
            this.label_color.AutoSize = true;
            this.label_color.BackColor = System.Drawing.Color.Red;
            this.label_color.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_color.Location = new System.Drawing.Point(253, 302);
            this.label_color.MaximumSize = new System.Drawing.Size(15, 15);
            this.label_color.MinimumSize = new System.Drawing.Size(15, 15);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(15, 15);
            this.label_color.TabIndex = 6;
            this.label_color.Click += new System.EventHandler(this.label_color_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Match color:";
            // 
            // colorDialog_debug
            // 
            this.colorDialog_debug.AnyColor = true;
            this.colorDialog_debug.Color = System.Drawing.Color.Red;
            // 
            // FormDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_color);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_debug_stop);
            this.Controls.Add(this.button_debug_start);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox_debug);
            this.Controls.Add(this.button_apply);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDebug";
            this.Text = "FormDebug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.TextBox textBox_debug;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button_debug_start;
        private System.Windows.Forms.Button button_debug_stop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog_debug;
    }
}