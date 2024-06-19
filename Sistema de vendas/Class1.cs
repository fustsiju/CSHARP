using System;
using System.Collections;
using System.Reflection.Emit;

public class Class1
{
    private string name; // field
    private float preco;
    private string tipo;

    public string Name   // property
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }
    public float Preco
    {
        get { return preco; }
        set { preco = value; }
    }
    public string Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }
}