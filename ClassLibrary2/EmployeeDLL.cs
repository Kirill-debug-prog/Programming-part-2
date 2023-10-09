using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDLL
{
    public class Employee
    {
        private string name;
        private string position;
        private string education;
        private int hireYear;
        private int experience;
        private int salary;
        private bool knowForeinnLanguage;

        public Employee (string name, string position, string education, 
            int hireYear, int experience, int salary, bool knowForeinnLanguage)
        {
            this.name = name;
            this.position = position;
            this.education = education;
            this.hireYear = hireYear;
            this.experience = experience;
            this.salary = salary;
            this.knowForeinnLanguage = knowForeinnLanguage;
        }

        public void IncreaseSalary(int newSalary)
        {
            salary = newSalary;
        }

        public void ChangePosition(string newPosition)
        {
            position = newPosition;
        }

        public void Fire()
        {
            position = "-";
            education = "-";
            hireYear = 0;
            experience = 0;
            salary = 0;
            knowForeinnLanguage = false;
        }
        
        public string GetImployeeData()
        {
            return $"Ф.И.О.: {name}\nДолжность:{position}\nОбразование: {education}" +
                $"\nГод приема: {hireYear}\nСтаж работы: {experience} года" +
                $"\nЗарплата: {salary}\nЗнание ИЯ: {knowForeinnLanguage}";
        }

        public string GetFull_Name()
        {
            return name;
        }

        public double GetBonus()
        {
            double bonus = 0;
            if (experience >= 5 && experience <= 10)
            {
                bonus += salary * 0.05;
            }
            else
            {
                bonus += salary * 0.1;
            }
            if (knowForeinnLanguage)
            {
                bonus += salary * 0.03;
            }

            return bonus;
        }

        public string GetPosition() { return position; }
        public string GetEducation() { return education; }
        public int GetHireYear() { return hireYear; }
        public int GetExperience() { return experience; }
        public int GetSalary() { return salary; }
        public bool GetKnowForeinnLanguage() {  return knowForeinnLanguage; }

    }
}