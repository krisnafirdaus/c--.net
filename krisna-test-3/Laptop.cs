using System;
namespace krisna_test_3
{
	public class Laptop
	{
		private string brand;
		private string model;

		public string Brand
		{
			get { return brand; }
			set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public void LaptopDetails()
		{
			Console.WriteLine("Brand: " + Brand);
			Console.WriteLine("Model: " + Model);
        }

		public void LaptopKeyboard()
		{
            Console.WriteLine("Type Using Keyboard");
        }

        public void MotherBoardInformation()
        {
            Console.WriteLine("Motherboard Information");
        }

        public void InternalProcessor()
        {
            Console.WriteLine("InternalProcessor Information");
        }
    }
}

