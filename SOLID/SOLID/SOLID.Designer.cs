namespace SOLID
{
    partial class SOLID_Principals
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
            this.m_labelSOLID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.m_buttonFollowingDIP = new System.Windows.Forms.Button();
            this.m_buttonViolatingDIP = new System.Windows.Forms.Button();
            this.m_labelDIP = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.m_buttonFollowingISP = new System.Windows.Forms.Button();
            this.m_buttonViolatingISP = new System.Windows.Forms.Button();
            this.m_labelISP = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.m_buttonFollowingLSP = new System.Windows.Forms.Button();
            this.m_buttonViolatingLSP = new System.Windows.Forms.Button();
            this.m_labelLSP = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_buttonFollowingOCP = new System.Windows.Forms.Button();
            this.m_buttonViolatingOCP = new System.Windows.Forms.Button();
            this.m_labelOCP = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_buttonFollowingSRP = new System.Windows.Forms.Button();
            this.m_buttonViolatingSRP = new System.Windows.Forms.Button();
            this.m_labelSRP = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_labelSOLID
            // 
            this.m_labelSOLID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.m_labelSOLID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_labelSOLID.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_labelSOLID.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_labelSOLID.ForeColor = System.Drawing.Color.White;
            this.m_labelSOLID.Location = new System.Drawing.Point(0, 0);
            this.m_labelSOLID.Name = "m_labelSOLID";
            this.m_labelSOLID.Size = new System.Drawing.Size(1169, 40);
            this.m_labelSOLID.TabIndex = 0;
            this.m_labelSOLID.Text = "S.O.L.I.D";
            this.m_labelSOLID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_labelSOLID.Click += new System.EventHandler(this.m_labelSOLID_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 327);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.m_buttonFollowingDIP);
            this.panel4.Controls.Add(this.m_buttonViolatingDIP);
            this.panel4.Controls.Add(this.m_labelDIP);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(936, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 327);
            this.panel4.TabIndex = 1;
            // 
            // m_buttonFollowingDIP
            // 
            this.m_buttonFollowingDIP.Location = new System.Drawing.Point(29, 263);
            this.m_buttonFollowingDIP.Name = "m_buttonFollowingDIP";
            this.m_buttonFollowingDIP.Size = new System.Drawing.Size(178, 48);
            this.m_buttonFollowingDIP.TabIndex = 4;
            this.m_buttonFollowingDIP.Text = "Following DIP";
            this.m_buttonFollowingDIP.UseVisualStyleBackColor = true;
            this.m_buttonFollowingDIP.Click += new System.EventHandler(this.m_buttonFollowingDIP_Click);
            // 
            // m_buttonViolatingDIP
            // 
            this.m_buttonViolatingDIP.Location = new System.Drawing.Point(29, 179);
            this.m_buttonViolatingDIP.Name = "m_buttonViolatingDIP";
            this.m_buttonViolatingDIP.Size = new System.Drawing.Size(178, 48);
            this.m_buttonViolatingDIP.TabIndex = 5;
            this.m_buttonViolatingDIP.Text = "Violating DIP";
            this.m_buttonViolatingDIP.UseVisualStyleBackColor = true;
            this.m_buttonViolatingDIP.Click += new System.EventHandler(this.m_buttonViolatingDIP_Click);
            // 
            // m_labelDIP
            // 
            this.m_labelDIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.m_labelDIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_labelDIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_labelDIP.ForeColor = System.Drawing.Color.White;
            this.m_labelDIP.Location = new System.Drawing.Point(0, 0);
            this.m_labelDIP.Name = "m_labelDIP";
            this.m_labelDIP.Size = new System.Drawing.Size(229, 159);
            this.m_labelDIP.TabIndex = 2;
            this.m_labelDIP.Text = "Dependency Inversion Principle (DIP)";
            this.m_labelDIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_labelDIP.Click += new System.EventHandler(this.m_labelDIP_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.m_buttonFollowingISP);
            this.panel5.Controls.Add(this.m_buttonViolatingISP);
            this.panel5.Controls.Add(this.m_labelISP);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(718, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 327);
            this.panel5.TabIndex = 1;
            // 
            // m_buttonFollowingISP
            // 
            this.m_buttonFollowingISP.Location = new System.Drawing.Point(22, 263);
            this.m_buttonFollowingISP.Name = "m_buttonFollowingISP";
            this.m_buttonFollowingISP.Size = new System.Drawing.Size(178, 48);
            this.m_buttonFollowingISP.TabIndex = 4;
            this.m_buttonFollowingISP.Text = "Following ISP";
            this.m_buttonFollowingISP.UseVisualStyleBackColor = true;
            this.m_buttonFollowingISP.Click += new System.EventHandler(this.m_buttonFollowingISP_Click);
            // 
            // m_buttonViolatingISP
            // 
            this.m_buttonViolatingISP.Location = new System.Drawing.Point(22, 179);
            this.m_buttonViolatingISP.Name = "m_buttonViolatingISP";
            this.m_buttonViolatingISP.Size = new System.Drawing.Size(178, 48);
            this.m_buttonViolatingISP.TabIndex = 5;
            this.m_buttonViolatingISP.Text = "Violating ISP";
            this.m_buttonViolatingISP.UseVisualStyleBackColor = true;
            this.m_buttonViolatingISP.Click += new System.EventHandler(this.m_buttonViolatingISP_Click);
            // 
            // m_labelISP
            // 
            this.m_labelISP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.m_labelISP.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_labelISP.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_labelISP.ForeColor = System.Drawing.Color.White;
            this.m_labelISP.Location = new System.Drawing.Point(0, 0);
            this.m_labelISP.Name = "m_labelISP";
            this.m_labelISP.Size = new System.Drawing.Size(214, 159);
            this.m_labelISP.TabIndex = 2;
            this.m_labelISP.Text = "Interface Segregation Principle (ISP)";
            this.m_labelISP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_labelISP.Click += new System.EventHandler(this.m_labelISP_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.m_buttonFollowingLSP);
            this.panel6.Controls.Add(this.m_buttonViolatingLSP);
            this.panel6.Controls.Add(this.m_labelLSP);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(503, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(215, 327);
            this.panel6.TabIndex = 1;
            // 
            // m_buttonFollowingLSP
            // 
            this.m_buttonFollowingLSP.Location = new System.Drawing.Point(17, 263);
            this.m_buttonFollowingLSP.Name = "m_buttonFollowingLSP";
            this.m_buttonFollowingLSP.Size = new System.Drawing.Size(178, 48);
            this.m_buttonFollowingLSP.TabIndex = 4;
            this.m_buttonFollowingLSP.Text = "Following LSP";
            this.m_buttonFollowingLSP.UseVisualStyleBackColor = true;
            this.m_buttonFollowingLSP.Click += new System.EventHandler(this.m_buttonFollowingLSP_Click);
            // 
            // m_buttonViolatingLSP
            // 
            this.m_buttonViolatingLSP.Location = new System.Drawing.Point(17, 179);
            this.m_buttonViolatingLSP.Name = "m_buttonViolatingLSP";
            this.m_buttonViolatingLSP.Size = new System.Drawing.Size(178, 48);
            this.m_buttonViolatingLSP.TabIndex = 5;
            this.m_buttonViolatingLSP.Text = "Violating LSP";
            this.m_buttonViolatingLSP.UseVisualStyleBackColor = true;
            this.m_buttonViolatingLSP.Click += new System.EventHandler(this.m_buttonViolatingLSP_Click);
            // 
            // m_labelLSP
            // 
            this.m_labelLSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.m_labelLSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_labelLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_labelLSP.ForeColor = System.Drawing.Color.White;
            this.m_labelLSP.Location = new System.Drawing.Point(0, 0);
            this.m_labelLSP.Name = "m_labelLSP";
            this.m_labelLSP.Size = new System.Drawing.Size(211, 159);
            this.m_labelLSP.TabIndex = 2;
            this.m_labelLSP.Text = "Liskov Substitution Principle (LSP)";
            this.m_labelLSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_labelLSP.Click += new System.EventHandler(this.m_labelLSP_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.m_buttonFollowingOCP);
            this.panel3.Controls.Add(this.m_buttonViolatingOCP);
            this.panel3.Controls.Add(this.m_labelOCP);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(261, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 327);
            this.panel3.TabIndex = 1;
            // 
            // m_buttonFollowingOCP
            // 
            this.m_buttonFollowingOCP.Location = new System.Drawing.Point(31, 263);
            this.m_buttonFollowingOCP.Name = "m_buttonFollowingOCP";
            this.m_buttonFollowingOCP.Size = new System.Drawing.Size(178, 48);
            this.m_buttonFollowingOCP.TabIndex = 4;
            this.m_buttonFollowingOCP.Text = "Following OCP";
            this.m_buttonFollowingOCP.UseVisualStyleBackColor = true;
            this.m_buttonFollowingOCP.Click += new System.EventHandler(this.m_buttonFollowingOCP_Click);
            // 
            // m_buttonViolatingOCP
            // 
            this.m_buttonViolatingOCP.Location = new System.Drawing.Point(31, 179);
            this.m_buttonViolatingOCP.Name = "m_buttonViolatingOCP";
            this.m_buttonViolatingOCP.Size = new System.Drawing.Size(178, 48);
            this.m_buttonViolatingOCP.TabIndex = 5;
            this.m_buttonViolatingOCP.Text = "Violating OCP";
            this.m_buttonViolatingOCP.UseVisualStyleBackColor = true;
            this.m_buttonViolatingOCP.Click += new System.EventHandler(this.m_buttonViolatingOCP_Click);
            // 
            // m_labelOCP
            // 
            this.m_labelOCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.m_labelOCP.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_labelOCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_labelOCP.ForeColor = System.Drawing.Color.White;
            this.m_labelOCP.Location = new System.Drawing.Point(0, 0);
            this.m_labelOCP.Name = "m_labelOCP";
            this.m_labelOCP.Size = new System.Drawing.Size(238, 159);
            this.m_labelOCP.TabIndex = 2;
            this.m_labelOCP.Text = "Open/Closed Principle (OCP)";
            this.m_labelOCP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_labelOCP.Click += new System.EventHandler(this.m_labelOCP_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.m_buttonFollowingSRP);
            this.panel2.Controls.Add(this.m_buttonViolatingSRP);
            this.panel2.Controls.Add(this.m_labelSRP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 327);
            this.panel2.TabIndex = 0;
            // 
            // m_buttonFollowingSRP
            // 
            this.m_buttonFollowingSRP.Location = new System.Drawing.Point(47, 263);
            this.m_buttonFollowingSRP.Name = "m_buttonFollowingSRP";
            this.m_buttonFollowingSRP.Size = new System.Drawing.Size(178, 48);
            this.m_buttonFollowingSRP.TabIndex = 3;
            this.m_buttonFollowingSRP.Text = "Following SRP";
            this.m_buttonFollowingSRP.UseVisualStyleBackColor = true;
            this.m_buttonFollowingSRP.Click += new System.EventHandler(this.m_buttonFollowingSRP_Click);
            // 
            // m_buttonViolatingSRP
            // 
            this.m_buttonViolatingSRP.Location = new System.Drawing.Point(47, 179);
            this.m_buttonViolatingSRP.Name = "m_buttonViolatingSRP";
            this.m_buttonViolatingSRP.Size = new System.Drawing.Size(178, 48);
            this.m_buttonViolatingSRP.TabIndex = 3;
            this.m_buttonViolatingSRP.Text = "Violating SRP";
            this.m_buttonViolatingSRP.UseVisualStyleBackColor = true;
            this.m_buttonViolatingSRP.Click += new System.EventHandler(this.m_buttonViolatingSRP_Click);
            // 
            // m_labelSRP
            // 
            this.m_labelSRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.m_labelSRP.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_labelSRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_labelSRP.ForeColor = System.Drawing.Color.White;
            this.m_labelSRP.Location = new System.Drawing.Point(0, 0);
            this.m_labelSRP.Name = "m_labelSRP";
            this.m_labelSRP.Size = new System.Drawing.Size(257, 159);
            this.m_labelSRP.TabIndex = 1;
            this.m_labelSRP.Text = "Single Responsibility Principle (SRP)";
            this.m_labelSRP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_labelSRP.Click += new System.EventHandler(this.m_labelSRP_Click);
            // 
            // SOLID_Principals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 367);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_labelSOLID);
            this.Name = "SOLID_Principals";
            this.Text = "SOLID";
            this.Load += new System.EventHandler(this.SOLID_Principals_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_labelSOLID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label m_labelDIP;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label m_labelISP;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label m_labelLSP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label m_labelOCP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label m_labelSRP;
        private System.Windows.Forms.Button m_buttonFollowingDIP;
        private System.Windows.Forms.Button m_buttonViolatingDIP;
        private System.Windows.Forms.Button m_buttonFollowingISP;
        private System.Windows.Forms.Button m_buttonViolatingISP;
        private System.Windows.Forms.Button m_buttonFollowingLSP;
        private System.Windows.Forms.Button m_buttonViolatingLSP;
        private System.Windows.Forms.Button m_buttonFollowingOCP;
        private System.Windows.Forms.Button m_buttonViolatingOCP;
        private System.Windows.Forms.Button m_buttonFollowingSRP;
        private System.Windows.Forms.Button m_buttonViolatingSRP;
    }
}

