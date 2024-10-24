namespace STUDY101_APP_FINALPROJECT
{
    partial class TRACKER_PAGE
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblprogress = new System.Windows.Forms.Label();
            this.btnopen = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.comboboxsubjects = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboBoxtype = new System.Windows.Forms.ComboBox();
            this.btnfilter = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtvalue = new System.Windows.Forms.TextBox();
            this.txtscore = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblvalue = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.TextBox();
            this.btndeleteSCORE = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblprogress);
            this.panel1.Controls.Add(this.btnopen);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.comboboxsubjects);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 100);
            this.panel1.TabIndex = 1;
            // 
            // lblprogress
            // 
            this.lblprogress.AutoSize = true;
            this.lblprogress.Font = new System.Drawing.Font("Calibri", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprogress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblprogress.Location = new System.Drawing.Point(215, 29);
            this.lblprogress.Name = "lblprogress";
            this.lblprogress.Size = new System.Drawing.Size(154, 45);
            this.lblprogress.TabIndex = 26;
            this.lblprogress.Text = "Progress";
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnopen.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopen.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnopen.Location = new System.Drawing.Point(1032, 29);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(161, 43);
            this.btnopen.TabIndex = 25;
            this.btnopen.Text = "OPEN";
            this.btnopen.UseVisualStyleBackColor = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btndelete.Location = new System.Drawing.Point(1199, 29);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(161, 43);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // comboboxsubjects
            // 
            this.comboboxsubjects.FormattingEnabled = true;
            this.comboboxsubjects.Items.AddRange(new object[] {
            "math",
            "biology"});
            this.comboboxsubjects.Location = new System.Drawing.Point(588, 46);
            this.comboboxsubjects.Name = "comboboxsubjects";
            this.comboboxsubjects.Size = new System.Drawing.Size(401, 21);
            this.comboboxsubjects.TabIndex = 0;
            this.comboboxsubjects.SelectedIndexChanged += new System.EventHandler(this.comboboxsubjects_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(223, 289);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1453, 651);
            this.dataGridView.TabIndex = 2;
            // 
            // comboBoxtype
            // 
            this.comboBoxtype.FormattingEnabled = true;
            this.comboBoxtype.Items.AddRange(new object[] {
            "quiz",
            "mid",
            "final"});
            this.comboBoxtype.Location = new System.Drawing.Point(223, 168);
            this.comboBoxtype.Name = "comboBoxtype";
            this.comboBoxtype.Size = new System.Drawing.Size(375, 21);
            this.comboBoxtype.TabIndex = 13;
            // 
            // btnfilter
            // 
            this.btnfilter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfilter.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfilter.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnfilter.Location = new System.Drawing.Point(223, 212);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(93, 33);
            this.btnfilter.TabIndex = 13;
            this.btnfilter.Text = "FILTER";
            this.btnfilter.UseVisualStyleBackColor = false;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(706, 167);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(188, 20);
            this.txtname.TabIndex = 14;
            // 
            // txtvalue
            // 
            this.txtvalue.Location = new System.Drawing.Point(969, 167);
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.Size = new System.Drawing.Size(188, 20);
            this.txtvalue.TabIndex = 15;
            // 
            // txtscore
            // 
            this.txtscore.Location = new System.Drawing.Point(1238, 167);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(188, 20);
            this.txtscore.TabIndex = 16;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnadd.Location = new System.Drawing.Point(1583, 212);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(93, 33);
            this.btnadd.TabIndex = 18;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.BackColor = System.Drawing.Color.Transparent;
            this.lbltype.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.ForeColor = System.Drawing.Color.White;
            this.lbltype.Location = new System.Drawing.Point(218, 136);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(98, 29);
            this.lbltype.TabIndex = 19;
            this.lbltype.Text = "Type List";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(701, 136);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(73, 29);
            this.lblname.TabIndex = 20;
            this.lblname.Text = "Name";
            // 
            // lblvalue
            // 
            this.lblvalue.AutoSize = true;
            this.lblvalue.BackColor = System.Drawing.Color.Transparent;
            this.lblvalue.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalue.ForeColor = System.Drawing.Color.White;
            this.lblvalue.Location = new System.Drawing.Point(964, 135);
            this.lblvalue.Name = "lblvalue";
            this.lblvalue.Size = new System.Drawing.Size(70, 29);
            this.lblvalue.TabIndex = 21;
            this.lblvalue.Text = "Value";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.Transparent;
            this.lblscore.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.Color.White;
            this.lblscore.Location = new System.Drawing.Point(1233, 136);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(67, 29);
            this.lblscore.TabIndex = 22;
            this.lblscore.Text = "Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1483, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Type";
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(1488, 167);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(188, 20);
            this.txttype.TabIndex = 23;
            // 
            // btndeleteSCORE
            // 
            this.btndeleteSCORE.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndeleteSCORE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeleteSCORE.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteSCORE.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btndeleteSCORE.Location = new System.Drawing.Point(706, 212);
            this.btndeleteSCORE.Name = "btndeleteSCORE";
            this.btndeleteSCORE.Size = new System.Drawing.Size(93, 33);
            this.btndeleteSCORE.TabIndex = 25;
            this.btndeleteSCORE.Text = "DELETE";
            this.btndeleteSCORE.UseVisualStyleBackColor = false;
            this.btndeleteSCORE.Click += new System.EventHandler(this.btndeleteSCORE_Click);
            // 
            // TRACKER_PAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::STUDY101_APP_FINALPROJECT.Properties.Resources.aesthetic_baby_blue_gradient_i4clvor3aimq8rzu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btndeleteSCORE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.lblvalue);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.txtvalue);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnfilter);
            this.Controls.Add(this.comboBoxtype);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "TRACKER_PAGE";
            this.Text = "TRACKER_PAGE";
            this.Load += new System.EventHandler(this.TRACKER_PAGE_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboboxsubjects;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBoxtype;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtvalue;
        private System.Windows.Forms.TextBox txtscore;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblvalue;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btndeleteSCORE;
        private System.Windows.Forms.Label lblprogress;
    }
}