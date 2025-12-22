namespace Day4OOPDemo
{
    public class FareCalculator
    {
        public double CalculateFinalFare(
            int age,
            bool isGovEmployee,
            double fareAfterClass,
            out string discountType)
        {
            double discount = 0;
            discountType = "No Discount";

            // if - else if ladder with logical operators
            if (age >= 60)
            {
                discount = fareAfterClass * 0.30;
                discountType = "Senior Citizen (30%)";
            }
            else if (isGovEmployee)
            {
                discount = fareAfterClass * 0.15;
                discountType = "Government Employee (15%)";
            }
            else if (age >= 5 && age <= 12)
            {
                discount = fareAfterClass * 0.50;
                discountType = "Child Discount (50%)";
            }

            return fareAfterClass - discount;
        }
    }
}
