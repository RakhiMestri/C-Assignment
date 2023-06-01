public class Program {
    public class Medicines
    {
        public string Medicine_Code { get; set; }
        public string Manufracture_Name { get; set; }
        public string Unit_Price { get; set; }
        public string Medicine_Name { get; set; }
        public string Quantity { get; set; }
        public string Manufracture_Date { get; set; }
        public string Expiry_Date { get; set; }
        public string Batch_Number { get; set; }
        //public Medicines(string code, string name, string manufacture, string price, string quantity, string Man_Date, string Exp_Date, string batchNo)
        //{
        //    Medicine_Code = code;
        //    Medicine_Name = name;
        //    Manufracture_Name = manufacture;
        //    Unit_Price = price;
        //    Quantity = quantity;
        //    Manufracture_Date = Man_Date;
        //    Expiry_Date = Exp_Date;
        //    Batch_Number = batchNo;
        //}
        public void Accept()
        {
            Console.Write("Enter value for Medicine Code: ");
            Medicine_Code = Console.ReadLine();

            Console.Write("Enter value for Medicine Name: ");
            Medicine_Name = Console.ReadLine();

            Console.Write("Enter value for Manufracture Name: ");
            Manufracture_Name = Console.ReadLine();

            Console.Write("Enter value for Unit Price: ");
            Unit_Price = Console.ReadLine();

            Console.Write("Enter value for Quantity: ");
            Quantity = Console.ReadLine();

            Console.Write("Enter value for Manufracture Date: ");
            Manufracture_Date = Console.ReadLine();

            Console.Write("Enter value for Expiry_Date: ");
            Expiry_Date = Console.ReadLine();

            Console.Write("Enter value for Batch Number: ");
            Batch_Number = Console.ReadLine();
        }
        public void Display()
        {
            Console.Write("value for Medicine Code: " + Medicine_Code);

            Console.Write(" value for Medicine Name: " + Medicine_Name);


            Console.Write(" value for Manufracture Name: " + Manufracture_Name);


            Console.Write(" value for Unit Price: " + Unit_Price);


            Console.Write(" value for Quantity: " + Quantity);


            Console.Write(" value for Manufracture Date: " + Manufracture_Date);


            Console.Write(" value for Expiry_Date: " + Expiry_Date);


            Console.Write(" value for Batch Number: " + Batch_Number);

        }

    }
    public class Sales
    {
        public string Medicine_Code { get; set; }
        public string Quantity_Sold { get; set; }
        public string Planned_Sales { get; set; }
        public string Actual_Sales { get; set; }
        public string Region { get; set; }

        public Sales(string code, string quantity, string planned_sales, string actual_sales, string region)
        {
            Medicine_Code = code;
            Quantity_Sold = quantity;
            Planned_Sales = planned_sales;
            Actual_Sales = actual_sales;
            Region = region;
        }
        public void Accept()
        {
            Console.Write("Enter value for Medicine Code: ");
            Medicine_Code = Console.ReadLine();

            Console.Write("Enter value for Medicine Name: ");
            Quantity_Sold = Console.ReadLine();

            Console.Write("Enter value for Manufracture Name: ");
            Planned_Sales = Console.ReadLine();

            Console.Write("Enter value for Unit Price: ");
            Actual_Sales = Console.ReadLine();

            Console.Write("Enter value for Quantity: ");
            Region = Console.ReadLine();
        }
        public void Display()
        {
            Console.Write("value for Medicine Code: " + Medicine_Code);

            Console.Write(" value for Medicine Name: " + Quantity_Sold);


            Console.Write(" value for Manufracture Name: " + Planned_Sales);


            Console.Write(" value for Unit Price: " + Actual_Sales);


            Console.Write(" value for Quantity: " + Region);
        }
    }
}
static void Main(string[] args)
{
    
}
