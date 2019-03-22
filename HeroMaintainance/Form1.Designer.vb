'*********************************************************
'
'    Copyright (c) Microsoft. All rights reserved.
'    This code is licensed under the Microsoft Public License.
'    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
'    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
'    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
'    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
'
'*********************************************************
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        m_IsInitializing = true
        InitializeComponent()
        m_IsInitializing = False
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Update1 As Microsoft.Dynamics.SL.Controls.DSLUpdate
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Update1 = New Microsoft.Dynamics.SL.Controls.DSLUpdate()
        Me.SAFHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DslGrid1 = New Microsoft.Dynamics.SL.Controls.DSLGrid()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DslMaskedText1 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.DslMaskedText2 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.DslCombo1 = New Microsoft.Dynamics.SL.Controls.DSLCombo()
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DslGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Update1
        '
        Me.Update1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Update1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Update1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update1.Image = CType(resources.GetObject("Update1.Image"), System.Drawing.Image)
        Me.Update1.Levels = "Detail;D"
        Me.Update1.Location = New System.Drawing.Point(501, 12)
        Me.Update1.Name = "Update1"
        Me.Update1.Size = New System.Drawing.Size(25, 25)
        Me.Update1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Update1.TabIndex = 0
        Me.Update1.TabStop = False
        Me.Update1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DslGrid1)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 185)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Press F4 for details"
        '
        'DslGrid1
        '
        Me.DslGrid1.Location = New System.Drawing.Point(391, 112)
        Me.DslGrid1.Name = "DslGrid1"
        Me.DslGrid1.OcxState = CType(resources.GetObject("DslGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DslGrid1.Size = New System.Drawing.Size(75, 23)
        Me.DslGrid1.SetSLDBNav(Me.DslGrid1, """select * from xtHero where CpnyID = @parm1 and HeroID like @parm2"", ""bpes.cpnyid" &
        """; 0; 0; 0; 0, ""bxthero.HeroID""; 0; 0; 0; 1, ")
        Me.DslGrid1.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.74004!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.25996!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DslMaskedText1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DslMaskedText2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DslCombo1, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(477, 165)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hero ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 57)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 51)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Type"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DslMaskedText1
        '
        Me.DslMaskedText1.Blankerr = True
        Me.DslMaskedText1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DslMaskedText1.FieldName = """bxtHero.HeroID""; 0; 0; 0"
        Me.DslMaskedText1.Heading = "Hero ID"
        Me.DslMaskedText1.Level = "0,k"
        Me.DslMaskedText1.Location = New System.Drawing.Point(58, 3)
        Me.DslMaskedText1.Mask = "UUUUUUUUU"
        Me.DslMaskedText1.Name = "DslMaskedText1"
        Me.DslMaskedText1.Size = New System.Drawing.Size(416, 51)
        Me.DslMaskedText1.TabIndex = 3
        Me.DslMaskedText1.TextLength = 9
        '
        'DslMaskedText2
        '
        Me.DslMaskedText2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DslMaskedText2.FieldName = """bxtHero.Name""; 0; 0; 0"
        Me.DslMaskedText2.Heading = "Name"
        Me.DslMaskedText2.Location = New System.Drawing.Point(58, 60)
        Me.DslMaskedText2.Mask = "XXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.DslMaskedText2.Name = "DslMaskedText2"
        Me.DslMaskedText2.Size = New System.Drawing.Size(416, 51)
        Me.DslMaskedText2.TabIndex = 4
        Me.DslMaskedText2.TextLength = 27
        '
        'DslCombo1
        '
        Me.DslCombo1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DslCombo1.FieldName = """bxtHero.Type""; 0; 0; 0"
        Me.DslCombo1.FormattingEnabled = True
        Me.DslCombo1.Heading = "Type"
        Me.DslCombo1.List = "W;Wizard,K;Knight,B;Barbarian,T;Thief"
        Me.DslCombo1.Location = New System.Drawing.Point(58, 117)
        Me.DslCombo1.Name = "DslCombo1"
        Me.DslCombo1.Size = New System.Drawing.Size(416, 21)
        Me.DslCombo1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(538, 216)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Update1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Hero Maintainance (TS.HERO.001)"
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DslGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SAFHelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DslGrid1 As Microsoft.Dynamics.SL.Controls.DSLGrid
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DslMaskedText1 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents DslMaskedText2 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents DslCombo1 As Microsoft.Dynamics.SL.Controls.DSLCombo
#End Region
End Class
