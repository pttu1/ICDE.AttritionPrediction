using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICDE.CompareProducts.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string BusinessTravel { get; set; }
        public string DailyRate { get; set; }
        public int DistanceFromHome { get; set; }

        public string EducationField { get; set; }

        public int EnvironmentSatisfaction { get; set; }

        public int Gender { get; set; }

        public int HourlyRate { get; set; }


        public string JobRole { get; set; }

        public string MaritalStatus { get; set; }

        public int PercentSalaryHike { get; set; }

        public int PerformanceRating { get; set; }
    }
}
