Public Class frmCalculadora
    Dim nAuxMemStorage As Double
    Dim nFirst As Double
    Dim sCalcMode As String
    Dim bNFirst As Boolean

    Private Sub cmdFClose_Click(sender As Object, e As EventArgs) Handles cmdFClose.Click
        If MsgBox("Realmente desea salir?", MsgBoxStyle.OkCancel, "Salir") = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub
    Private Sub addNum(num As String)
        txtInsertArea.Text = txtInsertArea.Text + num
        cmdFBack.Enabled = True
    End Sub

    Private Sub cmdN7_Click(sender As Object, e As EventArgs) Handles cmdN7.Click
        addNum(sender.text)
    End Sub

    Private Sub cmdN8_Click(sender As Object, e As EventArgs) Handles cmdN8.Click
        addNum(sender.text)
    End Sub

    Private Sub cmdN9_Click(sender As Object, e As EventArgs) Handles cmdN9.Click
        addNum(sender.text)
    End Sub

    Private Sub cmdN4_Click(sender As Object, e As EventArgs) Handles cmdN4.Click
        addNum(sender.text)
    End Sub

    Private Sub cmdN5_Click(sender As Object, e As EventArgs) Handles cmdN5.Click
        addNum(sender.text)
    End Sub

    Private Sub cmdN6_Click(sender As Object, e As EventArgs) Handles cmdN6.Click
        addNum(sender.text)
    End Sub

    Private Sub cmdN1_Click(sender As Object, e As EventArgs) Handles cmdN1.Click
        addNum(sender.text)
    End Sub

    Private Sub cmdN2_Click(sender As Object, e As EventArgs) Handles cmdN2.Click
        addNum(sender.text)
    End Sub

    Private Sub cmdN3_Click(sender As Object, e As EventArgs) Handles cmdN3.Click
        addNum(sender.text)
    End Sub

    Private Sub cmdN0_Click(sender As Object, e As EventArgs) Handles cmdN0.Click
        addNum(sender.text)
    End Sub

    Private Sub cmdNdot_Click(sender As Object, e As EventArgs) Handles cmdNdot.Click
        addNum(sender.text)
    End Sub

    Private Sub cmdCFTogglePosNeg_Click(sender As Object, e As EventArgs) Handles cmdCFTogglePosNeg.Click
        If TypeOf validNumber(txtInsertArea.Text) Is Boolean Then
            MsgBox("El número ingresado no es válido.", MsgBoxStyle.Critical, "Error")
        Else
            If validNumber(txtInsertArea.Text) <> 0 Then
                If (txtInsertArea.Text.Substring(0, 1) = "-") Then
                    txtInsertArea.Text = txtInsertArea.Text.Replace("-", "")
                Else
                    txtInsertArea.Text = "-" + txtInsertArea.Text
                End If
            End If
        End If
    End Sub

    Private Sub result(newMode As String)
        If TypeOf validNumber(txtInsertArea.Text) Is Boolean Then
            MsgBox("El número ingresado no es válido.", MsgBoxStyle.Critical, "Error")
        Else
            nFirst = calculate(newMode, validNumber(txtInsertArea.Text))
            bNFirst = True
            txtInsertArea.Text = ""
            cmdFBack.Enabled = False
            txtResultArea.Text = nFirst
        End If
    End Sub

    Public Function HexToDec(ByVal HexStr As String) As Double
        Dim mult As Double
        Dim DecNum As Double
        Dim ch As String
        mult = 1
        DecNum = 0

        Dim i As Integer
        For i = Len(HexStr) To 1 Step -1
            ch = Mid(HexStr, i, 1)
            If (ch >= "0") And (ch <= "9") Then
                DecNum = DecNum + (Val(ch) * mult)
            Else
                If (ch >= "A") And (ch <= "F") Then
                    DecNum = DecNum + ((Asc(ch) - Asc("A") + 10) * mult)
                Else
                    If (ch >= "a") And (ch <= "f") Then
                        DecNum = DecNum + ((Asc(ch) - Asc("a") + 10) * mult)
                    Else
                        HexToDec = 0
                        Exit Function
                    End If
                End If
            End If
            mult = mult * 16
        Next i
        HexToDec = DecNum
    End Function

    Private Function DecToHex(ByVal DecNum As Double) As String
        Dim remainder As Integer
        Dim HexStr As String
        HexStr = ""
        Do While DecNum <> 0
            remainder = DecNum Mod 16
            If remainder <= 9 Then
                HexStr = Chr(Asc(remainder)) & HexStr
            Else
                HexStr = Chr(Asc("A") + remainder - 10) & HexStr
            End If
            DecNum = DecNum \ 16
        Loop
        If HexStr = "" Then HexStr = "0"
        DecToHex = HexStr
    End Function

    Private Function BinToDec(ByVal BinStr As String) As Double
        Dim mult As Double
        Dim DecNum As Double
        mult = 1
        DecNum = 0

        Dim i As Integer
        For i = Len(BinStr) To 1 Step -1
            If Mid(BinStr, i, 1) = "1" Then
                DecNum = DecNum + mult
            End If
            mult = mult * 2
        Next i
        BinToDec = DecNum
    End Function

    Private Function HexToBin(ByVal HexStr As String) As String
        Dim BinStr As String
        BinStr = ""
        Dim i As Integer
        For i = 1 To Len(HexStr)
            BinStr = BinStr & DecToBin(HexToDec(Mid(HexStr, i, 1)))
        Next i
        HexToBin = BinStr
    End Function

    Private Function BinToHex(ByVal BinStr As String) As String
        Dim HexStr As String
        HexStr = ""
        Dim i As Integer
        For i = 1 To Len(BinStr) Step 4
            HexStr = HexStr & DecToHex(BinToDec(Mid(BinStr, i, 4)))
        Next i
        BinToHex = HexStr
    End Function

    Private Function DecToBin(ByVal DecNum As Double) As String
        Dim BinStr As String
        BinStr = ""
        Do While DecNum <> 0
            If (DecNum Mod 2) = 1 Then
                BinStr = "1" & BinStr
            Else
                BinStr = "0" & BinStr
            End If
            DecNum = DecNum \ 2
        Loop
        If BinStr = "" Then BinStr = "0000"
        DecToBin = BinStr
    End Function

    Private Function DecToOct(ByVal DecNum As Double) As String
        Dim numero, resultado As Long
        Dim octal, residuo As String

        numero = Val(DecNum)

        Do
            resultado = Fix(numero / 8)
            residuo = numero Mod 8
            octal = residuo & octal
            numero = resultado
        Loop Until resultado = 0

        DecToOct = octal
    End Function


    Private Function Algebraic(operation As String, number1 As Double, number2 As Double)
        Select operation
            Case "+"
                Return number1 + number2
            Case "-"
                Return number1 - number2
            Case "x"
                Return number1 * number2
            Case "/"
                Return number1 / number2
            Case "sqrt"
                Return Math.Sqrt(number2)
            Case "%"
                Return number2 * number1 / 100
            Case Else
                MsgBox("La operación enviada no se pudo reconocer.", MsgBoxStyle.Critical, "Error")
                Return Nothing
        End Select
    End Function

    Private Function calculate(newMode As String, number As Double)
        Dim retorno As Double
        Try
            Select newMode
                Case "%"
                    retorno = Algebraic(newMode, nFirst, number)
                    retorno = Algebraic(sCalcMode, nFirst, retorno)
                Case "sqrt"
                    retorno = Algebraic(newMode, nFirst, number)
                Case Else
                    Select Case sCalcMode
                        Case Nothing
                            sCalcMode = newMode
                            If bNFirst Then
                                Return nFirst
                            End If
                            Return number
                        Case "+"
                            retorno = Algebraic(sCalcMode, nFirst, number)
                            sCalcMode = newMode
                        Case "-"
                            retorno = Algebraic(sCalcMode, nFirst, number)
                            sCalcMode = newMode
                        Case "x"
                            retorno = Algebraic(sCalcMode, nFirst, number)
                            sCalcMode = newMode
                        Case "/"
                            retorno = Algebraic(sCalcMode, nFirst, number)
                            sCalcMode = newMode
                        Case "="
                            retorno = Algebraic(sCalcMode, nFirst, number)
                        Case Else
                            MsgBox("Ocurrió un error determinando el cálculo a ejecutar", MsgBoxStyle.Critical, "Error")
                    End Select
            End Select
            Return retorno
        Catch ex As Exception
            MsgBox("Ocurrió un error en el cálculo.", MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    Private Function validNumber(toValidate As String)
        Try
            If toValidate = "" Then
                toValidate = "0"
            End If
            Return Convert.ToDouble(toValidate)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub cmdCFplus_Click(sender As Object, e As EventArgs) Handles cmdCFplus.Click
        result(sender.text)
    End Sub
    Private Sub procCE()
        nFirst = Nothing
        bNFirst = False
        sCalcMode = Nothing
        txtInsertArea.Text = ""
        txtResultArea.Text = ""
        cmdFBack.Enabled = False
    End Sub

    Private Sub Form_Keypress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57
                addNum(e.KeyChar)
            Case 43, 45, 37
                result(e.KeyChar)
            Case 42
                result("x")
            Case 47
                result("/")
            Case 118
                result("sqrt")
            Case 27
                procCE()
            Case 8
                cmdFBack_Click()
            Case 13
                result("=")
        End Select
    End Sub
    Private Sub frmCalculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        procCE()
        cmdFMR.Enabled = False
        cmdFMplus.Enabled = False
        cmdFMless.Enabled = False
        cmdFMC.Enabled = False
        cmdCFBinario.Enabled = False
        cmdCFDecimal.Enabled = False
        cmdCFHexadecimal.Enabled = False
        cmdCFOcteto.Enabled = False
        ToolTip1.SetToolTip(cmdFMC, "Limpia la memoria.")
        ToolTip1.SetToolTip(cmdFMR, "Obtiene el número de la memoria sin eliminarlo de la misma.")
        ToolTip1.SetToolTip(cmdFMS, "Aloja el número actual del área de resultados en la memoria.")
        ToolTip1.SetToolTip(cmdFMplus, "Suma el número actual del área de resultados al valor que está en memoria.")
        ToolTip1.SetToolTip(cmdFMless, "Resta el número actual del área de resultados al valor que está en memoria.")
        ToolTip1.SetToolTip(cmdFC, "Borra el número que se está ingresando actualmente.")
        ToolTip1.SetToolTip(cmdFCE, "Borra toda la operación que se está realizando actualmente. Corresponde a la tecla 'Esc'.")
        ToolTip1.SetToolTip(cmdFBack, "Borra el último dígito ingresado. Corresponde a la tecla Backspace o Retroceso.")
        ToolTip1.SetToolTip(cmdFClose, "Cierra el programa, perdiendo toda la información de la ejecución actual. Solicita confirmación.")
        ToolTip1.SetToolTip(txtInsertArea, "Área de ingreso de valores. Se puede copiar el valor que aquí aparece.")
        ToolTip1.SetToolTip(txtResultArea, "Área de resultados. Se puede copiar el valor que aquí aparece, pero no editar.")
        For Each objeto As Control In Me.Controls
            AddHandler objeto.KeyPress, AddressOf Form_Keypress
        Next
    End Sub



    Private Sub cmdFCE_Click(sender As Object, e As EventArgs) Handles cmdFCE.Click
        procCE()
    End Sub

    Private Sub cmdFC_Click(sender As Object, e As EventArgs) Handles cmdFC.Click
        txtInsertArea.Text = ""
    End Sub

    Private Sub cmdFMC_Click(sender As Object, e As EventArgs) Handles cmdFMC.Click
        nAuxMemStorage = Nothing
        cmdFMR.Enabled = False
        cmdFMplus.Enabled = False
        cmdFMless.Enabled = False
        cmdFMC.Enabled = False
    End Sub

    Private Sub cmdFMR_Click(sender As Object, e As EventArgs) Handles cmdFMR.Click
        txtInsertArea.Text = nAuxMemStorage
    End Sub

    Private Sub cmdFMS_Click(sender As Object, e As EventArgs) Handles cmdFMS.Click
        If TypeOf validNumber(txtResultArea.Text) Is Boolean Then
            MsgBox("El número ingresado no es válido.", MsgBoxStyle.Critical, "Error")
        Else
            nAuxMemStorage = validNumber(txtResultArea.Text)
            cmdFMR.Enabled = True
            cmdFMplus.Enabled = True
            cmdFMless.Enabled = True
            cmdFMC.Enabled = True
        End If
    End Sub
    Private Sub addToMem(memmode As String)
        If TypeOf validNumber(txtResultArea.Text) Is Boolean Then
            MsgBox("El número ingresado no es válido.", MsgBoxStyle.Critical, "Error")
        Else
            nAuxMemStorage = Algebraic(memmode, nAuxMemStorage, validNumber(txtResultArea.Text))
        End If
    End Sub
    

    Private Sub cmdFMplus_Click(sender As Object, e As EventArgs) Handles cmdFMplus.Click
        addToMem("+")
    End Sub

    Private Sub cmdFMless_Click(sender As Object, e As EventArgs) Handles cmdFMless.Click
        addToMem("-")
    End Sub

    Private Sub cmdCFresu_Click(sender As Object, e As EventArgs) Handles cmdCFresu.Click
        result(sCalcMode)
    End Sub

    Private Sub cmdCFsqrt_Click(sender As Object, e As EventArgs) Handles cmdCFsqrt.Click
        result("sqrt")
    End Sub

    Private Sub cmdCFless_Click(sender As Object, e As EventArgs) Handles cmdCFless.Click
        result(sender.text)
    End Sub

    Private Sub cmdCFperc_Click(sender As Object, e As EventArgs) Handles cmdCFperc.Click
        result(sender.text)
    End Sub

    Private Sub cmdCFmult_Click(sender As Object, e As EventArgs) Handles cmdCFmult.Click
        result(sender.text)
    End Sub

    Private Sub cmdCFdivi_Click(sender As Object, e As EventArgs) Handles cmdCFdivi.Click
        result(sender.text)
    End Sub

    Private Sub cmdFBack_Click() Handles cmdFBack.Click
        If (txtInsertArea.Text.Length = 1) Or txtInsertArea.Text = "" Then
            txtInsertArea.Text = ""
            cmdFBack.Enabled = False
        Else
            txtInsertArea.Text = txtInsertArea.Text.Substring(0, txtInsertArea.Text.Length - 1)
        End If


    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup
    
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/jorgarciac")
    End Sub

    Private Sub cmdFBack_Click(sender As Object, e As EventArgs) Handles cmdFBack.Click

    End Sub

    Private Sub rbCalculadora_CheckedChanged(sender As Object, e As EventArgs) Handles rbCalculadora.CheckedChanged
        If (rbCalculadora.Checked = True) Then
            txtInsertArea.Text = ""
            cmdCFBinario.Enabled = False
            cmdCFDecimal.Enabled = False
            cmdCFHexadecimal.Enabled = False
            cmdCFOcteto.Enabled = False
            cmdN0.Enabled = True
            cmdN1.Enabled = True
            cmdN2.Enabled = True
            cmdN3.Enabled = True
            cmdN4.Enabled = True
            cmdN5.Enabled = True
            cmdN6.Enabled = True
            cmdN7.Enabled = True
            cmdN8.Enabled = True
            cmdN9.Enabled = True
            cmdNdot.Enabled = True
            cmdCFTogglePosNeg.Enabled = True
            cmdCFdivi.Enabled = True
            cmdCFmult.Enabled = True
            cmdCFless.Enabled = True
            cmdCFplus.Enabled = True
            cmdCFsqrt.Enabled = True
            cmdCFperc.Enabled = True
            cmdCFresu.Enabled = True
            cmdFMS.Enabled = True
            cmdLA.Enabled = False
            cmdLB.Enabled = False
            cmdLC.Enabled = False
            cmdLD.Enabled = False
            cmdLE.Enabled = False
            cmdLF.Enabled = False
        End If
    End Sub

    Private Sub rbBinario_CheckedChanged(sender As Object, e As EventArgs) Handles rbBinario.CheckedChanged
        If (rbBinario.Checked = True) Then
            txtInsertArea.Text = ""
            cmdCFBinario.Enabled = False
            cmdCFDecimal.Enabled = True
            cmdCFHexadecimal.Enabled = True
            cmdCFOcteto.Enabled = True
            cmdN0.Enabled = True
            cmdN1.Enabled = True
            cmdN2.Enabled = False
            cmdN3.Enabled = False
            cmdN4.Enabled = False
            cmdN5.Enabled = False
            cmdN6.Enabled = False
            cmdN7.Enabled = False
            cmdN8.Enabled = False
            cmdN9.Enabled = False
            cmdNdot.Enabled = False
            cmdCFTogglePosNeg.Enabled = False
            cmdCFdivi.Enabled = False
            cmdCFmult.Enabled = False
            cmdCFless.Enabled = False
            cmdCFplus.Enabled = False
            cmdCFsqrt.Enabled = False
            cmdCFperc.Enabled = False
            cmdCFresu.Enabled = False
            cmdFMS.Enabled = False
            cmdLA.Enabled = False
            cmdLB.Enabled = False
            cmdLC.Enabled = False
            cmdLD.Enabled = False
            cmdLE.Enabled = False
            cmdLF.Enabled = False
        End If
    End Sub

    Private Sub rbDecimal_CheckedChanged(sender As Object, e As EventArgs) Handles rbDecimal.CheckedChanged
        If (rbDecimal.Checked = True) Then
            txtInsertArea.Text = ""
            cmdCFBinario.Enabled = True
            cmdCFDecimal.Enabled = False
            cmdCFHexadecimal.Enabled = True
            cmdCFOcteto.Enabled = True
            cmdN0.Enabled = True
            cmdN1.Enabled = True
            cmdN2.Enabled = True
            cmdN3.Enabled = True
            cmdN4.Enabled = True
            cmdN5.Enabled = True
            cmdN6.Enabled = True
            cmdN7.Enabled = True
            cmdN8.Enabled = True
            cmdN9.Enabled = True
            cmdNdot.Enabled = False
            cmdCFTogglePosNeg.Enabled = False
            cmdCFdivi.Enabled = False
            cmdCFmult.Enabled = False
            cmdCFless.Enabled = False
            cmdCFplus.Enabled = False
            cmdCFsqrt.Enabled = False
            cmdCFperc.Enabled = False
            cmdCFresu.Enabled = False
            cmdFMS.Enabled = False
            cmdLA.Enabled = False
            cmdLB.Enabled = False
            cmdLC.Enabled = False
            cmdLD.Enabled = False
            cmdLE.Enabled = False
            cmdLF.Enabled = False
        End If
    End Sub

    Private Sub rbHexadecimal_CheckedChanged(sender As Object, e As EventArgs) Handles rbHexadecimal.CheckedChanged
        If (rbHexadecimal.Enabled = True) Then
            txtInsertArea.Text = ""
            cmdCFBinario.Enabled = True
            cmdCFDecimal.Enabled = True
            cmdCFHexadecimal.Enabled = False
            cmdCFOcteto.Enabled = True
            cmdN0.Enabled = True
            cmdN1.Enabled = True
            cmdN2.Enabled = True
            cmdN3.Enabled = True
            cmdN4.Enabled = True
            cmdN5.Enabled = True
            cmdN6.Enabled = True
            cmdN7.Enabled = True
            cmdN8.Enabled = True
            cmdN9.Enabled = True
            cmdNdot.Enabled = False
            cmdCFTogglePosNeg.Enabled = False
            cmdCFdivi.Enabled = False
            cmdCFmult.Enabled = False
            cmdCFless.Enabled = False
            cmdCFplus.Enabled = False
            cmdCFsqrt.Enabled = False
            cmdCFperc.Enabled = False
            cmdCFresu.Enabled = False
            cmdFMS.Enabled = False
            cmdLA.Enabled = True
            cmdLB.Enabled = True
            cmdLC.Enabled = True
            cmdLD.Enabled = True
            cmdLE.Enabled = True
            cmdLF.Enabled = True
        End If
    End Sub

    Private Sub rbOctal_CheckedChanged(sender As Object, e As EventArgs) Handles rbOctal.CheckedChanged
        If (rbOctal.Enabled = True) Then
            txtInsertArea.Text = ""
            cmdCFBinario.Enabled = True
            cmdCFDecimal.Enabled = True
            cmdCFHexadecimal.Enabled = True
            cmdCFOcteto.Enabled = False
            cmdN0.Enabled = True
            cmdN1.Enabled = True
            cmdN2.Enabled = True
            cmdN3.Enabled = True
            cmdN4.Enabled = True
            cmdN5.Enabled = True
            cmdN6.Enabled = True
            cmdN7.Enabled = True
            cmdN8.Enabled = False
            cmdN9.Enabled = False
            cmdNdot.Enabled = False
            cmdCFTogglePosNeg.Enabled = False
            cmdCFdivi.Enabled = False
            cmdCFmult.Enabled = False
            cmdCFless.Enabled = False
            cmdCFplus.Enabled = False
            cmdCFsqrt.Enabled = False
            cmdCFperc.Enabled = False
            cmdCFresu.Enabled = False
            cmdFMS.Enabled = False
            cmdLA.Enabled = False
            cmdLB.Enabled = False
            cmdLC.Enabled = False
            cmdLD.Enabled = False
            cmdLE.Enabled = False
            cmdLF.Enabled = False
        End If
    End Sub



    Private Sub cmdLA_Click(sender As Object, e As EventArgs) Handles cmdLA.Click
        addNum(sender.text)
    End Sub

    Private Sub cmdLB_Click(sender As Object, e As EventArgs) Handles cmdLB.Click
        addNum(sender.text)
    End Sub

    Private Sub cmdLC_Click(sender As Object, e As EventArgs) Handles cmdLC.Click
        addNum(sender.text)
    End Sub

    Private Sub cmdLD_Click(sender As Object, e As EventArgs) Handles cmdLD.Click
        addNum(sender.text)
    End Sub

    Private Sub cmdLE_Click(sender As Object, e As EventArgs) Handles cmdLE.Click
        addNum(sender.text)
    End Sub

    Private Sub cmdLF_Click(sender As Object, e As EventArgs) Handles cmdLF.Click
        addNum(sender.text)
    End Sub

    Private Sub cmdCFDecimal_Click(sender As Object, e As EventArgs) Handles cmdCFDecimal.Click
        If (rbBinario.Checked = True) Then
            txtResultArea.Text = BinToDec(txtInsertArea.Text)
        ElseIf (rbHexadecimal.Checked = True) Then
            txtResultArea.Text = HexToDec(txtInsertArea.Text)
        ElseIf (rbOctal.Checked = True) Then
            txtResultArea.Text = Convert.ToByte(Val(txtInsertArea.Text), 8)
        End If
    End Sub

    Private Sub cmdCFHexadecimal_Click(sender As Object, e As EventArgs) Handles cmdCFHexadecimal.Click
        If (rbBinario.Checked = True) Then
            ''Codigo para convertir de binario a hexadecimal
            txtResultArea.Text = DecToHex(BinToDec(txtInsertArea.Text))
        ElseIf (rbDecimal.Checked = True) Then
            ''Codigo para convertir de decimal a hexadecimal
            txtResultArea.Text = DecToHex(Val(txtInsertArea.Text))
        ElseIf (rbOctal.Checked = True) Then
            ''Codigo para convertir de Octeto a Hexadecimal
            txtResultArea.Text = DecToHex(Convert.ToByte(txtInsertArea.Text, 8))

        End If
    End Sub

    Private Sub cmdCFOcteto_Click(sender As Object, e As EventArgs) Handles cmdCFOcteto.Click
        If (rbBinario.Checked = True) Then
            ''Codigo para convertir de binario a octeto
            txtResultArea.Text = DecToOct(BinToDec(txtInsertArea.Text))
        ElseIf (rbDecimal.Checked = True) Then
            ''Codigo para convertir de decimal a octeto
            txtResultArea.Text = DecToOct(txtInsertArea.Text)
        ElseIf (rbHexadecimal.Checked = True) Then
            ''Codigo para convertir de Hexadecimal a octeto
            txtResultArea.Text = DecToOct(HexToDec(txtInsertArea.Text))
        End If
    End Sub

    Private Sub cmdCFBinario_Click(sender As Object, e As EventArgs) Handles cmdCFBinario.Click
        If (rbOctal.Checked = True) Then
            ''Codigo para convertir de binario a octeto
            txtResultArea.Text = DecToBin(Convert.ToByte(txtInsertArea.Text, 8))
        ElseIf (rbDecimal.Checked = True) Then
            ''Codigo para convertir de decimal a octeto
            txtResultArea.Text = DecToBin(txtInsertArea.Text)
        ElseIf (rbHexadecimal.Checked = True) Then
            ''Codigo para convertir de Hexadecimal a octeto
            txtResultArea.Text = HexToBin(txtInsertArea.Text)
        End If
    End Sub
End Class
