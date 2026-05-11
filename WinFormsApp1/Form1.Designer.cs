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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            Codigo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            ValorStock = new DataGridViewTextBoxColumn();
            label1 = new Label();
            cmbrubros = new ComboBox();
            lblcantidadArticulos = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            //
            // dataGridView1
            //
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descripcion, Costo, Stock, ValorStock });
            dataGridView1.Location = new Point(31, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(647, 236);
            dataGridView1.TabIndex = 0;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            //
            // groupBox1
            //
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblcantidadArticulos);
            groupBox1.Controls.Add(cmbrubros);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(89, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(709, 422);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ver Articulo";
            //
            // Codigo
            //
            Codigo.HeaderText = "Codigo";
            Codigo.Name = "Codigo";
            Codigo.Width = 110;
            //
            // Descripcion
            //
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.Width = 220;
            //
            // Costo
            //
            Costo.HeaderText = "Costo";
            Costo.Name = "Costo";
            Costo.Width = 80;
            //
            // Stock
            //
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.Width = 60;
            //
            // ValorStock
            //
            ValorStock.HeaderText = "Valor de Stock";
            ValorStock.Name = "ValorStock";
            ValorStock.Width = 100;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(31, 287);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Rubros:";
            label1.Click += label1_Click;
            //
            // cmbrubros
            //
            cmbrubros.FormattingEnabled = true;
            cmbrubros.Location = new Point(31, 305);
            cmbrubros.Name = "cmbrubros";
            cmbrubros.Size = new Size(121, 23);
            cmbrubros.TabIndex = 3;
            //
            // lblcantidadArticulos
            //
            lblcantidadArticulos.AutoSize = true;
            lblcantidadArticulos.Location = new Point(234, 343);
            lblcantidadArticulos.Name = "lblcantidadArticulos";
            lblcantidadArticulos.Size = new Size(32, 15);
            lblcantidadArticulos.TabIndex = 4;
            lblcantidadArticulos.Text = "Total:";
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(234, 313);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 5;
            label2.Text = "Cantidad de articulos:";
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(359, 311);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "0";
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Location = new Point(359, 344);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "0";
            //
            // button1
            //
            button1.Location = new Point(512, 310);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Mostrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            //
            // button2
            //
            button2.Location = new Point(514, 344);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Exportar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            //
            // linkLabel1
            //
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(375, 520);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Acerca de";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 563);
            Controls.Add(linkLabel1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Gestion de Articulos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn ValorStock;
        private GroupBox groupBox1;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblcantidadArticulos;
        private ComboBox cmbrubros;
        private LinkLabel linkLabel1;
    }
}
