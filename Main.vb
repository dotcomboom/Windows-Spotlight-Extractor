Public Class Main

    Public path = System.Environment.ExpandEnvironmentVariables("%USERPROFILE%\AppData\Local\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets\")

    Private Sub updateConfig()
        Filenames.Checked = My.Settings.Filenames
        If My.Settings.Filenames Then
            For Each item As ListViewItem In List.Items
                If item.Text.Length = 0 Then
                    item.Text = item.Tag.Replace(path, "")
                End If
            Next
        Else
            For Each item As ListViewItem In List.Items
                item.Text = ""
            Next
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = My.Application.Info.AssemblyName
        Me.Text &= " " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        If My.Application.Info.Version.Build > 0 Then
            Me.Text &= "." & My.Application.Info.Version.Build
        End If
        If My.Application.Info.Version.Revision > 0 Then
            Me.Text &= "." & My.Application.Info.Version.Revision
        End If
        For Each file In My.Computer.FileSystem.GetFiles(path)
            Dim bmp As System.Drawing.Bitmap = System.Drawing.Bitmap.FromFile(file)
            If bmp.Width > 620 And bmp.Height > 620 Then ' app tiles: 300
                ' some twitter logo idk: 620
                Img.Images.Add(file.Replace(path, ""), System.Drawing.Bitmap.FromFile(file))
                Dim item As New ListViewItem
                item.Text = file.Replace(path, "")
                item.Tag = file
                item.ImageKey = file.Replace(path, "")
                List.Items.Add(item)
            End If
        Next
        updateConfig()
    End Sub

    Private Sub Extract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Extract.Click, CopyCon.Click
        If Browser.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each file As ListViewItem In List.SelectedItems
                My.Computer.FileSystem.CopyFile(file.Tag, Browser.SelectedPath & "\" & System.IO.Path.GetFileNameWithoutExtension(path & file.Text) & ".jpg")
            Next
        End If
    End Sub

    Private Sub List_ItemSelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles List.ItemSelectionChanged
        Extract.Enabled = List.SelectedItems.Count > 0
    End Sub

    Private Sub List_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles List.KeyDown, MyBase.KeyDown
        If e.Control And e.KeyCode = Keys.A Then
            For Each item As ListViewItem In List.Items
                item.Selected = True
            Next
        End If
    End Sub

    Private Sub OpenFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFolder.Click
        Process.Start(path)
    End Sub

    Private Sub About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles About.Click
        Dim v = My.Application.Info.AssemblyName
        v &= vbNewLine & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        If My.Application.Info.Version.Build > 0 Then
            v &= "." & My.Application.Info.Version.Build
        End If
        If My.Application.Info.Version.Revision > 0 Then
            v &= "." & My.Application.Info.Version.Revision
        End If
        v &= vbNewLine & My.Application.Info.Description
        v &= vbNewLine & My.Application.Info.CompanyName

        MsgBox(v, MsgBoxStyle.Information, "About")
    End Sub

    Private Sub List_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles List.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Context.Show(List, e.Location)
        End If
    End Sub

    Private Sub Context_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Context.Popup
        CopyCon.Enabled = List.SelectedItems.Count > 0
        CopyCon.DefaultItem = List.SelectedItems.Count > 0
    End Sub

    Private Sub ExitApplication_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitApplication.Click
        Application.Exit()
    End Sub

    Private Sub Filenames_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Filenames.Click
        My.Settings.Filenames = Not My.Settings.Filenames
        updateConfig()
    End Sub
End Class
