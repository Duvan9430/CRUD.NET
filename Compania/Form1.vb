Public Class Form1
    Dim Operaciones As New ServicioDatos.empleadosSoapClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub

    Private Sub Limpiar()
        txtID.Text = "0"
        txtNOMBRE.Clear()
        txtTELEFONO.Clear()

        txtNOMBRE.Focus()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtID.Text = "0" Then
            Operaciones.NuevoRegistro(txtNOMBRE.Text, txtTELEFONO.Text)
            DataGridView1.DataSource = Operaciones.BuscaRegistro(txtBuscar.Text).Tables(0)
        Else
            Operaciones.ActualizarRegistro(txtID.Text, txtNOMBRE.Text, txtTELEFONO.Text)
            DataGridView1.DataSource = Operaciones.BuscaRegistro(txtBuscar.Text).Tables(0)
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Operaciones.EliminaRegistro(txtID.Text)
        DataGridView1.DataSource = Operaciones.BuscaRegistro(txtBuscar.Text).Tables(0)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        DataGridView1.DataSource = Operaciones.BuscaRegistro(txtBuscar.Text).Tables(0)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        txtID.Text = DataGridView1.CurrentRow.Cells("ID").Value
        txtNOMBRE.Text = DataGridView1.CurrentRow.Cells("NOMBRE").Value.ToString
        txtTELEFONO.Text = DataGridView1.CurrentRow.Cells("TELEFONO").Value.ToString
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub
End Class
