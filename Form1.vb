Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim primary_col As Color = Color.FromArgb(54, 115, 169)

    Dim active_col As Color = Color.FromArgb(121, 247, 159)
    Dim inactive_col As Color = Color.Silver

    Dim comPort As String = ""
    Dim connected As Boolean = False

    Sub connectComPort(comName As String)
        If (comName <> "") Then
            SerialPort1.PortName = comName
            SerialPort1.BaudRate = 9600

            Try
                If (SerialPort1.IsOpen) Then 'if com is open then close it
                    SerialPort1.Close()
                Else                        'if com is close the open it then close
                    SerialPort1.Open()
                    SerialPort1.Close()
                End If
            Catch ex As Exception

            End Try

        End If
    End Sub
    Function checkComPort() As Boolean
        Dim detected As String = ""

        For Each names As String In My.Computer.Ports.SerialPortNames
            If (Not names.Equals("")) Then
                detected = names
            End If
        Next

        If (Not detected.Equals("")) Then
            If (Not detected.Equals(comPort)) Then
                comPort = detected
                'if comport has changed connect again
                connectComPort(detected)
            End If
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (checkComPort()) Then
            If (Not connected) Then
                snackbar1.Show(
                    Me,
                    "Connected Succesfully",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
                    2000, "",
                    Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight)
            End If

            connected = True
            comLabel.Text = comPort
            comLabel.ForeColor = primary_col
        Else
            If (connected) Then
                snackbar1.Show(
                    Me,
                    "Arduino Board has been Disconnected",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error,
                    2000, "",
                    Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight)
            End If

            connected = False
            comPort = ""
            comLabel.Text = "Not Connected"
            comLabel.ForeColor = Color.FromArgb(241, 74, 22)
        End If
    End Sub

    Private Sub toggle1_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs) Handles toggle1.CheckedChanged

    End Sub
End Class
