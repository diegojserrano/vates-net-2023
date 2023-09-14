namespace EjercicioHospital{
    public class AtencionMedica : Atencion 
    {
        public decimal ImporteConsulta {get;set;}
        public Paciente Paciente {get;set;}

        public AtencionMedica(int codigo, int tipoCobro, Paciente paciente, decimal importeConsulta) : base(codigo, tipoCobro)
        {
            Paciente = paciente;
            ImporteConsulta = importeConsulta;
        }
        public override decimal ImporteACobrar()
        {
            decimal importe = ImporteConsulta;
            if (Paciente.EsHabitual)
            {
               importe *= 0.75m; 
            }
            if(TipoCobro == 2)
            {
                importe *= 1.20m;
            } else if(TipoCobro == 1)
            {
                importe *= 0.90m;
            }
            return importe;
        }
        
        public override string ToString()
        {
            return $"Atención Médica - Código: {Codigo}, Tipo de Cobro: {TipoCobro}, Importe de la consulta: {ImporteConsulta}, Paciente: {Paciente.Nombre}";
        }
    }
}