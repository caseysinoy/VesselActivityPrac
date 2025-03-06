Partial Public Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbtnCreateAct = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtn_ActivityList = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtn_vessel = New DevExpress.XtraBars.BarButtonItem()
        Me.dd = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.xtraTab = New DevExpress.XtraTab.XtraTabControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.xtraTab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.bbtnCreateAct, Me.bbtn_ActivityList, Me.bbtn_vessel, Me.dd})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 5
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.Size = New System.Drawing.Size(677, 142)
        '
        'bbtnCreateAct
        '
        Me.bbtnCreateAct.Caption = "Create Activity"
        Me.bbtnCreateAct.Id = 1
        Me.bbtnCreateAct.ImageOptions.LargeImage = Global.DXApplication1.My.Resources.Resources.fishing_boat
        Me.bbtnCreateAct.Name = "bbtnCreateAct"
        '
        'bbtn_ActivityList
        '
        Me.bbtn_ActivityList.Caption = "Activity List"
        Me.bbtn_ActivityList.Id = 2
        Me.bbtn_ActivityList.ImageOptions.LargeImage = Global.DXApplication1.My.Resources.Resources.daily_task
        Me.bbtn_ActivityList.Name = "bbtn_ActivityList"
        '
        'bbtn_vessel
        '
        Me.bbtn_vessel.Caption = "Add Vessel"
        Me.bbtn_vessel.Enabled = False
        Me.bbtn_vessel.Id = 3
        Me.bbtn_vessel.ImageOptions.Image = Global.DXApplication1.My.Resources.Resources.add_file
        Me.bbtn_vessel.Name = "bbtn_vessel"
        '
        'dd
        '
        Me.dd.Caption = "Add Activty"
        Me.dd.Enabled = False
        Me.dd.Id = 4
        Me.dd.ImageOptions.Image = Global.DXApplication1.My.Resources.Resources.add_file
        Me.dd.ImageOptions.LargeImage = Global.DXApplication1.My.Resources.Resources.add_file
        Me.dd.Name = "dd"
        Me.dd.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "Home"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.bbtnCreateAct)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.bbtn_ActivityList)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "Activity"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.bbtn_vessel)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.dd)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Action"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Caramel"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.xtraTab)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 142)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1270, 189, 650, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(677, 326)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'xtraTab
        '
        Me.xtraTab.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader
        Me.xtraTab.Location = New System.Drawing.Point(12, 12)
        Me.xtraTab.MultiLine = DevExpress.Utils.DefaultBoolean.[False]
        Me.xtraTab.Name = "xtraTab"
        Me.xtraTab.Size = New System.Drawing.Size(653, 302)
        Me.xtraTab.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(677, 326)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.xtraTab
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(657, 306)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'frmMain
        '
        Me.ClientSize = New System.Drawing.Size(677, 468)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Name = "frmMain"
        Me.Ribbon = Me.ribbonControl1
        Me.Text = "Vessel Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.xtraTab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents bbtnCreateAct As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtn_ActivityList As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents xtraTab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents bbtn_vessel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dd As DevExpress.XtraBars.BarButtonItem
End Class
