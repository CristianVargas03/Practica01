namespace Practica_Grupal1.Views
{
    partial class Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias));
            this.Panel_ingreso_categoria = new Guna.UI.WinForms.GunaPanel();
            this.cb_estado_categoria = new Guna.UI.WinForms.GunaComboBox();
            this.lbl_Estado_categoria = new Guna.UI.WinForms.GunaLabel();
            this.txt_nombre_categoria = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_nombre_categoria = new Guna.UI.WinForms.GunaLabel();
            this.txt_id_categoria = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_id_categoria = new Guna.UI.WinForms.GunaLabel();
            this.panel_crud = new Guna.UI.WinForms.GunaPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_delete = new Guna.UI.WinForms.GunaButton();
            this.btn_update = new Guna.UI.WinForms.GunaButton();
            this.btn_Read = new Guna.UI.WinForms.GunaButton();
            this.btn_create = new Guna.UI.WinForms.GunaButton();
            this.Panel_ingreso_categoria.SuspendLayout();
            this.panel_crud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_ingreso_categoria
            // 
            this.Panel_ingreso_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.Panel_ingreso_categoria.Controls.Add(this.cb_estado_categoria);
            this.Panel_ingreso_categoria.Controls.Add(this.lbl_Estado_categoria);
            this.Panel_ingreso_categoria.Controls.Add(this.txt_nombre_categoria);
            this.Panel_ingreso_categoria.Controls.Add(this.lbl_nombre_categoria);
            this.Panel_ingreso_categoria.Controls.Add(this.txt_id_categoria);
            this.Panel_ingreso_categoria.Controls.Add(this.lbl_id_categoria);
            this.Panel_ingreso_categoria.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_ingreso_categoria.Location = new System.Drawing.Point(715, 0);
            this.Panel_ingreso_categoria.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_ingreso_categoria.Name = "Panel_ingreso_categoria";
            this.Panel_ingreso_categoria.Size = new System.Drawing.Size(181, 488);
            this.Panel_ingreso_categoria.TabIndex = 5;
            // 
            // cb_estado_categoria
            // 
            this.cb_estado_categoria.BackColor = System.Drawing.Color.Transparent;
            this.cb_estado_categoria.BaseColor = System.Drawing.Color.White;
            this.cb_estado_categoria.BorderColor = System.Drawing.Color.Silver;
            this.cb_estado_categoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_estado_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estado_categoria.FocusedColor = System.Drawing.Color.Empty;
            this.cb_estado_categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estado_categoria.ForeColor = System.Drawing.Color.Black;
            this.cb_estado_categoria.FormattingEnabled = true;
            this.cb_estado_categoria.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cb_estado_categoria.Location = new System.Drawing.Point(4, 213);
            this.cb_estado_categoria.Margin = new System.Windows.Forms.Padding(2);
            this.cb_estado_categoria.Name = "cb_estado_categoria";
            this.cb_estado_categoria.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cb_estado_categoria.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_estado_categoria.Size = new System.Drawing.Size(170, 28);
            this.cb_estado_categoria.TabIndex = 13;
            // 
            // lbl_Estado_categoria
            // 
            this.lbl_Estado_categoria.AutoSize = true;
            this.lbl_Estado_categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado_categoria.Location = new System.Drawing.Point(4, 194);
            this.lbl_Estado_categoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Estado_categoria.Name = "lbl_Estado_categoria";
            this.lbl_Estado_categoria.Size = new System.Drawing.Size(54, 20);
            this.lbl_Estado_categoria.TabIndex = 12;
            this.lbl_Estado_categoria.Text = "Estado";
            // 
            // txt_nombre_categoria
            // 
            this.txt_nombre_categoria.BaseColor = System.Drawing.Color.White;
            this.txt_nombre_categoria.BorderColor = System.Drawing.Color.Silver;
            this.txt_nombre_categoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre_categoria.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_nombre_categoria.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_nombre_categoria.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_nombre_categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_categoria.Location = new System.Drawing.Point(4, 139);
            this.txt_nombre_categoria.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre_categoria.Name = "txt_nombre_categoria";
            this.txt_nombre_categoria.PasswordChar = '\0';
            this.txt_nombre_categoria.Size = new System.Drawing.Size(170, 30);
            this.txt_nombre_categoria.TabIndex = 3;
            // 
            // lbl_nombre_categoria
            // 
            this.lbl_nombre_categoria.AutoSize = true;
            this.lbl_nombre_categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_categoria.Location = new System.Drawing.Point(4, 120);
            this.lbl_nombre_categoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre_categoria.Name = "lbl_nombre_categoria";
            this.lbl_nombre_categoria.Size = new System.Drawing.Size(66, 20);
            this.lbl_nombre_categoria.TabIndex = 2;
            this.lbl_nombre_categoria.Text = "Nombre";
            // 
            // txt_id_categoria
            // 
            this.txt_id_categoria.BaseColor = System.Drawing.Color.White;
            this.txt_id_categoria.BorderColor = System.Drawing.Color.Silver;
            this.txt_id_categoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id_categoria.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_id_categoria.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_id_categoria.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_id_categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_categoria.Location = new System.Drawing.Point(4, 74);
            this.txt_id_categoria.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id_categoria.Name = "txt_id_categoria";
            this.txt_id_categoria.PasswordChar = '\0';
            this.txt_id_categoria.Size = new System.Drawing.Size(170, 30);
            this.txt_id_categoria.TabIndex = 1;
            // 
            // lbl_id_categoria
            // 
            this.lbl_id_categoria.AutoSize = true;
            this.lbl_id_categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_categoria.Location = new System.Drawing.Point(4, 55);
            this.lbl_id_categoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_id_categoria.Name = "lbl_id_categoria";
            this.lbl_id_categoria.Size = new System.Drawing.Size(24, 20);
            this.lbl_id_categoria.TabIndex = 0;
            this.lbl_id_categoria.Text = "ID";
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
            this.panel_crud.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(715, 414);
            this.dataGridView1.TabIndex = 7;
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
            this.btn_delete.Location = new System.Drawing.Point(561, 12);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_delete.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_delete.OnHoverImage = null;
            this.btn_delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_delete.Size = new System.Drawing.Size(125, 50);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.btn_update.Location = new System.Drawing.Point(381, 12);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update.Name = "btn_update";
            this.btn_update.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_update.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_update.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_update.OnHoverImage = null;
            this.btn_update.OnPressedColor = System.Drawing.Color.Black;
            this.btn_update.Size = new System.Drawing.Size(125, 50);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "Update";
            this.btn_update.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.btn_Read.Location = new System.Drawing.Point(187, 12);
            this.btn_Read.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Read.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Read.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Read.OnHoverImage = null;
            this.btn_Read.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Read.Size = new System.Drawing.Size(125, 50);
            this.btn_Read.TabIndex = 5;
            this.btn_Read.Text = "Read";
            this.btn_Read.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.btn_create.Location = new System.Drawing.Point(28, 12);
            this.btn_create.Margin = new System.Windows.Forms.Padding(2);
            this.btn_create.Name = "btn_create";
            this.btn_create.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_create.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_create.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_create.OnHoverImage = null;
            this.btn_create.OnPressedColor = System.Drawing.Color.Black;
            this.btn_create.Size = new System.Drawing.Size(118, 50);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "Create";
            this.btn_create.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 488);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_crud);
            this.Controls.Add(this.Panel_ingreso_categoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Categorias";
            this.Text = "Categorias";
            this.Panel_ingreso_categoria.ResumeLayout(false);
            this.Panel_ingreso_categoria.PerformLayout();
            this.panel_crud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel Panel_ingreso_categoria;
        private Guna.UI.WinForms.GunaComboBox cb_estado_categoria;
        private Guna.UI.WinForms.GunaLabel lbl_Estado_categoria;
        private Guna.UI.WinForms.GunaTextBox txt_nombre_categoria;
        private Guna.UI.WinForms.GunaLabel lbl_nombre_categoria;
        private Guna.UI.WinForms.GunaTextBox txt_id_categoria;
        private Guna.UI.WinForms.GunaLabel lbl_id_categoria;
        private Guna.UI.WinForms.GunaPanel panel_crud;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaButton btn_delete;
        private Guna.UI.WinForms.GunaButton btn_update;
        private Guna.UI.WinForms.GunaButton btn_Read;
        private Guna.UI.WinForms.GunaButton btn_create;
    }
}