namespace STUDY101_APP_FINALPROJECT
{
    partial class DIARY_PAGE
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
            this.richTextBoxdiarycontent = new System.Windows.Forms.RichTextBox();
            this.listBoxdiarylist = new System.Windows.Forms.ListBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.txtdiaryname = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxdiarycontent
            // 
            this.richTextBoxdiarycontent.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxdiarycontent.Location = new System.Drawing.Point(250, 200);
            this.richTextBoxdiarycontent.Name = "richTextBoxdiarycontent";
            this.richTextBoxdiarycontent.Size = new System.Drawing.Size(1006, 690);
            this.richTextBoxdiarycontent.TabIndex = 0;
            this.richTextBoxdiarycontent.Text = "";
            // 
            // listBoxdiarylist
            // 
            this.listBoxdiarylist.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxdiarylist.FormattingEnabled = true;
            this.listBoxdiarylist.ItemHeight = 23;
            this.listBoxdiarylist.Location = new System.Drawing.Point(1390, 206);
            this.listBoxdiarylist.Name = "listBoxdiarylist";
            this.listBoxdiarylist.Size = new System.Drawing.Size(276, 671);
            this.listBoxdiarylist.TabIndex = 1;
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnopen.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopen.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnopen.Location = new System.Drawing.Point(1446, 131);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(161, 43);
            this.btnopen.TabIndex = 26;
            this.btnopen.Text = "OPEN";
            this.btnopen.UseVisualStyleBackColor = false;
            // 
            // txtdiaryname
            // 
            this.txtdiaryname.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiaryname.Location = new System.Drawing.Point(250, 139);
            this.txtdiaryname.Name = "txtdiaryname";
            this.txtdiaryname.Size = new System.Drawing.Size(471, 33);
            this.txtdiaryname.TabIndex = 27;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnadd.Location = new System.Drawing.Point(859, 131);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(161, 43);
            this.btnadd.TabIndex = 28;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btndelete.Location = new System.Drawing.Point(1095, 131);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(161, 43);
            this.btndelete.TabIndex = 29;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // DIARY_PAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STUDY101_APP_FINALPROJECT.Properties.Resources.aesthetic_baby_blue_gradient_i4clvor3aimq8rzu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtdiaryname);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.listBoxdiarylist);
            this.Controls.Add(this.richTextBoxdiarycontent);
            this.Name = "DIARY_PAGE";
            this.Text = "DIARY_PAGE";
            this.Load += new System.EventHandler(this.DIARY_PAGE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxdiarycontent;
        private System.Windows.Forms.ListBox listBoxdiarylist;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.TextBox txtdiaryname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
    }
}