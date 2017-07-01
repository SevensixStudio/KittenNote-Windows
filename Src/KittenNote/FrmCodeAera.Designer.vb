<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCodeAera
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCodeAera))
        Me.Highlighter1 = New KittenNote.Highlighter.Highlighter()
        Me.SuspendLayout()
        '
        'Highlighter1
        '
        Me.Highlighter1.Location = New System.Drawing.Point(0, -1)
        Me.Highlighter1.Name = "Highlighter1"
        Me.Highlighter1.ShowEOLMarkers = True
        Me.Highlighter1.ShowSpaces = True
        Me.Highlighter1.ShowTabs = True
        Me.Highlighter1.ShowVRuler = True
        Me.Highlighter1.Size = New System.Drawing.Size(287, 233)
        Me.Highlighter1.TabIndex = 0
        '
        'FrmCodeAera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 270)
        Me.Controls.Add(Me.Highlighter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCodeAera"
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Highlighter1 As KittenNote.Highlighter.Highlighter
End Class
