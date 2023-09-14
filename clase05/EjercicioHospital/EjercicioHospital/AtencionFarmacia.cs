namespace EjercicioHospital{
    public class AtencionFarmacia : Atencion {
        public decimal ImporteTotalMedicamentos {get;set;}
        public decimal CuponDescuento {get;set;}

        public AtencionFarmacia(int codigo, int tipoCobro, decimal importeTotal, decimal cuponDescuento) 
        : base(codigo, tipoCobro)
        {
            ImporteTotalMedicamentos = importeTotal;
            CuponDescuento = cuponDescuento;
        }

        public override decimal ImporteACobrar(){
            decimal importe = ImporteTotalMedicamentos - CuponDescuento;
            if (TipoCobro == 2) // Tarjeta de Crédito
            {
                importe *= 1.30m;
            }
            else if (TipoCobro == 1) // Efectivo
            {
                importe *= 0.95m;
            }
            return importe;
        }
        public override string ToString()
        {
            return $"Atención Farmacia - Código: {Codigo}, Tipo de Cobro: {TipoCobro}, Importe Medicamentos: {ImporteTotalMedicamentos}, Cupón: {CuponDescuento}";
        }
    }
}