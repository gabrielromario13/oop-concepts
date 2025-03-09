using OOP.prac;

// OOP Concepts:

// 1. ENCAPSULATION
var myAccount = new BankAccount(1000);

// It won't be possible to access the private _balance variable directly like this:
//var balance = myAccount._balance; (Cannot access private field '_balance' here)

// Only by calling the public methods:
Console.WriteLine("Balance: " + myAccount.GetBalance());

myAccount.Deposit(500);
Console.WriteLine("Balance: " + myAccount.GetBalance());

myAccount.Withdraw(2000);
Console.WriteLine("Balance: " + myAccount.GetBalance());

// 2. INHERITANCE

// Single inheritance
var dog = new Dog();
dog.Eat();
dog.Bark();

// Multi-level inheritance
var horse = new Horse();
horse.Eat();
horse.Run();
horse.Gallop();

// Hierarchical inheritance
var eagle = new Eagle();
var penguin = new Penguin();
eagle.Fly();
eagle.Hunt();
penguin.Fly();
penguin.Swim();

// Multiple inheritance using interfaces
var myClass = new MyClass();
myClass.Method1();
myClass.Method2();

// 3. POLYMORPHISM

// Method Overloading (Compile-time)
var mult = Calculator.Mathfunct(2, 3);
var add = Calculator.Mathfunct(2, 3, 4);
var sub = Calculator.Mathfunct(2, 3, 4, 5);

Console.WriteLine("Multiplication: " + mult);
Console.WriteLine("Addition: " + add);
Console.WriteLine("Subtraction: " + sub);

// Method Overriding (Runtime)
var vehicle = new Vehicle();
var motorcycle = new Motorcycle();
var car = new Car();

vehicle.MakeSound(); 
motorcycle.MakeSound();    
car.MakeSound();

// 4. ABSTRACTION

// 4.1 Using Abstract Classes
// Creating reference of Shape class
// Which refer to Square class instance
Shape sh = new Square(4);

double result = sh.Area();

Console.Write("{0}", result);

// 4.2 Using Interfaces
IStudent geeky = new Geeky();
      
geeky.FavSubject(); 

Console.ReadKey();