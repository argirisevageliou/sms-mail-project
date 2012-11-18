Imports System.ComponentModel
Imports System.Runtime.InteropServices

<ProvideProperty("CueBanner", GetType(TextBox))> _
Class CueBanner
    Inherits Component
    Implements IExtenderProvider

    <DllImport("user32.dll", CharSet:=CharSet.Auto, EntryPoint:="SendMessage")> _
    Private Shared Function SetCueBanner( _
        ByVal handle As IntPtr, _
        ByVal message As UInteger, _
        ByVal wparam As IntPtr, _
        ByVal hint As String) As IntPtr
    End Function

    Private children As New Hashtable
    Private Function CanExtend(ByVal c As Object) As Boolean Implements IExtenderProvider.CanExtend
        If Not TypeOf c Is TextBox Then Return False

        If Not children.Contains(c) Then
            children.Add(c, String.Empty)
            HookCreation(DirectCast(c, TextBox))
        End If

        Return True
    End Function

    Private Sub HandleCreated(ByVal s As Object, ByVal e As EventArgs)
        SetBanner(DirectCast(s, TextBox))
    End Sub

    Function GetCueBanner(ByVal c As TextBox) As String
        Return DirectCast(children(c), String)
    End Function
    Sub SetCueBanner(ByVal c As TextBox, ByVal v As String)
        children(c) = v

        HookCreation(c)
        SetBanner(c)
    End Sub

    Private Sub HookCreation(ByVal c As TextBox)
        RemoveHandler c.HandleCreated, AddressOf HandleCreated
        AddHandler c.HandleCreated, AddressOf HandleCreated
    End Sub

    Private Sub SetBanner(ByVal c As TextBox)
        If Not c.IsHandleCreated Then Return
        SetCueBanner(c.Handle, 5377, IntPtr.Zero, GetCueBanner(c))
    End Sub

End Class