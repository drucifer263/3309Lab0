namespace Lab0
{
    partial class Lab0
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
            this.btnClickMe = new System.Windows.Forms.Button();
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEnterRadius = new System.Windows.Forms.Label();
            this.txtEnterRadius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(81, 91);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(75, 23);
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "Click Me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(97, 155);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(100, 20);
            this.txtEnterName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEnterRadius
            // 
            this.lblEnterRadius.AutoSize = true;
            this.lblEnterRadius.Location = new System.Drawing.Point(28, 203);
            this.lblEnterRadius.Name = "lblEnterRadius";
            this.lblEnterRadius.Size = new System.Drawing.Size(68, 13);
            this.lblEnterRadius.TabIndex = 3;
            this.lblEnterRadius.Text = "Enter Radius";
            // 
            // txtEnterRadius
            // 
            this.txtEnterRadius.Location = new System.Drawing.Point(97, 196);
            this.txtEnterRadius.Name = "txtEnterRadius";
            this.txtEnterRadius.Size = new System.Drawing.Size(100, 20);
            this.txtEnterRadius.TabIndex = 4;
            // 
            // Lab0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtEnterRadius);
            this.Controls.Add(this.lblEnterRadius);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnterName);
            this.Controls.Add(this.btnClickMe);
            this.Name = "Lab0";
            this.Text = "Lab0";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEnterRadius;
        private System.Windows.Forms.TextBox txtEnterRadius;
    }
}

