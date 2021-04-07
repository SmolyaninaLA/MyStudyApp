using System;

class MainClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public abstract class Pay
    {

        public static decimal Sum { get; set; }
        public static int NomOrder { get; set; }

        public Pay(decimal sum, int nomorder)
        {
            Sum = sum;
            NomOrder = nomorder;
        }

        public abstract void PayOrder();

    }
    public class PayOrderCustomer : Pay
    {
        private string NomCard;


        public string Nomcard
        {
            set
            {
                if (value == null)
                {
                    NomCard = "no";
                }
                else
                {
                    NomCard = value;
                }
            }
            get
            {
                return NomCard;
            }
        }



        public PayOrderCustomer(string nomcard) : base(Sum, NomOrder)
        {
            this.Nomcard = nomcard;
        }



        public override void PayOrder()
        {

        }

        PayNal PayN;
        public PayOrderCustomer(PayNal pn) : base(Sum, NomOrder)
        {
            PayN = pn;
        }
    }

    public class PayNal
    {
        //оплата наличкой
    }

    public abstract class Delivery
    {
        public abstract string Address { get; }
        public DateTime DateDelivery;
    }

    public class HomeDelivery : Delivery
    {
        protected string address;

        public override string Address
        {
            get
            {
                return address;
            }

        }


        public HomeDelivery() : base()
        {

        }

    }

    public class PickPointDelivery : Delivery
    {
        protected string address;

        public override string Address
        {
            get
            {
                return address;
            }

        }

        DeliveryMode delivery;
        public PickPointDelivery() : base()
        {

        }

        public int PPointDelivery(DeliveryMode pDelivery)
        {
            int Return = 1;
            delivery = pDelivery;

            return Return;
        }

    }

    public class ShopDelivery : Delivery
    {
        protected string address;

        public override string Address
        {
            get
            {
                return address;
            }

        }

        public ShopDelivery() : base()
        {

        }
    }

    public class DeliveryMode
    {

    }

    class Order<TDelivery, TPay, TTov>
        where TDelivery : Delivery
        where TPay : Pay
        where TTov : Tov
    {
        public TDelivery Delivery;

        public TPay Pay;

        public TTov Tov;

        public int Number;

        public string Description;


        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }


    }

    public abstract class Tov
    {
       public int TypeTov;
       public string articul;
       public string nTov;
       public decimal price;
    }

  
}
