﻿namespace Scissors.Timeline
{
    partial class SliceControl
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
            this.removeSlice = new System.Windows.Forms.Button();
            this.createSlice = new System.Windows.Forms.Button();
            this.moveUp = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            this.toggleLockButton = new System.Windows.Forms.Button();
            this.toggleVisibilityButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // removeSlice
            // 
            this.removeSlice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.removeSlice.Location = new System.Drawing.Point(9, 6);
            this.removeSlice.Margin = new System.Windows.Forms.Padding(9, 6, 0, 0);
            this.removeSlice.Name = "removeSlice";
            this.removeSlice.Size = new System.Drawing.Size(20, 20);
            this.removeSlice.TabIndex = 0;
            this.removeSlice.Text = "-";
            this.removeSlice.UseVisualStyleBackColor = true;
            this.removeSlice.Click += new System.EventHandler(this.removeSlice_Click);
            // 
            // createSlice
            // 
            this.createSlice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.createSlice.Location = new System.Drawing.Point(9, 26);
            this.createSlice.Margin = new System.Windows.Forms.Padding(0);
            this.createSlice.Name = "createSlice";
            this.createSlice.Size = new System.Drawing.Size(20, 20);
            this.createSlice.TabIndex = 1;
            this.createSlice.Text = "+";
            this.createSlice.UseVisualStyleBackColor = true;
            this.createSlice.Click += new System.EventHandler(this.createSlice_Click);
            // 
            // moveUp
            // 
            this.moveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.moveUp.Location = new System.Drawing.Point(29, 6);
            this.moveUp.Margin = new System.Windows.Forms.Padding(0);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(20, 20);
            this.moveUp.TabIndex = 2;
            this.moveUp.Text = "u";
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // moveDown
            // 
            this.moveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.moveDown.Location = new System.Drawing.Point(29, 26);
            this.moveDown.Margin = new System.Windows.Forms.Padding(0);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(20, 20);
            this.moveDown.TabIndex = 3;
            this.moveDown.Text = "d";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // toggleLockButton
            // 
            this.toggleLockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.toggleLockButton.Location = new System.Drawing.Point(49, 6);
            this.toggleLockButton.Margin = new System.Windows.Forms.Padding(0);
            this.toggleLockButton.Name = "toggleLockButton";
            this.toggleLockButton.Size = new System.Drawing.Size(20, 20);
            this.toggleLockButton.TabIndex = 4;
            this.toggleLockButton.Text = "l";
            this.toggleLockButton.UseVisualStyleBackColor = true;
            this.toggleLockButton.Click += new System.EventHandler(this.toggleLock_Click);
            // 
            // toggleVisibilityButton
            // 
            this.toggleVisibilityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.toggleVisibilityButton.Location = new System.Drawing.Point(49, 26);
            this.toggleVisibilityButton.Margin = new System.Windows.Forms.Padding(0);
            this.toggleVisibilityButton.Name = "toggleVisibilityButton";
            this.toggleVisibilityButton.Size = new System.Drawing.Size(20, 20);
            this.toggleVisibilityButton.TabIndex = 5;
            this.toggleVisibilityButton.Text = "v";
            this.toggleVisibilityButton.UseVisualStyleBackColor = true;
            this.toggleVisibilityButton.Click += new System.EventHandler(this.toggleVisibility_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(72, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(72, 46);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // SliceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.toggleVisibilityButton);
            this.Controls.Add(this.toggleLockButton);
            this.Controls.Add(this.moveDown);
            this.Controls.Add(this.moveUp);
            this.Controls.Add(this.createSlice);
            this.Controls.Add(this.removeSlice);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SliceControl";
            this.Size = new System.Drawing.Size(144, 52);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button removeSlice;
        private System.Windows.Forms.Button createSlice;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button toggleLockButton;
        private System.Windows.Forms.Button toggleVisibilityButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
