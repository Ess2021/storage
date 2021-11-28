Imports System
Imports System.Linq

Module LCM
	Sub Main(Args As String())
		Console.Write("gcd or lcm? >> ")
		Dim selecter As String = Console.ReadLine()
		Console.Write("val1 val2 ? >> ")
		Dim vals As Integer() = Console.ReadLine().Split().Select(Function(c) Integer.Parse(c)).ToArray()

		If selecter = "gcd" Then
			Dim result As Integer = Gcd(vals(0), vals(1))
			Console.WriteLine(result)
		Else If selecter = "lcm" Then
			Dim result As Integer = Lcm(vals(0), vals(1))
			Console.WriteLine(result)
		Else
			Console.WriteLine("What are you talking about??")
		End If

		Console.ReadKey()
	End Sub
	
	Function Gcd(a As Integer, b As Integer) As Integer
		If b = 0 Then
			Return a
		Else
			Return Gcd(b, a mod b)
		End If
	End Function

	Function Lcm(a As Integer, b As Integer) As Integer
		Dim d As Integer = Gcd(a, b)
		Return a / d * b
	End Function
End Module