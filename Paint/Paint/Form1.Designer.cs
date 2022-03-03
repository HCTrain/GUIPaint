namespace Paint
{
    partial class Paint
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
            this.btnSizeSmall = new System.Windows.Forms.Button();
            this.btnSizeBig = new System.Windows.Forms.Button();
            this.btnChangeColour = new System.Windows.Forms.Button();
            this.trckbarChangeSize = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trckbarChangeSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSizeSmall
            // 
            this.btnSizeSmall.Location = new System.Drawing.Point(13, 13);
            this.btnSizeSmall.Name = "btnSizeSmall";
            this.btnSizeSmall.Size = new System.Drawing.Size(115, 21);
            this.btnSizeSmall.TabIndex = 0;
            this.btnSizeSmall.Text = "Small Brush";
            this.btnSizeSmall.UseVisualStyleBackColor = true;
            this.btnSizeSmall.Click += new System.EventHandler(this.btnSizeSmall_Click);
            // 
            // btnSizeBig
            // 
            this.btnSizeBig.Location = new System.Drawing.Point(12, 40);
            this.btnSizeBig.Name = "btnSizeBig";
            this.btnSizeBig.Size = new System.Drawing.Size(116, 22);
            this.btnSizeBig.TabIndex = 1;
            this.btnSizeBig.Text = "Big Brush";
            this.btnSizeBig.UseVisualStyleBackColor = true;
            this.btnSizeBig.Click += new System.EventHandler(this.btnSizeBig_Click);
            // 
            // btnChangeColour
            // 
            this.btnChangeColour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChangeColour.Location = new System.Drawing.Point(13, 68);
            this.btnChangeColour.Name = "btnChangeColour";
            this.btnChangeColour.Size = new System.Drawing.Size(116, 23);
            this.btnChangeColour.TabIndex = 2;
            this.btnChangeColour.Text = "Change Colour";
            this.btnChangeColour.UseVisualStyleBackColor = true;
            this.btnChangeColour.Click += new System.EventHandler(this.btnChangeColour_Click);
            // 
            // trckbarChangeSize
            // 
            this.trckbarChangeSize.Location = new System.Drawing.Point(158, 13);
            this.trckbarChangeSize.Maximum = 100;
            this.trckbarChangeSize.Name = "trckbarChangeSize";
            this.trckbarChangeSize.Size = new System.Drawing.Size(104, 45);
            this.trckbarChangeSize.TabIndex = 3;
            this.trckbarChangeSize.TickFrequency = 10;
            this.trckbarChangeSize.Scroll += new System.EventHandler(this.trckbarChangeSize_Scroll);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 402);
            this.Controls.Add(this.trckbarChangeSize);
            this.Controls.Add(this.btnChangeColour);
            this.Controls.Add(this.btnSizeBig);
            this.Controls.Add(this.btnSizeSmall);
            this.Name = "Paint";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Paint_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.trckbarChangeSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSizeSmall;
        private System.Windows.Forms.Button btnSizeBig;
        private System.Windows.Forms.Button btnChangeColour;
        private System.Windows.Forms.TrackBar trckbarChangeSize;
    }
}

