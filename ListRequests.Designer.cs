namespace NCRM
{
    partial class ListRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListRequests));
            this.lbReqList = new System.Windows.Forms.Label();
            this.lbRequests = new System.Windows.Forms.ListBox();
            this.btnGetApproved = new System.Windows.Forms.Button();
            this.btnGetDenied = new System.Windows.Forms.Button();
            this.btnGetNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pbLogoSmall = new System.Windows.Forms.PictureBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // lbReqList
            // 
            this.lbReqList.AutoSize = true;
            this.lbReqList.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReqList.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbReqList.Location = new System.Drawing.Point(13, 14);
            this.lbReqList.Name = "label1";
            this.lbReqList.Size = new System.Drawing.Size(260, 28);
            this.lbReqList.TabIndex = 1;
            this.lbReqList.Text = "Curriculum Request Lists ";
            // 
            // lbRequests
            // 
            this.lbRequests.FormattingEnabled = true;
            this.lbRequests.Location = new System.Drawing.Point(17, 92);
            this.lbRequests.Name = "lbRequests";
            this.lbRequests.ScrollAlwaysVisible = true;
            this.lbRequests.Size = new System.Drawing.Size(511, 212);
            this.lbRequests.TabIndex = 1;
            this.lbRequests.DoubleClick += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnGetApproved
            // 
            this.btnGetApproved.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGetApproved.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGetApproved.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGetApproved.Location = new System.Drawing.Point(112, 54);
            this.btnGetApproved.Name = "btnGetApproved";
            this.btnGetApproved.Size = new System.Drawing.Size(85, 27);
            this.btnGetApproved.TabIndex = 4;
            this.btnGetApproved.TabStop = false;
            this.btnGetApproved.Text = "&Approved";
            this.btnGetApproved.UseVisualStyleBackColor = false;
            this.btnGetApproved.Click += new System.EventHandler(this.btnGetApproved_Click);
            // 
            // btnGetDenied
            // 
            this.btnGetDenied.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGetDenied.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGetDenied.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGetDenied.Location = new System.Drawing.Point(208, 54);
            this.btnGetDenied.Name = "btnGetDenied";
            this.btnGetDenied.Size = new System.Drawing.Size(85, 27);
            this.btnGetDenied.TabIndex = 5;
            this.btnGetDenied.TabStop = false;
            this.btnGetDenied.Text = "&Denied";
            this.btnGetDenied.UseVisualStyleBackColor = false;
            this.btnGetDenied.Click += new System.EventHandler(this.btnGetDenied_Click);
            // 
            // btnGetNew
            // 
            this.btnGetNew.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnGetNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGetNew.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGetNew.Location = new System.Drawing.Point(18, 54);
            this.btnGetNew.Name = "btnGetNew";
            this.btnGetNew.Size = new System.Drawing.Size(85, 27);
            this.btnGetNew.TabIndex = 3;
            this.btnGetNew.TabStop = false;
            this.btnGetNew.Text = "&New";
            this.btnGetNew.UseVisualStyleBackColor = false;
            this.btnGetNew.Click += new System.EventHandler(this.btnGetNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoad.Location = new System.Drawing.Point(347, 310);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(97, 32);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.TabStop = false;
            this.btnLoad.Text = "&Load Request";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pbLogoSmall
            // 
            this.pbLogoSmall.ErrorImage = global::NCRM.Properties.Resources.NCRM_SML;
            this.pbLogoSmall.Image = global::NCRM.Properties.Resources.NCRM_SML;
            this.pbLogoSmall.InitialImage = global::NCRM.Properties.Resources.NCRM_SML;
            this.pbLogoSmall.Location = new System.Drawing.Point(448, 13);
            this.pbLogoSmall.Name = "pbLogoSmall";
            this.pbLogoSmall.Size = new System.Drawing.Size(80, 69);
            this.pbLogoSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogoSmall.TabIndex = 0;
            this.pbLogoSmall.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Navy;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExport.Location = new System.Drawing.Point(347, 54);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 27);
            this.btnExport.TabIndex = 6;
            this.btnExport.TabStop = false;
            this.btnExport.Text = "&Excel Report";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCompleted.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCompleted.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCompleted.Location = new System.Drawing.Point(17, 310);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(91, 32);
            this.btnCompleted.TabIndex = 7;
            this.btnCompleted.TabStop = false;
            this.btnCompleted.Text = "&Completed";
            this.btnCompleted.UseVisualStyleBackColor = false;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(453, 310);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 32);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.TabStop = false;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // ListRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 354);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnGetNew);
            this.Controls.Add(this.btnGetDenied);
            this.Controls.Add(this.btnGetApproved);
            this.Controls.Add(this.lbRequests);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogoSmall);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Course Request Management";
            this.Load += new System.EventHandler(this.ListRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoSmall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogoSmall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbRequests;
        private System.Windows.Forms.Button btnGetApproved;
        private System.Windows.Forms.Button btnGetDenied;
        private System.Windows.Forms.Button btnGetNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnQuit;
    }
}