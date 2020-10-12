namespace Practica_Grupal1.Views
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Lista = new Guna.UI.WinForms.GunaPanel();
            this.btn_filtro = new Guna.UI.WinForms.GunaButton();
            this.gv_lista = new Guna.UI.WinForms.GunaDataGridView();
            this.panel_Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Lista
            // 
            this.panel_Lista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.panel_Lista.Controls.Add(this.btn_filtro);
            this.panel_Lista.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Lista.Location = new System.Drawing.Point(954, 0);
            this.panel_Lista.Name = "panel_Lista";
            this.panel_Lista.Size = new System.Drawing.Size(241, 600);
            this.panel_Lista.TabIndex = 6;
            // 
            // btn_filtro
            // 
            this.btn_filtro.AnimationHoverSpeed = 0.07F;
            this.btn_filtro.AnimationSpeed = 0.03F;
            this.btn_filtro.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btn_filtro.BorderColor = System.Drawing.Color.Black;
            this.btn_filtro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filtro.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_filtro.FocusedColor = System.Drawing.Color.Empty;
            this.btn_filtro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtro.ForeColor = System.Drawing.Color.Black;
            this.btn_filtro.Image = null;
            this.btn_filtro.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_filtro.Location = new System.Drawing.Point(3, 270);
            this.btn_filtro.Name = "btn_filtro";
            this.btn_filtro.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_filtro.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_filtro.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_filtro.OnHoverImage = null;
            this.btn_filtro.OnPressedColor = System.Drawing.Color.Black;
            this.btn_filtro.Size = new System.Drawing.Size(235, 58);
            this.btn_filtro.TabIndex = 2;
            this.btn_filtro.Text = "Filtrar";
            this.btn_filtro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gv_lista
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gv_lista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gv_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_lista.BackgroundColor = System.Drawing.Color.White;
            this.gv_lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_lista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_lista.DefaultCellStyle = dataGridViewCellStyle6;
            this.gv_lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_lista.EnableHeadersVisualStyles = false;
            this.gv_lista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_lista.Location = new System.Drawing.Point(0, 0);
            this.gv_lista.Name = "gv_lista";
            this.gv_lista.RowHeadersVisible = false;
            this.gv_lista.RowHeadersWidth = 51;
            this.gv_lista.RowTemplate.Height = 24;
            this.gv_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_lista.Size = new System.Drawing.Size(954, 600);
            this.gv_lista.TabIndex = 7;
            this.gv_lista.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gv_lista.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_lista.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gv_lista.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gv_lista.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gv_lista.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gv_lista.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gv_lista.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_lista.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gv_lista.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gv_lista.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gv_lista.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gv_lista.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_lista.ThemeStyle.HeaderStyle.Height = 4;
            this.gv_lista.ThemeStyle.ReadOnly = false;
            this.gv_lista.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gv_lista.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gv_lista.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gv_lista.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gv_lista.ThemeStyle.RowsStyle.Height = 24;
            this.gv_lista.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gv_lista.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 600);
            this.Controls.Add(this.gv_lista);
            this.Controls.Add(this.panel_Lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lista";
            this.Text = "Lista";
            this.panel_Lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel panel_Lista;
        private Guna.UI.WinForms.GunaButton btn_filtro;
        private Guna.UI.WinForms.GunaDataGridView gv_lista;
    }
}