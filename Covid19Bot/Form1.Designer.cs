namespace Covid19Bot
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_disp = new System.Windows.Forms.Label();
            this.Status_dsp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stop_btn = new System.Windows.Forms.Label();
            this.Start_btn = new System.Windows.Forms.Label();
            this.Listening_btn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(571, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(206, 37);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // lbl_disp
            // 
            this.lbl_disp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_disp.Font = new System.Drawing.Font("Nokia Pure Headline", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_disp.ForeColor = System.Drawing.Color.White;
            this.lbl_disp.Location = new System.Drawing.Point(29, 433);
            this.lbl_disp.Name = "lbl_disp";
            this.lbl_disp.Size = new System.Drawing.Size(963, 151);
            this.lbl_disp.TabIndex = 1;
            this.lbl_disp.Text = "Text";
            // 
            // Status_dsp
            // 
            this.Status_dsp.BackColor = System.Drawing.Color.Transparent;
            this.Status_dsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Status_dsp.Font = new System.Drawing.Font("Nokia Pure Headline", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_dsp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Status_dsp.Location = new System.Drawing.Point(564, 380);
            this.Status_dsp.Name = "Status_dsp";
            this.Status_dsp.Size = new System.Drawing.Size(204, 37);
            this.Status_dsp.TabIndex = 3;
            this.Status_dsp.Text = "N/A";
            this.Status_dsp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.Transparent;
            this.stop_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_btn.Image = global::Covid19Bot.Properties.Resources.Stop;
            this.stop_btn.Location = new System.Drawing.Point(538, 60);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(274, 251);
            this.stop_btn.TabIndex = 2;
            this.stop_btn.Click += new System.EventHandler(this.Listening_btn_Click);
            // 
            // Start_btn
            // 
            this.Start_btn.BackColor = System.Drawing.Color.Transparent;
            this.Start_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_btn.Image = global::Covid19Bot.Properties.Resources.Start;
            this.Start_btn.Location = new System.Drawing.Point(538, 60);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(274, 251);
            this.Start_btn.TabIndex = 4;
            this.Start_btn.Click += new System.EventHandler(this.Listening_btn_Click);
            // 
            // Listening_btn
            // 
            this.Listening_btn.BackColor = System.Drawing.Color.Transparent;
            this.Listening_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Listening_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Listening_btn.Image = global::Covid19Bot.Properties.Resources.Listen;
            this.Listening_btn.Location = new System.Drawing.Point(538, 60);
            this.Listening_btn.Name = "Listening_btn";
            this.Listening_btn.Size = new System.Drawing.Size(274, 251);
            this.Listening_btn.TabIndex = 5;
            this.Listening_btn.Click += new System.EventHandler(this.Listening_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Covid19Bot.Properties.Resources.BG_Pic;
            this.ClientSize = new System.Drawing.Size(1037, 593);
            this.Controls.Add(this.Listening_btn);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.Status_dsp);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.lbl_disp);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CovidBot: Main Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl_disp;
        private System.Windows.Forms.Label Status_dsp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label stop_btn;
        private System.Windows.Forms.Label Start_btn;
        private System.Windows.Forms.Label Listening_btn;
    }
}

