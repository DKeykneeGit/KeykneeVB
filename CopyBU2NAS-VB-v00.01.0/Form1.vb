Imports System.IO

Public Class Form1

    Public Shared dteSelectedFileDte As String
    Public Shared FileWriteDateToSelect As String




    Private Sub ClearList()
        'Clear the list
        ListBox1.Items.Clear()
    End Sub


    Private Sub ClearList2()
        'Clear the list
        ListBox2.Items.Clear()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Clear the list 
        ClearList()
        ClearList2()

        '   Dim FileWriteDateToSelect As Date = #02/01/2016#
        '   Dim FileWriteDateToSelect As String
        '   Dim dteSelectedFileDte As String

        '      Read an entire file and display in a MsgBox - Just a good to know
        '   Dim fileReader As String
        '   fileReader = My.Computer.FileSystem.ReadAllText("C:\MachINFO.txt")
        '   MsgBox(fileReader)

        '      Try this sometime but needs something to display all lines Not just first
        '   Dim fileReader As System.IO.StreamReader
        '   fileReader = My.Computer.FileSystem.OpenTextFileReader("D:\MachInfoVBtestfile.txt")
        '   Dim stringReader As String
        '   stringReader = fileReader.ReadLine()
        '   MsgBox("The first line of the file is " & stringReader)

        '      Read The MachID for this machine
        Dim fileReader As String
        Dim intMachId As Short
        fileReader = My.Computer.FileSystem.ReadAllText("C:\MachINFO.txt")
        intMachId = fileReader
        '   MsgBox(intMachId)


        '      NEED TO WRITE EXCEPTION CODE FOR LINES IMMEDIATELY BELOW FOR INVALID DATE ENTERED
        '   FileWriteDateToSelect = InputBox("Enter the > or =  Date for File(s) to Select", "Enter mm/dd/yyyy", Today.ToShortDateString)
        '   Dim isValidDate As Boolean = IsDate(FileWriteDateToSelect)

        '  Below is the LONG WAY of doing essentially the same thing as the one line "FileWriteDateToSelect = InputBox" above
        '   but the following code mcy be a bit more flexible
