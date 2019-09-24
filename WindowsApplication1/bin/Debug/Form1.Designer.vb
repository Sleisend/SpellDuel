<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Download_Percent = New System.Windows.Forms.Label()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.LogoBox = New System.Windows.Forms.PictureBox()
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.TopLabel = New System.Windows.Forms.Label()
        Me.Infotext = New System.Windows.Forms.Label()
        Me.Infotext_button = New System.Windows.Forms.Button()
        Me.Version = New System.Windows.Forms.Label()
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(24, 380)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(322, 35)
        Me.BtnUpdate.TabIndex = 0
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(24, 339)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(420, 35)
        Me.ProgressBar1.Step = 2
        Me.ProgressBar1.TabIndex = 4
        '
        'Download_Percent
        '
        Me.Download_Percent.AutoSize = True
        Me.Download_Percent.BackColor = System.Drawing.Color.Transparent
        Me.Download_Percent.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Download_Percent.ForeColor = System.Drawing.Color.Black
        Me.Download_Percent.Location = New System.Drawing.Point(404, 348)
        Me.Download_Percent.Name = "Download_Percent"
        Me.Download_Percent.Size = New System.Drawing.Size(16, 15)
        Me.Download_Percent.TabIndex = 6
        Me.Download_Percent.Text = "%"
        '
        'BtnStart
        '
        Me.BtnStart.Enabled = False
        Me.BtnStart.Location = New System.Drawing.Point(24, 421)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(420, 35)
        Me.BtnStart.TabIndex = 2
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'LogoBox
        '
        Me.LogoBox.Location = New System.Drawing.Point(12, 12)
        Me.LogoBox.Name = "LogoBox"
        Me.LogoBox.Size = New System.Drawing.Size(443, 50)
        Me.LogoBox.TabIndex = 8
        Me.LogoBox.TabStop = False
        '
        'WebBrowser
        '
        Me.WebBrowser.AllowNavigation = False
        Me.WebBrowser.AllowWebBrowserDrop = False
        Me.WebBrowser.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser.Location = New System.Drawing.Point(12, 68)
        Me.WebBrowser.Margin = New System.Windows.Forms.Padding(1)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.Size = New System.Drawing.Size(443, 267)
        Me.WebBrowser.TabIndex = 9
        Me.WebBrowser.Url = New System.Uri("http://vortexirc.com/spellduel_changelog/changelog.html", System.UriKind.Absolute)
        Me.WebBrowser.WebBrowserShortcutsEnabled = False
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HeaderLabel.Location = New System.Drawing.Point(63, 12)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(323, 34)
        Me.HeaderLabel.TabIndex = 10
        Me.HeaderLabel.Text = "Spell Duel Placeholder Logo"
        '
        'TopLabel
        '
        Me.TopLabel.AutoSize = True
        Me.TopLabel.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TopLabel.Location = New System.Drawing.Point(8, 46)
        Me.TopLabel.Name = "TopLabel"
        Me.TopLabel.Size = New System.Drawing.Size(78, 20)
        Me.TopLabel.TabIndex = 11
        Me.TopLabel.Text = "Changelog"
        '
        'Infotext
        '
        Me.Infotext.BackColor = System.Drawing.SystemColors.Window
        Me.Infotext.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Infotext.Location = New System.Drawing.Point(12, 68)
        Me.Infotext.Name = "Infotext"
        Me.Infotext.Size = New System.Drawing.Size(443, 267)
        Me.Infotext.TabIndex = 12
        Me.Infotext.Text = resources.GetString("Infotext.Text")
        Me.Infotext.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Infotext.Visible = False
        '
        'Infotext_button
        '
        Me.Infotext_button.Location = New System.Drawing.Point(352, 380)
        Me.Infotext_button.Name = "Infotext_button"
        Me.Infotext_button.Size = New System.Drawing.Size(92, 35)
        Me.Infotext_button.TabIndex = 13
        Me.Infotext_button.Text = "Installation information"
        Me.Infotext_button.UseVisualStyleBackColor = True
        '
        'Version
        '
        Me.Version.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(343, 455)
        Me.Version.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(121, 15)
        Me.Version.TabIndex = 14
        Me.Version.Text = "Installer Version: 1.0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 470)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Infotext)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Infotext_button)
        Me.Controls.Add(Me.TopLabel)
        Me.Controls.Add(Me.HeaderLabel)
        Me.Controls.Add(Me.LogoBox)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.WebBrowser)
        Me.Controls.Add(Me.Download_Percent)
        Me.MaximumSize = New System.Drawing.Size(484, 509)
        Me.MinimumSize = New System.Drawing.Size(484, 509)
        Me.Name = "Form1"
        Me.Text = "Spell Duel Launcher"
        CType(Me.LogoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnUpdate As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Download_Percent As Label
    Friend WithEvents BtnStart As Button
    Friend WithEvents LogoBox As PictureBox
    Friend WithEvents WebBrowser As WebBrowser
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents TopLabel As Label
    Friend WithEvents Infotext As Label
    Friend WithEvents Infotext_button As Button
    Friend WithEvents Version As Label
End Class
