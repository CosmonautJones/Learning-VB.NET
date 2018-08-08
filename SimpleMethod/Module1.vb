Module Module1

    Sub Main()

        Console.WriteLine("The Name Game")

        Console.Write("What's your first name? ")
        Dim firstName As String = GetReversedString(Console.ReadLine())

        Console.Write("What's your last name? ")
        Dim lastName As String = GetReversedString(Console.ReadLine())

        Console.Write("In what city were you born? ")
        Dim city As String = GetReversedString(Console.ReadLine())

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

End Module
