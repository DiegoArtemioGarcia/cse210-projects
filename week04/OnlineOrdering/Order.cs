
// Clase que representa un Pedido.
public class Order
{
    // Propiedades del pedido: Lista de productos y el cliente que lo realizó.
    public List<Product> Products { get; private set; }
    public Customer Customer { get; private set; }

    // Constructor para inicializar un pedido con el cliente y la lista de productos.
    public Order(Customer customer, List<Product> products)
    {
        Customer = customer;
        Products = products;
    }

    // Método que calcula el costo total del pedido (productos + envío).
    public decimal GetTotalCost()
    {
        // Calculamos el costo total de los productos sumando los costos individuales.
        decimal totalProductCost = Products.Sum(p => p.GetTotalCost());

        // Determinamos el costo de envío: $5 si está en EE.UU., $35 si está fuera de EE.UU.
        decimal shippingCost = Customer.IsInUS() ? 5 : 35;

        // Retornamos el costo total del pedido: productos + envío.
        return totalProductCost + shippingCost;
    }

    // Método que genera la etiqueta de embalaje, mostrando el nombre y ID de cada producto.
    public string GetPackingLabel()
    {
        var labels = Products.Select(p => $"Product: {p.Name}, ID: {p.ProductID}");
        return string.Join("\n", labels);
    }

    // Método que genera la etiqueta de envío, mostrando el nombre del cliente y su dirección.
    public string GetShippingLabel()
    {
        return $"Name: {Customer.Name}\n{Customer.GetAddressInfo()}";
    }
}