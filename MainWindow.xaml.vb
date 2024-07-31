Class MainWindow
    Private Sub end_click(sender As Object, e As RoutedEventArgs)
        SaveSetting("全家桶设置", "settings", "rou", Me.rou.Text)
        SaveSetting("全家桶设置", "settings", "aero", Me.aero.Text)
        End
    End Sub
    Private Sub move()
        If Mouse.LeftButton = 1 Then
            DragMove()
        End If
    End Sub
    Private Sub main_act()
        Me.border1.CornerRadius = New CornerRadius(GetSetting("全家桶设置", "settings", "rou", 15))
        Me.border1.Opacity = GetSetting("全家桶设置", "settings", "aero", 90) / 100
        Me.rou.Text = Me.border1.CornerRadius.TopLeft.ToString
        Me.aero.Text = Me.border1.Opacity * 100
    End Sub
    Private Sub rou_add(sender As Object, e As RoutedEventArgs)
        Me.rou.Text = Me.rou.Text + 5
        If Me.rou.Text < 0 Then
            Me.rou.Text = 0
        End If
    End Sub
    Private Sub rou_miu(sender As Object, e As RoutedEventArgs)
        Me.rou.Text = Me.rou.Text - 5
        If Me.rou.Text < 0 Then
            Me.rou.Text = 0
        End If
    End Sub
    Private Sub rou_LostFocus(sender As Object, e As RoutedEventArgs) Handles rou.LostFocus
        If Me.rou.Text < 0 Then
            Me.rou.Text = 0
        End If
    End Sub
    Private Sub aero_add(sender As Object, e As RoutedEventArgs)
        Me.aero.Text = Me.aero.Text + 10
        If Me.aero.Text < 0 Then
            Me.aero.Text = 0
        End If
        If Me.aero.Text > 100 Then
            Me.aero.Text = 100
        End If
    End Sub
    Private Sub aero_miu(sender As Object, e As RoutedEventArgs)
        Me.aero.Text = Me.aero.Text - 10
        If Me.aero.Text < 0 Then
            Me.aero.Text = 0
        End If
        If Me.aero.Text > 100 Then
            Me.aero.Text = 100
        End If
    End Sub
    Private Sub aero_LostFocus(sender As Object, e As RoutedEventArgs) Handles aero.LostFocus
        If Me.aero.Text < 0 Then
            Me.aero.Text = 0
        End If
        If Me.aero.Text > 100 Then
            Me.aero.Text = 100
        End If
    End Sub
    Private Sub show_set(sender As Object, e As RoutedEventArgs)
        Me.border1.CornerRadius = New CornerRadius(Int(Me.rou.Text))
        Me.border1.Opacity = Me.aero.Text / 100
    End Sub
    Private Sub show_reset(sender As Object, e As RoutedEventArgs)
        Me.rou.Text = 15
        Me.aero.Text = 90
        Me.border1.CornerRadius = New CornerRadius(Int(Me.rou.Text))
        Me.border1.Opacity = Me.aero.Text / 100
    End Sub
End Class
