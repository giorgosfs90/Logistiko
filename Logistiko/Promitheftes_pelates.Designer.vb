﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Promitheftes_pelates
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(74, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 56)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ΕΙΣΑΓΩΓΗ ΣΥΝΑΛΛΑΣΟΜΕΝΟΥ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(74, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(231, 56)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "ΚΑΡΤΕΛΕΣ ΠΕΛΑΤΩΝ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(74, 268)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(231, 56)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "ΚΑΡΤΕΛΕΣ ΠΡΟΜΗΘΕΥΤΩΝ"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(291, 361)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "ΕΠΙΣΤΡΟΦΗ"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 383)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ΜΕΝΟΥ ΠΕΛΑΤΩΝ / ΠΡΟΜΗΘΕΥΤΩΝ"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(74, 116)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(231, 56)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "ΕΠΕΞΕΡΓΑΣΙΑ ΣΥΝΑΛΛΑΣΟΜΕΝΟΥ"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Promitheftes_pelates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 407)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Promitheftes_pelates"
        Me.Text = "ΦΑΣΣΑΣ ΛΟΓΙΣΤΙΚΗ - ΠΡΟΜΗΘΕΥΤΕΣ/ΠΕΛΑΤΕΣ"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
