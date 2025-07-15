
Module Module1

    Sub Main()
        Dim Cards(21) As String
        Dim Piles(3, 7) As String
        Dim PileChoice As Integer
        Dim MagicCard As String

        Cards(1) = "7 clubs"
        Cards(2) = "4 clubs"
        Cards(3) = "2 diamonds"
        Cards(4) = "5 spades"
        Cards(5) = "7 spades"
        Cards(6) = "3 clubs"
        Cards(7) = "4 spades"
        Cards(8) = "Ace diamonds"
        Cards(9) = "Ace spades"
        Cards(10) = "5 clubs"
        Cards(11) = "6 diamonds"
        Cards(12) = "6 spades"
        Cards(13) = "5 diamonds"
        Cards(14) = "6 clubs"
        Cards(15) = "3 diamonds"
        Cards(16) = "Ace clubs"
        Cards(17) = "2 spades"
        Cards(18) = "4 diamonds"
        Cards(19) = "7 diamonds"
        Cards(20) = "3 spades"
        Cards(21) = "2 clubs"

        For count = 1 To 3
            PutinPiles(Piles, Cards)
            DisplayCards(Piles)
            PileChoice = GetChoice()
            GroupPiles(Cards, Piles, PileChoice)
        Next

        MagicCard = Cards(Cards.Length \ 2)
        Console.WriteLine("Your card is the " & MagicCard)

        Console.ReadLine()
    End Sub

    Function GetChoice() As Integer
        Dim PileNum As Integer

        Console.WriteLine("Choose Pile Number")
        Do
            Try
                PileNum = Console.ReadLine
            Catch
                Console.WriteLine("Please enter a number")
            End Try

            If PileNum < 1 Or PileNum > 3 Then
                Console.WriteLine("Please enter 1, 2 or 3")
            End If
        Loop Until PileNum = 1 Or PileNum = 2 Or PileNum = 3

        Return PileNum
    End Function

    Sub GroupPiles(ByRef Cards() As String, ByVal Piles(,) As String, ByVal PileNum As Integer)
        Dim CardPos As Integer = 1

        If PileNum = 1 Then
            For j = 1 To 7
                Cards(j) = Piles(2, j)
            Next
            For j = 8 To 14
                Cards(j) = Piles(1, CardPos)
                CardPos = CardPos + 1
            Next
            CardPos = 1
            For j = 15 To 21
                Cards(j) = Piles(3, CardPos)
                CardPos = CardPos + 1
            Next
        End If

        If PileNum = 2 Then
            For j = 1 To 7
                Cards(j) = Piles(1, j)
            Next
            For j = 8 To 14
                Cards(j) = Piles(2, CardPos)
                CardPos = CardPos + 1
            Next
            CardPos = 1
            For j = 15 To 21
                Cards(j) = Piles(3, CardPos)
                CardPos = CardPos + 1
            Next
        End If

        If PileNum = 3 Then
            For j = 1 To 7
                Cards(j) = Piles(1, j)
            Next
            For j = 8 To 14
                Cards(j) = Piles(3, CardPos)
                CardPos = CardPos + 1
            Next
            CardPos = 1
            For j = 15 To 21
                Cards(j) = Piles(2, CardPos)
                CardPos = CardPos + 1
            Next
        End If
    End Sub

    Sub PutinPiles(ByRef Piles(,) As String, ByVal Cards() As String)
        Dim j As Integer = 1

        For i = 1 To 21 Step 3
            Piles(1, j) = Cards(i)
            j = j + 1
        Next

        j = 1
        For i = 2 To 21 Step 3
            Piles(2, j) = Cards(i)
            j = j + 1
        Next

        j = 1
        For i = 3 To 21 Step 3
            Piles(3, j) = Cards(i)
            j = j + 1
        Next
    End Sub

    Sub DisplayCards(ByVal Piles(,) As String)
        For i = 1 To 3
            Console.WriteLine("Pile " & i)
            For j = 1 To 7
                Console.WriteLine(Piles(i, j))
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub ShowDeck(ByVal Cards() As String)
        Console.WriteLine("The deck is now ")

        For i = 1 To 7
            Console.WriteLine(Cards(i))
        Next
        Console.WriteLine()

        For i = 8 To 14
            Console.WriteLine(Cards(i))
        Next
        Console.WriteLine()

        For i = 15 To 21
            Console.WriteLine(Cards(i))
        Next
    End Sub
End Module