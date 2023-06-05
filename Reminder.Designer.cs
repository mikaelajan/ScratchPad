namespace try1234
{
    partial class Reminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminder));
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSetAlarm = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.radAM = new System.Windows.Forms.RadioButton();
            this.radPM = new System.Windows.Forms.RadioButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.backStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.cLOSEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(241, 54);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 20);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "TIME";
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.AutoSize = true;
            this.btnSetAlarm.BackColor = System.Drawing.Color.Salmon;
            this.btnSetAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetAlarm.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnSetAlarm.FlatAppearance.BorderSize = 0;
            this.btnSetAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetAlarm.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAlarm.Location = new System.Drawing.Point(203, 85);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(110, 48);
            this.btnSetAlarm.TabIndex = 2;
            this.btnSetAlarm.Text = "SET REMINDER";
            this.btnSetAlarm.UseVisualStyleBackColor = false;
            this.btnSetAlarm.Click += new System.EventHandler(this.btnSetAlarm_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // txtMinute
            // 
            this.txtMinute.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute.Location = new System.Drawing.Point(66, 111);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(43, 27);
            this.txtMinute.TabIndex = 3;
            this.txtMinute.Text = "00";
            // 
            // txtHour
            // 
            this.txtHour.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHour.Location = new System.Drawing.Point(66, 78);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(41, 27);
            this.txtHour.TabIndex = 4;
            this.txtHour.Text = "00";
            // 
            // radAM
            // 
            this.radAM.AutoSize = true;
            this.radAM.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAM.Location = new System.Drawing.Point(116, 88);
            this.radAM.Name = "radAM";
            this.radAM.Size = new System.Drawing.Size(45, 24);
            this.radAM.TabIndex = 5;
            this.radAM.TabStop = true;
            this.radAM.Text = "AM";
            this.radAM.UseVisualStyleBackColor = true;
            // 
            // radPM
            // 
            this.radPM.AutoSize = true;
            this.radPM.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPM.Location = new System.Drawing.Point(115, 118);
            this.radPM.Name = "radPM";
            this.radPM.Size = new System.Drawing.Size(46, 24);
            this.radPM.TabIndex = 6;
            this.radPM.TabStop = true;
            this.radPM.Text = "PM";
            this.radPM.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(189, 282);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(133, 117);
            this.txtDescription.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(189, 225);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(133, 27);
            this.txtTitle.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "TITLE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "DESCRIPTION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "HOUR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "MINUTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "YOUR REMINDER";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Salmon;
            this.menuStrip1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 42);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeStrip,
            this.backStrip,
            this.cLOSEToolStripMenuItem1});
            this.mENUToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mENUToolStripMenuItem.Image")));
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(103, 38);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // homeStrip
            // 
            this.homeStrip.BackColor = System.Drawing.Color.Salmon;
            this.homeStrip.Image = ((System.Drawing.Image)(resources.GetObject("homeStrip.Image")));
            this.homeStrip.Name = "homeStrip";
            this.homeStrip.Size = new System.Drawing.Size(155, 38);
            this.homeStrip.Text = "HOME";
            this.homeStrip.Click += new System.EventHandler(this.homeStrip_Click);
            // 
            // backStrip
            // 
            this.backStrip.BackColor = System.Drawing.Color.Salmon;
            this.backStrip.Image = ((System.Drawing.Image)(resources.GetObject("backStrip.Image")));
            this.backStrip.Name = "backStrip";
            this.backStrip.Size = new System.Drawing.Size(155, 38);
            this.backStrip.Text = "BACK";
            this.backStrip.Click += new System.EventHandler(this.backStrip_Click);
            // 
            // cLOSEToolStripMenuItem1
            // 
            this.cLOSEToolStripMenuItem1.BackColor = System.Drawing.Color.Salmon;
            this.cLOSEToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("cLOSEToolStripMenuItem1.Image")));
            this.cLOSEToolStripMenuItem1.Name = "cLOSEToolStripMenuItem1";
            this.cLOSEToolStripMenuItem1.Size = new System.Drawing.Size(155, 38);
            this.cLOSEToolStripMenuItem1.Text = "CLOSE";
            this.cLOSEToolStripMenuItem1.Click += new System.EventHandler(this.cLOSEToolStripMenuItem1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(168, 172);
            this.dataGridView1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "eg.( 06:30)";
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.radPM);
            this.Controls.Add(this.radAM);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.btnSetAlarm);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder";
            this.Load += new System.EventHandler(this.Reminder_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnSetAlarm;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.RadioButton radAM;
        private System.Windows.Forms.RadioButton radPM;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem homeStrip;
        private System.Windows.Forms.ToolStripMenuItem backStrip;
        private System.Windows.Forms.ToolStripMenuItem cLOSEToolStripMenuItem1;
        private System.Windows.Forms.Label label6;
    }
}