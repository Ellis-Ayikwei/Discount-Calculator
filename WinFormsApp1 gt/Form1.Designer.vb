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
        PrintDialog1 = New PrintDialog()
        lblstudName = New Label()
        TBoxNameofStu = New TextBox()
        Programdropdown = New ComboBox()
        leveldropdown = New ComboBox()
        Sessiondropdown = New ComboBox()
        lblprgm = New Label()
        lblLevel = New Label()
        lblSession = New Label()
        Btn1StuInfo = New Button()
        BtnClr = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' lblstudName
        ' 
        lblstudName.AllowDrop = True
        lblstudName.Anchor = AnchorStyles.None
        lblstudName.AutoSize = True
        lblstudName.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        lblstudName.Location = New Point(208, 161)
        lblstudName.Name = "lblstudName"
        lblstudName.Size = New Size(234, 37)
        lblstudName.TabIndex = 0
        lblstudName.Text = "Name of Student"
        ' 
        ' TBoxNameofStu
        ' 
        TBoxNameofStu.AllowDrop = True
        TBoxNameofStu.Anchor = AnchorStyles.None
        TBoxNameofStu.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TBoxNameofStu.Location = New Point(453, 163)
        TBoxNameofStu.Name = "TBoxNameofStu"
        TBoxNameofStu.Size = New Size(579, 34)
        TBoxNameofStu.TabIndex = 1
        ' 
        ' Programdropdown
        ' 
        Programdropdown.AllowDrop = True
        Programdropdown.Anchor = AnchorStyles.None
        Programdropdown.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Programdropdown.FormattingEnabled = True
        Programdropdown.Items.AddRange(New Object() {"BSc. Information Technology", "BSc. Engineering", "Bsc. Business Administration"})
        Programdropdown.Location = New Point(208, 377)
        Programdropdown.Name = "Programdropdown"
        Programdropdown.Size = New Size(390, 36)
        Programdropdown.TabIndex = 2
        Programdropdown.Text = "Select programme"
        ' 
        ' leveldropdown
        ' 
        leveldropdown.AccessibleDescription = ""
        leveldropdown.AllowDrop = True
        leveldropdown.Anchor = AnchorStyles.None
        leveldropdown.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        leveldropdown.FormattingEnabled = True
        leveldropdown.Items.AddRange(New Object() {"100", "200", "300", "400"})
        leveldropdown.Location = New Point(710, 377)
        leveldropdown.Name = "leveldropdown"
        leveldropdown.Size = New Size(151, 36)
        leveldropdown.TabIndex = 2
        leveldropdown.Text = "Select level"
        ' 
        ' Sessiondropdown
        ' 
        Sessiondropdown.AllowDrop = True
        Sessiondropdown.Anchor = AnchorStyles.None
        Sessiondropdown.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Sessiondropdown.FormattingEnabled = True
        Sessiondropdown.Items.AddRange(New Object() {"Morning", "Evening", "Weekend"})
        Sessiondropdown.Location = New Point(967, 377)
        Sessiondropdown.Name = "Sessiondropdown"
        Sessiondropdown.Size = New Size(235, 36)
        Sessiondropdown.TabIndex = 2
        Sessiondropdown.Text = "Select Session"
        ' 
        ' lblprgm
        ' 
        lblprgm.AllowDrop = True
        lblprgm.Anchor = AnchorStyles.None
        lblprgm.AutoSize = True
        lblprgm.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblprgm.Location = New Point(208, 333)
        lblprgm.Name = "lblprgm"
        lblprgm.Size = New Size(261, 32)
        lblprgm.TabIndex = 0
        lblprgm.Text = "Programme Of Study "
        ' 
        ' lblLevel
        ' 
        lblLevel.AllowDrop = True
        lblLevel.Anchor = AnchorStyles.None
        lblLevel.AutoSize = True
        lblLevel.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblLevel.Location = New Point(709, 333)
        lblLevel.Name = "lblLevel"
        lblLevel.Size = New Size(72, 32)
        lblLevel.TabIndex = 0
        lblLevel.Text = "Level"
        ' 
        ' lblSession
        ' 
        lblSession.AllowDrop = True
        lblSession.Anchor = AnchorStyles.None
        lblSession.AutoSize = True
        lblSession.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        lblSession.Location = New Point(967, 333)
        lblSession.Name = "lblSession"
        lblSession.Size = New Size(99, 32)
        lblSession.TabIndex = 0
        lblSession.Text = "Session"
        ' 
        ' Btn1StuInfo
        ' 
        Btn1StuInfo.AllowDrop = True
        Btn1StuInfo.Anchor = AnchorStyles.None
        Btn1StuInfo.BackColor = Color.PaleGreen
        Btn1StuInfo.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Btn1StuInfo.Location = New Point(229, 465)
        Btn1StuInfo.Name = "Btn1StuInfo"
        Btn1StuInfo.Size = New Size(257, 97)
        Btn1StuInfo.TabIndex = 3
        Btn1StuInfo.Text = "Display Student Infomation"
        Btn1StuInfo.UseVisualStyleBackColor = False
        ' 
        ' BtnClr
        ' 
        BtnClr.AllowDrop = True
        BtnClr.Anchor = AnchorStyles.None
        BtnClr.BackColor = Color.LightCyan
        BtnClr.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        BtnClr.Location = New Point(603, 465)
        BtnClr.Name = "BtnClr"
        BtnClr.Size = New Size(257, 97)
        BtnClr.TabIndex = 3
        BtnClr.Text = "Clear"
        BtnClr.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.AllowDrop = True
        Button3.Anchor = AnchorStyles.None
        Button3.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Button3.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = SystemColors.ButtonFace
        Button3.Location = New Point(945, 465)
        Button3.Name = "Button3"
        Button3.Size = New Size(257, 97)
        Button3.TabIndex = 3
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1369, 760)
        Controls.Add(Button3)
        Controls.Add(BtnClr)
        Controls.Add(Btn1StuInfo)
        Controls.Add(Sessiondropdown)
        Controls.Add(leveldropdown)
        Controls.Add(Programdropdown)
        Controls.Add(TBoxNameofStu)
        Controls.Add(lblSession)
        Controls.Add(lblLevel)
        Controls.Add(lblprgm)
        Controls.Add(lblstudName)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents lblstudName As Label
    Friend WithEvents TBoxNameofStu As TextBox
    Friend WithEvents Programdropdown As ComboBox
    Friend WithEvents leveldropdown As ComboBox
    Friend WithEvents Sessiondropdown As ComboBox
    Friend WithEvents lblprgm As Label
    Friend WithEvents lblLevel As Label
    Friend WithEvents lblSession As Label
    Friend WithEvents Btn1StuInfo As Button
    Friend WithEvents BtnClr As Button
    Friend WithEvents Button3 As Button
End Class
