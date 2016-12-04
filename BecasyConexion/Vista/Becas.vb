Public Class Becas

    Private dt As New DataTable

    Public Sub limpiar()
        
        nombre.Text = ""
        apellido.Text = ""
        pro1.Text = ""
        pro2.Text = ""
        pro3.Text = ""
        pro4.Text = ""
        pro5.Text = ""
        pro6.Text = ""

        btnguardar.Visible = True
        btneditar.Visible = False


    End Sub



    Private Sub Becas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mostrar()


    End Sub

    Private Sub mostrar()
        Try
            Dim func As New falumno
            dt = func.mostrar
           

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                datalistado.ColumnHeadersVisible = True

            Else
                datalistado.DataSource = Nothing
                datalistado.ColumnHeadersVisible = False

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btneditar.Click

        Dim resul As DialogResult

        resul = MessageBox.Show("Realmente desea editar los datos del Alumno? ", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resul = DialogResult.OK Then


            Try
                Dim dts As New Valumno
                Dim func As New falumno

                dts.gid = txtid.Text
                dts.gnombre = nombre.Text
                dts.gapellidos = apellido.Text
                dts.gcal1 = pro1.Text
                dts.gcal2 = pro2.Text
                dts.gcal3 = pro3.Text
                dts.gcal4 = pro4.Text
                dts.gcal5 = pro5.Text
                dts.gcal6 = pro6.Text


                If func.editar(dts) Then
                    MessageBox.Show("Alumno modificado correctamente", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("Alumno no modificado intente de nuevo", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Modificando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub



    Private Sub nombre_TextChanged(sender As Object, e As EventArgs) Handles nombre.TextChanged

    End Sub

    Private Sub nombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles nombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Ingresar el nombre del Alumno")
        End If
    End Sub

    Private Sub apellido_TextChanged(sender As Object, e As EventArgs) Handles apellido.TextChanged

    End Sub

    Private Sub apellido_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles apellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Ingresar los Apellidos del Alumno")
        End If
    End Sub

    Private Sub pro1_TextChanged(sender As Object, e As EventArgs) Handles pro1.TextChanged

    End Sub

    Private Sub pro1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles pro1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Ingresar la calificación del Semestre 1 del Alumno")
        End If
    End Sub

    Private Sub pro2_TextChanged(sender As Object, e As EventArgs) Handles pro2.TextChanged

    End Sub

    Private Sub pro2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles pro2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Ingresar la calificación del Semestre 2 del Alumno")
        End If
    End Sub

    Private Sub pro3_TextChanged(sender As Object, e As EventArgs) Handles pro3.TextChanged

    End Sub

    Private Sub pro3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles pro3.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Ingresar la calificación del Semestre 3 del Alumno")
        End If
    End Sub

    Private Sub pro4_TextChanged(sender As Object, e As EventArgs) Handles pro4.TextChanged

    End Sub

    Private Sub pro4_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles pro4.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Ingresar la calificación del Semestre 4 del Alumno")
        End If
    End Sub

    Private Sub pro5_TextChanged(sender As Object, e As EventArgs) Handles pro5.TextChanged

    End Sub

    Private Sub pro5_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles pro5.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Ingresar la calificación del Semestre 5 del Alumno")
        End If
    End Sub

    Private Sub pro6_TextChanged(sender As Object, e As EventArgs) Handles pro6.TextChanged

    End Sub

    Private Sub pro6_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles pro6.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcon.SetError(sender, "")
        Else
            Me.ErrorIcon.SetError(sender, "Ingresar la calificación del Semestre 6 del Alumno")
        End If
    End Sub

    Private Sub datalistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellClick
        Dim i As Integer

        i = datalistado.CurrentRow.Index

        txtid.Text = datalistado.Item(1, i).Value()
        nombre.Text = datalistado.Item(2, i).Value()
        apellido.Text = datalistado.Item(3, i).Value()
        pro1.Text = datalistado.Item(4, i).Value()
        pro2.Text = datalistado.Item(5, i).Value()
        pro3.Text = datalistado.Item(6, i).Value()
        pro4.Text = datalistado.Item(7, i).Value()
        pro5.Text = datalistado.Item(8, i).Value()
        pro6.Text = datalistado.Item(9, i).Value()

        btneditar.Visible = True
        btnguardar.Visible = False
    End Sub

    Private Sub datalistado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datalistado.CellContentClick
        If e.ColumnIndex = Me.datalistado.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.datalistado.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim resultado As Double
        Dim A, B, C, D, G, F As Double

        A = pro1.Text
        B = pro2.Text
        C = pro3.Text
        D = pro4.Text
        G = pro5.Text
        F = pro6.Text


        resultado = (A + B + C + D + G + F) / 6



        If resultado >= 8 And resultado < 9 Then
            MessageBox.Show("El alumno" & " " & nombre.Text & " " & " tiene un promedio de " & " " & resultado & " " & " y Tiene una beca de Transporte", "Beca de Transporte ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf resultado >= 9 And resultado < 10 Then
            MessageBox.Show("El alumno" & " " & nombre.Text & " " & " tiene un promedio de " & " " & resultado & " " & " y Tiene una beca de Manutención", "Beca de Manutención ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf resultado = 10 Then
            MessageBox.Show("El alumno" & " " & nombre.Text & " " & " tiene un promedio de " & " " & resultado & " " & " y Tiene una beca de Pablo Garcia", "Beca de Pablo Garcia ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            MessageBox.Show("el alumno no tiene ninguna beca", "sin beca", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        limpiar()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And nombre.Text <> "" And apellido.Text <> "" And pro1.Text <> "" And pro2.Text <> "" And pro3.Text <> "" And pro4.Text <> "" And pro5.Text <> "" And pro6.Text <> "" Then

            Try
                Dim fel As New Valumno
                Dim func As New falumno


                fel.gnombre = nombre.Text
                fel.gapellidos = apellido.Text
                fel.gcal1 = pro1.Text
                fel.gcal2 = pro2.Text
                fel.gcal3 = pro3.Text
                fel.gcal4 = pro4.Text
                fel.gcal5 = pro5.Text
                fel.gcal6 = pro6.Text


                If func.insertar(fel) Then
                    MessageBox.Show("Alumno Registrado corectamente", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    mostrar()
                Else
                    MessageBox.Show("Alumno NO registrado ", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MessageBox.Show("Faltan ingresar algunos datos ", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim resul As DialogResult

        resul = MessageBox.Show("Realmente desea eliminar los Alumno seleccionados?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If resul = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In datalistado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id").Value)
                        Dim vdb As New Valumno
                        Dim func As New falumno
                        vdb.gid = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("Alumno no fue eliminado", "Eliminando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        End If
                    End If

                Next
                Call mostrar()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If

        Call limpiar()
    End Sub
    
    Private Sub cbelimiar_CheckedChanged(sender As Object, e As EventArgs) Handles cbelimiar.CheckedChanged
        If cbelimiar.CheckState = CheckState.Checked Then
            datalistado.Columns.Item("Eliminar").Visible = True
        Else
            datalistado.Columns.Item("Eliminar").Visible = False
        End If
    End Sub
End Class