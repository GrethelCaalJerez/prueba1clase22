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
End Class
