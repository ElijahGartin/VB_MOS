<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.totalamtTextBox = New System.Windows.Forms.RichTextBox()
        Me.shTextBox = New System.Windows.Forms.TextBox()
        Me.taxTextBox = New System.Windows.Forms.TextBox()
        Me.dollaramtTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.totalamtTextBox)
        Me.GroupBox3.Controls.Add(Me.shTextBox)
        Me.GroupBox3.Controls.Add(Me.taxTextBox)
        Me.GroupBox3.Controls.Add(Me.dollaramtTextBox)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 74)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 115)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'totalamtTextBox
        '
        Me.totalamtTextBox.Location = New System.Drawing.Point(158, 87)
        Me.totalamtTextBox.Name = "totalamtTextBox"
        Me.totalamtTextBox.ReadOnly = True
        Me.totalamtTextBox.Size = New System.Drawing.Size(100, 22)
        Me.totalamtTextBox.TabIndex = 7
        Me.totalamtTextBox.TabStop = False
        Me.totalamtTextBox.Text = ""
        '
        'shTextBox
        '
        Me.shTextBox.Location = New System.Drawing.Point(158, 65)
        Me.shTextBox.Name = "shTextBox"
        Me.shTextBox.ReadOnly = True
        Me.shTextBox.Size = New System.Drawing.Size(100, 20)
        Me.shTextBox.TabIndex = 5
        Me.shTextBox.TabStop = False
        '
        'taxTextBox
        '
        Me.taxTextBox.Location = New System.Drawing.Point(158, 45)
        Me.taxTextBox.Name = "taxTextBox"
        Me.taxTextBox.ReadOnly = True
        Me.taxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.taxTextBox.TabIndex = 3
        Me.taxTextBox.TabStop = False
        '
        'dollaramtTextBox
        '
        Me.dollaramtTextBox.Location = New System.Drawing.Point(158, 24)
        Me.dollaramtTextBox.Name = "dollaramtTextBox"
        Me.dollaramtTextBox.ReadOnly = True
        Me.dollaramtTextBox.Size = New System.Drawing.Size(100, 20)
        Me.dollaramtTextBox.TabIndex = 1
        Me.dollaramtTextBox.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Total Dollar Amount Due"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Shipping and Handling"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Sales Tax"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Dollar Amount Due"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Summary Order"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "SummaryForm"
        Me.Text = "Summary Form"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents totalamtTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents shTextBox As System.Windows.Forms.TextBox
    Friend WithEvents taxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents dollaramtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
