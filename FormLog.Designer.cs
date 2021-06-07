namespace ExcelFinderComparator
{
    partial class FormLog
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
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.button_close_log = new System.Windows.Forms.Button();
            this.button_update_log = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_log.Location = new System.Drawing.Point(12, 12);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.Size = new System.Drawing.Size(529, 369);
            this.richTextBox_log.TabIndex = 0;
            this.richTextBox_log.Text = "";
            // 
            // button_close_log
            // 
            this.button_close_log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close_log.Location = new System.Drawing.Point(460, 393);
            this.button_close_log.Name = "button_close_log";
            this.button_close_log.Size = new System.Drawing.Size(81, 30);
            this.button_close_log.TabIndex = 1;
            this.button_close_log.Text = "Close";
            this.button_close_log.UseVisualStyleBackColor = true;
            // 
            // button_update_log
            // 
            this.button_update_log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_update_log.Location = new System.Drawing.Point(12, 393);
            this.button_update_log.Name = "button_update_log";
            this.button_update_log.Size = new System.Drawing.Size(83, 30);
            this.button_update_log.TabIndex = 2;
            this.button_update_log.Text = "Update";
            this.button_update_log.UseVisualStyleBackColor = true;
            this.button_update_log.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_clear.Location = new System.Drawing.Point(101, 393);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 30);
            this.button_clear.TabIndex = 3;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 435);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_update_log);
            this.Controls.Add(this.button_close_log);
            this.Controls.Add(this.richTextBox_log);
            this.Name = "FormLog";
            this.Text = "FormLog";
            this.Activated += new System.EventHandler(this.FormLog_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_log;
        private System.Windows.Forms.Button button_close_log;
        private System.Windows.Forms.Button button_update_log;
        private System.Windows.Forms.Button button_clear;
    }
}