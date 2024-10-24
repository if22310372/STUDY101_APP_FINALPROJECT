namespace STUDY101_APP_FINALPROJECT
{
    partial class ADD_EVENT_PAGE
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
            this.txtevent = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblevent = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.datepick = new System.Windows.Forms.DateTimePicker();
            this.checkedListBoxevent = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // txtevent
            // 
            this.txtevent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtevent.Location = new System.Drawing.Point(41, 144);
            this.txtevent.Name = "txtevent";
            this.txtevent.Size = new System.Drawing.Size(401, 20);
            this.txtevent.TabIndex = 1;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbldate.Location = new System.Drawing.Point(37, 46);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(48, 23);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Date";
            // 
            // lblevent
            // 
            this.lblevent.AutoSize = true;
            this.lblevent.BackColor = System.Drawing.Color.Transparent;
            this.lblevent.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblevent.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblevent.Location = new System.Drawing.Point(37, 118);
            this.lblevent.Name = "lblevent";
            this.lblevent.Size = new System.Drawing.Size(54, 23);
            this.lblevent.TabIndex = 3;
            this.lblevent.Text = "Event";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnadd.Location = new System.Drawing.Point(359, 206);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(83, 34);
            this.btnadd.TabIndex = 11;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // datepick
            // 
            this.datepick.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datepick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepick.Location = new System.Drawing.Point(41, 72);
            this.datepick.Name = "datepick";
            this.datepick.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datepick.Size = new System.Drawing.Size(401, 21);
            this.datepick.TabIndex = 12;
            // 
            // checkedListBoxevent
            // 
            this.checkedListBoxevent.FormattingEnabled = true;
            this.checkedListBoxevent.Location = new System.Drawing.Point(541, 46);
            this.checkedListBoxevent.Name = "checkedListBoxevent";
            this.checkedListBoxevent.Size = new System.Drawing.Size(405, 169);
            this.checkedListBoxevent.TabIndex = 13;
            // 
            // ADD_EVENT_PAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1001, 261);
            this.Controls.Add(this.checkedListBoxevent);
            this.Controls.Add(this.datepick);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblevent);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.txtevent);
            this.Name = "ADD_EVENT_PAGE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD_EVENT_PAGE";
            this.Load += new System.EventHandler(this.ADD_EVENT_PAGE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtevent;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblevent;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DateTimePicker datepick;
        private System.Windows.Forms.CheckedListBox checkedListBoxevent;
    }
}