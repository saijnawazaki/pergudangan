Public Class product_image
    Dim now_product_id As Integer = 0
    Dim now_counter As Integer = 0
    Public Function loadParams(product, counter)
        now_product_id = product
        now_counter = counter

        Dim reader = getSoloRowData("select * from product where product_id = " & now_product_id)
        While reader.Read()
            Label1.Text = reader("product_name").ToString()
        End While

        loadData(now_product_id, now_counter)
        Return 1
    End Function
    Private Function loadData(product_id, counter)
        pb.Image = Nothing
        Label2.Text = ""
        Dim reader = getSoloRowData("select * from product_image where product_id = " & product_id & " and counter = " & counter)

        While reader.Read()
            'Debug.WriteLine(reader("file_path").ToString())
            pb.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\assets\product_image\" & reader("file_path").ToString())
            Label2.Text = reader("file_path").ToString()
        End While
        Return 1
    End Function

    Private Sub product_image_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pb.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\assets\product_image\1_1.jpg")
        'now_product_id = 1
        'now_counter = 3

        

    End Sub

    Private Sub btn_prev_Click(sender As Object, e As EventArgs) Handles btn_prev.Click
        now_counter -= 1
        loadData(now_product_id, now_counter)
    End Sub


    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        now_counter += 1
        loadData(now_product_id, now_counter)
    End Sub
End Class