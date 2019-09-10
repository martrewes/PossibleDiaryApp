<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.calMonth = New System.Windows.Forms.MonthCalendar()
        Me.tbxDate = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.tvbRoot = New System.Windows.Forms.TreeView()
        Me.tvbImgList = New System.Windows.Forms.ImageList(Me.components)
        Me.fbDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.rtbDiaryEntry = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ChangeFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToZipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblCharCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblWordCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDateText = New System.Windows.Forms.Label()
        Me.sfDialog = New System.Windows.Forms.SaveFileDialog()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.lblFontSize = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'calMonth
        '
        Me.calMonth.Location = New System.Drawing.Point(0, 37)
        Me.calMonth.Margin = New System.Windows.Forms.Padding(14)
        Me.calMonth.MaxSelectionCount = 1
        Me.calMonth.Name = "calMonth"
        Me.calMonth.TabIndex = 0
        '
        'tbxDate
        '
        Me.tbxDate.Location = New System.Drawing.Point(1032, 28)
        Me.tbxDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxDate.Name = "tbxDate"
        Me.tbxDate.Size = New System.Drawing.Size(148, 26)
        Me.tbxDate.TabIndex = 2
        Me.tbxDate.Visible = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(657, 12)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 20)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Visible = False
        '
        'tvbRoot
        '
        Me.tvbRoot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tvbRoot.Location = New System.Drawing.Point(0, 300)
        Me.tvbRoot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tvbRoot.Name = "tvbRoot"
        Me.tvbRoot.Size = New System.Drawing.Size(312, 353)
        Me.tvbRoot.TabIndex = 4
        '
        'tvbImgList
        '
        Me.tvbImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.tvbImgList.ImageSize = New System.Drawing.Size(16, 16)
        Me.tvbImgList.TransparentColor = System.Drawing.Color.Transparent
        '
        'fbDialog
        '
        Me.fbDialog.Description = "Please select a folder as the root of your diary (new or existing)"
        '
        'rtbDiaryEntry
        '
        Me.rtbDiaryEntry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbDiaryEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtbDiaryEntry.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDiaryEntry.Location = New System.Drawing.Point(320, 40)
        Me.rtbDiaryEntry.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rtbDiaryEntry.Name = "rtbDiaryEntry"
        Me.rtbDiaryEntry.Size = New System.Drawing.Size(854, 616)
        Me.rtbDiaryEntry.TabIndex = 5
        Me.rtbDiaryEntry.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeFolderToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExportToZipToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(354, 35)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChangeFolderToolStripMenuItem
        '
        Me.ChangeFolderToolStripMenuItem.Name = "ChangeFolderToolStripMenuItem"
        Me.ChangeFolderToolStripMenuItem.Size = New System.Drawing.Size(143, 29)
        Me.ChangeFolderToolStripMenuItem.Text = "Change Folder"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExportToZipToolStripMenuItem
        '
        Me.ExportToZipToolStripMenuItem.Name = "ExportToZipToolStripMenuItem"
        Me.ExportToZipToolStripMenuItem.Size = New System.Drawing.Size(141, 29)
        Me.ExportToZipToolStripMenuItem.Text = "Export to zip..."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblCharCount, Me.lblWordCount})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 660)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(21, 0, 2, 0)
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(1200, 32)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip"
        '
        'lblCharCount
        '
        Me.lblCharCount.Name = "lblCharCount"
        Me.lblCharCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCharCount.Size = New System.Drawing.Size(103, 25)
        Me.lblCharCount.Text = "Characters: "
        '
        'lblWordCount
        '
        Me.lblWordCount.Name = "lblWordCount"
        Me.lblWordCount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWordCount.Size = New System.Drawing.Size(68, 25)
        Me.lblWordCount.Text = "Words:"
        '
        'lblDateText
        '
        Me.lblDateText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateText.AutoSize = True
        Me.lblDateText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateText.Location = New System.Drawing.Point(358, 5)
        Me.lblDateText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateText.Name = "lblDateText"
        Me.lblDateText.Size = New System.Drawing.Size(228, 29)
        Me.lblDateText.TabIndex = 11
        Me.lblDateText.Text = "Date in Long Form"
        '
        'sfDialog
        '
        Me.sfDialog.DefaultExt = "zip"
        Me.sfDialog.Filter = "Zip files .zip | All files"
        '
        'TrackBar1
        '
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.Location = New System.Drawing.Point(214, 663)
        Me.TrackBar1.Maximum = 32
        Me.TrackBar1.Minimum = 6
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(104, 28)
        Me.TrackBar1.SmallChange = 2
        Me.TrackBar1.TabIndex = 12
        Me.TrackBar1.TickFrequency = 2
        Me.TrackBar1.Value = 12
        '
        'lblFontSize
        '
        Me.lblFontSize.AutoSize = True
        Me.lblFontSize.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFontSize.Location = New System.Drawing.Point(95, 663)
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(113, 25)
        Me.lblFontSize.TabIndex = 13
        Me.lblFontSize.Text = "Font Size: 12"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.lblFontSize)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.lblDateText)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.rtbDiaryEntry)
        Me.Controls.Add(Me.tvbRoot)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.tbxDate)
        Me.Controls.Add(Me.calMonth)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Personal Diary"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calMonth As MonthCalendar
    Friend WithEvents tbxDate As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents tvbRoot As TreeView
    Friend WithEvents tvbImgList As ImageList
    Friend WithEvents fbDialog As FolderBrowserDialog
    Friend WithEvents rtbDiaryEntry As RichTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ChangeFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblCharCount As ToolStripStatusLabel
    Friend WithEvents lblWordCount As ToolStripStatusLabel
    Friend WithEvents lblDateText As Label
    Friend WithEvents ExportToZipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents sfDialog As SaveFileDialog
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents lblFontSize As Label
End Class
