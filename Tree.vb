'the class defindes the node (as data and two Child nodes{right and left})
Module BinarySearchTree
	Sub Main()	
		Dim nums As MyBinarySearchTree
		
		nums.Insert(23)
		nums.Insert(45)
		nums.Insert(16)
		nums.Insert(37)
		nums.Insert(3)
		nums.Insert(99)
		nums.Insert(22)
		
		Console.WriteLine("Inorder traversal: ")
		nums.inOrder(nums.root)
		Console.WriteLine()
		
		Console.WriteLine("Perorder traversal: ")
		nums.preOrder(nums.root)
		Console.WriteLine()
		
		Console.WriteLine("Postorder traversal: ")
		nums.postOrder(nums.root)
		Console.WriteLine()
		
		Dim min As Integer = nums.FindMin()
		Dim max As Integer = nums.FindMax()
		
		Console.WriteLine("The maximum value in the tree is: " &max)
		Console.WriteLine("The minimum value in the tree is: " &min)
		
		Dim value1 As Integer = 37
		Dim value2 As Integer = 4
		
		Dim node As TNode = nums.Find(value1)
		If(IsNoThing (node)) Then
			Console.WriteLine("Vlaue " & value1 & "doesn't exist")
		Else
			Console.WriteLine("Value " & value1 & "exits in the tree")
		End If
		
		node = nums.Find(value2)
		If(IsNoThing(value2)) Then
			Console.WriteLine("Value " & value2 & "doesn't exist")
		Else
			Console.WriteLine("Value " & value2 & "exists in the tree")
		End If
	End Sub
End Module


Public Class TNode
	
	Public iData As Integer
	Public left As TNode
	Public right As TNode
	
	'The method that display the content of the node
	Public Sub displayNode()
		Console.Write(iData & " ")
	End Sub
	
End Class

'The Class that build the binary search tree
Public Class MyBinarySearchTree
	
	'Define the root
	Public root As TNode
	
	'Constructor Declaration in which the root is set to as nothing
	Public Sub New()
		root = NoThing
	End Sub
	
	'The method that insert new node
	Public Sub Insert(ByVal i As Integer)
		Dim newNode As TNode
		newNode.iData = i
		
		If (root is NoThing)
			root = newNode
		Else
			Dim current As TNode = root
			Dim parent As TNode
			while (True)
				parent = current
				If (i < current.iData)
					current = current.Left
					If (current is NoThing) Then
						parent.Left = newNode
						Exit While
					End If
				Else
					current = current.Right
					If (i > current.iData)
						current = current.Right
						If (current is NoThing)
							parent.Right = newNode
							Exit While
						End If
					End If
				End If
		End While
		End If
	End Sub
	
	'The method that performs inOrder traversal
	Public Sub inOrder(ByVal theRoot As TNode)
		If(Not(theRoot is NoThing))
			inOrder(theRoot.Left)
			theRoot.displayNode()
			inOrder(theRoot.Right)
		End if
	End Sub
	
	'The method that performs preOrder traversal
	Public Sub preOrder(ByVal theRoot As TNode)
		If(Not(theRoot is NoThing))
			theRoot.displayNode()
			preOrder(theRoot.Left)
			preOrder(theRoot.Right)
		End If
	End Sub
	
	'The method that performs postOrder traversal
	Public Sub postOrder(ByVal theRoot As TNode)
		If(Not(theRoot is NoThing))
			postOrder(theRoot.Left)
			postOrder(theRoot.Right)
			theRoot.displayNode()
		End If
	End Sub
	
	'The fucnction that returns minimum value in the tree
	Public Function FindMin() As Integer
		Dim current As TNode = root
		While (Not(current.Left is NoThing))
			current = current.Left
		End While
		Return current.iData
	End Function
	
	'The method that returns maximum value in the tree
	Public Function FindMax() As Integer
		Dim current As TNode = root
		While(Not(current.Right is NoThing))
			current = current.Right
		End While
		Return current.iData
	End Function
	
	'The method that finds a specific node based on the data stored in it
	Public Function Find(ByVal key As Integer) As TNode
		Dim current As TNode = root
		While (current.iData <> key)
			If(key < current.iData) Then
				current = current.Left
			Else
				current = current.Right
			End If
			If (current Is NoThing) Then
				Return NoThing
			End If
		End While
	End Function
End Class