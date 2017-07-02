Imports MarkdownSharp.Markdown
Public Class FrmMain
    Dim MDExchanger As MarkdownSharp.Markdown = New MarkdownSharp.Markdown
    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
      On Error Resume Next
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '显示MDI子窗体
        FrmCodeAera.Show()
        
        
        With FrmCodeAera  '调整代码框位置大小
          .Left =0
          .Top =0
          .Width =me.Width
          .Height =me.Height
        End With
    End Sub
End Class
