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
        Me.rbCalculadora = New System.Windows.Forms.RadioButton()
        Me.rbBinario = New System.Windows.Forms.RadioButton()
        Me.rbDecimal = New System.Windows.Forms.RadioButton()
        Me.rbHexadecimal = New System.Windows.Forms.RadioButton()
        Me.rbOctal = New System.Windows.Forms.RadioButton()
        Me.cmdCFBinario = New System.Windows.Forms.Button()
        Me.cmdCFDecimal = New System.Windows.Forms.Button()
        Me.cmdCFHexadecimal = New System.Windows.Forms.Button()
        Me.cmdCFOcteto = New System.Windows.Forms.Button()
        Me.cmdLA = New System.Windows.Forms.Button()
        Me.cmdLB = New System.Windows.Forms.Button()
        Me.cmdLC = New System.Windows.Forms.Button()
        Me.cmdLD = New System.Windows.Forms.Button()
        Me.cmdLE = New System.Windows.Forms.Button()
        Me.cmdLF = New System.Windows.Forms.Button()
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
        Me.txtInsertArea.Size = New System.Drawing.Size(368, 30)
        Me.txtInsertArea.TabIndex = 0
        '
        'cmdFMC
        '
        Me.cmdFMC.BackColor = System.Drawing.Color.Silver
        Me.cmdFMC.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdFMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFMC.Location = New System.Drawing.Point(56, 104)
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
        Me.cmdFMR.Location = New System.Drawing.Point(109, 104)
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
        Me.cmdFMS.Location = New System.Drawing.Point(3, 104)
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
        Me.cmdFMplus.Location = New System.Drawing.Point(162, 104)
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
        Me.cmdFMless.Location = New System.Drawing.Point(215, 104)
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
        Me.cmdFBack.Location = New System.Drawing.Point(268, 149)
        Me.cmdFBack.Name = "cmdFBack"
        Me.cmdFBack.Size = New System.Drawing.Size(99, 83)
        Me.cmdFBack.TabIndex = 10
        Me.cmdFBack.Text = "ß"
        Me.cmdFBack.UseVisualStyleBackColor = False
        '
        'cmdFC
        '
        Me.cmdFC.BackColor = System.Drawing.Color.Silver
        Me.cmdFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFC.Location = New System.Drawing.Point(162, 193)
        Me.cmdFC.Name = "cmdFC"
        Me.cmdFC.Size = New System.Drawing.Size(100, 39)
        Me.cmdFC.TabIndex = 8
        Me.cmdFC.Text = "C"
        Me.cmdFC.UseVisualStyleBackColor = False
        '
        'cmdFCE
        '
        Me.cmdFCE.BackColor = System.Drawing.Color.Silver
        Me.cmdFCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFCE.Location = New System.Drawing.Point(162, 149)
        Me.cmdFCE.Name = "cmdFCE"
        Me.cmdFCE.Size = New System.Drawing.Size(100, 39)
        Me.cmdFCE.TabIndex = 7
        Me.cmdFCE.Text = "CE"
        Me.cmdFCE.UseVisualStyleBackColor = False
        '
        'cmdFClose
        '
        Me.cmdFClose.BackColor = System.Drawing.Color.Pink
        Me.cmdFClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFClose.Font = New System.Drawing.Font("Wingdings", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdFClose.Location = New System.Drawing.Point(268, 104)
        Me.cmdFClose.Name = "cmdFClose"
        Me.cmdFClose.Size = New System.Drawing.Size(99, 39)
        Me.cmdFClose.TabIndex = 6
        Me.cmdFClose.Text = "x"
        Me.cmdFClose.UseVisualStyleBackColor = False
        '
        'cmdCFsqrt
        '
        Me.cmdCFsqrt.BackColor = System.Drawing.Color.DimGray
        Me.cmdCFsqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCFsqrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCFsqrt.Location = New System.Drawing.Point(215, 238)
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
        Me.cmdCFplus.Location = New System.Drawing.Point(162, 238)
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
        Me.cmdN9.Location = New System.Drawing.Point(109, 238)
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
        Me.cmdN8.Location = New System.Drawing.Point(56, 238)
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
        Me.cmdN7.Location = New System.Drawing.Point(3, 238)
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
        Me.cmdCFperc.Location = New System.Drawing.Point(215, 283)
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
        Me.cmdCFless.Location = New System.Drawing.Point(162, 283)
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
        Me.cmdN6.Location = New System.Drawing.Point(109, 283)
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
        Me.cmdN5.Location = New System.Drawing.Point(56, 283)
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
        Me.cmdN4.Location = New System.Drawing.Point(3, 283)
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
        Me.cmdCFmult.Location = New System.Drawing.Point(162, 328)
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
        Me.cmdN3.Location = New System.Drawing.Point(109, 328)
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
        Me.cmdN2.Location = New System.Drawing.Point(56, 328)
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
        Me.cmdN1.Location = New System.Drawing.Point(3, 328)
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
        Me.cmdCFresu.Location = New System.Drawing.Point(215, 328)
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
        Me.cmdCFdivi.Location = New System.Drawing.Point(162, 373)
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
        Me.cmdNdot.Location = New System.Drawing.Point(109, 373)
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
        Me.cmdN0.Location = New System.Drawing.Point(56, 373)
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
        Me.cmdCFTogglePosNeg.Location = New System.Drawing.Point(3, 373)
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
        Me.LinkLabel1.Location = New System.Drawing.Point(222, 415)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(145, 13)
        Me.LinkLabel1.TabIndex = 31
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Jorge Eduardo García Castro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 415)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Ir a perfil de Github"
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
        Me.txtResultArea.Size = New System.Drawing.Size(368, 30)
        Me.txtResultArea.TabIndex = 33
        Me.txtResultArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolTip1
        '
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 435)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 26)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Pase el mouse sobre cada elemento para obtener " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ayuda. Se puede utilizar con el " &
    "teclado numérico."
        '
        'rbCalculadora
        '
        Me.rbCalculadora.AutoSize = True
        Me.rbCalculadora.Checked = True
        Me.rbCalculadora.Location = New System.Drawing.Point(3, 69)
        Me.rbCalculadora.Name = "rbCalculadora"
        Me.rbCalculadora.Size = New System.Drawing.Size(81, 17)
        Me.rbCalculadora.TabIndex = 35
        Me.rbCalculadora.TabStop = True
        Me.rbCalculadora.Text = "Calculadora"
        Me.rbCalculadora.UseVisualStyleBackColor = True
        '
        'rbBinario
        '
        Me.rbBinario.AutoSize = True
        Me.rbBinario.Location = New System.Drawing.Point(90, 69)
        Me.rbBinario.Name = "rbBinario"
        Me.rbBinario.Size = New System.Drawing.Size(57, 17)
        Me.rbBinario.TabIndex = 36
        Me.rbBinario.Text = "Binario"
        Me.rbBinario.UseVisualStyleBackColor = True
        '
        'rbDecimal
        '
        Me.rbDecimal.AutoSize = True
        Me.rbDecimal.Location = New System.Drawing.Point(154, 69)
        Me.rbDecimal.Name = "rbDecimal"
        Me.rbDecimal.Size = New System.Drawing.Size(63, 17)
        Me.rbDecimal.TabIndex = 37
        Me.rbDecimal.Text = "Decimal"
        Me.rbDecimal.UseVisualStyleBackColor = True
        '
        'rbHexadecimal
        '
        Me.rbHexadecimal.AutoSize = True
        Me.rbHexadecimal.Location = New System.Drawing.Point(224, 69)
        Me.rbHexadecimal.Name = "rbHexadecimal"
        Me.rbHexadecimal.Size = New System.Drawing.Size(86, 17)
        Me.rbHexadecimal.TabIndex = 38
        Me.rbHexadecimal.Text = "Hexadecimal"
        Me.rbHexadecimal.UseVisualStyleBackColor = True
        '
        'rbOctal
        '
        Me.rbOctal.AutoSize = True
        Me.rbOctal.Location = New System.Drawing.Point(317, 70)
        Me.rbOctal.Name = "rbOctal"
        Me.rbOctal.Size = New System.Drawing.Size(50, 17)
        Me.rbOctal.TabIndex = 39
        Me.rbOctal.Text = "Octal"
        Me.rbOctal.UseVisualStyleBackColor = True
        '
        'cmdCFBinario
        '
        Me.cmdCFBinario.BackColor = System.Drawing.Color.Silver
        Me.cmdCFBinario.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdCFBinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCFBinario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCFBinario.Location = New System.Drawing.Point(268, 238)
        Me.cmdCFBinario.Name = "cmdCFBinario"
        Me.cmdCFBinario.Size = New System.Drawing.Size(99, 39)
        Me.cmdCFBinario.TabIndex = 40
        Me.cmdCFBinario.Text = "Binario"
        Me.cmdCFBinario.UseVisualStyleBackColor = False
        '
        'cmdCFDecimal
        '
        Me.cmdCFDecimal.BackColor = System.Drawing.Color.Silver
        Me.cmdCFDecimal.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdCFDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCFDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCFDecimal.Location = New System.Drawing.Point(268, 283)
        Me.cmdCFDecimal.Name = "cmdCFDecimal"
        Me.cmdCFDecimal.Size = New System.Drawing.Size(99, 39)
        Me.cmdCFDecimal.TabIndex = 41
        Me.cmdCFDecimal.Text = "Decimal"
        Me.cmdCFDecimal.UseVisualStyleBackColor = False
        '
        'cmdCFHexadecimal
        '
        Me.cmdCFHexadecimal.BackColor = System.Drawing.Color.Silver
        Me.cmdCFHexadecimal.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdCFHexadecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCFHexadecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCFHexadecimal.Location = New System.Drawing.Point(268, 328)
        Me.cmdCFHexadecimal.Name = "cmdCFHexadecimal"
        Me.cmdCFHexadecimal.Size = New System.Drawing.Size(99, 39)
        Me.cmdCFHexadecimal.TabIndex = 42
        Me.cmdCFHexadecimal.Text = "Hexade"
        Me.cmdCFHexadecimal.UseVisualStyleBackColor = False
        '
        'cmdCFOcteto
        '
        Me.cmdCFOcteto.BackColor = System.Drawing.Color.Silver
        Me.cmdCFOcteto.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cmdCFOcteto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCFOcteto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCFOcteto.Location = New System.Drawing.Point(268, 373)
        Me.cmdCFOcteto.Name = "cmdCFOcteto"
        Me.cmdCFOcteto.Size = New System.Drawing.Size(99, 39)
        Me.cmdCFOcteto.TabIndex = 43
        Me.cmdCFOcteto.Text = "Octal"
        Me.cmdCFOcteto.UseVisualStyleBackColor = False
        '
        'cmdLA
        '
        Me.cmdLA.BackColor = System.Drawing.Color.DimGray
        Me.cmdLA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLA.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLA.Location = New System.Drawing.Point(3, 148)
        Me.cmdLA.Name = "cmdLA"
        Me.cmdLA.Size = New System.Drawing.Size(47, 39)
        Me.cmdLA.TabIndex = 44
        Me.cmdLA.Text = "A"
        Me.cmdLA.UseVisualStyleBackColor = False
        '
        'cmdLB
        '
        Me.cmdLB.BackColor = System.Drawing.Color.DimGray
        Me.cmdLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLB.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLB.Location = New System.Drawing.Point(56, 148)
        Me.cmdLB.Name = "cmdLB"
        Me.cmdLB.Size = New System.Drawing.Size(47, 39)
        Me.cmdLB.TabIndex = 45
        Me.cmdLB.Text = "B"
        Me.cmdLB.UseVisualStyleBackColor = False
        '
        'cmdLC
        '
        Me.cmdLC.BackColor = System.Drawing.Color.DimGray
        Me.cmdLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLC.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLC.Location = New System.Drawing.Point(109, 148)
        Me.cmdLC.Name = "cmdLC"
        Me.cmdLC.Size = New System.Drawing.Size(47, 39)
        Me.cmdLC.TabIndex = 46
        Me.cmdLC.Text = "C"
        Me.cmdLC.UseVisualStyleBackColor = False
        '
        'cmdLD
        '
        Me.cmdLD.BackColor = System.Drawing.Color.DimGray
        Me.cmdLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLD.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLD.Location = New System.Drawing.Point(3, 193)
        Me.cmdLD.Name = "cmdLD"
        Me.cmdLD.Size = New System.Drawing.Size(47, 39)
        Me.cmdLD.TabIndex = 47
        Me.cmdLD.Text = "D"
        Me.cmdLD.UseVisualStyleBackColor = False
        '
        'cmdLE
        '
        Me.cmdLE.BackColor = System.Drawing.Color.DimGray
        Me.cmdLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLE.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLE.Location = New System.Drawing.Point(56, 193)
        Me.cmdLE.Name = "cmdLE"
        Me.cmdLE.Size = New System.Drawing.Size(47, 39)
        Me.cmdLE.TabIndex = 48
        Me.cmdLE.Text = "E"
        Me.cmdLE.UseVisualStyleBackColor = False
        '
        'cmdLF
        '
        Me.cmdLF.BackColor = System.Drawing.Color.DimGray
        Me.cmdLF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLF.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLF.Location = New System.Drawing.Point(109, 193)
        Me.cmdLF.Name = "cmdLF"
        Me.cmdLF.Size = New System.Drawing.Size(47, 39)
        Me.cmdLF.TabIndex = 49
        Me.cmdLF.Text = "F"
        Me.cmdLF.UseVisualStyleBackColor = False
        '
        'frmCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(374, 502)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdLF)
        Me.Controls.Add(Me.cmdLE)
        Me.Controls.Add(Me.cmdLD)
        Me.Controls.Add(Me.cmdLC)
        Me.Controls.Add(Me.cmdLB)
        Me.Controls.Add(Me.cmdLA)
        Me.Controls.Add(Me.cmdCFOcteto)
        Me.Controls.Add(Me.cmdCFHexadecimal)
        Me.Controls.Add(Me.cmdCFDecimal)
        Me.Controls.Add(Me.cmdCFBinario)
        Me.Controls.Add(Me.rbOctal)
        Me.Controls.Add(Me.rbHexadecimal)
        Me.Controls.Add(Me.rbDecimal)
        Me.Controls.Add(Me.rbBinario)
        Me.Controls.Add(Me.rbCalculadora)
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
    Friend WithEvents rbCalculadora As RadioButton
    Friend WithEvents rbBinario As RadioButton
    Friend WithEvents rbDecimal As RadioButton
    Friend WithEvents rbHexadecimal As RadioButton
    Friend WithEvents rbOctal As RadioButton
    Friend WithEvents cmdCFBinario As Button
    Friend WithEvents cmdCFDecimal As Button
    Friend WithEvents cmdCFHexadecimal As Button
    Friend WithEvents cmdCFOcteto As Button
    Friend WithEvents cmdLA As Button
    Friend WithEvents cmdLB As Button
    Friend WithEvents cmdLC As Button
    Friend WithEvents cmdLD As Button
    Friend WithEvents cmdLE As Button
    Friend WithEvents cmdLF As Button
End Class
