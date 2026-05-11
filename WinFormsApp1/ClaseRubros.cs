namespace WinFormsApp1
{
    public class ClaseRubros
    {
        public string NombreArchivo = "RUBROS.CSV";

        public struct RegRubros
        {
            public string Nombre;
        }

        public void CargarCombo(ComboBox Combo)
        {
            string DatosLeidos;

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            Combo.Items.Clear();

            while (DatosLeidos != null)
            {
                Combo.Items.Add(DatosLeidos.Trim());
                DatosLeidos = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();
        }
    }
}
