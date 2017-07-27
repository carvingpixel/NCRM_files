namespace NCRM
{
    partial class ViewApproved
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewApproved));
            this.lbRequests = new System.Windows.Forms.ListBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnGetApproved = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRequests
            // 
            this.lbRequests.FormattingEnabled = true;
            this.lbRequests.HorizontalScrollbar = true;
            this.lbRequests.Location = new System.Drawing.Point(21, 98);
            this.lbRequests.Name = "lbRequests";
            this.lbRequests.ScrollAlwaysVisible = true;
            this.lbRequests.Size = new System.Drawing.Size(534, 316);
            this.lbRequests.TabIndex = 1;
            this.lbRequests.DoubleClick += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbTitle.Location = new System.Drawing.Point(17, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(366, 28);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "Central Registration Implementation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NCRM.Properties.Resources.NCRM_SML;
            this.pictureBox1.Location = new System.Drawing.Point(475, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoad.Location = new System.Drawing.Point(377, 426);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(97, 32);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.TabStop = false;
            this.btnLoad.Text = "&Load Request";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnGetApproved
            // 
            this.btnGetApproved.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGetApproved.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGetApproved.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGetApproved.Location = new System.Drawing.Point(22, 58);
            this.btnGetApproved.Name = "btnGetApproved";
            this.btnGetApproved.Size = new System.Drawing.Size(85, 23);
            this.btnGetApproved.TabIndex = 10;
            this.btnGetApproved.TabStop = false;
            this.btnGetApproved.Text = "&Approved";
            this.btnGetApproved.UseVisualStyleBackColor = false;
            this.btnGetApproved.Click += new System.EventHandler(this.btnGetApproved_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCompleted.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCompleted.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCompleted.Location = new System.Drawing.Point(124, 58);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(85, 23);
            this.btnCompleted.TabIndex = 12;
            this.btnCompleted.TabStop = false;
            this.btnCompleted.Text = "&Completed";
            this.btnCompleted.UseVisualStyleBackColor = false;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(480, 426);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 32);
            this.btnQuit.TabIndex = 13;
            this.btnQuit.TabStop = false;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Navy;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExport.Location = new System.Drawing.Point(377, 54);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 27);
            this.btnExport.TabIndex = 14;
            this.btnExport.TabStop = false;
            this.btnExport.Text = "&Excel Report";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // ViewApproved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 470);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnGetApproved);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbRequests);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewApproved";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Course Request Management";
            this.Load += new System.EventHandler(this.ViewApproved_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbRequests;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnGetApproved;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnExport;
    }
}