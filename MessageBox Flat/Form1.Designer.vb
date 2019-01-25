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
        Me.btn_msgS = New System.Windows.Forms.Button()
        Me.btn_msgErr = New System.Windows.Forms.Button()
        Me.btn_msgExM = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_msgS
        '
        Me.btn_msgS.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btn_msgS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_msgS.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.btn_msgS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_msgS.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_msgS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_msgS.Location = New System.Drawing.Point(14, 25)
        Me.btn_msgS.Name = "btn_msgS"
        Me.btn_msgS.Size = New System.Drawing.Size(303, 53)
        Me.btn_msgS.TabIndex = 0
        Me.btn_msgS.Text = "MessageBox Information"
        Me.btn_msgS.UseVisualStyleBackColor = False
        '
        'btn_msgErr
        '
        Me.btn_msgErr.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btn_msgErr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_msgErr.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.btn_msgErr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_msgErr.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_msgErr.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_msgErr.Location = New System.Drawing.Point(14, 84)
        Me.btn_msgErr.Name = "btn_msgErr"
        Me.btn_msgErr.Size = New System.Drawing.Size(303, 53)
        Me.btn_msgErr.TabIndex = 1
        Me.btn_msgErr.Text = "MessageBox Error"
        Me.btn_msgErr.UseVisualStyleBackColor = False
        '
        'btn_msgExM
        '
        Me.btn_msgExM.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn_msgExM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_msgExM.FlatAppearance.BorderColor = System.Drawing.Color.LightSlateGray
        Me.btn_msgExM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_msgExM.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_msgExM.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_msgExM.Location = New System.Drawing.Point(14, 143)
        Me.btn_msgExM.Name = "btn_msgExM"
        Me.btn_msgExM.Size = New System.Drawing.Size(303, 53)
        Me.btn_msgExM.TabIndex = 2
        Me.btn_msgExM.Text = "MessageBox Warning"
        Me.btn_msgExM.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_msgS)
        Me.GroupBox1.Controls.Add(Me.btn_msgExM)
        Me.GroupBox1.Controls.Add(Me.btn_msgErr)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 221)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(355, 248)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MessageBox Metro Freamwork"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_msgS As System.Windows.Forms.Button
    Friend WithEvents btn_msgErr As System.Windows.Forms.Button
    Friend WithEvents btn_msgExM As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
