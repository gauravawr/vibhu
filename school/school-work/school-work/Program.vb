' P: how many numbers greater than 7 and less than 11 and  = [4,7,0,3,5,4,10,8]

imports System
Module LoopTask
    Sub Main
        Dim char1 As Char = "A"c
        Dim char2 As Char = "B"c
        Dim str1 As String = "Hello"
        Dim str2 As String = "World"

        ' Combine characters into a string
        Dim result1 As String = char1 & char2   ' "AB"

        ' Combine string and character
        Dim result2 As String = str1 & char1    ' "HelloA"

        ' Combine strings
        Dim result3 As String = str1 & " " & str2   ' "Hello World"

        ' Output results
        Console.WriteLine(result1)
        Console.WriteLine(result2)
        Console.WriteLine(result3)
    end sub
End Module 