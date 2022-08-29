using UserRegistration;

Pattern pattern = new Pattern();
Console.WriteLine("Enter the First Name: ");
string FName = Console.ReadLine();
Console.WriteLine("Enter the Last Name: ");
string LName = Console.ReadLine();
pattern.validateFName(FName);
pattern.validateLName(LName);