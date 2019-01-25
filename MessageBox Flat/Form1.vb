Imports MetroFramework
Public Class Form1


    Private Sub btnMSG(sender As Object, e As EventArgs) Handles btn_msgS.Click
        MetroMessageBox.Show(Me, "Ok.", "Message Information",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_msgErr.Click
        MetroMessageBox.Show(Me, "Error .", "Message Error!",
                             MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_msgExM.Click
        MetroMessageBox.Show(Me, "Warning .", "Message Warning!!",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Welcome To Metro Freamwork MessageBox" & vbNewLine &
                        "Example From : https://github.com/poetralesana", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
