namespace Assignment_01_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine(Enum.GetValues(typeof(WeekDays)));
            //Console.WriteLine("weekDays are:");
            //foreach (var day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Q2
            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();
            //Console.WriteLine($"your choise is {input}");
            //switch (input)
            //{
            //    case "Spring":
            //        Console.WriteLine("Spring: March to May");
            //        break;
            //    case "Summer":
            //        Console.WriteLine("Summer: June to August");
            //        break;
            //    case "Autumn":
            //        Console.WriteLine("Autumn: September to November");
            //        break;
            //    case "Winter":
            //        Console.WriteLine("Winter: December to February");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid season.");
            //        break;
            //}
            #endregion

            #region Q3
            //Permissions userPermissions = Permissions.None;

            //// Add permissions
            //userPermissions |= Permissions.Read;
            //userPermissions |= Permissions.Write;

            //// Remove a permission
            //userPermissions &= ~Permissions.Write;

            //// Check if a permission exists
            //if ((userPermissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("Read permission exists.");
            //}
            //else
            //{
            //    Console.WriteLine("Read permission does not exist.");
            //}

            //// Display current permissions
            //Console.WriteLine($"Current Permissions: {userPermissions}");
            #endregion

            #region Q4
            //Console.WriteLine("Enter a color name:");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Colors color))
            //{
            //    Console.WriteLine($"{color} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is not a primary color.");
            //}
            #endregion
        }
    }
}
