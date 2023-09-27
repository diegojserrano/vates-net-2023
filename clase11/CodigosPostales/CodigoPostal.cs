namespace CodigosPostales
{
    public class CodigoPostal
    {
        public string Provincia {get; set;}
        public int Codigo {get;set;}
        public string Nombre {get;set;}

        public CodigoPostal(){}
        public CodigoPostal(string provincia, string nom, int codigo)
        {
            Provincia = provincia;
            Codigo = codigo;
            Nombre = nom;
        }
        public override string ToString()
        {
            return $"Provincia: {Provincia}, Código: {Codigo}, Nombre: {Nombre}";
        }
    }
}