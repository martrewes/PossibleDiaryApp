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
        Me.btnLoadFolder = New System.Windows.Forms.Button()
        Me.calMonth = New System.Windows.Forms.MonthCalendar()
        Me.tbxDate = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.tvbRoot = New System.Windows.Forms.TreeView()
        Me.tvbImgList = New System.Windows.Forms.ImageList(Me.components)
        Me.fbDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.rtbDiaryEntry = New System.Windows.Forms.RichTextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLoadFolder
        '
        Me.btnLoadFolder.Location = New System.Drawing.Point(239, 12)
        Me.btnLoadFolder.Name = "btnLoadFolder"
        Me.btnLoadFolder.Size = New System.Drawing.Size(101, 23)
        Me.btnLoadFolder.TabIndex = 0
        Me.btnLoadFolder.Text = "Change Folder"
        Me.btnLoadFolder.UseVisualStyleBackColor = True
        '
        'calMonth
        '
        Me.calMonth.Location = New System.Drawing.Point(0, 18)
        Me.calMonth.MaxSelectionCount = 1
        Me.calMonth.Name = "calMonth"
        Me.calMonth.TabIndex = 1
        '
        'tbxDate
        '
        Me.tbxDate.Location = New System.Drawing.Point(688, 18)
        Me.tbxDate.Name = "tbxDate"
        Me.tbxDate.Size = New System.Drawing.Size(100, 20)
        Me.tbxDate.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(233, 425)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 13)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Label1"
        '
        'tvbRoot
        '
        Me.tvbRoot.Location = New System.Drawing.Point(0, 192)
        Me.tvbRoot.Name = "tvbRoot"
        Me.tvbRoot.Size = New System.Drawing.Size(227, 258)
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
        Me.rtbDiaryEntry.Location = New System.Drawing.Point(233, 44)
        Me.rtbDiaryEntry.Name = "rtbDiaryEntry"
        Me.rtbDiaryEntry.Size = New System.Drawing.Size(554, 365)
        Me.rtbDiaryEntry.TabIndex = 5
        Me.rtbDiaryEntry.Text = ""
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(346, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.rtbDiaryEntry)
        Me.Controls.Add(Me.tvbRoot)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.tbxDate)
        Me.Controls.Add(Me.calMonth)
        Me.Controls.Add(Me.btnLoadFolder)
        Me.Name = "MainForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Personal Diary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoadFolder As Button
    Friend WithEvents calMonth As MonthCalendar
    Friend WithEvents tbxDate As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents tvbRoot As TreeView
    Friend WithEvents tvbImgList As ImageList
    Friend WithEvents fbDialog As FolderBrowserDialog
    Friend WithEvents rtbDiaryEntry As RichTextBox
    Friend WithEvents btnSave As Button
End Class
