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
            lblCarrera.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblCarrera.Location = new Point(80, 50);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(153, 20);
            lblCarrera.TabIndex = 3;
            lblCarrera.Text = "Analista de Sistemas";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMateria.Location = new Point(80, 90);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(227, 20);
            lblMateria.TabIndex = 2;
            lblMateria.Text = "Laboratorio de Programacion 2";
            // 
            // lblInstancia
            // 
            lblInstancia.AutoSize = true;
            lblInstancia.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblInstancia.Location = new Point(80, 130);
            lblInstancia.Name = "lblInstancia";
            lblInstancia.Size = new Size(167, 20);
            lblInstancia.TabIndex = 1;
            lblInstancia.Text = "1º Instancia Evaluativa";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAlumno.Location = new Point(80, 170);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(429, 20);
            lblAlumno.TabIndex = 0;
            lblAlumno.Text = "DNI Alumno 43881903– Nombre Alumno Paloma Ottonello";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 270);
            Controls.Add(lblAlumno);
            Controls.Add(lblInstancia);
            Controls.Add(lblMateria);
            Controls.Add(lblCarrera);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Acerca de";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblCarrera;
        private Label lblMateria;
        private Label lblInstancia;
        private Label lblAlumno;
    }
}
