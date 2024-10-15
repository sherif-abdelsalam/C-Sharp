class Employee{
        public int Id { get; set; }
        public required string Gender { get; set; }
        public decimal TotalSales { get; set; }
        public required string Name { get; set; }

        public string GetEmpInfo(){
            return $"{Id} | {Name} | {Gender} | {TotalSales}";
        }
    }