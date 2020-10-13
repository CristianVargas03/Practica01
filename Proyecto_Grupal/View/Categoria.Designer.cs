namespace View
{
    partial class Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categoria));
            this.panel_producto = new System.Windows.Forms.Panel();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_Nombre_Categoria = new System.Windows.Forms.Label();
            this.txt_Nombre_Categoria = new System.Windows.Forms.TextBox();
            this.lbl_ID_categoria = new System.Windows.Forms.Label();
            this.txt_ID_Categoria = new System.Windows.Forms.TextBox();
            this.cb_estado_categoria = new System.Windows.Forms.ComboBox();
            this.crud_productos = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_delete_categoria = new System.Windows.Forms.Button();
            this.btn_update_categoria = new System.Windows.Forms.Button();
            this.btn_Read_categoria = new System.Windows.Forms.Button();
            this.btn_create_categoria = new System.Windows.Forms.Button();
            this.panel_producto.SuspendLayout();
            this.crud_productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_producto
            // 
            this.panel_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.panel_producto.Controls.Add(this.cb_estado_categoria);
            this.panel_producto.Controls.Add(this.lbl_Estado);
            this.panel_producto.Controls.Add(this.lbl_Nombre_Categoria);
            this.panel_producto.Controls.Add(this.txt_Nombre_Categoria);
            this.panel_producto.Controls.Add(this.lbl_ID_categoria);
            this.panel_producto.Controls.Add(this.txt_ID_Categoria);
            this.panel_producto.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_producto.Location = new System.Drawing.Point(1005, 0);
            this.panel_producto.Name = "panel_producto";
            this.panel_producto.Size = new System.Drawing.Size(218, 600);
            this.panel_producto.TabIndex = 1;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(7, 154);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(52, 17);
            this.lbl_Estado.TabIndex = 5;
            this.lbl_Estado.Text = "Estado";
            // 
            // lbl_Nombre_Categoria
            // 
            this.lbl_Nombre_Categoria.AutoSize = true;
            this.lbl_Nombre_Categoria.Location = new System.Drawing.Point(7, 95);
            this.lbl_Nombre_Categoria.Name = "lbl_Nombre_Categoria";
            this.lbl_Nombre_Categoria.Size = new System.Drawing.Size(58, 17);
            this.lbl_Nombre_Categoria.TabIndex = 3;
            this.lbl_Nombre_Categoria.Text = "Nombre";
            // 
            // txt_Nombre_Categoria
            // 
            this.txt_Nombre_Categoria.Location = new System.Drawing.Point(6, 122);
            this.txt_Nombre_Categoria.Name = "txt_Nombre_Categoria";
            this.txt_Nombre_Categoria.Size = new System.Drawing.Size(188, 22);
            this.txt_Nombre_Categoria.TabIndex = 2;
            // 
            // lbl_ID_categoria
            // 
            this.lbl_ID_categoria.AutoSize = true;
            this.lbl_ID_categoria.Location = new System.Drawing.Point(7, 36);
            this.lbl_ID_categoria.Name = "lbl_ID_categoria";
            this.lbl_ID_categoria.Size = new System.Drawing.Size(21, 17);
            this.lbl_ID_categoria.TabIndex = 1;
            this.lbl_ID_categoria.Text = "ID";
            // 
            // txt_ID_Categoria
            // 
            this.txt_ID_Categoria.Location = new System.Drawing.Point(6, 63);
            this.txt_ID_Categoria.Name = "txt_ID_Categoria";
            this.txt_ID_Categoria.Size = new System.Drawing.Size(188, 22);
            this.txt_ID_Categoria.TabIndex = 0;
            // 
            // cb_estado_categoria
            // 
            this.cb_estado_categoria.FormattingEnabled = true;
            this.cb_estado_categoria.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cb_estado_categoria.Location = new System.Drawing.Point(6, 174);
            this.cb_estado_categoria.Name = "cb_estado_categoria";
            this.cb_estado_categoria.Size = new System.Drawing.Size(188, 24);
            this.cb_estado_categoria.TabIndex = 6;
            // 
            // crud_productos
            // 
            this.crud_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.crud_productos.Controls.Add(this.btn_delete_categoria);
            this.crud_productos.Controls.Add(this.btn_update_categoria);
            this.crud_productos.Controls.Add(this.btn_Read_categoria);
            this.crud_productos.Controls.Add(this.btn_create_categoria);
            this.crud_productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.crud_productos.Location = new System.Drawing.Point(0, 0);
            this.crud_productos.Name = "crud_productos";
            this.crud_productos.Size = new System.Drawing.Size(1005, 100);
            this.crud_productos.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 500);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_delete_categoria
            // 
            this.btn_delete_categoria.BackColor = System.Drawing.Color.Black;
            this.btn_delete_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_categoria.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_delete_categoria.FlatAppearance.BorderSize = 3;
            this.btn_delete_categoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_delete_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_delete_categoria.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete_categoria.Image")));
            this.btn_delete_categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete_categoria.Location = new System.Drawing.Point(788, 21);
            this.btn_delete_categoria.Name = "btn_delete_categoria";
            this.btn_delete_categoria.Size = new System.Drawing.Size(167, 58);
            this.btn_delete_categoria.TabIndex = 11;
            this.btn_delete_categoria.Text = "Delete";
            this.btn_delete_categoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete_categoria.UseVisualStyleBackColor = false;
            // 
            // btn_update_categoria
            // 
            this.btn_update_categoria.BackColor = System.Drawing.Color.Black;
            this.btn_update_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_categoria.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_update_categoria.FlatAppearance.BorderSize = 3;
            this.btn_update_categoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_update_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_update_categoria.Image = ((System.Drawing.Image)(resources.GetObject("btn_update_categoria.Image")));
            this.btn_update_categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update_categoria.Location = new System.Drawing.Point(542, 21);
            this.btn_update_categoria.Name = "btn_update_categoria";
            this.btn_update_categoria.Size = new System.Drawing.Size(167, 58);
            this.btn_update_categoria.TabIndex = 10;
            this.btn_update_categoria.Text = "Update";
            this.btn_update_categoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update_categoria.UseVisualStyleBackColor = false;
            // 
            // btn_Read_categoria
            // 
            this.btn_Read_categoria.BackColor = System.Drawing.Color.Black;
            this.btn_Read_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Read_categoria.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Read_categoria.FlatAppearance.BorderSize = 3;
            this.btn_Read_categoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Read_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Read_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Read_categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_Read_categoria.Image = ((System.Drawing.Image)(resources.GetObject("btn_Read_categoria.Image")));
            this.btn_Read_categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Read_categoria.Location = new System.Drawing.Point(296, 21);
            this.btn_Read_categoria.Name = "btn_Read_categoria";
            this.btn_Read_categoria.Size = new System.Drawing.Size(167, 58);
            this.btn_Read_categoria.TabIndex = 9;
            this.btn_Read_categoria.Text = "Read";
            this.btn_Read_categoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Read_categoria.UseVisualStyleBackColor = false;
            // 
            // btn_create_categoria
            // 
            this.btn_create_categoria.BackColor = System.Drawing.Color.Black;
            this.btn_create_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create_categoria.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_create_categoria.FlatAppearance.BorderSize = 3;
            this.btn_create_categoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_create_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_categoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_create_categoria.Image = ((System.Drawing.Image)(resources.GetObject("btn_create_categoria.Image")));
            this.btn_create_categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_create_categoria.Location = new System.Drawing.Point(50, 21);
            this.btn_create_categoria.Name = "btn_create_categoria";
            this.btn_create_categoria.Size = new System.Drawing.Size(167, 58);
            this.btn_create_categoria.TabIndex = 8;
            this.btn_create_categoria.Text = "Create";
            this.btn_create_categoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_create_categoria.UseVisualStyleBackColor = false;
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.crud_productos);
            this.Controls.Add(this.panel_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categoria";
            this.Text = "Categoria";
            this.panel_producto.ResumeLayout(false);
            this.panel_producto.PerformLayout();
            this.crud_productos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_producto;
        private System.Windows.Forms.ComboBox cb_estado_categoria;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_Nombre_Categoria;
        private System.Windows.Forms.TextBox txt_Nombre_Categoria;
        private System.Windows.Forms.Label lbl_ID_categoria;
        private System.Windows.Forms.TextBox txt_ID_Categoria;
        private System.Windows.Forms.Panel crud_productos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_delete_categoria;
        private System.Windows.Forms.Button btn_update_categoria;
        private System.Windows.Forms.Button btn_Read_categoria;
        private System.Windows.Forms.Button btn_create_categoria;
    }
}