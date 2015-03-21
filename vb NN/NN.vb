Imports Accord.Math

Public Class NN
    Implements INN

    Private neurons As New List(Of Neuron)
    Private A(,) As Double
    Private B(,) As Double
    Private ReadOnly dims
    Private ReadOnly classes As Double()
    Private ReadOnly reg_limits As Double()
    Private ReadOnly NNLayers() As Double = {-1, -1} 'hidden not strictly needed with linear activation

    Public Sub New(classes As Double(), reg_limits As Double()) 'build a fully-connected network with NNLayers(i) neurons in layer i
        Me.classes = classes
        Me.reg_limits = reg_limits
        dims = classes.Length
        NNLayers(0) = classes.Sum()
        NNLayers(NNLayers.Length - 1) = classes.Sum()

        For i = 1 To NNLayers(0)
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
        ReDim B(examples.Count - 1, NNLayers.Last() - 1)

        'construct A and B from network
        Dim i = 0 'examples
        For Each ex In examples
            feed(ex.from, ex.match)
            Dim j = 0
            For Each n In neurons.Take(NNLayers(0))
                A(i, j) = n.val
                B(i, j) = neurons(neurons.Count - NNLayers.Last() + j).val
                j += 1
            Next
            i += 1
        Next

        'm>n?
        Dim svd = New Accord.Math.Decompositions.SingularValueDecomposition(A, True, True, True)
        Dim U = svd.LeftSingularVectors
        Dim S = svd.DiagonalMatrix
        Dim V = svd.RightSingularVectors
        Dim pseudoinverseA = V.Multiply(S.Inverse()).MultiplyByTranspose(U)
        Dim X = pseudoinverseA.Multiply(B)

        'Dim X(,) = A.Solve(B) 'Also works (?), but implicit, and fails if rank is low

        'update weights
        i = 0 'neuron
        For Each n In neurons.Skip(neurons.Count - NNLayers.Last())
            Dim j = 0 'edge
            For Each edge In n.inputs
                edge.weight = X(j, i)
                j += 1
            Next
            i += 1
        Next

    End Sub
    Private Sub feed(input As Profile, Optional output As Profile = Nothing)
        Dim i_neuron = 0
        For i = 0 To dims - 1
            If classes(i) = 1 Then
                neurons(i_neuron).val = input.att(i)
            Else
                neurons(i_neuron + input.att(i) - 1).val = 1 ' input.att must be >=1
                'rest are 0
            End If
            i_neuron = i_neuron + classes(i)
        Next

        For Each neuron In neurons.Skip(NNLayers(0))
            neuron.recalc()
        Next

        If output IsNot Nothing Then
            i_neuron = neurons.Count - NNLayers.Last()
            For i = 0 To dims - 1
                If classes(i) = 1 Then
                    neurons(i_neuron).val = output.att(i)
                Else
                    For j = 0 To classes(i) - 1
                        neurons(i_neuron + j).val = 0
                    Next
                    neurons(i_neuron + output.att(i) - 1).val = 1 ' output.att must be >=1
                End If
                i_neuron = i_neuron + classes(i)
            Next
        End If
    End Sub

    Public Function match(input As Profile) As Profile Implements INN.match
        feed(input)
        Dim output As New Profile
        Dim i_neuron = neurons.Count - NNLayers.Last()
        For i = 0 To dims - 1
            If classes(i) = 1 Then
                output.att(i) = neurons(i_neuron).val
            Else
                Dim max_j = 0, max = Double.MinValue
                For j = 0 To classes(i) - 1
                    If neurons(i_neuron + j).val > max Then
                        max = neurons(i_neuron + j).val
                        max_j = j
                    End If
                Next
                output.att(i) = max_j + 1
            End If
            i_neuron = i_neuron + classes(i)
        Next

        'sanify...
        For i = 0 To dims - 1
            If reg_limits(i) <> 0 Then
                If output.att(i) < 1 Then
                    output.att(i) = 1
                ElseIf output.att(i) > reg_limits(i) Then
                    output.att(i) = reg_limits(i)
                Else
                    output.att(i) = Math.Round(output.att(i))
                End If
            End If
        Next

        Return output
    End Function
End Class
Public Class Neuron
    Public inputs As List(Of Edge)
    Public val As Double
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