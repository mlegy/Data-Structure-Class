REM Page 2-9
REM Write a program to count the number of each letter in a given name:

Module Module1
	Sub Main()
		Dim name As String
		Dim count(26) As integer
		Dim chars() As Char = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n",
			"o","p","q","r","s","t","u","v","w","x","y","z"}
		name = InputBox("Enter the name: ")
		For i As Integer = 0 To name.length - 1
			For j As Integer = 0 To 25
				If name.Chars(i) = chars(j) Then
					count(j) += 1
					Exit For
				End If
			Next
		Next
		For i As Integer = 0 To 25
			If Not count(i) = 0 Then
				Console.WriteLine("The number of " & chars(i) & " = " & count(i))
			End If
		Next
	End Sub
End Module