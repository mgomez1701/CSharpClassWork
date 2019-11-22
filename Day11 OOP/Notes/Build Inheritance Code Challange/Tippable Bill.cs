using System;
using System.Collections.Generic;
using System.Text;

namespace Build_Inheritance_Code_Challange
{
    class Tippable_Bill: Bill 
    {
        public double Tip { get; set; }

        public Tippable_Bill ()
        {

        }
        public Tippable_Bill(double subTotal, double taxRate, double tip) : base(taxRate,subTotal)
        {
            this.Tip = tip; 
        }
        public override double CalcTotal()
        {
            return base.CalcTotal() + Tip;


        }

    }


}
