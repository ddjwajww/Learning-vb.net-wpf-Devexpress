Class MainWindow
    Private Sub btnAddColour_Click(sender As Object, e As RoutedEventArgs)

        Dim item As New ListViewItem
        item.Content = txtColour.Text
        lstColours.Items.Add(item)
        txtColour.Clear()


    End Sub

    Private Sub btnRemove_Click(sender As Object, e As RoutedEventArgs)

        If lstColours.SelectedIndex > -1 Then
            lstColours.Items.RemoveAt(lstColours.SelectedIndex)
        End If

    End Sub

    Private Sub btnDuplicate_Click(sender As Object, e As RoutedEventArgs)

        If lstColours.SelectedIndex > -1 Then

            Dim item As New ListViewItem

            item.Content = lstColours.SelectedItem.Content

            lstColours.Items.Insert(lstColours.SelectedIndex + 1, item)

        End If

    End Sub

    Private Sub btnMoveUp_Click(sender As Object, e As RoutedEventArgs)

        If lstColours.SelectedIndex > 0 Then

            Dim index As Integer = lstColours.SelectedIndex

            Dim item As New ListViewItem

            item.Content = lstColours.SelectedItem.Content

            lstColours.Items.Insert(lstColours.SelectedIndex - 1, item)

            lstColours.Items.RemoveAt(lstColours.SelectedIndex)

            lstColours.SelectedIndex = index - 1



        End If


    End Sub

    Private Sub btnMoveDown_Click(sender As Object, e As RoutedEventArgs)

        If lstColours.SelectedIndex < lstColours.Items.Count - 1 Then

            Dim index As Integer = lstColours.SelectedIndex

            Dim item As New ListViewItem

            item.Content = lstColours.SelectedItem.Content

            lstColours.Items.Insert(lstColours.SelectedIndex + 2, item)

            lstColours.Items.RemoveAt(lstColours.SelectedIndex)
            lstColours.SelectedIndex = index + 1

        End If


    End Sub
End Class
