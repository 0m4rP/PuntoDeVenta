namespace PuntoDeVentaSD
{
    partial class Grafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btn_gra_Volver = new System.Windows.Forms.Button();
            this.btn_gra_Cargar = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_gra_Volver
            // 
            this.btn_gra_Volver.Location = new System.Drawing.Point(37, 382);
            this.btn_gra_Volver.Name = "btn_gra_Volver";
            this.btn_gra_Volver.Size = new System.Drawing.Size(147, 45);
            this.btn_gra_Volver.TabIndex = 0;
            this.btn_gra_Volver.Text = "Volver";
            this.btn_gra_Volver.UseVisualStyleBackColor = true;
            this.btn_gra_Volver.Click += new System.EventHandler(this.btn_gra_Volver_Click);
            // 
            // btn_gra_Cargar
            // 
            this.btn_gra_Cargar.Location = new System.Drawing.Point(37, 331);
            this.btn_gra_Cargar.Name = "btn_gra_Cargar";
            this.btn_gra_Cargar.Size = new System.Drawing.Size(147, 45);
            this.btn_gra_Cargar.TabIndex = 1;
            this.btn_gra_Cargar.Text = "Cargar data";
            this.btn_gra_Cargar.UseVisualStyleBackColor = true;
            this.btn_gra_Cargar.Click += new System.EventHandler(this.btn_gra_Cargar_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(220, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(568, 415);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_gra_Cargar);
            this.Controls.Add(this.btn_gra_Volver);
            this.Name = "Grafico";
            this.Text = "Grafico";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_gra_Volver;
        private System.Windows.Forms.Button btn_gra_Cargar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}