<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPound = New System.Windows.Forms.Label()
        Me.txtRegular = New System.Windows.Forms.TextBox()
        Me.txtDecaf = New System.Windows.Forms.TextBox()
        Me.lblCoffee = New System.Windows.Forms.Label()
        Me.lblDecaf = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.LabelCity = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.LabelZip = New System.Windows.Forms.Label()
        Me.txtZIP = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBegin
        '
        Me.btnBegin.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnBegin.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBegin.ForeColor = System.Drawing.Color.Firebrick
        Me.btnBegin.Location = New System.Drawing.Point(41, 545)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(138, 32)
        Me.btnBegin.TabIndex = 1
        Me.btnBegin.Text = "Calculate"
        Me.btnBegin.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Firebrick
        Me.btnClear.Location = New System.Drawing.Point(301, 288)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 40)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnExit.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Firebrick
        Me.btnExit.Location = New System.Drawing.Point(483, 288)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 40)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblPound
        '
        Me.lblPound.AutoSize = True
        Me.lblPound.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblPound.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPound.ForeColor = System.Drawing.Color.Firebrick
        Me.lblPound.Location = New System.Drawing.Point(57, 32)
        Me.lblPound.Name = "lblPound"
        Me.lblPound.Size = New System.Drawing.Size(213, 18)
        Me.lblPound.TabIndex = 4
        Me.lblPound.Text = "Total Pounds of Coffee Ordered"
        '
        'txtRegular
        '
        Me.txtRegular.Location = New System.Drawing.Point(138, 96)
        Me.txtRegular.Name = "txtRegular"
        Me.txtRegular.Size = New System.Drawing.Size(100, 20)
        Me.txtRegular.TabIndex = 5
        '
        'txtDecaf
        '
        Me.txtDecaf.Location = New System.Drawing.Point(138, 143)
        Me.txtDecaf.Name = "txtDecaf"
        Me.txtDecaf.Size = New System.Drawing.Size(100, 20)
        Me.txtDecaf.TabIndex = 6
        '
        'lblCoffee
        '
        Me.lblCoffee.AutoSize = True
        Me.lblCoffee.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoffee.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCoffee.Location = New System.Drawing.Point(37, 93)
        Me.lblCoffee.Name = "lblCoffee"
        Me.lblCoffee.Size = New System.Drawing.Size(76, 21)
        Me.lblCoffee.TabIndex = 7
        Me.lblCoffee.Text = "Regular "
        '
        'lblDecaf
        '
        Me.lblDecaf.AutoSize = True
        Me.lblDecaf.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDecaf.ForeColor = System.Drawing.Color.Firebrick
        Me.lblDecaf.Location = New System.Drawing.Point(37, 143)
        Me.lblDecaf.Name = "lblDecaf"
        Me.lblDecaf.Size = New System.Drawing.Size(58, 24)
        Me.lblDecaf.TabIndex = 8
        Me.lblDecaf.Text = "Decaf"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.Firebrick
        Me.lblInfo.Location = New System.Drawing.Point(12, 198)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(263, 21)
        Me.lblInfo.TabIndex = 9
        Me.lblInfo.Text = "Please Enter Information Below"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.Firebrick
        Me.lblname.Location = New System.Drawing.Point(38, 244)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(49, 18)
        Me.lblname.TabIndex = 10
        Me.lblname.Text = "Name "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(114, 245)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 11
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAddress.ForeColor = System.Drawing.Color.Firebrick
        Me.LabelAddress.Location = New System.Drawing.Point(28, 288)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(59, 18)
        Me.LabelAddress.TabIndex = 12
        Me.LabelAddress.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(114, 299)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 13
        '
        'LabelCity
        '
        Me.LabelCity.AutoSize = True
        Me.LabelCity.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCity.ForeColor = System.Drawing.Color.Firebrick
        Me.LabelCity.Location = New System.Drawing.Point(38, 345)
        Me.LabelCity.Name = "LabelCity"
        Me.LabelCity.Size = New System.Drawing.Size(34, 18)
        Me.LabelCity.TabIndex = 14
        Me.LabelCity.Text = "City"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(114, 345)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 15
        '
        'LabelZip
        '
        Me.LabelZip.AutoSize = True
        Me.LabelZip.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelZip.ForeColor = System.Drawing.Color.Firebrick
        Me.LabelZip.Location = New System.Drawing.Point(38, 441)
        Me.LabelZip.Name = "LabelZip"
        Me.LabelZip.Size = New System.Drawing.Size(30, 18)
        Me.LabelZip.TabIndex = 16
        Me.LabelZip.Text = "Zip"
        '
        'txtZIP
        '
        Me.txtZIP.Location = New System.Drawing.Point(114, 452)
        Me.txtZIP.Name = "txtZIP"
        Me.txtZIP.Size = New System.Drawing.Size(100, 20)
        Me.txtZIP.TabIndex = 17
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.Firebrick
        Me.lblState.Location = New System.Drawing.Point(33, 391)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(39, 18)
        Me.lblState.TabIndex = 18
        Me.lblState.Text = "State"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(114, 392)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(100, 20)
        Me.txtState.TabIndex = 19
        '
        'lstOut
        '
        Me.lstOut.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOut.ForeColor = System.Drawing.Color.Firebrick
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 18
        Me.lstOut.Location = New System.Drawing.Point(360, 404)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(211, 184)
        Me.lstOut.TabIndex = 20
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Firebrick
        Me.txtTotal.Location = New System.Drawing.Point(272, 113)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 25)
        Me.txtTotal.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(405, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(236, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(691, 642)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.txtZIP)
        Me.Controls.Add(Me.LabelZip)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.LabelCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.LabelAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblDecaf)
        Me.Controls.Add(Me.lblCoffee)
        Me.Controls.Add(Me.txtDecaf)
        Me.Controls.Add(Me.txtRegular)
        Me.Controls.Add(Me.lblPound)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBegin)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBegin As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblPound As Label
    Friend WithEvents txtRegular As TextBox
    Friend WithEvents txtDecaf As TextBox
    Friend WithEvents lblCoffee As Label
    Friend WithEvents lblDecaf As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblname As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents LabelAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents LabelCity As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents LabelZip As Label
    Friend WithEvents txtZIP As TextBox
    Friend WithEvents lblState As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents lstOut As ListBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
