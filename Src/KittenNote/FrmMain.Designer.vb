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
        Dim ThemeMac1 As Gdu.WinFormUI.Theme.ThemeMac = New Gdu.WinFormUI.Theme.ThemeMac()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Dim ButtonColorTable1 As Gdu.WinFormUI.SelfRenderControl.ButtonColorTable = New Gdu.WinFormUI.SelfRenderControl.ButtonColorTable()
        Dim ButtonColorTable2 As Gdu.WinFormUI.SelfRenderControl.ButtonColorTable = New Gdu.WinFormUI.SelfRenderControl.ButtonColorTable()
        Dim ButtonColorTable3 As Gdu.WinFormUI.SelfRenderControl.ButtonColorTable = New Gdu.WinFormUI.SelfRenderControl.ButtonColorTable()
        Me.SuspendLayout()
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderWidth = 2
        Me.ClientSize = New System.Drawing.Size(589, 294)
        Me.CloseBoxSize = New System.Drawing.Size(16, 16)
        Me.ControlBoxOffset = New System.Drawing.Point(12, 8)
        Me.ControlBoxSpace = 6
        Me.MaxBoxSize = New System.Drawing.Size(16, 16)
        Me.MinBoxSize = New System.Drawing.Size(16, 16)
        Me.MinimumSize = New System.Drawing.Size(160, 60)
        Me.Name = "FrmMain"
        Me.Round = Gdu.WinFormUI.MyGraphics.RoundStyle.Top
        Me.Text = "KittenNote-Beta"
        ThemeMac1.BorderWidth = 2
        ThemeMac1.CaptionBackColorBottom = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        ThemeMac1.CaptionBackColorTop = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        ThemeMac1.CaptionHeight = 28
        ThemeMac1.CaptionTextCenter = True
        ThemeMac1.CaptionTextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ThemeMac1.CloseBoxBackImageHover = CType(resources.GetObject("ThemeMac1.CloseBoxBackImageHover"), System.Drawing.Image)
        ThemeMac1.CloseBoxBackImageNormal = CType(resources.GetObject("ThemeMac1.CloseBoxBackImageNormal"), System.Drawing.Image)
        ThemeMac1.CloseBoxBackImagePressed = CType(resources.GetObject("ThemeMac1.CloseBoxBackImagePressed"), System.Drawing.Image)
        ButtonColorTable1.BackColorHover = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(244, Byte), Integer))
        ButtonColorTable1.BackColorNormal = System.Drawing.Color.Empty
        ButtonColorTable1.BackColorPressed = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(166, Byte), Integer))
        ButtonColorTable1.BorderColorHover = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(101, Byte), Integer))
        ButtonColorTable1.BorderColorNormal = System.Drawing.Color.Empty
        ButtonColorTable1.BorderColorPressed = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(101, Byte), Integer))
        ButtonColorTable1.ForeColorHover = System.Drawing.Color.Black
        ButtonColorTable1.ForeColorNormal = System.Drawing.Color.Black
        ButtonColorTable1.ForeColorPressed = System.Drawing.Color.Black
        ThemeMac1.CloseBoxColor = ButtonColorTable1
        ThemeMac1.CloseBoxSize = New System.Drawing.Size(16, 16)
        ThemeMac1.ControlBoxOffset = New System.Drawing.Point(12, 8)
        ThemeMac1.ControlBoxSpace = 6
        ThemeMac1.DrawCaptionIcon = True
        ThemeMac1.DrawCaptionText = True
        ThemeMac1.FormBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        ThemeMac1.FormBorderInmostColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(219, Byte), Integer))
        ThemeMac1.FormBorderInnerColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ThemeMac1.FormBorderOutterColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(101, Byte), Integer))
        ThemeMac1.IconLeftMargin = 2
        ThemeMac1.IconSize = New System.Drawing.Size(16, 16)
        ThemeMac1.MaxBoxBackImageHover = CType(resources.GetObject("ThemeMac1.MaxBoxBackImageHover"), System.Drawing.Image)
        ThemeMac1.MaxBoxBackImageNormal = CType(resources.GetObject("ThemeMac1.MaxBoxBackImageNormal"), System.Drawing.Image)
        ThemeMac1.MaxBoxBackImagePressed = CType(resources.GetObject("ThemeMac1.MaxBoxBackImagePressed"), System.Drawing.Image)
        ThemeMac1.MaxBoxColor = ButtonColorTable1
        ThemeMac1.MaxBoxSize = New System.Drawing.Size(16, 16)
        ThemeMac1.Mdi_AlwaysShowListAllBtn = True
        ThemeMac1.Mdi_BarBackColor = System.Drawing.Color.LightSkyBlue
        ThemeMac1.Mdi_BarBorderColor = System.Drawing.Color.Red
        ThemeMac1.Mdi_BarBottomRegionBackColor = System.Drawing.Color.White
        ThemeMac1.Mdi_BarBottomRegionHeight = 3
        ThemeMac1.Mdi_BarLeftPadding = 3
        ThemeMac1.Mdi_BarMargin = New System.Windows.Forms.Padding(6, 38, 100, 0)
        ThemeMac1.Mdi_BarRightPadding = 100
        ThemeMac1.Mdi_DrawBarBackground = False
        ThemeMac1.Mdi_DrawBarBorder = False
        ThemeMac1.Mdi_ListAllBtnAlign = Gdu.WinFormUI.SelfRenderControl.BarButtonAlignmentType.Left
        ThemeMac1.Mdi_ListAllBtnBottomSpace = 7
        ButtonColorTable2.BackColorHover = System.Drawing.Color.HotPink
        ButtonColorTable2.BackColorNormal = System.Drawing.Color.LightPink
        ButtonColorTable2.BackColorPressed = System.Drawing.Color.DeepPink
        ButtonColorTable2.BorderColorHover = System.Drawing.Color.Empty
        ButtonColorTable2.BorderColorNormal = System.Drawing.Color.Empty
        ButtonColorTable2.BorderColorPressed = System.Drawing.Color.Empty
        ButtonColorTable2.ForeColorHover = System.Drawing.Color.Black
        ButtonColorTable2.ForeColorNormal = System.Drawing.Color.Black
        ButtonColorTable2.ForeColorPressed = System.Drawing.Color.Black
        ThemeMac1.Mdi_ListAllBtnColor = ButtonColorTable2
        ThemeMac1.Mdi_ListAllBtnLeftSpace = 4
        ThemeMac1.Mdi_ListAllBtnSize = New System.Drawing.Size(36, 18)
        ThemeMac1.Mdi_NewTabBtnBottomSpace = 7
        ButtonColorTable3.BackColorHover = System.Drawing.Color.HotPink
        ButtonColorTable3.BackColorNormal = System.Drawing.Color.LightPink
        ButtonColorTable3.BackColorPressed = System.Drawing.Color.DeepPink
        ButtonColorTable3.BorderColorHover = System.Drawing.Color.Empty
        ButtonColorTable3.BorderColorNormal = System.Drawing.Color.Empty
        ButtonColorTable3.BorderColorPressed = System.Drawing.Color.Empty
        ButtonColorTable3.ForeColorHover = System.Drawing.Color.Black
        ButtonColorTable3.ForeColorNormal = System.Drawing.Color.Black
        ButtonColorTable3.ForeColorPressed = System.Drawing.Color.Black
        ThemeMac1.Mdi_NewTabBtnColor = ButtonColorTable3
        ThemeMac1.Mdi_NewTabBtnLeftSpace = 4
        ThemeMac1.Mdi_NewTabBtnSize = New System.Drawing.Size(25, 18)
        ThemeMac1.Mdi_ShowNewTabBtn = True
        ThemeMac1.Mdi_ShowTabIcon = True
        ThemeMac1.Mdi_TabActiveBackColorBottom = System.Drawing.Color.White
        ThemeMac1.Mdi_TabActiveBackColorTop = System.Drawing.Color.White
        ThemeMac1.Mdi_TabAndTabSpace = -8
        ThemeMac1.Mdi_TabDeactiveBackColorBottom = System.Drawing.Color.DarkGray
        ThemeMac1.Mdi_TabDeactiveBackColorTop = System.Drawing.Color.LightGray
        ThemeMac1.Mdi_TabHeight = 26
        ThemeMac1.Mdi_TabHeightActive = 26
        ThemeMac1.Mdi_TabInnerBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ThemeMac1.Mdi_TabMaxWidth = 360
        ThemeMac1.Mdi_TabMinWidth = 90
        ThemeMac1.Mdi_TabNormalWidth = 180
        ThemeMac1.Mdi_TabOutterBorderColor = System.Drawing.Color.Gray
        ThemeMac1.Mdi_TabSlopeWidth = 8
        ThemeMac1.Mdi_TabTopSpace = 2
        ThemeMac1.Mdi_UseMsgToActivateChild = True
        ThemeMac1.MinBoxBackImageHover = CType(resources.GetObject("ThemeMac1.MinBoxBackImageHover"), System.Drawing.Image)
        ThemeMac1.MinBoxBackImageNormal = CType(resources.GetObject("ThemeMac1.MinBoxBackImageNormal"), System.Drawing.Image)
        ThemeMac1.MinBoxBackImagePressed = CType(resources.GetObject("ThemeMac1.MinBoxBackImagePressed"), System.Drawing.Image)
        ThemeMac1.MinBoxColor = ButtonColorTable1
        ThemeMac1.MinBoxSize = New System.Drawing.Size(16, 16)
        ThemeMac1.Radius = 8
        ThemeMac1.ResBoxBackImageHover = CType(resources.GetObject("ThemeMac1.ResBoxBackImageHover"), System.Drawing.Image)
        ThemeMac1.ResBoxBackImageNormal = CType(resources.GetObject("ThemeMac1.ResBoxBackImageNormal"), System.Drawing.Image)
        ThemeMac1.ResBoxBackImagePressed = CType(resources.GetObject("ThemeMac1.ResBoxBackImagePressed"), System.Drawing.Image)
        ThemeMac1.RoundedStyle = Gdu.WinFormUI.MyGraphics.RoundStyle.Top
        ThemeMac1.SetClientInset = False
        ThemeMac1.ShadowAValueDark = 80
        ThemeMac1.ShadowAValueLight = 0
        ThemeMac1.ShadowColor = System.Drawing.Color.Black
        ThemeMac1.ShadowWidth = 6
        ThemeMac1.ShowShadow = False
        ThemeMac1.SideResizeWidth = 6
        ThemeMac1.TextLeftMargin = 2
        ThemeMac1.UseDefaultTopRoundingFormRegion = False
        ThemeMac1.UseShadowToResize = False
        Me.XTheme = ThemeMac1
        Me.ResumeLayout(False)

    End Sub
End Class
