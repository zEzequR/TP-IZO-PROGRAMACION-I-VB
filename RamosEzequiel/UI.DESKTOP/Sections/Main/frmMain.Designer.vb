<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        MenuStrip1 = New MenuStrip()
        archiveMenStrip = New ToolStripMenuItem()
        loginBtn = New ToolStripMenuItem()
        logoutBtn = New ToolStripMenuItem()
        exitBtn = New ToolStripMenuItem()
        AcercaDeToolStripMenuItem = New ToolStripMenuItem()
        RefrescarToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        statusTxt = New ToolStripStatusLabel()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {archiveMenStrip, AcercaDeToolStripMenuItem, RefrescarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 32)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' archiveMenStrip
        ' 
        archiveMenStrip.DropDownItems.AddRange(New ToolStripItem() {loginBtn, logoutBtn, exitBtn})
        archiveMenStrip.Font = New Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        archiveMenStrip.Image = CType(resources.GetObject("archiveMenStrip.Image"), Image)
        archiveMenStrip.Name = "archiveMenStrip"
        archiveMenStrip.Size = New Size(116, 28)
        archiveMenStrip.Text = "Archivo"
        archiveMenStrip.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' loginBtn
        ' 
        loginBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginBtn.Image = CType(resources.GetObject("loginBtn.Image"), Image)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(180, 26)
        loginBtn.Text = "Iniciar sesión"
        loginBtn.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' logoutBtn
        ' 
        logoutBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        logoutBtn.Image = CType(resources.GetObject("logoutBtn.Image"), Image)
        logoutBtn.Name = "logoutBtn"
        logoutBtn.Size = New Size(180, 26)
        logoutBtn.Text = "Cerrar sesión"
        ' 
        ' exitBtn
        ' 
        exitBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        exitBtn.Image = CType(resources.GetObject("exitBtn.Image"), Image)
        exitBtn.Name = "exitBtn"
        exitBtn.Size = New Size(180, 26)
        exitBtn.Text = "Salir"
        ' 
        ' AcercaDeToolStripMenuItem
        ' 
        AcercaDeToolStripMenuItem.Font = New Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AcercaDeToolStripMenuItem.Image = CType(resources.GetObject("AcercaDeToolStripMenuItem.Image"), Image)
        AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        AcercaDeToolStripMenuItem.Size = New Size(145, 28)
        AcercaDeToolStripMenuItem.Text = "Acerca de"
        AcercaDeToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' RefrescarToolStripMenuItem
        ' 
        RefrescarToolStripMenuItem.Font = New Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RefrescarToolStripMenuItem.Image = CType(resources.GetObject("RefrescarToolStripMenuItem.Image"), Image)
        RefrescarToolStripMenuItem.Name = "RefrescarToolStripMenuItem"
        RefrescarToolStripMenuItem.Size = New Size(129, 28)
        RefrescarToolStripMenuItem.Text = "Refrescar"
        RefrescarToolStripMenuItem.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {statusTxt})
        StatusStrip1.Location = New Point(0, 424)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 26)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' statusTxt
        ' 
        statusTxt.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        statusTxt.Name = "statusTxt"
        statusTxt.Size = New Size(175, 21)
        statusTxt.Text = "ToolStripStatusLabel1"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistema IZO - Programación I"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents archiveMenStrip As ToolStripMenuItem
    Friend WithEvents loginBtn As ToolStripMenuItem
    Friend WithEvents logoutBtn As ToolStripMenuItem
    Friend WithEvents exitBtn As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents statusTxt As ToolStripStatusLabel
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefrescarToolStripMenuItem As ToolStripMenuItem

End Class
