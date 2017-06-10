Public Class frmMain

    Private WithEvents fUsers As frmPermissions
    Private WithEvents fProfiles As frmProfiles
    Private WithEvents fCompanies As frmCompanies

    Private Sub Buttons_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProfiles.MouseHover, cmdMail.MouseHover, cmdCompanies.MouseHover, btUsers.MouseHover

        Dim Button As Button
        Try

            Button = TryCast(sender, Button)

            If Button Is Nothing Then Exit Try

            Button.Font = New Drawing.Font("Calibri", 20.25, FontStyle.Underline)
            Button.ForeColor = Drawing.SystemColors.ControlLightLight

        Catch ex As Exception
            ex = Nothing
        End Try


    End Sub

    Private Sub Buttons_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProfiles.MouseLeave, cmdMail.MouseLeave, cmdCompanies.MouseLeave, btUsers.MouseLeave
        Dim Button As Button
        Try

            Button = TryCast(sender, Button)

            If Button Is Nothing Then Exit Try

            Button.Font = New Drawing.Font("Calibri", 15.75, FontStyle.Regular)
            Button.ForeColor = Drawing.SystemColors.ControlText

        Catch ex As Exception
            ex = Nothing
        End Try
    End Sub

    Private Sub btUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUsers.Click

        Try

            fUsers = New frmPermissions(Domain.CompanyRepository.GetAll(), Domain.ProfileRepository.GetAll())
            fUsers.ShowDialog()

        Catch ex As Exception
            ex.ToString()
        End Try

    End Sub

    Private Sub cmdProfiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProfiles.Click
        Try

            fProfiles = New frmProfiles(Domain.ProfileRepository.GetAll())
            fProfiles.ShowDialog()

        Catch ex As Exception
            ex.ToString()
        End Try

    End Sub

    Private Sub cmdCompanies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompanies.Click

        Try

            fCompanies = New frmCompanies(Domain.CompanyRepository.TgCompanies)
            fCompanies.ShowDialog()



        Catch ex As Exception
            ex.ToString()
        End Try

    End Sub
End Class
