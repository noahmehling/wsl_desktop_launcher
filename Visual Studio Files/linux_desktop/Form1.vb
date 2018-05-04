Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Process.Start("cmd.exe")
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SendKeys.Send("ubuntu{ENTER}")
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        SendKeys.Send("sudo /etc/init.d/xrdp start{ENTER}")
        Timer2.Enabled = False
        Timer3.Enabled = True
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        SendKeys.Send(My.Computer.FileSystem.ReadAllText("C:\Users\Public\passwd.txt") + "{ENTER}")
        Timer3.Enabled = False
        Timer4.Enabled = True
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Process.Start("C:\Users\Public\linux_desktop.rdp")
        Timer4.Enabled = False
        Me.Close()
    End Sub
End Class