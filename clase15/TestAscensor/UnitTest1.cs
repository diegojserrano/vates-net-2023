namespace TestAscensor;

public class UnitTest1
{
    [Fact]
    public void TestToString()
    {
        Ascensor a = new Ascensor(1,5,10);
        string s = a.ToString();
        Assert.Equal("Piso: 0 - Personas: 0", s);
    }

    [Fact]
    public void Subir1()
    {
        Ascensor a = new Ascensor(1,5,10);
        a.Subir(3);
        Assert.Equal(3, a.Personas);
    }

    [Fact]
    public void PisoValido()
    {
        Ascensor a = new Ascensor(1,5,10);
        Assert.True(a.IrAPiso(4));
        Assert.Equal(4, a.Piso);
    }

    [Fact]
    public void PisoInvalido()
    {
        Ascensor a = new Ascensor(1,5,10);
        a.IrAPiso(4);
        Assert.False(a.IrAPiso(15));
        Assert.Equal(4, a.Piso);
    }
}