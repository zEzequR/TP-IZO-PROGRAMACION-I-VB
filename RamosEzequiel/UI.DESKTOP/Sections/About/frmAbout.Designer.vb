<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        TableLayoutPanel1 = New TableLayoutPanel()
        TP2Txt = New Label()
        nameTxt = New Label()
        profNameTxt = New Label()
        izoLogo = New PictureBox()
        izoLogo2 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        closeBtn = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        statusTxt = New ToolStripStatusLabel()
        TableLayoutPanel1.SuspendLayout()
        CType(izoLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(izoLogo2, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Controls.Add(TP2Txt, 1, 1)
        TableLayoutPanel1.Controls.Add(nameTxt, 1, 2)
        TableLayoutPanel1.Controls.Add(profNameTxt, 1, 3)
        TableLayoutPanel1.Controls.Add(izoLogo, 0, 1)
        TableLayoutPanel1.Controls.Add(izoLogo2, 2, 1)
        TableLayoutPanel1.Location = New Point(12, 35)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Size = New Size(776, 386)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' TP2Txt
        ' 
        TP2Txt.Anchor = AnchorStyles.None
        TP2Txt.AutoSize = True
        TP2Txt.Font = New Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TP2Txt.Location = New Point(163, 87)
        TP2Txt.Name = "TP2Txt"
        TP2Txt.Size = New Size(449, 56)
        TP2Txt.TabIndex = 0
        TP2Txt.Text = "Trabajo práctico 2"
        ' 
        ' nameTxt
        ' 
        nameTxt.Anchor = AnchorStyles.None
        nameTxt.AutoSize = True
        nameTxt.Font = New Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nameTxt.Location = New Point(218, 176)
        nameTxt.Name = "nameTxt"
        nameTxt.Size = New Size(339, 33)
        nameTxt.TabIndex = 1
        nameTxt.Text = "Nombre: Ezequiel Ramos"
        ' 
        ' profNameTxt
        ' 
        profNameTxt.Anchor = AnchorStyles.Top
        profNameTxt.AutoSize = True
        profNameTxt.Font = New Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        profNameTxt.Location = New Point(255, 231)
        profNameTxt.Name = "profNameTxt"
        profNameTxt.Size = New Size(265, 24)
        profNameTxt.TabIndex = 2
        profNameTxt.Text = "Profesor: Mauricio García"
        ' 
        ' izoLogo
        ' 
        izoLogo.Anchor = AnchorStyles.None
        izoLogo.Image = CType(resources.GetObject("izoLogo.Image"), Image)
        izoLogo.Location = New Point(3, 80)
        izoLogo.Name = "izoLogo"
        TableLayoutPanel1.SetRowSpan(izoLogo, 2)
        izoLogo.Size = New Size(149, 148)
        izoLogo.SizeMode = PictureBoxSizeMode.StretchImage
        izoLogo.TabIndex = 3
        izoLogo.TabStop = False
        ' 
        ' izoLogo2
        ' 
        izoLogo2.Anchor = AnchorStyles.None
        izoLogo2.Image = CType(resources.GetObject("izoLogo2.Image"), Image)
        izoLogo2.Location = New Point(624, 80)
        izoLogo2.Name = "izoLogo2"
        TableLayoutPanel1.SetRowSpan(izoLogo2, 2)
        izoLogo2.Size = New Size(148, 148)
        izoLogo2.SizeMode = PictureBoxSizeMode.StretchImage
        izoLogo2.TabIndex = 4
        izoLogo2.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {closeBtn})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 32)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' closeBtn
        ' 
        closeBtn.Font = New Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        closeBtn.Image = CType(resources.GetObject("closeBtn.Image"), Image)
        closeBtn.Name = "closeBtn"
        closeBtn.Size = New Size(101, 28)
        closeBtn.Text = "Cerrar"
        closeBtn.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {statusTxt})
        StatusStrip1.Location = New Point(0, 424)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 26)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' statusTxt
        ' 
        statusTxt.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        statusTxt.Name = "statusTxt"
        statusTxt.Size = New Size(175, 21)
        statusTxt.Text = "ToolStripStatusLabel1"
        ' 
        ' frmAbout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmAbout"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Acerca De"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(izoLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(izoLogo2, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TP2Txt As Label
    Friend WithEvents nameTxt As Label
    Friend WithEvents profNameTxt As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents closeBtn As ToolStripMenuItem
    Friend WithEvents izoLogo As PictureBox
    Friend WithEvents izoLogo2 As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents statusTxt As ToolStripStatusLabel
End Class
