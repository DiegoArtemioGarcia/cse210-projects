using System;
using System.Collections.Generic;
using System.Linq;


// Clase que representa un Producto.
public class Product
{
    // Propiedades del producto: Nombre, ID, Precio unitario y Cantidad.
    public string Name { get; private set; }
    public int ProductID { get; private set; }
    public decimal Price { get; private set; }
    public int Quantity { get; private set; }

    // Constructor para inicializar un producto con sus valores.
    public Product(string name, int productID, decimal price, int quantity)
    {
        Name = name;
        ProductID = productID;
        Price = price;
        Quantity = quantity;
    }

    // Método que calcula el costo total del producto (Precio * Cantidad).
    public decimal GetTotalCost()
    {
        return Price * Quantity;
    }
}