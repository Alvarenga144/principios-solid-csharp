﻿namespace OpenClose
{
    internal class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public override decimal CalculateSalaryMonthly()
        {
            decimal hourValue = 40000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }
    }
}
