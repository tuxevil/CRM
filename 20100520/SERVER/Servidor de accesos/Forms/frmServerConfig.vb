Public Class frmServerConfig

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Drawme()
        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")
        End Try

    End Sub

    Private Sub Drawme()

        Try

            txtServer.Text = My.Settings.ServerName
            txtSqlService.Text = My.Settings.SqlService
            txtTangoService.Text = My.Settings.TangoService
            txtSqlInstance.Text = My.Settings.ServerInstance
            txtUser.Text = My.Settings.ServerUser
            txtPassword.Text = My.Settings.ServerPassword
            txtDictionary.Text = My.Settings.DbDictionary
            txtOwnerDatabase.Text = My.Settings.DbOwner
            txtMainCompany.Text = My.Settings.DefaultDatabase

        Catch ex As Exception
            Throw ex

        End Try

    End Sub

    Private Sub BlankPassword_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBlankPassword.CheckedChanged

        Try
            txtPassword.Enabled = Not chkBlankPassword.Checked

        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")
            ex = Nothing
        End Try
    End Sub

    Private Sub Password_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.EnabledChanged
        Try

            txtPassword.Text = ""

        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")
            ex = Nothing

        End Try
    End Sub

    Private Sub Data_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServer.TextChanged, txtSqlInstance.TextChanged, txtUser.TextChanged, txtPassword.TextChanged, chkBlankPassword.CheckStateChanged
        Dim b As Boolean = True
        Try
            If txtServer.Text = "" Then b = False
            If txtSqlInstance.Text = "" Then b = False
            If txtUser.Text = "" Then b = False
            If txtPassword.Text = "" And Not (chkBlankPassword.Checked) Then b = False

            cmdTestConnection.Enabled = b

        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")
            ex = Nothing
        End Try

    End Sub

    Private Sub DataBases_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDictionary.TextChanged, txtMainCompany.TextChanged, txtOwnerDatabase.TextChanged
        Dim b As Boolean = True
        Try
            If txtDictionary.Text = "" Then b = False
            If txtMainCompany.Text = "" Then b = False
            If txtOwnerDatabase.Text = "" Then b = False

            cmdSave.Enabled = b

        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")
            ex = Nothing
        End Try

    End Sub

    Private Sub TestConnection(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTestConnection.Click

        Try

            If SqlBrowser.TestServerConnection(txtSqlInstance.Text, txtUser.Text, txtPassword.Text) Then
                PanelGeneral.Visible = False
                PanelDatabase.Visible = True
            Else
                PanelGeneral.Visible = True
                PanelDatabase.Visible = False
            End If

        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")

        End Try
    End Sub

    Private Sub SaveSettings(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Try

            My.Settings.ServerName = txtServer.Text
            My.Settings.TangoService = txtTangoService.Text
            My.Settings.SqlService = txtSqlService.Text
            My.Settings.ServerInstance = txtSqlInstance.Text
            My.Settings.ServerUser = txtUser.Text
            My.Settings.ServerPassword = txtPassword.Text

            My.Settings.DbDictionary = txtDictionary.Text
            My.Settings.DbOwner = txtOwnerDatabase.Text

            My.Settings.DefaultDatabase = txtMainCompany.Text

            My.Settings.Save()

            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.Close()

        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")
            ex = Nothing

        End Try
    End Sub

    Private Sub ListServers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewServers.Click
        Dim ServersList As frmList

        Try

            ServersList = New frmList(NetworkBrowser.NetworkComputers, True)

            If ServersList.UserSelection Then
                txtServer.Enabled = True
                txtServer.ReadOnly = False
                txtServer.Focus()
            Else
                If ServersList.SelectedItem IsNot Nothing Then
                    txtServer.Text = ServersList.SelectedItem
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")
            ex = Nothing
        End Try
    End Sub


    Private Sub ListServicesSQL(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewServicesSQL.Click
        Dim ServicesList As frmList

        Try

            ServicesList = New frmList(ServicesBrowser.Services, True)

            If ServicesList.UserSelection Then
                txtSqlService.Enabled = True
                txtSqlService.ReadOnly = False
                txtSqlService.Focus()
            Else
                If ServicesList.SelectedItem IsNot Nothing Then
                    txtSqlService.Text = ServicesList.SelectedItem
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")
            ex = Nothing
        End Try
    End Sub

    Private Sub ListServicesTango(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewServicesTango.Click
        Dim ServicesList As frmList

        Try

            ServicesList = New frmList(ServicesBrowser.Services, True)

            If ServicesList.UserSelection Then
                txtTangoService.Enabled = True
                txtTangoService.ReadOnly = False
                txtTangoService.Focus()
            Else
                If ServicesList.SelectedItem IsNot Nothing Then
                    txtTangoService.Text = ServicesList.SelectedItem
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")
            ex = Nothing
        End Try
    End Sub

    Private Sub ListSqlInstances_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewSqlInstances.Click
        Dim ServersList As frmList

        Try

            ServersList = New frmList(SqlBrowser.SqlServers, True)

            If ServersList.UserSelection Then
                txtSqlInstance.Enabled = True
                txtSqlInstance.ReadOnly = False
                txtSqlInstance.Focus()
            Else
                If ServersList.SelectedItem IsNot Nothing Then
                    txtSqlInstance.Text = ServersList.SelectedItem
                End If

            End If


        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")
            ex = Nothing
        End Try
    End Sub

    Private Sub ListDatabases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewDictionaryDatabases.Click, cmdViewMaincompanydatabase.Click, cmdViewOwnerDatabase.Click
        Dim frmList As frmList
        Try
            frmList = New frmList(SqlBrowser.ServerDatabases(txtSqlInstance.Text, txtUser.Text, txtPassword.Text))

            If frmList.SelectedItem IsNot Nothing Then

                Select Case sender.name
                    Case "cmdViewDictionaryDatabases" : txtDictionary.Text = frmList.SelectedItem

                    Case "cmdViewMaincompanydatabase" : txtMainCompany.Text = frmList.SelectedItem

                    Case "cmdViewOwnerDatabase" : txtOwnerDatabase.Text = frmList.SelectedItem

                End Select

            End If

        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")
            ex = Nothing
        End Try
    End Sub

    Private Sub ChangeUser(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangeSqlUser.Click
        Try
            txtUser.ReadOnly = False
            txtUser.Focus()
        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")
            ex = Nothing
        End Try
    End Sub

    Private Sub ChangePassword(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangeSqlPassword.Click
        Try
            txtPassword.ReadOnly = False
            txtPassword.Focus()
        Catch ex As Exception
            MsgBox("Error al intentar procesar la instrucción." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Informe de errores")
            ex = Nothing
        End Try
    End Sub


End Class