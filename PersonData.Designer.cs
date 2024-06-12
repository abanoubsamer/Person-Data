namespace Person_Data
{
    partial class PersonData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonData));
            this.labal_titla = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.IDtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nametext = new System.Windows.Forms.TextBox();
            this.Addresstext = new System.Windows.Forms.TextBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.btnfFind = new System.Windows.Forms.Button();
            this.butShowAll = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labal_titla
            // 
            this.labal_titla.AutoSize = true;
            this.labal_titla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labal_titla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labal_titla.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labal_titla.Location = new System.Drawing.Point(345, 25);
            this.labal_titla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labal_titla.Name = "labal_titla";
            this.labal_titla.Size = new System.Drawing.Size(174, 32);
            this.labal_titla.TabIndex = 0;
            this.labal_titla.Text = "PersonData";
            this.labal_titla.Click += new System.EventHandler(this.labal_titla_Click);
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(82, 102);
            this.labelname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(43, 32);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "ID";
            // 
            // IDtext
            // 
            this.IDtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDtext.Location = new System.Drawing.Point(273, 96);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(499, 38);
            this.IDtext.TabIndex = 2;
            this.info.SetToolTip(this.IDtext, "Person ID");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address";
            // 
            // Nametext
            // 
            this.Nametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nametext.Location = new System.Drawing.Point(273, 168);
            this.Nametext.Name = "Nametext";
            this.Nametext.Size = new System.Drawing.Size(499, 38);
            this.Nametext.TabIndex = 5;
            this.info.SetToolTip(this.Nametext, "Person Name");
            // 
            // Addresstext
            // 
            this.Addresstext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresstext.Location = new System.Drawing.Point(273, 235);
            this.Addresstext.Name = "Addresstext";
            this.Addresstext.Size = new System.Drawing.Size(499, 38);
            this.Addresstext.TabIndex = 6;
            this.info.SetToolTip(this.Addresstext, "Person Address");
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.butAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butAdd.Location = new System.Drawing.Point(88, 313);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(104, 50);
            this.butAdd.TabIndex = 7;
            this.butAdd.Text = "Add";
            this.info.SetToolTip(this.butAdd, "Add a New Person");
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // btnfFind
            // 
            this.btnfFind.BackColor = System.Drawing.Color.CadetBlue;
            this.btnfFind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfFind.Location = new System.Drawing.Point(283, 313);
            this.btnfFind.Name = "btnfFind";
            this.btnfFind.Size = new System.Drawing.Size(104, 50);
            this.btnfFind.TabIndex = 8;
            this.btnfFind.Text = "Find";
            this.info.SetToolTip(this.btnfFind, "Find By ID");
            this.btnfFind.UseVisualStyleBackColor = false;
            this.btnfFind.Click += new System.EventHandler(this.btnfFind_Click);
            // 
            // butShowAll
            // 
            this.butShowAll.BackColor = System.Drawing.Color.CadetBlue;
            this.butShowAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butShowAll.Location = new System.Drawing.Point(465, 313);
            this.butShowAll.Name = "butShowAll";
            this.butShowAll.Size = new System.Drawing.Size(104, 50);
            this.butShowAll.TabIndex = 10;
            this.butShowAll.Text = "ShowAll";
            this.info.SetToolTip(this.butShowAll, "Show All Persons");
            this.butShowAll.UseVisualStyleBackColor = false;
            this.butShowAll.Click += new System.EventHandler(this.butShowAll_Click);
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.CadetBlue;
            this.butExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butExit.Location = new System.Drawing.Point(668, 313);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(104, 50);
            this.butExit.TabIndex = 10;
            this.butExit.Text = "Exit";
            this.info.SetToolTip(this.butExit, "Exit From Program");
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // info
            // 
            this.info.IsBalloon = true;
            this.info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // PersonData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 388);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butShowAll);
            this.Controls.Add(this.btnfFind);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.Addresstext);
            this.Controls.Add(this.Nametext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDtext);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.labal_titla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PersonData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Data";
            this.Load += new System.EventHandler(this.PersonData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labal_titla;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.TextBox IDtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nametext;
        private System.Windows.Forms.TextBox Addresstext;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button btnfFind;
        private System.Windows.Forms.Button butShowAll;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.ToolTip info;
    }
}

