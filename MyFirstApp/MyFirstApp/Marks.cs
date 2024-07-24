namespace MyFirstApp
{
    public class Marks
    {

        public void Result()
        {
            string subject1, subject2, subject3, subject4, subject5;

            subject1 = Console.ReadLine();
            subject2 = Console.ReadLine();
            subject3 = Console.ReadLine();
            subject4 = Console.ReadLine();
            subject5 = Console.ReadLine();

            int totalMarks = Convert.ToInt32(subject1) + Convert.ToInt32(subject2) + Convert.ToInt32(subject3) + Convert.ToInt32(subject4) + Convert.ToInt32(subject5);

            Console.WriteLine("Toatal Marks-" + totalMarks);

            CalculatePercentage(totalMarks, 5);
        }

        private void CalculatePercentage(int totalMarks, int totlaSubjects)
        {
            double percentage = (double)totalMarks / totlaSubjects;

            Console.WriteLine("Percentage-" + percentage);

            if (percentage >= 80)
            {
                Console.WriteLine("Pass" + percentage);
                Console.WriteLine("I Division");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Pass" + percentage);
                Console.WriteLine("II Division");
            }
            else if (percentage >= 33)
            {
                Console.WriteLine("Pass" + percentage);
                Console.WriteLine("III Division");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
