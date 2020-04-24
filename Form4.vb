Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboBox1.SelectedIndex = 0 Then
            PictureBox1.Image = ImageList1.Images(0)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            PictureBox1.Image = ImageList1.Images(1)
        ElseIf ComboBox1.SelectedIndex = 2 Then
            PictureBox1.Image = ImageList1.Images(2)
        ElseIf ComboBox1.SelectedIndex = 3 Then
            PictureBox1.Image = ImageList1.Images(3)
        ElseIf ComboBox1.SelectedIndex = 4 Then
            PictureBox1.Image = ImageList1.Images(4)
        ElseIf ComboBox1.SelectedIndex = 5 Then
            PictureBox1.Image = ImageList1.Images(5)
        Else
            MsgBox("INVALID SELECTION FROM IMAGE")
        End If
        If ComboBox2.SelectedIndex = 0 Then
            PictureBox2.Image = ImageList1.Images(6)
        ElseIf ComboBox2.SelectedIndex = 1 Then
            PictureBox2.Image = ImageList1.Images(7)
        ElseIf ComboBox2.SelectedIndex = 2 Then
            PictureBox2.Image = ImageList1.Images(8)
        Else
            MsgBox("INVALID SELECTION FROM PATTERN")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedIndex = 0 Then
            Process.Start("C:\Users\Ayan\Documents\Final Year Project\Face Localization\Output\face_image1_pattern1.exe")
        ElseIf ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedIndex = 1 Then
            MsgBox("PLEASE SELECT ANOTHER IMAGE OR PATTERN, PATTERN IS NOT IN THE IMAGE")
        ElseIf ComboBox1.SelectedIndex = 0 And ComboBox2.SelectedIndex = 2 Then
            MsgBox("PLEASE SELECT ANOTHER IMAGE OR PATTERN, PATTERN IS NOT IN THE IMAGE")
        ElseIf ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 0 Then
            Process.Start("C:\Users\Ayan\Documents\Final Year Project\Face Localization\Output\face_image2_pattern1.exe")
        ElseIf ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 1 Then
            Process.Start("C:\Users\Ayan\Documents\Final Year Project\Face Localization\Output\face_image2_pattern2.exe")
        ElseIf ComboBox1.SelectedIndex = 1 And ComboBox2.SelectedIndex = 2 Then
            MsgBox("PLEASE SELECT ANOTHER IMAGE OR PATTERN, PATTERN IS NOT IN THE IMAGE")
        ElseIf ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedIndex = 0 Then
            MsgBox("PLEASE SELECT ANOTHER IMAGE OR PATTERN, PATTERN IS NOT IN THE IMAGE")
        ElseIf ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedIndex = 1 Then
            Process.Start("C:\Users\Ayan\Documents\Final Year Project\Face Localization\Output\face_image3_pattern2.exe")
        ElseIf ComboBox1.SelectedIndex = 2 And ComboBox2.SelectedIndex = 2 Then
            MsgBox("PLEASE SELECT ANOTHER IMAGE OR PATTERN, PATTERN IS NOT IN THE IMAGE")
        ElseIf ComboBox1.SelectedIndex = 3 And ComboBox2.SelectedIndex = 0 Then
            Process.Start("C:\Users\Ayan\Documents\Final Year Project\Facee Localization\Output\face_image4_pattern1.exe")
        ElseIf ComboBox1.SelectedIndex = 3 And ComboBox2.SelectedIndex = 1 Then
            Process.Start("C:\Users\Ayan\Documents\Final Year Project\Face Localization\Output\face_image4_pattern2.exe")
        ElseIf ComboBox1.SelectedIndex = 3 And ComboBox2.SelectedIndex = 2 Then
            MsgBox("PLEASE SELECT ANOTHER IMAGE OR PATTERN, PATTERN IS NOT IN THE IMAGE")
        ElseIf ComboBox1.SelectedIndex = 4 And ComboBox2.SelectedIndex = 0 Then
            MsgBox("PLEASE SELECT ANOTHER IMAGE OR PATTERN, PATTERN IS NOT IN THE IMAGE")
        ElseIf ComboBox1.SelectedIndex = 4 And ComboBox2.SelectedIndex = 1 Then
            MsgBox("PLEASE SELECT ANOTHER IMAGE OR PATTERN, PATTERN IS NOT IN THE IMAGE")
        ElseIf ComboBox1.SelectedIndex = 4 And ComboBox2.SelectedIndex = 3 Then
            Process.Start("C:\Users\Ayan\Documents\Final Year Project\Face Localization\Output\face_image5_pattern3.exe")
        ElseIf ComboBox1.SelectedIndex = 5 And ComboBox2.SelectedIndex = 0 Then
            MsgBox("PLEASE SELECT ANOTHER IMAGE OR PATTERN, PATTERN IS NOT IN THE IMAGE")
        ElseIf ComboBox1.SelectedIndex = 5 And ComboBox2.SelectedIndex = 1 Then
            MsgBox("PLEASE SELECT ANOTHER IMAGE OR PATTERN, PATTERN IS NOT IN THE IMAGE")
        ElseIf ComboBox1.SelectedIndex = 5 And ComboBox2.SelectedIndex = 2 Then
            Process.Start("C:\Users\Ayan\Documents\Final Year Project\Face Localization\Output\face_image6_pattern3.exe")
        Else
            MsgBox("INVALID SELECTION")
        End If
    End Sub
End Class