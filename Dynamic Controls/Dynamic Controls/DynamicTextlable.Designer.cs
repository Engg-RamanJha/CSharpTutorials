namespace Dynamic_Controls
{
    partial class DynamicTextlable
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
            this.btn_gentext = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_genlabel = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_txtval = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gentext
            // 
            this.btn_gentext.Location = new System.Drawing.Point(288, 11);
            this.btn_gentext.Name = "btn_gentext";
            this.btn_gentext.Size = new System.Drawing.Size(75, 23);
            this.btn_gentext.TabIndex = 0;
            this.btn_gentext.Text = "Generate";
            this.btn_gentext.UseVisualStyleBackColor = true;
            this.btn_gentext.Click += new System.EventHandler(this.btn_gentext_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text Box";
            // 
            // btn_genlabel
            // 
            this.btn_genlabel.Location = new System.Drawing.Point(288, 49);
            this.btn_genlabel.Name = "btn_genlabel";
            this.btn_genlabel.Size = new System.Drawing.Size(75, 23);
            this.btn_genlabel.TabIndex = 0;
            this.btn_genlabel.Text = "Generate";
            this.btn_genlabel.UseVisualStyleBackColor = true;
            this.btn_genlabel.Click += new System.EventHandler(this.btn_genlabel_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Label";
            // 
            // btn_txtval
            // 
            this.btn_txtval.Location = new System.Drawing.Point(413, 8);
            this.btn_txtval.Name = "btn_txtval";
            this.btn_txtval.Size = new System.Drawing.Size(75, 23);
            this.btn_txtval.TabIndex = 3;
            this.btn_txtval.Text = "Get Value";
            this.btn_txtval.UseVisualStyleBackColor = true;
            this.btn_txtval.Click += new System.EventHandler(this.btn_txtval_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DynamicTextlable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_txtval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_genlabel);
            this.Controls.Add(this.btn_gentext);
            this.Name = "DynamicTextlable";
            this.Text = "Dynamic Controls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gentext;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_genlabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_txtval;
        private System.Windows.Forms.Button button1;
    }
}

