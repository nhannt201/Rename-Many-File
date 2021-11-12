Public Class home
    Dim total As String
    Public Sub ChooseFolder()
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            paths.Text = FolderBrowserDialog1.SelectedPath
            filenm.Items.Clear()
            ' make a reference to a directory
            Dim di As New IO.DirectoryInfo(paths.Text)
            Dim diar1 As IO.FileInfo() = di.GetFiles()
            Dim dra As IO.FileInfo

            'list the names of all files in the specified directory
            For Each dra In diar1
                filenm.Items.Add(dra)
                filepath.Items.Add(dra.FullName)
                total = filenm.Items.Count
            Next
            strname.Enabled = True
        End If
    End Sub

    Private Sub selct_Click(sender As Object, e As EventArgs) Handles selct.Click
        ChooseFolder()

    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filepath.Visible = False
    End Sub

    Private Sub strname_Click(sender As Object, e As EventArgs) Handles strname.Click

        If namedl.Text = "" Then
            MsgBox("Không được để trống!")
        Else
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' My.Computer.FileSystem.RenameFile("C:\Test.txt", "SecondTest.txt")
        ' filenm.Items.Count = filenm.Items.Count - 1
        Try
            '  Dim namefl As String
            filenm.SelectedIndex = filenm.SelectedIndex + 1
            filepath.SelectedIndex = filepath.SelectedIndex + 1
            wait.Text = filepath.Text
            Label4.Text = filenm.Text
            If Label4.Text.Contains(namedl.Text) Then
                Label4.Text = Label4.Text.Replace(namedl.Text, namerp.Text)
            Else
                Label4.Text = Label4.Text
            End If

            My.Computer.FileSystem.RenameFile(wait.Text, Label4.Text)
            cplrm.Items.Add(Label4.Text)
        Catch

            '     Timer1.Stop()
        End Try

    End Sub
End Class
