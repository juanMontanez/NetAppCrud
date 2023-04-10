Imports System.Windows.Forms

Public Class modEmpleadoDialog
    Dim time As Integer = 5

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
        frmPrincipal.openChildForm(frmModificarEmpleados)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If time > 0 Then
            time -= 1
            timerLbl.Text = time
        Else
            Timer1.Enabled = False
            Me.Close()
            frmPrincipal.openChildForm(frmModificarEmpleados)
        End If
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Enabled = True
    End Sub
End Class
