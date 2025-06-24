namespace GUI
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
            this.volunteerPage = new System.Windows.Forms.Button();
            this.btnhlpreq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // volunteerPage
            // 
            this.volunteerPage.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.volunteerPage.Font = new System.Drawing.Font("Cascadia Mono", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volunteerPage.Location = new System.Drawing.Point(582, 149);
            this.volunteerPage.Margin = new System.Windows.Forms.Padding(4);
            this.volunteerPage.Name = "volunteerPage";
            this.volunteerPage.Size = new System.Drawing.Size(328, 250);
            this.volunteerPage.TabIndex = 0;
            this.volunteerPage.Text = "מתנדב";
            this.volunteerPage.UseVisualStyleBackColor = false;
            this.volunteerPage.Click += new System.EventHandler(this.volunteerPage_Click);
            // 
            // btnhlpreq
            // 
            this.btnhlpreq.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnhlpreq.Font = new System.Drawing.Font("Cascadia Mono", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhlpreq.Location = new System.Drawing.Point(155, 149);
            this.btnhlpreq.Name = "btnhlpreq";
            this.btnhlpreq.Size = new System.Drawing.Size(328, 250);
            this.btnhlpreq.TabIndex = 1;
            this.btnhlpreq.Text = "מבקש עזרה";
            this.btnhlpreq.UseVisualStyleBackColor = false;
            this.btnhlpreq.Click += new System.EventHandler(this.btnhlpreq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnhlpreq);
            this.Controls.Add(this.volunteerPage);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button volunteerPage;
        private System.Windows.Forms.Button btnhlpreq;
    }
}

