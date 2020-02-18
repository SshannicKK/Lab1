<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblUnitsPrompt = New System.Windows.Forms.Label()
        Me.txtNumberOfUnitsShipped = New System.Windows.Forms.TextBox()
        Me.lblDayNumber = New System.Windows.Forms.Label()
        Me.lblAverageOutput = New System.Windows.Forms.Label()
        Me.txtPastDayShipments = New System.Windows.Forms.TextBox()
        Me.ttpAverageUnitsShipped = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(118, 318)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(120, 46)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Enter"
        Me.ttpAverageUnitsShipped.SetToolTip(Me.btnEnter, "Click to enter in value")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(330, 318)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(109, 46)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.ttpAverageUnitsShipped.SetToolTip(Me.btnReset, "Click to reset form back to blank")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(520, 318)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 46)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.ttpAverageUnitsShipped.SetToolTip(Me.btnExit, "Click here to exit the form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblUnitsPrompt
        '
        Me.lblUnitsPrompt.AutoSize = True
        Me.lblUnitsPrompt.Location = New System.Drawing.Point(234, 51)
        Me.lblUnitsPrompt.Name = "lblUnitsPrompt"
        Me.lblUnitsPrompt.Size = New System.Drawing.Size(44, 17)
        Me.lblUnitsPrompt.TabIndex = 0
        Me.lblUnitsPrompt.Text = "Units:"
        '
        'txtNumberOfUnitsShipped
        '
        Me.txtNumberOfUnitsShipped.Location = New System.Drawing.Point(320, 51)
        Me.txtNumberOfUnitsShipped.Name = "txtNumberOfUnitsShipped"
        Me.txtNumberOfUnitsShipped.Size = New System.Drawing.Size(100, 22)
        Me.txtNumberOfUnitsShipped.TabIndex = 1
        Me.ttpAverageUnitsShipped.SetToolTip(Me.txtNumberOfUnitsShipped, "Enter The Number Of Units Shipped")
        '
        'lblDayNumber
        '
        Me.lblDayNumber.AutoSize = True
        Me.lblDayNumber.Location = New System.Drawing.Point(460, 51)
        Me.lblDayNumber.Name = "lblDayNumber"
        Me.lblDayNumber.Size = New System.Drawing.Size(45, 17)
        Me.lblDayNumber.TabIndex = 2
        Me.lblDayNumber.Text = "Day 1"
        '
        'lblAverageOutput
        '
        Me.lblAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageOutput.Location = New System.Drawing.Point(239, 259)
        Me.lblAverageOutput.Name = "lblAverageOutput"
        Me.lblAverageOutput.Size = New System.Drawing.Size(265, 39)
        Me.lblAverageOutput.TabIndex = 4
        Me.lblAverageOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ttpAverageUnitsShipped.SetToolTip(Me.lblAverageOutput, "Displays Average of 7 days entered")
        '
        'txtPastDayShipments
        '
        Me.txtPastDayShipments.Enabled = False
        Me.txtPastDayShipments.Location = New System.Drawing.Point(235, 88)
        Me.txtPastDayShipments.Multiline = True
        Me.txtPastDayShipments.Name = "txtPastDayShipments"
        Me.txtPastDayShipments.Size = New System.Drawing.Size(268, 168)
        Me.txtPastDayShipments.TabIndex = 3
        Me.ttpAverageUnitsShipped.SetToolTip(Me.txtPastDayShipments, "Past days")
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtPastDayShipments)
        Me.Controls.Add(Me.lblAverageOutput)
        Me.Controls.Add(Me.lblDayNumber)
        Me.Controls.Add(Me.txtNumberOfUnitsShipped)
        Me.Controls.Add(Me.lblUnitsPrompt)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblUnitsPrompt As Label
    Friend WithEvents txtNumberOfUnitsShipped As TextBox
    Friend WithEvents lblDayNumber As Label
    Friend WithEvents lblAverageOutput As Label
    Friend WithEvents txtPastDayShipments As TextBox
    Friend WithEvents ttpAverageUnitsShipped As ToolTip
End Class
