using minimarket;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class UserControl1:UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PName = new System.Windows.Forms.Label();
            this.PPrice = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.დამატებაToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.წაშლაToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.რედაქტირებაToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PName
            // 
            this.PName.AutoSize = true;
            this.PName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PName.Location = new System.Drawing.Point(13, 13);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(51, 20);
            this.PName.TabIndex = 0;
            this.PName.Text = "label1";
            this.PName.Click += new System.EventHandler(this.UserControl1_Load);
            // 
            // PPrice
            // 
            this.PPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PPrice.AutoSize = true;
            this.PPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPrice.Location = new System.Drawing.Point(44, 68);
            this.PPrice.Name = "PPrice";
            this.PPrice.Size = new System.Drawing.Size(58, 22);
            this.PPrice.TabIndex = 1;
            this.PPrice.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.დამატებაToolStripMenuItem,
            this.წაშლაToolStripMenuItem,
            this.რედაქტირებაToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // დამატებაToolStripMenuItem
            // 
            this.დამატებაToolStripMenuItem.Name = "დამატებაToolStripMenuItem";
            this.დამატებაToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.დამატებაToolStripMenuItem.Text = "დამატება";
            this.დამატებაToolStripMenuItem.Click += new System.EventHandler(this.დამატებაToolStripMenuItem_Click);
            // 
            // წაშლაToolStripMenuItem
            // 
            this.წაშლაToolStripMenuItem.Name = "წაშლაToolStripMenuItem";
            this.წაშლაToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.წაშლაToolStripMenuItem.Text = "წაშლა";
            this.წაშლაToolStripMenuItem.Click += new System.EventHandler(this.წაშლაToolStripMenuItem_Click);
            // 
            // რედაქტირებაToolStripMenuItem
            // 
            this.რედაქტირებაToolStripMenuItem.Name = "რედაქტირებაToolStripMenuItem";
            this.რედაქტირებაToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.რედაქტირებაToolStripMenuItem.Text = "რედაქტირება";
            this.რედაქტირებაToolStripMenuItem.Click += new System.EventHandler(this.რედაქტირებაToolStripMenuItem_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.PPrice);
            this.Controls.Add(this.PName);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(197, 153);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Click += new System.EventHandler(this.UserControl1_Click);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        
      


      



        public System.Windows.Forms.Label PName;
        public System.Windows.Forms.Label PPrice;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem დამატებაToolStripMenuItem;
        private ToolStripMenuItem წაშლაToolStripMenuItem;
        private ToolStripMenuItem რედაქტირებაToolStripMenuItem;
    }
}
