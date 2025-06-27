Imports System.Security.Cryptography

Public Class PasswordHelper
    Public Shared Function HashPassword(password As String) As String
        Dim salt As Byte() = New Byte(15) {}
        Using rng = New RNGCryptoServiceProvider()
            rng.GetBytes(salt)
        End Using

        Using pbkdf2 = New Rfc2898DeriveBytes(password, salt, 10000)
            Dim hash As Byte() = pbkdf2.GetBytes(20)
            Dim hashBytes As Byte() = New Byte(35) {}
            Array.Copy(salt, 0, hashBytes, 0, 16)
            Array.Copy(hash, 0, hashBytes, 16, 20)
            Return Convert.ToBase64String(hashBytes)
        End Using
    End Function

    Public Shared Function VerifyPassword(password As String, storedHash As String) As Boolean
        Dim hashBytes As Byte() = Convert.FromBase64String(storedHash)
        Dim salt As Byte() = New Byte(15) {}
        Array.Copy(hashBytes, 0, salt, 0, 16)

        Using pbkdf2 = New Rfc2898DeriveBytes(password, salt, 10000)
            Dim hash As Byte() = pbkdf2.GetBytes(20)
            For i As Integer = 0 To 19
                If hashBytes(i + 16) <> hash(i) Then Return False
            Next
        End Using
        Return True
    End Function
End Class