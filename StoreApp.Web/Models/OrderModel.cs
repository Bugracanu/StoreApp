using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace StoreApp.Web.Models;

public class OrderModel
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public String Name { get; set; } = null!;
    public String City { get; set; } = null!;
    public String Phone { get; set; } = null!;
    [EmailAddress]
    public String Email { get; set; } = null!;
    public String AddressLine { get; set; } = null!;
    [BindNever]
    public Cart? Cart { get; set; } = null!;

}