Public Class NN
    Implements INN

    Private neurons As New List(Of Neuron)
    Private A(,) As Double
    Private b() As Double
    Private Const dimensions = 8
    Private ReadOnly NNLayers() As Double = {dimensions, 4, dimensions} 'hidden not strictly needed with linear activation

    Public Sub New() 'build a fully-connected network with NNLayers(i) neurons in layer i
        For i = 1 To dimensions
            neurons.Add(New Neuron)
        Next
        Dim prev_layer_first = 0
        For i = 1 To NNLayers.Count - 1
            For j = 1 To NNLayers(i)
                neurons.Add(New Neuron(neurons.GetRange(prev_layer_first, NNLayers(i - 1))))
            Next
            prev_layer_first += NNLayers(i - 1)
        Next
    End Sub
    Public Sub learn(examples As List(Of Example)) Implements INN.learn
        Dim total_weights = NNLayers.Zip(NNLayers.Skip(1), Function(a, b) a * b).Sum()
        ReDim A(examples.Count * neurons.Skip(dimensions).Count, total_weights)
        ReDim b(total_weights)

        'construct A and b from network
        Dim i = 0
        For Each ex In examples
            feed(ex.person, ex.likes)
            Dim j = 0
            For Each n In neurons.Skip(dimensions)
                b(i) = n.val
                For Each edge In n.inputs
                    A(i, j) = edge.from.val
                    j += 1
                Next
                i += 1
            Next
        Next

        'm>n?
        Dim svd = New Accord.Math.Decompositions.SingularValueDecomposition(A)
        Dim res() = svd.Solve(b)

        'update weights
        i = 0
        For Each n In neurons.Skip(dimensions)
            For Each edge In n.inputs
                edge.weight = res(i)
                i += 1
            Next
        Next

    End Sub
    Private Sub feed(input As Profile, Optional output As Profile = Nothing)
        For i = 0 To dimensions - 1
            neurons(i).val = input.att(i)
        Next
        For Each neuron In neurons.Skip(dimensions)
            neuron.recalc()
        Next
        If output IsNot Nothing Then
            For i = 0 To dimensions - 1
                neurons(neurons.Count - dimensions + i).val = output.att(i)
            Next
        End If
    End Sub

    Public Function match(input As Profile) As Profile Implements INN.match
        feed(input)
        Dim output As New Profile
        For i = 0 To dimensions - 1
            output.att(i) = neurons(neurons.Count - dimensions + i).val
        Next
        Return output
    End Function
End Class
Public Class Neuron
    Public inputs As List(Of Edge)
    Public val As Integer
    Sub New(neu_inputs As List(Of Neuron))
        For Each i In neu_inputs
            inputs.Add(New Edge(i))
        Next
    End Sub
    Sub New()
    End Sub
    Sub recalc()
        val = Activation_Fun(Aggregate i In inputs Into Sum(i.from.val * i.weight))
    End Sub
    Function Activation_Fun(inputs As Double) As Double 'hard threshold
        If inputs > 0.5 Then
            Return 1
        End If
        Return 0
    End Function

End Class
Public Class Edge
    Public weight As Double = Rnd() / 4
    Shared counter As Integer
    Friend index As Integer
    Friend from As Neuron
    Sub New(from1 As Neuron)
        from = from1
        counter += 1
        index = counter
    End Sub
End Class