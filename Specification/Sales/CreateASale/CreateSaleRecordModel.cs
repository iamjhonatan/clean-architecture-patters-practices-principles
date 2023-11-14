﻿
namespace CleanArchitecture.Specification.Sales.CreateASale;

public class CreateSaleRecordModel
{
    public DateTime Date { get; set; }

    public string Customer { get; set; } = string.Empty;

    public string Employee { get; set; } = string.Empty;

    public string Product { get; set; } = string.Empty;

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    public decimal TotalPrice { get; set; }
}
