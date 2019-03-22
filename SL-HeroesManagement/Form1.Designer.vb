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
        Me.tHeroID_0 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.tHeroName_0 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cHeroType_0 = New Microsoft.Dynamics.SL.Controls.DSLCombo()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DslGrid1 = New Microsoft.Dynamics.SL.Controls.DSLGrid()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tArsenalID_1 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.tArsenalDescr_1 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.tArsenalProdClassID_1 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.tArsenalUOM_1 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.tArsenalHeroID_1 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DslGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
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
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.TableLayoutPanel1.Controls.Add(Me.tHeroID_0, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tHeroName_0, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cHeroType_0, 1, 2)
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
        'tHeroID_0
        '
        Me.tHeroID_0.Blankerr = True
        Me.tHeroID_0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tHeroID_0.FieldName = """bxtHero.ID""; 0; 0; 0"
        Me.tHeroID_0.Level = "0,k"
        Me.tHeroID_0.Location = New System.Drawing.Point(77, 3)
        Me.tHeroID_0.Mask = "UUUUUUUUUU"
        Me.tHeroID_0.Name = "tHeroID_0"
        Me.tHeroID_0.Size = New System.Drawing.Size(374, 37)
        Me.tHeroID_0.TabIndex = 3
        Me.tHeroID_0.TextLength = 10
        '
        'tHeroName_0
        '
        Me.tHeroName_0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tHeroName_0.FieldName = """bxtHero.Name""; 0; 0; 0"
        Me.tHeroName_0.Location = New System.Drawing.Point(77, 46)
        Me.tHeroName_0.Mask = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.tHeroName_0.Name = "tHeroName_0"
        Me.tHeroName_0.Size = New System.Drawing.Size(374, 37)
        Me.tHeroName_0.TabIndex = 4
        Me.tHeroName_0.TextLength = 50
        '
        'cHeroType_0
        '
        Me.cHeroType_0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cHeroType_0.FieldName = """bxtHero.Type""; 0; 0; 0"
        Me.cHeroType_0.FormattingEnabled = True
        Me.cHeroType_0.List = "W;Wizard,K;Knight,B;Barbarian,T;Thief"
        Me.cHeroType_0.Location = New System.Drawing.Point(77, 89)
        Me.cHeroType_0.Name = "cHeroType_0"
        Me.cHeroType_0.Size = New System.Drawing.Size(374, 21)
        Me.cHeroType_0.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DslGrid1)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(460, 252)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Press F4 for details"
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
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.73913!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.26087!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tArsenalID_1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tArsenalDescr_1, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tArsenalProdClassID_1, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.tArsenalUOM_1, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tArsenalHeroID_1, 2, 0)
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
        Me.Label4.Size = New System.Drawing.Size(102, 62)
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
        Me.Label5.Size = New System.Drawing.Size(102, 62)
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
        Me.Label6.Size = New System.Drawing.Size(102, 52)
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
        Me.Label7.Size = New System.Drawing.Size(102, 56)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Unit of Measure"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tArsenalID_1
        '
        Me.tArsenalID_1.Blankerr = True
        Me.tArsenalID_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tArsenalID_1.FieldName = """xtHeroArsenal.ID""; 0; 0; 0"
        Me.tArsenalID_1.Heading = "Arsenal ID"
        Me.tArsenalID_1.Level = "1,k"
        Me.tArsenalID_1.Location = New System.Drawing.Point(111, 3)
        Me.tArsenalID_1.Mask = "UUUUUUUUUUUUUUUUUUUUUUUUUUUUUU"
        Me.tArsenalID_1.Name = "tArsenalID_1"
        Me.tArsenalID_1.Size = New System.Drawing.Size(228, 56)
        Me.tArsenalID_1.TabIndex = 4
        Me.tArsenalID_1.TextLength = 30
        '
        'tArsenalDescr_1
        '
        Me.tArsenalDescr_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tArsenalDescr_1.FieldName = """xtHeroArsenal.Description""; 0; 0; 0"
        Me.tArsenalDescr_1.Heading = "Description"
        Me.tArsenalDescr_1.Level = "1"
        Me.tArsenalDescr_1.Location = New System.Drawing.Point(111, 65)
        Me.tArsenalDescr_1.Mask = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.tArsenalDescr_1.Name = "tArsenalDescr_1"
        Me.tArsenalDescr_1.Size = New System.Drawing.Size(228, 56)
        Me.tArsenalDescr_1.TabIndex = 5
        Me.tArsenalDescr_1.TextLength = 60
        '
        'tArsenalProdClassID_1
        '
        Me.tArsenalProdClassID_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tArsenalProdClassID_1.FieldName = """xtHeroArsenal.ProdClassID""; 0; 0; 0"
        Me.tArsenalProdClassID_1.Heading = "Product Class ID"
        Me.tArsenalProdClassID_1.Level = "1"
        Me.tArsenalProdClassID_1.Location = New System.Drawing.Point(111, 127)
        Me.tArsenalProdClassID_1.Mask = "UUUUUU"
        Me.tArsenalProdClassID_1.Name = "tArsenalProdClassID_1"
        Me.tArsenalProdClassID_1.Size = New System.Drawing.Size(228, 46)
        Me.tArsenalProdClassID_1.TabIndex = 6
        Me.tArsenalProdClassID_1.TextLength = 6
        '
        'tArsenalUOM_1
        '
        Me.tArsenalUOM_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tArsenalUOM_1.FieldName = """xtHeroArsenal.UOM""; 0; 0; 0"
        Me.tArsenalUOM_1.Level = "1"
        Me.tArsenalUOM_1.Location = New System.Drawing.Point(111, 179)
        Me.tArsenalUOM_1.Mask = "UUUUUU"
        Me.tArsenalUOM_1.Name = "tArsenalUOM_1"
        Me.tArsenalUOM_1.Size = New System.Drawing.Size(228, 50)
        Me.tArsenalUOM_1.TabIndex = 7
        Me.tArsenalUOM_1.TextLength = 6
        '
        'tArsenalHeroID_1
        '
        Me.tArsenalHeroID_1.FieldName = """xtHeroArsenal.HeroID""; 0; 0; 0"
        Me.tArsenalHeroID_1.Heading = "Hero ID"
        Me.tArsenalHeroID_1.InGrid = False
        Me.tArsenalHeroID_1.Level = "1,k"
        Me.tArsenalHeroID_1.Location = New System.Drawing.Point(345, 3)
        Me.tArsenalHeroID_1.Mask = "UUUUUUUUUU"
        Me.tArsenalHeroID_1.Name = "tArsenalHeroID_1"
        Me.tArsenalHeroID_1.Size = New System.Drawing.Size(94, 20)
        Me.tArsenalHeroID_1.TabIndex = 8
        Me.tArsenalHeroID_1.TextLength = 10
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
        CType(Me.DslGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SAFHelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tHeroID_0 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents tHeroName_0 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tArsenalID_1 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents tArsenalDescr_1 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cHeroType_0 As Microsoft.Dynamics.SL.Controls.DSLCombo
    Friend WithEvents tArsenalProdClassID_1 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents tArsenalUOM_1 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents tArsenalHeroID_1 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents DslGrid1 As Microsoft.Dynamics.SL.Controls.DSLGrid
#End Region
End Class
