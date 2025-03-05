Public Class product_add_edit
    Dim now_product_id As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If now_product_id = 0 Then
            Dim final_product_id = getSoloData("select max(product_id) as last_id from product")
            'MsgBox(final_product_id)

            final_product_id += 1
            getExecute("INSERT INTO product (product_id,product_name) VALUES (" & final_product_id & ", '" & TextBox1.Text & "')")

            MsgBox("Saved", MsgBoxStyle.Information)
            
        Else
            getExecute("UPDATE product SET product_name = '" & TextBox1.Text & "' WHERE product_id = " & now_product_id)

            MsgBox("Updated", MsgBoxStyle.Information)
        End If

        product.load()
        Me.Close()

    End Sub

    Public Function loadParams(product_id)
        now_product_id = product_id
        If now_product_id > 0 Then
            TextBox1.Text = getSoloData("select product_name from product where product_id = " & now_product_id)
        End If
    End Function
End Class