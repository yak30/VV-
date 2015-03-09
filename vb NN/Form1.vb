Public Class Form1
    Dim oneway, twoway As INN
    Dim ExL As IList(Of Example)
    Dim learned1way, learned2way As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.Profile' table. You can move, or remove it, as needed.
        Me.ProfileTableAdapter.Fill(Me.DataSet1.Profile)
        'TODO: This line of code loads data into the 'DataSet1.TBuild' table. You can move, or remove it, as needed.
        Me.TBuildTableAdapter.Fill(Me.DataSet1.TBuild)
        'TODO: This line of code loads data into the 'DataSet1.TFamily' table. You can move, or remove it, as needed.
        Me.TFamilyTableAdapter.Fill(Me.DataSet1.TFamily)
        'TODO: This line of code loads data into the 'DataSet1.TCitizenship' table. You can move, or remove it, as needed.
        Me.TCitizenshipTableAdapter.Fill(Me.DataSet1.TCitizenship)
        'TODO: This line of code loads data into the 'DataSet1.THobbies' table. You can move, or remove it, as needed.
        Me.THobbiesTableAdapter.Fill(Me.DataSet1.THobbies)
        'TODO: This line of code loads data into the 'DataSet1.TEthnicity' table. You can move, or remove it, as needed.
        Me.TEthnicityTableAdapter.Fill(Me.DataSet1.TEthnicity)
        'TODO: This line of code loads data into the 'DataSet1.TEducation' table. You can move, or remove it, as needed.
        Me.TEducationTableAdapter.Fill(Me.DataSet1.TEducation)
        'TODO: This line of code loads data into the 'DataSet1.TFinancial' table. You can move, or remove it, as needed.
        Me.TFinancialTableAdapter.Fill(Me.DataSet1.TFinancial)
        'TODO: This line of code loads data into the 'DataSet1.TAge' table. You can move, or remove it, as needed.
        Me.TAgeTableAdapter.Fill(Me.DataSet1.TAge)
        'TODO: This line of code loads data into the 'DataSet1.TSex' table. You can move, or remove it, as needed.
        Me.TSexTableAdapter.Fill(Me.DataSet1.TSex)

    End Sub
    Private Sub Fill()
        ExL = New List(Of Example)

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
        p2.att(0) = 2
        p2.att(1) = 2
        p2.att(2) = 2
        p2.att(3) = 2
        p2.att(4) = 4
        p2.att(5) = 3
        p2.att(6) = 1
        p2.att(7) = 2
        p2.att(8) = 1

        Dim p3 = New Profile
        p3.att(0) = 3
        p3.att(1) = 1
        p3.att(2) = 1
        p3.att(3) = 2
        p3.att(4) = 3
        p3.att(5) = 2
        p3.att(6) = 2
        p3.att(7) = 2
        p3.att(8) = 2

        Dim p4 = New Profile
        p4.att(0) = 4
        p4.att(1) = 2
        p4.att(2) = 2
        p4.att(3) = 3
        p4.att(4) = 2
        p4.att(5) = 2
        p4.att(6) = 2
        p4.att(7) = 2
        p4.att(8) = 2

        Dim p5 = New Profile
        p5.att(0) = 5
        p5.att(1) = 2
        p5.att(2) = 2
        p5.att(3) = 3
        p5.att(4) = 1
        p5.att(5) = 2
        p5.att(6) = 2
        p5.att(7) = 1
        p5.att(8) = 1

        Dim exp1 = New Example
        exp1.person = p1
        exp1.likes = p2

        Dim exp2 = New Example
        exp2.person = p2
        exp2.likes = p1

        Dim exp3 = New Example
        exp3.person = p3
        exp3.likes = p2

        Dim exp4 = New Example
        exp4.person = p4
        exp4.likes = p5

        Dim exp5 = New Example
        exp5.person = p5
        exp5.likes = p4

        ExL.Add(exp1)
        ExL.Add(exp2)
        ExL.Add(exp3)
        ExL.Add(exp4)
        ExL.Add(exp5)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pro = New Profile
        'Dim comb As String = ""
        'pro.att(0) = 2 ''YAK: why don't you use indexes? ,We dont need to use it at all
        pro.att(0) = CInt(ComboBox35.Text.Substring(0, 1)) 'The list start from Age colum.(I think it get the Women sex as defult?)
        pro.att(1) = CInt(ComboBox34.Text.Substring(0, 1))
        pro.att(2) = CInt(ComboBox33.Text.Substring(0, 1))
        pro.att(3) = CInt(ComboBox32.Text.Substring(0, 1))
        pro.att(4) = CInt(ComboBox31.Text.Substring(0, 1))
        pro.att(5) = CInt(ComboBox30.Text.Substring(0, 1))
        pro.att(6) = CInt(ComboBox29.Text.Substring(0, 1))
        pro.att(7) = CInt(ComboBox28.Text.Substring(0, 1))

        Fill()
        ''YAK: you didn't instantiate an NN.
        ''YAK: also, NN code was broken. I fixed it, but did not check results.

        oneway = New NN(8)
        oneway.learn(ExL)
        Dim mres = oneway.match(pro)

        'MsgBox(String.Join(" ", mres.att))
        ComboBox27.Text = ComboBox35.Items(mres.att(0))
        ComboBox26.Text = ComboBox34.Items(mres.att(1))
        ComboBox25.Text = ComboBox33.Items(mres.att(2))
        ComboBox24.Text = ComboBox32.Items(mres.att(3))
        ComboBox23.Text = ComboBox31.Items(mres.att(4))
        ComboBox22.Text = ComboBox30.Items(mres.att(5))
        ComboBox21.Text = ComboBox29.Items(mres.att(6))
        ComboBox20.Text = ComboBox28.Items(mres.att(7))
        'ComboBox19.Text = ComboBox35.Items(mres.att(8))

    End Sub

    Private Sub ComboBox36_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox28_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox28.SelectedIndexChanged

    End Sub

    Private Sub ComboBox34_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox34.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox26_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox26.SelectedIndexChanged

    End Sub
End Class
Public Class Profile
    Public att(8) As Double
End Class
Public Class Example
    Public person, likes As Profile

End Class
Public Interface INN
    Sub learn(examples As List(Of Example))
    Function match(input As Profile) As Profile

End Interface
