namespace MyFirstApp
{
    public class Calc
    {
        //Constructor
        public Calc()
        {

        }

        public void Eligiblity()
        {
            string age = Console.ReadLine();

            //Console.WriteLine(age);

            if (Convert.ToInt32(age) >= 18)
            {
                Console.WriteLine("Eligible for voting");
            }
            else
            {
                Console.WriteLine("Not Eligible for vote");
            }
        }

        public void Calculator(string val)
        {
            if (val == "Add")
            {
                Add();
            }
            else if (val == "Minus")
            {
                Minus();
            }
            else if (val == "Multiply")
            {
                Multiply();
            }
            else
            {
                Division();
            }
        }

        private void Add()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int c = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine(c);
        }


        private void Minus()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int c = Convert.ToInt32(a) - Convert.ToInt32(b);
            Console.WriteLine(c);
        }


        private void Multiply()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int c = Convert.ToInt32(a) * Convert.ToInt32(b);
            Console.WriteLine(c);
        }


        private void Division()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int c = Convert.ToInt32(a) / Convert.ToInt32(b);
            Console.WriteLine(c);
        }

    }
}
