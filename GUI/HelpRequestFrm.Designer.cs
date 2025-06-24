namespace GUI
{
    partial class HelpRequestFrm
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
            this.btnhome = new System.Windows.Forms.Button();
            this.btnishour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblmosthours = new System.Windows.Forms.Label();
            this.lblvolinservice = new System.Windows.Forms.Label();
            this.lblreqapproved = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.LightCoral;
            this.btnhome.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.Brown;
            this.btnhome.Location = new System.Drawing.Point(111, 441);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(251, 81);
            this.btnhome.TabIndex = 0;
            this.btnhome.Text = "<---  לדף הבית";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.BackColorChanged += new System.EventHandler(this.btnishour_Click);
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnishour
            // 
            this.btnishour.BackColor = System.Drawing.Color.LightCoral;
            this.btnishour.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnishour.ForeColor = System.Drawing.Color.Brown;
            this.btnishour.Location = new System.Drawing.Point(811, 441);
            this.btnishour.Name = "btnishour";
            this.btnishour.Size = new System.Drawing.Size(174, 81);
            this.btnishour.TabIndex = 1;
            this.btnishour.Text = "בדוק";
            this.btnishour.UseVisualStyleBackColor = false;
            this.btnishour.Click += new System.EventHandler(this.btnishour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(967, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "הכנס מספר שירות";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightCoral;
            this.textBox1.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(773, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 39);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(702, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = " - מתנדב שנותרו לו הכי הרבה שעות לתרום";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(833, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = " - כמות המתנדבים בשירות זה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(854, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = " - כמה בקשות אושרו השנה";
            // 
            // lblmosthours
            // 
            this.lblmosthours.AutoSize = true;
            this.lblmosthours.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmosthours.ForeColor = System.Drawing.Color.Brown;
            this.lblmosthours.Location = new System.Drawing.Point(702, 194);
            this.lblmosthours.Name = "lblmosthours";
            this.lblmosthours.Size = new System.Drawing.Size(113, 37);
            this.lblmosthours.TabIndex = 7;
            this.lblmosthours.Text = "label5";
            this.lblmosthours.Visible = false;
            // 
            // lblvolinservice
            // 
            this.lblvolinservice.AutoSize = true;
            this.lblvolinservice.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvolinservice.ForeColor = System.Drawing.Color.Brown;
            this.lblvolinservice.Location = new System.Drawing.Point(709, 246);
            this.lblvolinservice.Name = "lblvolinservice";
            this.lblvolinservice.Size = new System.Drawing.Size(113, 37);
            this.lblvolinservice.TabIndex = 8;
            this.lblvolinservice.Text = "label5";
            this.lblvolinservice.Visible = false;
            // 
            // lblreqapproved
            // 
            this.lblreqapproved.AutoSize = true;
            this.lblreqapproved.Font = new System.Drawing.Font("Cascadia Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreqapproved.ForeColor = System.Drawing.Color.Brown;
            this.lblreqapproved.Location = new System.Drawing.Point(723, 310);
            this.lblreqapproved.Name = "lblreqapproved";
            this.lblreqapproved.Size = new System.Drawing.Size(113, 37);
            this.lblreqapproved.TabIndex = 9;
            this.lblreqapproved.Text = "label5";
            this.lblreqapproved.Visible = false;
            // 
            // HelpRequestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1243, 591);
            this.Controls.Add(this.lblreqapproved);
            this.Controls.Add(this.lblvolinservice);
            this.Controls.Add(this.lblmosthours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnishour);
            this.Controls.Add(this.btnhome);
            this.Name = "HelpRequestFrm";
            this.Text = "HelpRequestFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnishour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblmosthours;
        private System.Windows.Forms.Label lblvolinservice;
        private System.Windows.Forms.Label lblreqapproved;
    }
}