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
            this.btn_create = new System.Windows.Forms.Button();
            this.cb_estado_categoria = new System.Windows.Forms.ComboBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_Nombre_Categoria = new System.Windows.Forms.Label();
            this.txt_Nombre_Categoria = new System.Windows.Forms.TextBox();
            this.crud_productos = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            this.dgCategoria = new System.Windows.Forms.DataGridView();
            this.panel_producto.SuspendLayout();
            this.crud_productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_producto
            // 
            this.panel_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.panel_producto.Controls.Add(this.btn_create);
            this.panel_producto.Controls.Add(this.cb_estado_categoria);
            this.panel_producto.Controls.Add(this.lbl_Estado);
            this.panel_producto.Controls.Add(this.lbl_Nombre_Categoria);
            this.panel_producto.Controls.Add(this.txt_Nombre_Categoria);
            this.panel_producto.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_producto.Location = new System.Drawing.Point(731, 0);
            this.panel_producto.Margin = new System.Windows.Forms.Padding(2);
            this.panel_producto.Name = "panel_producto";
            this.panel_producto.Size = new System.Drawing.Size(186, 488);
            this.panel_producto.TabIndex = 1;
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.Black;
            this.btn_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_create.FlatAppearance.BorderSize = 2;
            this.btn_create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_create.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_create.Image = ((System.Drawing.Image)(resources.GetObject("btn_create.Image")));
            this.btn_create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_create.Location = new System.Drawing.Point(4, 248);
            this.btn_create.Margin = new System.Windows.Forms.Padding(2);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(169, 47);
            this.btn_create.TabIndex = 7;
            this.btn_create.Text = "Save";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // cb_estado_categoria
            // 
            this.cb_estado_categoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estado_categoria.FormattingEnabled = true;
            this.cb_estado_categoria.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cb_estado_categoria.Location = new System.Drawing.Point(6, 175);
            this.cb_estado_categoria.Margin = new System.Windows.Forms.Padding(2);
            this.cb_estado_categoria.Name = "cb_estado_categoria";
            this.cb_estado_categoria.Size = new System.Drawing.Size(169, 29);
            this.cb_estado_categoria.TabIndex = 6;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.Location = new System.Drawing.Point(7, 152);
            this.lbl_Estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(64, 21);
            this.lbl_Estado.TabIndex = 5;
            this.lbl_Estado.Text = "Estado";
            // 
            // lbl_Nombre_Categoria
            // 
            this.lbl_Nombre_Categoria.AutoSize = true;
            this.lbl_Nombre_Categoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre_Categoria.Location = new System.Drawing.Point(7, 89);
            this.lbl_Nombre_Categoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nombre_Categoria.Name = "lbl_Nombre_Categoria";
            this.lbl_Nombre_Categoria.Size = new System.Drawing.Size(73, 21);
            this.lbl_Nombre_Categoria.TabIndex = 3;
            this.lbl_Nombre_Categoria.Text = "Nombre";
            // 
            // txt_Nombre_Categoria
            // 
            this.txt_Nombre_Categoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre_Categoria.Location = new System.Drawing.Point(6, 111);
            this.txt_Nombre_Categoria.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nombre_Categoria.Name = "txt_Nombre_Categoria";
            this.txt_Nombre_Categoria.Size = new System.Drawing.Size(169, 27);
            this.txt_Nombre_Categoria.TabIndex = 2;
            // 
            // crud_productos
            // 
            this.crud_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.crud_productos.Controls.Add(this.btn_delete);
            this.crud_productos.Controls.Add(this.btn_update);
            this.crud_productos.Controls.Add(this.btn_Read);
            this.crud_productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.crud_productos.Location = new System.Drawing.Point(0, 0);
            this.crud_productos.Margin = new System.Windows.Forms.Padding(2);
            this.crud_productos.Name = "crud_productos";
            this.crud_productos.Size = new System.Drawing.Size(731, 81);
            this.crud_productos.TabIndex = 2;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Black;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_delete.FlatAppearance.BorderSize = 2;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(572, 40);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(141, 37);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Black;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_update.FlatAppearance.BorderSize = 2;
            this.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(276, 40);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(141, 37);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Read
            // 
            this.btn_Read.BackColor = System.Drawing.Color.Black;
            this.btn_Read.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Read.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Read.FlatAppearance.BorderSize = 2;
            this.btn_Read.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Read.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Read.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Read.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_Read.Image = ((System.Drawing.Image)(resources.GetObject("btn_Read.Image")));
            this.btn_Read.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Read.Location = new System.Drawing.Point(11, 40);
            this.btn_Read.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(141, 37);
            this.btn_Read.TabIndex = 4;
            this.btn_Read.Text = "Read";
            this.btn_Read.UseVisualStyleBackColor = false;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // dgCategoria
            // 
            this.dgCategoria.BackgroundColor = System.Drawing.Color.White;
            this.dgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCategoria.Location = new System.Drawing.Point(0, 81);
            this.dgCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.dgCategoria.Name = "dgCategoria";
            this.dgCategoria.RowHeadersWidth = 51;
            this.dgCategoria.RowTemplate.Height = 24;
            this.dgCategoria.Size = new System.Drawing.Size(731, 407);
            this.dgCategoria.TabIndex = 3;
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 488);
            this.Controls.Add(this.dgCategoria);
            this.Controls.Add(this.crud_productos);
            this.Controls.Add(this.panel_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            this.panel_producto.ResumeLayout(false);
            this.panel_producto.PerformLayout();
            this.crud_productos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_producto;
        private System.Windows.Forms.ComboBox cb_estado_categoria;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_Nombre_Categoria;
        private System.Windows.Forms.TextBox txt_Nombre_Categoria;
        private System.Windows.Forms.Panel crud_productos;
        private System.Windows.Forms.DataGridView dgCategoria;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Button btn_create;
    }
}