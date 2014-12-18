Public Class CArray

	private arr() As Integer
	Private numElements As Integer
	
	Public Sub New(ByVal number As Integer)
		ReDim Preserve arr(number)
		numElements = 0
	End Sub
	
	Public Sub Insert(ByVal item As Integer)
		 If(numElements > arr.GetUpperBound(0)) Then
		 	ReDim Preserve arr(numElements * 1.25)
		 End if
		 arr(numElements) = item
		 numElements += 1
	End Sub
	
	Public Sub ShowArray()
		Dim index As integer
		For index = 0 To numElements - 1
			Console.Write(arr(index) & " ")
		Next
		Console.WriteLine()
	End Sub
	
	Public Sub Sort()
		Dim outer, inner, min, temp As Integer
		For outer = 0 To numElements - 2
			min = outer
			For inner = outer + 1 To numElements -1
				If (arr(inner) < arr(min)) Then
					min = inner
				End If
			Next
			temp = arr(outer)
			arr(outer) = arr(min)
			arr(min) = temp
		Next
	End Sub
	
	Public Function BinarySearch(ByVal value As Integer) As Integer
		Dim upperbound, lowerbound, mid As Integer
		upperbound = arr.GetUpperBound(0)
		lowerbound = 0
		Do While (lowerbound <= upperbound)
			mid = ( upperbound + lowerbound ) \ 2
			If arr(mid) = value Then
				Return mid
			ElseIf arr(mid) < value Then
				lowerbound = mid + 1
			Else
				upperbound = mid - 1
			End If
		Loop
		Return -1		
	End Function

End Class

Module test

	sub Main()
		Dim mynums As New CArray(9)
		Dim index As Integer
		For index = 0 To 9
			mynums.Insert(100 * Rnd() + 1)
		Next
		mynums.Sort()
		Dim position As Integer = mynums.BinarySearch(90)
		If (position > -1) Then
			Console.WriteLine("found item")
			mynums.showArray()
		Else
			Console.WriteLine("Not in the array.")
		End If
	End Sub
	
End Module