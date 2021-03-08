Public Class Form1
    'binario ad altre basi
    Private Sub bin_txt_TextChanged(sender As Object, e As EventArgs) Handles bin_txt.TextChanged
        If bin_txt.Focused = True Then
            If bin_txt.Text IsNot "" Then
                Try
                    'decimale
                    Dim toDecimal As Integer = Convert.ToInt32(bin_txt.Text, 2)
                    dec_txt.Text = toDecimal
                    'ottale
                    oct_txt.Text = System.Convert.ToString(toDecimal, 8)
                    'esadecimale
                    hex_txt.Text = UCase(System.Convert.ToString(toDecimal, 16))
                Catch ex As Exception
                    dec_txt.Text = "ERR"
                    oct_txt.Text = "ERR"
                    hex_txt.Text = "ERR"
                End Try
            Else
                dec_txt.Text = ""
                oct_txt.Text = ""
                hex_txt.Text = ""
            End If
        End If
    End Sub
    'ottale ad altre basi
    Private Sub oct_txt_TextChanged(sender As Object, e As EventArgs) Handles oct_txt.TextChanged
        If oct_txt.Focused = True Then
            If oct_txt.Text IsNot "" Then
                Try
                    Dim toDecimal As Integer = Convert.ToInt32(oct_txt.Text, 8)
                    'decimale
                    dec_txt.Text = toDecimal
                    'ottale
                    bin_txt.Text = System.Convert.ToString(toDecimal, 2)
                    'esadecimale
                    hex_txt.Text = UCase(System.Convert.ToString(toDecimal, 16))
                Catch ex As Exception
                    dec_txt.Text = "ERR"
                    bin_txt.Text = "ERR"
                    hex_txt.Text = "ERR"
                End Try
            Else
                dec_txt.Text = ""
                bin_txt.Text = ""
                hex_txt.Text = ""
            End If
        End If
    End Sub
    'decimale ad altre basi
    Private Sub dec_txt_TextChanged(sender As Object, e As EventArgs) Handles dec_txt.TextChanged
        If dec_txt.Focused = True Then
            If dec_txt.Text IsNot "" Then
                Try
                    Dim actualInt As Integer = dec_txt.Text
                    'binario
                    bin_txt.Text = System.Convert.ToString(actualInt, 2)
                    'ottale
                    oct_txt.Text = System.Convert.ToString(actualInt, 8)
                    'esadecimale
                    hex_txt.Text = UCase(System.Convert.ToString(actualInt, 16))
                Catch ex As Exception
                    bin_txt.Text = "ERR"
                    oct_txt.Text = "ERR"
                    hex_txt.Text = "ERR"
                End Try
            Else
                bin_txt.Text = ""
                oct_txt.Text = ""
                hex_txt.Text = ""
            End If
        End If
    End Sub
    'hex ad altre basi
    Private Sub hex_txt_TextChanged(sender As Object, e As EventArgs) Handles hex_txt.TextChanged
        If hex_txt.Focused = True Then
            If hex_txt.Text IsNot "" Then
                Try
                    'decimale
                    Dim toDecimal As Integer = Convert.ToInt32(hex_txt.Text, 16)
                    dec_txt.Text = toDecimal
                    'ottale
                    oct_txt.Text = System.Convert.ToString(toDecimal, 8)
                    'binario
                    bin_txt.Text = System.Convert.ToString(toDecimal, 2)
                Catch ex As Exception
                    dec_txt.Text = "ERR"
                    oct_txt.Text = "ERR"
                    bin_txt.Text = "ERR"
                End Try
            Else
                dec_txt.Text = ""
                oct_txt.Text = ""
                bin_txt.Text = ""
            End If
        End If
    End Sub
End Class
