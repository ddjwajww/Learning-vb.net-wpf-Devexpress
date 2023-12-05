Imports Microsoft.Win32

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim openFile As New OpenFileDialog

        openFile.Title = "Select a document to open..."
        openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        openFile.Filter = "Microsoft Word Document|*.docx|Rich Text File|*.rtf|All Files|*.*"
        openFile.Multiselect = True

        If openFile.ShowDialog() = True Then
            lstFiles.Items.Clear()

            For Each filename As String In openFile.FileNames
                lstFiles.Items.Add(filename)
            Next
        End If


    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)

        Dim saveFile As New SaveFileDialog

        saveFile.Title = "Select a filename to save..."
        saveFile.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory

        saveFile.Filter = "My Data File Type|*.mdf| Text Doc|*.txt"

        If saveFile.ShowDialog() = True Then

            txtFileName.Text = saveFile.FileName

        End If

    End Sub
End Class
