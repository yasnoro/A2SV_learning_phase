// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to grade calculator!");
Console.WriteLine("Please, enter your name: ");
string name = Console.ReadLine();
Console.WriteLine("Enter the number of subjects you have taken: ");
int sub_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Now you are going to enter subject's name and grade for each of the subjects you took, please proceed..");
Dictionary<string, int> sub =
    new Dictionary<string, int>();
int ind = 0;
while (ind<sub_num)
{
    Console.WriteLine("Enter the name of subject:");
    string subject = Console.ReadLine();
    Console.WriteLine("Enter the grade:");
    int sub_grade = Convert.ToInt32(Console.ReadLine());

    if (sub_grade <= 100 & sub_grade>=0) {
        sub[subject] = sub_grade;
        ind++;
    }
    else{
        Console.WriteLine("The grade must be between 0 and 100, Please enter again");
    }
    
}
Console.WriteLine($"Student's Name: {name}");
foreach( KeyValuePair<string, int> kvp in sub )
        {
            Console.WriteLine($"--> {kvp.Key}: {kvp.Value}");
        }
Console.WriteLine($"Average result: {average(sub, sub_num)}");
Console.WriteLine("Thanks for using our service");

int average (Dictionary<string, int> sub, int sub_num)
   {
      int sum = 0;
      foreach( KeyValuePair<string, int> kvp in sub )
        {
            sum += kvp.Value;
        }
      return sum/sub_num;
   }


