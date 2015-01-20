Module GraphExample
	
	Sub Main()
		
		Dim aGraph As New MyGraph
		
		aGraph.addVertex("A")
		aGraph.addVertex("B")
		aGraph.addVertex("C")
		aGraph.addVertex("D")
		aGraph.addVertex("E")
		aGraph.addVertex("F")
		aGraph.addVertex("G")
		
		aGraph.addEdge(0, 1)
		aGraph.addEdge(0, 2)
		aGraph.addEdge(0, 3)
		aGraph.addEdge(1, 2)
		aGraph.addEdge(1, 3)
		aGraph.addEdge(1, 4)
		aGraph.addEdge(2, 3)
		aGraph.addEdge(2, 5)
		aGraph.addEdge(3, 5)
		aGraph.addEdge(3, 4)
		aGraph.addEdge(3, 6)
		aGraph.addEdge(4, 5)
		aGraph.addEdge(4, 6)
		aGraph.addEdge(5, 6)
		
		Console.WriteLine(aGraph.GetDescription())
		
	End Sub

End Module

'The Class that creates a vertex 
'(the vertex considered as label and flag to indicate if it was visited or not)
Public Class MyVertex
	'Declare the variable that indicate if the vertex was visited or not
	Public wasVisited As boolean
	Public label As String
	
	'The Constructor that set vertex with the specific label
	Public Sub New(ByVal label As String)
		Me.label = label
		wasVisited = False
	End Sub
End Class
	
'The Class that creates the graph
Public Class MyGraph
	'Determine the number of the verices
	Private const NUM_VERTICIES As Integer = 20
	'Define array of MyVertex class
	Private vertices() As MyVertex
	'Define adjancy matrix whic indicate the neighbours of each vertex
	Private adjMatrix(,) As Boolean
	Private numVerts As Integer
	
	'Constructor declaration in which determine the array size
	'and set the adjcent matrix to false
	Public Sub New()
		ReDim vertices(NUM_VERTICIES - 1)
		ReDim adjMatrix(NUM_VERTICIES - 1, NUM_VERTICIES - 1)
		
		numVerts = 0
		Dim j, k As Integer
		
		For j = 0 To adjMatrix.GetUpperBound(0)
			For k = 0 To adjMatrix.GetUpperBound(1)
				adjMatrix(j, k) = False
			Next
		Next

	End Sub
	
	'The method that add new vertex
	Public Sub addVertex(ByVal label As String)
		vertices(numVerts) = New MyVertex(label)
		numVerts += 1
	End Sub
	
	'The methoh that add Edge
	Public Sub addEdge(ByVal start As Integer, ByVal eend As Integer)
		adjMatrix(start, eend) = True
		adjMatrix(eend, start) = True
	End Sub
	
	'The method that display the vertices
	Public Sub showVertex(ByVal v As Integer)
		Console.WriteLine(vertices(v).label)
	End Sub
	
	'Describe the Graph:
	'The function that returns with the graph as string in suitable format
	Public Function GetDescription() As String
		Dim str As String = "Vertices: " + vbCrLf
	
		'Write the IDs of all vertices each in a separate line
		For i As Integer = 0 To numVerts - 1
			str &= vertices(i).label & vbCrlf
		Next
	
		str &= vbCrlf & "Edges: " & vbCrLf
		
		'Write the description of each edge as a
		'connection between two vertices each displayed as Vertex ID
		For i As Integer = 0 To numVerts - 1
			For j As Integer = 0 To i
				If(adjMatrix(i, j)) Then
					str &= vertices(i).label & " <---->" & _
					vertices(j).label & vbCrLf
				End If
			Next
		Next
		Return str
	End Function
End Class