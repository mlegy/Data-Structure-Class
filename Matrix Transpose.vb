REM Ex 2-16
Module Module1

	Sub Main()
		
		Dim ra,ca As Integer
		Dim io As InputOutput = new InputOutput()
		ra = InputBox("Enter Rows: ")
		ca = InputBox("Enter Cols: ")
		io.output(io.trans(io.input(ra,ca)))
		
	End Sub
	
	Public Class transpose

		Function trans(ByVal x(,) As Integer) As Integer(,)
			Dim xt(x.GetUpperBound(1), x.GetUpperBound(0)) As Integer
			For i As Integer = 0 To x.GetUpperBound(0)
				For j As Integer = 0 To x.GetUpperBound(1)
					xt(i,j) = x(j,i)
				Next
			Next
			Return xt
		End Function
	End Class
	
	Public Class InputOutput 
		Inherits transpose

		Function input(Byval n As Integer, ByVal m As Integer) As Integer(,)
			Dim x(n-1,m-1) As Integer
			For i As Integer = 0 To x.GetUpperBound(0)
				For j As Integer = 0 To x.GetUpperBound(1)
				    x(i,j) = InputBox("Enter the element " & i & " , " & j & " : ")
				Next
			Next
			Return x
		End Function
		
		Sub output(ByVal x(,) As Integer)
			For i As integer = 0 To x.GetUpperBound(0)
				For j As Integer = 0 To x.GetUpperBound(1)
					Console.Write(x(i,j) & " ")	
				Next
				Console.WriteLine()
			Next
		End Sub
		
	End Class

End Module