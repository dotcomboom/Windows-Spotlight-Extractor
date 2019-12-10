<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Img = New System.Windows.Forms.ImageList(Me.components)
        Me.Mnu = New System.Windows.Forms.MainMenu(Me.components)
        Me.FileMnu = New System.Windows.Forms.MenuItem
        Me.OpenFolder = New System.Windows.Forms.MenuItem
        Me.Extract = New System.Windows.Forms.MenuItem
        Me.FileSep = New System.Windows.Forms.MenuItem
        Me.ExitApplication = New System.Windows.Forms.MenuItem
        Me.HelpMnu = New System.Windows.Forms.MenuItem
        Me.About = New System.Windows.Forms.MenuItem
        Me.Browser = New System.Windows.Forms.FolderBrowserDialog
        Me.List = New System.Windows.Forms.ListView
        Me.Context = New System.Windows.Forms.ContextMenu
        Me.CopyCon = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'Img
        '
        Me.Img.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.Img.ImageSize = New System.Drawing.Size(16, 16)
        Me.Img.TransparentColor = System.Drawing.Color.Transparent
        '
        'Mnu
        '
        Me.Mnu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.FileMnu, Me.HelpMnu})
        '
        'FileMnu
        '
        Me.FileMnu.Index = 0
        Me.FileMnu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.OpenFolder, Me.Extract, Me.FileSep, Me.ExitApplication})
        Me.FileMnu.Text = "File"
        '
        'OpenFolder
        '
        Me.OpenFolder.Index = 0
        Me.OpenFolder.Text = "Open Cache Folder"
        '
        'Extract
        '
        Me.Extract.Enabled = False
        Me.Extract.Index = 1
        Me.Extract.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.Extract.Text = "Extract"
        '
        'FileSep
        '
        Me.FileSep.Index = 2
        Me.FileSep.Text = "-"
        '
        'ExitApplication
        '
        Me.ExitApplication.Index = 3
        Me.ExitApplication.Text = "Exit"
        '
        'HelpMnu
        '
        Me.HelpMnu.Index = 1
        Me.HelpMnu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.About})
        Me.HelpMnu.Text = "Help"
        '
        'About
        '
        Me.About.Index = 0
        Me.About.Text = "About"
        '
        'Browser
        '
        Me.Browser.Description = "Choose a folder to extract selected images."
        '
        'List
        '
        Me.List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.List.LargeImageList = Me.Img
        Me.List.Location = New System.Drawing.Point(0, 0)
        Me.List.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(696, 380)
        Me.List.SmallImageList = Me.Img
        Me.List.TabIndex = 0
        Me.List.UseCompatibleStateImageBehavior = False
        Me.List.View = System.Windows.Forms.View.SmallIcon
        '
        'Context
        '
        Me.Context.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.CopyCon})
        '
        'CopyCon
        '
        Me.CopyCon.DefaultItem = True
        Me.CopyCon.Index = 0
        Me.CopyCon.Text = "Extract"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 380)
        Me.Controls.Add(Me.List)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Menu = Me.Mnu
        Me.Name = "Main"
        Me.Text = "Windows Spotlight Extractor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Img As System.Windows.Forms.ImageList
    Friend WithEvents Mnu As System.Windows.Forms.MainMenu
    Friend WithEvents Extract As System.Windows.Forms.MenuItem
    Friend WithEvents Browser As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents List As System.Windows.Forms.ListView
    Friend WithEvents OpenFolder As System.Windows.Forms.MenuItem
    Friend WithEvents HelpMnu As System.Windows.Forms.MenuItem
    Friend WithEvents About As System.Windows.Forms.MenuItem
    Friend WithEvents Context As System.Windows.Forms.ContextMenu
    Friend WithEvents CopyCon As System.Windows.Forms.MenuItem
    Friend WithEvents FileMnu As System.Windows.Forms.MenuItem
    Friend WithEvents FileSep As System.Windows.Forms.MenuItem
    Friend WithEvents ExitApplication As System.Windows.Forms.MenuItem

End Class
