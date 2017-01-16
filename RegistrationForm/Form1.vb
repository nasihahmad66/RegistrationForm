Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each tc In {TabControl1}
            With tc
                .SuspendLayout()
                .SizeMode = TabSizeMode.Fixed
                .ItemSize = New Size(0, 1)
                .Appearance = TabAppearance.Buttons
                .ResumeLayout()
            End With
        Next
    End Sub
End Class
