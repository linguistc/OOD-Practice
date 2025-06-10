// See https://aka.ms/new-console-template for more information

using OODPractice.BasicSalaryCalculatorSystem.EmployeeService;

List<Employee> employees = new()
{
    new Manager
    {
        Id = 1001,
        FName = "Ahmad",
        LName = "Salem",
        HourlyRate = 10.0m,
        ExpectedHours = 40,
        LoggedHours = 40,
        Allowance = 100,
    },
    new SalesAgent
    {
        Id = 1002,
        FName = "Reem",
        LName = "Abdallah",
        HourlyRate = 10.0m,
        ExpectedHours = 40,
        LoggedHours = 45,
        TotalSales = 10000
    },
    new Handyman
    {
        Id = 1003,
        FName = "Salah",
        LName = "Adel",
        HourlyRate = 5.0m,
        ExpectedHours = 40,
        LoggedHours = 65,
        Hardship = 75,
    },
    new SoftwareEngineer
    {
        Id = 1004,
        FName = "Madiha",
        LName = "Rawi",
        HourlyRate = 10.0m,
        ExpectedHours = 40,
        LoggedHours = 40,
        TrainingAllowance = 50,
        StoryPointCompleted = 8
    }
};

foreach (var e in employees)
{
    Console.WriteLine($"------ {e.GetType().Name} ------\n" +
                      $"{e.ShowSalarySlip()}\n");
}
