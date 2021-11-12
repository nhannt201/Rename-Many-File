<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.paths = New System.Windows.Forms.TextBox()
        Me.namedl = New System.Windows.Forms.TextBox()
        Me.namerp = New System.Windows.Forms.TextBox()
        Me.selct = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.filenm = New System.Windows.Forms.ListBox()
        Me.strname = New System.Windows.Forms.Button()
        Me.cplrm = New System.Windows.Forms.ListBox()
        Me.filepath = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.wait = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chọn thư mục :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên loại bỏ:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên thay thế:"
        '
        'paths
        '
        Me.paths.Enabled = False
        Me.paths.Location = New System.Drawing.Point(97, 15)
        Me.paths.Name = "paths"
        Me.paths.Size = New System.Drawing.Size(345, 20)
        Me.paths.TabIndex = 3
        '
        'namedl
        '
        Me.namedl.Location = New System.Drawing.Point(97, 43)
        Me.namedl.Name = "namedl"
        Me.namedl.Size = New System.Drawing.Size(345, 20)
        Me.namedl.TabIndex = 4
        '
        'namerp
        '
        Me.namerp.Location = New System.Drawing.Point(97, 68)
        Me.namerp.Name = "namerp"
        Me.namerp.Size = New System.Drawing.Size(345, 20)
        Me.namerp.TabIndex = 5
        '
        'selct
        '
        Me.selct.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selct.Location = New System.Drawing.Point(448, 11)
        Me.selct.Name = "selct"
        Me.selct.Size = New System.Drawing.Size(66, 27)
        Me.selct.TabIndex = 6
        Me.selct.Text = "&Chọn..."
        Me.selct.UseVisualStyleBackColor = True
        '
        'filenm
        '
        Me.filenm.Enabled = False
        Me.filenm.FormattingEnabled = True
        Me.filenm.Location = New System.Drawing.Point(12, 106)
        Me.filenm.Name = "filenm"
        Me.filenm.Size = New System.Drawing.Size(217, 225)
        Me.filenm.TabIndex = 8
        '
        'strname
        '
        Me.strname.Enabled = False
        Me.strname.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strname.Location = New System.Drawing.Point(448, 43)
        Me.strname.Name = "strname"
        Me.strname.Size = New System.Drawing.Size(66, 45)
        Me.strname.TabIndex = 9
        Me.strname.Text = "&Bắt đầu đổi tên"
        Me.strname.UseVisualStyleBackColor = True
        '
        'cplrm
        '
        Me.cplrm.FormattingEnabled = True
        Me.cplrm.Location = New System.Drawing.Point(247, 106)
        Me.cplrm.Name = "cplrm"
        Me.cplrm.ScrollAlwaysVisible = True
        Me.cplrm.Size = New System.Drawing.Size(267, 225)
        Me.cplrm.TabIndex = 10
        '
        'filepath
        '
        Me.filepath.FormattingEnabled = True
        Me.filepath.Location = New System.Drawing.Point(182, 106)
        Me.filepath.Name = "filepath"
        Me.filepath.Size = New System.Drawing.Size(47, 82)
        Me.filepath.TabIndex = 11
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'wait
        '
        Me.wait.AutoSize = True
        Me.wait.Location = New System.Drawing.Point(28, 91)
        Me.wait.Name = "wait"
        Me.wait.Size = New System.Drawing.Size(82, 13)
        Me.wait.TabIndex = 12
        Me.wait.Text = "Wait Progress..."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Wait Progress..."
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 340)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.wait)
        Me.Controls.Add(Me.filepath)
        Me.Controls.Add(Me.cplrm)
        Me.Controls.Add(Me.strname)
        Me.Controls.Add(Me.filenm)
        Me.Controls.Add(Me.selct)
        Me.Controls.Add(Me.namerp)
        Me.Controls.Add(Me.namedl)
        Me.Controls.Add(Me.paths)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rename Many File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents paths As TextBox
    Friend WithEvents namedl As TextBox
    Friend WithEvents namerp As TextBox
    Friend WithEvents selct As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents filenm As ListBox
    Friend WithEvents strname As Button
    Friend WithEvents cplrm As ListBox
    Friend WithEvents filepath As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents wait As Label
    Friend WithEvents Label4 As Label
End Class
