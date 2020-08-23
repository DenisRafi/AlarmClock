namespace Alarm_Clock
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.b1Start = new System.Windows.Forms.Button();
            this.b2Stop = new System.Windows.Forms.Button();
            this.lbl1Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(216, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // b1Start
            // 
            this.b1Start.Location = new System.Drawing.Point(12, 88);
            this.b1Start.Name = "b1Start";
            this.b1Start.Size = new System.Drawing.Size(75, 23);
            this.b1Start.TabIndex = 1;
            this.b1Start.Text = "Start";
            this.b1Start.UseVisualStyleBackColor = true;
            this.b1Start.Click += new System.EventHandler(this.b1Start_Click);
            // 
            // b2Stop
            // 
            this.b2Stop.Location = new System.Drawing.Point(153, 88);
            this.b2Stop.Name = "b2Stop";
            this.b2Stop.Size = new System.Drawing.Size(75, 23);
            this.b2Stop.TabIndex = 2;
            this.b2Stop.Text = "Stop";
            this.b2Stop.UseVisualStyleBackColor = true;
            this.b2Stop.Click += new System.EventHandler(this.b2Stop_Click);
            // 
            // lbl1Status
            // 
            this.lbl1Status.AutoSize = true;
            this.lbl1Status.Location = new System.Drawing.Point(97, 52);
            this.lbl1Status.Name = "lbl1Status";
            this.lbl1Status.Size = new System.Drawing.Size(37, 13);
            this.lbl1Status.TabIndex = 3;
            this.lbl1Status.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 140);
            this.Controls.Add(this.lbl1Status);
            this.Controls.Add(this.b2Stop);
            this.Controls.Add(this.b1Start);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm Clock | ByDenisRafi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button b1Start;
        private System.Windows.Forms.Button b2Stop;
        private System.Windows.Forms.Label lbl1Status;
    }
}

