// Example 1: Incorrect or No Output
// Problem: Missing output statement
int a = 10;
int b = 20;
// Console.WriteLine(a + b); // Uncomment this line to fix

// Fixed:
Console.WriteLine(a + b); // Outputs: 30

// Example 2: Formatting Issues
// Problem: Incorrect string concatenation
int age = 25;
Console.WriteLine("Your age is " + age + " years"); // Works but not ideal
Console.WriteLine($"Your age is {age} years"); // Fixed with string interpolation

// Example 3: Input/Output Mismatch
// Problem: String input parsed incorrectly
Console.WriteLine("Enter a number:");
string input = Console.ReadLine();
int number = int.Parse(input);
Console.WriteLine($"You entered: {number}");

// Example 4: Infinite Loops
// Problem: Missing termination condition
int count = 0;
while (count < 5) {
    Console.WriteLine($"Count: {count}");
    count++; // Ensure increment to fix
}

// Example 5: Console Closes Immediately
// Problem: No pause at the end
Console.WriteLine("Hello, World!");
Console.WriteLine("Press Enter to exit...");
Console.ReadLine(); // Keeps console open
