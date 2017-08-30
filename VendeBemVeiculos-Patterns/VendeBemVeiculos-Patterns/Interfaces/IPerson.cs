namespace VendeBemVeiculos_Patterns.Interfaces
{
    public interface IPerson
    {
        string Name { get; }

        string RGDocument { get; set; }

        string CPFDocument { get; }

        string Address { get; set; }

        string PhoneNumber { get; }
    }
}