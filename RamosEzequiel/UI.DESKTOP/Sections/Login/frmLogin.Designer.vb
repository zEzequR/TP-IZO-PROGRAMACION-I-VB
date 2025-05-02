<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        loginCont = New TableLayoutPanel()
        passwrdCont = New TableLayoutPanel()
        passwrdInp = New TextBox()
        passwrdTxt = New Label()
        wlcTxt = New Label()
        inputTxt = New Label()
        usernameImg = New PictureBox()
        passwrdImg = New PictureBox()
        sumbitBtn = New Button()
        usernameCont = New TableLayoutPanel()
        userInp = New TextBox()
        usernameTxt = New Label()
        loginCont.SuspendLayout()
        passwrdCont.SuspendLayout()
        CType(usernameImg, ComponentModel.ISupportInitialize).BeginInit()
        CType(passwrdImg, ComponentModel.ISupportInitialize).BeginInit()
        usernameCont.SuspendLayout()
        SuspendLayout()
        ' 
        ' loginCont
        ' 
        loginCont.Anchor = AnchorStyles.None
        loginCont.ColumnCount = 2
        loginCont.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 39.82558F))
        loginCont.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60.17442F))
        loginCont.Controls.Add(passwrdCont, 1, 3)
        loginCont.Controls.Add(wlcTxt, 0, 0)
        loginCont.Controls.Add(inputTxt, 0, 1)
        loginCont.Controls.Add(usernameImg, 0, 2)
        loginCont.Controls.Add(passwrdImg, 0, 3)
        loginCont.Controls.Add(sumbitBtn, 0, 4)
        loginCont.Controls.Add(usernameCont, 1, 2)
        loginCont.Location = New Point(219, 12)
        loginCont.Name = "loginCont"
        loginCont.RowCount = 5
        loginCont.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        loginCont.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        loginCont.RowStyles.Add(New RowStyle(SizeType.Percent, 32.5F))
        loginCont.RowStyles.Add(New RowStyle(SizeType.Percent, 32.5F))
        loginCont.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        loginCont.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        loginCont.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        loginCont.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        loginCont.Size = New Size(344, 426)
        loginCont.TabIndex = 0
        ' 
        ' passwrdCont
        ' 
        passwrdCont.Anchor = AnchorStyles.None
        passwrdCont.ColumnCount = 1
        passwrdCont.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        passwrdCont.Controls.Add(passwrdInp, 0, 1)
        passwrdCont.Controls.Add(passwrdTxt, 0, 0)
        passwrdCont.Location = New Point(142, 249)
        passwrdCont.Name = "passwrdCont"
        passwrdCont.RowCount = 2
        passwrdCont.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        passwrdCont.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        passwrdCont.Size = New Size(196, 126)
        passwrdCont.TabIndex = 6
        ' 
        ' passwrdInp
        ' 
        passwrdInp.AcceptsTab = True
        passwrdInp.Anchor = AnchorStyles.None
        passwrdInp.BorderStyle = BorderStyle.FixedSingle
        passwrdInp.Location = New Point(21, 83)
        passwrdInp.Name = "passwrdInp"
        passwrdInp.PasswordChar = "*"c
        passwrdInp.Size = New Size(154, 23)
        passwrdInp.TabIndex = 1
        ' 
        ' passwrdTxt
        ' 
        passwrdTxt.Anchor = AnchorStyles.None
        passwrdTxt.AutoSize = True
        passwrdTxt.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passwrdTxt.Location = New Point(7, 21)
        passwrdTxt.Name = "passwrdTxt"
        passwrdTxt.Size = New Size(181, 21)
        passwrdTxt.TabIndex = 9
        passwrdTxt.Text = "Ingrese su contraseña"
        passwrdTxt.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' wlcTxt
        ' 
        wlcTxt.Anchor = AnchorStyles.None
        wlcTxt.AutoSize = True
        loginCont.SetColumnSpan(wlcTxt, 2)
        wlcTxt.Font = New Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        wlcTxt.Location = New Point(20, 15)
        wlcTxt.Name = "wlcTxt"
        wlcTxt.Size = New Size(303, 33)
        wlcTxt.TabIndex = 0
        wlcTxt.Text = "Bienvenido devuelta!"
        wlcTxt.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' inputTxt
        ' 
        inputTxt.Anchor = AnchorStyles.None
        inputTxt.AutoSize = True
        loginCont.SetColumnSpan(inputTxt, 2)
        inputTxt.Font = New Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        inputTxt.Location = New Point(8, 72)
        inputTxt.Name = "inputTxt"
        inputTxt.Size = New Size(328, 24)
        inputTxt.TabIndex = 1
        inputTxt.Text = "Ingrese su usuario y contraseña"
        inputTxt.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' usernameImg
        ' 
        usernameImg.Anchor = AnchorStyles.None
        usernameImg.Image = CType(resources.GetObject("usernameImg.Image"), Image)
        usernameImg.Location = New Point(5, 111)
        usernameImg.Name = "usernameImg"
        usernameImg.Size = New Size(127, 126)
        usernameImg.SizeMode = PictureBoxSizeMode.StretchImage
        usernameImg.TabIndex = 2
        usernameImg.TabStop = False
        ' 
        ' passwrdImg
        ' 
        passwrdImg.Anchor = AnchorStyles.None
        passwrdImg.Image = CType(resources.GetObject("passwrdImg.Image"), Image)
        passwrdImg.Location = New Point(5, 249)
        passwrdImg.Name = "passwrdImg"
        passwrdImg.Size = New Size(127, 126)
        passwrdImg.SizeMode = PictureBoxSizeMode.StretchImage
        passwrdImg.TabIndex = 3
        passwrdImg.TabStop = False
        ' 
        ' sumbitBtn
        ' 
        sumbitBtn.Anchor = AnchorStyles.None
        loginCont.SetColumnSpan(sumbitBtn, 2)
        sumbitBtn.Font = New Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        sumbitBtn.Location = New Point(79, 385)
        sumbitBtn.Name = "sumbitBtn"
        sumbitBtn.Size = New Size(186, 37)
        sumbitBtn.TabIndex = 4
        sumbitBtn.Text = "Ingresar"
        sumbitBtn.UseVisualStyleBackColor = True
        ' 
        ' usernameCont
        ' 
        usernameCont.Anchor = AnchorStyles.None
        usernameCont.ColumnCount = 1
        usernameCont.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        usernameCont.Controls.Add(userInp, 0, 1)
        usernameCont.Controls.Add(usernameTxt, 0, 0)
        usernameCont.Location = New Point(142, 111)
        usernameCont.Name = "usernameCont"
        usernameCont.RowCount = 2
        usernameCont.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        usernameCont.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        usernameCont.Size = New Size(196, 126)
        usernameCont.TabIndex = 5
        ' 
        ' userInp
        ' 
        userInp.AcceptsTab = True
        userInp.Anchor = AnchorStyles.None
        userInp.BorderStyle = BorderStyle.FixedSingle
        userInp.Location = New Point(21, 83)
        userInp.Name = "userInp"
        userInp.Size = New Size(154, 23)
        userInp.TabIndex = 0
        ' 
        ' usernameTxt
        ' 
        usernameTxt.Anchor = AnchorStyles.None
        usernameTxt.AutoSize = True
        usernameTxt.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernameTxt.Location = New Point(25, 21)
        usernameTxt.Name = "usernameTxt"
        usernameTxt.Size = New Size(146, 21)
        usernameTxt.TabIndex = 8
        usernameTxt.Text = "Ingrese su usuario"
        usernameTxt.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(loginCont)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        loginCont.ResumeLayout(False)
        loginCont.PerformLayout()
        passwrdCont.ResumeLayout(False)
        passwrdCont.PerformLayout()
        CType(usernameImg, ComponentModel.ISupportInitialize).EndInit()
        CType(passwrdImg, ComponentModel.ISupportInitialize).EndInit()
        usernameCont.ResumeLayout(False)
        usernameCont.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents loginCont As TableLayoutPanel
    Friend WithEvents wlcTxt As Label
    Friend WithEvents inputTxt As Label
    Friend WithEvents usernameImg As PictureBox
    Friend WithEvents passwrdImg As PictureBox
    Friend WithEvents sumbitBtn As Button
    Friend WithEvents passwrdCont As TableLayoutPanel
    Friend WithEvents usernameCont As TableLayoutPanel
    Friend WithEvents passwrdInp As TextBox
    Friend WithEvents passwrdTxt As Label
    Friend WithEvents userInp As TextBox
    Friend WithEvents usernameTxt As Label
End Class
