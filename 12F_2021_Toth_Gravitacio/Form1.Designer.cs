namespace _12F_2021_Toth_Gravitacio
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
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.palya = new System.Windows.Forms.PictureBox();
            this.inic = new System.Windows.Forms.Button();
            this.tomeginput = new System.Windows.Forms.NumericUpDown();
            this.tomegcimke = new System.Windows.Forms.Label();
            this.monitorpanel = new System.Windows.Forms.Panel();
            this.metronom = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.palya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomeginput)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(1321, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(131, 60);
            this.start.TabIndex = 0;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // palya
            // 
            this.palya.BackColor = System.Drawing.Color.Black;
            this.palya.Location = new System.Drawing.Point(12, 12);
            this.palya.Name = "palya";
            this.palya.Size = new System.Drawing.Size(1303, 629);
            this.palya.TabIndex = 1;
            this.palya.TabStop = false;
            this.palya.Click += new System.EventHandler(this.palya_Click);
            // 
            // inic
            // 
            this.inic.Location = new System.Drawing.Point(1322, 81);
            this.inic.Name = "inic";
            this.inic.Size = new System.Drawing.Size(129, 64);
            this.inic.TabIndex = 2;
            this.inic.Text = "Törlés";
            this.inic.UseVisualStyleBackColor = true;
            // 
            // tomeginput
            // 
            this.tomeginput.Location = new System.Drawing.Point(1400, 146);
            this.tomeginput.Name = "tomeginput";
            this.tomeginput.Size = new System.Drawing.Size(51, 20);
            this.tomeginput.TabIndex = 3;
            // 
            // tomegcimke
            // 
            this.tomegcimke.AutoSize = true;
            this.tomegcimke.Location = new System.Drawing.Point(1321, 148);
            this.tomegcimke.Name = "tomegcimke";
            this.tomegcimke.Size = new System.Drawing.Size(78, 13);
            this.tomegcimke.TabIndex = 4;
            this.tomegcimke.Text = "Új test tömege:";
            // 
            // monitorpanel
            // 
            this.monitorpanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.monitorpanel.Location = new System.Drawing.Point(1324, 174);
            this.monitorpanel.Name = "monitorpanel";
            this.monitorpanel.Size = new System.Drawing.Size(126, 466);
            this.monitorpanel.TabIndex = 5;
            // 
            // metronom
            // 
            this.metronom.Tick += new System.EventHandler(this.metronom_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 653);
            this.Controls.Add(this.monitorpanel);
            this.Controls.Add(this.tomegcimke);
            this.Controls.Add(this.tomeginput);
            this.Controls.Add(this.inic);
            this.Controls.Add(this.palya);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.palya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tomeginput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.PictureBox palya;
        private System.Windows.Forms.Button inic;
        private System.Windows.Forms.NumericUpDown tomeginput;
        private System.Windows.Forms.Label tomegcimke;
        private System.Windows.Forms.Panel monitorpanel;
        private System.Windows.Forms.Timer metronom;
    }
}

