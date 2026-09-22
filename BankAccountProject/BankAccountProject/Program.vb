Imports System

Module Program
    Sub Main()

        Dim account As New BankAccount(1000D)

        Console.WriteLine("Initial Balance: " & account.Balance)

        account.Deposit(500D)
        Console.WriteLine("Balance after deposit: " & account.Balance)

        account.Withdraw(300D)
        Console.WriteLine("Balance after withdrawal: " & account.Balance)

        account.Deposit(-100D)

        account.Withdraw(2000D)

        Console.WriteLine()
        Console.WriteLine("Press Enter to exist.")
        Console.ReadLine()

    End Sub
End Module
