// Clase que representa al Cliente.
public class Customer
{
    // Propiedades del cliente: Nombre y Dirección.
    public string Name { get; private set; }
    public Address Address { get; private set; }

    // Constructor para inicializar el cliente con nombre y dirección.
    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    // Método que devuelve la dirección completa como una cadena.
    public string GetAddressInfo()
    {
        return Address.ToString();
    }

    // Método que verifica si el cliente reside en EE.UU.
    public bool IsInUS()
    {
        return Address.IsInUS();
    }
}