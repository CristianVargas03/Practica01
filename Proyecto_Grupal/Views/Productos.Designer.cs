namespace Practica_Grupal1.Views
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
            this.CRUD_Producto = new Guna.UI.WinForms.GunaPanel();
            this.panel_ingresos = new Guna.UI.WinForms.GunaPanel();
            this.cb_estado = new Guna.UI.WinForms.GunaComboBox();
            this.lbl_Estado = new Guna.UI.WinForms.GunaLabel();
            this.txt_categoria = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_categoria = new Guna.UI.WinForms.GunaLabel();
            this.txt_Fecha_vencimiento = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_fecha_vencimiento = new Guna.UI.WinForms.GunaLabel();
            this.txt_stock = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_stock = new Guna.UI.WinForms.GunaLabel();
            this.txt_codigo = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_codigo = new Guna.UI.WinForms.GunaLabel();
            this.txt_product_name = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_product_name = new Guna.UI.WinForms.GunaLabel();
            this.txt_id = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_ID = new Guna.UI.WinForms.GunaLabel();
            this.panel_crud = new Guna.UI.WinForms.GunaPanel();
            this.btn_delete = new Guna.UI.WinForms.GunaButton();
            this.btn_update = new Guna.UI.WinForms.GunaButton();
            this.btn_Read = new Guna.UI.WinForms.GunaButton();
            this.btn_create = new Guna.UI.WinForms.GunaButton();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.CRUD_Producto.SuspendLayout();
            this.panel_ingresos.SuspendLayout();
            this.panel_crud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // CRUD_Producto
            // 
            this.CRUD_Producto.Controls.Add(this.panel_ingresos);
            this.CRUD_Producto.Controls.Add(this.gunaTextBox2);
            this.CRUD_Producto.Controls.Add(this.gunaLabel1);
            this.CRUD_Producto.Controls.Add(this.gunaTextBox1);
            this.CRUD_Producto.Controls.Add(this.lbl_ID);
            this.CRUD_Producto.Dock = System.Windows.Forms.DockStyle.Right;
            this.CRUD_Producto.Location = new System.Drawing.Point(715, 0);
            this.CRUD_Producto.Margin = new System.Windows.Forms.Padding(2);
            this.CRUD_Producto.Name = "CRUD_Producto";
            this.CRUD_Producto.Size = new System.Drawing.Size(181, 488);
            this.CRUD_Producto.TabIndex = 0;
            // 
            // panel_ingresos
            // 
            this.panel_ingresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.panel_ingresos.Controls.Add(this.cb_estado);
            this.panel_ingresos.Controls.Add(this.lbl_Estado);
            this.panel_ingresos.Controls.Add(this.txt_categoria);
            this.panel_ingresos.Controls.Add(this.lbl_categoria);
            this.panel_ingresos.Controls.Add(this.txt_Fecha_vencimiento);
            this.panel_ingresos.Controls.Add(this.lbl_fecha_vencimiento);
            this.panel_ingresos.Controls.Add(this.txt_stock);
            this.panel_ingresos.Controls.Add(this.lbl_stock);
            this.panel_ingresos.Controls.Add(this.txt_codigo);
            this.panel_ingresos.Controls.Add(this.lbl_codigo);
            this.panel_ingresos.Controls.Add(this.txt_product_name);
            this.panel_ingresos.Controls.Add(this.lbl_product_name);
            this.panel_ingresos.Controls.Add(this.txt_id);
            this.panel_ingresos.Controls.Add(this.gunaLabel4);
            this.panel_ingresos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_ingresos.Location = new System.Drawing.Point(0, 0);
            this.panel_ingresos.Margin = new System.Windows.Forms.Padding(2);
            this.panel_ingresos.Name = "panel_ingresos";
            this.panel_ingresos.Size = new System.Drawing.Size(181, 488);
            this.panel_ingresos.TabIndex = 4;
            // 
            // cb_estado
            // 
            this.cb_estado.BackColor = System.Drawing.Color.Transparent;
            this.cb_estado.BaseColor = System.Drawing.Color.White;
            this.cb_estado.BorderColor = System.Drawing.Color.Silver;
            this.cb_estado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estado.FocusedColor = System.Drawing.Color.Empty;
            this.cb_estado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cb_estado.ForeColor = System.Drawing.Color.Black;
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cb_estado.Location = new System.Drawing.Point(2, 400);
            this.cb_estado.Margin = new System.Windows.Forms.Padding(2);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cb_estado.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_estado.Size = new System.Drawing.Size(170, 30);
            this.cb_estado.TabIndex = 13;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.Location = new System.Drawing.Point(2, 378);
            this.lbl_Estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(59, 21);
            this.lbl_Estado.TabIndex = 12;
            this.lbl_Estado.Text = "Estado";
            // 
            // txt_categoria
            // 
            this.txt_categoria.BaseColor = System.Drawing.Color.White;
            this.txt_categoria.BorderColor = System.Drawing.Color.Silver;
            this.txt_categoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_categoria.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_categoria.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_categoria.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_categoria.Location = new System.Drawing.Point(2, 340);
            this.txt_categoria.Margin = new System.Windows.Forms.Padding(2);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.PasswordChar = '\0';
            this.txt_categoria.Size = new System.Drawing.Size(170, 32);
            this.txt_categoria.TabIndex = 11;
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.Location = new System.Drawing.Point(2, 317);
            this.lbl_categoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(81, 21);
            this.lbl_categoria.TabIndex = 10;
            this.lbl_categoria.Text = "Categoria";
            // 
            // txt_Fecha_vencimiento
            // 
            this.txt_Fecha_vencimiento.BaseColor = System.Drawing.Color.White;
            this.txt_Fecha_vencimiento.BorderColor = System.Drawing.Color.Silver;
            this.txt_Fecha_vencimiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Fecha_vencimiento.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Fecha_vencimiento.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Fecha_vencimiento.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Fecha_vencimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_Fecha_vencimiento.Location = new System.Drawing.Point(2, 280);
            this.txt_Fecha_vencimiento.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Fecha_vencimiento.Name = "txt_Fecha_vencimiento";
            this.txt_Fecha_vencimiento.PasswordChar = '\0';
            this.txt_Fecha_vencimiento.Size = new System.Drawing.Size(170, 32);
            this.txt_Fecha_vencimiento.TabIndex = 9;
            // 
            // lbl_fecha_vencimiento
            // 
            this.lbl_fecha_vencimiento.AutoSize = true;
            this.lbl_fecha_vencimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_vencimiento.Location = new System.Drawing.Point(2, 257);
            this.lbl_fecha_vencimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fecha_vencimiento.Name = "lbl_fecha_vencimiento";
            this.lbl_fecha_vencimiento.Size = new System.Drawing.Size(169, 21);
            this.lbl_fecha_vencimiento.TabIndex = 8;
            this.lbl_fecha_vencimiento.Text = "Fecha de vencimiento";
            // 
            // txt_stock
            // 
            this.txt_stock.BaseColor = System.Drawing.Color.White;
            this.txt_stock.BorderColor = System.Drawing.Color.Silver;
            this.txt_stock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_stock.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_stock.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_stock.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_stock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_stock.Location = new System.Drawing.Point(2, 220);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(2);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.PasswordChar = '\0';
            this.txt_stock.Size = new System.Drawing.Size(170, 32);
            this.txt_stock.TabIndex = 7;
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(2, 197);
            this.lbl_stock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(51, 21);
            this.lbl_stock.TabIndex = 6;
            this.lbl_stock.Text = "Stock";
            // 
            // txt_codigo
            // 
            this.txt_codigo.BaseColor = System.Drawing.Color.White;
            this.txt_codigo.BorderColor = System.Drawing.Color.Silver;
            this.txt_codigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_codigo.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_codigo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_codigo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_codigo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_codigo.Location = new System.Drawing.Point(2, 160);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.PasswordChar = '\0';
            this.txt_codigo.Size = new System.Drawing.Size(170, 32);
            this.txt_codigo.TabIndex = 5;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(2, 137);
            this.lbl_codigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(64, 21);
            this.lbl_codigo.TabIndex = 4;
            this.lbl_codigo.Text = "Codigo";
            // 
            // txt_product_name
            // 
            this.txt_product_name.BaseColor = System.Drawing.Color.White;
            this.txt_product_name.BorderColor = System.Drawing.Color.Silver;
            this.txt_product_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_product_name.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_product_name.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_product_name.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_product_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_product_name.Location = new System.Drawing.Point(2, 100);
            this.txt_product_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.PasswordChar = '\0';
            this.txt_product_name.Size = new System.Drawing.Size(170, 32);
            this.txt_product_name.TabIndex = 3;
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.AutoSize = true;
            this.lbl_product_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product_name.Location = new System.Drawing.Point(2, 78);
            this.lbl_product_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(170, 21);
            this.lbl_product_name.TabIndex = 2;
            this.lbl_product_name.Text = "Nombre del Producto";
            // 
            // txt_id
            // 
            this.txt_id.BaseColor = System.Drawing.Color.White;
            this.txt_id.BorderColor = System.Drawing.Color.Silver;
            this.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_id.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_id.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_id.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txt_id.Location = new System.Drawing.Point(2, 40);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.Size = new System.Drawing.Size(170, 32);
            this.txt_id.TabIndex = 1;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(2, 16);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(26, 21);
            this.gunaLabel4.TabIndex = 0;
            this.gunaLabel4.Text = "ID";
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox2.Location = new System.Drawing.Point(2, 161);
            this.gunaTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Size = new System.Drawing.Size(120, 26);
            this.gunaTextBox2.TabIndex = 3;
            this.gunaTextBox2.Text = "gunaTextBox2";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(14, 111);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(18, 15);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "ID";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(2, 71);
            this.gunaTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Size = new System.Drawing.Size(120, 26);
            this.gunaTextBox1.TabIndex = 1;
            this.gunaTextBox1.Text = "gunaTextBox1";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_ID.Location = new System.Drawing.Point(14, 21);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 15);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID";
            // 
            // panel_crud
            // 
            this.panel_crud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.panel_crud.Controls.Add(this.btn_delete);
            this.panel_crud.Controls.Add(this.btn_update);
            this.panel_crud.Controls.Add(this.btn_Read);
            this.panel_crud.Controls.Add(this.btn_create);
            this.panel_crud.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_crud.Location = new System.Drawing.Point(0, 0);
            this.panel_crud.Margin = new System.Windows.Forms.Padding(2);
            this.panel_crud.Name = "panel_crud";
            this.panel_crud.Size = new System.Drawing.Size(715, 74);
            this.panel_crud.TabIndex = 1;
            // 
            // btn_delete
            // 
            this.btn_delete.AnimationHoverSpeed = 0.07F;
            this.btn_delete.AnimationSpeed = 0.03F;
            this.btn_delete.BaseColor = System.Drawing.Color.Black;
            this.btn_delete.BorderColor = System.Drawing.Color.Black;
            this.btn_delete.BorderSize = 1;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_delete.FocusedColor = System.Drawing.Color.Empty;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_delete.Location = new System.Drawing.Point(559, 16);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_delete.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_delete.OnHoverImage = null;
            this.btn_delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_delete.Size = new System.Drawing.Size(125, 50);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.AnimationHoverSpeed = 0.07F;
            this.btn_update.AnimationSpeed = 0.03F;
            this.btn_update.BaseColor = System.Drawing.Color.Black;
            this.btn_update.BorderColor = System.Drawing.Color.Black;
            this.btn_update.BorderSize = 1;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_update.FocusedColor = System.Drawing.Color.Empty;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_update.Location = new System.Drawing.Point(379, 16);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update.Name = "btn_update";
            this.btn_update.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_update.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_update.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_update.OnHoverImage = null;
            this.btn_update.OnPressedColor = System.Drawing.Color.Black;
            this.btn_update.Size = new System.Drawing.Size(125, 50);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Read
            // 
            this.btn_Read.AnimationHoverSpeed = 0.07F;
            this.btn_Read.AnimationSpeed = 0.03F;
            this.btn_Read.BaseColor = System.Drawing.Color.Black;
            this.btn_Read.BorderColor = System.Drawing.Color.Black;
            this.btn_Read.BorderSize = 1;
            this.btn_Read.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Read.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Read.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Read.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Read.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_Read.Image = ((System.Drawing.Image)(resources.GetObject("btn_Read.Image")));
            this.btn_Read.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Read.Location = new System.Drawing.Point(185, 16);
            this.btn_Read.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Read.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Read.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Read.OnHoverImage = null;
            this.btn_Read.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Read.Size = new System.Drawing.Size(125, 50);
            this.btn_Read.TabIndex = 1;
            this.btn_Read.Text = "Read";
            this.btn_Read.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // btn_create
            // 
            this.btn_create.AnimationHoverSpeed = 0.07F;
            this.btn_create.AnimationSpeed = 0.03F;
            this.btn_create.BaseColor = System.Drawing.Color.Black;
            this.btn_create.BorderColor = System.Drawing.Color.Black;
            this.btn_create.BorderSize = 1;
            this.btn_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_create.FocusedColor = System.Drawing.Color.Empty;
            this.btn_create.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_create.Image = ((System.Drawing.Image)(resources.GetObject("btn_create.Image")));
            this.btn_create.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_create.Location = new System.Drawing.Point(26, 16);
            this.btn_create.Margin = new System.Windows.Forms.Padding(2);
            this.btn_create.Name = "btn_create";
            this.btn_create.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_create.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_create.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_create.OnHoverImage = null;
            this.btn_create.OnPressedColor = System.Drawing.Color.Black;
            this.btn_create.Size = new System.Drawing.Size(118, 50);
            this.btn_create.TabIndex = 0;
            this.btn_create.Text = "Create";
            this.btn_create.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // dtgProductos
            // 
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgProductos.Location = new System.Drawing.Point(0, 74);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.Size = new System.Drawing.Size(715, 414);
            this.dtgProductos.TabIndex = 2;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 488);
            this.Controls.Add(this.dtgProductos);
            this.Controls.Add(this.panel_crud);
            this.Controls.Add(this.CRUD_Producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Productos";
            this.Text = "Productos";
            this.CRUD_Producto.ResumeLayout(false);
            this.CRUD_Producto.PerformLayout();
            this.panel_ingresos.ResumeLayout(false);
            this.panel_ingresos.PerformLayout();
            this.panel_crud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel CRUD_Producto;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaLabel lbl_ID;
        private Guna.UI.WinForms.GunaPanel panel_ingresos;
        private Guna.UI.WinForms.GunaComboBox cb_estado;
        private Guna.UI.WinForms.GunaLabel lbl_Estado;
        private Guna.UI.WinForms.GunaTextBox txt_categoria;
        private Guna.UI.WinForms.GunaLabel lbl_categoria;
        private Guna.UI.WinForms.GunaTextBox txt_Fecha_vencimiento;
        private Guna.UI.WinForms.GunaLabel lbl_fecha_vencimiento;
        private Guna.UI.WinForms.GunaTextBox txt_stock;
        private Guna.UI.WinForms.GunaLabel lbl_stock;
        private Guna.UI.WinForms.GunaTextBox txt_codigo;
        private Guna.UI.WinForms.GunaLabel lbl_codigo;
        private Guna.UI.WinForms.GunaTextBox txt_product_name;
        private Guna.UI.WinForms.GunaLabel lbl_product_name;
        private Guna.UI.WinForms.GunaTextBox txt_id;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaPanel panel_crud;
        private Guna.UI.WinForms.GunaButton btn_create;
        private Guna.UI.WinForms.GunaButton btn_delete;
        private Guna.UI.WinForms.GunaButton btn_update;
        private Guna.UI.WinForms.GunaButton btn_Read;
        private System.Windows.Forms.DataGridView dtgProductos;
    }
}