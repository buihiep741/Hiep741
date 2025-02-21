using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;


public class ModelBMI
{
    public double Weight { get; set;}
    public double Height { get; set;}
    public double BMI => Weight / (Height * Height);
}