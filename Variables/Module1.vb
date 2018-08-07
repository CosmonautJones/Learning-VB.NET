Module Module1

    Sub Main()

        'Dim x As Integer
        'Dim y As Integer

        'x = 7
        'y = x + 3

        'Console.WriteLine(y)
        'Console.ReadLine()

        Console.WriteLine("What is your name?")
        Console.Write("Type your first name here: ")
        Dim myFirstName As String

        myFirstName = Console.ReadLine()

        Console.Write("Type your last name here: ")
        Dim myLastName As String

        myLastName = Console.ReadLine()

        Console.WriteLine("Hello, " & myFirstName & " " & myLastName)
        Console.ReadLine()

    End Sub

End Module
