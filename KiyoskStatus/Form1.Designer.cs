namespace KiyoskStatus
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbKhadamat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbResturant = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbComputerName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(282, 69);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(353, 41);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Visible = false;
            // 
            // BtnRun
            // 
            this.BtnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnRun.Location = new System.Drawing.Point(395, 559);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(112, 49);
            this.BtnRun.TabIndex = 12;
            this.BtnRun.Text = "RUN";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(649, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "شماره خدمات";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView1.BackgroundImage = global::KiyoskStatus.Properties.Resources.lunch;
            this.listView1.BackgroundImageTiled = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("B Yekan", 15.75F);
            this.listView1.ForeColor = System.Drawing.Color.Navy;
            this.listView1.Location = new System.Drawing.Point(65, 130);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(777, 227);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lbKhadamat
            // 
            this.lbKhadamat.AutoSize = true;
            this.lbKhadamat.BackColor = System.Drawing.Color.Transparent;
            this.lbKhadamat.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbKhadamat.Location = new System.Drawing.Point(525, 26);
            this.lbKhadamat.Name = "lbKhadamat";
            this.lbKhadamat.Size = new System.Drawing.Size(118, 25);
            this.lbKhadamat.TabIndex = 15;
            this.lbKhadamat.Text = "شماره خدمات";
            this.lbKhadamat.Click += new System.EventHandler(this.lbKhadamat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(393, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "نام رستوران";
            // 
            // lbResturant
            // 
            this.lbResturant.AutoSize = true;
            this.lbResturant.BackColor = System.Drawing.Color.Transparent;
            this.lbResturant.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbResturant.Location = new System.Drawing.Point(285, 18);
            this.lbResturant.Name = "lbResturant";
            this.lbResturant.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbResturant.Size = new System.Drawing.Size(107, 37);
            this.lbResturant.TabIndex = 17;
            this.lbResturant.Text = "نام رستوران";
            this.lbResturant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(156, 18);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(45, 37);
            this.label5.TabIndex = 18;
            this.label5.Text = "نوع";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.BackColor = System.Drawing.Color.Transparent;
            this.lbType.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbType.Location = new System.Drawing.Point(51, 18);
            this.lbType.Name = "lbType";
            this.lbType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbType.Size = new System.Drawing.Size(45, 37);
            this.lbType.TabIndex = 19;
            this.lbType.Text = "نوع";
            // 
            // lbComputerName
            // 
            this.lbComputerName.BackColor = System.Drawing.Color.Transparent;
            this.lbComputerName.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComputerName.Location = new System.Drawing.Point(330, 106);
            this.lbComputerName.Name = "lbComputerName";
            this.lbComputerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbComputerName.Size = new System.Drawing.Size(331, 38);
            this.lbComputerName.TabIndex = 21;
            this.lbComputerName.Text = "نام رستوران";
            this.lbComputerName.Click += new System.EventHandler(this.lbComputerName_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(667, 101);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(103, 37);
            this.label8.TabIndex = 20;
            this.label8.Text = "نام کامپیوتر";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.BackColor = System.Drawing.Color.Transparent;
            this.lbTel.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbTel.Location = new System.Drawing.Point(66, 102);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(45, 37);
            this.lbTel.TabIndex = 23;
            this.lbTel.Text = "نوع";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("B Titr", 15.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(142, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 37);
            this.label10.TabIndex = 22;
            this.label10.Text = "تلفن";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbTel);
            this.panel1.Controls.Add(this.lbKhadamat);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbType);
            this.panel1.Controls.Add(this.lbComputerName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbResturant);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(65, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 159);
            this.panel1.TabIndex = 24;
            this.panel1.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("B Titr", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblStatus.ForeColor = System.Drawing.Color.Navy;
            this.lblStatus.Location = new System.Drawing.Point(261, 19);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStatus.Size = new System.Drawing.Size(399, 47);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "بررسی اتصال کیوسک های  رستوران";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::KiyoskStatus.Properties.Resources.lunch;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnRun);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbKhadamat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbResturant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbComputerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

