using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;


public class ModelScore
{
    public double A { get; set;}
    public double B { get; set;}
    public double C { get; set;}
    public double Total => A * 0.6 + B * 0.3 + C * 0.1;
}