namespace WebApplication1.Models;
using System.ComponentModel.DataAnnotations;  


public class InputNumber
{
    [Range(0, 200, ErrorMessage = "Must be a number between 0 to 200")]
    public int EnteredNumber { get; set; }
}