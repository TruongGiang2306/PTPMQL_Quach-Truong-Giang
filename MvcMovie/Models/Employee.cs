using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace DemoMVC.Models
{
    public class Employee : Person
    {
        public string EmployeeId { get; set; }
        public int Age { get; set; }
    }
}
