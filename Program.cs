namespace CSharpCoding
{
    internal class Program
    {
        static void Main()
        {
            /*
            // Encapsulation01 //
            Console.Write("Enter initial balance: ");
            double initialBalance = Convert.ToDouble(Console.ReadLine());
            Encapsulation01 account = new Encapsulation01(initialBalance);

            Console.Write("Enter deposit amount: ");
            double deposit = Convert.ToDouble(Console.ReadLine());
            account.Deposit(deposit);

            Console.Write("Enter withdrawal amount: ");
            double withdrawal = Convert.ToDouble(Console.ReadLine());
            account.Withdraw(withdrawal); */






            /*
            // Data Hiding //
            DataHiding student = new DataHiding();

            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Roll Number: ");
            student.RollNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nStudent Details:\nName: {student.Name}\nRoll No: {student.RollNo}"); */






            /*
            // Construction Overloading //
            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author: ");
            string author = Console.ReadLine();

            Console.Write("Enter ISBN (or press Enter to skip): ");
            string isbn = Console.ReadLine();

            ConstructionOverloading book;
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
                book = new ConstructionOverloading();  // Default constructor
            else if (string.IsNullOrWhiteSpace(isbn))
                book = new ConstructionOverloading(title, author);  // Constructor with Title & Author
            else
                book = new ConstructionOverloading(title, author, isbn);  // Constructor with all details

            book.Display(); */





            /*
            // Calculating Area //
            Console.Write("Enter radius of Circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Shape circle = new Circle(radius);
            Console.WriteLine($"Area of Circle: {circle.CalculateArea()}");

            Console.Write("\nEnter length of Rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width of Rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Shape rectangle = new Rectangle(length, width);
            Console.WriteLine($"Area of Rectangle: {rectangle.CalculateArea()}"); */






            /*
            // Vehicle System //
            Console.Write("Enter vehicle type (Car/Bike): ");
            string type = Console.ReadLine().ToLower();

            Vehicle vehicle;

            if (type == "car")
                vehicle = new Car();
            else if (type == "bike")
                vehicle = new Bike();
            else
            {
                Console.WriteLine("Invalid vehicle type. Defaulting to Vehicle.");
                vehicle = new Vehicle();
            }

            vehicle.Start();  // Demonstrates method overriding (polymorphism) */








            /*
            // Virtual Machine //
            Console.Write("Enter role (Student/Teacher): ");
            string role = Console.ReadLine().ToLower();

            Person person;

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (role == "student")
            {
                Console.Write("Enter Roll Number: ");
                int rollNo = Convert.ToInt32(Console.ReadLine());
                person = new Student { Name = name, Age = age, RollNo = rollNo };
            }
            else if (role == "teacher")
            {
                Console.Write("Enter Subject: ");
                string subject = Console.ReadLine();
                person = new Teacher { Name = name, Age = age, Subject = subject };
            }
            else
            {
                Console.WriteLine("Invalid role. Defaulting to Person.");
                person = new Person { Name = name, Age = age };
            }

            person.GetDetails();  // Demonstrates method overriding and polymorphism */









            /*
            // Calculator //
            Calculator calc = new Calculator();

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter third number (or press Enter to skip): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double num3))
                Console.WriteLine($"Sum: {calc.Add((int)num1, (int)num2, (int)num3)}");
            else if (num1 % 1 == 0 && num2 % 1 == 0)
                Console.WriteLine($"Sum: {calc.Add((int)num1, (int)num2)}");
            else
                Console.WriteLine($"Sum: {calc.Add(num1, num2)}"); */






            /*
            // IPlayable //
            Console.Write("Enter player type (Music/Video): ");
            string type = Console.ReadLine().ToLower();

            IPlayable player = type == "music" ? new MusicPlayer() : new VideoPlayer();
            player.Play();  // Demonstrates interface-based polymorphism */








            /*
            // IPrintable //
            Console.Write("Enter report content: ");
            string content = Console.ReadLine();

            Report report = new Report(content);

            Console.Write("Choose action (Print/Save): ");
            string action = Console.ReadLine().ToLower();

            if (action == "print")
                report.Print();
            else if (action == "save")
                report.SaveToFile();
            else
                Console.WriteLine("Invalid action."); */







            /* 
            // Access System //
            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Role (Admin/Customer): ");
            string role = Console.ReadLine().ToLower();

            User user = role == "admin" ? new Admin { Username = username, Role = "Admin" } :
                       role == "customer" ? new Customer { Username = username, Role = "Customer" } :
                       new User { Username = username, Role = "Guest" };

            user.AccessControl();  // Demonstrates method overriding and polymorphism */







            // Complex Number //
            /* Console.Write("Enter real part of the first complex number: ");
            double real1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter imaginary part of the first complex number: ");
            double imaginary1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter real part of the second complex number: ");
            double real2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter imaginary part of the second complex number: ");
            double imaginary2 = Convert.ToDouble(Console.ReadLine());

            ComplexNumber c1 = new ComplexNumber(real1, imaginary1);
            ComplexNumber c2 = new ComplexNumber(real2, imaginary2);

            ComplexNumber result = c1 + c2; // Using overloaded + operator

            Console.WriteLine($"The sum of the complex numbers is: {result}"); */








            // Department //
            /* Console.Write("Enter Department Name: ");
            string deptName = Console.ReadLine();

            Console.Write("Enter Manager Name: ");
            string managerName = Console.ReadLine();

            Department original = new Department { DeptName = deptName, Manager = new Manager { Name = managerName } };

            Department shallowCopy = original.ShallowCopy();
            Department deepCopy = original.DeepCopy();

            // Modify original to see effect on copies
            Console.Write("Enter New Manager Name: ");
            original.Manager.Name = Console.ReadLine();

            Console.WriteLine("\nAfter modifying original:");
            Console.WriteLine($"Original Manager: {original.Manager.Name}");
            Console.WriteLine($"Shallow Copy Manager: {shallowCopy.Manager.Name}"); // Changes (reference copied)
            Console.WriteLine($"Deep Copy Manager: {deepCopy.Manager.Name}"); // Remains unchanged */






            // Bank //
            /* Console.Write("Enter Interest Rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Bank.SetInterestRate(rate); // Setting static interest rate

            Console.Write("Enter first account holder name: ");
            Bank acc1 = new Bank { AccountHolder = Console.ReadLine() };

            Console.Write("Enter second account holder name: ");
            Bank acc2 = new Bank { AccountHolder = Console.ReadLine() };

            Console.WriteLine("\nAccount Details:");
            acc1.ShowDetails();
            acc2.ShowDetails(); // Same interest rate applies to all accounts */





            // Security System //
            /* Console.Write("Set Security System Password: ");
            string password = Console.ReadLine();

            SecuritySystem system = new SecuritySystem(password);
            system.Authenticate(); */







            // Button //
            /* Button btn = new Button();

            // Subscribe an event handler
            btn.OnClick += (msg) => Console.WriteLine($"Button Clicked! Message: {msg}");

            Console.Write("Enter a message for the button click event: ");
            string userMessage = Console.ReadLine();

            btn.Click(userMessage); // Trigger event with dynamic input */






            // Vehicle Factory //
            /* Console.Write("Enter vehicle type (Car/Bike): ");
            string vehicleType = Console.ReadLine();

            try
            {
                IVehicle vehicle = VehicleFactory.GetVehicle(vehicleType);
                vehicle.Drive();  // Call Drive() method correctly
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            } */





            // ILogger //
            /* Console.Write("Enter log message: ");
            string message = Console.ReadLine();

            ILogger logger = new FileLogger();
            ILogger timestampLogger = new TimestampLogger(logger);
            ILogger errorLogger = new ErrorLogger(timestampLogger);

            errorLogger.Log(message); // Logs message with timestamp and error tag */






            // Configuration Manager //
            /* Console.WriteLine("Press Enter to get Configuration Manager instance...");
            Console.ReadLine();

            ConfigurationManager config1 = ConfigurationManager.GetInstance();
            config1.ShowMessage();

            ConfigurationManager config2 = ConfigurationManager.GetInstance();
            Console.WriteLine(config1 == config2 ? "Same Instance" : "Different Instances"); */







            // Notification Service //
            /* NotificationService service = new NotificationService();

            service.Subscribe(new EmailNotifier());
            service.Subscribe(new SMSNotifier());

            Console.Write("Enter notification message: ");
            string message = Console.ReadLine();

            service.NotifyAll(message); // Notifies all observers */






            // Shopping Cart //
            /* ShoppingCart cart = new ShoppingCart();

            Console.Write("Enter total price: ");
            double total = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose Discount Strategy:\n1. No Discount\n2. Percentage Discount\n3. Fixed Amount Discount");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 2:
                    Console.Write("Enter discount percentage: ");
                    double percentage = Convert.ToDouble(Console.ReadLine());
                    cart.SetDiscountStrategy(new PercentageDiscount(percentage));
                    break;
                case 3:
                    Console.Write("Enter fixed discount amount: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    cart.SetDiscountStrategy(new FixedAmountDiscount(amount));
                    break;
                default:
                    cart.SetDiscountStrategy(new NoDiscount());
                    break;
            }

            Console.WriteLine($"Final Price: {cart.CalculateTotal(total)}"); */
        }
    }
}
