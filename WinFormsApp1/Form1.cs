namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ClaseArticulos ObjArticulos = new ClaseArticulos();
        ClaseRubros ObjRubros = new ClaseRubros();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ValidarArchivos();
            ObjRubros.CargarCombo(cmbrubros);
        }

        private void ValidarArchivos()
        {
            if (!File.Exists(ObjRubros.NombreArchivo))
                MessageBox.Show(
                    "No se encontro el archivo " + ObjRubros.NombreArchivo + " en la carpeta de ejecucion.",
                    "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (!File.Exists(ObjArticulos.NombreArchivo))
                MessageBox.Show(
                    "No se encontro el archivo " + ObjArticulos.NombreArchivo + " en la carpeta de ejecucion.",
                    "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbrubros.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un rubro.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ObjArticulos.Listar(dataGridView1, cmbrubros.SelectedItem.ToString());
            label3.Text = ObjArticulos.CantidadListados.ToString();
            label4.Text = ObjArticulos.TotalValorStock.ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbrubros.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un rubro.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar. Presione 'Mostrar' primero.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog GuardarDialogo = new SaveFileDialog();
            GuardarDialogo.Filter = "Archivos CSV (*.csv)|*.csv";
            GuardarDialogo.FileName = "Articulos_" + cmbrubros.SelectedItem.ToString() + ".csv";
            GuardarDialogo.Title = "Exportar articulos";

            if (GuardarDialogo.ShowDialog() != DialogResult.OK) return;

            ObjArticulos.Exportar(GuardarDialogo.FileName, cmbrubros.SelectedItem.ToString());

            MessageBox.Show("Exportacion completada correctamente.", "Exito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}
