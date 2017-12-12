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
        Me.lstgo = New System.Windows.Forms.ListBox()
        Me.btnNames = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstgo
        '
        Me.lstgo.FormattingEnabled = True
        Me.lstgo.Location = New System.Drawing.Point(80, 63)
        Me.lstgo.Name = "lstgo"
        Me.lstgo.Size = New System.Drawing.Size(120, 95)
        Me.lstgo.TabIndex = 0
        '
        'btnNames
        '
        Me.btnNames.Location = New System.Drawing.Point(30, 169)
        Me.btnNames.Name = "btnNames"
        Me.btnNames.Size = New System.Drawing.Size(97, 54)
        Me.btnNames.TabIndex = 1
        Me.btnNames.Text = "Enter Names"
        Me.btnNames.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(165, 169)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 54)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 266)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNames)
        Me.Controls.Add(Me.lstgo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstgo As System.Windows.Forms.ListBox
    Friend WithEvents btnNames As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
