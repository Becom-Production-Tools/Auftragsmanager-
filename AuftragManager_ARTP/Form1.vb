Imports System
Imports System.IO
Imports System.Diagnostics
Imports System.Text
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Xml

Public Class Form1

    Dim ARTP_daten = New Dictionary(Of String, Integer)
    Dim ARTP_index = New Dictionary(Of String, String)
    Dim ARTP_ZKWA = New Dictionary(Of String, String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Console.WriteLine("STAR")

        Dim names() As String '= Split(ConfigurationSettings.AppSettings("names"), ",")
        Dim datas() As String '= Split(ConfigurationSettings.AppSettings("datas"), ",")
        Dim i As Integer

        Dim m_xmlr As XmlTextReader
        m_xmlr = New XmlTextReader("baugruppen.xml")
        m_xmlr.WhitespaceHandling = WhitespaceHandling.None
        m_xmlr.Read()
        m_xmlr.Read()
        While Not m_xmlr.EOF
            m_xmlr.Read()
            If Not m_xmlr.IsStartElement() Then
                Exit While
            End If
            Dim bg_name = m_xmlr.GetAttribute("bg")
            m_xmlr.Read()
            Dim daten = m_xmlr.ReadElementString("daten")
            Dim index = m_xmlr.ReadElementString("index")
            Dim zkwa = m_xmlr.ReadElementString("zkwa")
            'Console.WriteLine("BG: " & bg_name _
            '  & " daten: " & daten & " index: " _
            '  & index)
            'Console.Write(vbCrLf)
            ARTP_daten.Add(bg_name, daten)
            ARTP_index.Add(bg_name, index)
            ARTP_ZKWA.Add(bg_name, zkwa)
            i = i + 1
        End While
        m_xmlr.Close()

        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 12)
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 12)

        DataGridView1.Width = Me.Width - 5
        DataGridView1.Height = Me.Height - 130

        Timer1.Start()

        path_in.Text = ConfigurationSettings.AppSettings("pathin")


        'For Each ARTP_part As String In ARTP

        'Console.WriteLine(ARTP_part)
        'Console.Write(vbCrLf)

        'Next
        Me.Refresh()
        readfiles(ConfigurationSettings.AppSettings("pathin"))

    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged

        Dim selectedrow As Integer
        Dim maxrows As Integer
        Dim i As Integer

        Try
            selectedrow = DataGridView1.CurrentCell.RowIndex
            maxrows = DataGridView1.RowCount

            'Console.WriteLine("-------------")
            'Console.WriteLine(selectedrow)
            'Console.WriteLine(DataGridView1.Rows(selectedrow).DefaultCellStyle.BackColor)

            If (DataGridView1.Rows(selectedrow).DefaultCellStyle.BackColor = Color.White) Then
                movedeletebutton.Enabled = True
            Else
                movedeletebutton.Enabled = False
            End If

        Catch

        Finally


            selectedprimerauftrag.Text = ""
            'selectedsecunderauftrag.Text = ""

            selectedprimerauftrag.BackColor = SystemColors.Control
            'selectedsecunderauftrag.BackColor = SystemColors.Control

            selected.Text = ""

            If selectedrow < (maxrows - 1) Then

                Dim primerauftrag As String = DataGridView1.Rows(selectedrow).Cells(0).Value
                Dim secunderauftrag As String = primerauftrag.Substring(4, Len(primerauftrag) - 4)

                If primerauftrag.Substring(0, 4) = "5180" Then
                    secunderauftrag = "4500" + secunderauftrag
                End If

                If primerauftrag.Substring(0, 4) = "4500" Then
                    secunderauftrag = "5180" + secunderauftrag
                End If

                selectedprimerauftrag.Text = primerauftrag

                For i = 0 To maxrows - 2

                    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.White

                    If DataGridView1.Rows(i).Cells(0).Value = secunderauftrag Then
                        'DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                    End If

                    If DataGridView1.Rows(i).Cells(4).Value <> "N" Then
                        DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Crimson
                    Else
                        If i = selectedrow Then
                            'DataGridView1.Rows(selectedrow).DefaultCellStyle.BackColor = Color.LightGreen
                        End If
                    End If

                    'Prüfung Datenmenge
                    'Try
                    '    If ARTP_daten(Trim(DataGridView1.Rows(i).Cells(2).Value)) <> DataGridView1.Rows(i).Cells(5).Value Then
                    '        DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    '    End If
                    'Catch
                    '    DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Blue
                    'End Try

                    'Prüfung Index
                    Try
                        If ARTP_index(Trim(DataGridView1.Rows(i).Cells(2).Value)) <> DataGridView1.Rows(i).Cells(6).Value Then
                            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.DarkViolet
                        End If
                    Catch
                        DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Blue
                    End Try

                    'Prüfung Artikelnummer
                    Try
                        If ARTP_ZKWA(Trim(DataGridView1.Rows(i).Cells(2).Value)) <> DataGridView1.Rows(i).Cells(7).Value Then
                            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Pink
                        End If
                    Catch
                        DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Blue

                    End Try
                Next

                Try
                    If (DataGridView1.Rows(selectedrow).Cells(4).Value = "N") And
                        (ARTP_daten(Trim(DataGridView1.Rows(selectedrow).Cells(2).Value)) = DataGridView1.Rows(selectedrow).Cells(5).Value) And
                        (ARTP_index(Trim(DataGridView1.Rows(selectedrow).Cells(2).Value)) = DataGridView1.Rows(selectedrow).Cells(6).Value) Then

                        'movedeletebutton.Enabled = True

                        If File.Exists(ConfigurationSettings.AppSettings("pathin") + "\" + secunderauftrag) Then
                            'selectedsecunderauftrag.Text = secunderauftrag
                            selectedprimerauftrag.BackColor = Color.LightGreen

                            'selectedsecunderauftrag.BackColor = Color.LightGreen
                        End If

                    End If
                Catch

                End Try

                If DataGridView1.Rows(selectedrow).Cells(4).Value = "J" Then
                    Delete.Enabled = True
                End If

            End If

        End Try

    End Sub
    Private Sub movedeletebutton_Click(sender As Object, e As EventArgs) Handles movedeletebutton.Click

        If selected.Text = "ENGMATEC 1" Then

            File.Copy(ConfigurationSettings.AppSettings("pathin") + "\" + selectedprimerauftrag.Text, ConfigurationSettings.AppSettings("pathouttrash") + "\" + selectedprimerauftrag.Text, True)
            File.Move(ConfigurationSettings.AppSettings("pathin") + "\" + selectedprimerauftrag.Text, ConfigurationSettings.AppSettings("pathout1") + selectedprimerauftrag.Text)

            'If selectedsecunderauftrag.Text <> "" Then
            'File.Copy(ConfigurationSettings.AppSettings("pathin") + "\" + selectedsecunderauftrag.Text, ConfigurationSettings.AppSettings("pathouttrash") + "\" + selectedsecunderauftrag.Text, True)
            'File.Delete(ConfigurationSettings.AppSettings("pathin") + "\" + selectedsecunderauftrag.Text)
            'End If
        End If

        If selected.Text = "ENGMATEC 2" Then

            File.Copy(ConfigurationSettings.AppSettings("pathin") + "\" + selectedprimerauftrag.Text, ConfigurationSettings.AppSettings("pathouttrash") + "\" + selectedprimerauftrag.Text, True)
            File.Move(ConfigurationSettings.AppSettings("pathin") + "\" + selectedprimerauftrag.Text, ConfigurationSettings.AppSettings("pathout2") + selectedprimerauftrag.Text)

            'If selectedsecunderauftrag.Text <> "" Then
            'File.Copy(ConfigurationSettings.AppSettings("pathin") + "\" + selectedsecunderauftrag.Text, ConfigurationSettings.AppSettings("pathouttrash") + "\" + selectedsecunderauftrag.Text, True)
            'File.Delete(ConfigurationSettings.AppSettings("pathin") + "\" + selectedsecunderauftrag.Text)
            'End If
        End If

        If selected.Text = "ENGMATEC 3" Then

            File.Copy(ConfigurationSettings.AppSettings("pathin") + "\" + selectedprimerauftrag.Text, ConfigurationSettings.AppSettings("pathouttrash") + "\" + selectedprimerauftrag.Text, True)
            File.Move(ConfigurationSettings.AppSettings("pathin") + "\" + selectedprimerauftrag.Text, ConfigurationSettings.AppSettings("pathout3") + selectedprimerauftrag.Text)

            'If selectedsecunderauftrag.Text <> "" Then
            'File.Copy(ConfigurationSettings.AppSettings("pathin") + "\" + selectedsecunderauftrag.Text, ConfigurationSettings.AppSettings("pathouttrash") + "\" + selectedsecunderauftrag.Text, True)
            'File.Delete(ConfigurationSettings.AppSettings("pathin") + "\" + selectedsecunderauftrag.Text)
            'End If
        End If

        readfiles(ConfigurationSettings.AppSettings("pathin"))

    End Sub
    Private Sub newfile()

        'readfiles(ConfigurationSettings.AppSettings("pathin"))
        'Reload.Enabled = True
        MsgBox("New")
        readfiles(ConfigurationSettings.AppSettings("pathin"))

    End Sub
    Private Sub readfiles(pathin As String)

        Dim txtFiles = Directory.GetFiles(pathin, ConfigurationSettings.AppSettings("filefilter") + ".txt", SearchOption.TopDirectoryOnly).
       [Select](Function(nm) Path.GetFileName(nm))

        Dim arrayList As New System.Collections.ArrayList()
        Dim i As Integer

        DataGridView1.Rows.Clear()

        For Each filenm As String In txtFiles

            Dim path As String = pathin & "\" & filenm
            Dim readText As String = File.ReadAllText(path, System.Text.Encoding.Default)
            Dim temparray() As String = Split(readText, ";")
            Dim aktiv As String = temparray(17).Substring(0, 1)
            Dim index As String = "--"
            Dim ZKWA As String = "-"

            Dim index_pos As Integer = Array.FindIndex(temparray, Function(s) s = ConfigurationSettings.AppSettings("indextext2"))

            If index_pos < 0 Then
                index_pos = Array.FindIndex(temparray, Function(s) s = ConfigurationSettings.AppSettings("indextext1"))
            End If

            If index_pos > 0 Then
                index = temparray(index_pos + 1).Trim()
            End If

            Dim ZKWA_pos As Integer = Array.FindIndex(temparray, Function(s) s = ConfigurationSettings.AppSettings("indextext3"))

            If ZKWA_pos > 0 Then
                ZKWA = temparray(ZKWA_pos + 1).Trim()
            End If

            If aktiv = "N" Then
                DataGridView1.Rows.Add(filenm, temparray(2), temparray(6), temparray(9).Substring(0, temparray(9).IndexOf(",")), aktiv, temparray.Length, index, ZKWA)
                DataGridView1.Rows(DataGridView1.RowCount - 1).DefaultCellStyle.BackColor = Color.Red
            End If

            If aktiv = "J" Then
                File.Delete(path) ' , ConfigurationSettings.AppSettings("pathout3") + "\" + selectedprimerauftrag.Text)
            End If

        Next

        Me.Refresh()
        DataGridView1.Sort(DataGridView1.Columns(2), ListSortDirection.Ascending)
        DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(0)
        DataGridView1_SelectionChanged(DataGridView1, EventArgs.Empty)

        For i = 0 To DataGridView1.RowCount - 1
            DataGridView1.Rows(i).MinimumHeight = 50
        Next

    End Sub
    Private Sub Reload_Click(sender As Object, e As EventArgs) Handles reload.Click
        readfiles(ConfigurationSettings.AppSettings("pathin"))
    End Sub
    Private Sub FileSystemWatcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileSystemWatcher1.Path = ConfigurationSettings.AppSettings("pathin")
        AddHandler FileSystemWatcher1.Created, AddressOf OnCreated
    End Sub
    Private Sub OnCreated(sender As Object, e As IO.FileSystemEventArgs)
        ' print some info about the file that is created
        readfiles(ConfigurationSettings.AppSettings("pathin"))
    End Sub
    Private Sub selectedprimerauftrag_DoubleClick(sender As Object, e As EventArgs) Handles selectedprimerauftrag.DoubleClick
        Process.Start(ConfigurationSettings.AppSettings("pathin") + "\" + selectedprimerauftrag.Text)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If My.Computer.Keyboard.AltKeyDown = True And My.Computer.Keyboard.CtrlKeyDown = True Then
                Delete.Enabled = True
            ElseIf My.Computer.Keyboard.AltKeyDown = False And My.Computer.Keyboard.CtrlKeyDown = False Then
                Delete.Enabled = False
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        Me.Close()
    End Sub
    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim result As Integer = MessageBox.Show("Delete?", "", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            File.Copy(ConfigurationSettings.AppSettings("pathin") + "\" + selectedprimerauftrag.Text, ConfigurationSettings.AppSettings("pathouttrash") + "\" + selectedprimerauftrag.Text, True)
            File.Delete(ConfigurationSettings.AppSettings("pathin") + "\" + selectedprimerauftrag.Text)
            readfiles(ConfigurationSettings.AppSettings("pathin"))
        End If

    End Sub
    Private Sub path_in_Click(sender As Object, e As EventArgs) Handles path_in.Click
        Process.Start(path_in.Text)
    End Sub
    Private Sub ENG1_Click(sender As Object, e As EventArgs) Handles ENG1.Click
        selected.Text = ENG1.Text
        'movedeletebutton.Enabled = True
    End Sub
    Private Sub ENG2_Click(sender As Object, e As EventArgs) Handles ENG2.Click
        selected.Text = ENG2.Text
        'movedeletebutton.Enabled = True
    End Sub
    Private Sub ENG3_Click(sender As Object, e As EventArgs) Handles ENG3.Click
        selected.Text = ENG3.Text
        'movedeletebutton.Enabled = True
    End Sub
    Private Sub bBGconfig_Click(sender As Object, e As EventArgs) Handles bBGconfig.Click
        Process.Start(Application.StartupPath & "\baugruppen.xml")
    End Sub
    Private Sub bTrash_Click(sender As Object, e As EventArgs) Handles bTrash.Click
        Process.Start(ConfigurationSettings.AppSettings("pathouttrash"))
    End Sub
End Class

