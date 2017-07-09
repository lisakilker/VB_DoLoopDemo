Public Class frmDoLoopApp

    Private Sub frmDoLoopApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        'Print("Hi!")
        'Print(42)
        'Print(19.74)
        'Dim input As String = InputBox("Enter a value to display", "Input required")
        'Print(input)
        '----------------------
        'Const cintDataPieces As Integer = 10
        'Dim intCounter As Integer = 0
        'Dim strInput As String

        'Do While intCounter < cintDataPieces
        'strInput = InputBox("Enter something")
        'Print(strInput)
        'intCounter += 1
        'Loop
        '-------------------------

        ' Const cintDataPieces As Integer = 10
        ' Dim intCounter As Integer = 0
        ' Dim strInput As String
        ' Do
        'strInput = InputBox("Enter something.")
        ' Print(strInput)
        'intCounter = intCounter + 1
        'Loop Until strInput = ""
        '----------------------------
        'Const cintDataPieces As Integer = 7
        'Dim intCounter As Integer = 0
        'Dim strInput As String

        'Do While intCounter < cintDataPieces
        'strInput = InputBox("Enter Something")
        'If IsNumeric(strInput) Then
        'Print(strInput)
        'intCounter = intCounter + 1
        'Else
        'MsgBox("Numeric input Only")
        'End If
        'Loop
        '----------------------------------------
        'Const cintDataPieces As Integer = 12
        'Dim intCounter As Integer = 0
        'Dim strInput As String
        ' Do
        'strInput = InputBox("Enter something.")
        'Print(strInput)
        'intCounter = intCounter + 1
        'Loop Until intCounter >= cintDataPieces Or strInput = ""
        '-----------------------------------------
        Const cintDataPieces As Integer = 11
        Dim intCounter As Integer = 0
        Dim intTotal As Integer = 0
        Dim strInput As String
        Do
            strInput = InputBox("Enter something.")
            If IsNumeric(strInput) Then
                Print(strInput)
                intCounter = intCounter + 1
                intTotal = intTotal + Convert.ToInt32(strInput)
            Else
                MsgBox("Please enter a valid number")
            End If
        Loop Until intCounter >= cintDataPieces Or strInput = ""

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub
    ' Magic code :-)
    ' Don't change anything below

    Private lstDisplay As ListBox
    Private lblCount As Label

    Private Sub Clear()
        lstDisplay.Items.Clear()
        UpdateCount()
    End Sub
    Private Sub Init()
        lstDisplay = New ListBox()
        lstDisplay.Location = New Point(15, 15)
        lstDisplay.Size = New Size(250, 200)
        Me.Controls.Add(lstDisplay)

        lblCount = New Label()
        lblCount.Location = New Point(15, 215)
        UpdateCount()
        Me.Controls.Add(lblCount)
    End Sub

    Private Sub Print(value As Integer)
        Print(value.ToString("N0"))
    End Sub

    Private Sub Print(value As Double)
        Print(value.ToString("N"))
    End Sub

    Private Sub Print(value As String)
        lstDisplay.Items.Add(value)
        UpdateCount()
    End Sub

    Private Sub UpdateCount()
        lblCount.Text = "Count: " & lstDisplay.Items.Count.ToString()
    End Sub

    ' End of magic code

End Class
