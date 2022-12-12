<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form
    Dim a As Decimal
    Dim b As Decimal
    Dim sign As String
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnmiltiple = New System.Windows.Forms.Button()
        Me.btndiv = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnsub = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btnequal = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btncama = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(264, 73)
        Me.TextBox1.TabIndex = 0
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnclear.Location = New System.Drawing.Point(14, 91)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(119, 32)
        Me.btnclear.TabIndex = 1
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnmiltiple
        '
        Me.btnmiltiple.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmiltiple.Location = New System.Drawing.Point(150, 91)
        Me.btnmiltiple.Name = "btnmiltiple"
        Me.btnmiltiple.Size = New System.Drawing.Size(53, 32)
        Me.btnmiltiple.TabIndex = 2
        Me.btnmiltiple.Text = "X"
        Me.btnmiltiple.UseVisualStyleBackColor = False
        '
        'btndiv
        '
        Me.btndiv.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndiv.Location = New System.Drawing.Point(225, 91)
        Me.btndiv.Name = "btndiv"
        Me.btndiv.Size = New System.Drawing.Size(53, 32)
        Me.btndiv.TabIndex = 3
        Me.btndiv.Text = "/"
        Me.btndiv.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn9.Location = New System.Drawing.Point(150, 139)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(53, 32)
        Me.btn9.TabIndex = 4
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn8.Location = New System.Drawing.Point(80, 139)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(53, 32)
        Me.btn8.TabIndex = 5
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn7.Location = New System.Drawing.Point(14, 139)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(53, 32)
        Me.btn7.TabIndex = 6
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnadd.Location = New System.Drawing.Point(225, 139)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(53, 32)
        Me.btnadd.TabIndex = 7
        Me.btnadd.Text = "+"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnsub
        '
        Me.btnsub.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsub.Location = New System.Drawing.Point(225, 189)
        Me.btnsub.Name = "btnsub"
        Me.btnsub.Size = New System.Drawing.Size(53, 32)
        Me.btnsub.TabIndex = 11
        Me.btnsub.Text = "-"
        Me.btnsub.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn4.Location = New System.Drawing.Point(14, 189)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(53, 32)
        Me.btn4.TabIndex = 10
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn5.Location = New System.Drawing.Point(80, 189)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(53, 32)
        Me.btn5.TabIndex = 9
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn6.Location = New System.Drawing.Point(150, 189)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(53, 32)
        Me.btn6.TabIndex = 8
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btnequal
        '
        Me.btnequal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnequal.Location = New System.Drawing.Point(225, 238)
        Me.btnequal.Name = "btnequal"
        Me.btnequal.Size = New System.Drawing.Size(53, 85)
        Me.btnequal.TabIndex = 15
        Me.btnequal.Text = "="
        Me.btnequal.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn1.Location = New System.Drawing.Point(14, 238)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(53, 32)
        Me.btn1.TabIndex = 14
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn2.Location = New System.Drawing.Point(80, 238)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(53, 32)
        Me.btn2.TabIndex = 13
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn3.Location = New System.Drawing.Point(150, 238)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(53, 32)
        Me.btn3.TabIndex = 12
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn0.Location = New System.Drawing.Point(14, 281)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(119, 42)
        Me.btn0.TabIndex = 16
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btncama
        '
        Me.btncama.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btncama.Location = New System.Drawing.Point(150, 291)
        Me.btncama.Name = "btncama"
        Me.btncama.Size = New System.Drawing.Size(53, 32)
        Me.btncama.TabIndex = 17
        Me.btncama.Text = "."
        Me.btncama.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(292, 330)
        Me.Controls.Add(Me.btncama)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnequal)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btnsub)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btndiv)
        Me.Controls.Add(Me.btnmiltiple)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnclear As Button
    Friend WithEvents btnmiltiple As Button
    Friend WithEvents btndiv As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnsub As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btnequal As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btncama As Button

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        TextBox1.Text = TextBox1.Text & 0

    End Sub

    Private Sub btncama_Click(sender As Object, e As EventArgs) Handles btncama.Click
        TextBox1.Text = TextBox1.Text & "."
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        TextBox1.Text = TextBox1.Text & 1
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        TextBox1.Text = TextBox1.Text & 2
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        TextBox1.Text = TextBox1.Text & 3
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        TextBox1.Text = TextBox1.Text & 4
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        TextBox1.Text = TextBox1.Text & 5
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        TextBox1.Text = TextBox1.Text & 6
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        TextBox1.Text = TextBox1.Text & 7
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        TextBox1.Text = TextBox1.Text & 8
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        TextBox1.Text = TextBox1.Text & 9
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        TextBox1.Text = ""
    End Sub

    Private Sub btnmiltiple_Click(sender As Object, e As EventArgs) Handles btnmiltiple.Click
        a = Convert.ToDecimal(TextBox1.Text)
        sign = "*"
        TextBox1.Text = ""
    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        a = Convert.ToDecimal(TextBox1.Text)
        sign = "/"
        TextBox1.Text = ""
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        a = Convert.ToDecimal(TextBox1.Text)
        sign = "+"
        TextBox1.Text = ""
    End Sub

    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        a = Convert.ToDecimal(TextBox1.Text)
        sign = "-"
        TextBox1.Text = ""
    End Sub

    Private Sub btnequal_Click(sender As Object, e As EventArgs) Handles btnequal.Click
        b = Convert.ToDecimal(TextBox1.Text)
        If sign = "+" Then
            TextBox1.Text = Convert.ToString(a + b)

        End If
        If sign = "-" Then
            TextBox1.Text = Convert.ToString(a - b)

        End If
        If sign = "*" Then
            TextBox1.Text = Convert.ToString(a * b)

        End If
        If sign = "/" Then
            TextBox1.Text = Convert.ToString(a / b)

        End If
    End Sub
End Class
