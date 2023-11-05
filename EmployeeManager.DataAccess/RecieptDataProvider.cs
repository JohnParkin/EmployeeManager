using EmployeeManager.Common.DataProvider;
using EmployeeManager.Common.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace EmployeeManager.DataAccess
{
  public class RecieptDataProvider : IRecieptDataProvider
  {
    public IEnumerable<Reciept> LoadReciepts()
    {
      return new List<Reciept>

      {
        new Reciept
        {
              Id = 1,
              Supplier = "National Trust",
              Catagory = 4,
              EntryDate = new DateTime(2023, 09, 25),
              Total = 15.90,
              VAT = true,
              VatValue = 2.65,
              ScannedImage = "/Images/Scan 6.jpg"
        },
        new Reciept
        {
                Id = 2,
                Supplier = "One Stop",
                Catagory = 1,
                EntryDate = new DateTime(2019, 10, 1),
                Total = 10,
                VAT = true
        },
        new Reciept
        {
          Id = 3,
          Supplier = "Marks & Spencer",
          Catagory = 1,
          EntryDate = new DateTime(2019, 10, 1),
          Total = 10,
        },
        new Reciept
        {
          Id = 4,
          Supplier = "One Stop",
          Catagory = 1,
          EntryDate = new DateTime(2023, 10, 16),
          Total = 10,
          VAT = true,
          VatValue = 0.54,
          ScannedImage = "/Images/Scan 0.jpg"
        },
        new Reciept
        {
          Id = 5,
          Supplier = "Superdrug",
          Catagory = 16,
          EntryDate = new DateTime(2023, 10, 17),
          Total = 16.71,
          ScannedImage = "/Images/Scan 1.jpg"
        }
      };
    }

    public void SaveReciept(Reciept reciept)
    {
      Debug.WriteLine($"Reciept saved: {reciept.Supplier}");
    }

    public IEnumerable<Category> LoadCategories()
    {
      return new List<Category>
      {
        new Category{ Id = 1, CategoryName = "Accommodation and Subsistence" },
        new Category{ Id = 2, CategoryName = "Accountancy" },
        new Category{ Id = 3, CategoryName = "Capital Assets" },
        new Category{ Id = 4, CategoryName = "Client entertaining" },
        new Category{ Id = 5, CategoryName = "Computer consumables" },
        new Category{ Id = 6, CategoryName = "Insurance" },
        new Category{ Id = 7, CategoryName = "Marketing and advertising" },
        new Category{ Id = 8, CategoryName = "Motor and Travel" },
        new Category{ Id = 9, CategoryName = "Pension contributions" },
        new Category{ Id = 10, CategoryName = "Postage and stationery" },
        new Category{ Id = 12, CategoryName = "Rent" },
        new Category{ Id = 13, CategoryName = "Share Capital" },
        new Category{ Id = 14, CategoryName = "Staff entertaining" },
        new Category{ Id = 15, CategoryName = "Subscriptions" },
        new Category{ Id = 16, CategoryName = "Sundries" },
        new Category{ Id = 17, CategoryName = "Telephone and Internet" },
        new Category{ Id = 18, CategoryName = "Training" },
        new Category{ Id = 19, CategoryName = "Use of home as office" }
      };
    }
  }
}