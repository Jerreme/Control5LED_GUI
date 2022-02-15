Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Timer1.Start()
    End Sub

    Dim primary_col As Color = Color.FromArgb(54, 115, 169)
    Dim active_col As Color = Color.FromArgb(121, 247, 159)
    Dim inactive_col As Color = Color.DarkGray

    Dim comPort As String = ""
    Dim prevComPort As String = ""
    Dim connected As Boolean = True
    Dim toggledAll As Boolean = False

    Sub connectComPort(comName As String)
        If (comName <> "") Then
            sp.PortName = comName
            sp.BaudRate = 9600

            Try
                If (sp.IsOpen) Then 'if com is open then close it
                    sp.Close()
                Else                'if com is close the open it then close
                    sp.Open()
                    sp.Close()
                End If
            Catch ex As Exception
                snackbar1.Show(
                    Me,
                     "Error Occured! @connectComPort",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error,
                    2000, "",
                    Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopCenter)
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
            If (Not connected Or Not comPort.Equals(prevComPort)) Then
                snackbar1.Show(
                    Me,
                    "Connected Succesfully",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success,
                    2000, "",
                    Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight)

                prevComPort = comPort
                connected = True
                comLabel.Text = comPort
                comLabel.ForeColor = primary_col
                Disable_All(False)
            End If

        Else
            If (connected) Then
                snackbar1.Show(
                    Me,
                    "Arduino Board has been Disconnected",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error,
                    2000, "",
                    Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopRight)

                connected = False
                comPort = ""
                comLabel.Text = "Not Connected"
                comLabel.ForeColor = Color.FromArgb(241, 74, 22)
                Disable_All(True)
            End If
        End If
    End Sub


    Sub Disable_All(state As Boolean)
        If (state) Then
            reset(True)
            toggle1.Enabled = False
            toggle2.Enabled = False
            toggle3.Enabled = False
            toggle4.Enabled = False
            toggle5.Enabled = False
            toggle6.Enabled = False
            toggle7.Enabled = False
            toggle8.Enabled = False

            toggle_all.Enabled = False
            turn_off_all.Enabled = False
        Else
            toggle1.Enabled = True
            toggle2.Enabled = True
            toggle3.Enabled = True
            toggle4.Enabled = True
            toggle5.Enabled = True
            toggle6.Enabled = True
            toggle7.Enabled = True
            toggle8.Enabled = True

            toggle_all.Enabled = True
            turn_off_all.Enabled = True
        End If
    End Sub

    Sub reset(state As Boolean)
        Dim col As Color
        Dim val As Boolean

        If state Then
            col = inactive_col
            val = False
        Else
            col = active_col
            val = True
        End If

        indicator1.BackColor = col
        indicator2.BackColor = col
        indicator3.BackColor = col
        indicator4.BackColor = col
        indicator5.BackColor = col

        toggle1.Checked = val
        toggle2.Checked = val
        toggle3.Checked = val
        toggle4.Checked = val
        toggle5.Checked = val
    End Sub

    Private Sub turn_off_all_Click(sender As Object, e As EventArgs) Handles turn_off_all.Click
        reset(True)
        indicator6.BackColor = inactive_col
        indicator7.BackColor = inactive_col
        indicator8.BackColor = inactive_col

        toggle6.Checked = False
        toggle7.Checked = False
        toggle8.Checked = False
        toggle_all.Checked = False
    End Sub

    Private Sub toggle_all_CheckedChanged(sender As Object, e As EventArgs) Handles toggle_all.CheckedChanged
        If (CType(sender, Guna.UI2.WinForms.Guna2ToggleSwitch).Checked) Then
            reset(False)
        Else
            reset(True)
        End If
    End Sub

    Sub sendData(sender As Object, indicator As Label, data_On As String, data_off As String)
        If (connected) Then
            Try
                If (CType(sender, Guna.UI2.WinForms.Guna2ToggleSwitch).Checked) Then
                    indicator.BackColor = active_col
                    sp.Open()
                    sp.Write(data_On)
                    sp.Close()
                Else
                    indicator.BackColor = inactive_col
                    sp.Open()
                    sp.Write(data_off)
                    sp.Close()
                End If
            Catch ex As Exception
                snackbar1.Show(
                    Me,
                    "Error Occured! @sendData",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error,
                    2000, "",
                    Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopCenter)

            End Try

        End If
    End Sub
    Private Sub toggle1_CheckedChanged(sender As Object, e As EventArgs) Handles toggle1.CheckedChanged
        sendData(sender, indicator1, "A", "a")
    End Sub

    Private Sub toggle2_CheckedChanged(sender As Object, e As EventArgs) Handles toggle2.CheckedChanged
        sendData(sender, indicator2, "B", "b")
    End Sub

    Private Sub toggle3_CheckedChanged(sender As Object, e As EventArgs) Handles toggle3.CheckedChanged
        sendData(sender, indicator3, "C", "c")
    End Sub

    Private Sub toggle4_CheckedChanged(sender As Object, e As EventArgs) Handles toggle4.CheckedChanged
        sendData(sender, indicator4, "D", "d")
    End Sub

    Private Sub toggle5_CheckedChanged(sender As Object, e As EventArgs) Handles toggle5.CheckedChanged
        sendData(sender, indicator5, "E", "e")
    End Sub

    Private Sub toggle6_CheckedChanged(sender As Object, e As EventArgs) Handles toggle6.CheckedChanged
        sendData(sender, indicator6, "F", "f")
    End Sub

    Private Sub toggle7_CheckedChanged(sender As Object, e As EventArgs) Handles toggle7.CheckedChanged
        sendData(sender, indicator7, "G", "g")
    End Sub

    Private Sub toggle8_CheckedChanged(sender As Object, e As EventArgs) Handles toggle8.CheckedChanged
        sendData(sender, indicator8, "H", "h")
    End Sub
End Class
