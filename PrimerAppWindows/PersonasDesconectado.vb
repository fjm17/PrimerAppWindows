Imports System.Data.SqlClient

Public Class PersonasDesconectado

    Dim conexion As New SqlConnection(My.Settings.cadenaConexion)
    Dim tblDatosPersonas As New DataTable
    Dim adpAdaptador As New SqlDataAdapter

    Private Sub PersonasDesconectado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cmdSelect As New SqlCommand("Select * From Persona", conexion)
        adpAdaptador.SelectCommand = cmdSelect
        adpAdaptador.Fill(tblDatosPersonas)

        grdPersonasDescanectadas.DataSource = tblDatosPersonas
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        adpAdaptador.InsertCommand = crearInsert()

        adpAdaptador.UpdateCommand = crearUpdate()

        adpAdaptador.DeleteCommand = crearDelete()

        adpAdaptador.Update(tblDatosPersonas)
    End Sub
    Private Function crearInsert() As SqlCommand

        Dim cmdinsert As New SqlCommand
        cmdinsert.Connection = conexion
        cmdinsert.CommandText = "Insert into persona (cedula, nombre, apellido)" & "values (@ced, @nom, @ape)"

        cmdinsert.Parameters.Add(New SqlParameter("@ced", SqlDbType.NVarChar, 20, "Cedula"))
        cmdinsert.Parameters.Add(New SqlParameter("@nom", SqlDbType.NVarChar, 100, "Nombre"))
        cmdinsert.Parameters.Add(New SqlParameter("@ape", SqlDbType.NVarChar, 200, "Apellido"))

        Return cmdinsert
    End Function

    Private Function crearUpdate() As SqlCommand

        Dim cmdupdate As New SqlCommand
        cmdupdate.Connection = conexion
        cmdupdate.CommandText = "update persona set Nombre = @nom, Apellido = @ape where cedula = @ced"

        cmdupdate.Parameters.Add(New SqlParameter("@ced", SqlDbType.NVarChar, 20, "Cedula"))
        cmdupdate.Parameters.Add(New SqlParameter("@nom", SqlDbType.NVarChar, 100, "Nombre"))
        cmdupdate.Parameters.Add(New SqlParameter("@ape", SqlDbType.NVarChar, 200, "Apellido"))

        Return cmdupdate

    End Function

    Private Function crearDelete() As SqlCommand

        Dim cmddelete As New SqlCommand
        cmddelete.Connection = conexion
        cmddelete.CommandText = "delete from persona where Cedula = @ced"

        cmddelete.Parameters.Add(New SqlParameter("@ced", SqlDbType.NVarChar, 20, "Cedula"))

        Return cmddelete

    End Function

End Class