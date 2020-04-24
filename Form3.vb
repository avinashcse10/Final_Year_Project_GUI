Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        PictureBox2.Image = ImageList1.Images(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboBox2.SelectedIndex = 0 Then
            PictureBox1.Image = ImageList1.Images(1)
        ElseIf ComboBox2.SelectedIndex = 1 Then
            PictureBox1.Image = ImageList1.Images(2)
        ElseIf ComboBox2.SelectedIndex = 2 Then
            PictureBox1.Image = ImageList1.Images(3)
        Else
            MsgBox("Invalid Request")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedIndex = 0 Then
            Process.Start("C:\Users\Ayan\Documents\Visual Studio 2015\Projects\start\Final Year Project\Complete AWSLGS\coil_100_with_awslgs_0d.exe")
        ElseIf ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedIndex = 1 Then
            Process.Start("C:\Users\Ayan\Documents\Visual Studio 2015\Projects\start\Final Year Project\Complete AWSLGS\coil_100_with_awslgs_45d.exe")
        ElseIf ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedIndex = 2 Then
            Process.Start("C:\Users\Ayan\Documents\Visual Studio 2015\Projects\start\Final Year Project\Complete AWSLGS\coil_100_with_awslgs_320d.exe")
        ElseIf ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 0 Then
            Process.Start("C:\Users\Ayan\Documents\Visual Studio 2015\Projects\start\Final Year Project\Complete SLGS\coil_100_output_slgs_0d.exe")
        ElseIf ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 1 Then
            Process.Start("C:\Users\Ayan\Documents\Visual Studio 2015\Projects\start\Final Year Project\Complete SLGS\coil_100_output_slgs_45d.exe")
        ElseIf ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 2 Then
            Process.Start("C:\Users\Ayan\Documents\Visual Studio 2015\Projects\start\Final Year Project\Complete SLGS\coil_100_output_slgs_320d.exe")
        ElseIf ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedIndex = 0 Then
            Process.Start("C:\Users\Ayan\Documents\Visual Studio 2015\Projects\start\Final Year Project\Complete LGS\coil_100_output_lgs_0d.exe")
        ElseIf ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedIndex = 1 Then
            Process.Start("C:\Users\Ayan\Documents\Visual Studio 2015\Projects\start\Final Year Project\Complete LGS\coil_100_output_lgs_45d.exe")
        ElseIf ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedIndex = 2 Then
            Process.Start("C:\Users\Ayan\Documents\Visual Studio 2015\Projects\start\Final Year Project\Complete LGS\coil_100_output_lgs_320d.exe")
        Else
            MsgBox("INVALID ENTRY")
        End If
    End Sub
End Class