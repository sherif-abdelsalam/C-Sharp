class Report{
    
    public void ProceesEmpWith60kPLusSaled(Employee[]emps){
        System.Console.WriteLine("Employees With 60k + Sales");
        System.Console.WriteLine("======================================================");
        foreach(var emp in emps){
            if(emp.TotalSales>=60000){
                System.Console.WriteLine(emp.GetEmpInfo());
            }
        }
        System.Console.WriteLine();
    }

    public void ProceesEmpWithless60KAndMore30k(Employee[]emps){
        System.Console.WriteLine("Employees With More 30k and less 60k + Sales");
        System.Console.WriteLine("======================================================");
        foreach(var emp in emps){
            if(emp.TotalSales<60000 && emp.TotalSales >=30000){
                System.Console.WriteLine(emp.GetEmpInfo());
            }
        }
        System.Console.WriteLine();
    }
    public void ProceesEmpWithless30K(Employee[]emps){
        System.Console.WriteLine("Employees With Less 30k + Sales");
        System.Console.WriteLine("======================================================");
        foreach(var emp in emps){
            if(emp.TotalSales <30000){
                System.Console.WriteLine(emp.GetEmpInfo());
            }
        }
        System.Console.WriteLine();
    }
}