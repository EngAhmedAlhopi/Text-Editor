Public Class Form1
    Dim txtname As String
    Dim don As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Do
            Me.Show()
            txtname = InputBox("ادخل اسم الملف")
            Me.Text = txtname & "-محرر النصوص"
            RichTextBox1.Text = "اهلا وسهلا بكم في محرر النصوص."
        Loop While (txtname = "")
    End Sub

    Private Sub جديدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles جديدToolStripMenuItem.Click
        Do While (don = False)
            Dim save As New SaveFileDialog
            Try
                save.FileName = txtname
                save.Filter = "TXT|*.txt | Ah|*.ah"
                If save.ShowDialog = DialogResult.OK Then
                    RichTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText)
                    don = True
                End If
            Catch ex As Exception
                MessageBox.Show("Error" & Environment.NewLine & ex.ToString)
            End Try
        Loop
        If don = True Then
            Me.Show()
            txtname = InputBox("ادخل اسم الملف الجديد")
            Me.Text = txtname & "-محرر النصوص"
            RichTextBox1.Text = "اهلا وسهلا بكم في محرر النصوص."
        End If
    End Sub

    Private Sub فتحToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles فتحToolStripMenuItem.Click
        Dim open As OpenFileDialog = New OpenFileDialog()
        If open.ShowDialog() = DialogResult.OK Then
            RichTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.PlainText)
            Me.Text = open.FileName
        End If
    End Sub

    Private Sub حفظباسمToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حفظباسمToolStripMenuItem.Click
        Dim save As New SaveFileDialog
        Try
            save.FileName = txtname
            save.Filter = "TXT|*.txt |Ah|*.ah"
            If save.ShowDialog = DialogResult.OK Then
                RichTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText)
                don = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error" & Environment.NewLine & ex.ToString)
        End Try
    End Sub

    Private Sub قصToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles قصToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub نسخToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles نسخToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub لصقToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles لصقToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub مناليمينالىاليسارToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles مناليمينالىاليسارToolStripMenuItem.Click
        RichTextBox1.Text = HorizontalAlignment.Left
    End Sub

    Private Sub فيالمنتصفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles فيالمنتصفToolStripMenuItem.Click
        RichTextBox1.Text = HorizontalAlignment.Center
    End Sub

    Private Sub مناليسارالىاليمينToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles مناليسارالىاليمينToolStripMenuItem.Click
        RichTextBox1.Text = HorizontalAlignment.Right
    End Sub

    Private Sub تنسيقالخطToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تنسيقالخطToolStripMenuItem.Click
        Try
            Dim dlg As FontDialog = New FontDialog
            dlg.Font = RichTextBox1.Font
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.Font = dlg.Font
            End If
        Catch ex As Exception
            MessageBox.Show("Error" & Environment.NewLine & ex.ToString)
        End Try

    End Sub

    Private Sub الوضعالطبيعيToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الوضعالطبيعيToolStripMenuItem.Click
        MenuStrip1.BackColor = Color.LightGray
        MenuStrip1.ForeColor = Color.Black
        RichTextBox1.BackColor = Color.White
        RichTextBox1.ForeColor = Color.Black
    End Sub

    Private Sub الوضعالليليToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الوضعالليليToolStripMenuItem.Click
        MenuStrip1.BackColor = Color.DimGray
        MenuStrip1.ForeColor = Color.Silver
        RichTextBox1.BackColor = Color.DarkGray
        RichTextBox1.ForeColor = Color.White
    End Sub

    Private Sub اللونالازرقToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اللونالازرقToolStripMenuItem.Click
        MenuStrip1.BackColor = Color.DimGray
        MenuStrip1.ForeColor = Color.White
        RichTextBox1.BackColor = Color.CornflowerBlue
        RichTextBox1.ForeColor = Color.White
    End Sub

    Private Sub اللونالرماديToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اللونالرماديToolStripMenuItem.Click
        MenuStrip1.BackColor = Color.DimGray
        MenuStrip1.ForeColor = Color.Silver
        RichTextBox1.BackColor = Color.Silver
        RichTextBox1.ForeColor = Color.Black
    End Sub

    Private Sub اللونالبنيToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اللونالبنيToolStripMenuItem.Click
        MenuStrip1.BackColor = Color.DimGray
        MenuStrip1.ForeColor = Color.Silver
        RichTextBox1.BackColor = Color.Chocolate
        RichTextBox1.ForeColor = Color.White
    End Sub

    Private Sub حولالبرنامجToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حولالبرنامجToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub مننحنToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles مننحنToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub فيسبوكToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles فيسبوكToolStripMenuItem.Click
        Process.Start("https://www.facebook.com/ahmed.hopi/")
    End Sub

    Private Sub تيلجرامToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تيلجرامToolStripMenuItem.Click
        Process.Start("https://t.me/Eng_Ahmed_alhopi")
    End Sub

    Private Sub واتسابToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles واتسابToolStripMenuItem.Click
        Process.Start("https://iwtsp.com/970595421229")
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If don = False Then
            Dim save As New SaveFileDialog
            Do
                Try
                    save.FileName = txtname
                    save.Filter = "TXT|*.txt | Ah|*.ah"
                    If save.ShowDialog = DialogResult.OK Then
                        RichTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText)
                        don = True
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error" & Environment.NewLine & ex.ToString)
                End Try
            Loop While (don = False)
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        don = False
    End Sub

End Class
