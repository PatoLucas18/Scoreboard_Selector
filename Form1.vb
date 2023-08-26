Imports System.IO
Imports System.Runtime.InteropServices

Public Class Form1

#Region "Close and Minimize Form - Cerrar y Minimizar Formulario"
    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
    Private Sub btnMinimize_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Drag Form - Arrastrar/ mover Formulario"

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub titleBar_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles titleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

#End Region
    Dim carpeta As String
    Private Sub ListBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        Dim Indice As Integer = ListBox1.SelectedIndex
        carpeta = "Scoreboard Selector\" + ListBox1.Items.Item(Indice).ToString

        archivosafs(True)
        MsgBox("Marcador " + ListBox1.Items.Item(Indice).ToString + " Instalado")
        My.Settings.Scr = ListBox1.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Obtener todos los directorios del directorio c: ( un solo nivel )  
        For Each archivos As String In Directory.GetDirectories("Scoreboard Selector", "*.*", SearchOption.TopDirectoryOnly)
            ' extraer el nombre de la carpeta de la ruta completa  
            archivos = archivos.Substring(archivos.LastIndexOf("\") + 1).ToString
            ' Agregar el valor  
            ListBox1.Items.Add(archivos.ToString)
        Next
        If My.Settings.Scr > ListBox1.Items.Count - 1 Then
            ListBox1.SelectedIndex = 0
        Else
            ListBox1.SelectedIndex = My.Settings.Scr
        End If

    End Sub

    Private Sub archivosafs(ByVal archivosafs As Boolean)
        'MsgBox(carpeta & "\enter.txs")
        'Archivos
        's_text
        If IO.File.Exists(carpeta & "\enter.txs") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\enter.txs", Application.StartupPath & "\kitserver\Scoreboard Selector\s_text.afs\unnamed_5.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\formation.txs") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\formation.txs", Application.StartupPath & "\kitserver\Scoreboard Selector\s_text.afs\unnamed_128.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\scoreboard.txs") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\scoreboard.txs", Application.StartupPath & "\kitserver\Scoreboard Selector\s_text.afs\unnamed_151.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\screen.txs") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\screen.txs", Application.StartupPath & "\kitserver\Scoreboard Selector\s_text.afs\unnamed_152.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\result.txs") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\result.txs", Application.StartupPath & "\kitserver\Scoreboard Selector\s_text.afs\unnamed_157.bin", overwrite:=True)
        End If

        '0_text
        'Placas y marcadores
        If IO.File.Exists(carpeta & "\champions.opd") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\champions.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_212.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\champions.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_213.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\champions.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_214.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\champions.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_215.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\champions.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_216.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\champions.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_217.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\champions.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_218.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\champions.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_219.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\champions.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_220.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\champions.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_221.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\champions.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_222.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\champions.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_223.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\champions.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_224.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\champions.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_226.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\enter.opd") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\enter.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_255.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\enter.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_258.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\enter.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_259.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\enter.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_260.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\enter.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_261.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\enter.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_263.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\enter.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_264.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\enter.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_298.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\enter.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_299.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\enter.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_300.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\enter.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_301.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\enter.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_302.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\enter.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_303.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\enter.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_305.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\game2d.opd") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\game2d.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_570.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\game2d.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_571.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\game2d.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_572.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\game2d.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_573.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\game2d.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_574.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\game2d.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_576.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\game2d.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_577.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\game2d.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_578.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\game2d.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_579.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\game2d.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_580.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\game2d.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_581.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\game2d.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_582.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\game2d.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_583.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\game2d.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_585.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\scoreboard.bin") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\scoreboard.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_593.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\scoreboard.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_594.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\scoreboard.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_595.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\scoreboard.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_596.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\scoreboard.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_597.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\scoreboard.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_599.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\scoreboard.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_600.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\scoreboard.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_601.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\scoreboard.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_602.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\scoreboard.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_603.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\scoreboard.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_604.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\scoreboard.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_605.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\scoreboard.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_606.bin", overwrite:=True)
            My.Computer.FileSystem.CopyFile(carpeta & "\scoreboard.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_608.bin", overwrite:=True)
        End If
        'Escudos y Teamnames
        If IO.File.Exists(carpeta & "\teamnames.flg") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\teamnames.flg", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_535.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\emblems.flg") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\emblems.flg", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_536.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\score.fnt") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\score.fnt", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_567.bin", overwrite:=True)
        End If
        'Himno
        If IO.File.Exists(carpeta & "\Sound_enter1.adx") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\Sound_enter1.adx", Application.StartupPath & "\kitserver\Scoreboard Selector\0_sound.afs\unknow_00045.adx", overwrite:=True)
        End If
        'Himno2
        If IO.File.Exists(carpeta & "\Sound_enter2.adx") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\Sound_enter2.adx", Application.StartupPath & "\kitserver\Scoreboard Selector\0_sound.afs\unknow_00046.adx", overwrite:=True)
        End If

        'Menu
        If IO.File.Exists(carpeta & "\Sound_Menu.adx") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\Sound_Menu.adx", Application.StartupPath & "\kitserver\Scoreboard Selector\0_sound.afs\unknow_00063.adx", overwrite:=True)
        End If
        'Menu forma
        If IO.File.Exists(carpeta & "\Sound_Lineup1.adx") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\Sound_Lineup1.adx", Application.StartupPath & "\kitserver\Scoreboard Selector\0_sound.afs\unknow_00068.adx", overwrite:=True)
        End If
        'Menu forma2
        If IO.File.Exists(carpeta & "\Sound_Lineup2.adx") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\Sound_Lineup2.adx", Application.StartupPath & "\kitserver\Scoreboard Selector\0_sound.afs\unknow_00069.adx", overwrite:=True)
        End If

        'Programa de partidos
        If IO.File.Exists(carpeta & "\schedule.opd") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\schedule.opd", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_679.bin", overwrite:=True)
        End If

        'Tablero de Arbitro
        If IO.File.Exists(carpeta & "\Board_Referee.str") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\Board_Referee.str", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_83.bin", overwrite:=True)
        End If

        'Kit de arbitros
        If IO.File.Exists(carpeta & "\unnamed_431.bin") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\unnamed_431.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_431.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\unnamed_432.bin") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\unnamed_432.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_432.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\unnamed_433.bin") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\unnamed_433.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_433.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\unnamed_434.bin") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\unnamed_434.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_434.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\unnamed_435.bin") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\unnamed_435.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_435.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\unnamed_436.bin") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\unnamed_436.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_436.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\unnamed_437.bin") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\unnamed_437.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_437.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\unnamed_438.bin") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\unnamed_438.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_438.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\unnamed_439.bin") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\unnamed_439.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_439.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\unnamed_440.bin") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\unnamed_440.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_440.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\unnamed_441.bin") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\unnamed_441.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_441.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\unnamed_442.bin") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\unnamed_442.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_442.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\unnamed_443.bin") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\unnamed_443.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_443.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\unnamed_444.bin") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\unnamed_444.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_444.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\unnamed_445.bin") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\unnamed_445.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_445.bin", overwrite:=True)
        End If
        If IO.File.Exists(carpeta & "\unnamed_446.bin") Then
            My.Computer.FileSystem.CopyFile(carpeta & "\unnamed_446.bin", Application.StartupPath & "\kitserver\Scoreboard Selector\0_text.afs\unnamed_446.bin", overwrite:=True)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim Indice As Integer = ListBox1.SelectedIndex
        'MsgBox(ListBox1.Items.Item(Indice).ToString)
        If IO.File.Exists("Scoreboard Selector\" + ListBox1.Items.Item(Indice).ToString + "\Preview.png") Then
            PictureBox1.Image = Image.FromFile("Scoreboard Selector\" + ListBox1.Items.Item(Indice).ToString + "\Preview.png")
        End If

        If IO.File.Exists("Scoreboard Selector\" + ListBox1.Items.Item(Indice).ToString + "\Credits.txt") Then
            Dim fs As New FileStream("Scoreboard Selector\" + ListBox1.Items.Item(Indice).ToString + "\Credits.txt", FileMode.Open)
            Dim br As New StreamReader(fs)
            TextBox1.Text = br.ReadToEnd()
            br.Close()
            fs.Close()
        End If

    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        
        ' Ruta de la carpeta principal que contiene los archivos
        Dim folderPath As String = Application.StartupPath & "\kitserver\Scoreboard Selector"

        ' Elimina todos los archivos en la carpeta y sus subcarpetas
        If Directory.Exists(folderPath) Then
            Directory.Delete(folderPath, True)
            MsgBox("Desinstalación exitosa. Archivos eliminados correctamente.")
        Else
            'MsgBox("La carpeta no existe.")
        End If

    End Sub
End Class
