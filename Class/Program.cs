using Third_Task_Wektory.Class;

public class Wektor
{
    private double[] współrzędne;

    public Wektor(byte wymiar)
    {
        współrzędne = new double[wymiar];
    }

    public Wektor(params double[] współrzędne)
    {
        this.współrzędne = współrzędne;
    }

    public double this[byte indeks]
    {
        get { return współrzędne[indeks]; }
        set { współrzędne[indeks] = value; }
    }

    public double Długość
    {
        get { return Math.Sqrt(ObliczeniaWektorów.IloczynSkalarny(this, this)); }
    }

    public byte Wymiar
    {
        get { return (byte)współrzędne.Length; }
    }

    public static Wektor Suma(params Wektor[] wektory)
    {
        return ObliczeniaWektorów.Suma(wektory);
    }

    public static Wektor operator +(Wektor v1, Wektor v2)
    {
        return ObliczeniaWektorów.Dodaj(v1, v2);
    }

    public static Wektor operator -(Wektor v1, Wektor v2)
    {
        return ObliczeniaWektorów.Odejmij(v1, v2);
    }

    public static Wektor operator *(Wektor v, double skalar)
    {
        return ObliczeniaWektorów.Pomnóż(v, skalar);
    }

    public static Wektor operator *(double skalar, Wektor v)
    {
        return ObliczeniaWektorów.Pomnóż(skalar, v);
    }

    public static Wektor operator /(Wektor v, double skalar)
    {
        return ObliczeniaWektorów.Podziel(v, skalar);
    }



    public override string ToString()
    {
        string separator = " | ";
        string result = string.Join(separator, współrzędne);
        return $"({result})";
    }

}
