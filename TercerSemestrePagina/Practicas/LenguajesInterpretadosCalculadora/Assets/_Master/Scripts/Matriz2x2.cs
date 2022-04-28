using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * <p>Clase para matrices de 2×2.</p>
 *
 * <p>Las matrices de 2×2 pueden sumarse, multiplicarse, sacar su determinante,
 * obtener su matriz inversa (una matriz multiplicada por su inversa resulta en
 * la matriz identidad), y elevarla a la potencia <em>n</em> (multiplicarla
 * consigo misma <em>n</em> veces).</p>
 *
 * <p>Las matrices se crean con cuatro dobles a, b, c y d, tales que representan
 * a la matriz:</p>
 *
<pre>
 ⎛ a  b ⎞
 ⎝ c  d ⎠
</pre>
 */
public class Matriz2x2
{

    /* La primera entrada de la matriz. */
    private double a, ai;
    /* La segunda entrada de la matriz. */
    private double b, bi;
    /* La tercera entrada de la matriz. */
    private double c, ci;
    /* La cuarta entrada de la matriz. */
    private double d, di;

    private double matr;
    private double matri;
    private double matrii;
    private double matriii;

    /**
     * Constructor único. Dado que no proveemos <em>setters</em>, nuestras
     * matrices de 2×2 son <em>inmutables</em>; no podemos cambiar sus valores.
     * @param a la primera entrada de la matriz.
     * @param b la segunda entrada de la matriz.
     * @param c la tercera entrada de la matriz.
     * @param d la cuarta entrada de la matriz.
     */
    public Matriz2x2(double a, double b,
                     double c, double d)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
        // Aquí va su código.
    }

    /**
     * Regresa el elemento <tt>a</tt> de la matriz de 2×2.
     * @return El elemento <tt>a</tt> de la matriz de 2×2.
     */
    public double GetA()
    {
        return a;
    }

    /**
     * Regresa el elemento <tt>b</tt> de la matriz de 2×2.
     * @return El elemento <tt>b</tt> de la matriz de 2×2.
     */
    public double GetB()
    {

        return b;
        // Aquí va su código.
    }

    /**
     * Regresa el elemento <tt>c</tt> de la matriz de 2×2.
     * @return El elemento <tt>c</tt> de la matriz de 2×2.
     */
    public double GetC()
    {

        return c;
        // Aquí va su código.
    }

    /**
     * Regresa el elemento <tt>d</tt> de la matriz de 2×2.
     * @return El elemento <tt>d</tt> de la matriz de 2×2.
     */
    public double GetD()
    {
        return d;
        // Aquí va su código.
    }

    /**
     * Suma la matriz de 2×2 con la matriz de 2×2 que recibe como parámetro.
     * @param m La matriz de 2×2 con la que hay que sumar.
     * @return La suma con la matriz de 2×2 <tt>m</tt>.
     */
    public Matriz2x2 Suma(Matriz2x2 m)
    {
        Matriz2x2 suma = new Matriz2x2(a + m.GetA(), b + m.GetB(), c + m.GetC(), d + m.GetD());
        return suma;
        
    }

    /**
     * Multiplica la matriz de 2×2 con la matriz de 2×2 que recibe como
     * parámetro.
     * @param m La matriz de 2×2 con la que hay que multiplicar.
     * @return La multiplicación con la matriz de 2×2 <tt>m</tt>.
     */
    public Matriz2x2 Multiplica(Matriz2x2 m)
    {
        Matriz2x2 multi = new Matriz2x2(a * m.GetC() + b * m.GetD(), b * m.GetA() + c * m.GetB(),
                                        c * m.GetC() + b * m.GetD(), b * m.GetA() + a * m.GetB());
        return multi;
        
    }

    /**
     * Multiplica la matriz de 2×2 con la constante que recibe como parámetro.
     * @param x La constante con la que hay que multiplicar.
     * @return La multiplicación con la constante <tt>x</tt>.
     */
    public Matriz2x2 Multiplica(double x)
    {
        Matriz2x2 multii = new Matriz2x2(a*x,
                                         b*x,
                                         c*x,
                                         d*x);
        return multii;  
    }

    /**
     * Calcula el determinante de la matriz de 2×2.
     * @return El determinante de la matriz de 2×2.
     */
    public double Determinante()
    {
        Matriz2x2 Det = new Matriz2x2(a + GetD() * b + GetC(),0,0,0);
         

        return 0;
       
    }

    /**
     * Calcula la inversa de la matriz de 2×2.
     *
     * Si multiplicamos una matriz de 2×2 con su inversa, obtenemos la matriz
     * identidad.
     * @return La inversa de la matriz de 2×2, o <tt>null</tt> si la matriz no
     *         es inversible.
     */
    public Matriz2x2 Inversa()
    {
        double det = Determinante();
        if (det == 0.0)
        {
            return null;
        }
        Matriz2x2 inv = new Matriz2x2(a = GetC(), b = GetD(), c = GetA(), d = GetB());

        return null;

    }

    /**
     * Calcula la <em>n</em>-ésima potencia de la matriz de 2×2.
     *
     * La <em>n</em>-ésima potencia de una matriz de 2×2 es el resultado de
     * multiplicar la matriz consigo misma <em>n</em> veces.
     * @param n La potencia a la que hay que elevar la matriz; si <em>n</em> es
     *          menor que 2, regresa una copia de la matriz de 2×2.
     * @return la <em>n</em>-ésima potencia de la matriz de 2×2.
     */
    public Matriz2x2 Potencia(int n)
    {
        Matriz2x2 m = new Matriz2x2(a, b, c, d);
        if (n < 2)
            return m;
        while (n > 1)
        {
            m = m.Multiplica(this);
            n--;
        }
        return m;
    }

    /**
     * Nos dice si el objeto recibido es una matrix de 2×2 igual a
     * la que manda llamar al método.
     * @param o el objeto con el que se comparará el que manda llamar el método.
     * @return <tt>true</tt> si el objeto o es una matrix de 2×2 igual a la que
     *         manda llamar al método; <tt>false</tt> en otro caso.
     */
    public override bool Equals(System.Object o)
    {
        if (o == null)
        {
            return false;

        }
        if (!(o.GetType() == typeof(Matriz2x2)))
        {
            return false;
        }
        Matriz2x2 m = (Matriz2x2)o;

        if (a == m.GetA() && b == m.GetB() && c == m.GetC() && d == m.GetD())
        {
            return true;
        }
        else return false;
        
    }

    /**
     * Regresa una representación en cadena de la matriz de 2×2. La
     * representación es de la forma:
<pre>
 ⎛ a  b ⎞
 ⎝ c  d ⎠
</pre>
     * @return una representación en cadena de la matriz de 2×2.
     */
    public override string ToString()
    {
        string sa = a.ToString();
        string sb = b.ToString();
        string sc = c.ToString();
        string sd = d.ToString();

        return "( " + sa + "   " + sb + " )\n" +
            "( " + sc + "   " + sd + " )";
    }
}
