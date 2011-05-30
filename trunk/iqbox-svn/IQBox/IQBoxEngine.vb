Public Class IQBoxEngine
    Dim WithEvents Timer1 As Timer




    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Public Sub New()
        Timer1.Enabled = False
        Timer1.Interval = 0

    End Sub
End Class
