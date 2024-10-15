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
            string BreakLIne = "===========================";
            // rep.ProccessEmp(emps,"Emploees With 60K+",BreakLIne,Procee60kPlus);
            // rep.ProccessEmp(emps,"Emploees With 60K- and 30K+",BreakLIne,Procee60kLess30KPLus);
            // rep.ProccessEmp(emps,"Emploees With 30K-",BreakLIne,Procee30KLess);

            // Anonymus Delgate (used when you call method only once)
            // rep.ProccessEmp(emps,"Emploees With 60K+",BreakLIne,delegate(Employee e){return e.TotalSales>=60000;});
            // rep.ProccessEmp(emps,"Emploees With 60K- and 30K+",BreakLIne,delegate(Employee e){return e.TotalSales<60000 && e.TotalSales>=30000;});
            // rep.ProccessEmp(emps,"Emploees With 30K-",BreakLIne,delegate(Employee e){return e.TotalSales<30000;});

            // Lambda Expression
            // rep.ProccessEmp(emps,"Emploees With 60K+",BreakLIne,(Employee e)=> e.TotalSales>=60000);
            // rep.ProccessEmp(emps,"Emploees With 60K- and 30K+",BreakLIne,(Employee e) => e.TotalSales<60000 && e.TotalSales>=30000);
            // rep.ProccessEmp(emps,"Emploees With 30K-",BreakLIne,(Employee e) => e.TotalSales<30000);

            // Lambda Expression enhanced 
            rep.ProccessEmp(emps,"Emploees With 60K+",BreakLIne,e => e.TotalSales>=60000);
            rep.ProccessEmp(emps,"Emploees With 60K- and 30K+",BreakLIne,e => e.TotalSales<60000 && e.TotalSales>=30000);
            rep.ProccessEmp(emps,"Emploees With 30K-",BreakLIne,e => e.TotalSales<30000);


        }

        //public static bool Procee60kPlus(Employee e) => e.TotalSales>=60000;
        //public static bool Procee60kLess30KPLus(Employee e) => e.TotalSales<60000 && e.TotalSales>=30000;
        //public static bool Procee30KLess(Employee e) => e.TotalSales<30000;

    }
}