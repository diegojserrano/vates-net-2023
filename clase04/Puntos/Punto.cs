using System;

namespace Puntos {
public enum Cuadrante {
    I,
    II,
    III,
    IV,
    Origen,
    EjeAbcisas,
    EjeOrdenadas
}


public record Punto(float X, float Y)  {

    public Punto(): this(0,0) {}


    //public double DistanciaOrigen => Math.sqrt(X*X + Y*Y);

    // Alternativa: no es mejor que la anterior, pero puede ser 
    // util si el calculo de la distancia fuera más largo o complejo
    public double DistanciaOrigen => Distancia(new Punto());

    public double Distancia(Punto otro) {
        double dx = this.X - otro.X;
        double dy = this.Y - otro.Y;
        return Math.Sqrt(dx*dx + dy*dy);
    } 

    public Cuadrante Cuadrante => (Math.Sign(X), Math.Sign(Y)) switch {
        (1,1) => Cuadrante.I,
        (1,-1) => Cuadrante.IV,
        (-1,1) => Cuadrante.II,
        (-1,-1) => Cuadrante.III,
        (0,0) => Cuadrante.Origen,
        (0,_) => Cuadrante.EjeOrdenadas,
        _ => Cuadrante.EjeAbcisas
    };

}
}
