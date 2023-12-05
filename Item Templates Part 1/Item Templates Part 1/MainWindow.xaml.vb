Imports System.Collections.ObjectModel

Class MainWindow

    Dim items As New ObservableCollection(Of ItemClass)
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        items.Add(New ItemClass(False,
            New Uri("C:\Users\emre\Desktop\foto.jpeg"),
            txtItems.Text))
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        MessageBox.Show(lstTest.SelectedItem.Checked)
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        items.Add(New ItemClass(False,
            New Uri("C:\Users\emre\Desktop\foto.jpeg"),
            "Item #1"))
        items.Add(New ItemClass(True,
            New Uri("C:\Users\emre\Desktop\foto.jpeg"),
            "Item #2"))
        items.Add(New ItemClass(False,
            New Uri("C:\Users\emre\Desktop\foto.jpeg"),
            "Item #3"))

        lstTest.ItemsSource = items
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        If lstTest.SelectedIndex > -1 Then
            lstTest.SelectedItem.Text = "Hello World"
        End If
    End Sub

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)
        For Each item As ItemClass In lstTest.Items
            item.Image = New BitmapImage(New Uri("C:\Users\emre\Desktop\foto2.jpg"))

        Next
    End Sub

    Private Sub Button_Click_4(sender As Object, e As RoutedEventArgs)

        For Each item As ItemClass In lstTest.Items
            item.Checked = Not item.Checked


        Next
    End Sub
End Class
