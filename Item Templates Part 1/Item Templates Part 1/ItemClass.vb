Imports System.ComponentModel

Public Class ItemClass
    Implements INotifyPropertyChanged

    Private _checked As Boolean
    Private _image As ImageSource
    Private _text As String
    Public Property Checked As Boolean
        Get
            Return _checked
        End Get
        Set(value As Boolean)
            _checked = value
            OnPropertyChanged("Checked")
        End Set
    End Property
    Public Property Image As ImageSource
        Get
            Return _image
        End Get
        Set(value As ImageSource)
            _image = value
            OnPropertyChanged("Image")
        End Set
    End Property
    Public Property Text As String
        Get
            Return _text
        End Get
        Set(value As String)
            _text = value
            OnPropertyChanged("Text")
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Sub New(checked As Boolean,
            image As Uri,
            text As String)
        Me.Checked = checked
        Me.Image = New BitmapImage(image)
        Me.Text = text

    End Sub

    Protected Sub OnPropertyChanged(name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
    End Sub
End Class
