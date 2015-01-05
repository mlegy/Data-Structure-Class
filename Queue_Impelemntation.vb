Public Class ArrayQueue
	
	Dim queue() As Object
	Dim capacity As Integer
	Dim numItems As Integer = 0
	Dim front As Integer = -1
	Dim rear As Integer = 0
	
	Public Sub New()
		ReDim queue(99)
		capacity = 100
	End Sub
	
	Public Sub New(ByVal maxSize As Integer)
		ReDim queue(maxSize - 1)
		capacity = maxSize
	End Sub
	
	Public Sub Enqueue(ByVal item As Object)
		fornt = (front + 1) Mod capacity
		queue(front) = item
		numItems += 1
	End Sub
	
	Public Function Dequeue() As Object
		Dim toReturn As Object = queue(rear)
		queue(rear) = NoThing
		rear = (rear + 1) Mod capacity
		numItems -= 1
		Return toReturn
	End Function
	
	Public Function IsEmpty() As Boolean
		If (numElements = 0) Then
			Return True
		Else
			Return False
		End If
	End Function
	
	Public Function IsFull() As Boolean
		If (numElements = capacity) Then
			Return True
		Else
			Return False
		End If
	End Function
	
	Public Function Count() As Integer
		Return numElements
	End Function
	
	Public Sub PrintItems()
		For i As Integer = 0 To queue.GetUpperBound(0)
			Console.WriteLine(queue(i))
		Next
		Console.WriteLine()
	End Sub

End Class