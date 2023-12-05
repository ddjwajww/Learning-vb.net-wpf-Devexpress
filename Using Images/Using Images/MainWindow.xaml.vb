Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        Dim myImage As New Image
        Dim myBitmap As New BitmapImage

        Try
            myBitmap.BeginInit()
            myBitmap.UriSource = New Uri(txtImage.Text)
            myBitmap.EndInit()

            myImage.Source = myBitmap
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



        theGrid.Children.Add(myImage)
        Grid.SetColumn(myImage, 1)
        Grid.SetRow(myImage, 1)

    End Sub
End Class
