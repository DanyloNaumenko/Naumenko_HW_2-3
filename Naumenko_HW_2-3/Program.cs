using Naumenko_HW_2_3;
using System.Text.RegularExpressions;

User user;
string? _firstName;
string? _lastName;
int _age;
Gender _gender;

try 
{
    while (true)
    {

        Console.Write("Enter your first name: ");
        _firstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        _lastName = Console.ReadLine();

        Console.Write("Enter your age: ");
        _age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Choose your gender (0 - Male, 1 - Female): ");
        switch (Console.ReadLine())
        {
            case ("0"):
                {
                    _gender = Gender.Male;
                    break;
                };
            case ("1"):
                {
                    _gender = Gender.Female;
                    break;
                };
            default:
                {
                    _gender = Gender.Unknown;
                    break;
                };
        }

        if (Validation(_firstName, _lastName, _age))
        {
            user = CreateUser(_firstName!, _lastName!, _age, _gender);
            break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Validation is failed, try again!");
            continue;
        }
    }
    Console.WriteLine(user.ToString());
} catch (Exception) { Console.WriteLine("Something went wrong!"); }



User CreateUser(string firstName, string lastName, int age, Gender gender)
{
    var user = new User(age);
    user.FirstName = firstName;
    user.LastName = lastName;
    user.Gender = gender;

    return user;
}
bool Validation(string? firstName, string? lastName, int age)
{
    Regex regex = new Regex("[a-z|A-Z]");
    if(firstName != null && lastName != null)
    {
        return regex.IsMatch(firstName) && regex.IsMatch(lastName) && age >= 4;
    }
    else { return false; }
}
