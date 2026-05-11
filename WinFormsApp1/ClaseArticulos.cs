namespace WinFormsApp1
{
    public class ClaseArticulos
    {
        public string NombreArchivo = "ARTICULOS.CSV";

        public struct RegArticulos
        {
            public string Codigo;
            public string Descripcion;
            public Decimal Costo;
            public string Rubro;
            public Int32 Stock;
        }

        private RegArticulos[] VecArticulos = new RegArticulos[1500];
        private Int32 IND = 0;

        public Int32 CantidadListados = 0;
        public Decimal TotalValorStock = 0;

        public void Listar(DataGridView Grilla, string Rubro)
        {
            string DatosLeidos;
            string[] VecDatos = new string[5];
            Decimal ValorStock;

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            Grilla.Rows.Clear();
            CantidadListados = 0;
            TotalValorStock = 0;

            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');

                if (VecDatos[3] == Rubro)
                {
                    ValorStock = Convert.ToDecimal(VecDatos[2]) * Convert.ToInt32(VecDatos[4]);
                    Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[4], ValorStock);
                    CantidadListados++;
                    TotalValorStock += ValorStock;
                }

                DatosLeidos = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();
        }

        public void Exportar(string NombreArchivoDestino, string Rubro)
        {
            string DatosLeidos;
            string[] VecDatos = new string[5];
            Decimal ValorStock;

            StreamWriter Reporte = new StreamWriter(NombreArchivoDestino, false);
            Reporte.WriteLine("Codigo;Descripcion;Costo;Stock;Valor en Stock");

            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');

                if (VecDatos[3] == Rubro)
                {
                    ValorStock = Convert.ToDecimal(VecDatos[2]) * Convert.ToInt32(VecDatos[4]);
                    Reporte.Write(VecDatos[0]);
                    Reporte.Write(';');
                    Reporte.Write(VecDatos[1]);
                    Reporte.Write(';');
                    Reporte.Write(VecDatos[2]);
                    Reporte.Write(';');
                    Reporte.Write(VecDatos[4]);
                    Reporte.Write(';');
                    Reporte.WriteLine(ValorStock);
                }

                DatosLeidos = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();

            Reporte.Close();
            Reporte.Dispose();
        }
    }
}
