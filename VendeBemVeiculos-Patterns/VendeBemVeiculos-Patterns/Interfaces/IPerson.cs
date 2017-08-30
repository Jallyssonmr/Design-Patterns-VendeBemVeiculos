namespace VendeBemVeiculos_Patterns.Interfaces
{
    public interface IPerson
    {
        string Name { get; set; }

        string RGDocument { get; set; }

        string CPFDocument { get; set; }

        string Address { get; set; }

        string PhoneNumber { get; set; }
    }
}