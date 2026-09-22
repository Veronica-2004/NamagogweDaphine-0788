Public Class BankAccount
    'Private balance field
    Private _balance As Decimal

    'Constructor
    Public Sub New(initialBalance As Decimal)
        If initialBalance < 0D Then

            _balance = 0
        Else
            _balance = initialBalance
        End If

    End Sub

    'Public property for accessing the balance
    'Public ReadOnly Property Balance As Decimal
    Get
    Return _balance
    End Get
    End Property

    'Deposit method
    Public Sub Deposit(amount As Decimal)
        If amount < 0 Then
            Console.WriteLine("Deposit amount cannot be negative.")
        Else
            _balance += amount
            Console.WriteLine("Deposit Successful.")
        End If

    End Sub

    'Withdraw method
    Public Sub Withdraw(amount As Decimal)
        If amount < 0 Then
            Console.WriteLine("Withdrawal amount cannot be negative.")
        ElseIf amount > _balance Then
            Console.WriteLine("Withdrawal denied. Insufficient balance.")
        Else
            _balance -= amount

            Console.WriteLine("Withdrawal successful.")



        End If


    End Sub

End Class
