<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculadora
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
        Me.components = New System.ComponentModel.Container()
        Me.txtInsertArea = New System.Windows.Forms.TextBox()
        Me.cmdFMC = New System.Windows.Forms.Button()
        Me.cmdFMR = New System.Windows.Forms.Button()
        Me.cmdFMS = New System.Windows.Forms.Button()
        Me.cmdFMplus = New System.Windows.Forms.Button()
        Me.cmdFMless = New System.Windows.Forms.Button()
        Me.cmdFBack = New System.Windows.Forms.Button()
        Me.cmdFC = New System.Windows.Forms.Button()
        Me.cmdFCE = New System.Windows.Forms.Button()
        Me.cmdFClose = New System.Windows.Forms.Button()
        Me.cmdCFsqrt = New System.Windows.Forms.Button()
        Me.cmdCFplus = New System.Windows.Forms.Button()
        Me.cmdN9 = New System.Windows.Forms.Button()
        Me.cmdN8 = New System.Windows.Forms.Button()
        Me.cmdN7 = New System.Windows.Forms.Button()
        Me.cmdCFperc = New System.Windows.Forms.Button()
        Me.cmdCFless = New System.Windows.Forms.Button()
        Me.cmdN6 = New System.Windows.Forms.Button()
        Me.cmdN5 = New System.Windows.Forms.Button()
        Me.cmdN4 = New System.Windows.Forms.Button()
        Me.cmdCFmult = New System.Windows.Forms.Button()
        Me.cmdN3 = New System.Windows.Forms.Button()
        Me.cmdN2 = New System.Windows.Forms.Button()
        Me.cmdN1 = New System.Windows.Forms.Button()
        Me.cmdCFresu = New System.Windows.Forms.Button()
        Me.cmdCFdivi = New System.Windows.Forms.Button()
        Me.cmdNdot = New System.Windows.Forms.Button()
        Me.cmdN0 = New System.Windows.Forms.Button()
        Me.cmdCFTogglePosNeg = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtResultArea = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtInsertArea
        '
        Me.txtInsertArea.BackColor = System.Drawing.Color.LightGray
        Me.txtInsertArea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInsertArea.Font = New System.Drawing.Font("Georgia", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInsertArea.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtInsertArea.Location = New System.Drawing.Point(3, 3)
        Me.txtInsertArea.Multiline = True
        Me.txtInsertArea.Name = "txtInsertArea"
        Me.txtInsertArea.ReadOnly = True
        Me.txtInsertArea.Size = New System.Drawing.Size(259, 30)
        Me.txtInsertArea.TabIndex = 0
        '
        'cmdFMC
        '
        Me.cmdFMC.BackColor = System.Drawing.Color.Silver
        Me.cmdFMC.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdFMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFMC.Location = New System.Drawing.Point(56, 69)
        Me.cmdFMC.Name = "cmdFMC"
        Me.cmdFMC.Size = New System.Drawing.Size(47, 39)
        Me.cmdFMC.TabIndex = 1
        Me.cmdFMC.Tag = "Memory Clear"
        Me.cmdFMC.Text = "MC"
        Me.cmdFMC.UseVisualStyleBackColor = False
        '
        'cmdFMR
        '
        Me.cmdFMR.BackColor = System.Drawing.Color.Silver
        Me.cmdFMR.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdFMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFMR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFMR.Location = New System.Drawing.Point(109, 69)
        Me.cmdFMR.Name = "cmdFMR"
        Me.cmdFMR.Size = New System.Drawing.Size(47, 39)
        Me.cmdFMR.TabIndex = 2
        Me.cmdFMR.Text = "MR"
        Me.cmdFMR.UseVisualStyleBackColor = False
        '
        'cmdFMS
        '
        Me.cmdFMS.BackColor = System.Drawing.Color.Silver
        Me.cmdFMS.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdFMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFMS.Location = New System.Drawing.Point(3, 69)
        Me.cmdFMS.Name = "cmdFMS"
        Me.cmdFMS.Size = New System.Drawing.Size(47, 39)
        Me.cmdFMS.TabIndex = 3
        Me.cmdFMS.Text = "MS"
        Me.cmdFMS.UseVisualStyleBackColor = False
        '
        'cmdFMplus
        '
        Me.cmdFMplus.BackColor = System.Drawing.Color.Silver
        Me.cmdFMplus.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdFMplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFMplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFMplus.Location = New System.Drawing.Point(162, 69)
        Me.cmdFMplus.Name = "cmdFMplus"
        Me.cmdFMplus.Size = New System.Drawing.Size(47, 39)
        Me.cmdFMplus.TabIndex = 4
        Me.cmdFMplus.Text = "M+"
        Me.cmdFMplus.UseVisualStyleBackColor = False
        '
        'cmdFMless
        '
        Me.cmdFMless.BackColor = System.Drawing.Color.Silver
        Me.cmdFMless.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdFMless.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFMless.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFMless.Location = New System.Drawing.Point(215, 69)
        Me.cmdFMless.Name = "cmdFMless"
        Me.cmdFMless.Size = New System.Drawing.Size(47, 39)
        Me.cmdFMless.TabIndex = 5
        Me.cmdFMless.Text = "M-"
        Me.cmdFMless.UseVisualStyleBackColor = False
        '
        'cmdFBack
        '
        Me.cmdFBack.BackColor = System.Drawing.Color.Silver
        Me.cmdFBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFBack.Font = New System.Drawing.Font("Wingdings", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdFBack.Location = New System.Drawing.Point(162, 114)
        Me.cmdFBack.Name = "cmdFBack"
        Me.cmdFBack.Size = New System.Drawing.Size(100, 39)
        Me.cmdFBack.TabIndex = 10
        Me.cmdFBack.Text = "ß"
        Me.cmdFBack.UseVisualStyleBackColor = False
        '
        'cmdFC
        '
        Me.cmdFC.BackColor = System.Drawing.Color.Silver
        Me.cmdFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFC.Location = New System.Drawing.Point(109, 114)
        Me.cmdFC.Name = "cmdFC"
        Me.cmdFC.Size = New System.Drawing.Size(47, 39)
        Me.cmdFC.TabIndex = 8
        Me.cmdFC.Text = "C"
        Me.cmdFC.UseVisualStyleBackColor = False
        '
        'cmdFCE
        '
        Me.cmdFCE.BackColor = System.Drawing.Color.Silver
        Me.cmdFCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFCE.Location = New System.Drawing.Point(56, 114)
        Me.cmdFCE.Name = "cmdFCE"
        Me.cmdFCE.Size = New System.Drawing.Size(47, 39)
        Me.cmdFCE.TabIndex = 7
        Me.cmdFCE.Text = "CE"
        Me.cmdFCE.UseVisualStyleBackColor = False
        '
        'cmdFClose
        '
        Me.cmdFClose.BackColor = System.Drawing.Color.Pink
        Me.cmdFClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFClose.Font = New System.Drawing.Font("Wingdings", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdFClose.Location = New System.Drawing.Point(3, 114)
        Me.cmdFClose.Name = "cmdFClose"
        Me.cmdFClose.Size = New System.Drawing.Size(47, 39)
        Me.cmdFClose.TabIndex = 6
        Me.cmdFClose.Text = "x"
        Me.cmdFClose.UseVisualStyleBackColor = False
        '
        'cmdCFsqrt
        '
        Me.cmdCFsqrt.BackColor = System.Drawing.Color.DimGray
        Me.cmdCFsqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCFsqrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCFsqrt.Location = New System.Drawing.Point(215, 159)
        Me.cmdCFsqrt.Name = "cmdCFsqrt"
        Me.cmdCFsqrt.Size = New System.Drawing.Size(47, 39)
        Me.cmdCFsqrt.TabIndex = 15
        Me.cmdCFsqrt.Text = "√"
        Me.ToolTip1.SetToolTip(Me.cmdCFsqrt, "Corresponde a la tecla ""v""")
        Me.cmdCFsqrt.UseVisualStyleBackColor = False
        '
        'cmdCFplus
        '
        Me.cmdCFplus.BackColor = System.Drawing.Color.DimGray
        Me.cmdCFplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCFplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCFplus.Location = New System.Drawing.Point(162, 159)
        Me.cmdCFplus.Name = "cmdCFplus"
        Me.cmdCFplus.Size = New System.Drawing.Size(47, 39)
        Me.cmdCFplus.TabIndex = 14
        Me.cmdCFplus.Text = "+"
        Me.cmdCFplus.UseVisualStyleBackColor = False
        '
        'cmdN9
        '
        Me.cmdN9.BackColor = System.Drawing.Color.DimGray
        Me.cmdN9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdN9.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdN9.Location = New System.Drawing.Point(109, 159)
        Me.cmdN9.Name = "cmdN9"
        Me.cmdN9.Size = New System.Drawing.Size(47, 39)
        Me.cmdN9.TabIndex = 13
        Me.cmdN9.Text = "9"
        Me.cmdN9.UseVisualStyleBackColor = False
        '
        'cmdN8
        '
        Me.cmdN8.BackColor = System.Drawing.Color.DimGray
        Me.cmdN8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdN8.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdN8.Location = New System.Drawing.Point(56, 159)
        Me.cmdN8.Name = "cmdN8"
        Me.cmdN8.Size = New System.Drawing.Size(47, 39)
        Me.cmdN8.TabIndex = 12
        Me.cmdN8.Text = "8"
        Me.cmdN8.UseVisualStyleBackColor = False
        '
        'cmdN7
        '
        Me.cmdN7.BackColor = System.Drawing.Color.DimGray
        Me.cmdN7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdN7.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdN7.Location = New System.Drawing.Point(3, 159)
        Me.cmdN7.Name = "cmdN7"
        Me.cmdN7.Size = New System.Drawing.Size(47, 39)
        Me.cmdN7.TabIndex = 11
        Me.cmdN7.Text = "7"
        Me.cmdN7.UseVisualStyleBackColor = False
        '
        'cmdCFperc
        '
        Me.cmdCFperc.BackColor = System.Drawing.Color.DimGray
        Me.cmdCFperc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCFperc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCFperc.Location = New System.Drawing.Point(215, 204)
        Me.cmdCFperc.Name = "cmdCFperc"
        Me.cmdCFperc.Size = New System.Drawing.Size(47, 39)
        Me.cmdCFperc.TabIndex = 20
        Me.cmdCFperc.Text = "%"
        Me.cmdCFperc.UseVisualStyleBackColor = False
        '
        'cmdCFless
        '
        Me.cmdCFless.BackColor = System.Drawing.Color.DimGray
        Me.cmdCFless.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCFless.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCFless.Location = New System.Drawing.Point(162, 204)
        Me.cmdCFless.Name = "cmdCFless"
        Me.cmdCFless.Size = New System.Drawing.Size(47, 39)
        Me.cmdCFless.TabIndex = 19
        Me.cmdCFless.Text = "-"
        Me.cmdCFless.UseVisualStyleBackColor = False
        '
        'cmdN6
        '
        Me.cmdN6.BackColor = System.Drawing.Color.DimGray
        Me.cmdN6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdN6.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdN6.Location = New System.Drawing.Point(109, 204)
        Me.cmdN6.Name = "cmdN6"
        Me.cmdN6.Size = New System.Drawing.Size(47, 39)
        Me.cmdN6.TabIndex = 18
        Me.cmdN6.Text = "6"
        Me.cmdN6.UseVisualStyleBackColor = False
        '
        'cmdN5
        '
        Me.cmdN5.BackColor = System.Drawing.Color.DimGray
        Me.cmdN5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdN5.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdN5.Location = New System.Drawing.Point(56, 204)
        Me.cmdN5.Name = "cmdN5"
        Me.cmdN5.Size = New System.Drawing.Size(47, 39)
        Me.cmdN5.TabIndex = 17
        Me.cmdN5.Text = "5"
        Me.cmdN5.UseVisualStyleBackColor = False
        '
        'cmdN4
        '
        Me.cmdN4.BackColor = System.Drawing.Color.DimGray
        Me.cmdN4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdN4.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdN4.Location = New System.Drawing.Point(3, 204)
        Me.cmdN4.Name = "cmdN4"
        Me.cmdN4.Size = New System.Drawing.Size(47, 39)
        Me.cmdN4.TabIndex = 16
        Me.cmdN4.Text = "4"
        Me.cmdN4.UseVisualStyleBackColor = False
        '
        'cmdCFmult
        '
        Me.cmdCFmult.BackColor = System.Drawing.Color.DimGray
        Me.cmdCFmult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCFmult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCFmult.Location = New System.Drawing.Point(162, 249)
        Me.cmdCFmult.Name = "cmdCFmult"
        Me.cmdCFmult.Size = New System.Drawing.Size(47, 39)
        Me.cmdCFmult.TabIndex = 24
        Me.cmdCFmult.Text = "x"
        Me.cmdCFmult.UseVisualStyleBackColor = False
        '
        'cmdN3
        '
        Me.cmdN3.BackColor = System.Drawing.Color.DimGray
        Me.cmdN3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdN3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdN3.Location = New System.Drawing.Point(109, 249)
        Me.cmdN3.Name = "cmdN3"
        Me.cmdN3.Size = New System.Drawing.Size(47, 39)
        Me.cmdN3.TabIndex = 23
        Me.cmdN3.Text = "3"
        Me.cmdN3.UseVisualStyleBackColor = False
        '
        'cmdN2
        '
        Me.cmdN2.BackColor = System.Drawing.Color.DimGray
        Me.cmdN2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdN2.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdN2.Location = New System.Drawing.Point(56, 249)
        Me.cmdN2.Name = "cmdN2"
        Me.cmdN2.Size = New System.Drawing.Size(47, 39)
        Me.cmdN2.TabIndex = 22
        Me.cmdN2.Text = "2"
        Me.cmdN2.UseVisualStyleBackColor = False
        '
        'cmdN1
        '
        Me.cmdN1.BackColor = System.Drawing.Color.DimGray
        Me.cmdN1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdN1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdN1.Location = New System.Drawing.Point(3, 249)
        Me.cmdN1.Name = "cmdN1"
        Me.cmdN1.Size = New System.Drawing.Size(47, 39)
        Me.cmdN1.TabIndex = 21
        Me.cmdN1.Text = "1"
        Me.cmdN1.UseVisualStyleBackColor = False
        '
        'cmdCFresu
        '
        Me.cmdCFresu.BackColor = System.Drawing.Color.Silver
        Me.cmdCFresu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCFresu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCFresu.Location = New System.Drawing.Point(215, 249)
        Me.cmdCFresu.Name = "cmdCFresu"
        Me.cmdCFresu.Size = New System.Drawing.Size(47, 84)
        Me.cmdCFresu.TabIndex = 30
        Me.cmdCFresu.Text = "="
        Me.cmdCFresu.UseVisualStyleBackColor = False
        '
        'cmdCFdivi
        '
        Me.cmdCFdivi.BackColor = System.Drawing.Color.DimGray
        Me.cmdCFdivi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCFdivi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCFdivi.Location = New System.Drawing.Point(162, 294)
        Me.cmdCFdivi.Name = "cmdCFdivi"
        Me.cmdCFdivi.Size = New System.Drawing.Size(47, 39)
        Me.cmdCFdivi.TabIndex = 29
        Me.cmdCFdivi.Text = "/"
        Me.cmdCFdivi.UseVisualStyleBackColor = False
        '
        'cmdNdot
        '
        Me.cmdNdot.BackColor = System.Drawing.Color.DimGray
        Me.cmdNdot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNdot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNdot.Location = New System.Drawing.Point(109, 294)
        Me.cmdNdot.Name = "cmdNdot"
        Me.cmdNdot.Size = New System.Drawing.Size(47, 39)
        Me.cmdNdot.TabIndex = 28
        Me.cmdNdot.Text = ","
        Me.cmdNdot.UseVisualStyleBackColor = False
        '
        'cmdN0
        '
        Me.cmdN0.BackColor = System.Drawing.Color.DimGray
        Me.cmdN0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdN0.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdN0.Location = New System.Drawing.Point(56, 294)
        Me.cmdN0.Name = "cmdN0"
        Me.cmdN0.Size = New System.Drawing.Size(47, 39)
        Me.cmdN0.TabIndex = 27
        Me.cmdN0.Text = "0"
        Me.cmdN0.UseVisualStyleBackColor = False
        '
        'cmdCFTogglePosNeg
        '
        Me.cmdCFTogglePosNeg.BackColor = System.Drawing.Color.DimGray
        Me.cmdCFTogglePosNeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCFTogglePosNeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCFTogglePosNeg.Location = New System.Drawing.Point(3, 294)
        Me.cmdCFTogglePosNeg.Name = "cmdCFTogglePosNeg"
        Me.cmdCFTogglePosNeg.Size = New System.Drawing.Size(47, 39)
        Me.cmdCFTogglePosNeg.TabIndex = 26
        Me.cmdCFTogglePosNeg.Text = "+/-"
        Me.cmdCFTogglePosNeg.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel1.Location = New System.Drawing.Point(178, 336)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(84, 13)
        Me.LinkLabel1.TabIndex = 31
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Calculadora"
        Me.ToolTip1.SetToolTip(Me.LinkLabel1, "")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Calculadora"
        '
        'txtResultArea
        '
        Me.txtResultArea.BackColor = System.Drawing.Color.Silver
        Me.txtResultArea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtResultArea.Font = New System.Drawing.Font("Georgia", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultArea.Location = New System.Drawing.Point(3, 33)
        Me.txtResultArea.Multiline = True
        Me.txtResultArea.Name = "txtResultArea"
        Me.txtResultArea.ReadOnly = True
        Me.txtResultArea.Size = New System.Drawing.Size(259, 30)
        Me.txtResultArea.TabIndex = 33
        Me.txtResultArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolTip1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 26)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Pase el mouse sobre cada elemento para obtener " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ayuda. Se puede utilizar con el " & _
    "teclado numérico."
        '
        'frmCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(265, 386)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtResultArea)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.cmdCFresu)
        Me.Controls.Add(Me.cmdCFdivi)
        Me.Controls.Add(Me.cmdNdot)
        Me.Controls.Add(Me.cmdN0)
        Me.Controls.Add(Me.cmdCFTogglePosNeg)
        Me.Controls.Add(Me.cmdCFmult)
        Me.Controls.Add(Me.cmdN3)
        Me.Controls.Add(Me.cmdN2)
        Me.Controls.Add(Me.cmdN1)
        Me.Controls.Add(Me.cmdCFperc)
        Me.Controls.Add(Me.cmdCFless)
        Me.Controls.Add(Me.cmdN6)
        Me.Controls.Add(Me.cmdN5)
        Me.Controls.Add(Me.cmdN4)
        Me.Controls.Add(Me.cmdCFsqrt)
        Me.Controls.Add(Me.cmdCFplus)
        Me.Controls.Add(Me.cmdN9)
        Me.Controls.Add(Me.cmdN8)
        Me.Controls.Add(Me.cmdN7)
        Me.Controls.Add(Me.cmdFBack)
        Me.Controls.Add(Me.cmdFC)
        Me.Controls.Add(Me.cmdFCE)
        Me.Controls.Add(Me.cmdFClose)
        Me.Controls.Add(Me.cmdFMless)
        Me.Controls.Add(Me.cmdFMplus)
        Me.Controls.Add(Me.cmdFMS)
        Me.Controls.Add(Me.cmdFMR)
        Me.Controls.Add(Me.cmdFMC)
        Me.Controls.Add(Me.txtInsertArea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmCalculadora"
        Me.Text = "Calculadora 1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInsertArea As System.Windows.Forms.TextBox
    Friend WithEvents cmdFMC As System.Windows.Forms.Button
    Friend WithEvents cmdFMR As System.Windows.Forms.Button
    Friend WithEvents cmdFMS As System.Windows.Forms.Button
    Friend WithEvents cmdFMplus As System.Windows.Forms.Button
    Friend WithEvents cmdFMless As System.Windows.Forms.Button
    Friend WithEvents cmdFBack As System.Windows.Forms.Button
    Friend WithEvents cmdFC As System.Windows.Forms.Button
    Friend WithEvents cmdFCE As System.Windows.Forms.Button
    Friend WithEvents cmdFClose As System.Windows.Forms.Button
    Friend WithEvents cmdCFsqrt As System.Windows.Forms.Button
    Friend WithEvents cmdCFplus As System.Windows.Forms.Button
    Friend WithEvents cmdN9 As System.Windows.Forms.Button
    Friend WithEvents cmdN8 As System.Windows.Forms.Button
    Friend WithEvents cmdN7 As System.Windows.Forms.Button
    Friend WithEvents cmdCFperc As System.Windows.Forms.Button
    Friend WithEvents cmdCFless As System.Windows.Forms.Button
    Friend WithEvents cmdN6 As System.Windows.Forms.Button
    Friend WithEvents cmdN5 As System.Windows.Forms.Button
    Friend WithEvents cmdN4 As System.Windows.Forms.Button
    Friend WithEvents cmdCFmult As System.Windows.Forms.Button
    Friend WithEvents cmdN3 As System.Windows.Forms.Button
    Friend WithEvents cmdN2 As System.Windows.Forms.Button
    Friend WithEvents cmdN1 As System.Windows.Forms.Button
    Friend WithEvents cmdCFresu As System.Windows.Forms.Button
    Friend WithEvents cmdCFdivi As System.Windows.Forms.Button
    Friend WithEvents cmdNdot As System.Windows.Forms.Button
    Friend WithEvents cmdN0 As System.Windows.Forms.Button
    Friend WithEvents cmdCFTogglePosNeg As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtResultArea As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
