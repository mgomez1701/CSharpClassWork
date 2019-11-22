using System;

namespace Build_Inheritance_Code_Challange
{
    class Program
    {
        static void Main(string[] args)
        {
            //  In the Main, write a code snippet to create a Bill that has a subtotal of 15.80 and a tax rate of 0.06 then pass it to the Pay method. (will print: $16.748)

            Bill bill = new Bill (  15.80,  0.06 );
            Tippable_Bill tippable = new Tippable_Bill(8.50, 0.06, 2.00);

            bill.Pay();
            tippable.Pay();

        }



    }
}
