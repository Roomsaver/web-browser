
Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Browser.Navigate(txtURL.Text)
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Browser.Stop()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Browser.Refresh()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If (Browser.CanGoBack) Then
            Browser.GoBack()
        End If
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        If (Browser.CanGoForward) Then
            Browser.GoForward()
        End If
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        If (GlobalVariables.SettingsOpen = True) Then
            My.Forms.Settings.Hide()
            GlobalVariables.SettingsOpen = False
        Else
            My.Forms.Settings.Show()
            GlobalVariables.SettingsOpen = True
        End If
    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        If (GlobalVariables.EmailOpen = True) Then
            My.Forms.Email.Hide()
            GlobalVariables.EmailOpen = False
        Else
            My.Forms.Email.Show()
            GlobalVariables.EmailOpen = True
        End If
    End Sub
End Class
Public Class GlobalVariables
    Public Shared SettingsOpen As Boolean = False
    Public Shared EmailOpen As Boolean = False
End Class