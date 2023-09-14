namespace EjercicioHospital
{
    public class Hospital
    {
        public string RazonSocial { get; set; }
        public List<Atencion> Atenciones { get; set; }

        public Hospital(string razonSocial)
        {
            RazonSocial = razonSocial;
            Atenciones = new List<Atencion>();
        }
        public void AddAtencion(Atencion atencion)
        {
            Atenciones.Add(atencion);
        }
        public decimal ImporteACobrarPromedioAtencionesMedicas()
        {
            // var atencionesMedicas = Atenciones.OfType<AtencionesMedicas>();
            //List<AtencionMedica> atenciones = new List<AtencionMedica>();
            var atencionesFiltradas = Atenciones.FindAll(a => a is AtencionMedica); // Uso de operador is
            if (atencionesFiltradas.Count() == 0)
            {
                throw new InvalidOperationException("No se han registrado atenciones médicas");
            }
            decimal sumaImportes = atencionesFiltradas.Sum(atencion => atencion.ImporteACobrar());
            int cantidadAtenciones = atencionesFiltradas.Count();
            return sumaImportes / cantidadAtenciones;
        }
        
        public int CantidadAtencionesConImporteACobrarDesdeHasta(decimal desde, decimal hasta)
        {
            var atencionesMedicas = Atenciones.OfType<AtencionMedica>();
            return atencionesMedicas.Count(atencion => atencion.ImporteACobrar() >= desde && atencion.ImporteACobrar() <= hasta);
        }

        public string NombrePrimerPacienteDeOtroSintomaAtendido()
        {
            var atencionesMedicas = Atenciones.OfType<AtencionMedica>();
            var pacienteOtroSintoma = atencionesMedicas.FirstOrDefault(atencion => atencion.Paciente.Sintoma == 3);

            if (pacienteOtroSintoma != null)
            {
                return pacienteOtroSintoma.Paciente.Nombre;
            }
            else
            {
                return "No se ha atendido a ningún paciente con otros síntomas.";
            }
        }
    }
}