namespace WinFormsApp1
{
    partial class Form2
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

        private void InitializeComponent()
        {
            lblCarrera = new Label();
            lblMateria = new Label();
            lblInstancia = new Label();
            lblAlumno = new Label();
            SuspendLayout();
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Bold);
            lblCarrera.Location = new Point(114, 83);
            lblCarrera.Margin = new Padding(4, 0, 4, 0);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(331, 45);
            lblCarrera.TabIndex = 3;
            lblCarrera.Text = "Analista de Sistemas";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Bold);
            lblMateria.Location = new Point(114, 150);
            lblMateria.Margin = new Padding(4, 0, 4, 0);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(493, 45);
            lblMateria.TabIndex = 2;
            lblMateria.Text = "Laboratorio de Programacion II";
            // 
            // lblInstancia
            // 
            lblInstancia.AutoSize = true;
            lblInstancia.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Bold);
            lblInstancia.Location = new Point(114, 217);
            lblInstancia.Margin = new Padding(4, 0, 4, 0);
            lblInstancia.Name = "lblInstancia";
            lblInstancia.Size = new Size(356, 45);
            lblInstancia.TabIndex = 1;
            lblInstancia.Text = "1º Instancia Evaluativa";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Font = new Font("Segoe UI Symbol", 16F, FontStyle.Bold);
            lblAlumno.Location = new Point(114, 283);
            lblAlumno.Margin = new Padding(4, 0, 4, 0);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(946, 45);
            lblAlumno.TabIndex = 0;
            lblAlumno.Text = "DNI Alumno: 43.881.903– Nombre Alumno: Paloma Ottonello";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 373);
            Controls.Add(lblAlumno);
            Controls.Add(lblInstancia);
            Controls.Add(lblMateria);
            Controls.Add(lblCarrera);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Acerca de";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblCarrera;
        private Label lblMateria;
        private Label lblInstancia;
        private Label lblAlumno;
    }
}
