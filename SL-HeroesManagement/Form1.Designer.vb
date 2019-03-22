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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DslMaskedText1 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.DslMaskedText2 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.DslCombo1 = New Microsoft.Dynamics.SL.Controls.DSLCombo()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DslMaskedText4 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.DslMaskedText5 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.DslMaskedText3 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.DslMaskedText6 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.DslMaskedText7 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.DslGrid1 = New Microsoft.Dynamics.SL.Controls.DSLGrid()
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DslGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Update1
        '
        Me.Update1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Update1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Update1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update1.Image = CType(resources.GetObject("Update1.Image"), System.Drawing.Image)
        Me.Update1.Levels = "Header;N,Detail;D"
        Me.Update1.Location = New System.Drawing.Point(482, 12)
        Me.Update1.Name = "Update1"
        Me.Update1.Size = New System.Drawing.Size(25, 25)
        Me.Update1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Update1.TabIndex = 0
        Me.Update1.TabStop = False
        Me.Update1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 149)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.29956!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.70044!))
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(454, 129)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hero ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 43)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hero Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 43)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hero Type"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DslMaskedText1
        '
        Me.DslMaskedText1.Blankerr = True
        Me.DslMaskedText1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DslMaskedText1.FieldName = """bxtHero.ID""; 0; 0; 0"
        Me.DslMaskedText1.Level = "0,k"
        Me.DslMaskedText1.Location = New System.Drawing.Point(77, 3)
        Me.DslMaskedText1.Mask = "UUUUUUUUUU"
        Me.DslMaskedText1.Name = "DslMaskedText1"
        Me.DslMaskedText1.Size = New System.Drawing.Size(374, 37)
        Me.DslMaskedText1.TabIndex = 3
        Me.DslMaskedText1.TextLength = 10
        '
        'DslMaskedText2
        '
        Me.DslMaskedText2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DslMaskedText2.Enabled = False
        Me.DslMaskedText2.FieldName = """bxtHero.Name""; 0; 0; 0"
        Me.DslMaskedText2.Location = New System.Drawing.Point(77, 46)
        Me.DslMaskedText2.Mask = "XXXXXXXXXXX"
        Me.DslMaskedText2.Name = "DslMaskedText2"
        Me.DslMaskedText2.Size = New System.Drawing.Size(374, 37)
        Me.DslMaskedText2.TabIndex = 4
        Me.DslMaskedText2.TextLength = 11
        '
        'DslCombo1
        '
        Me.DslCombo1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DslCombo1.Enabled = False
        Me.DslCombo1.FieldName = """bxtHero.Type""; 0; 0; 0"
        Me.DslCombo1.FormattingEnabled = True
        Me.DslCombo1.List = "W;Wizard,K;Knight,B;Barbarian,T;Thief"
        Me.DslCombo1.Location = New System.Drawing.Point(77, 89)
        Me.DslCombo1.Name = "DslCombo1"
        Me.DslCombo1.Size = New System.Drawing.Size(374, 21)
        Me.DslCombo1.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DslGrid1)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(460, 252)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Press F4 for details"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.73913!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.26087!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.DslMaskedText4, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DslMaskedText5, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.DslMaskedText3, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.DslMaskedText6, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.DslMaskedText7, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(454, 232)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 62)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Arsenal ID"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 62)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Description"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 52)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Product Class ID"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 56)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Unit of Measure"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DslMaskedText4
        '
        Me.DslMaskedText4.Blankerr = True
        Me.DslMaskedText4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DslMaskedText4.FieldName = """xtHeroArsenal.ID""; 0; 0; 0"
        Me.DslMaskedText4.Heading = "Arsenal ID"
        Me.DslMaskedText4.Level = "1,k"
        Me.DslMaskedText4.Location = New System.Drawing.Point(113, 3)
        Me.DslMaskedText4.Mask = "UUUUUUUUUUUUUUUUUUUU"
        Me.DslMaskedText4.Name = "DslMaskedText4"
        Me.DslMaskedText4.Size = New System.Drawing.Size(232, 56)
        Me.DslMaskedText4.TabIndex = 4
        Me.DslMaskedText4.TextLength = 20
        '
        'DslMaskedText5
        '
        Me.DslMaskedText5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DslMaskedText5.FieldName = """xtHeroArsenal.Description""; 0; 0; 0"
        Me.DslMaskedText5.Heading = "Description"
        Me.DslMaskedText5.Level = "1"
        Me.DslMaskedText5.Location = New System.Drawing.Point(113, 65)
        Me.DslMaskedText5.Mask = "XXXXXXXXXX"
        Me.DslMaskedText5.Name = "DslMaskedText5"
        Me.DslMaskedText5.Size = New System.Drawing.Size(232, 56)
        Me.DslMaskedText5.TabIndex = 5
        Me.DslMaskedText5.TextLength = 10
        '
        'DslMaskedText3
        '
        Me.DslMaskedText3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DslMaskedText3.FieldName = """xtHeroArsenal.ProdClassID""; 0; 0; 0"
        Me.DslMaskedText3.Heading = "Product Class ID"
        Me.DslMaskedText3.Level = "1"
        Me.DslMaskedText3.Location = New System.Drawing.Point(113, 127)
        Me.DslMaskedText3.Mask = "UUUUUU"
        Me.DslMaskedText3.Name = "DslMaskedText3"
        Me.DslMaskedText3.Size = New System.Drawing.Size(232, 46)
        Me.DslMaskedText3.TabIndex = 6
        Me.DslMaskedText3.TextLength = 6
        '
        'DslMaskedText6
        '
        Me.DslMaskedText6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DslMaskedText6.FieldName = """xtHeroArsenal.UOM""; 0; 0; 0"
        Me.DslMaskedText6.Level = "1"
        Me.DslMaskedText6.Location = New System.Drawing.Point(113, 179)
        Me.DslMaskedText6.Mask = "UUUUUU"
        Me.DslMaskedText6.Name = "DslMaskedText6"
        Me.DslMaskedText6.Size = New System.Drawing.Size(232, 50)
        Me.DslMaskedText6.TabIndex = 7
        Me.DslMaskedText6.TextLength = 6
        '
        'DslMaskedText7
        '
        Me.DslMaskedText7.FieldName = """xtHeroArsenal.HeroID""; 0; 0; 0"
        Me.DslMaskedText7.Heading = "Hero ID"
        Me.DslMaskedText7.InGrid = False
        Me.DslMaskedText7.Level = "1,k"
        Me.DslMaskedText7.Location = New System.Drawing.Point(351, 3)
        Me.DslMaskedText7.Mask = "UUUUUUUUUU"
        Me.DslMaskedText7.Name = "DslMaskedText7"
        Me.DslMaskedText7.Size = New System.Drawing.Size(94, 20)
        Me.DslMaskedText7.TabIndex = 8
        Me.DslMaskedText7.TextLength = 10
        '
        'DslGrid1
        '
        Me.DslGrid1.Location = New System.Drawing.Point(272, 8)
        Me.DslGrid1.Name = "DslGrid1"
        Me.DslGrid1.OcxState = CType(resources.GetObject("DslGrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.DslGrid1.Size = New System.Drawing.Size(75, 23)
        Me.DslGrid1.SetSLDBNav(Me.DslGrid1, """select * from xtHeroArsenal where cpnyid = @parm1 and HeroID = @parm2 and ID lik" &
        "e @parm3"", ""bpes.cpnyID""; 0; 0; 0; 0, ""bxtHero.ID""; 0; 0; 0; 0, ""bxtHeroArsenal." &
        "ID""; 0; 0; 0; 1, ")
        Me.DslGrid1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(519, 432)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Update1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Hero Arsenal Maintenance (TS.HERO.002)"
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.DslGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SAFHelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DslMaskedText1 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents DslMaskedText2 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DslMaskedText4 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents DslMaskedText5 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents DslCombo1 As Microsoft.Dynamics.SL.Controls.DSLCombo
    Friend WithEvents DslMaskedText3 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents DslMaskedText6 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents DslMaskedText7 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents DslGrid1 As Microsoft.Dynamics.SL.Controls.DSLGrid
#End Region
End Class
