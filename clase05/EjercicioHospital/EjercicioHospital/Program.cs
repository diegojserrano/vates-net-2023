namespace EjercicioHospital
{
    public class Program
    {
        public static void Main()
        {
            Hospital hospital = new Hospital("Hospital ABC");
            Paciente paciente1 = new Paciente("Juan", 1, true);
            AtencionMedica atencionMedica1 = new AtencionMedica(1, 1, paciente1, 500);
            hospital.AddAtencion(atencionMedica1);
            Paciente paciente2 = new Paciente("Maria", 3, false);
            AtencionMedica atencionMedica2 = new AtencionMedica(1, 2, paciente2, 700);
            hospital.AddAtencion(atencionMedica2);
            AtencionFarmacia atencionFarmacia1 = new AtencionFarmacia(2, 2, 200, 10);
            hospital.AddAtencion(atencionFarmacia1);
            decimal promedio = hospital.ImporteACobrarPromedioAtencionesMedicas();
            Console.WriteLine($"Importe promedio de atenciones médicas: ${promedio}");
            int cantidad = hospital.CantidadAtencionesConImporteACobrarDesdeHasta(200, 400);
            Console.WriteLine($"Cantidad de atenciones médicas en el rango: {cantidad}");
            string nombrePaciente = hospital.NombrePrimerPacienteDeOtroSintomaAtendido();
            Console.WriteLine($"Nombre del primer paciente con otros síntomas: {nombrePaciente}");



        }
    }
}