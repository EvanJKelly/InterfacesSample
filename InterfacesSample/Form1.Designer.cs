namespace InterfacesSample
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
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btnLogData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(171, 94);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(100, 20);
            this.txtinput.TabIndex = 0;
            // 
            // btnLogData
            // 
            this.btnLogData.Location = new System.Drawing.Point(109, 174);
            this.btnLogData.Name = "btnLogData";
            this.btnLogData.Size = new System.Drawing.Size(220, 96);
            this.btnLogData.TabIndex = 1;
            this.btnLogData.Text = "Log Data";
            this.btnLogData.UseVisualStyleBackColor = true;
            this.btnLogData.Click += new System.EventHandler(this.btnLogData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 314);
            this.Controls.Add(this.btnLogData);
            this.Controls.Add(this.txtinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btnLogData;
    }
}

