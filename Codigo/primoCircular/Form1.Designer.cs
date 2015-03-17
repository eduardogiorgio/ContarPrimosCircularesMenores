namespace primoCircular
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
            this.buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPrimosCirculares = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.limitNumber = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(215, 81);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(94, 21);
            this.buscar.TabIndex = 1;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total de primos Circulares encontrados";
            // 
            // totalPrimosCirculares
            // 
            this.totalPrimosCirculares.AutoSize = true;
            this.totalPrimosCirculares.Location = new System.Drawing.Point(265, 127);
            this.totalPrimosCirculares.Name = "totalPrimosCirculares";
            this.totalPrimosCirculares.Size = new System.Drawing.Size(16, 13);
            this.totalPrimosCirculares.TabIndex = 3;
            this.totalPrimosCirculares.Text = "---";
            this.totalPrimosCirculares.Click += new System.EventHandler(this.totalPrimosCirculares_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Solo se pueden utilizar multiplos de 10 hasta el millon";
            // 
            // limitNumber
            // 
            this.limitNumber.FormattingEnabled = true;
            this.limitNumber.Items.AddRange(new object[] {
            "10",
            "100",
            "1000",
            "10000",
            "100000",
            "1000000"});
            this.limitNumber.Location = new System.Drawing.Point(72, 81);
            this.limitNumber.Name = "limitNumber";
            this.limitNumber.Size = new System.Drawing.Size(121, 21);
            this.limitNumber.TabIndex = 7;
            this.limitNumber.Text = "1000000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 288);
            this.Controls.Add(this.limitNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalPrimosCirculares);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscar);
            this.Name = "Form1";
            this.Text = "Primo circular";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPrimosCirculares;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox limitNumber;
    }
}

