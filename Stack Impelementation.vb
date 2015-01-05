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