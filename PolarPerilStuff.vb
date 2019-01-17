Module PolarPerilStuff

    Structure SpriteType
        Dim speed As Point
        Dim floattime As Integer
        Dim picNum As Integer
        Dim facingRight As Boolean
        Dim floating As Boolean
        Dim onLadder As Boolean
        Dim floorNumber As Integer
        Dim onFloor As Boolean
    End Structure

    Structure FloorType
        Dim x As Single
        Dim y As Single
        Dim slope As Single
        Dim LeftEdge As Single
        Dim RightEdge As Integer
    End Structure

End Module
