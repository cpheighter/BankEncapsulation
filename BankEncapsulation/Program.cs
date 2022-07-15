using BankEncapsulation;

bool isDone = false;
Console.WriteLine("Welcome to the Bank of Coders");
do 
{
  Console.WriteLine("Would you like to make a Deposit, a Withdraw, or check your Balance?");
  var input = Console.ReadLine();
    if (input == "Deposit" || input == "deposit" || input == "DEPOSIT")
    {
        Console.WriteLine("How much money would you like to deposit?");
        double amount = double.Parse(Console.ReadLine());
        var deposit = new BankAccount();
        deposit.Deposit(amount);
        Console.WriteLine("Would you like a receipt? Yes or No?");
        var answer1 = Console.ReadLine();
        if (answer1 == "Yes")
        {
            Console.WriteLine($"Your new balance is: {deposit.GetBalance()};");

        }
        Console.WriteLine("Would you like to do anything else? Yes or No");
        var answer2 = Console.ReadLine();
        if (answer2 == "No")
        {
            isDone = true;
        }
        else if (answer2 == "Yes")
        {
            isDone = false;
        }
        else
        {
            Console.WriteLine("Invaild Input. Try Again.");
        }

    }

    else if (input == "Withdraw" || input == "withdraw" || input == "WITHDRAW")
    {
        Console.WriteLine("How much money would you like to withdraw?");
        var amount = double.Parse(Console.ReadLine());
        var withdraw = new BankAccount();
        withdraw.Withdraw(amount);
        Console.WriteLine("Would you like a receipt? Yes or No?");
        var answer3 = Console.ReadLine();
        if (answer3 == "Yes")
        {
            Console.WriteLine($"Your new balance is {withdraw.GetBalance()}");
        }
        Console.WriteLine("Would you like to do anything else? Yes or No");
        var answer4 = Console.ReadLine();
        if (answer4 == "No")
        {
            isDone = true;
        }
        else if (answer4 == "Yes")
        {
            isDone = false;
        }
        else
        {
            Console.WriteLine("Invaild Input. Try Again.");
        }
    }

    else if (input == "Balance" || input == "balance" || input == "BALANCE")
    {
        var balance = new BankAccount();
        balance.GetBalance();
        Console.WriteLine($"Your new balance is {balance.GetBalance()}");

        Console.WriteLine("Would you like to do anything else? Yes or No");
        var answer5 = Console.ReadLine();
        if (answer5 == "No")
        {
            isDone = true;
        }
        else if (answer5 == "Yes")
        {
            isDone = false;
        }
        else
        {
            Console.WriteLine("Invaild Input. Try Again.");
        }
    }

    else
    {
        Console.WriteLine("Invaild Input. Try Again.");
    }
} while (isDone == false);

Console.WriteLine("Thank you for using the Bank of the Coders. HAVE A NICE DAY :)");