using UserRegistration;

Pattern pattern = new Pattern();
Console.WriteLine("Enter the First Name: ");
string FName = Console.ReadLine();
Console.WriteLine("Enter the Last Name: ");
string LName = Console.ReadLine();
Console.WriteLine("Enter the Email ID: ");
string Email = Console.ReadLine();
Console.WriteLine("Enter the Mobile No: ");
string Mobile = Console.ReadLine();
Console.WriteLine("----------------------------------------");
pattern.validateFName(FName);
pattern.validateLName(LName);
pattern.validateEmail(Email);
pattern.validateMobile(Mobile);
Console.WriteLine("----------------------------------------");