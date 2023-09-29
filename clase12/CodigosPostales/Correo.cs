namespace CodigosPostales;

public class Correo {


    private Dictionary<int, List<CodigoPostal>> codigosPostales;
    public int CantidadCodigosUnicos => codigosPostales.Count;

    public Dictionary<string, int> CantidadPorProvincia {
        get {
            Dictionary<string, int> conteo = new();

            foreach(List<CodigoPostal> l in codigosPostales.Values) {
                foreach(CodigoPostal c in l) {
                    // Contar segun la provincia
                    if (!conteo.ContainsKey(c.Provincia))
                        conteo[c.Provincia] = 0;
                    conteo[c.Provincia]++;
                }
            }

            return conteo;
        }
    }

    public Correo()
    {
        codigosPostales = new();
    }

    public void AgregarCodigo(CodigoPostal nuevo) {
        if (!codigosPostales.ContainsKey(nuevo.Codigo)) 
            codigosPostales[nuevo.Codigo] = new List<CodigoPostal>();
        
        codigosPostales[nuevo.Codigo].Add(nuevo);
    }

    public List<CodigoPostal> BuscarPorCodigo(int codigo) {
        if (codigosPostales.ContainsKey(codigo))
            return codigosPostales[codigo];
        return new List<CodigoPostal>();
    }

    public List<CodigoPostal> BuscarPorNombre(string nombre) {
        List<CodigoPostal> resultado = new List<CodigoPostal>();

        foreach (List<CodigoPostal> lista in codigosPostales.Values)
            resultado.AddRange(lista.Where(cp => cp.Nombre.Contains(nombre)));

        return resultado;
    }

    

}