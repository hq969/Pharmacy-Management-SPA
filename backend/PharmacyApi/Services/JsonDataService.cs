using System.Text.Json;
using PharmacyAPI.Models;

namespace PharmacyAPI.Services;

public class JsonDataService
{
    private readonly string medFile = "Data/medicines.json";
    private readonly string salesFile = "Data/sales.json";

    public List<Medicine> GetMedicines()
    {
        if (!File.Exists(medFile))
            return new List<Medicine>();

        var json = File.ReadAllText(medFile);
        return JsonSerializer.Deserialize<List<Medicine>>(json) ?? new List<Medicine>();
    }

    public void SaveMedicines(List<Medicine> medicines)
    {
        var json = JsonSerializer.Serialize(medicines, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(medFile, json);
    }

    public void AddMedicine(Medicine med)
    {
        var meds = GetMedicines();
        med.Id = Guid.NewGuid().ToString();
        meds.Add(med);
        SaveMedicines(meds);
    }

    public void RecordSale(Sale sale)
    {
        var meds = GetMedicines();
        var med = meds.FirstOrDefault(m => m.Id == sale.MedicineId);

        if (med == null)
            throw new Exception("Medicine not found");

        if (med.Quantity < sale.QuantitySold)
            throw new Exception("Insufficient stock");

        med.Quantity -= sale.QuantitySold;
        SaveMedicines(meds);

        List<Sale> sales = new();

        if (File.Exists(salesFile))
        {
            sales = JsonSerializer.Deserialize<List<Sale>>(File.ReadAllText(salesFile)) ?? new List<Sale>();
        }

        sale.Id = Guid.NewGuid().ToString();
        sale.SaleDate = DateTime.Now;

        sales.Add(sale);

        File.WriteAllText(salesFile,
            JsonSerializer.Serialize(sales, new JsonSerializerOptions { WriteIndented = true }));
    }
}
