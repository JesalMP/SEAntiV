Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Public Class Form1

    Function md5_hash(ByVal file_name As String)
        Return hash_generator("md5", file_name)
    End Function

    Function hash_generator(ByRef hash_type As String, ByRef file_name As String)

        Dim hash
        hash = MD5.Create

        Dim hashValue() As Byte

        Dim filestream As FileStream = File.OpenRead(file_name)
        filestream.Position = 0
        hashValue = hash.ComputeHash(filestream)
        Dim hash_hex = PrintByteArray(hashValue)

        filestream.Close()

        Return hash_hex
    End Function

    Public Function PrintByteArray(ByRef array() As Byte)

        Dim hex_value As String = ""

        Dim i As Integer
        For i = 0 To array.Length - 1

            hex_value += array(i).ToString("x2")
        Next i

        Return hex_value.ToLower
    End Function

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            txtFilePath.Text = path

            Dim sample As String
            sample = md5_hash(path)
            txtHash.Text = md5_hash(path)

            Using f As System.IO.FileStream = System.IO.File.OpenRead("C:\bhedak project\Tutorial\Tutorial\Tutorial\bin\Debug\md5.txt")
                Using s As System.IO.StreamReader = New System.IO.StreamReader(f)
                    While Not s.EndOfStream
                        Dim line As String = s.ReadLine

                        If (line = sample) Then
                            lblResult.Text = "Infected!"
                            lblResult.ForeColor = Color.Red
                            Dim result As DialogResult = MessageBox.Show("Should we Delete The Threat Found?", "Virus Found", MessageBoxButtons.YesNoCancel)
                            If result = DialogResult.Cancel Then
                                MessageBox.Show("Cancel pressed, skipping further operations")
                            ElseIf result = DialogResult.No Then
                                MessageBox.Show("No pressed, We have added this file for False-Positive")
                            ElseIf result = DialogResult.Yes Then
                                MessageBox.Show("Yes pressed, Threat Has Been Terminated")
                                FileSystem.Kill(path)
                            End If
                        Else
                            lblResult.Text = "Clean!"
                            lblResult.ForeColor = Color.Green
                        End If
                    End While
                End Using
            End Using
        End If
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub txtHash_TextChanged(sender As Object, e As EventArgs) Handles txtHash.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
