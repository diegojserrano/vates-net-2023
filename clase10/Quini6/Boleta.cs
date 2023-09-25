
public class Boleta {

    private SortedSet<int> apuesta;

    public Boleta() {
        apuesta = new();
    }

    public bool AgregarNumero(int x) {
        return apuesta.Add(x);
    }

    public bool EsValida => apuesta.Count == 6;

    public bool EsGanadora(SortedSet<int> sorteados) {
        return EsValida && CantidadAciertos(sorteados) == 6;
    }

    public int CantidadAciertos(SortedSet<int> sorteados) {
        return apuesta.Intersect(sorteados).Count();
    }

    public override string ToString()
    {
        string listado = "[";
        foreach(int x in apuesta) listado += $"{x},";
        return listado + "]";  
    }
}
