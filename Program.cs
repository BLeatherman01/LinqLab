namespace Linq_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));





            //Find the Minimum value 
            int lowest = nums.Min();
            Console.WriteLine(lowest);
            //Find the Max value
            int highest = nums.Max();
            Console.WriteLine(highest);
            //Find the maximum value less than 10000
            int maxValuesBelow10000 = nums.Where(nums => nums < 10000).Max();
            Console.WriteLine(maxValuesBelow10000);
            //Find all values between 10 and 100
            List<int> valuesBetween10And100 = nums.Where(nums => nums > 10 && nums < 100).ToList();
            PrintList(valuesBetween10And100);
            //Final all values between 100000 and 999999 inclusive
            List<int> valuesbetween100000And999999 = nums.Where(nums => nums >= 100000 && nums <= 999999).ToList();
            PrintList(valuesbetween100000And999999);
            //Count all the even numbers
            int allEven = nums.Count(nums => nums % 2 == 0);
            Console.WriteLine(allEven);
            //Order the list by descending order, most to least 
            List<int> ordernums = nums.OrderByDescending(n => n).ToList();
            PrintList(ordernums);


            
            
            
            
            List<Student> studentsOver21 = students.Where(student => student.Age >= 21).ToList();
            PrintList2(studentsOver21);
            Console.WriteLine();

            int oldestAge = students.Max(s => s.Age);
            Student oldestName  = students.Where(s => s.Age == oldestAge).First();
            Console.WriteLine($"The oldest student, age : {oldestName.Name}, {oldestAge}");
            Console.WriteLine();

            int youngestAge = students.Min(s => s.Age);
            Student youngestName = students.Where(s => s.Age == youngestAge).First();
            Console.WriteLine($"The youngest student, age : {youngestName.Name}, {youngestAge}");
            Console.WriteLine();


           
            List<Student> oldestNameUnder25 = students.Where(s => s.Age < 25).ToList();
            int oldestAgeUnder25 = oldestNameUnder25.Max(s => s.Age);
            Student oldUnder25 = students.Where(s => s.Age == oldestAgeUnder25).First();
            Console.WriteLine($"The oldest student under 25 : {oldUnder25.Name}");
            Console.WriteLine();
          
           

            List<Student> studentsOver21Even = students.Where(student => student.Age > 21 && student.Age % 2 == 0).ToList();
            PrintList2(studentsOver21Even);
            Console.WriteLine();
            
            List<Student> teenageStudents = students.Where(student => student.Age >= 13 && student.Age <= 19).ToList();
            PrintList2(teenageStudents);
            Console.WriteLine();


            string[] vowels = { "A", "E", "I", "O", "U" };
            List<Student> studentNameStartingWithVowel = students.Where(student => vowels.Contains(student.Name.Substring(0, 1)) == true).ToList();
            PrintList2(studentNameStartingWithVowel);
            Console.WriteLine();


            List<Student> orderByAcesending = students.OrderBy(student => student.Age).ToList();
            PrintList2(orderByAcesending);
            Console.WriteLine();

        }
        public static void PrintList(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                int s = input[i];
                Console.WriteLine(s);
            }
        }
        public static void PrintList2(List<Student> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                Student s = input[i];
                Console.WriteLine(s.Name);
            }
        }
        
        
    }
}