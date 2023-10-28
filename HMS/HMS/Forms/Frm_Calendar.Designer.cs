namespace HMS
{
    partial class Frm_Calendar
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
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monthCalendar2 = new Pabo.Calendar.MonthCalendar();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "MONTH";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 2);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "YEAR";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 58);
            this.panel2.TabIndex = 18;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.ActiveMonth.Month = 10;
            this.monthCalendar2.ActiveMonth.Year = 2023;
            this.monthCalendar2.Culture = new System.Globalization.CultureInfo("en-PH");
            this.monthCalendar2.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar2.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.monthCalendar2.Header.TextColor = System.Drawing.Color.White;
            this.monthCalendar2.ImageList = null;
            this.monthCalendar2.Location = new System.Drawing.Point(55, 80);
            this.monthCalendar2.MaxDate = new System.DateTime(2033, 10, 27, 18, 23, 19, 468);
            this.monthCalendar2.MinDate = new System.DateTime(2013, 10, 27, 18, 23, 19, 468);
            this.monthCalendar2.Month.BackgroundImage = null;
            this.monthCalendar2.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar2.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.ShowFooter = false;
            this.monthCalendar2.Size = new System.Drawing.Size(500, 285);
            this.monthCalendar2.TabIndex = 20;
            this.monthCalendar2.TodayColor = System.Drawing.Color.Blue;
            this.monthCalendar2.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar2.Weekdays.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(28)))), ((int)(((byte)(50)))));
            this.monthCalendar2.Weeknumbers.Align = Pabo.Calendar.mcWeeknumberAlign.Center;
            this.monthCalendar2.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.monthCalendar2.DayRender += new Pabo.Calendar.DayRenderEventHandler(this.monthCalendar2_DayRender);
            this.monthCalendar2.DayQueryInfo += new Pabo.Calendar.DayQueryInfoEventHandler(this.monthCalendar2_DayQueryInfo);
            // 
            // Frm_Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 405);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Calendar";
            this.Text = "Frm_Calendar";
            this.Load += new System.EventHandler(this.Frm_Calendar_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Pabo.Calendar.MonthCalendar monthCalendar2;
    }
}