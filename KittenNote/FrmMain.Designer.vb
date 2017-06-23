Imports Gdu.WinFormUI.Theme
Imports ICSharpCode
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits Gdu.WinFormUI.Forms.GMForm


    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Dim ThemeDevExpress4 As Gdu.WinFormUI.Theme.ThemeDevExpress = New Gdu.WinFormUI.Theme.ThemeDevExpress()
        Dim ButtonColorTable13 As Gdu.WinFormUI.SelfRenderControl.ButtonColorTable = New Gdu.WinFormUI.SelfRenderControl.ButtonColorTable()
        Dim ButtonColorTable14 As Gdu.WinFormUI.SelfRenderControl.ButtonColorTable = New Gdu.WinFormUI.SelfRenderControl.ButtonColorTable()
        Dim ButtonColorTable15 As Gdu.WinFormUI.SelfRenderControl.ButtonColorTable = New Gdu.WinFormUI.SelfRenderControl.ButtonColorTable()
        Dim ButtonColorTable16 As Gdu.WinFormUI.SelfRenderControl.ButtonColorTable = New Gdu.WinFormUI.SelfRenderControl.ButtonColorTable()
        Me.HTMLEdit = New ICSharpCode.TextEditor.TextEditorControl()
        Me.MDEdit = New ICSharpCode.TextEditor.TextEditorControl()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Browser = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'HTMLEdit
        '
        Me.HTMLEdit.CreateBackupCopy = True
        Me.HTMLEdit.EnableFolding = False
        Me.HTMLEdit.Encoding = CType(resources.GetObject("HTMLEdit.Encoding"), System.Text.Encoding)
        Me.HTMLEdit.Location = New System.Drawing.Point(192, 119)
        Me.HTMLEdit.Name = "HTMLEdit"
        Me.HTMLEdit.ShowEOLMarkers = True
        Me.HTMLEdit.ShowInvalidLines = False
        Me.HTMLEdit.ShowSpaces = True
        Me.HTMLEdit.ShowTabs = True
        Me.HTMLEdit.ShowVRuler = True
        Me.HTMLEdit.Size = New System.Drawing.Size(227, 135)
        Me.HTMLEdit.TabIndex = 2
        '
        'MDEdit
        '
        Me.MDEdit.Encoding = CType(resources.GetObject("MDEdit.Encoding"), System.Text.Encoding)
        Me.MDEdit.Location = New System.Drawing.Point(2, 86)
        Me.MDEdit.Name = "MDEdit"
        Me.MDEdit.ShowEOLMarkers = True
        Me.MDEdit.ShowInvalidLines = False
        Me.MDEdit.ShowSpaces = True
        Me.MDEdit.ShowTabs = True
        Me.MDEdit.ShowVRuler = True
        Me.MDEdit.Size = New System.Drawing.Size(154, 293)
        Me.MDEdit.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(2, 32)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(647, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Browser
        '
        Me.Browser.Location = New System.Drawing.Point(385, 234)
        Me.Browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(121, 110)
        Me.Browser.TabIndex = 4
        Me.Browser.WebBrowserShortcutsEnabled = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Markdown："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(161, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Html："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(319, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "预览："
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderWidth = 2
        Me.CaptionHeight = 30
        Me.ClientSize = New System.Drawing.Size(651, 460)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Browser)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.HTMLEdit)
        Me.Controls.Add(Me.MDEdit)
        Me.MinimumSize = New System.Drawing.Size(160, 60)
        Me.Name = "FrmMain"
        Me.ShadowWidth = 10
        Me.ShowShadow = True
        Me.SideResizeWidth = 4
        Me.Text = "FrmMain"
        ThemeDevExpress4.BorderWidth = 2
        ThemeDevExpress4.CaptionBackColorBottom = System.Drawing.Color.White
        ThemeDevExpress4.CaptionBackColorTop = System.Drawing.Color.White
        ThemeDevExpress4.CaptionHeight = 30
        ThemeDevExpress4.CaptionTextCenter = True
        ThemeDevExpress4.CaptionTextColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        ThemeDevExpress4.CloseBoxBackImageHover = Nothing
        ThemeDevExpress4.CloseBoxBackImageNormal = Nothing
        ThemeDevExpress4.CloseBoxBackImagePressed = Nothing
        ButtonColorTable13.BackColorHover = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        ButtonColorTable13.BackColorNormal = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        ButtonColorTable13.BackColorPressed = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        ButtonColorTable13.BorderColorHover = System.Drawing.Color.Empty
        ButtonColorTable13.BorderColorNormal = System.Drawing.Color.Empty
        ButtonColorTable13.BorderColorPressed = System.Drawing.Color.Empty
        ButtonColorTable13.ForeColorHover = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        ButtonColorTable13.ForeColorNormal = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        ButtonColorTable13.ForeColorPressed = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        ThemeDevExpress4.CloseBoxColor = ButtonColorTable13
        ThemeDevExpress4.CloseBoxSize = New System.Drawing.Size(37, 17)
        ThemeDevExpress4.ControlBoxOffset = New System.Drawing.Point(8, 8)
        ThemeDevExpress4.ControlBoxSpace = 2
        ThemeDevExpress4.DrawCaptionIcon = True
        ThemeDevExpress4.DrawCaptionText = True
        ThemeDevExpress4.FormBackColor = System.Drawing.Color.White
        ThemeDevExpress4.FormBorderInmostColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(219, Byte), Integer))
        ThemeDevExpress4.FormBorderInnerColor = System.Drawing.Color.White
        ThemeDevExpress4.FormBorderOutterColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(198, Byte), Integer))
        ThemeDevExpress4.IconLeftMargin = 2
        ThemeDevExpress4.IconSize = New System.Drawing.Size(16, 16)
        ThemeDevExpress4.MaxBoxBackImageHover = Nothing
        ThemeDevExpress4.MaxBoxBackImageNormal = Nothing
        ThemeDevExpress4.MaxBoxBackImagePressed = Nothing
        ButtonColorTable14.BackColorHover = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(179, Byte), Integer))
        ButtonColorTable14.BackColorNormal = System.Drawing.Color.Transparent
        ButtonColorTable14.BackColorPressed = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(161, Byte), Integer))
        ButtonColorTable14.BorderColorHover = System.Drawing.Color.Empty
        ButtonColorTable14.BorderColorNormal = System.Drawing.Color.Empty
        ButtonColorTable14.BorderColorPressed = System.Drawing.Color.Empty
        ButtonColorTable14.ForeColorHover = System.Drawing.Color.White
        ButtonColorTable14.ForeColorNormal = System.Drawing.Color.Black
        ButtonColorTable14.ForeColorPressed = System.Drawing.Color.White
        ThemeDevExpress4.MaxBoxColor = ButtonColorTable14
        ThemeDevExpress4.MaxBoxSize = New System.Drawing.Size(25, 17)
        ThemeDevExpress4.Mdi_AlwaysShowListAllBtn = True
        ThemeDevExpress4.Mdi_BarBackColor = System.Drawing.Color.LightSkyBlue
        ThemeDevExpress4.Mdi_BarBorderColor = System.Drawing.Color.Red
        ThemeDevExpress4.Mdi_BarBottomRegionBackColor = System.Drawing.Color.White
        ThemeDevExpress4.Mdi_BarBottomRegionHeight = 3
        ThemeDevExpress4.Mdi_BarLeftPadding = 3
        ThemeDevExpress4.Mdi_BarMargin = New System.Windows.Forms.Padding(6, 38, 100, 0)
        ThemeDevExpress4.Mdi_BarRightPadding = 100
        ThemeDevExpress4.Mdi_DrawBarBackground = False
        ThemeDevExpress4.Mdi_DrawBarBorder = False
        ThemeDevExpress4.Mdi_ListAllBtnAlign = Gdu.WinFormUI.SelfRenderControl.BarButtonAlignmentType.Left
        ThemeDevExpress4.Mdi_ListAllBtnBottomSpace = 7
        ButtonColorTable15.BackColorHover = System.Drawing.Color.HotPink
        ButtonColorTable15.BackColorNormal = System.Drawing.Color.LightPink
        ButtonColorTable15.BackColorPressed = System.Drawing.Color.DeepPink
        ButtonColorTable15.BorderColorHover = System.Drawing.Color.Empty
        ButtonColorTable15.BorderColorNormal = System.Drawing.Color.Empty
        ButtonColorTable15.BorderColorPressed = System.Drawing.Color.Empty
        ButtonColorTable15.ForeColorHover = System.Drawing.Color.Black
        ButtonColorTable15.ForeColorNormal = System.Drawing.Color.Black
        ButtonColorTable15.ForeColorPressed = System.Drawing.Color.Black
        ThemeDevExpress4.Mdi_ListAllBtnColor = ButtonColorTable15
        ThemeDevExpress4.Mdi_ListAllBtnLeftSpace = 4
        ThemeDevExpress4.Mdi_ListAllBtnSize = New System.Drawing.Size(36, 18)
        ThemeDevExpress4.Mdi_NewTabBtnBottomSpace = 7
        ButtonColorTable16.BackColorHover = System.Drawing.Color.HotPink
        ButtonColorTable16.BackColorNormal = System.Drawing.Color.LightPink
        ButtonColorTable16.BackColorPressed = System.Drawing.Color.DeepPink
        ButtonColorTable16.BorderColorHover = System.Drawing.Color.Empty
        ButtonColorTable16.BorderColorNormal = System.Drawing.Color.Empty
        ButtonColorTable16.BorderColorPressed = System.Drawing.Color.Empty
        ButtonColorTable16.ForeColorHover = System.Drawing.Color.Black
        ButtonColorTable16.ForeColorNormal = System.Drawing.Color.Black
        ButtonColorTable16.ForeColorPressed = System.Drawing.Color.Black
        ThemeDevExpress4.Mdi_NewTabBtnColor = ButtonColorTable16
        ThemeDevExpress4.Mdi_NewTabBtnLeftSpace = 4
        ThemeDevExpress4.Mdi_NewTabBtnSize = New System.Drawing.Size(25, 18)
        ThemeDevExpress4.Mdi_ShowNewTabBtn = True
        ThemeDevExpress4.Mdi_ShowTabIcon = True
        ThemeDevExpress4.Mdi_TabActiveBackColorBottom = System.Drawing.Color.White
        ThemeDevExpress4.Mdi_TabActiveBackColorTop = System.Drawing.Color.White
        ThemeDevExpress4.Mdi_TabAndTabSpace = -8
        ThemeDevExpress4.Mdi_TabDeactiveBackColorBottom = System.Drawing.Color.DarkGray
        ThemeDevExpress4.Mdi_TabDeactiveBackColorTop = System.Drawing.Color.LightGray
        ThemeDevExpress4.Mdi_TabHeight = 26
        ThemeDevExpress4.Mdi_TabHeightActive = 26
        ThemeDevExpress4.Mdi_TabInnerBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ThemeDevExpress4.Mdi_TabMaxWidth = 360
        ThemeDevExpress4.Mdi_TabMinWidth = 90
        ThemeDevExpress4.Mdi_TabNormalWidth = 180
        ThemeDevExpress4.Mdi_TabOutterBorderColor = System.Drawing.Color.Gray
        ThemeDevExpress4.Mdi_TabSlopeWidth = 8
        ThemeDevExpress4.Mdi_TabTopSpace = 2
        ThemeDevExpress4.Mdi_UseMsgToActivateChild = True
        ThemeDevExpress4.MinBoxBackImageHover = Nothing
        ThemeDevExpress4.MinBoxBackImageNormal = Nothing
        ThemeDevExpress4.MinBoxBackImagePressed = Nothing
        ThemeDevExpress4.MinBoxColor = ButtonColorTable14
        ThemeDevExpress4.MinBoxSize = New System.Drawing.Size(25, 17)
        ThemeDevExpress4.Radius = 8
        ThemeDevExpress4.ResBoxBackImageHover = Nothing
        ThemeDevExpress4.ResBoxBackImageNormal = Nothing
        ThemeDevExpress4.ResBoxBackImagePressed = Nothing
        ThemeDevExpress4.RoundedStyle = Gdu.WinFormUI.MyGraphics.RoundStyle.None
        ThemeDevExpress4.SetClientInset = False
        ThemeDevExpress4.ShadowAValueDark = 80
        ThemeDevExpress4.ShadowAValueLight = 0
        ThemeDevExpress4.ShadowColor = System.Drawing.Color.Black
        ThemeDevExpress4.ShadowWidth = 10
        ThemeDevExpress4.ShowShadow = True
        ThemeDevExpress4.SideResizeWidth = 4
        ThemeDevExpress4.TextLeftMargin = 2
        ThemeDevExpress4.UseDefaultTopRoundingFormRegion = False
        ThemeDevExpress4.UseShadowToResize = False
        Me.XTheme = ThemeDevExpress4
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HTMLEdit As ICSharpCode.TextEditor.TextEditorControl
    Friend WithEvents MDEdit As ICSharpCode.TextEditor.TextEditorControl
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Browser As WebBrowser
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
End Class
