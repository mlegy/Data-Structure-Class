Imports System.Collections
Public Class MyStack
	Private ToS As Integer
	Private list As New ArrayList()
	
	Public Sub New()
		Tos = -1
	End Sub
	
	Function Count() As Integer
		Return list.Count
	End Function
	
	Public Sub Push(ByVal value As Object)
		list.Add(value)
		ToS += 1
	End Sub
	
	Public Function Pop() As Object
		Dim obj As Object = list.Item(ToS)
		list.RemoveAt(ToS)
		Tos -= 1
		Return obj
	End Function
	
	Public Sub Clear()
		list.Clear()
		Tos = -1
	End Sub
	
	Public Function Peak() As Object
		Return list.Item(ToS)
	End Function
	
	Public Function IsEmpty() As Boolean
		If ToS = -1 Then
			Return True
		Else
			Return False
		End If
	End Function

End Class

Module BracketChecker
	
	Dim stack As New MyStack()
	
	Sub Main()
		
		Console.WriteLine("Enter a sentence containing brackets, parentheses, or braces:")
		Dim input As String = Console.ReadLine()
		
		For i As Integer = 0 To input.Length - 1
			Dim ch As Char = input.Chars(i)
			
			Select Case ch
				case = "{", "[", "("
					stack.Push(ch)
				case = "}","]",")"
					If stack.IsEmpty() Then
						GoTo Wrong
					Else
						Dim chx As Char = stack.Pop()
						If ch = "}" And chx <> "{" Or _
						   ch = "]" And chx <> "[" Or _
						   ch = ")" And chx <> "(" Then
						   GoTo Wrong
						End If
					End If
				End Select
		Next
		
		If stack.IsEmpty() Then
			Console.WriteLine("All have been correctly closed ..")
		Else
Wrong:
			Console.WriteLine("Your sentence contains errors !")
		End If
		
	End Sub
	
End Module