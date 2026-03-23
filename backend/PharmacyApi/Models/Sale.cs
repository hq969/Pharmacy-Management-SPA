namespace PharmacyAPI.Models;

public class Sale
{
    public string Id { get; set; }
    public string MedicineId { get; set; }
    public int QuantitySold { get; set; }
    public DateTime SaleDate { get; set; }
}
