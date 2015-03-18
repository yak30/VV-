Imports Accord.Math

Public Class NN
    Implements INN

    Private neurons As New List(Of Neuron)
    Private A(,) As Double
    Private B(,) As Double
    Private dims = -1
    Private ReadOnly NNLayers() As Double = {dims, dims} 'hidden not strictly needed with linear activation

    Public Sub New(num_dimensions As Double) 'build a fully-connected network with NNLayers(i) neurons in layer i
        dims = num_dimensions
        NNLayers(0) = dims
        NNLayers(NNLayers.Length - 1) = dims

        For i = 1 To dims
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
        Dim total_weights_per_dim = NNLayers.Zip(NNLayers.Skip(1), Function(a, b) a * b).Sum() / NNLayers.Last()
        ReDim A(examples.Count - 1, total_weights_per_dim - 1)
        ReDim B(examples.Count - 1, dims - 1)

        'construct A and B from network
        Dim i = 0 'examples
        For Each ex In examples
            feed(ex.from, ex.match)
            Dim j = 0
            For Each n In neurons.Take(dims)
                A(i, j) = n.val
                B(i, j) = neurons(neurons.Count - dims + j).val
                j += 1
            Next
            i += 1
        Next
        'TODO: hidden layers
        'For Each n In neurons.Take(neurons.Count - dims).Skip(dims)
        '    For Each edge In n.inputs
        '        A(i, j) = edge.from.val
        '        j += 1
        '    Next
        'Next
        'For Each edge In neurons(neurons.Count - dims + k).inputs
        '    A(i, j) = edge.from.val
        '    j += 1
        'Next



        'm>n?
        Dim svd = New Accord.Math.Decompositions.SingularValueDecomposition(A, True, True, True)
        Dim U = svd.LeftSingularVectors
        Dim S = svd.DiagonalMatrix
        Dim V = svd.RightSingularVectors
        Dim pseudoinverseA = V.Multiply(S.Inverse()).MultiplyByTranspose(U)
        Dim X = pseudoinverseA.Multiply(B)
        'Dim X(,) = A.Solve(B) 'Also works (?), but implicit

        'update weights
        i = 0 'neuron
        For Each n In neurons.Skip(neurons.Count - dims)
            Dim j = 0 'edge
            For Each edge In n.inputs
                edge.weight = X(j, i)
                j += 1
            Next
            i += 1
        Next

    End Sub
    Private Sub feed(input As Profile, Optional output As Profile = Nothing)
        For i = 0 To dims - 1
            neurons(i).val = input.att(i)
        Next
        For Each neuron In neurons.Skip(dims)
            neuron.recalc()
        Next
        If output IsNot Nothing Then
            For i = 0 To dims - 1
                neurons(neurons.Count - dims + i).val = output.att(i)
            Next
        End If
    End Sub

    Public Function match(input As Profile) As Profile Implements INN.match
        feed(input)
        Dim output As New Profile
        For i = 0 To dims - 1
            output.att(i) = neurons(neurons.Count - dims + i).val
        Next
        Return output
    End Function
End Class
Public Class Neuron
    Public inputs As List(Of Edge)
    Public val As Integer
    Sub New(neu_inputs As List(Of Neuron))
        inputs = New List(Of Edge)
        For Each i In neu_inputs
            inputs.Add(New Edge(i))
        Next
    End Sub
    Sub New()
    End Sub
    Sub recalc()
        val = Activation_Fun(Aggregate i In inputs Into Sum(i.from.val * i.weight))
    End Sub
    Function Activation_Fun(inputs As Double) As Double
        'If inputs > 0.5 Then
        '    Return 1
        'End If
        'Return 0
        Return inputs
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