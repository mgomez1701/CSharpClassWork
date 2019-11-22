using System;
using System.Collections.Generic;
using System.Text;

namespace Build_Inheritance_Code_Challange
{
    class Bill
    {
        public double Subtotal { get; set; } //prop tab tab shortcut
        public double TaxRate { get; set; }
       
        public Bill ()
        {

        }

        public Bill (double taxRate, double subTotal)
        {
            this.TaxRate = taxRate;
            this.Subtotal = subTotal;
        }

       

        public virtual double CalcTotal ()
        {
            return (Subtotal * (1 + TaxRate));
           
        }
        public void Pay() // this is static because its not dealing with a specific obkject
        {
            Console.WriteLine($"${CalcTotal()}");

        }

    }
}
