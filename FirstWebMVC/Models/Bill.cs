using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;


public class ModelBill
{
    public int soluong { get; set;}
    public double dongia { get; set;}
    public double Tong => soluong * dongia;
}