using UserRegistration;

Pattern pattern = new Pattern();
Console.WriteLine("Enter the First Name: ");
string FName = Console.ReadLine();
pattern.validateFName(FName);