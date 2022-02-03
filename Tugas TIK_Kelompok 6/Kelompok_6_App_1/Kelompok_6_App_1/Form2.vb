Public Class Form2



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MessageBox.Show(TxtNama.Text & vbCrLf & CmbKelas.Text & vbCrLf & CmbJK.Text & vbCrLf & CmbMP.Text, "Hasil", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
    End Sub
End Class