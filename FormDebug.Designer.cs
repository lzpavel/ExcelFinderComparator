﻿namespace ExcelFinderComparator
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
            this.components = new System.ComponentModel.Container();
            this.button_apply = new System.Windows.Forms.Button();
            this.textBox_debug = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button_debug_start = new System.Windows.Forms.Button();
            this.button_debug_stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(345, 9);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(100, 28);
            this.button_apply.TabIndex = 0;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // textBox_debug
            // 
            this.textBox_debug.Location = new System.Drawing.Point(12, 12);
            this.textBox_debug.Name = "textBox_debug";
            this.textBox_debug.Size = new System.Drawing.Size(327, 22);
            this.textBox_debug.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(433, 183);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.DoubleClick += new System.EventHandler(this.richTextBox1_DoubleClick);
            // 
            // button_debug_start
            // 
            this.button_debug_start.Location = new System.Drawing.Point(12, 229);
            this.button_debug_start.Name = "button_debug_start";
            this.button_debug_start.Size = new System.Drawing.Size(75, 23);
            this.button_debug_start.TabIndex = 3;
            this.button_debug_start.Text = "Start";
            this.button_debug_start.UseVisualStyleBackColor = true;
            this.button_debug_start.Click += new System.EventHandler(this.button_debug_start_Click);
            // 
            // button_debug_stop
            // 
            this.button_debug_stop.Location = new System.Drawing.Point(370, 229);
            this.button_debug_stop.Name = "button_debug_stop";
            this.button_debug_stop.Size = new System.Drawing.Size(75, 23);
            this.button_debug_stop.TabIndex = 4;
            this.button_debug_stop.Text = "Stop";
            this.button_debug_stop.UseVisualStyleBackColor = true;
            this.button_debug_stop.Click += new System.EventHandler(this.button_debug_stop_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_debug_stop);
            this.Controls.Add(this.button_debug_start);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox_debug);
            this.Controls.Add(this.button_apply);
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
        private System.Windows.Forms.Timer timer1;
    }
}