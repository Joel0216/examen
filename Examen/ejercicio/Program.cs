using System;

public class Producto
{
    private string nombre;
    private int codigo;
    private double precio;
    public Producto(string nombre, int codigo, double precio)
    {
        this.nombre = nombre;
        this.codigo = codigo;
        this.precio = precio;
    }
    public string GetNombre()
    {
        return nombre;
    }
    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }
    public int GetCodigo()
    {
        return codigo;
    }
    public void SetCodigo(int codigo)
    {
        this.codigo = codigo;
    }
    public double GetPrecio()
    {
        return precio;
    }
    public void SetPrecio(double precio)
    {
        this.precio = precio;
    }
    public override string ToString()
    {
        return "Producto [nombre=" + nombre + ", codigo=" + codigo + ", precio=" + precio + "]";
    }
}