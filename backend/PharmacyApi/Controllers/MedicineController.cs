using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.DTOs;
using PharmacyAPI.Models;
using PharmacyAPI.Services;

namespace PharmacyAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MedicinesController : ControllerBase
{
    private readonly JsonDataService _service;

    public MedicinesController(JsonDataService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_service.GetMedicines());
    }

    [HttpPost]
    public IActionResult Add([FromBody] MedicineDto dto)
    {
        var med = new Medicine
        {
            FullName = dto.FullName,
            Notes = dto.Notes,
            ExpiryDate = dto.ExpiryDate,
            Quantity = dto.Quantity,
            Price = dto.Price,
            Brand = dto.Brand
        };

        _service.AddMedicine(med);
        return Ok("Medicine added");
    }

    [HttpPost("sale")]
    public IActionResult Sale([FromBody] SaleDto dto)
    {
        var sale = new Sale
        {
            MedicineId = dto.MedicineId,
            QuantitySold = dto.QuantitySold
        };

        _service.RecordSale(sale);
        return Ok("Sale recorded");
    }
}
