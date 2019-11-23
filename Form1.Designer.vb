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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.CH_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_Diplomacy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_Engineering = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_Command = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_Medicine = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_Science = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_Security = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_Accuracy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_CritBonus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_CritRating = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CH_Evasion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(81, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(81, 125)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(81, 155)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(196, 478)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CH_Name, Me.CH_Diplomacy, Me.CH_Engineering, Me.CH_Command, Me.CH_Medicine, Me.CH_Science, Me.CH_Security, Me.CH_Accuracy, Me.CH_CritBonus, Me.CH_CritRating, Me.CH_Evasion})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(197, 95)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(906, 360)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'CH_Name
        '
        Me.CH_Name.Text = "Name"
        Me.CH_Name.Width = 200
        '
        'CH_Diplomacy
        '
        Me.CH_Diplomacy.Text = "Diplomacy"
        Me.CH_Diplomacy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CH_Diplomacy.Width = 70
        '
        'CH_Engineering
        '
        Me.CH_Engineering.Text = "Engineering"
        Me.CH_Engineering.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CH_Engineering.Width = 70
        '
        'CH_Command
        '
        Me.CH_Command.Text = "Command"
        Me.CH_Command.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CH_Command.Width = 70
        '
        'CH_Medicine
        '
        Me.CH_Medicine.Text = "Medicine"
        Me.CH_Medicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CH_Medicine.Width = 70
        '
        'CH_Science
        '
        Me.CH_Science.Text = "Science"
        Me.CH_Science.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CH_Science.Width = 70
        '
        'CH_Security
        '
        Me.CH_Security.Text = "Security"
        Me.CH_Security.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CH_Security.Width = 70
        '
        'CH_Accuracy
        '
        Me.CH_Accuracy.Text = "Accuracy"
        Me.CH_Accuracy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CH_Accuracy.Width = 70
        '
        'CH_CritBonus
        '
        Me.CH_CritBonus.Text = "CritBonus"
        Me.CH_CritBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CH_CritBonus.Width = 70
        '
        'CH_CritRating
        '
        Me.CH_CritRating.Text = "CritRating"
        Me.CH_CritRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CH_CritRating.Width = 70
        '
        'CH_Evasion
        '
        Me.CH_Evasion.Text = "Evasion"
        Me.CH_Evasion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CH_Evasion.Width = 70
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 638)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents CH_Name As ColumnHeader
    Friend WithEvents CH_Diplomacy As ColumnHeader
    Friend WithEvents CH_Engineering As ColumnHeader
    Friend WithEvents CH_Command As ColumnHeader
    Friend WithEvents CH_Medicine As ColumnHeader
    Friend WithEvents CH_Science As ColumnHeader
    Friend WithEvents CH_Security As ColumnHeader
    Friend WithEvents CH_Accuracy As ColumnHeader
    Friend WithEvents CH_CritBonus As ColumnHeader
    Friend WithEvents CH_CritRating As ColumnHeader
    Friend WithEvents CH_Evasion As ColumnHeader
End Class
