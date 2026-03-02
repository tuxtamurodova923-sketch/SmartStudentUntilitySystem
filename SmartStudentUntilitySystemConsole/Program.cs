{

    {
        Console.Clear();
        Console.WriteLine("===== Smart Student Utility System =====");
        Console.WriteLine("1. Student Helper");
        Console.WriteLine("2. Salary Calculator");
        Console.WriteLine("3. Password Tools");
        Console.WriteLine("4. Exit");

        Console.Write("Select an option (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {

            case 1:
                Console.Clear();
                Console.WriteLine("=== Student Helper ===");
                Console.WriteLine("1. O'rtacha bahoni hisoblash");
                Console.WriteLine("2. Eng yuqori bahoni topish");
                Console.WriteLine("3. Bahoni darajaga ajratish");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your command (1-4): ");
                int cmd1 = Convert.ToInt32(Console.ReadLine());

                switch (cmd1)
                {
                    case 1:
                        int[] grades = new int[5];
                        int sum = 0;

                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write($"Baho {i + 1}: ");
                            grades[i] = Convert.ToInt32(Console.ReadLine());
                            sum += grades[i];
                        }

                        double average = (double)sum / 5;
                        Console.WriteLine($"O'rtacha baho: {average}");
                        break;

                    case 2:
                        int[] grades2 = new int[5];

                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write($"Baho {i + 1}: ");
                            grades2[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        int max = grades2[0];

                        for (int i = 1; i < 5; i++)
                        {
                            if (grades2[i] > max)
                            {
                                max = grades2[i];
                            }
                        }

                        Console.WriteLine($"Eng yuqori baho: {max}");
                        break;

                    case 3:
                        Console.Write("Baho kiriting: ");
                        int grade = Convert.ToInt32(Console.ReadLine());

                        if (grade >= 90 && grade <= 100)
                            Console.WriteLine("A");
                        else if (grade >= 80)
                            Console.WriteLine("B");
                        else if (grade >= 70)
                            Console.WriteLine("C");
                        else if (grade >= 60)
                            Console.WriteLine("D");
                        else
                            Console.WriteLine("F");
                        break;
                }
                break;


            case 2:
                Console.Clear();
                Console.WriteLine("=== Salary Calculator ===");
                Console.WriteLine("1. Oylik maosh hisoblash");
                Console.WriteLine("2. Soliq hisoblash");
                Console.WriteLine("3. Yillik daromad");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your command (1-4): ");
                int cmd2 = Convert.ToInt32(Console.ReadLine());

                switch (cmd2)
                {
                    case 1:
                        Console.Write("Soatlik maosh: ");
                        double rate = Convert.ToDouble(Console.ReadLine());


                        Console.Write("Ish soati: ");
                        double hours = Convert.ToDouble(Console.ReadLine());

                        double salary = rate * hours;
                        Console.WriteLine($"Oylik maosh: {salary}");
                        break;

                    case 2:
                        Console.Write("Oylik maoshni kiriting: ");
                        double monthlySalary = Convert.ToDouble(Console.ReadLine());

                        double taxRate;

                        if (monthlySalary > 5000000)
                            taxRate = 0.12;
                        else
                            taxRate = 0.08;

                        double tax = Math.Round(monthlySalary * taxRate, 2);
                        Console.WriteLine($"Soliq: {tax}");
                        break;

                    case 3:
                        Console.Write("Oylik maoshni kiriting: ");
                        double monthly = Convert.ToDouble(Console.ReadLine());

                        double yearly = monthly * 12;
                        Console.WriteLine($"Yillik daromad: {yearly}");
                        break;
                }
                break;


            case 3:
                Console.Clear();
                Console.WriteLine("=== Password Tools ===");
                Console.WriteLine("1. Parol uzunligini tekshirish");
                Console.WriteLine("2. Kuchli yoki kuchsizligini aniqlash");
                Console.WriteLine("3. Parolni niqoblash");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your command (1-4): ");
                int cmd3 = Convert.ToInt32(Console.ReadLine());

                switch (cmd3)
                {
                    case 1:
                        Console.Write("Parolni kiriting: ");
                        string password = Console.ReadLine();

                        Console.WriteLine($"Uzunligi: {password.Length}");
                        break;

                    case 2:
                        Console.Write("Parolni kiriting: ");
                        string pass = Console.ReadLine();

                        bool hasUpper = false;
                        bool hasDigit = false;

                        for (int i = 0; i < pass.Length; i++)
                        {
                            if (char.IsUpper(pass[i]))
                                hasUpper = true;

                            if (char.IsDigit(pass[i]))
                                hasDigit = true;
                        }

                        if (pass.Length >= 8 && hasUpper && hasDigit)
                            Console.WriteLine("Strong");
                        else
                            Console.WriteLine("Weak");
                        break;

                    case 3:
                        Console.Write("Parolni kiriting: ");
                        string original = Console.ReadLine();

                        for (int i = 0; i < original.Length; i++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                        break;
                }
                break;

            case 4:
                Console.WriteLine("Dasturdan chiqildi...");
                break;

            default:
                Console.WriteLine("Noto‘g‘ri tanlov!");
                break;
        }
    }
}
