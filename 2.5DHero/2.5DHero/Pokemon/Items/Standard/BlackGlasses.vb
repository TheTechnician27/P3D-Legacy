Namespace Items.Standard

    <Item(102, "Black Glasses")>
    Public Class BlackGlasses

        Inherits Item

        Public Overrides ReadOnly Property CanBeUsedInBattle As Boolean = False
        Public Overrides ReadOnly Property CanBeUsed As Boolean = False

        Public Sub New()
            _textureRectangle = New Rectangle(96, 96, 24, 24)
        End Sub

    End Class

End Namespace
