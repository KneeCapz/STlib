Imports MySql.Data.MySqlClient
Public Class Form1

    'read database to objects. if crew value = 0 then skip variable in contstruct.
    'check for NULL values stats and such
    'checkboxes for stats when searching. ex: has diplomacy and trait = searchcriteria 

    Public AllCrew As New List(Of Crew) 'List of crew for search purposes
    Public CrewArray As New ArrayList 'Or use arraylist
    Public DBConnection As MySqlConnection


    Private Sub DBConnect()
        DBConnection = New MySqlConnection(
        "Server=localhost;" _
        & "Database=startrektimelines;" _
        & "Uid=root;" _
        & "Pwd=Myh0pparskr0tsq;")
        Try
            DBConnection.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub DBDisconnect()
        DBConnection.Close()
        DBConnection.Dispose()
    End Sub


    ''' <summary>
    ''' Takes object as integer and returns 0 if type is DBNull
    ''' </summary>
    ''' <param name="intInteger">Integer to check</param>
    ''' <returns>0 if type is DBNull</returns>
    Private Function convertInteger(intInteger As Object) As Integer
        If intInteger Is DBNull.Value Then
            Return 0
        End If
        Return intInteger
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim Morten As New Crew With {.Name = "Morten Ivar", .Dip = 55, .Eng = 111, .Accuracy = 883}
        'Dim Ivar As New Crew With {.Name = "Faugstadmo Iver", .Dip = 77, .Eng = 1211, .Accuracy = 23}
        'Dim Trine As New Crew With {.Name = "Kleven", .Dip = 66, .Eng = 11, .Accuracy = 1213}
        'AllCrew.Add(Morten)
        'AllCrew.Add(Ivar)
        'AllCrew.Add(Trine)
    End Sub


    ''' <summary>
    ''' Search on keypress
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ListView1.Items.Clear()
        For Each c In AllCrew
            If c.Name.ToLower.Contains(TextBox1.Text.ToLower.Trim) Then
                ListView1.Items.Add(c.Name)
            End If
        Next
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim listeobjekt As New ListViewItem
        Dim listearray As New List(Of String)

        For Each i In AllCrew

            listearray.Add(i.Name)
            'listeobjekt.SubItems.Add(i.Name)
            'listeobjekt.SubItems.Add(i.Dip)
            'listeobjekt.SubItems.Add(i.Eng)
            'listeobjekt.SubItems.Add(i.Com)
            'listeobjekt.SubItems.Add(i.Med)
            'listeobjekt.SubItems.Add(i.Sci)
            'listeobjekt.SubItems.Add(i.Sec)
            'listeobjekt.SubItems.Add(i.Accuracy)
            'listeobjekt.SubItems.Add(i.CritBonus)
            'listeobjekt.SubItems.Add(i.CritRating)
            'listeobjekt.SubItems.Add(i.Evasion)


        Next
        ListView1.Items.Add(listeobjekt)

        'For i As Integer = 0 To AllCrew.Count - 1
        '    ListView1.Items.Add(AllCrew(i).Name & vbTab &
        '                       AllCrew(i).Dip & vbTab &
        '                       AllCrew(i).Eng & vbTab &
        '                       AllCrew(i).Com & vbTab &
        '                       AllCrew(i).Med & vbTab &
        '                       AllCrew(i).Sci & vbTab &
        '                       AllCrew(i).Sec & vbTab &
        '                       AllCrew(i).Accuracy & vbTab &
        '                       AllCrew(i).CritBonus & vbTab &
        '                       AllCrew(i).CritRating & vbTab &
        '                       AllCrew(i).Evasion)
        'Next

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        '   for listbox
        AllCrew = AllCrew.OrderByDescending(Function(x) x.Accuracy).ToList
        For Each c In AllCrew
            ListView1.Items.Add(c.Name)
        Next
        Dim str As String = "test"
        Dim i As Integer = 1

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim AllCrewlist As New ArrayList

        DBConnect()
        Dim SqlQuery As String = "SELECT * FROM crew"
        Dim CrewTable As New DataTable
        Dim SqlCom As New MySqlCommand(SqlQuery, DBConnection)
        Dim SqlDa As New MySqlDataAdapter
        SqlDa.SelectCommand = SqlCom
        SqlDa.Fill(CrewTable)
        DBDisconnect()

        'Dim i As Integer = 0
        Dim liste(10) As String

        For Each row In CrewTable.Rows

            '   lager objekter av Crew klassen og legger de i en liste
            'AllCrew.Add(New Crew With {.Name = row("Name"), .Dip = convertInteger(row("Diplomacy")),
            '    .Sci = convertInteger(row("Science")), .Eng = convertInteger(row("Engineering")),
            '    .Med = convertInteger(row("Medicine")), .Com = convertInteger(row("command")),
            '    .Sec = convertInteger(row("Security")), .Accuracy = convertInteger(row("Accuracy")),
            '    .CritBonus = convertInteger(row("Critbonus")), .CritRating = convertInteger(row("CritRating")),
            '    .Evasion = convertInteger(row("evasion"))})



            '   dette er for listbox
            'ListBox1.Items.Add(AllCrew(i).Name & vbTab &
            '                   AllCrew(i).Dip & vbTab &
            '                   AllCrew(i).Eng & vbTab &
            '                   AllCrew(i).Com & vbTab &
            '                   AllCrew(i).Med & vbTab &
            '                   AllCrew(i).Sci & vbTab &
            '                   AllCrew(i).Sec & vbTab &
            '                   AllCrew(i).Accuracy & vbTab &
            '                   AllCrew(i).CritBonus & vbTab &
            '                   AllCrew(i).CritRating & vbTab &
            '                   AllCrew(i).Evasion)



            '   legger data fra DB i rett i listview
            liste(0) = row("Name")
            liste(1) = convertInteger(row("Diplomacy"))
            liste(2) = convertInteger(row("Engineering"))
            liste(3) = convertInteger(row("Command"))
            liste(4) = convertInteger(row("Medicine"))
            liste(5) = convertInteger(row("Science"))
            liste(6) = convertInteger(row("Security"))
            liste(7) = convertInteger(row("Accuracy"))
            liste(8) = convertInteger(row("CritBonus"))
            liste(9) = convertInteger(row("CritRating"))
            liste(10) = convertInteger(row("Evasion"))
            Dim listeobjekt As New ListViewItem(liste)
            ListView1.Items.Add(listeobjekt)


            'i += 1
            'Overkill
            'Dim dip, eng, com, med, sci, sec, acc, crb, crr, eva As Short

            'If row("Diplomacy") Is DBNull.Value Then
            '    dip = 0
            'Else
            '    dip = row("Diplomacy")
            'End If
            'If row("Engineering") Is DBNull.Value Then
            '    eng = 0
            'Else
            '    eng = row("Engineering")
            'End If
            'If row("Command") Is DBNull.Value Then
            '    com = 0
            'Else
            '    com = row("Command")
            'End If
            'If row("Medicine") Is DBNull.Value Then
            '    med = 0
            'Else
            '    med = row("Medicine")
            'End If
            'If row("Science") Is DBNull.Value Then
            '    sci = 0
            'Else
            '    sci = row("Science")
            'End If
            'If row("Security") Is DBNull.Value Then
            '    sec = 0
            'Else
            '    sec = row("Security")
            'End If
            'If row("Accuracy") Is DBNull.Value Then
            '    acc = 0
            'Else
            '    acc = row("Accuracy")
            'End If
            'If row("CritBonus") Is DBNull.Value Then
            '    crb = 0
            'Else
            '    crb = row("CritBonus")
            'End If
            'If row("CritRating") Is DBNull.Value Then
            '    crr = 0
            'Else
            '    crr = row("Critrating")
            'End If
            'If row("Evasion") Is DBNull.Value Then
            '    eva = 0
            'Else
            '    eva = row("Evasion")
            'End If

            'CrewList.Add(New Crew With {.Name = row("Name"), .Dip = dip,
            '    .Sci = sci, .Eng = eng, .Med = med,
            '    .Com = com, .Sec = sec, .Accuracy = acc,
            '    .CritBonus = crb, .CritRating = crr, .Evasion = eva})
        Next

    End Sub
End Class
