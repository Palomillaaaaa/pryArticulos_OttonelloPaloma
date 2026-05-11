namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvGrilla = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colCosto = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colValorStock = new DataGridViewTextBoxColumn();
            grbConsultar = new GroupBox();
            lnkAcercaDe = new LinkLabel();
            grbListado = new GroupBox();
            btnExportar = new Button();
            btnMostrar = new Button();
            lblTotalValor = new Label();
            lblCantidadValor = new Label();
            lblCantidadTitulo = new Label();
            lblTotalTitulo = new Label();
            cmbRubros = new ComboBox();
            lblRubros = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).BeginInit();
            grbConsultar.SuspendLayout();
            grbListado.SuspendLayout();
            SuspendLayout();
            // 
            // dgvGrilla
            // 
            dgvGrilla.AllowUserToAddRows = false;
            dgvGrilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrilla.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colDescripcion, colCosto, colStock, colValorStock });
            dgvGrilla.Location = new Point(17, 32);
            dgvGrilla.Margin = new Padding(4, 5, 4, 5);
            dgvGrilla.Name = "dgvGrilla";
            dgvGrilla.ReadOnly = true;
            dgvGrilla.RowHeadersWidth = 62;
            dgvGrilla.Size = new Size(721, 319);
            dgvGrilla.TabIndex = 0;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Codigo";
            colCodigo.MinimumWidth = 8;
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            colCodigo.Width = 110;
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripcion";
            colDescripcion.MinimumWidth = 8;
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            colDescripcion.Width = 220;
            // 
            // colCosto
            // 
            colCosto.HeaderText = "Costo";
            colCosto.MinimumWidth = 8;
            colCosto.Name = "colCosto";
            colCosto.ReadOnly = true;
            colCosto.Width = 80;
            // 
            // colStock
            // 
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 8;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            colStock.Width = 60;
            // 
            // colValorStock
            // 
            colValorStock.HeaderText = "Valor de Stock";
            colValorStock.MinimumWidth = 8;
            colValorStock.Name = "colValorStock";
            colValorStock.ReadOnly = true;
            colValorStock.Width = 150;
            // 
            // grbConsultar
            // 
            grbConsultar.Controls.Add(lnkAcercaDe);
            grbConsultar.Controls.Add(grbListado);
            grbConsultar.Controls.Add(btnExportar);
            grbConsultar.Controls.Add(btnMostrar);
            grbConsultar.Controls.Add(lblTotalValor);
            grbConsultar.Controls.Add(lblCantidadValor);
            grbConsultar.Controls.Add(lblCantidadTitulo);
            grbConsultar.Controls.Add(lblTotalTitulo);
            grbConsultar.Controls.Add(cmbRubros);
            grbConsultar.Controls.Add(lblRubros);
            grbConsultar.Location = new Point(127, 130);
            grbConsultar.Margin = new Padding(4, 5, 4, 5);
            grbConsultar.Name = "grbConsultar";
            grbConsultar.Padding = new Padding(4, 5, 4, 5);
            grbConsultar.Size = new Size(940, 597);
            grbConsultar.TabIndex = 1;
            grbConsultar.TabStop = false;
            grbConsultar.Text = "Consultar Articulos";
            grbConsultar.Enter += grbConsultar_Enter;
            // 
            // lnkAcercaDe
            // 
            lnkAcercaDe.AutoSize = true;
            lnkAcercaDe.Location = new Point(660, 511);
            lnkAcercaDe.Margin = new Padding(4, 0, 4, 0);
            lnkAcercaDe.Name = "lnkAcercaDe";
            lnkAcercaDe.Size = new Size(235, 25);
            lnkAcercaDe.TabIndex = 10;
            lnkAcercaDe.TabStop = true;
            lnkAcercaDe.Text = "Ver Información del Alumno";
            lnkAcercaDe.LinkClicked += lnkAcercaDe_LinkClicked;
            // 
            // grbListado
            // 
            grbListado.Controls.Add(dgvGrilla);
            grbListado.Location = new Point(29, 112);
            grbListado.Name = "grbListado";
            grbListado.Size = new Size(863, 381);
            grbListado.TabIndex = 10;
            grbListado.TabStop = false;
            grbListado.Text = "Listado de Articulos";
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(727, 37);
            btnExportar.Margin = new Padding(4, 5, 4, 5);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(165, 38);
            btnExportar.TabIndex = 9;
            btnExportar.Text = "Exportar a CSV";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(535, 37);
            btnMostrar.Margin = new Padding(4, 5, 4, 5);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(171, 38);
            btnMostrar.TabIndex = 8;
            btnMostrar.Text = "Mostrar Archivos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblTotalValor
            // 
            lblTotalValor.AutoSize = true;
            lblTotalValor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalValor.Location = new Point(430, 546);
            lblTotalValor.Margin = new Padding(4, 0, 4, 0);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(32, 38);
            lblTotalValor.TabIndex = 7;
            lblTotalValor.Text = "0";
            // 
            // lblCantidadValor
            // 
            lblCantidadValor.AutoSize = true;
            lblCantidadValor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidadValor.Location = new Point(141, 546);
            lblCantidadValor.Margin = new Padding(4, 0, 4, 0);
            lblCantidadValor.Name = "lblCantidadValor";
            lblCantidadValor.Size = new Size(32, 38);
            lblCantidadValor.TabIndex = 6;
            lblCantidadValor.Text = "0";
            // 
            // lblCantidadTitulo
            // 
            lblCantidadTitulo.AutoSize = true;
            lblCantidadTitulo.Location = new Point(29, 511);
            lblCantidadTitulo.Margin = new Padding(4, 0, 4, 0);
            lblCantidadTitulo.Name = "lblCantidadTitulo";
            lblCantidadTitulo.Size = new Size(249, 25);
            lblCantidadTitulo.TabIndex = 5;
            lblCantidadTitulo.Text = "Cantidad de articulos listados:";
            // 
            // lblTotalTitulo
            // 
            lblTotalTitulo.AutoSize = true;
            lblTotalTitulo.Location = new Point(387, 511);
            lblTotalTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTotalTitulo.Name = "lblTotalTitulo";
            lblTotalTitulo.Size = new Size(146, 25);
            lblTotalTitulo.TabIndex = 4;
            lblTotalTitulo.Text = "Total Valor Stock:";
            // 
            // cmbRubros
            // 
            cmbRubros.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRubros.FormattingEnabled = true;
            cmbRubros.Location = new Point(259, 41);
            cmbRubros.Margin = new Padding(4, 5, 4, 5);
            cmbRubros.Name = "cmbRubros";
            cmbRubros.Size = new Size(223, 33);
            cmbRubros.TabIndex = 3;
            // 
            // lblRubros
            // 
            lblRubros.AutoSize = true;
            lblRubros.Location = new Point(74, 44);
            lblRubros.Margin = new Padding(4, 0, 4, 0);
            lblRubros.Name = "lblRubros";
            lblRubros.Size = new Size(177, 25);
            lblRubros.TabIndex = 2;
            lblRubros.Text = "Seleccione un Rubro:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 938);
            Controls.Add(grbConsultar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Gestion de Articulos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).EndInit();
            grbConsultar.ResumeLayout(false);
            grbConsultar.PerformLayout();
            grbListado.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGrilla;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colCosto;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colValorStock;
        private GroupBox grbConsultar;
        private Label lblRubros;
        private Button btnExportar;
        private Button btnMostrar;
        private Label lblTotalValor;
        private Label lblCantidadValor;
        private Label lblCantidadTitulo;
        private Label lblTotalTitulo;
        private ComboBox cmbRubros;
        private LinkLabel lnkAcercaDe;
        private GroupBox grbListado;
    }
}
