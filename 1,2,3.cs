namespace methods
{
    internal class Program
    {
        //TASK---1

        //static void Main(string[] args)
        //{
        //    int number = 9;
        //    int sum = 0;
        //    int result = SumofNumbers(number, sum);
        //    Console.WriteLine($"Sum of even numbers is - {result}");
        //}

        //static int SumofNumbers(int number, int sum)
        //{

        //    for (int i = 0; i < number; i++)
        //    {

        //        if (i % 2 == 0)
        //        {
        //            sum += i;
        //        }
        //    }
        //    return sum;

        //}

        
        //TASK---2

        //static void Main(string[] args)
        //{
        //    string name = "Code Academy";
        //    string result = DeleteSpace(name);
        //    Console.WriteLine(result);
        //}

        //static string DeleteSpace(string name)
        //{
        //    char[] nameWithoutspace = new char[name.Length];
        //    int count = 0;

        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        if (name[i] != ' ')
        //        {
        //            nameWithoutspace[count] = name[i];
        //            count++;
        //        }
        //    }
        //    return new string(nameWithoutspace, 0, count);
        //}


        //TASK---3

        static void Main(string[] args)
        {
            string name = "Code Academy";
            InitialLetters(name);

        }

        static void InitialLetters(string name)
        {
            bool space = true;

            for (int i = 0; i < name.Length; i++)
            {

                if (name[i] == ' ')
                {
                    space = true;
                }
                else if (space)
                {
                    Console.Write(name[i] + " ");
                    space = false;
                }
            }
        }











    }
}
