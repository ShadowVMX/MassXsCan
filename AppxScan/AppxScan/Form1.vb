Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim number As Integer

        number = InputBox("Proporcione el número en decimal del tercer octeto (192.168.[X].X)", "xScan", "0")

        If number < 0 Or number >= 255 Then
            MsgBox("Imposibilidad de escanear un rango inexistente.", vbCritical + vbOKOnly)
            End
        End If

        Process.Start("cmd", "/k C:\Users\%username%\Desktop\xScan.bat" & " " & number)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ip As String

        ip = InputBox("Inserte la IP que desea escanear: ", "xPorts", "192.168.0.1")

        Process.Start("cmd", "/k powershell C:\Users\%username%\Desktop\xPorts.ps1 -ip" & " " & ip)
        'Set-ExecutionPolicy RemoteSigned -Scope CurrentUser


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        MsgBox("Set-ExecutionPolicy RemoteSigned -Scope CurrentUser", vbExclamation + vbOKOnly, "Usar en PowerShell")

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Process.Start("https://protegermipc.net/2018/11/22/permitir-la-ejecucion-de-scripts-powershell-en-windows-10/")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Process.Start("https://www.github.com/shadowvmx/xScan")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Process.Start("cmd", "/k C:\Users\%username%\Desktop\Información.txt")
    End Sub
End Class
