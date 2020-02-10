using System;

namespace AccessTernary {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine($"The Cube of 17 is {Program.cubed(17)}");
            Console.WriteLine(Customer.PrintNextId());
            var cust1 = new Customer("Max Technical Training");
            var cust2 = new Customer("Amazon");
            var cust3 = new Customer("Target");
            cust1.NationalAccount("yes");
            var order1 = new Order { Id = 1, Amount = 1000, Customer = cust1 };

        }
        static int cubed(int nbr) {
            return nbr * nbr * nbr;
        }
    }
}
