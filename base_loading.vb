Public Class base_loading


    '"FAKE" LOADING. (You may replace this with Update Checks and Server Status Checks)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        FlatProgressBar1.Value += 1

        If FlatProgressBar1.Value = 100 Then
            base_login.Show()
            Me.Close()
        End If
    End Sub

    Private Sub FormSkin1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlatLabel2_Click(sender As Object, e As EventArgs) Handles FlatLabel2.Click

    End Sub
End Class
