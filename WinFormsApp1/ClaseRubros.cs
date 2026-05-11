namespace WinFormsApp1
{
    public class ClaseRubros
    {
        public string NombreArchivo = "RUBROS.CSV";

        public struct RegRubros
        {
            public string Nombre;
        }

        //metodo del combo box para que se llamen los elementos dentro del csv
        public void CargarCombo(ComboBox Combo)
        {
            string DatosLeidos;
            //abro

            StreamReader AD = new StreamReader(NombreArchivo);
            //leo

            DatosLeidos = AD.ReadLine();
            Combo.Items.Clear();

            while (DatosLeidos != null)
            {
                Combo.Items.Add(DatosLeidos.Trim());
                DatosLeidos = AD.ReadLine();
            }
            //cerrar

            AD.Close();
            AD.Dispose();
        }
    }
}
