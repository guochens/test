<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox_login = New System.Windows.Forms.TextBox()
        Me.Label_login = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader_序号 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_姓名 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_已在线时长 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_签入时间 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_签退时间 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader_备注 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button_login = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox_login
        '
        Me.TextBox_login.Location = New System.Drawing.Point(12, 91)
        Me.TextBox_login.Name = "TextBox_login"
        Me.TextBox_login.Size = New System.Drawing.Size(139, 21)
        Me.TextBox_login.TabIndex = 0
        '
        'Label_login
        '
        Me.Label_login.AutoSize = True
        Me.Label_login.Font = New System.Drawing.Font("宋体", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_login.Location = New System.Drawing.Point(39, 47)
        Me.Label_login.Name = "Label_login"
        Me.Label_login.Size = New System.Drawing.Size(75, 20)
        Me.Label_login.TabIndex = 1
        Me.Label_login.Text = "Label1"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader_序号, Me.ColumnHeader_姓名, Me.ColumnHeader_已在线时长, Me.ColumnHeader_签入时间, Me.ColumnHeader_签退时间, Me.ColumnHeader_备注})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(189, 35)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(605, 422)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader_序号
        '
        Me.ColumnHeader_序号.Text = "序号"
        Me.ColumnHeader_序号.Width = 100
        '
        'ColumnHeader_姓名
        '
        Me.ColumnHeader_姓名.Text = "姓名"
        Me.ColumnHeader_姓名.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader_姓名.Width = 100
        '
        'ColumnHeader_已在线时长
        '
        Me.ColumnHeader_已在线时长.Text = "已在线时长"
        Me.ColumnHeader_已在线时长.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader_已在线时长.Width = 100
        '
        'ColumnHeader_签入时间
        '
        Me.ColumnHeader_签入时间.Text = "签入时间"
        Me.ColumnHeader_签入时间.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader_签入时间.Width = 100
        '
        'ColumnHeader_签退时间
        '
        Me.ColumnHeader_签退时间.Text = "签退时间"
        Me.ColumnHeader_签退时间.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader_签退时间.Width = 100
        '
        'ColumnHeader_备注
        '
        Me.ColumnHeader_备注.Text = "备注"
        Me.ColumnHeader_备注.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader_备注.Width = 100
        '
        'Button_login
        '
        Me.Button_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_login.Location = New System.Drawing.Point(43, 129)
        Me.Button_login.Name = "Button_login"
        Me.Button_login.Size = New System.Drawing.Size(75, 23)
        Me.Button_login.TabIndex = 3
        Me.Button_login.Text = "Button1"
        Me.Button_login.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(67, 231)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 513)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_login)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label_login)
        Me.Controls.Add(Me.TextBox_login)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_login As System.Windows.Forms.TextBox
    Friend WithEvents Label_login As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader_序号 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader_姓名 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader_已在线时长 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader_签入时间 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader_签退时间 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button_login As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader_备注 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As Button
End Class
