Public Class ArrayQueue
	Dim queue() As Object
	Dim capacity As Integer
	Dim numItems As Integer = 0
	Dim front As Integer = 0
	Dim rear As Integer = -1
	
	Public Sub New()
		ReDim queue(99)
		capacity = 100
	End Sub
	
	Public Sub New (ByVal maxSize As Integer)
		ReDim queue(maxSize - 1)
		capacity = maxSize
	End Sub
	
	Public Sub EnQueue(ByVal item As object)
		front = (front + 1) Mod capacity
		queue(front) = item
		numItems = numItems + 1
	End Sub
	
	Public Function DeQueue() As object
		Dim toReturn As object = queue(rear)
		queue(rear) = NoThing
		rear = (rear + 1) Mod capacity
		numItems = numItems -1
		Return toReturn
	End Function
	
	Public Function isEmpty() As Boolean
		If (numItems = 0 ) Then
			Return True
		Else
			Return False
		End If
	End Function
	
	Public Function isFull() As Boolean
		If (numItems = capacity) Then
			Return True
		Else
			Return False
		End If
	End Function
	
	Public Function Count() As Integer
		Return numItems
	End Function
	
	Public Sub PrintItems()
		For i As Integer = 0 To queue.GetUpperBound(0)
			Console.WriteLine(queue(i))
		Next
		Console.WriteLine()
	End Sub
	
End Class

Module ArrayQueueExample
	
	Sub Main()
		Dim q As New ArrayQueue(4)
		q.EnQueue("Mostafa")
		q.Enqueue("Ali")
		q.Enqueue("Ahmad")
		q.PrintItems()
		q.DeQueue()
		q.PrintItems()
	End Sub
	
End Module