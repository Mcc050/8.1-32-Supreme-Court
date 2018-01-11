Public Class frmJustices

    Private Sub btnCLick_Click(sender As Object, e As EventArgs) Handles btnCLick.Click
        Dim skip() As String = IO.File.ReadAllLines("skippy.txt")

                   
        Dim query = From line In IO.File.ReadAllLines("justices.txt")
                    Let data = line.Split(","c)
                    Let year = data(4)
                    Select year






        
        IO.File.WriteAllLines("Newfile.txt", skip.Except(query))





    End Sub
End Class
