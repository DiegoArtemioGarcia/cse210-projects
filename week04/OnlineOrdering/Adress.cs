// Clase que representa la Dirección del cliente.
public class Address
{
    // Propiedades de la dirección: Calle, Ciudad, Estado y País.
    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Country { get; private set; }

    // Constructor para inicializar la dirección con sus valores.
    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    // Método que determina si la dirección está en EE.UU. (USA).
    public bool IsInUS()
    {
        return Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    // Método que devuelve la dirección completa como una cadena con saltos de línea.
    public override string ToString()
    {
        return $"{Street}\n{City}, {State}\n{Country}";
    }
}