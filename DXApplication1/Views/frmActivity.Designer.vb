<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActivity
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbtn_saveAct = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.bbtn_submitAct = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.deActDate = New DevExpress.XtraEditors.DateEdit()
        Me.teRep = New DevExpress.XtraEditors.TextEdit()
        Me.cbLoc = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbAct = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbVessel = New DevExpress.XtraEditors.LookUpEdit()
        Me.seLati = New DevExpress.XtraEditors.SpinEdit()
        Me.seLongi = New DevExpress.XtraEditors.SpinEdit()
        Me.teDesc = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.deActDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deActDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teRep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbLoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbVessel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seLati.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seLongi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.bbtn_saveAct, Me.BarButtonItem2, Me.bbtn_submitAct})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 4
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(709, 142)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'bbtn_saveAct
        '
        Me.bbtn_saveAct.Caption = "Save"
        Me.bbtn_saveAct.Id = 1
        Me.bbtn_saveAct.ImageOptions.LargeImage = Global.DXApplication1.My.Resources.Resources.save
        Me.bbtn_saveAct.Name = "bbtn_saveAct"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Remove"
        Me.BarButtonItem2.Enabled = False
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ImageOptions.LargeImage = Global.DXApplication1.My.Resources.Resources.delete
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'bbtn_submitAct
        '
        Me.bbtn_submitAct.Caption = "Post"
        Me.bbtn_submitAct.Enabled = False
        Me.bbtn_submitAct.Id = 3
        Me.bbtn_submitAct.ImageOptions.LargeImage = Global.DXApplication1.My.Resources.Resources.check
        Me.bbtn_submitAct.Name = "bbtn_submitAct"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Activity"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbtn_saveAct)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.bbtn_submitAct)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Actions"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 490)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(709, 25)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.XtraTabControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 142)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(935, 211, 650, 400)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(709, 348)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 12)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(685, 324)
        Me.XtraTabControl1.TabIndex = 4
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.LayoutControl2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(678, 296)
        Me.XtraTabPage1.Text = "Activity"
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.deActDate)
        Me.LayoutControl2.Controls.Add(Me.teRep)
        Me.LayoutControl2.Controls.Add(Me.cbLoc)
        Me.LayoutControl2.Controls.Add(Me.cbAct)
        Me.LayoutControl2.Controls.Add(Me.cbVessel)
        Me.LayoutControl2.Controls.Add(Me.seLati)
        Me.LayoutControl2.Controls.Add(Me.seLongi)
        Me.LayoutControl2.Controls.Add(Me.teDesc)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(918, 194, 650, 400)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(678, 296)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'deActDate
        '
        Me.deActDate.EditValue = Nothing
        Me.deActDate.Location = New System.Drawing.Point(75, 12)
        Me.deActDate.MenuManager = Me.RibbonControl
        Me.deActDate.Name = "deActDate"
        Me.deActDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deActDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deActDate.Size = New System.Drawing.Size(591, 20)
        Me.deActDate.StyleController = Me.LayoutControl2
        Me.deActDate.TabIndex = 14
        '
        'teRep
        '
        Me.teRep.Location = New System.Drawing.Point(75, 156)
        Me.teRep.MenuManager = Me.RibbonControl
        Me.teRep.Name = "teRep"
        Me.teRep.Size = New System.Drawing.Size(591, 20)
        Me.teRep.StyleController = Me.LayoutControl2
        Me.teRep.TabIndex = 12
        '
        'cbLoc
        '
        Me.cbLoc.Location = New System.Drawing.Point(75, 60)
        Me.cbLoc.MenuManager = Me.RibbonControl
        Me.cbLoc.Name = "cbLoc"
        Me.cbLoc.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbLoc.Size = New System.Drawing.Size(591, 20)
        Me.cbLoc.StyleController = Me.LayoutControl2
        Me.cbLoc.TabIndex = 8
        '
        'cbAct
        '
        Me.cbAct.Location = New System.Drawing.Point(75, 84)
        Me.cbAct.MenuManager = Me.RibbonControl
        Me.cbAct.Name = "cbAct"
        Me.cbAct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAct.Properties.NullText = ""
        Me.cbAct.Properties.PopupSizeable = False
        Me.cbAct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cbAct.Size = New System.Drawing.Size(591, 20)
        Me.cbAct.StyleController = Me.LayoutControl2
        Me.cbAct.TabIndex = 7
        '
        'cbVessel
        '
        Me.cbVessel.Location = New System.Drawing.Point(75, 36)
        Me.cbVessel.MenuManager = Me.RibbonControl
        Me.cbVessel.Name = "cbVessel"
        Me.cbVessel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbVessel.Properties.NullText = ""
        Me.cbVessel.Properties.PopupSizeable = False
        Me.cbVessel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cbVessel.Size = New System.Drawing.Size(591, 20)
        Me.cbVessel.StyleController = Me.LayoutControl2
        Me.cbVessel.TabIndex = 9
        '
        'seLati
        '
        Me.seLati.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seLati.Location = New System.Drawing.Point(75, 108)
        Me.seLati.MenuManager = Me.RibbonControl
        Me.seLati.Name = "seLati"
        Me.seLati.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.seLati.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.seLati.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.seLati.Size = New System.Drawing.Size(591, 20)
        Me.seLati.StyleController = Me.LayoutControl2
        Me.seLati.TabIndex = 11
        '
        'seLongi
        '
        Me.seLongi.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seLongi.Location = New System.Drawing.Point(75, 132)
        Me.seLongi.MenuManager = Me.RibbonControl
        Me.seLongi.Name = "seLongi"
        Me.seLongi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.seLongi.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.seLongi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.seLongi.Size = New System.Drawing.Size(591, 20)
        Me.seLongi.StyleController = Me.LayoutControl2
        Me.seLongi.TabIndex = 10
        '
        'teDesc
        '
        Me.teDesc.Location = New System.Drawing.Point(75, 180)
        Me.teDesc.MenuManager = Me.RibbonControl
        Me.teDesc.Name = "teDesc"
        Me.teDesc.Size = New System.Drawing.Size(591, 20)
        Me.teDesc.StyleController = Me.LayoutControl2
        Me.teDesc.TabIndex = 4
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem4, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10})
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(678, 296)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.teDesc
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(658, 24)
        Me.LayoutControlItem2.Text = "Description"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(60, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 192)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(658, 84)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cbAct
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(658, 24)
        Me.LayoutControlItem5.Text = "Activity"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(60, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.cbLoc
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(658, 24)
        Me.LayoutControlItem6.Text = "Location"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(60, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.cbVessel
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(658, 24)
        Me.LayoutControlItem7.Text = "Vessel"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(60, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.seLongi
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(658, 24)
        Me.LayoutControlItem4.Text = "Longitude"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(60, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.seLati
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(658, 24)
        Me.LayoutControlItem8.Text = "Latitude"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(60, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.teRep
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(658, 24)
        Me.LayoutControlItem9.Text = "Repair"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(60, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.deActDate
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(658, 24)
        Me.LayoutControlItem10.Text = "Activty Date"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(60, 13)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(709, 348)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.XtraTabControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(689, 328)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'frmActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 515)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmActivity"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Vessel Activity"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.deActDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deActDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teRep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbLoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbVessel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seLati.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.seLongi.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.teDesc.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlGroup2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.EmptySpaceItem1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem6,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem7,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem9,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem10,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlGroup1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LayoutControlItem1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents bbtn_saveAct As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbtn_submitAct As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents teRep As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbLoc As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents deActDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbAct As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents seLati As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents seLongi As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents teDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbVessel As DevExpress.XtraEditors.LookUpEdit


End Class
