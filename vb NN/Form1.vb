Public Class Form1
    Dim oneway, twoway As INN
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

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
