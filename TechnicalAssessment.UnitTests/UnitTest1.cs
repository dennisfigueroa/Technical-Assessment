using WebApplication1.Models;
using WebApplication1.Services;

namespace TechnicalAssessment.UnitTests;
using NUnit.Framework;
using TechnicalAssessment;

public class InputNumberServicesTests
{

    [Test]
    public void ConvertToIntegerList_Works()
    {
        
        //Arrange
        var testList = new List<int>() { 1, 2, 3, 4, 5 };
        //Act
        var completedList = InputNumberServices.ConvertToIntegerList(5);
        //Assert
        Assert.That( completedList, Is.EqualTo(testList));
    }
    
    [Test]
    public void ConvertToStringList_Works()
    {
        var testList = new List<int>() { 1, 2, 3, 4, 5 };
        var today = DateTime.Today;
        var updatedTestList = new List<String>();

        //Arrange
        
        if (today.DayOfWeek == DayOfWeek.Monday)  
        {
            updatedTestList = new List<String>() { "1", "2", "walkersm", "4", "assessment-m" };
        }
        else
        {
            updatedTestList = new List<String>() { "1", "2", "walkers", "4", "assessment" };
        }
        
        //Act
        var convertedList = InputNumberServices.ConvertToStringList(testList);
        //Assert
        Assert.That( convertedList, Is.EqualTo(updatedTestList));
    }
    
 
}