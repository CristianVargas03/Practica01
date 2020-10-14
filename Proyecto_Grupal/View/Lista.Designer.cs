namespace View
{
    partial class Lista
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
            this.panel_producto = new System.Windows.Forms.Panel();
            this.btn_filtro_lista = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_producto
            // 
            this.panel_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.panel_producto.Controls.Add(this.btn_filtro_lista);
            this.panel_producto.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_producto.Location = new System.Drawing.Point(753, 0);
            this.panel_producto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_producto.Name = "panel_producto";
            this.panel_producto.Size = new System.Drawing.Size(164, 488);
            this.panel_producto.TabIndex = 2;
            // 
            // btn_filtro_lista
            // 
            this.btn_filtro_lista.BackColor = System.Drawing.Color.Black;
            this.btn_filtro_lista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filtro_lista.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_filtro_lista.FlatAppearance.BorderSize = 3;
            this.btn_filtro_lista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_filtro_lista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtro_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtro_lista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_filtro_lista.Location = new System.Drawing.Point(4, 220);
            this.btn_filtro_lista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_filtro_lista.Name = "btn_filtro_lista";
            this.btn_filtro_lista.Size = new System.Drawing.Size(157, 47);
            this.btn_filtro_lista.TabIndex = 1;
            this.btn_filtro_lista.Text = "Filtrar";
            this.btn_filtro_lista.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(753, 488);
            this.dataGridView1.TabIndex = 3;
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 488);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Lista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.panel_producto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_producto;
        private System.Windows.Forms.Button btn_filtro_lista;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}