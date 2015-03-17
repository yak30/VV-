Public Class Form1
    Dim oneway, twoway As INN
    Dim ExList As IList(Of Example) = New List(Of Example)
    Dim Plist As IList(Of Profile) = New List(Of Profile)
    Dim oneway_learned, twoway_learned As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProfileTableAdapter.Fill(Me.DataSet1.Profile)
        Me.TBuildTableAdapter.Fill(Me.DataSet1.TBuild)
        Me.TFamilyTableAdapter.Fill(Me.DataSet1.TFamily)
        Me.TCitizenshipTableAdapter.Fill(Me.DataSet1.TCitizenship)
        Me.THobbiesTableAdapter.Fill(Me.DataSet1.THobbies)
        Me.TEthnicityTableAdapter.Fill(Me.DataSet1.TEthnicity)
        Me.TEducationTableAdapter.Fill(Me.DataSet1.TEducation)
        Me.TFinancialTableAdapter.Fill(Me.DataSet1.TFinancial)
        Me.TAgeTableAdapter.Fill(Me.DataSet1.TAge)
        Me.TSexTableAdapter.Fill(Me.DataSet1.TSex)
    End Sub
    Private Sub Fill()
        ExList = New List(Of Example)

        Dim p1 = New Profile
        p1.att(0) = 1
        p1.att(1) = 2
        p1.att(2) = 2
        p1.att(3) = 3
        p1.att(4) = 2
        p1.att(5) = 2
        p1.att(6) = 2
        p1.att(7) = 1
        p1.att(8) = 2


        Dim p2 = New Profile
        p2.att(0) = 1
        p2.att(1) = 2
        p2.att(2) = 2
        p2.att(3) = 2
        p2.att(4) = 4
        p2.att(5) = 3
        p2.att(6) = 1
        p2.att(7) = 2
        p2.att(8) = 1

        Dim p3 = New Profile
        p3.att(0) = 1
        p3.att(1) = 1
        p3.att(2) = 1
        p3.att(3) = 2
        p3.att(4) = 3
        p3.att(5) = 2
        p3.att(6) = 2
        p3.att(7) = 2
        p3.att(8) = 2

        Dim p4 = New Profile
        p4.att(0) = 1
        p4.att(1) = 2
        p4.att(2) = 2
        p4.att(3) = 3
        p4.att(4) = 2
        p4.att(5) = 2
        p4.att(6) = 2
        p4.att(7) = 2
        p4.att(8) = 2

        Dim p5 = New Profile
        p5.att(0) = 1
        p5.att(1) = 2
        p5.att(2) = 2
        p5.att(3) = 3
        p5.att(4) = 1
        p5.att(5) = 2
        p5.att(6) = 2
        p5.att(7) = 1
        p5.att(8) = 1

        Dim exp1 = New Example
        exp1.from = p1
        exp1.match_to = p2

        Dim exp2 = New Example
        exp2.from = p2
        exp2.match_to = p1

        Dim exp3 = New Example
        exp3.from = p3
        exp3.match_to = p2

        Dim exp4 = New Example
        exp4.from = p4
        exp4.match_to = p5

        Dim exp5 = New Example
        exp5.from = p5
        exp5.match_to = p4

        ExList.Add(exp1)
        ExList.Add(exp2)
        ExList.Add(exp3)
        ExList.Add(exp4)
        ExList.Add(exp5)

    End Sub
    Private Sub populate()
        Plist.Clear()
        For Each row As DataGridViewRow In DGV.Rows
            If row.IsNewRow Then Exit For
            Dim p As New Profile
            For col = 1 To DGV.Columns.Count - 2
                Dim q = From r As DataRowView In CType(DGV.Columns(col), DataGridViewComboBoxColumn).Items
                        Where r.Item(0) = row.Cells(col).Value
                        Select r.Item(1)
                p.att(col - 1) = q.First()
            Next
            Plist.Add(p)
        Next
    End Sub
    Private Sub ButtonOneWay_Click(sender As Object, e As EventArgs) Handles ButtonOneWay.Click
        If oneway_learned = False Then
            populate()

            For Each row As DataGridViewRow In DGV.Rows
                If row.IsNewRow Then Exit For
                Dim ex As New Example
                ex.match_to = Plist(row.Cells("IdDataGridViewTextBoxColumn").Value - 1)
                ex.from = Plist(row.Cells("LikeIdDataGridViewTextBoxColumn").Value - 1)
                ExList.Add(ex)
            Next

            oneway = New NN(9)
            oneway.learn(ExList)
            oneway_learned = True
        End If

        Dim you = New Profile
        With you
            .att(0) = ComboBoxYSex.SelectedValue
            .att(1) = ComboBoxYAge.SelectedValue
            .att(2) = ComboBoxYEthnic.SelectedValue
            .att(3) = ComboBoxYBuild.SelectedValue
            .att(4) = ComboBoxYEdu.SelectedValue
            .att(5) = ComboBoxYCitizen.SelectedValue
            .att(6) = ComboBoxYHobbies.SelectedValue
            .att(7) = ComboBoxYFinancial.SelectedValue
            .att(8) = ComboBoxYFamily.SelectedValue
        End With

        Dim mres = oneway.match(you)
        'TODO: color green

        ToolStripStatusLabel1.Text = String.Join(" ", mres.att)

        'ComboBoxMSex.SelectedIndex = mres.att(0)
        'ComboBoxMAge.SelectedIndex = mres.att(1)
        'ComboBoxMEthnic.SelectedIndex = mres.att(2)
        'ComboBoxMBuild.SelectedIndex = mres.att(3)
        'ComboBoxMEdu.SelectedIndex = mres.att(4)
        'ComboBoxMCitizen.SelectedIndex = mres.att(5)
        'ComboBoxMHobbies.SelectedIndex = mres.att(6)
        'ComboBoxMFinancial.SelectedIndex = mres.att(7)
        'ComboBoxMFamily.SelectedIndex = mres.att(8)

    End Sub


    Private Sub ButtonOneWay_MouseMove(sender As Object, e As MouseEventArgs) Handles ButtonOneWay.MouseMove
        ToolStripStatusLabel1.Text = "This button will match members who are interested in your profile to you."
    End Sub

    Private Sub ButtonTwoWay_MouseMove(sender As Object, e As MouseEventArgs) Handles ButtonTwoWay.MouseMove
        ToolStripStatusLabel1.Text = "This button will match you with members who are interesting to you and who are interested in your profile."
    End Sub

    Private Sub ButtonTwoWay_Click(sender As Object, e As EventArgs) Handles ButtonTwoWay.Click

    End Sub
End Class
Public Class Profile
    Public att(8) As Double
End Class
Public Class Example
    Public from, match_to As Profile

End Class
Public Interface INN
    Sub learn(examples As List(Of Example))
    Function match(input As Profile) As Profile

End Interface
