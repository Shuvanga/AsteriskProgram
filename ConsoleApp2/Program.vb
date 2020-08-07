Imports System

Module Program
    Sub Main()
        Dim i, j, k As Integer
        Console.WriteLine("Press enter to generate output!")
        Console.ReadKey()
        For i = 1 To 5
            For j = 1 To i
                Console.Write("*")
            Next
            Console.WriteLine(" ")
        Next
        Console.WriteLine("Press enter to generate output!")
        Console.ReadKey()
        For i = 1 To 5
            For j = i To 5
                Console.Write("*")
            Next
            Console.WriteLine(" ")
        Next
        Dim n As Integer
        Console.WriteLine("Enter number!")
        n = Console.ReadLine
        Console.WriteLine("Press enter to generate output!")
        Console.ReadKey()
        For i = 0 To n
            For j = 0 To (n - 1) + i
                If j >= (n - 1) - i Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub
End Module
