Module Module1

    Sub Main()

        Console.WriteLine("The Name Game")

        Console.Write("What's your first name? ")
        Dim firstName As String = Console.ReadLine()

        Console.Write("What's your last name? ")
        Dim lastName As String = Console.ReadLine()

        Console.Write("In what city were you born? ")
        Dim city As String = Console.ReadLine()

        ReverseString(firstName)
        ReverseString(lastName)
        ReverseString(city)

        DisplayResult(firstName, lastName, city)
        Console.ReadLine()

    End Sub

    Sub DisplayResult(reversedFirstName As String,
                      reversedLastName As String,
                      reversedCity As String)
        Console.Write("Results: ")
        Console.Write("{0} {1} {2}",
                      reversedFirstName,
                      reversedLastName,
                      reversedCity)
    End Sub

    Function GetReversedString(message As String) As String
        Dim messageArray As Char() = message.ToCharArray()
        Array.Reverse(messageArray)
        Return String.Concat(messageArray)
    End Function

    ' ByRef manipulates the actual value of the "bucket" in the actual memory location
    Sub ReverseString(ByRef message As String)
        Dim messageArray As Char() = message.ToCharArray()
        Array.Reverse(messageArray)
        message = String.Concat(messageArray)
    End Sub

End Module
