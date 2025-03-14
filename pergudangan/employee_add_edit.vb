Public Class employee_add_edit

    Dim now_product_id As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If now_product_id = 0 Then
            Dim final_product_id = getSoloData("select max(employee_id) as last_id from employee")
            'MsgBox(final_product_id)

            final_product_id += 1
            getExecute("INSERT INTO employee (employee_id,employee_name) VALUES (" & final_product_id & ", '" & TextBox1.Text & "')")

            MsgBox("Saved", MsgBoxStyle.Information)

        Else
            getExecute("UPDATE employee SET employee_name = '" & TextBox1.Text & "' WHERE employee_id = " & now_product_id)

            MsgBox("Updated", MsgBoxStyle.Information)
        End If

        employee.loadZX()
        Me.Close()

    End Sub

    Public Function loadParams(product_id)
        now_product_id = product_id
        If now_product_id > 0 Then
            TextBox1.Text = getSoloData("select employee_name from employee where employee_id = " & now_product_id)
        End If
        Return 1
    End Function
End Class