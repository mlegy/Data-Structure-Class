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

	Public Sub SelectionSort()
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
			Me.ShowArray()
		Next
	End Sub
End Class

Module test

	sub Main()
		Dim theArray As New CArray(9)
		Dim index As Integer
		For index = 0 To 9
			theArray.Insert(100 * Rnd() + 1)
		Next
		Console.WriteLine("Before")
		theArray.ShowArray()
		Console.WriteLine("During")
		theArray.SelectionSort()
		Console.WriteLine("After")
		theArray.ShowArray()
	End Sub
	
End Module