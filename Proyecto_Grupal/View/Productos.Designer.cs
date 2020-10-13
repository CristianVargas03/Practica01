﻿namespace View
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.panel_producto = new System.Windows.Forms.Panel();
            this.crud_productos = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Nombre_producto = new System.Windows.Forms.Label();
            this.txt_nombre_producto = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.lbl_Fecha_vencimiento = new System.Windows.Forms.Label();
            this.txt_fecha_vencimiento = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.txt_categoria = new System.Windows.Forms.TextBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.cb_Estado = new System.Windows.Forms.ComboBox();
            this.panel_producto.SuspendLayout();
            this.crud_productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_producto
            // 
            this.panel_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.panel_producto.Controls.Add(this.cb_Estado);
            this.panel_producto.Controls.Add(this.lbl_Estado);
            this.panel_producto.Controls.Add(this.lbl_categoria);
            this.panel_producto.Controls.Add(this.txt_categoria);
            this.panel_producto.Controls.Add(this.lbl_descripcion);
            this.panel_producto.Controls.Add(this.txt_Descripcion);
            this.panel_producto.Controls.Add(this.lbl_Fecha_vencimiento);
            this.panel_producto.Controls.Add(this.txt_fecha_vencimiento);
            this.panel_producto.Controls.Add(this.lbl_stock);
            this.panel_producto.Controls.Add(this.txt_stock);
            this.panel_producto.Controls.Add(this.lbl_codigo);
            this.panel_producto.Controls.Add(this.txt_codigo);
            this.panel_producto.Controls.Add(this.lbl_Nombre_producto);
            this.panel_producto.Controls.Add(this.txt_nombre_producto);
            this.panel_producto.Controls.Add(this.lbl_ID);
            this.panel_producto.Controls.Add(this.txt_ID);
            this.panel_producto.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_producto.Location = new System.Drawing.Point(1005, 0);
            this.panel_producto.Name = "panel_producto";
            this.panel_producto.Size = new System.Drawing.Size(218, 600);
            this.panel_producto.TabIndex = 0;
            // 
            // crud_productos
            // 
            this.crud_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.crud_productos.Controls.Add(this.btn_delete);
            this.crud_productos.Controls.Add(this.btn_update);
            this.crud_productos.Controls.Add(this.btn_Read);
            this.crud_productos.Controls.Add(this.btn_create);
            this.crud_productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.crud_productos.Location = new System.Drawing.Point(0, 0);
            this.crud_productos.Name = "crud_productos";
            this.crud_productos.Size = new System.Drawing.Size(1005, 100);
            this.crud_productos.TabIndex = 1;
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
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.Black;
            this.btn_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_create.FlatAppearance.BorderSize = 3;
            this.btn_create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_create.Image = ((System.Drawing.Image)(resources.GetObject("btn_create.Image")));
            this.btn_create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_create.Location = new System.Drawing.Point(50, 23);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(167, 58);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Create";
            this.btn_create.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_create.UseVisualStyleBackColor = false;
            // 
            // btn_Read
            // 
            this.btn_Read.BackColor = System.Drawing.Color.Black;
            this.btn_Read.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Read.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Read.FlatAppearance.BorderSize = 3;
            this.btn_Read.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Read.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_Read.Image = ((System.Drawing.Image)(resources.GetObject("btn_Read.Image")));
            this.btn_Read.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Read.Location = new System.Drawing.Point(296, 23);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(167, 58);
            this.btn_Read.TabIndex = 1;
            this.btn_Read.Text = "Read";
            this.btn_Read.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Read.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Black;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_update.FlatAppearance.BorderSize = 3;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(542, 23);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(167, 58);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Black;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_delete.FlatAppearance.BorderSize = 3;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(788, 23);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(167, 58);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(6, 62);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(188, 22);
            this.txt_ID.TabIndex = 0;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(7, 36);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(21, 17);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID";
            // 
            // lbl_Nombre_producto
            // 
            this.lbl_Nombre_producto.AutoSize = true;
            this.lbl_Nombre_producto.Location = new System.Drawing.Point(7, 93);
            this.lbl_Nombre_producto.Name = "lbl_Nombre_producto";
            this.lbl_Nombre_producto.Size = new System.Drawing.Size(142, 17);
            this.lbl_Nombre_producto.TabIndex = 3;
            this.lbl_Nombre_producto.Text = "Nombre del Producto";
            // 
            // txt_nombre_producto
            // 
            this.txt_nombre_producto.Location = new System.Drawing.Point(6, 119);
            this.txt_nombre_producto.Name = "txt_nombre_producto";
            this.txt_nombre_producto.Size = new System.Drawing.Size(188, 22);
            this.txt_nombre_producto.TabIndex = 2;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(7, 150);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(52, 17);
            this.lbl_codigo.TabIndex = 5;
            this.lbl_codigo.Text = "Codigo";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(6, 176);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(188, 22);
            this.txt_codigo.TabIndex = 4;
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(7, 207);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(43, 17);
            this.lbl_stock.TabIndex = 7;
            this.lbl_stock.Text = "Stock";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(6, 233);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(188, 22);
            this.txt_stock.TabIndex = 6;
            // 
            // lbl_Fecha_vencimiento
            // 
            this.lbl_Fecha_vencimiento.AutoSize = true;
            this.lbl_Fecha_vencimiento.Location = new System.Drawing.Point(7, 264);
            this.lbl_Fecha_vencimiento.Name = "lbl_Fecha_vencimiento";
            this.lbl_Fecha_vencimiento.Size = new System.Drawing.Size(146, 17);
            this.lbl_Fecha_vencimiento.TabIndex = 9;
            this.lbl_Fecha_vencimiento.Text = "Fecha de vencimiento";
            // 
            // txt_fecha_vencimiento
            // 
            this.txt_fecha_vencimiento.Location = new System.Drawing.Point(6, 290);
            this.txt_fecha_vencimiento.Name = "txt_fecha_vencimiento";
            this.txt_fecha_vencimiento.Size = new System.Drawing.Size(188, 22);
            this.txt_fecha_vencimiento.TabIndex = 8;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(7, 321);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(82, 17);
            this.lbl_descripcion.TabIndex = 11;
            this.lbl_descripcion.Text = "Descripcion";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(6, 347);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(188, 22);
            this.txt_Descripcion.TabIndex = 10;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Location = new System.Drawing.Point(7, 378);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(69, 17);
            this.lbl_categoria.TabIndex = 13;
            this.lbl_categoria.Text = "Categoria";
            // 
            // txt_categoria
            // 
            this.txt_categoria.Location = new System.Drawing.Point(6, 404);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(188, 22);
            this.txt_categoria.TabIndex = 12;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(7, 435);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(52, 17);
            this.lbl_Estado.TabIndex = 15;
            this.lbl_Estado.Text = "Estado";
            // 
            // cb_Estado
            // 
            this.cb_Estado.FormattingEnabled = true;
            this.cb_Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cb_Estado.Location = new System.Drawing.Point(7, 461);
            this.cb_Estado.Name = "cb_Estado";
            this.cb_Estado.Size = new System.Drawing.Size(187, 24);
            this.cb_Estado.TabIndex = 16;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.crud_productos);
            this.Controls.Add(this.panel_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.panel_producto.ResumeLayout(false);
            this.panel_producto.PerformLayout();
            this.crud_productos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_producto;
        private System.Windows.Forms.Panel crud_productos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.TextBox txt_categoria;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label lbl_Fecha_vencimiento;
        private System.Windows.Forms.TextBox txt_fecha_vencimiento;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_Nombre_producto;
        private System.Windows.Forms.TextBox txt_nombre_producto;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.ComboBox cb_Estado;
    }
}