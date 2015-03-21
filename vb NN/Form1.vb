Public Class Form1
    Private oneway, twoway As INN
    Private ExList As IList(Of Example) = New List(Of Example)
    Private Plist As IList(Of Profile) = New List(Of Profile)
    Private oneway_learned, twoway_learned As Boolean
    'Public Shared ReadOnly classes As Double() = {1, 1, 4, 4, 1, 1, 4, 1, 1}
    'Public Shared ReadOnly reg_limits As Double() = {2, 4, 0, 0, 3, 4, 0, 4, 3}
    Public Shared ReadOnly classes As Double() = {1, 1, 1, 1, 1, 1, 1, 1, 1}
    Public Shared ReadOnly reg_limits As Double() = {2, 4, 4, 4, 3, 4, 4, 4, 3}

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

    Private Function to_id(col As Integer, row As DataGridViewRow) As Integer
        Dim q = From r As DataRowView In CType(DGV.Columns(col), DataGridViewComboBoxColumn).Items
                        Where r.Item(0) = row.Cells(col).Value
                        Select r.Item(1)
        Return q.First()
    End Function

    Private Sub populate()
        Plist.Clear()
        For Each row As DataGridViewRow In DGV.Rows
            If row.IsNewRow Then Exit For
            Dim p As New Profile
            For col = 1 To DGV.Columns.Count - 2
                p.att(col - 1) = to_id(col, row)
            Next
            Plist.Add(p)
        Next
    End Sub
    Private Sub highlight_matches(p As Profile)
        For Each row As DataGridViewRow In DGV.Rows
            If row.IsNewRow Then Exit For
            Dim off = 0
            For col = 1 To DGV.Columns.Count - 2
                If p.att(col - 1) <> to_id(col, row) Then off = off + 1
            Next
            With row.DefaultCellStyle
                Select Case off
                    Case 0, 1
                        .BackColor = Color.DarkGreen
                    Case 2
                        .BackColor = Color.ForestGreen
                    Case 3
                        .BackColor = Color.MediumSeaGreen
                    Case 4
                        .BackColor = Color.PaleGreen
                    Case Else
                        .BackColor = Color.Empty
                End Select
            End With
        Next
    End Sub
    Private Function your_profile() As Profile
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
        Return you
    End Function
    Private Sub output_match(mres As Profile)
        ComboBoxMSex.SelectedValue = mres.att(0)
        ComboBoxMAge.SelectedValue = mres.att(1)
        ComboBoxMEthnic.SelectedValue = mres.att(2)
        ComboBoxMBuild.SelectedValue = mres.att(3)
        ComboBoxMEdu.SelectedValue = mres.att(4)
        ComboBoxMCitizen.SelectedValue = mres.att(5)
        ComboBoxMHobbies.SelectedValue = mres.att(6)
        ComboBoxMFinancial.SelectedValue = mres.att(7)
        ComboBoxMFamily.SelectedValue = mres.att(8)
    End Sub

    Private Sub ButtonOneWay_Click(sender As Object, e As EventArgs) Handles ButtonOneWay.Click
        If oneway_learned = False Then
            populate()

            For Each row As DataGridViewRow In DGV.Rows
                If row.IsNewRow Then Exit For
                If IsDBNull(row.Cells("LikeIdDataGridViewTextBoxColumn").Value) OrElse
                    row.Cells("LikeIdDataGridViewTextBoxColumn").Value >= DGV.Rows.Count Then Continue For
                Dim ex As New Example
                ex.match = Plist(row.Cells("IdDataGridViewTextBoxColumn").Value - 1)
                ex.from = Plist(row.Cells("LikeIdDataGridViewTextBoxColumn").Value - 1)
                ExList.Add(ex)
            Next

            oneway = New NN(classes, reg_limits)
            oneway.learn(ExList)
            oneway_learned = True
        End If

        Dim mres = oneway.match(your_profile)
        highlight_matches(mres)
        'ToolStripStatusLabel1.Text = "Raw results: " + String.Join(" ", mres.att)

        output_match(mres)
    End Sub

    Private Sub ButtonTwoWay_Click(sender As Object, e As EventArgs) Handles ButtonTwoWay.Click
        If twoway_learned = False Then
            populate()

            For Each row As DataGridViewRow In DGV.Rows
                If row.IsNewRow Then Exit For
                If IsDBNull(row.Cells("LikeIdDataGridViewTextBoxColumn").Value) Then Continue For
                Dim ex As New Example 'who likes you?
                ex.match = Plist(row.Cells("IdDataGridViewTextBoxColumn").Value - 1)
                ex.from = Plist(row.Cells("LikeIdDataGridViewTextBoxColumn").Value - 1)
                ExList.Add(ex)
                Dim ex2 As New Example 'whom do you like?
                ex2.match = Plist(row.Cells("LikeIdDataGridViewTextBoxColumn").Value - 1)
                ex2.from = Plist(row.Cells("IdDataGridViewTextBoxColumn").Value - 1)
                ExList.Add(ex2)
            Next

            twoway = New NN(classes, reg_limits)
            twoway.learn(ExList)
            twoway_learned = True
        End If

        Dim mres = twoway.match(your_profile)
        highlight_matches(mres)
        'ToolStripStatusLabel1.Text = "Raw results: " + String.Join(" ", mres.att)

        output_match(mres)
    End Sub

    Private Sub ButtonOneWay_MouseEnter(sender As Object, e As EventArgs) Handles ButtonOneWay.MouseEnter
        ToolStripStatusLabel1.Text = "This button will match members who are interested in your profile to you."
    End Sub

    Private Sub ButtonTwoWay_MouseEnter(sender As Object, e As EventArgs) Handles ButtonTwoWay.MouseEnter
        ToolStripStatusLabel1.Text = "This button will match you with members interested in your profile which are also interesting to people like you."
    End Sub

    Private Sub DGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseDoubleClick
        Dim s As DataGridView = sender
        If s.CurrentCell.OwningColumn.Name = "IdDataGridViewTextBoxColumn" And Not s.CurrentRow.IsNewRow Then
            Dim row = s.CurrentCell.OwningRow
            ComboBoxYSex.SelectedValue = to_id(1, row)
            ComboBoxYAge.SelectedValue = to_id(2, row)
            ComboBoxYEthnic.SelectedValue = to_id(3, row)
            ComboBoxYBuild.SelectedValue = to_id(4, row)
            ComboBoxYEdu.SelectedValue = to_id(5, row)
            ComboBoxYCitizen.SelectedValue = to_id(6, row)
            ComboBoxYHobbies.SelectedValue = to_id(7, row)
            ComboBoxYFinancial.SelectedValue = to_id(8, row)
            ComboBoxYFamily.SelectedValue = to_id(9, row)

        End If
    End Sub

    Private Sub DGV_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseMove
        ToolStripStatusLabel1.Text = "Double click on the Id column to use a saved profile for matching." +
            " Matched Ids (if any) will be colored dark green to light green for excellent to passable matches, respectively."

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If DataSet1.HasChanges() Then
            oneway_learned = False
            twoway_learned = False
            With DataSet1.Profile
                Try
                    ProfileTableAdapter.Update(.GetChanges())
                    .AcceptChanges()
                    ToolStripStatusLabel1.Text = "Changes saved."
                Catch ex As System.Data.SqlClient.SqlException
                    ToolStripStatusLabel1.Text = "Data error. Changes aborted. (Is there an invalid LikeId?)"
                    .RejectChanges()
                End Try
            End With
        End If
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        Me.ProfileTableAdapter.Fill(Me.DataSet1.Profile)
        ToolStripStatusLabel1.Text = "Database loaded."
        oneway_learned = False
        twoway_learned = False
    End Sub


    Private Sub DGV_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellValueChanged
        oneway_learned = False
        twoway_learned = False
    End Sub

    Private Sub DGV_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DGV.RowsAdded
        Dim s As DataGridView = sender
        If s.CurrentRow IsNot Nothing AndAlso s.CurrentRow.Index = s.NewRowIndex - 1 Then
            'MsgBox(DataSet1.Profile.Rows(s.CurrentRow.Index).Item(0))
            s.CurrentRow.Cells("IdDataGridViewTextBoxColumn").Value = s.CurrentRow.Index + 1
        End If
    End Sub
End Class
Public Class Profile
    Public att(Form1.classes.Length - 1) As Double
End Class
Public Class Example
    Public from, match As Profile

End Class
Public Interface INN
    Sub learn(examples As List(Of Example))
    Function match(input As Profile) As Profile

End Interface