TagRetryDate:
        Dim message, title, defaultValue As String
        '   03/31/2016 orig code used Object for this      '   Dim myValue As Object
        Dim myValue As String


        ' Set prompt.
        message = "Accept default or enter mm/dd/yyyy for > or = file date last written (modified) selection"
        ' Set title.
        title = "Select > or = date for files to be copied"
        defaultValue = Today.ToShortDateString   ' Set default value.
        '   defaultValue = #04/01/2016#  ' FORCE default value.


        ' Display message, title, and default value.
        myValue = InputBox(message, title, defaultValue)

        ' If user has clicked Cancel, set myValue to defaultValue
        '   If myValue Is "" Then myValue = defaultValue
        If myValue Is "" Then Stop


        Dim check4InValidDate As Boolean = IsDate(myValue)
        If check4InValidDate = False Then
            MsgBox(" Date entered not a valid date or incorrect format used - Please enter a valid mm/dd/yyyy including the /  /")
            GoTo TagRetryDate
        End If

        FileWriteDateToSelect = myValue

        '   If date is blank then Cancel button was pushed - So EXIT and CLOSE the Program
        If FileWriteDateToSelect = Nothing Then Stop

        Dim CurDir As String = "F:\MAI01-SSR2013-BU-C-SysBCD-and-SSD-C\"
        '   Dim CurDir As String = "F:\MAI01-SSR2013-BU-of-D\"
        '   Dim CurDir As String = "F:\MAI01-SSR2013-BU-of-E\"


        Dim OutDirRoot As String = "D:\DK-VB-Files\ZDK-VBTest\AllFilesInDir-vb\"
        Dim OutDirAllFile As String = "D:\DK-VB-Files\ZDK-VBTest\AllFilesInDir-vb\AllFilesInDirVB.txt"
        Dim OutDirSelFile As String = "D:\DK-VB-Files\ZDK-VBTest\AllFilesInDir-vb\SelectedFilesInDirVB.txt"


        Dim aRayAllFileName As New ArrayList()
        Dim aRayAllFileDate As New ArrayList()
        Dim aRayAllFileSize As New ArrayList()

        Dim aRaySelectedFileName As New ArrayList()
        Dim aRaySelectedFileDate As New ArrayList()
        Dim aRaySelectedFileSize As New ArrayList()
        Dim aRaySelectedFileNameOnly As New ArrayList

        Dim TotNbrAllFilesCurrDir As Integer = 0
        Dim TotNbrSelectedFilesCurrDir As Integer = 0
        Dim TotSizeAllFilesCurrDir As Double = 0
        Dim TotSizeSelectedFilesCurrDir As Double = 0


        Dim Writer As New System.IO.StreamWriter(OutDirAllFile)
        Dim Writer2 As New System.IO.StreamWriter(OutDirSelFile)


        '   vvvvv Below is for my future reference vvvvv
        '   How to remove an item from arrayList ?
        '   Syntax: ArrayList.Remove(item)
        '   ^^^^^ Above  is for my future reference ^^^^^


        Dim di As DirectoryInfo = New DirectoryInfo(CurDir)
        For Each fi In di.GetFiles()
            'ListBox1.Items.Add(fi.FullName & vbTab & fi.LastWriteTime.ToShortDateString & vbTab & fi.Length & vbCrLf)
            ListBox1.Items.Add(fi.FullName & vbTab & fi.LastWriteTime & vbTab & fi.Length & vbCrLf)

            aRayAllFileName.Add(fi.FullName)
            aRayAllFileDate.Add(fi.LastWriteTime.ToShortDateString)
            '   aRayAllFileDate.Add(fi.LastWriteTime)
            aRayAllFileSize.Add(fi.Length)
            TotNbrAllFilesCurrDir = TotNbrAllFilesCurrDir + 1
            TotSizeAllFilesCurrDir = TotSizeAllFilesCurrDir + fi.Length

            '   Write file info for ALL FILES in current directory to disk audit file

            '   Write file with short date 
            '   Writer.Write(fi.FullName & vbTab & fi.LastWriteTime.ToShortDateString & vbTab & fi.Length & vbCrLf)

            '   or with file Last Write date & time 
            ' Writing to AllFilesInDirVB.txt
            Writer.Write(fi.FullName & vbTab & fi.LastWriteTime & vbTab & fi.Length & vbCrLf)

            '   ClearList2()

            '   Does this file qualify for the date selection criteria? (Files last write -AKA Modified- date) >= Entered Date 
            If (fi.LastWriteTime.ToShortDateString >= FileWriteDateToSelect) Then

                '   Load selected files arrays
                aRaySelectedFileName.Add(fi.FullName)
                aRaySelectedFileNameOnly.Add(fi.Name)
                aRaySelectedFileDate.Add(fi.LastWriteTime.ToShortDateString)
                aRaySelectedFileSize.Add(fi.Length)
                TotNbrSelectedFilesCurrDir = TotNbrSelectedFilesCurrDir + 1
                TotSizeSelectedFilesCurrDir = TotSizeSelectedFilesCurrDir + fi.Length

                ListBox2.Items.Add(fi.FullName & vbTab & fi.LastWriteTime & vbTab)

                '   The MsgBox entry below for "The date to select" has embeded spaces in the front for allignment
                '   MsgBox(" The file last access date and time are " & (fi.LastWriteTime) & vbCrLf &
                '                 "                               The date to select is " & (FileWriteDateToSelect))

                '   Write file info for files "SELECTED BY LAST WRITE DATE" in current directory to disk audit file
                ' Writing to SelectedFilesInDirVB.txt
                Writer2.Write(fi.FullName & vbTab & fi.LastWriteTime.ToShortDateString & vbTab & fi.Length & vbCrLf)

            End If

            '   dteSelectedFileDte = FileWriteDateToSelect.ToShortDateString
            ' Below Stop is to debug date not displaying in Form1 Textbox control and it does stop here so dates were =
            '   If dteSelectedFileDte = myValue Then Stop

            Me.lblCurrDir.Text = CurDir
            Me.lblSelectedFileDte.Text = FileWriteDateToSelect
            txtTotNbrAllFilesCurrDir.Text = TotNbrAllFilesCurrDir.ToString("n0")
            txtTotSizeAllFilesCurrDir.Text = TotSizeAllFilesCurrDir.ToString("n0")
            txtTotNbrSelectedFilesCurrDir.Text = TotNbrSelectedFilesCurrDir.ToString("n0")
            txtTotSizeSelectedFilesCurrDir.Text = TotSizeSelectedFilesCurrDir.ToString("n0")

        Next

        Writer.Close()
        Writer2.Close()

        ' Define vars for max number of elements in each Array
        Dim AllFilesMaxElem As Integer
        Dim SelectedFilesMaxElem As Integer

        '   Find the number of elements in each array
        AllFilesMaxElem = aRayAllFileName.Count
        SelectedFilesMaxElem = aRaySelectedFileName.Count

        '   MsgBox(" AllFilesNumElem         = " & (AllFilesMaxElem) & vbCrLf &
        '                  " SelectedFilesMaxElem = " & (SelectedFilesMaxElem))


        '   File.Create("D:\DK-VB-Files\ZDK-VBTest\AllFilesInDir-vb\AllFilesInDirVB.txt")
        '   File.Create("D:\DK-VB-Files\ZDK-VBTest\AllFilesInDir-vb\SelectedFilesInDirVB.txt")


        '   End Sub

        '   COPY SELECTED FILES TO NAS


        'Stackoverflow version code in VB.Net File copy with progress bar

        Dim i As Integer

        If aRaySelectedFileName(0) = Nothing Then
            Stop
        End If


        Dim CFPositionAllSelFilesHold As Double = 0
        Dim PercentAllSelectFileDone As Integer = 0


        Dim TmpOutDir As String = " "
        TmpOutDir = "T:\VBFileCopyTestOut\"
        Dim TempFileName As String = aRaySelectedFileNameOnly(i)
        For i = 0 To SelectedFilesMaxElem - 1
            Me.lblSameAsi.Text = i + 1
            Me.lblTotFilesToCopy.Text = aRaySelectedFileName.Count
            Me.lblFileName.Text = aRaySelectedFileNameOnly(i)
            Dim CF As New IO.FileStream(aRaySelectedFileName(i).ToString, IO.FileMode.Open)
            Dim CT As New IO.FileStream(TmpOutDir & aRaySelectedFileNameOnly(i).ToString, IO.FileMode.Create)
            Dim len As Long = CF.Length - 1
            Dim buffer(1024) As Byte
            Dim byteCFead As Integer
            While CF.Position < len
                byteCFead = (CF.Read(buffer, 0, 1024))
                CT.Write(buffer, 0, byteCFead)
                ProgressBar1.Value = CInt(CF.Position / len * 100)
                '   Application.DoEvents()

                Dim PercentSelectFileDone As Integer
                PercentSelectFileDone = (CF.Position / aRaySelectedFileSize(i) * 100)
                '   Me.lblFilePctDone.Text = Format(0.0, PercentSelectFileDone)
                Me.lblFilePctDone.Text = PercentSelectFileDone


                '   IF THE "Application.DoEvents()" STATEMENT BELOW IS DELETED OR MISPLACED NONE OF THE LISTBOXES WORK
                Application.DoEvents()


            End While   '   CF.Position

            CFPositionAllSelFilesHold = CFPositionAllSelFilesHold + len
            '   CFPositionAllSelFilesHold = CFPositionAllSelFilesHold + CF.Position

            '      Calc cumulative % and cumulatively advance ProgressBar2 on total of all files copied so far
            PercentAllSelectFileDone = (CFPositionAllSelFilesHold / TotSizeSelectedFilesCurrDir * 100)
            ProgressBar2.Value = CInt(CFPositionAllSelFilesHold / TotSizeSelectedFilesCurrDir * 100)
            '    ProgressBar2.Value = CInt(CFPositionAllSelFilesHold / TotSizeSelectedFilesCurrDir * 100)
            Me.lblAllSelFilePctDone.Text = PercentAllSelectFileDone



            '      Trying to do a % and cumulatively advance ProgressBar2 on total of all files copied so far
            '      With this code located here it resets ALL SELECTED FILE percent and bar to 0 after each file is copied 
            '   PercentAllSelectFileDone = (CF.Position / TotSizeSelectedFilesCurrDir * 100)
            '   Me.lblAllSelFilePctDone.Text = PercentAllSelectFileDone
            '   ProgressBar2.Value = CInt(CF.Position / TotSizeSelectedFilesCurrDir * 100)

            CT.Flush()
            CT.Close()
            CF.Close()



        Next i
    End Sub   '   Button1_Click

    Private Sub txtSelectedFileDte_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub


End Class
