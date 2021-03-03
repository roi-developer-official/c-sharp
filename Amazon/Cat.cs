using System;
namespace Amazon
{
    public class Cat : Animale
    {

        public void Pet()
        {
            Console.WriteLine("The Cat Is been Petted");
        }
        public void OfferVoucher()
        {
            CalculateAge();
        }
    }
}
