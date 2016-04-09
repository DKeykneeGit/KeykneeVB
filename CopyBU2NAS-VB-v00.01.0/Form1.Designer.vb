<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotNbrAllFilesCurrDir = New System.Windows.Forms.TextBox()
        Me.txtTotSizeAllFilesCurrDir = New System.Windows.Forms.TextBox()
        Me.txtTotNbrSelectedFilesCurrDir = New System.Windows.Forms.TextBox()
        Me.txtTotSizeSelectedFilesCurrDir = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblSelectedFileDte = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.lblCurrDir = New System.Windows.Forms.Label()
        Me.lblSameAsi = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotFilesToCopy = New System.Windows.Forms.Label()
        Me.lblFilePctDone = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.blPctAllSelFiles = New System.Windows.Forms.Label()
        Me.lblAllSelFilePctDone = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Copy Selected files to NAS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(2, 80)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(580, 407)
        Me.ListBox1.TabIndex = 1
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(588, 80)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(560, 407)
        Me.ListBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(796, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Selected File >= Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 501)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tot Nbr all files in CurDir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(318, 501)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tot Size all files in CurDir"
        '
        'txtTotNbrAllFilesCurrDir
        '
        Me.txtTotNbrAllFilesCurrDir.Location = New System.Drawing.Point(71, 526)
        Me.txtTotNbrAllFilesCurrDir.Name = "txtTotNbrAllFilesCurrDir"
        Me.txtTotNbrAllFilesCurrDir.Size = New System.Drawing.Size(65, 20)
        Me.txtTotNbrAllFilesCurrDir.TabIndex = 7
        Me.txtTotNbrAllFilesCurrDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotSizeAllFilesCurrDir
        '
        Me.txtTotSizeAllFilesCurrDir.AccessibleName = "txtTotSizeAllFilesCurrDir"
        Me.txtTotSizeAllFilesCurrDir.Location = New System.Drawing.Point(307, 526)
        Me.txtTotSizeAllFilesCurrDir.Name = "txtTotSizeAllFilesCurrDir"
        Me.txtTotSizeAllFilesCurrDir.Size = New System.Drawing.Size(150, 20)
        Me.txtTotSizeAllFilesCurrDir.TabIndex = 8
        Me.txtTotSizeAllFilesCurrDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotNbrSelectedFilesCurrDir
        '
        Me.txtTotNbrSelectedFilesCurrDir.Location = New System.Drawing.Point(663, 526)
        Me.txtTotNbrSelectedFilesCurrDir.Name = "txtTotNbrSelectedFilesCurrDir"
        Me.txtTotNbrSelectedFilesCurrDir.Size = New System.Drawing.Size(100, 20)
        Me.txtTotNbrSelectedFilesCurrDir.TabIndex = 9
        Me.txtTotNbrSelectedFilesCurrDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotSizeSelectedFilesCurrDir
        '
        Me.txtTotSizeSelectedFilesCurrDir.Location = New System.Drawing.Point(912, 525)
        Me.txtTotSizeSelectedFilesCurrDir.Name = "txtTotSizeSelectedFilesCurrDir"
        Me.txtTotSizeSelectedFilesCurrDir.Size = New System.Drawing.Size(152, 20)
        Me.txtTotSizeSelectedFilesCurrDir.TabIndex = 10
        Me.txtTotSizeSelectedFilesCurrDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(640, 501)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Tot Nbr Selected files in CurDir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(909, 501)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tot Size Selected files in CurDir"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(536, 557)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(566, 23)
        Me.ProgressBar1.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "List of all Files from Curr Dir"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1037, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Done"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblSelectedFileDte
        '
        Me.lblSelectedFileDte.AccessibleName = "lblSelectedFileDte"
        Me.lblSelectedFileDte.AutoSize = True
        Me.lblSelectedFileDte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSelectedFileDte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedFileDte.Location = New System.Drawing.Point(811, 56)
        Me.lblSelectedFileDte.MaximumSize = New System.Drawing.Size(2048, 50)
        Me.lblSelectedFileDte.Name = "lblSelectedFileDte"
        Me.lblSelectedFileDte.Size = New System.Drawing.Size(139, 18)
        Me.lblSelectedFileDte.TabIndex = 19
        Me.lblSelectedFileDte.Text = "Selected File Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 559)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "File BeingCopied"
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileName.Location = New System.Drawing.Point(263, 559)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(94, 18)
        Me.lblFileName.TabIndex = 21
        Me.lblFileName.Text = "lblFileName"
        '
        'lblCurrDir
        '
        Me.lblCurrDir.AutoSize = True
        Me.lblCurrDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrDir.Location = New System.Drawing.Point(152, 55)
        Me.lblCurrDir.Name = "lblCurrDir"
        Me.lblCurrDir.Size = New System.Drawing.Size(164, 15)
        Me.lblCurrDir.TabIndex = 22
        Me.lblCurrDir.Text = "Current Source Directory"
        '
        'lblSameAsi
        '
        Me.lblSameAsi.AutoSize = True
        Me.lblSameAsi.Location = New System.Drawing.Point(152, 559)
        Me.lblSameAsi.Name = "lblSameAsi"
        Me.lblSameAsi.Size = New System.Drawing.Size(15, 13)
        Me.lblSameAsi.TabIndex = 23
        Me.lblSameAsi.Text = "i="
        Me.lblSameAsi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(188, 557)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "of"
        '
        'lblTotFilesToCopy
        '
        Me.lblTotFilesToCopy.AutoSize = True
        Me.lblTotFilesToCopy.Location = New System.Drawing.Point(213, 559)
        Me.lblTotFilesToCopy.Name = "lblTotFilesToCopy"
        Me.lblTotFilesToCopy.Size = New System.Drawing.Size(44, 13)
        Me.lblTotFilesToCopy.TabIndex = 25
        Me.lblTotFilesToCopy.Text = "TotFiles"
        Me.lblTotFilesToCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFilePctDone
        '
        Me.lblFilePctDone.AutoSize = True
        Me.lblFilePctDone.Location = New System.Drawing.Point(1108, 564)
        Me.lblFilePctDone.Name = "lblFilePctDone"
        Me.lblFilePctDone.Size = New System.Drawing.Size(13, 13)
        Me.lblFilePctDone.TabIndex = 26
        Me.lblFilePctDone.Text = "0"
        Me.lblFilePctDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1137, 559)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "%"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(536, 587)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(566, 23)
        Me.ProgressBar2.TabIndex = 28
        '
        'blPctAllSelFiles
        '
        Me.blPctAllSelFiles.AutoSize = True
        Me.blPctAllSelFiles.Location = New System.Drawing.Point(351, 596)
        Me.blPctAllSelFiles.Name = "blPctAllSelFiles"
        Me.blPctAllSelFiles.Size = New System.Drawing.Size(156, 13)
        Me.blPctAllSelFiles.TabIndex = 29
        Me.blPctAllSelFiles.Text = "Percent All Selected Files Done"
        '
        'lblAllSelFilePctDone
        '
        Me.lblAllSelFilePctDone.AutoSize = True
        Me.lblAllSelFilePctDone.Location = New System.Drawing.Point(1108, 592)
        Me.lblAllSelFilePctDone.Name = "lblAllSelFilePctDone"
        Me.lblAllSelFilePctDone.Size = New System.Drawing.Size(13, 13)
        Me.lblAllSelFilePctDone.TabIndex = 30
        Me.lblAllSelFilePctDone.Text = "0"
        Me.lblAllSelFilePctDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1137, 587)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "%"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1417, 909)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblAllSelFilePctDone)
        Me.Controls.Add(Me.blPctAllSelFiles)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblFilePctDone)
        Me.Controls.Add(Me.lblTotFilesToCopy)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblSameAsi)
        Me.Controls.Add(Me.lblCurrDir)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblSelectedFileDte)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotSizeSelectedFilesCurrDir)
        Me.Controls.Add(Me.txtTotNbrSelectedFilesCurrDir)
        Me.Controls.Add(Me.txtTotSizeAllFilesCurrDir)
        Me.Controls.Add(Me.txtTotNbrAllFilesCurrDir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotNbrAllFilesCurrDir As TextBox
    Friend WithEvents txtTotSizeAllFilesCurrDir As TextBox
    Friend WithEvents txtTotNbrSelectedFilesCurrDir As TextBox
    Friend WithEvents txtTotSizeSelectedFilesCurrDir As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents lblSelectedFileDte As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblFileName As Label
    Friend WithEvents lblCurrDir As Label
    Friend WithEvents lblSameAsi As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTotFilesToCopy As Label
    Friend WithEvents lblFilePctDone As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents blPctAllSelFiles As Label
    Friend WithEvents lblAllSelFilePctDone As Label
    Friend WithEvents Label10 As Label
End Class
