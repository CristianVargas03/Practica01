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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.gv_categoria = new Guna.UI.WinForms.GunaDataGridView();
            this.Panel_ingreso_categoria.SuspendLayout();
            this.panel_crud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_categoria)).BeginInit();
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
            this.Panel_ingreso_categoria.Location = new System.Drawing.Point(954, 0);
            this.Panel_ingreso_categoria.Name = "Panel_ingreso_categoria";
            this.Panel_ingreso_categoria.Size = new System.Drawing.Size(241, 600);
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
            this.cb_estado_categoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_estado_categoria.ForeColor = System.Drawing.Color.Black;
            this.cb_estado_categoria.FormattingEnabled = true;
            this.cb_estado_categoria.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cb_estado_categoria.Location = new System.Drawing.Point(3, 192);
            this.cb_estado_categoria.Name = "cb_estado_categoria";
            this.cb_estado_categoria.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cb_estado_categoria.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cb_estado_categoria.Size = new System.Drawing.Size(226, 31);
            this.cb_estado_categoria.TabIndex = 13;
            // 
            // lbl_Estado_categoria
            // 
            this.lbl_Estado_categoria.AutoSize = true;
            this.lbl_Estado_categoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Estado_categoria.Location = new System.Drawing.Point(3, 169);
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
            this.txt_nombre_categoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nombre_categoria.Location = new System.Drawing.Point(3, 125);
            this.txt_nombre_categoria.Name = "txt_nombre_categoria";
            this.txt_nombre_categoria.PasswordChar = '\0';
            this.txt_nombre_categoria.Size = new System.Drawing.Size(226, 31);
            this.txt_nombre_categoria.TabIndex = 3;
            // 
            // lbl_nombre_categoria
            // 
            this.lbl_nombre_categoria.AutoSize = true;
            this.lbl_nombre_categoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_nombre_categoria.Location = new System.Drawing.Point(3, 102);
            this.lbl_nombre_categoria.Name = "lbl_nombre_categoria";
            this.lbl_nombre_categoria.Size = new System.Drawing.Size(64, 20);
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
            this.txt_id_categoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_id_categoria.Location = new System.Drawing.Point(3, 48);
            this.txt_id_categoria.Name = "txt_id_categoria";
            this.txt_id_categoria.PasswordChar = '\0';
            this.txt_id_categoria.Size = new System.Drawing.Size(226, 31);
            this.txt_id_categoria.TabIndex = 1;
            // 
            // lbl_id_categoria
            // 
            this.lbl_id_categoria.AutoSize = true;
            this.lbl_id_categoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_id_categoria.Location = new System.Drawing.Point(3, 25);
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
            this.panel_crud.Name = "panel_crud";
            this.panel_crud.Size = new System.Drawing.Size(954, 91);
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
            this.btn_delete_categoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_categoria.ForeColor = System.Drawing.Color.Black;
            this.btn_delete_categoria.Image = null;
            this.btn_delete_categoria.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_delete_categoria.Location = new System.Drawing.Point(718, 28);
            this.btn_delete_categoria.Name = "btn_delete_categoria";
            this.btn_delete_categoria.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_delete_categoria.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_delete_categoria.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_delete_categoria.OnHoverImage = null;
            this.btn_delete_categoria.OnPressedColor = System.Drawing.Color.Black;
            this.btn_delete_categoria.Size = new System.Drawing.Size(160, 42);
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
            this.btn_update_categoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_categoria.ForeColor = System.Drawing.Color.Black;
            this.btn_update_categoria.Image = null;
            this.btn_update_categoria.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_update_categoria.Location = new System.Drawing.Point(491, 28);
            this.btn_update_categoria.Name = "btn_update_categoria";
            this.btn_update_categoria.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_update_categoria.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_update_categoria.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_update_categoria.OnHoverImage = null;
            this.btn_update_categoria.OnPressedColor = System.Drawing.Color.Black;
            this.btn_update_categoria.Size = new System.Drawing.Size(160, 42);
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
            this.btn_Read_categoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Read_categoria.ForeColor = System.Drawing.Color.Black;
            this.btn_Read_categoria.Image = null;
            this.btn_Read_categoria.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Read_categoria.Location = new System.Drawing.Point(268, 28);
            this.btn_Read_categoria.Name = "btn_Read_categoria";
            this.btn_Read_categoria.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Read_categoria.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Read_categoria.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Read_categoria.OnHoverImage = null;
            this.btn_Read_categoria.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Read_categoria.Size = new System.Drawing.Size(160, 42);
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
            this.btn_create_categoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_categoria.ForeColor = System.Drawing.Color.Black;
            this.btn_create_categoria.Image = null;
            this.btn_create_categoria.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_create_categoria.Location = new System.Drawing.Point(49, 28);
            this.btn_create_categoria.Name = "btn_create_categoria";
            this.btn_create_categoria.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_create_categoria.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_create_categoria.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_create_categoria.OnHoverImage = null;
            this.btn_create_categoria.OnPressedColor = System.Drawing.Color.Black;
            this.btn_create_categoria.Size = new System.Drawing.Size(160, 42);
            this.btn_create_categoria.TabIndex = 0;
            this.btn_create_categoria.Text = "Create";
            this.btn_create_categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gv_categoria
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gv_categoria.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gv_categoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_categoria.BackgroundColor = System.Drawing.Color.White;
            this.gv_categoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_categoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_categoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_categoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gv_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_categoria.DefaultCellStyle = dataGridViewCellStyle6;
            this.gv_categoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_categoria.EnableHeadersVisualStyles = false;
            this.gv_categoria.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_categoria.Location = new System.Drawing.Point(0, 91);
            this.gv_categoria.Name = "gv_categoria";
            this.gv_categoria.RowHeadersVisible = false;
            this.gv_categoria.RowHeadersWidth = 51;
            this.gv_categoria.RowTemplate.Height = 24;
            this.gv_categoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_categoria.Size = new System.Drawing.Size(954, 509);
            this.gv_categoria.TabIndex = 7;
            this.gv_categoria.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gv_categoria.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_categoria.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gv_categoria.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gv_categoria.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gv_categoria.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gv_categoria.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gv_categoria.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_categoria.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gv_categoria.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gv_categoria.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gv_categoria.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gv_categoria.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_categoria.ThemeStyle.HeaderStyle.Height = 4;
            this.gv_categoria.ThemeStyle.ReadOnly = false;
            this.gv_categoria.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_categoria.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_categoria.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gv_categoria.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_categoria.ThemeStyle.RowsStyle.Height = 24;
            this.gv_categoria.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_categoria.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 600);
            this.Controls.Add(this.gv_categoria);
            this.Controls.Add(this.panel_crud);
            this.Controls.Add(this.Panel_ingreso_categoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categorias";
            this.Text = "Categorias";
            this.Panel_ingreso_categoria.ResumeLayout(false);
            this.Panel_ingreso_categoria.PerformLayout();
            this.panel_crud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_categoria)).EndInit();
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
        private Guna.UI.WinForms.GunaDataGridView gv_categoria;
    }
}