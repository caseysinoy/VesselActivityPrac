Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Module Mod_Utils
    ' Function to get the current server date (currently returns local system date)
    Function getServerDate() As Date
        'Dim dc As New DataClasses1DataContext
        'Return dc.GetDate
        Return Date.Now
    End Function

    ' Subroutine to configure a GridView for read-only display
    Public Sub gridTransMode(ByRef grid As GridView)
        Try
            grid.BestFitColumns() ' Auto-size columns to fit content
            grid.OptionsBehavior.Editable = False ' Make the grid non-editable
            grid.OptionsSelection.EnableAppearanceFocusedRow = True ' Enable focused row highlighting
            grid.Columns(0).Visible = False ' Hide the first column (often an ID column)
            grid.OptionsCustomization.AllowColumnMoving = False ' Disable column moving
        Catch ex As Exception
            ' Handle any exceptions silently
        End Try
    End Sub

    '================================== Validation Methods ==================================' 
    ' Function to validate a TextEdit control (with optional check for value greater than zero)
    Function validateField(ByRef control As TextEdit, Optional ByVal greaterThanZero As Boolean = False) As Boolean
        If greaterThanZero Then
            Return (Not control.Text = "") And (Val(control.Text) > 0)
        Else
            Return (Not control.Text = "")
        End If
    End Function

    ' Function to validate a LookUpEdit control
    Function validateField(ByRef control As LookUpEdit) As Boolean
        Return (Not control.EditValue Is Nothing)
    End Function

    ' Function to validate a DateEdit control
    Function validateField(ByRef control As DateEdit) As Boolean
        Return (Not control.EditValue Is Nothing)
    End Function

    ' Function to validate a ComboBoxEdit control
    Function validateField(ByRef control As ComboBoxEdit) As Boolean
        Return (Not control.EditValue Is Nothing)
    End Function

    ' Function to validate a SpinEdit Control
    Function validateField(ByRef control As SpinEdit) As Boolean
        Return (Not control.EditValue Is Nothing)
    End Function


    ' Function to validate a SearchLookUpEdit control
    Function validateField(ByRef control As SearchLookUpEdit) As Boolean
        Return (Not control.EditValue Is Nothing)
    End Function
    '================================== Validation Methods =================================='

    '================================== MessageBox Methods =================================='
    ' Validate each field using the validation methods from Mod_Utils
    Sub RequiredMessage()
        XtraMessageBox.Show("Please fill in missing fields.", APPNAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Sub RequiredMessage(ByVal fields As String)
        XtraMessageBox.Show("Required fields: " + vbNewLine + fields, APPNAME, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
    Sub ErrorMessage(ByVal ex As Exception, Optional full As Boolean = False)
        If full Then
            XtraMessageBox.Show(ex.Message, APPNAME, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            XtraMessageBox.Show("An error occurred.", APPNAME, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'TODO: [Error Handling and Logging] handle if possible, log everything
    End Sub
    Sub ErrorMessage(ByVal msg As String)
        XtraMessageBox.Show(msg, APPNAME, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Function ConfirmVerifyMessage() As Boolean
        Return XtraMessageBox.Show("Verify and commit?", APPNAME, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes
    End Function
    '================================== End MessageBox Methods ==================================' 

End Module
