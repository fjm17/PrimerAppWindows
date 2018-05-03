Imports System.Data.SqlClient

'Si importo la clase no se necesito poner la nameSpace (SqlClient), quedaria asi Dim conexion As New SqlConnection, de otra manera seria asi Dim conexion As New Sql.Client.SqlConnection
Public Class frmPersonas

    Dim conexion As New SqlConnection(My.Settings.cadenaConexion)
    Dim tblDatosPersonas As New DataTable


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim query As String
        Dim strCedula As String = txtCedula.Text.Trim
        Dim strNombre As String = txtNombre.Text.Trim
        Dim strApellidos As String = txtApellidos.Text.Trim

        'query = "spInsertarPersona" (para store procedure)

        'query = "Insert into Persona(cedula, nombre, apellido) values('" & strCedula & "', ' " & strNombre & "', ' " & strAellidos & "')"
        query = "Insert into Persona(cedula, nombre, apellido) values(@ced, @nom, @ape)"

        Dim sentencia As New SqlCommand(query, conexion)

        'sentencia.CommandType = CommandType.StoreProcedure (para store procedure)

        sentencia.Parameters.AddWithValue("@ced", strCedula)
        sentencia.Parameters.AddWithValue("@nom", strNombre)
        sentencia.Parameters.AddWithValue("@ape", strApellidos)

        'sentencia.CommandText = query
        'sentencia.Connection = conexion


        Dim sentencia2 As New SqlCommand("Select COUNT (cedula) FROM Persona WHERE cedula = @param", conexion)
        sentencia2.Parameters.AddWithValue("@param", strCedula)

        If conexion.State <> ConnectionState.Open Then
            conexion.Open()
        End If


        If sentencia2.ExecuteScalar() = 1 Then
            MessageBox.Show("La cedula esta repetida")

        Else
            sentencia.ExecuteNonQuery()

        End If


        If conexion.State <> ConnectionState.Closed Then
            conexion.Close()
        End If

        tblDatosPersonas.Rows.Add(txtCedula.Text.Trim, txtNombre.Text.Trim, txtApellidos.Text.Trim)
    End Sub

    Private Sub frmPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim tblDatosPersonas As New DataTable
        tblDatosPersonas.Columns.Add("Cedula", Type.GetType("System.String"))
        tblDatosPersonas.Columns.Add("Nombre", Type.GetType("System.String"))
        tblDatosPersonas.Columns.Add("Apellido", Type.GetType("System.String"))

        Dim consulta As String
        consulta = "SELECT * FROM Persona"

        Dim sentencia2 As New SqlCommand(consulta, conexion)

        If conexion.State <> ConnectionState.Open Then
            conexion.Open()
        End If

        Dim rdrLector As SqlDataReader
        rdrLector = sentencia2.ExecuteReader

        'Dim strCedula As String
        'Dim strNombre As String
        'Dim strApellido As String

        If rdrLector.HasRows Then

            While rdrLector.Read()

                'strCedula = rdrLector("cedula")
                'strNombre = rdrLector("nombre")
                'strApellido = rdrLector("apellido")
                'tblDatosPersonas.Rows.Add(strCedula, strNombre, strApellido)

                tblDatosPersonas.Rows.Add(rdrLector("cedula"), rdrLector("nombre"), rdrLector("apellido"))

            End While

        End If

        If conexion.State <> ConnectionState.Closed Then
            conexion.Close()
        End If

        grdDatosPersonas.DataSource = tblDatosPersonas

    End Sub
End Class
