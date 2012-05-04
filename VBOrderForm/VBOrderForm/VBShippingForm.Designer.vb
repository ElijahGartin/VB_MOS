<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VBShippingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VBShippingForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnFindPrice = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PriceTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ZoneComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radio10pluslb = New System.Windows.Forms.RadioButton()
        Me.radio10lb = New System.Windows.Forms.RadioButton()
        Me.radio5lb = New System.Windows.Forms.RadioButton()
        Me.radio3lb = New System.Windows.Forms.RadioButton()
        Me.radio1lb = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LinkLabel3)
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnFindPrice)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PriceTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ZoneComboBox)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 240)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculate Shipping Cost"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(305, 181)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 47)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exit the form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(205, 181)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(94, 47)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "&Print"
        Me.ToolTip1.SetToolTip(Me.btnPrint, "Print the items calculated thus far")
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(105, 181)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(94, 47)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Clear the current item - This does not clear the ongoing print list")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnFindPrice
        '
        Me.btnFindPrice.Location = New System.Drawing.Point(5, 182)
        Me.btnFindPrice.Name = "btnFindPrice"
        Me.btnFindPrice.Size = New System.Drawing.Size(94, 47)
        Me.btnFindPrice.TabIndex = 5
        Me.btnFindPrice.Text = "&Find Price"
        Me.ToolTip1.SetToolTip(Me.btnFindPrice, "Calculate the cost of the shipping")
        Me.btnFindPrice.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Price"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(260, 64)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(121, 33)
        Me.PriceTextBox.TabIndex = 4
        Me.PriceTextBox.TabStop = False
        Me.PriceTextBox.Text = ""
        Me.ToolTip1.SetToolTip(Me.PriceTextBox, "Price of shipping this package")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(222, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Zone"
        '
        'ZoneComboBox
        '
        Me.ZoneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ZoneComboBox.FormattingEnabled = True
        Me.ZoneComboBox.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.ZoneComboBox.Location = New System.Drawing.Point(260, 36)
        Me.ZoneComboBox.Name = "ZoneComboBox"
        Me.ZoneComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ZoneComboBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.ZoneComboBox, "Zones - A through D")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radio10pluslb)
        Me.GroupBox2.Controls.Add(Me.radio10lb)
        Me.GroupBox2.Controls.Add(Me.radio5lb)
        Me.GroupBox2.Controls.Add(Me.radio3lb)
        Me.GroupBox2.Controls.Add(Me.radio1lb)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 156)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Weight"
        '
        'radio10pluslb
        '
        Me.radio10pluslb.AutoSize = True
        Me.radio10pluslb.Location = New System.Drawing.Point(7, 116)
        Me.radio10pluslb.Name = "radio10pluslb"
        Me.radio10pluslb.Size = New System.Drawing.Size(112, 17)
        Me.radio10pluslb.TabIndex = 4
        Me.radio10pluslb.Text = "&Greater than 10lbs"
        Me.ToolTip1.SetToolTip(Me.radio10pluslb, "Select this button for items over 10lbs")
        Me.radio10pluslb.UseVisualStyleBackColor = True
        '
        'radio10lb
        '
        Me.radio10lb.AutoSize = True
        Me.radio10lb.Location = New System.Drawing.Point(7, 92)
        Me.radio10lb.Name = "radio10lb"
        Me.radio10lb.Size = New System.Drawing.Size(79, 17)
        Me.radio10lb.TabIndex = 3
        Me.radio10lb.Text = "Up to 1&0lbs"
        Me.ToolTip1.SetToolTip(Me.radio10lb, "Select this button for items 10lbs and under")
        Me.radio10lb.UseVisualStyleBackColor = True
        '
        'radio5lb
        '
        Me.radio5lb.AutoSize = True
        Me.radio5lb.Location = New System.Drawing.Point(7, 68)
        Me.radio5lb.Name = "radio5lb"
        Me.radio5lb.Size = New System.Drawing.Size(73, 17)
        Me.radio5lb.TabIndex = 2
        Me.radio5lb.Text = "Up to &5lbs"
        Me.ToolTip1.SetToolTip(Me.radio5lb, "Select this button for items 5lbs and under")
        Me.radio5lb.UseVisualStyleBackColor = True
        '
        'radio3lb
        '
        Me.radio3lb.AutoSize = True
        Me.radio3lb.Location = New System.Drawing.Point(7, 44)
        Me.radio3lb.Name = "radio3lb"
        Me.radio3lb.Size = New System.Drawing.Size(73, 17)
        Me.radio3lb.TabIndex = 1
        Me.radio3lb.Text = "Up to &3lbs"
        Me.ToolTip1.SetToolTip(Me.radio3lb, "Select this button for items 3lbs and under")
        Me.radio3lb.UseVisualStyleBackColor = True
        '
        'radio1lb
        '
        Me.radio1lb.AutoSize = True
        Me.radio1lb.Checked = True
        Me.radio1lb.Location = New System.Drawing.Point(7, 20)
        Me.radio1lb.Name = "radio1lb"
        Me.radio1lb.Size = New System.Drawing.Size(68, 17)
        Me.radio1lb.TabIndex = 0
        Me.radio1lb.TabStop = True
        Me.radio1lb.Text = "Up to &1lb"
        Me.ToolTip1.SetToolTip(Me.radio1lb, "Select this button for items 1lbs and under")
        Me.radio1lb.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel3.Location = New System.Drawing.Point(257, 154)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(93, 13)
        Me.LinkLabel3.TabIndex = 11
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "US Postal Service"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.Location = New System.Drawing.Point(257, 131)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(29, 13)
        Me.LinkLabel2.TabIndex = 10
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "UPS"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(257, 107)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(42, 13)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "FEDEX"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 259)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(403, 131)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contact Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Email : catalog@vbexpress.com"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Phone : 555-555-5555"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "VB Express Catalog Services"
        '
        'VBShippingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 398)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "VBShippingForm"
        Me.Text = "VB Mail Order Shipping Cost Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnFindPrice As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PriceTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ZoneComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radio10pluslb As System.Windows.Forms.RadioButton
    Friend WithEvents radio10lb As System.Windows.Forms.RadioButton
    Friend WithEvents radio5lb As System.Windows.Forms.RadioButton
    Friend WithEvents radio3lb As System.Windows.Forms.RadioButton
    Friend WithEvents radio1lb As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
