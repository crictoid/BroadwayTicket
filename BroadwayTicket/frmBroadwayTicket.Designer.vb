<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBroadwayTicket
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
        Me.grpDiscountType = New System.Windows.Forms.GroupBox()
        Me.radGroup3 = New System.Windows.Forms.RadioButton()
        Me.radGroup2 = New System.Windows.Forms.RadioButton()
        Me.radGroup1 = New System.Windows.Forms.RadioButton()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblCostTotal = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.radGroup4 = New System.Windows.Forms.RadioButton()
        Me.grpDiscountType.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDiscountType
        '
        Me.grpDiscountType.BackColor = System.Drawing.Color.SkyBlue
        Me.grpDiscountType.Controls.Add(Me.radGroup4)
        Me.grpDiscountType.Controls.Add(Me.radGroup3)
        Me.grpDiscountType.Controls.Add(Me.radGroup2)
        Me.grpDiscountType.Controls.Add(Me.radGroup1)
        Me.grpDiscountType.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDiscountType.ForeColor = System.Drawing.Color.Chocolate
        Me.grpDiscountType.Location = New System.Drawing.Point(88, 157)
        Me.grpDiscountType.Name = "grpDiscountType"
        Me.grpDiscountType.Size = New System.Drawing.Size(315, 137)
        Me.grpDiscountType.TabIndex = 22
        Me.grpDiscountType.TabStop = False
        Me.grpDiscountType.Text = "Group Discount Rates:"
        '
        'radGroup3
        '
        Me.radGroup3.AutoSize = True
        Me.radGroup3.Location = New System.Drawing.Point(6, 76)
        Me.radGroup3.Name = "radGroup3"
        Me.radGroup3.Size = New System.Drawing.Size(228, 27)
        Me.radGroup3.TabIndex = 2
        Me.radGroup3.Text = "13 - 24 :: $199 per person"
        Me.radGroup3.UseVisualStyleBackColor = True
        '
        'radGroup2
        '
        Me.radGroup2.AutoSize = True
        Me.radGroup2.Location = New System.Drawing.Point(6, 49)
        Me.radGroup2.Name = "radGroup2"
        Me.radGroup2.Size = New System.Drawing.Size(228, 27)
        Me.radGroup2.TabIndex = 1
        Me.radGroup2.Text = "9 - 12   :: $219 per person"
        Me.radGroup2.UseVisualStyleBackColor = True
        '
        'radGroup1
        '
        Me.radGroup1.AutoSize = True
        Me.radGroup1.Checked = True
        Me.radGroup1.Location = New System.Drawing.Point(6, 22)
        Me.radGroup1.Name = "radGroup1"
        Me.radGroup1.Size = New System.Drawing.Size(228, 27)
        Me.radGroup1.TabIndex = 0
        Me.radGroup1.TabStop = True
        Me.radGroup1.Text = "1 - 8     :: $249 per person"
        Me.radGroup1.UseVisualStyleBackColor = True
        '
        'txtSize
        '
        Me.txtSize.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSize.ForeColor = System.Drawing.Color.Chocolate
        Me.txtSize.Location = New System.Drawing.Point(356, 91)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(47, 33)
        Me.txtSize.TabIndex = 21
        Me.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblGroupSize
        '
        Me.lblGroupSize.AutoSize = True
        Me.lblGroupSize.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSize.ForeColor = System.Drawing.Color.Chocolate
        Me.lblGroupSize.Location = New System.Drawing.Point(83, 94)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(167, 25)
        Me.lblGroupSize.TabIndex = 20
        Me.lblGroupSize.Text = "Group Size (1-99):"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Goudy Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Chocolate
        Me.lblHeading.Location = New System.Drawing.Point(15, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(460, 37)
        Me.lblHeading.TabIndex = 19
        Me.lblHeading.Text = "Broadway Ticket Group Discount"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(359, 383)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 41)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Black
        Me.btnCalculate.Location = New System.Drawing.Point(22, 383)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(116, 41)
        Me.btnCalculate.TabIndex = 25
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblCostTotal
        '
        Me.lblCostTotal.AutoSize = True
        Me.lblCostTotal.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostTotal.ForeColor = System.Drawing.Color.Chocolate
        Me.lblCostTotal.Location = New System.Drawing.Point(309, 320)
        Me.lblCostTotal.Name = "lblCostTotal"
        Me.lblCostTotal.Size = New System.Drawing.Size(94, 25)
        Me.lblCostTotal.TabIndex = 24
        Me.lblCostTotal.Text = "$0000.00"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.Chocolate
        Me.lblCost.Location = New System.Drawing.Point(82, 320)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(168, 25)
        Me.lblCost.TabIndex = 23
        Me.lblCost.Text = "Registration Cost:"
        '
        'radGroup4
        '
        Me.radGroup4.AutoSize = True
        Me.radGroup4.Location = New System.Drawing.Point(6, 109)
        Me.radGroup4.Name = "radGroup4"
        Me.radGroup4.Size = New System.Drawing.Size(228, 27)
        Me.radGroup4.TabIndex = 3
        Me.radGroup4.Text = "25 - 99 :: $169 per person"
        Me.radGroup4.UseVisualStyleBackColor = True
        '
        'frmBroadwayTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 450)
        Me.Controls.Add(Me.grpDiscountType)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCostTotal)
        Me.Controls.Add(Me.lblCost)
        Me.Name = "frmBroadwayTicket"
        Me.Text = "Broadway Ticket Group Discount"
        Me.grpDiscountType.ResumeLayout(False)
        Me.grpDiscountType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpDiscountType As GroupBox
    Friend WithEvents radGroup3 As RadioButton
    Friend WithEvents radGroup2 As RadioButton
    Friend WithEvents radGroup1 As RadioButton
    Friend WithEvents txtSize As TextBox
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblCostTotal As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents radGroup4 As RadioButton
End Class
