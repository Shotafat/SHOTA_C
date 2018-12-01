namespace WindowsFormsApp2
{
    partial class Form3
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
            this.NameLabelorig = new System.Windows.Forms.Label();
            this.PriceLabelOrig = new System.Windows.Forms.Label();
            this.NameLabelEdit = new System.Windows.Forms.Label();
            this.PriceLabelEdit = new System.Windows.Forms.Label();
            this.PNameTBOR = new System.Windows.Forms.TextBox();
            this.PPriceTBOR = new System.Windows.Forms.TextBox();
            this.TNameEditBox = new System.Windows.Forms.TextBox();
            this.TPriceEditBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkayButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabelorig
            // 
            this.NameLabelorig.AutoSize = true;
            this.NameLabelorig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabelorig.Location = new System.Drawing.Point(56, 48);
            this.NameLabelorig.Name = "NameLabelorig";
            this.NameLabelorig.Size = new System.Drawing.Size(66, 24);
            this.NameLabelorig.TabIndex = 0;
            this.NameLabelorig.Text = "NAME";
            // 
            // PriceLabelOrig
            // 
            this.PriceLabelOrig.AutoSize = true;
            this.PriceLabelOrig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabelOrig.Location = new System.Drawing.Point(57, 81);
            this.PriceLabelOrig.Name = "PriceLabelOrig";
            this.PriceLabelOrig.Size = new System.Drawing.Size(65, 24);
            this.PriceLabelOrig.TabIndex = 0;
            this.PriceLabelOrig.Text = "PRICE";
            // 
            // NameLabelEdit
            // 
            this.NameLabelEdit.AutoSize = true;
            this.NameLabelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabelEdit.Location = new System.Drawing.Point(56, 138);
            this.NameLabelEdit.Name = "NameLabelEdit";
            this.NameLabelEdit.Size = new System.Drawing.Size(66, 24);
            this.NameLabelEdit.TabIndex = 0;
            this.NameLabelEdit.Text = "NAME";
            // 
            // PriceLabelEdit
            // 
            this.PriceLabelEdit.AutoSize = true;
            this.PriceLabelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabelEdit.Location = new System.Drawing.Point(57, 171);
            this.PriceLabelEdit.Name = "PriceLabelEdit";
            this.PriceLabelEdit.Size = new System.Drawing.Size(65, 24);
            this.PriceLabelEdit.TabIndex = 0;
            this.PriceLabelEdit.Text = "PRICE";
            // 
            // PNameTBOR
            // 
            this.PNameTBOR.Location = new System.Drawing.Point(129, 48);
            this.PNameTBOR.Name = "PNameTBOR";
            this.PNameTBOR.Size = new System.Drawing.Size(100, 20);
            this.PNameTBOR.TabIndex = 1;
            // 
            // PPriceTBOR
            // 
            this.PPriceTBOR.Location = new System.Drawing.Point(129, 85);
            this.PPriceTBOR.Name = "PPriceTBOR";
            this.PPriceTBOR.Size = new System.Drawing.Size(100, 20);
            this.PPriceTBOR.TabIndex = 1;
            // 
            // TNameEditBox
            // 
            this.TNameEditBox.Location = new System.Drawing.Point(128, 138);
            this.TNameEditBox.Name = "TNameEditBox";
            this.TNameEditBox.Size = new System.Drawing.Size(100, 20);
            this.TNameEditBox.TabIndex = 1;
            // 
            // TPriceEditBox
            // 
            this.TPriceEditBox.Location = new System.Drawing.Point(128, 175);
            this.TPriceEditBox.Name = "TPriceEditBox";
            this.TPriceEditBox.Size = new System.Drawing.Size(100, 20);
            this.TPriceEditBox.TabIndex = 1;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(275, 71);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OkayButton
            // 
            this.OkayButton.Location = new System.Drawing.Point(275, 117);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(75, 23);
            this.OkayButton.TabIndex = 2;
            this.OkayButton.Text = "OKAY";
            this.OkayButton.UseVisualStyleBackColor = true;
            this.OkayButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HeaderLabel.Location = new System.Drawing.Point(87, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(157, 25);
            this.HeaderLabel.TabIndex = 3;
            this.HeaderLabel.Text = "ADD PRODUCT";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 220);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.TPriceEditBox);
            this.Controls.Add(this.TNameEditBox);
            this.Controls.Add(this.PPriceTBOR);
            this.Controls.Add(this.PNameTBOR);
            this.Controls.Add(this.PriceLabelEdit);
            this.Controls.Add(this.PriceLabelOrig);
            this.Controls.Add(this.NameLabelEdit);
            this.Controls.Add(this.NameLabelorig);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabelorig;
        private System.Windows.Forms.Label PriceLabelOrig;
        private System.Windows.Forms.Label NameLabelEdit;
        private System.Windows.Forms.Label PriceLabelEdit;
        private System.Windows.Forms.TextBox PNameTBOR;
        private System.Windows.Forms.TextBox PPriceTBOR;
        private System.Windows.Forms.TextBox TNameEditBox;
        private System.Windows.Forms.TextBox TPriceEditBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkayButton;
        private System.Windows.Forms.Label HeaderLabel;
    }
}