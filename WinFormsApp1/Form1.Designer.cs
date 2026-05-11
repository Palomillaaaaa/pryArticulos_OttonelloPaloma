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
            grbConsultar = new GroupBox();
            colCodigo = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colCosto = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colValorStock = new DataGridViewTextBoxColumn();
            lblRubros = new Label();
            cmbRubros = new ComboBox();
            lblTotalTitulo = new Label();
            lblCantidadTitulo = new Label();
            lblCantidadValor = new Label();
            lblTotalValor = new Label();
            btnMostrar = new Button();
            btnExportar = new Button();
            lnkAcercaDe = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).BeginInit();
            grbConsultar.SuspendLayout();
            SuspendLayout();
            //
            // dgvGrilla
            //
            dgvGrilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrilla.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colDescripcion, colCosto, colStock, colValorStock });
            dgvGrilla.Location = new Point(31, 22);
            dgvGrilla.Name = "dgvGrilla";
            dgvGrilla.Size = new Size(647, 236);
            dgvGrilla.TabIndex = 0;
            dgvGrilla.ReadOnly = true;
            dgvGrilla.AllowUserToAddRows = false;
            //
            // grbConsultar
            //
            grbConsultar.Controls.Add(btnExportar);
            grbConsultar.Controls.Add(btnMostrar);
            grbConsultar.Controls.Add(lblTotalValor);
            grbConsultar.Controls.Add(lblCantidadValor);
            grbConsultar.Controls.Add(lblCantidadTitulo);
            grbConsultar.Controls.Add(lblTotalTitulo);
            grbConsultar.Controls.Add(cmbRubros);
            grbConsultar.Controls.Add(lblRubros);
            grbConsultar.Controls.Add(dgvGrilla);
            grbConsultar.Location = new Point(89, 78);
            grbConsultar.Name = "grbConsultar";
            grbConsultar.Size = new Size(709, 422);
            grbConsultar.TabIndex = 1;
            grbConsultar.TabStop = false;
            grbConsultar.Text = "Consultar Articulos";
            //
            // colCodigo
            //
            colCodigo.HeaderText = "Codigo";
            colCodigo.Name = "colCodigo";
            colCodigo.Width = 110;
            //
            // colDescripcion
            //
            colDescripcion.HeaderText = "Descripcion";
            colDescripcion.Name = "colDescripcion";
            colDescripcion.Width = 220;
            //
            // colCosto
            //
            colCosto.HeaderText = "Costo";
            colCosto.Name = "colCosto";
            colCosto.Width = 80;
            //
            // colStock
            //
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            colStock.Width = 60;
            //
            // colValorStock
            //
            colValorStock.HeaderText = "Valor de Stock";
            colValorStock.Name = "colValorStock";
            colValorStock.Width = 100;
            //
            // lblRubros
            //
            lblRubros.AutoSize = true;
            lblRubros.Location = new Point(31, 287);
            lblRubros.Name = "lblRubros";
            lblRubros.Size = new Size(41, 15);
            lblRubros.TabIndex = 2;
            lblRubros.Text = "Rubros:";
            //
            // cmbRubros
            //
            cmbRubros.FormattingEnabled = true;
            cmbRubros.Location = new Point(31, 305);
            cmbRubros.Name = "cmbRubros";
            cmbRubros.Size = new Size(121, 23);
            cmbRubros.TabIndex = 3;
            //
            // lblTotalTitulo
            //
            lblTotalTitulo.AutoSize = true;
            lblTotalTitulo.Location = new Point(234, 343);
            lblTotalTitulo.Name = "lblTotalTitulo";
            lblTotalTitulo.Size = new Size(32, 15);
            lblTotalTitulo.TabIndex = 4;
            lblTotalTitulo.Text = "Total:";
            //
            // lblCantidadTitulo
            //
            lblCantidadTitulo.AutoSize = true;
            lblCantidadTitulo.Location = new Point(234, 313);
            lblCantidadTitulo.Name = "lblCantidadTitulo";
            lblCantidadTitulo.Size = new Size(119, 15);
            lblCantidadTitulo.TabIndex = 5;
            lblCantidadTitulo.Text = "Cantidad de articulos:";
            //
            // lblCantidadValor
            //
            lblCantidadValor.AutoSize = true;
            lblCantidadValor.Location = new Point(359, 311);
            lblCantidadValor.Name = "lblCantidadValor";
            lblCantidadValor.Size = new Size(38, 15);
            lblCantidadValor.TabIndex = 6;
            lblCantidadValor.Text = "0";
            //
            // lblTotalValor
            //
            lblTotalValor.AutoSize = true;
            lblTotalValor.Location = new Point(359, 344);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(38, 15);
            lblTotalValor.TabIndex = 7;
            lblTotalValor.Text = "0";
            //
            // btnMostrar
            //
            btnMostrar.Location = new Point(512, 310);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 8;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            //
            // btnExportar
            //
            btnExportar.Location = new Point(514, 344);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(75, 23);
            btnExportar.TabIndex = 9;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            //
            // lnkAcercaDe
            //
            lnkAcercaDe.AutoSize = true;
            lnkAcercaDe.Location = new Point(375, 520);
            lnkAcercaDe.Name = "lnkAcercaDe";
            lnkAcercaDe.TabIndex = 10;
            lnkAcercaDe.TabStop = true;
            lnkAcercaDe.Text = "Acerca de";
            lnkAcercaDe.LinkClicked += lnkAcercaDe_LinkClicked;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 563);
            Controls.Add(lnkAcercaDe);
            Controls.Add(grbConsultar);
            Name = "Form1";
            Text = "Gestion de Articulos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGrilla).EndInit();
            grbConsultar.ResumeLayout(false);
            grbConsultar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
