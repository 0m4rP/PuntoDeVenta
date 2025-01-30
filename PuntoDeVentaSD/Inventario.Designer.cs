namespace PuntoDeVentaSD
{
    partial class Inventario
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_inv_Agregar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btn_inv_Editar = new System.Windows.Forms.Button();
            this.btn_inv_Eliminar = new System.Windows.Forms.Button();
            this.btn_inv_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PuntoDeVentaSD.Properties.Resources.Captura_de_pantalla_2025_01_28_211757;
            this.pictureBox1.Location = new System.Drawing.Point(757, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(713, 288);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_inv_Agregar
            // 
            this.btn_inv_Agregar.Location = new System.Drawing.Point(12, 394);
            this.btn_inv_Agregar.Name = "btn_inv_Agregar";
            this.btn_inv_Agregar.Size = new System.Drawing.Size(171, 43);
            this.btn_inv_Agregar.TabIndex = 2;
            this.btn_inv_Agregar.Text = "Agregar";
            this.btn_inv_Agregar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 329);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(109, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(242, 329);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(109, 22);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(357, 329);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(109, 22);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(472, 329);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(109, 22);
            this.textBox5.TabIndex = 7;
            // 
            // btn_inv_Editar
            // 
            this.btn_inv_Editar.Location = new System.Drawing.Point(215, 394);
            this.btn_inv_Editar.Name = "btn_inv_Editar";
            this.btn_inv_Editar.Size = new System.Drawing.Size(171, 43);
            this.btn_inv_Editar.TabIndex = 8;
            this.btn_inv_Editar.Text = "Editar";
            this.btn_inv_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_inv_Eliminar
            // 
            this.btn_inv_Eliminar.Location = new System.Drawing.Point(410, 394);
            this.btn_inv_Eliminar.Name = "btn_inv_Eliminar";
            this.btn_inv_Eliminar.Size = new System.Drawing.Size(171, 43);
            this.btn_inv_Eliminar.TabIndex = 9;
            this.btn_inv_Eliminar.Text = "Eliminar";
            this.btn_inv_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_inv_Cerrar
            // 
            this.btn_inv_Cerrar.Location = new System.Drawing.Point(741, 394);
            this.btn_inv_Cerrar.Name = "btn_inv_Cerrar";
            this.btn_inv_Cerrar.Size = new System.Drawing.Size(171, 43);
            this.btn_inv_Cerrar.TabIndex = 10;
            this.btn_inv_Cerrar.Text = "Cerrar";
            this.btn_inv_Cerrar.UseVisualStyleBackColor = true;
            this.btn_inv_Cerrar.Click += new System.EventHandler(this.btn_inv_Cerrar_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 449);
            this.Controls.Add(this.btn_inv_Cerrar);
            this.Controls.Add(this.btn_inv_Eliminar);
            this.Controls.Add(this.btn_inv_Editar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_inv_Agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_inv_Agregar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btn_inv_Editar;
        private System.Windows.Forms.Button btn_inv_Eliminar;
        private System.Windows.Forms.Button btn_inv_Cerrar;
    }
}