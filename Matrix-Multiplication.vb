REM Ex 2-10

Module MatrixMultiplication
	Sub Main()
	
		Dim io As InputOutput = new InputOutput()
		
		Dim rowsA, colsA, rowsB, colsB As Integer
		
		rowsA = InputBox("Enter the number of rows of matrix A: ")
		colsA = InputBox("Enter the number of cols of matrix A: ")
		rowsB = InputBox("Enter the number of rows of matrix B: ")
		colsB = InputBox("Enter the number of cols of matrix B: ")
		
		If (rowsB <> colsA) Then
			MsgBox("Thre is an Error")
			Exit Sub
		End IF
		
		Dim A(rowsA-1, colsA-1) As Single
		Dim B(rowsB-1, colsB-1) As Single
		Dim C(rowsA-1, colsB-1) As Single
		
		For i As Integer = 0 To A.GetUpperBound(0)
			For j As Integer = 0 To A.GetUpperBound(1)
				A(i,j) = io.input(i,j,"A")
			Next
		Next
		
		For i As Integer = 0 To B.GetUpperBound(0)
			For j As Integer = 0 To B.GetUpperBound(1)
				B(i,j) = io.input(i,j,"B")
			Next
		Next
		
		C = io.mul(A,B)
		Console.WriteLine("Resulting C matrix is: ")
		For i As Integer = 0 To C.GetUpperBound(0)
			For j As Integer = 0 To C.GetUpperBound(1)
				io.output(C(i,j))
			Next
			Console.WriteLine()
		Next
		Console.ReadLine()
End Sub

public Class Multiply
	
	Function mul(ByVal A(,) As Single, ByVal B(,) As Single) As Single(,)
		
		Dim rowsC As Integer = A.GetLength(0)
		Dim colsC As Integer = B.GetLength(1)
		Dim c(rowsC - 1, colsC - 1) As Single
		
		For i As Integer = 0 To c.GetUpperBound(0)
			For j As Integer = 0 To c.GetUpperBound(1)
				For k As Integer = 0 To A.GetUpperBound(1)
					c(i,j) += A(i,k) * B(k,j)
				Next
			Next
		Next
		
		Return c
		
	End Function
End Class

Public Class InputOutput 
	Inherits Multiply

	Function input(ByVal i As Integer, ByVal j As Integer, ByVal matrixName As String) As Integer
		Dim r As Single = InputBox("Enter the element" & i & " , " & j & "of matrix " & matrixName & ": ")
		Return r
	End Function
	
	Sub output(ByVal c As Integer)
		Console.Write(c & " ")
	End Sub

End Class

End Module