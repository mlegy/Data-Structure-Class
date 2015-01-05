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

Module StackManipulation
	
	Sub Main()
		
		Dim no As Integer
		no = InputBox("Enter number of elements to be pushed: ")
		PrintItems(Reverse(Inputelements(no)))
		MSGBox("Largest Element = " & GetLargest(Inputelements(no)))
		MSGBox("Sum of Elements = " & GetSum(InputElements(no)))
			
	End Sub
	
	Public Function Inputelements(Byval no As Integer) As MyStack
		Dim stk1 As New MyStack()
		Dim element As Integer		
		For i As Integer = 0 To no -1
			element = InputBox("Enter Element " & i & "to be pushed: ")
			stk1.push(element)
		Next
		Return stk1
	End Function
	
	Public Sub PrintItems(ByVal stk As MyStack)
		Dim i As Integer = 0
		While(Not stk.IsEmpty())
			Console.WriteLine("Top of Stack No." & i & " = " & stk.Pop())
			i += 1
		End While
	End Sub
		
	Public Function Reverse(ByVal stk As MyStack) As MyStack
		Dim stk1 As New MyStack()
		For i As Integer = 0 To stk.Count() - 1
			stk1.Push(stk.Pop())
		Next
		Return stk1
	End Function
		
	Public Function GetLargest(ByVal stk As MyStack) As Integer
		Dim element, max As Integer
		max = stk.Pop()
		While (Not stk.IsEmpty())
			element = stk.Pop()
			If element > max Then max = element
		End While
		Return max
	End Function
	
	Public Function GetSum(ByVal stk As MyStack) As Integer
		Dim sum As Integer = 0
		While (Not stk.IsEmpty())
			sum += stk.Pop()
		End While
		Return sum
	End Function

End Module