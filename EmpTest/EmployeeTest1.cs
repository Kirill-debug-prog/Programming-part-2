using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EmployeeDLL;
using Lab1;
using System.Net;

namespace EmpTest
{
    [TestClass]
    public class EmployeeTest1
    {
        [TestMethod]
        public void GetBonus_Should_Calculater_Correct_Bonus()
        {
            //Arange
            int salary = 5000;
            int experience = 7;
            bool knowForeinnLanguage = true;
            Employee employee = new Employee("Андрей", "Менеджер", "IT",
                2012, experience, salary, knowForeinnLanguage);

            //Act
            double bonus = employee.GetBonus();

            //Assert
            Assert.AreEqual(salary * 0.05 + salary * 0.03, bonus);
        }

        [TestMethod]
        public void IncreaseSalary_Should_Update_Salary()
        {
            //Arange
            int initialSalary = 5000;
            int newSalary = 6000;
            Employee employee = new Employee("Андрей", "Менеджер", "IT",
                2012, 7, initialSalary, true);

            //Act
            employee.IncreaseSalary(newSalary);

            //Assert
            Assert.AreEqual(newSalary, employee.GetSalary());
        }

        [TestMethod]
        public void Check_Transfer_to_another_position()
        {
            //Arange
            string initialPosition = "Менеджер";
            string newPosition = "Программист";
            Employee employee = new Employee("Андрей", initialPosition, "IT",
                2012, 7, 5000, true);

            //Act
            employee.ChangePosition(newPosition);

            //Assert
            Assert.AreEqual(newPosition, employee.GetPosition());
        }

        [TestMethod]
        public void Fire_Should_Reset_All_Properties()
        {
            //Arange
            string initialPosition = "Менеджер";
            string initialeducation = "Программист";
            int initialHireYear = 2012;
            int initialExperiace = 7;
            int initialSalary = 5000;
            bool initialKnowForeinnLanguag = false;
            Employee employee = new Employee("Андрей", initialPosition, initialeducation,
                initialHireYear, initialExperiace, initialSalary, initialKnowForeinnLanguag);

            //Act
            employee.Fire();

            //Assert
            Assert.AreEqual("-", employee.GetPosition());
            Assert.AreEqual("-", employee.GetEducation());
            Assert.AreEqual(0, employee.GetHireYear());
            Assert.AreEqual(0, employee.GetExperience());
            Assert.AreEqual(0, employee.GetSalary());
            Assert.IsFalse(employee.GetKnowForeinnLanguage());
        }
    }
}
