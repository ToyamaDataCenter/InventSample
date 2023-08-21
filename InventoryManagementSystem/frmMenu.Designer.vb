<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Control
        Button1.Dock = DockStyle.Top
        Button1.Font = New Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(384, 100)
        Button1.TabIndex = 0
        Button1.Text = "在庫入力"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Control
        Button2.Dock = DockStyle.Top
        Button2.Font = New Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(0, 100)
        Button2.Name = "Button2"
        Button2.Size = New Size(384, 100)
        Button2.TabIndex = 1
        Button2.Text = "在庫確認"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Control
        Button3.Dock = DockStyle.Bottom
        Button3.Font = New Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(0, 217)
        Button3.Name = "Button3"
        Button3.Size = New Size(384, 100)
        Button3.TabIndex = 2
        Button3.Text = "終了"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' frmMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(384, 317)
        ControlBox = False
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "frmMenu"
        Text = "在庫管理システムーメニュー"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
