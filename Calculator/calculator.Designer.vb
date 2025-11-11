<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Btn2 = New Button()
        Btn3 = New Button()
        Btn4 = New Button()
        Btn5 = New Button()
        Btn6 = New Button()
        Btn7 = New Button()
        Btn8 = New Button()
        Btn9 = New Button()
        Button11 = New Button()
        Btnadd = New Button()
        Btnsub = New Button()
        Btnclear = New Button()
        Btnmulti = New Button()
        Label1 = New Label()
        Btnequals = New Button()
        Txtres = New TextBox()
        Btndiv = New Button()
        Label2 = New Label()
        Btn1 = New Button()
        SuspendLayout()
        ' 
        ' Btn1
        ' 
        Btn1.BackColor = Color.Pink
        Btn1.Location = New Point(24, 244)
        Btn1.Name = "Btn1"
        Btn1.Size = New Size(60, 34)
        Btn1.TabIndex = 20
        Btn1.Text = "1"
        Btn1.UseVisualStyleBackColor = False
        ' 
        ' Btn2
        ' 
        Btn2.BackColor = Color.Pink
        Btn2.Location = New Point(97, 244)
        Btn2.Name = "Btn2"
        Btn2.Size = New Size(60, 34)
        Btn2.TabIndex = 1
        Btn2.Text = "2"
        Btn2.UseVisualStyleBackColor = False
        ' 
        ' Btn3
        ' 
        Btn3.BackColor = Color.Pink
        Btn3.Location = New Point(163, 244)
        Btn3.Name = "Btn3"
        Btn3.Size = New Size(60, 34)
        Btn3.TabIndex = 2
        Btn3.Text = "3"
        Btn3.UseVisualStyleBackColor = False
        ' 
        ' Btn4
        ' 
        Btn4.BackColor = Color.Pink
        Btn4.Location = New Point(24, 204)
        Btn4.Name = "Btn4"
        Btn4.Size = New Size(60, 34)
        Btn4.TabIndex = 3
        Btn4.Text = "4"
        Btn4.UseVisualStyleBackColor = False
        ' 
        ' Btn5
        ' 
        Btn5.BackColor = Color.Pink
        Btn5.Location = New Point(97, 204)
        Btn5.Name = "Btn5"
        Btn5.Size = New Size(60, 34)
        Btn5.TabIndex = 4
        Btn5.Text = "5"
        Btn5.UseVisualStyleBackColor = False
        ' 
        ' Btn6
        ' 
        Btn6.BackColor = Color.Pink
        Btn6.Location = New Point(163, 204)
        Btn6.Name = "Btn6"
        Btn6.Size = New Size(60, 34)
        Btn6.TabIndex = 5
        Btn6.Text = "6"
        Btn6.UseVisualStyleBackColor = False
        ' 
        ' Btn7
        ' 
        Btn7.BackColor = Color.Pink
        Btn7.Location = New Point(24, 164)
        Btn7.Name = "Btn7"
        Btn7.Size = New Size(60, 34)
        Btn7.TabIndex = 6
        Btn7.Text = "7"
        Btn7.UseVisualStyleBackColor = False
        ' 
        ' Btn8
        ' 
        Btn8.BackColor = Color.Pink
        Btn8.Location = New Point(97, 164)
        Btn8.Name = "Btn8"
        Btn8.Size = New Size(60, 34)
        Btn8.TabIndex = 7
        Btn8.Text = "8"
        Btn8.UseVisualStyleBackColor = False
        ' 
        ' Btn9
        ' 
        Btn9.BackColor = Color.Pink
        Btn9.Location = New Point(163, 164)
        Btn9.Name = "Btn9"
        Btn9.Size = New Size(60, 34)
        Btn9.TabIndex = 8
        Btn9.Text = "9"
        Btn9.UseVisualStyleBackColor = False
        ' 
        ' Button11
        ' 
        Button11.BackColor = Color.Pink
        Button11.Location = New Point(24, 284)
        Button11.Name = "Button11"
        Button11.Size = New Size(60, 34)
        Button11.TabIndex = 10
        Button11.Text = "0"
        Button11.UseVisualStyleBackColor = False
        ' 
        ' Btnadd
        ' 
        Btnadd.BackColor = Color.PaleVioletRed
        Btnadd.Location = New Point(229, 124)
        Btnadd.Name = "Btnadd"
        Btnadd.Size = New Size(112, 34)
        Btnadd.TabIndex = 11
        Btnadd.Text = "+"
        Btnadd.UseVisualStyleBackColor = False
        ' 
        ' Btnsub
        ' 
        Btnsub.BackColor = Color.PaleVioletRed
        Btnsub.Location = New Point(229, 164)
        Btnsub.Name = "Btnsub"
        Btnsub.Size = New Size(112, 34)
        Btnsub.TabIndex = 12
        Btnsub.Text = "-"
        Btnsub.UseVisualStyleBackColor = False
        ' 
        ' Btnclear
        ' 
        Btnclear.BackColor = Color.PaleVioletRed
        Btnclear.Location = New Point(24, 124)
        Btnclear.Name = "Btnclear"
        Btnclear.Size = New Size(199, 34)
        Btnclear.TabIndex = 13
        Btnclear.Text = "C"
        Btnclear.UseVisualStyleBackColor = False
        ' 
        ' Btnmulti
        ' 
        Btnmulti.BackColor = Color.PaleVioletRed
        Btnmulti.Font = New Font("Segoe UI Symbol", 11.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btnmulti.Location = New Point(229, 204)
        Btnmulti.Name = "Btnmulti"
        Btnmulti.Size = New Size(112, 34)
        Btnmulti.TabIndex = 14
        Btnmulti.Text = "*"
        Btnmulti.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(199, 339)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 25)
        Label1.TabIndex = 15
        Label1.Text = "           "
        ' 
        ' Btnequals
        ' 
        Btnequals.BackColor = Color.PaleVioletRed
        Btnequals.Location = New Point(90, 284)
        Btnequals.Name = "Btnequals"
        Btnequals.Size = New Size(251, 34)
        Btnequals.TabIndex = 16
        Btnequals.Text = "   =   "
        Btnequals.UseVisualStyleBackColor = False
        ' 
        ' Txtres
        ' 
        Txtres.BackColor = Color.LavenderBlush
        Txtres.Location = New Point(24, 87)
        Txtres.Name = "Txtres"
        Txtres.Size = New Size(317, 31)
        Txtres.TabIndex = 17
        ' 
        ' Btndiv
        ' 
        Btndiv.BackColor = Color.PaleVioletRed
        Btndiv.Location = New Point(229, 244)
        Btndiv.Name = "Btndiv"
        Btndiv.Size = New Size(112, 34)
        Btndiv.TabIndex = 18
        Btndiv.Text = "/"
        Btndiv.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.PaleVioletRed
        Label2.Location = New Point(106, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 30)
        Label2.TabIndex = 19
        Label2.Text = "My calculator"
        ' 

        ' calculator
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(367, 320)
        Controls.Add(Btn1)
        Controls.Add(Label2)
        Controls.Add(Btndiv)
        Controls.Add(Txtres)
        Controls.Add(Btnequals)
        Controls.Add(Label1)
        Controls.Add(Btnmulti)
        Controls.Add(Btnclear)
        Controls.Add(Btnsub)
        Controls.Add(Btnadd)
        Controls.Add(Button11)
        Controls.Add(Btn9)
        Controls.Add(Btn8)
        Controls.Add(Btn7)
        Controls.Add(Btn6)
        Controls.Add(Btn5)
        Controls.Add(Btn4)
        Controls.Add(Btn3)
        Controls.Add(Btn2)
        Name = "calculator"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn7 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Btnadd As Button
    Friend WithEvents Btnsub As Button
    Friend WithEvents Btnclear As Button
    Friend WithEvents Btnmulti As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnequals As Button
    Friend WithEvents Txtres As TextBox
    Friend WithEvents Btndiv As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn1 As Button

End Class
