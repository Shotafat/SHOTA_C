namespace WindowsFormsApp2
{
    partial class Form2
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
            this.Fpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NumLabel = new System.Windows.Forms.Label();
            this.salesbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fpanel
            // 
            this.Fpanel.Location = new System.Drawing.Point(21, 12);
            this.Fpanel.Name = "Fpanel";
            this.Fpanel.Size = new System.Drawing.Size(159, 119);
            this.Fpanel.TabIndex = 0;
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumLabel.Location = new System.Drawing.Point(21, 190);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(23, 25);
            this.NumLabel.TabIndex = 1;
            this.NumLabel.Text = "0";
            // 
            // salesbutton
            // 
            this.salesbutton.Location = new System.Drawing.Point(210, 12);
            this.salesbutton.Name = "salesbutton";
            this.salesbutton.Size = new System.Drawing.Size(45, 119);
            this.salesbutton.TabIndex = 2;
            this.salesbutton.Text = "SALE";
            this.salesbutton.UseVisualStyleBackColor = true;
            this.salesbutton.Click += new System.EventHandler(this.salesbutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 230);
            this.Controls.Add(this.salesbutton);
            this.Controls.Add(this.NumLabel);
            this.Controls.Add(this.Fpanel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Fpanel;
        private System.Windows.Forms.Label NumLabel;
        private System.Windows.Forms.Button salesbutton;
    }
}