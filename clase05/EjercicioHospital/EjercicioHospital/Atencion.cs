namespace EjercicioHospital{
    public class Atencion {
        public int Codigo {get; set;}
        public int TipoCobro {get;set;} // 1 - Efectivo , 2 - TC

        public Atencion(int codigo, int tipoCobro) {
            Codigo = codigo;
            TipoCobro = tipoCobro;
        }

        public virtual decimal ImporteACobrar(){
            return 0; // Implementación en clases derivadas   
        }
        public override string ToString()
        {
            return $"Atención - Código: {Codigo}, Tipo de Cobro: {TipoCobro} ";
        }
    }
}