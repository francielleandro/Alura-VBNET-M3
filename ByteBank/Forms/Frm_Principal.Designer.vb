<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.Btn_Click = New System.Windows.Forms.Button()
        Me.Btn_InstanciarFuncionario = New System.Windows.Forms.Button()
        Me.Btn_getTotalFuncionario = New System.Windows.Forms.Button()
        Me.Btn_exibirSalarios = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal.TabIndex = 0
        Me.Lbl_Principal.Text = "Label1"
        '
        'Btn_Click
        '
        Me.Btn_Click.Location = New System.Drawing.Point(15, 41)
        Me.Btn_Click.Name = "Btn_Click"
        Me.Btn_Click.Size = New System.Drawing.Size(111, 41)
        Me.Btn_Click.TabIndex = 1
        Me.Btn_Click.Text = "Button1"
        Me.Btn_Click.UseVisualStyleBackColor = True
        '
        'Btn_InstanciarFuncionario
        '
        Me.Btn_InstanciarFuncionario.Location = New System.Drawing.Point(183, 41)
        Me.Btn_InstanciarFuncionario.Name = "Btn_InstanciarFuncionario"
        Me.Btn_InstanciarFuncionario.Size = New System.Drawing.Size(108, 41)
        Me.Btn_InstanciarFuncionario.TabIndex = 2
        Me.Btn_InstanciarFuncionario.Text = "Button1"
        Me.Btn_InstanciarFuncionario.UseVisualStyleBackColor = True
        '
        'Btn_getTotalFuncionario
        '
        Me.Btn_getTotalFuncionario.Location = New System.Drawing.Point(343, 41)
        Me.Btn_getTotalFuncionario.Name = "Btn_getTotalFuncionario"
        Me.Btn_getTotalFuncionario.Size = New System.Drawing.Size(108, 41)
        Me.Btn_getTotalFuncionario.TabIndex = 3
        Me.Btn_getTotalFuncionario.Text = "Button1"
        Me.Btn_getTotalFuncionario.UseVisualStyleBackColor = True
        '
        'Btn_exibirSalarios
        '
        Me.Btn_exibirSalarios.Location = New System.Drawing.Point(477, 41)
        Me.Btn_exibirSalarios.Name = "Btn_exibirSalarios"
        Me.Btn_exibirSalarios.Size = New System.Drawing.Size(108, 41)
        Me.Btn_exibirSalarios.TabIndex = 4
        Me.Btn_exibirSalarios.Text = "Button1"
        Me.Btn_exibirSalarios.UseVisualStyleBackColor = True
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_exibirSalarios)
        Me.Controls.Add(Me.Btn_getTotalFuncionario)
        Me.Controls.Add(Me.Btn_InstanciarFuncionario)
        Me.Controls.Add(Me.Btn_Click)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btn_Click As Button
    Friend WithEvents Btn_InstanciarFuncionario As Button
    Friend WithEvents Btn_getTotalFuncionario As Button
    Friend WithEvents Btn_exibirSalarios As Button
End Class
