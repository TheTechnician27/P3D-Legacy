Namespace Items.Standard

    <Item(504, "Whipped Dream")>
    Public Class WhippedDream

        Inherits Item

        Public Overrides ReadOnly Property CanBeUsedInBattle As Boolean = False
        Public Overrides ReadOnly Property CanBeUsed As Boolean = False

        Public Sub New()
            _textureRectangle = New Rectangle(168, 240, 24, 24)
        End Sub

    End Class

End Namespace
