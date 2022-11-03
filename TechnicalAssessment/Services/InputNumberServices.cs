namespace WebApplication1.Services;
using WebApplication1.Models;

public  static class InputNumberServices
{
    public static List<int> ConvertToIntegerList(int number)
    {
        List<int> numbersToPrint = Enumerable.Range(1, number).ToList();
        return numbersToPrint;
    }

    public static List<String> ConvertToStringList(List<int> integers)
    {
        var listToPrint = new List<string>();
        var today = DateTime.Today;

        foreach (var number in integers)
        {

            if (number % 5 == 0 && number % 3 == 0)
            {
                listToPrint.Add("walkers assessment"); 
            }
            else if (today.DayOfWeek == DayOfWeek.Monday && number % 3 == 0)
            {
                listToPrint.Add("walkersm"); 
                    
            }
            else if (today.DayOfWeek == DayOfWeek.Monday && number % 5 == 0)
            {
                listToPrint.Add("assessment-m"); 
            }
            else if (today.DayOfWeek != DayOfWeek.Monday && number % 3 == 0)
            {
                listToPrint.Add("walkers"); 
                    
            }
            else if (today.DayOfWeek != DayOfWeek.Monday && number % 5 == 0)
            {
                listToPrint.Add("assessment"); 
            }
            else
            {
                listToPrint.Add(number.ToString());
            }

        }

        return listToPrint;
    }
}