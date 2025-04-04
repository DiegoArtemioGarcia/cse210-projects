// Clase principal (Main) donde se crea el programa. // Clase principal (Main) donde se crea el programa.
class Program
{
    static void Main(string[] args)
    {
        // Propiedades del producto: Nombre, ID, Precio unitario y Cantidad.
        Product product1 = new Product("Laptop", 1, 1000, 2); // 2 laptops, precio unitario 1000
        Product product2 = new Product("Mouse", 2, 20, 3);    // 3 mouse, precio unitario 20
        Product product3 = new Product("Keyboard", 3, 50, 1); // 1 teclado, precio unitario 50
        Product product4 = new Product("Monitor", 4, 200m, 1); // 1 monitor, precio unitario 200

        // Crear la dirección del cliente (dirección de ejemplo en EE.UU.).
        Address address = new Address("%0 E North Temple", "Salt Lake City", "Ut", "USA");

        // Crear el cliente, asignando el nombre y la dirección previamente creada.
        Customer customer = new Customer("Joseph Smith", address);// objeto de la clase Customer

        // Crear el pedido, asignando el cliente y la lista de productos.
        List<Product> products = new List<Product> { product1, product2 };// lista de productos
        Order order = new Order(customer, products);// objeto de la clase Order

        // Mostrar el costo total del pedido.
        Console.WriteLine($"Total cost:U$S.{order.GetTotalCost()}");

        // Mostrar la etiqueta de embalaje (productos).
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order.GetPackingLabel());

        // Mostrar la etiqueta de envío (información del cliente y su dirección).
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        // Crear un segundo cliente con dirección fuera de EE.UU.
        Address address2 = new Address("Calle Falsa", "Madrid", "Madrid", "Spain");

        Customer customer2 = new Customer("Juan Pérez", address2);
        // Crear un segundo pedido, asignando el cliente y la lista de productos.
        List<Product> products2 = new List<Product> { product3, product4 };
        Order order2 = new Order(customer2, products2);
        // Mostrar el costo total del segundo pedido.
        Console.WriteLine($"\nTotal cost:U$S.{order2.GetTotalCost()}");
        // Mostrar la etiqueta de embalaje del segundo pedido.
        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel());
        // Mostrar la etiqueta de envío del segundo pedido.
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.GetShippingLabel());



    }
}