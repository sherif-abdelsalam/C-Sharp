class Report{   

    public delegate bool IsIlligable(Employee e);
    
    public void ProccessEmp(Employee[]emps,string title,string line, IsIlligable isIllig){
        System.Console.WriteLine(title);
        System.Console.WriteLine(line);
        
        foreach(var emp in emps){
            if(isIllig(emp)){
                System.Console.WriteLine(emp.GetEmpInfo());
            }
        }
        System.Console.WriteLine();
    }
}