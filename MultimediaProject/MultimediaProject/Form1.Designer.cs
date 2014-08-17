namespace MultimediaProject
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
            this.pictureBoxNormal = new System.Windows.Forms.PictureBox();
            this.LoadImage = new System.Windows.Forms.Button();
            this.Rotate = new System.Windows.Forms.Button();
            this.Zoom = new System.Windows.Forms.Button();
            this.pictureBoxTransformed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransformed)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxNormal
            // 
            this.pictureBoxNormal.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxNormal.Name = "pictureBoxNormal";
            this.pictureBoxNormal.Size = new System.Drawing.Size(354, 322);
            this.pictureBoxNormal.TabIndex = 0;
            this.pictureBoxNormal.TabStop = false;
            this.pictureBoxNormal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxNormal_MouseClick);
            // 
            // LoadImage
            // 
            this.LoadImage.Location = new System.Drawing.Point(0, 411);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(119, 42);
            this.LoadImage.TabIndex = 1;
            this.LoadImage.Text = "Open Image";
            this.LoadImage.UseVisualStyleBackColor = true;
            this.LoadImage.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // Rotate
            // 
            this.Rotate.Location = new System.Drawing.Point(125, 411);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(128, 42);
            this.Rotate.TabIndex = 2;
            this.Rotate.Text = "Rotate";
            this.Rotate.UseVisualStyleBackColor = true;
            this.Rotate.Click += new System.EventHandler(this.Rotate_Click);
            // 
            // Zoom
            // 
            this.Zoom.Location = new System.Drawing.Point(259, 411);
            this.Zoom.Name = "Zoom";
            this.Zoom.Size = new System.Drawing.Size(114, 42);
            this.Zoom.TabIndex = 3;
            this.Zoom.Text = "Zoom";
            this.Zoom.UseVisualStyleBackColor = true;
            // 
            // pictureBoxTransformed
            // 
            this.pictureBoxTransformed.Location = new System.Drawing.Point(400, 12);
            this.pictureBoxTransformed.Name = "pictureBoxTransformed";
            this.pictureBoxTransformed.Size = new System.Drawing.Size(345, 310);
            this.pictureBoxTransformed.TabIndex = 4;
            this.pictureBoxTransformed.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(757, 465);
            this.Controls.Add(this.pictureBoxTransformed);
            this.Controls.Add(this.Zoom);
            this.Controls.Add(this.Rotate);
            this.Controls.Add(this.LoadImage);
            this.Controls.Add(this.pictureBoxNormal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTransformed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxNormal;
        private System.Windows.Forms.Button LoadImage;
        private System.Windows.Forms.Button Rotate;
        private System.Windows.Forms.Button Zoom;
        private System.Windows.Forms.PictureBox pictureBoxTransformed;
    }
}

