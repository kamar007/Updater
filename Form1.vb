Public Class Aktualizator

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Updater()


        
        Try
            Dim File As String = "version.txt"
            Dim MyVer As String = My.Computer.FileSystem.ReadAllText(File)
            Dim File1 As String = "Terraria Launcher by KaMaR.exe"
            Dim File2 As String = "nowaver.txt"

            My.Computer.Network.DownloadFile("http://t-mody.tk/program/version.txt", File2)
            Dim LastVer As String = My.Computer.FileSystem.ReadAllText(File2)
            If Not MyVer = LastVer Then
                MsgBox("Aktualizacja Dostępna, czekaj...")
                ProgressBar1.Value = 0
                ProgressBar1.Value = 1
                ProgressBar1.Value = 2
                ProgressBar1.Value = 3
                If My.Computer.FileSystem.FileExists(File1) Then
                    ProgressBar1.Value = 4
                    ProgressBar1.Value = 5
                    ProgressBar1.Value = 6
                    ProgressBar1.Value = 7
                    ProgressBar1.Value = 8
                    My.Computer.FileSystem.DeleteFile(File1)
                    ProgressBar1.Value = 9
                    ProgressBar1.Value = 10
                    ProgressBar1.Value = 11
                    ProgressBar1.Value = 12
                    ProgressBar1.Value = 13
                End If
                ProgressBar1.Value = 14
                My.Computer.Network.DownloadFile("http://t-mody.tk/program/Terraria Launcher by KaMaR.exe", "Terraria Launcher by KaMaR.exe")
                ProgressBar1.Value = 15
                ProgressBar1.Value = 16
                ProgressBar1.Value = 17
                ProgressBar1.Value = 18
                ProgressBar1.Value = 19
                If My.Computer.FileSystem.FileExists(File) Then
                    ProgressBar1.Value = 21
                    ProgressBar1.Value = 22
                    ProgressBar1.Value = 23
                    ProgressBar1.Value = 24
                    ProgressBar1.Value = 25
                    My.Computer.FileSystem.DeleteFile(File)
                    ProgressBar1.Value = 26
                    ProgressBar1.Value = 28
                    ProgressBar1.Value = 30
                    ProgressBar1.Value = 32
                    ProgressBar1.Value = 34
                    ProgressBar1.Value = 36
                    ProgressBar1.Value = 38
                    ProgressBar1.Value = 40
                    ProgressBar1.Value = 42
                    ProgressBar1.Value = 46
                    ProgressBar1.Value = 48
                End If
                ProgressBar1.Value = 50
                My.Computer.Network.DownloadFile("http://t-mody.tk/program/version.txt", "version.txt")
                ProgressBar1.Value = 51
                ProgressBar1.Value = 52
                ProgressBar1.Value = 53
                ProgressBar1.Value = 55
                ProgressBar1.Value = 57
                ProgressBar1.Value = 59
                ProgressBar1.Value = 61
                ProgressBar1.Value = 62
                ProgressBar1.Value = 63
                If My.Computer.FileSystem.FileExists(File2) Then
                    ProgressBar1.Value = 65
                    ProgressBar1.Value = 70
                    ProgressBar1.Value = 74
                    ProgressBar1.Value = 78
                    ProgressBar1.Value = 80
                    ProgressBar1.Value = 83
                    My.Computer.FileSystem.DeleteFile(File2)
                    ProgressBar1.Value = 85
                    ProgressBar1.Value = 86
                    ProgressBar1.Value = 87
                    ProgressBar1.Value = 88
                    ProgressBar1.Value = 89
                End If
                ProgressBar1.Value = 90
                ProgressBar1.Value = 91
                ProgressBar1.Value = 92
                ProgressBar1.Value = 93
                ProgressBar1.Value = 94
                ProgressBar1.Value = 95
                ProgressBar1.Value = 96
                ProgressBar1.Value = 97
                ProgressBar1.Value = 98
                ProgressBar1.Value = 99
                ProgressBar1.Value = 100
                MsgBox("Została Pobrana Nowa Wersja Launchera, nowa wersja zostanie teraz uruchomiona")
                Shell("Terraria Launcher by KaMaR.exe")

            Else
                MsgBox("Posiadasz najnowszą wersję programu")
                If My.Computer.FileSystem.FileExists(File2) Then
                    My.Computer.FileSystem.DeleteFile(File2)
                End If
                Shell("Terraria Launcher by KaMaR.exe")
            End If
        Catch
            MsgBox("Błąd Podczas Łączenia Z Serwerem")
        End Try
        End
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Updater()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Shell("Terraria Launcher by KaMaR.exe")
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

End Class
