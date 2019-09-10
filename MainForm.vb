Imports System.IO
Imports System.IO.Compression
Public Class MainForm
    'Declare the global variables
    Dim folderpath As String
    Dim lblString As String
    Dim fontSize As Integer
    Dim fontName As String
    Private Sub FormLoad() Handles Me.Load

        'Checking if used before
        If My.Settings.RootPath = "" Then

            If (fbDialog.ShowDialog() = DialogResult.OK) Then
                folderpath = fbDialog.SelectedPath
            Else
                MessageBox.Show("You must select a folder to continue")
                Me.Close()
            End If
        Else folderpath = My.Settings.RootPath
        End If
        AddCustomFolderRootNode(folderpath)
        tvbRoot.ExpandAll()
        ReadData()
        My.Settings.RootPath = folderpath
        fontSize = My.Settings.FontSize
        fontName = My.Settings.FontName
        AddFonts()
        ChangeFont()
        cbxFont.Text = fontName
        tvbRoot.Width = calMonth.Width
        rtbDiaryEntry.Location = New Point(tvbRoot.Width + 2, lblDateText.Location.Y + lblDateText.Height + 2)
        rtbDiaryEntry.Width = ClientSize.Width - (tvbRoot.Width + 2)
        rtbDiaryEntry.Height = ClientSize.Height - (lblDateText.Height + StatusStrip1.Height)

        lblDateText.Text = calMonth.SelectionRange.Start.DayOfWeek.ToString & ", " & calMonth.SelectionRange.Start.ToLongDateString



    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calMonth.DateChanged

        WriteData() 'write changes first (if any) then read from next date
        ReadData()
        AddCustomFolderRootNode(folderpath)
        tvbRoot.ExpandAll()
        lblDateText.Text = calMonth.SelectionRange.Start.DayOfWeek.ToString & ", " & calMonth.SelectionRange.Start.ToLongDateString

    End Sub

    Private Sub TvbRoot_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvbRoot.NodeMouseClick
        'Make sure it is the left mouse button that was clicked and that the node is a File node.
        If e.Button = MouseButtons.Left AndAlso File.Exists(e.Node.Tag.ToString) Then

            WriteData()

            lblString = e.Node.Tag.ToString

            'Hacky code to get the date from the filename in the TreeVeiw
            Dim strFileName As String
            Dim strFileDate As Date

            'Converting the string to a DateTime format To Then convert To readable Date
            strFileName = lblString.Replace(folderpath & "\", "")
            strFileName = strFileName.Replace(".txt", "")
            strFileName = strFileName.Replace("\", "-")
            strFileDate = Date.ParseExact(strFileName, "yyyy-MM-dd", Nothing)
            lblDateText.Text = strFileDate.DayOfWeek.ToString & ", " & strFileDate.ToLongDateString

            rtbDiaryEntry.LoadFile(e.Node.Tag.ToString, RichTextBoxStreamType.PlainText)
            rtbDiaryEntry.Text = rtbDiaryEntry.Text.Remove(rtbDiaryEntry.TextLength - 1)

        End If
    End Sub

    Private Sub ReadData()

        lblString = folderpath & "\" & calMonth.SelectionRange.Start.Year & "\" & calMonth.SelectionRange.Start.Month.ToString("D2") & "\" & calMonth.SelectionRange.Start.Day.ToString("D2") & ".txt"

        If File.Exists(lblString) Then
            rtbDiaryEntry.LoadFile(lblString, RichTextBoxStreamType.PlainText)
            rtbDiaryEntry.Text = rtbDiaryEntry.Text.Remove(rtbDiaryEntry.TextLength - 1) 'stops endless streams of new lines being added each time date/file is changed
        End If

        tvbRoot.Update()

    End Sub

    Private Sub WriteData()

        If rtbDiaryEntry.Text = "" Then

        Else
            Directory.CreateDirectory(folderpath & "\" & calMonth.SelectionRange.Start.Year & "\" & calMonth.SelectionRange.Start.Month.ToString("D2"))

            Dim sw As New System.IO.StreamWriter(lblString)

            If Not File.Exists(lblDate.Text & ".txt") Then
                File.Create(lblDate.Text & ".txt").Close()

            End If

            For Each sLine As String In rtbDiaryEntry.Lines
                sw.WriteLine(sLine)
            Next
            sw.Close()
            rtbDiaryEntry.Text = ""
        End If

    End Sub

    Private Sub ChangeFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeFolderToolStripMenuItem.Click
        If (fbDialog.ShowDialog() = DialogResult.OK) Then
            folderpath = fbDialog.SelectedPath
            My.Settings.RootPath = folderpath
            AddCustomFolderRootNode(folderpath)
        End If

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim sw As New System.IO.StreamWriter(lblString) 'Just an option to save manually
        For Each sLine As String In rtbDiaryEntry.Lines
            sw.WriteLine(sLine)
        Next
        sw.Close()
        'rtbDiaryEntry.SaveFile(lblString, RichTextBoxStreamType.RichText)
    End Sub

    Private Sub RtbDiaryEntry_TextChanged(sender As Object, e As EventArgs) Handles rtbDiaryEntry.TextChanged
        Static rex As New System.Text.RegularExpressions.Regex("\b", System.Text.RegularExpressions.RegexOptions.Compiled Or System.Text.RegularExpressions.RegexOptions.Multiline)
        'Counts words and characters as the user types
        lblWordCount.Text = "Words: " & (rex.Matches(rtbDiaryEntry.Text).Count / 2).ToString()
        lblCharCount.Text = "Characters: " & rtbDiaryEntry.TextLength
    End Sub

    Private Sub AddCustomFolderRootNode(folderpath As String) 'This code is taken from a tutorial on how to create directories into a TreeView, stripped of anything irrelevent
        tvbRoot.Nodes.Clear()
        If Directory.Exists(folderpath) Then 'check to make sure the folder exists before adding a node for it

            Dim FolderName As String = New DirectoryInfo(folderpath).Name 'get just the folder's name from the specified folder path.
            Dim rootNode As New TreeNode(FolderName) 'create a new TreeNode using the folder's name for the node's Text property.

            With rootNode
                .Tag = folderpath 'set the root node's Tag property to the folder's full path. This is used to get the full path of the folder that this node represents.

                'if the specified folder contains any sub files/folders, add an empty child node to this root node. This will add the [+] sign on the root node which will allow it to be expanded.
                If Directory.GetDirectories(folderpath).Count > 0 OrElse Directory.GetFiles(folderpath).Count > 0 Then
                    .Nodes.Add("Empty")
                End If
            End With

            tvbRoot.Nodes.Add(rootNode) 'add this root node to the treeview
        End If


    End Sub

    Private Sub AddChildNodes(tn As TreeNode, DirPath As String) 'This code is taken from a tutorial on how to create directories into a TreeView, stripped of anything irrelevent
        Dim DirInfo As New DirectoryInfo(DirPath) 'Create a new DirectoryInfo class for the directory

        'We will place the code that iterates through the sub directories and files in a Try Catch because we might run into a folder or file
        'that we do not have the proper permissions to access. This will stop the code from throwing an exception and crashing our application.
        'We will use the Catch to handle any exceptions and let the user know what happened. Then the program can continue.
        Try
            For Each di As DirectoryInfo In DirInfo.GetDirectories 'iterate through sub folders of this directory or drive

                If Not (di.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then 'Make sure it is not a hidden folder, we don`t want them
                    Dim FolderNode As New TreeNode(di.Name) 'ceate a new TreeNode for the folder
                    With FolderNode
                        .Tag = di.FullName 'add the full folder path to the Tag property
                        .Nodes.Add("*Empty*") 'add an empty node to this child node so it can be expanded in the TreeView

                    End With
                    tn.Nodes.Add(FolderNode) 'add this folder node to the node that was expanded, the one passed to this sub
                End If
            Next

            For Each fi As FileInfo In DirInfo.GetFiles 'iterate through the files in this directory or drive

                If Not (fi.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then 'Make sure it is not a hidden file, we don`t want them

                    'here is where we need to use the returned ImageKey that was used in the AddImageToImgList function to add the image to the ImageList.
                    'If you remember, if it is a registered file other than an exe, lnk, or url file type, the ImageKey name will be the extension of the file.
                    'Otherwise, it will be the full path to the file that is used to add the image to the ImageList.

                    Dim FileNode As New TreeNode(fi.Name) ' create a new TreeNode for this file
                    With FileNode
                        .Tag = fi.FullName 'add the full path to the file to the Tag property
                    End With
                    tn.Nodes.Add(FileNode) 'add this file node to the node that was expanded, the one passed to this sub
                End If
            Next

        Catch ex As Exception 'if an exception was thrown trying to access a folder or file, let the user know what exception was thrown
            MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TvbRoot_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles tvbRoot.BeforeExpand 'This code is taken from a tutorial on how to create directories into a TreeView, stripped of anything irrelevent
        Dim DrvIsReady As Boolean = (From d As DriveInfo In DriveInfo.GetDrives Where d.Name = e.Node.ImageKey Select d.IsReady).FirstOrDefault

        'if the node is not the Desktop node and does not contain a full folder path, or if it is a drive that is ready, or if the directory path
        'exists, we can add the child nodes to it from a single path that it`s Tag property has been set to.
        If (e.Node.ImageKey <> "Desktop" AndAlso Not e.Node.ImageKey.Contains(":\")) OrElse DrvIsReady OrElse Directory.Exists(e.Node.ImageKey) Then
            e.Node.Nodes.Clear() 'clear the "Empty" child node from this node
            AddChildNodes(e.Node, e.Node.Tag.ToString) 'call our sub to add the child nodes to this node

        ElseIf e.Node.ImageKey = "Desktop" Then 'if the node is the Desktop node, we need to add the child nodes from two different folders.
            e.Node.Nodes.Clear() 'clear the "Empty" child node from this node

            'If a program was installed on the computer for all useres, the desktop shortcut will be placed in the CommonDesktopFolder. If a program was
            'installed for the current user only, then the desktop shortcut would be placed in the Desktop folder. So, we need to add the child nodes to
            'this node from two different folders in order to make sure we get all the shortcuts that the user sees on their desktop.
            Dim PublicDesktopFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory)
            Dim CurrentUserDesktopFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            AddChildNodes(e.Node, CurrentUserDesktopFolder)
            AddChildNodes(e.Node, PublicDesktopFolder)

        Else 'if it makes it to the Else part, it indicates that it must be a CD or DVD-ROM drive that is not ready (No disc in the drive).
            e.Cancel = True 'cancel the node from expanding and then let the user know why
            MessageBox.Show("The CD or DVD drive is empty.", "Drive Info...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TvbRoot_AfterCollapse(sender As Object, e As TreeViewEventArgs) Handles tvbRoot.AfterCollapse
        e.Node.Nodes.Clear()
        e.Node.Nodes.Add("Empty")
    End Sub

    Private Sub ExportToZipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToZipToolStripMenuItem.Click
        sfDialog.Filter = "ZIP Files (*.zip*)|*.zip"
        If sfDialog.ShowDialog = Windows.Forms.DialogResult.OK _
       Then
            ZipFile.CreateFromDirectory(folderpath, sfDialog.FileName)
        End If

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        fontSize = TrackBar1.Value
        ChangeFont()
        My.Settings.FontSize = fontSize
        lblFontSize.Text = "Font Size: " & fontSize
    End Sub

    Private Sub ChangeFont()
        rtbDiaryEntry.Font = New Font(fontName, fontSize)
        lblFontSize.Text = "Font Size: " & fontSize

    End Sub

    Private Sub AddFonts()
        Dim allFonts As New Drawing.Text.InstalledFontCollection
        Dim fontFamilies() As FontFamily = allFonts.Families()

        For Each myFont As FontFamily In fontFamilies
            cbxFont.Items.Add(myFont.Name)
        Next
    End Sub

    Private Sub CbxFont_TextChanged(sender As Object, e As EventArgs) Handles cbxFont.SelectedIndexChanged
        fontName = cbxFont.Text
        ChangeFont()
        My.Settings.FontName = fontName
    End Sub
End Class
