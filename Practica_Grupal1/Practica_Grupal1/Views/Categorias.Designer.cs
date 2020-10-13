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
            this.Panel_ingreso_categoria = new Guna.UI.WinForms.GunaPanel();
            this.cb_estado_categoria = new Guna.UI.WinForms.GunaComboBox();
            this.lbl_Estado_categoria = new Guna.UI.WinForms.GunaLabel();
            this.txt_nombre_categoria = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_nombre_categoria = new Guna.UI.WinForms.GunaLabel();
            this.txt_id_categoria = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_id_categoria = new Guna.UI.WinForms.GunaLabel();
            this.panel_crud = new Guna.UI.WinForms.GunaPanel();
            this.btn_delete_categoria = new Guna.UI.WinForms.GunaButton();
            this.btn_update_categoria = new Guna.UI.WinForms.GunaButton();
            this.btn_Read_categoria = new Guna.UI.WinForms.GunaButton();
            this.btn_create_categoria = new Guna.UI.WinForms.GunaButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.panel_crud.Controls.Add(this.btn_delete_categoria);
            this.panel_crud.Controls.Add(this.btn_update_categoria);
            this.panel_crud.Controls.Add(this.btn_Read_categoria);
            this.panel_crud.Controls.Add(this.btn_create_categoria);
            this.panel_crud.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_crud.Location = new System.Drawing.Point(0, 0);
            this.panel_crud.Margin = new System.Windows.Forms.Padding(2);
            this.panel_crud.Name = "panel_crud";
            this.panel_crud.Size = new System.Drawing.Size(715, 74);
            this.panel_crud.TabIndex = 6;
            // 
            // btn_delete_categoria
            // 
            this.btn_delete_categoria.AnimationHoverSpeed = 0.07F;
            this.btn_delete_categoria.AnimationSpeed = 0.03F;
            this.btn_delete_categoria.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_delete_categoria.BorderColor = System.Drawing.Color.Black;
            this.btn_delete_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_categoria.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_delete_categoria.FocusedColor = System.Drawing.Color.Empty;
            this.btn_delete_categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_categoria.ForeColor = System.Drawing.Color.Black;
            this.btn_delete_categoria.Image = null;
            this.btn_delete_categoria.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_delete_categoria.Location = new System.Drawing.Point(474, 31);
            this.btn_delete_categoria.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete_categoria.Name = "btn_delete_categoria";
            this.btn_delete_categoria.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_delete_categoria.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_delete_categoria.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_delete_categoria.OnHoverImage = null;
            this.btn_delete_categoria.OnPressedColor = System.Drawing.Color.Black;
            this.btn_delete_categoria.Size = new System.Drawing.Size(120, 34);
            this.btn_delete_categoria.TabIndex = 3;
            this.btn_delete_categoria.Text = "Delete";
            this.btn_delete_categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_update_categoria
            // 
            this.btn_update_categoria.AnimationHoverSpeed = 0.07F;
            this.btn_update_categoria.AnimationSpeed = 0.03F;
            this.btn_update_categoria.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_update_categoria.BorderColor = System.Drawing.Color.Black;
            this.btn_update_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update_categoria.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_update_categoria.FocusedColor = System.Drawing.Color.Empty;
            this.btn_update_categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_categoria.ForeColor = System.Drawing.Color.Black;
            this.btn_update_categoria.Image = null;
            this.btn_update_categoria.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_update_categoria.Location = new System.Drawing.Point(350, 31);
            this.btn_update_categoria.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update_categoria.Name = "btn_update_categoria";
            this.btn_update_categoria.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_update_categoria.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_update_categoria.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_update_categoria.OnHoverImage = null;
            this.btn_update_categoria.OnPressedColor = System.Drawing.Color.Black;
            this.btn_update_categoria.Size = new System.Drawing.Size(120, 34);
            this.btn_update_categoria.TabIndex = 2;
            this.btn_update_categoria.Text = "Update";
            this.btn_update_categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Read_categoria
            // 
            this.btn_Read_categoria.AnimationHoverSpeed = 0.07F;
            this.btn_Read_categoria.AnimationSpeed = 0.03F;
            this.btn_Read_categoria.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_Read_categoria.BorderColor = System.Drawing.Color.Black;
            this.btn_Read_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Read_categoria.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Read_categoria.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Read_categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Read_categoria.ForeColor = System.Drawing.Color.Black;
            this.btn_Read_categoria.Image = null;
            this.btn_Read_categoria.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Read_categoria.Location = new System.Drawing.Point(226, 31);
            this.btn_Read_categoria.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Read_categoria.Name = "btn_Read_categoria";
            this.btn_Read_categoria.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Read_categoria.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Read_categoria.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Read_categoria.OnHoverImage = null;
            this.btn_Read_categoria.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Read_categoria.Size = new System.Drawing.Size(120, 34);
            this.btn_Read_categoria.TabIndex = 1;
            this.btn_Read_categoria.Text = "Read";
            this.btn_Read_categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_create_categoria
            // 
            this.btn_create_categoria.AnimationHoverSpeed = 0.07F;
            this.btn_create_categoria.AnimationSpeed = 0.03F;
            this.btn_create_categoria.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_create_categoria.BorderColor = System.Drawing.Color.Black;
            this.btn_create_categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create_categoria.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_create_categoria.FocusedColor = System.Drawing.Color.Empty;
            this.btn_create_categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_categoria.ForeColor = System.Drawing.Color.Black;
            this.btn_create_categoria.Image = null;
            this.btn_create_categoria.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_create_categoria.Location = new System.Drawing.Point(102, 31);
            this.btn_create_categoria.Margin = new System.Windows.Forms.Padding(2);
            this.btn_create_categoria.Name = "btn_create_categoria";
            this.btn_create_categoria.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_create_categoria.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_create_categoria.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_create_categoria.OnHoverImage = null;
            this.btn_create_categoria.OnPressedColor = System.Drawing.Color.Black;
            this.btn_create_categoria.Size = new System.Drawing.Size(120, 34);
            this.btn_create_categoria.TabIndex = 0;
            this.btn_create_categoria.Text = "Create";
            this.btn_create_categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(692, 412);
            this.dataGridView1.TabIndex = 7;
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
        private Guna.UI.WinForms.GunaButton btn_delete_categoria;
        private Guna.UI.WinForms.GunaButton btn_update_categoria;
        private Guna.UI.WinForms.GunaButton btn_Read_categoria;
        private Guna.UI.WinForms.GunaButton btn_create_categoria;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}