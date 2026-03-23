using Xunit;
using PharmacyAPI.Services;

public class MedicineServiceTests
{
    [Fact]
    public void GetMedicines_ReturnsList()
    {
        var service = new JsonDataService();
        var result = service.GetMedicines();

        Assert.NotNull(result);
    }
}
