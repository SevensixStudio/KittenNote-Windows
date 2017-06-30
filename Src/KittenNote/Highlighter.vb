Namespace KittenNote.Highlighter
    Partial Public Class Highlighter
        Inherits ICSharpCode.TextEditor.TextEditorControl

        Private Sub InitializeComponent()
            Me.SuspendLayout()
            '
            'textAreaPanel
            '
            Me.textAreaPanel.Size = New System.Drawing.Size(348, 287)
            '
            'Highlighter
            '
            Me.Name = "Highlighter"
            Me.ShowEOLMarkers = False
            Me.ShowInvalidLines = False
            Me.Size = New System.Drawing.Size(348, 287)
            Me.ResumeLayout(False)
        End Sub

        Public Shadows Event KeyDown()

    End Class
End Namespace
