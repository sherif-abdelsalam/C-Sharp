namespace before_delegate{
    class Program{
        public static void Main(string[] args)
        {
            Employee []emps = new Employee[]{
                new Employee {Id = 1,Name="ALi", Gender="male",TotalSales = 65000m},
                new Employee {Id = 2,Name="AHmed", Gender="male",TotalSales = 50000m},
                new Employee {Id = 3,Name="Issam", Gender="male",TotalSales = 65000m},
                new Employee {Id = 4,Name="basel", Gender="male",TotalSales = 40000m},
                new Employee {Id = 5,Name="sara", Gender="female",TotalSales = 42000m},
                new Employee {Id = 6,Name="souza", Gender="female",TotalSales = 30000m},
                new Employee {Id = 7,Name="mohammed", Gender="male",TotalSales = 16000m},
                new Employee {Id = 8,Name="yahia", Gender="male",TotalSales = 15000m}
            };
            
            var rep = new Report();
            rep.ProceesEmpWith60kPLusSaled(emps);
            rep.ProceesEmpWithless60KAndMore30k(emps);
            rep.ProceesEmpWithless30K(emps);            
        }
    }
}