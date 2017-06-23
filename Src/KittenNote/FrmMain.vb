Imports MarkdownSharp.Markdown
Public Class FrmMain
    Dim MDExchanger As MarkdownSharp.Markdown
    Dim lasttext, nowtext As String

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lasttext = ""
        nowtext = "0"
        HTMLEdit.ShowEOLMarkers = False
        HTMLEdit.SetHighlighting("HTML")
        'HTMLEdit.Enabled = False
        MDEdit.ShowEOLMarkers = False
        MDEdit.SetHighlighting("MARKDOWN")
    End Sub

    Private Sub FrmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        With MDEdit
            .Top = Label1.Top + Label1.Height
            .Left = 0
            .Height = Height - .Top
            .Width = Width / 3
        End With
        With HTMLEdit
            .Top = Label1.Top + Label1.Height
            .Left = MDEdit.Width
            .Height = Height - .Top
            .Width = Width / 3
        End With
        With Browser
            .Top = Label1.Top + Label1.Height
            .Left = HTMLEdit.Left + HTMLEdit.Width
            .Height = Height - .Top
            .Width = Width / 3
        End With
        With Label2
            .Left = MDEdit.Width
        End With
        With Label3
            .Left = MDEdit.Width * 2
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        nowtext = MDEdit.Text
        If lasttext <> nowtext Then
            MDExchanger = New MarkdownSharp.Markdown
            HTMLEdit.Text = MDExchanger.Transform(nowtext)
        End If
        lasttext = MDEdit.Text
    End Sub

    Private Sub HTMLEdit_KeyDown(sender As Object, e As KeyEventArgs) Handles HTMLEdit.KeyDown
        e.SuppressKeyPress = False
    End Sub


End Class
