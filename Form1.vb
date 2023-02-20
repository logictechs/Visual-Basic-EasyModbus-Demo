
Imports System.IO.Ports
Imports EasyModbus

Public Class Form1

    Dim ModbusClient As EasyModbus.ModbusClient

    Private Sub connect_btn_Click(sender As Object, e As EventArgs) Handles connect_btn.Click
        connect_btn.Enabled = False
        disconnect_btn.Enabled = True
        If ipaddress_txt_bx.Text = "" Then
            MessageBox.Show("Enter an IP address first!")
            connect_btn.Enabled = True
            disconnect_btn.Enabled = False
            Return
        End If
        ModbusClient = New EasyModbus.ModbusClient(ipaddress_txt_bx.Text, modbusport_txt_bx.Text)
        ModbusClient.ConnectionTimeout = 5000
        ModbusClient.NumberOfRetries = 5
        Try
            ModbusClient.Connect()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            connect_btn.Enabled = True
            disconnect_btn.Enabled = False
            Return
        End Try



    End Sub

    Private Sub disconnect_btn_Click(sender As Object, e As EventArgs) Handles disconnect_btn.Click

        Try
            ModbusClient.Disconnect()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        connect_btn.Enabled = True
        disconnect_btn.Enabled = False
    End Sub

    Private Sub ipaddress_txt_bx_TextChanged(sender As Object, e As EventArgs) Handles ipaddress_txt_bx.TextChanged
        If ipaddress_txt_bx.Text = "" And modbusport_txt_bx.Text = "" Then
            connect_btn.Enabled = False
            connect_btn.Update()
        Else
            connect_btn.Enabled = True
            connect_btn.Update()
        End If
    End Sub

    Private Sub modbusport_txt_bx_TextChanged(sender As Object, e As EventArgs) Handles modbusport_txt_bx.TextChanged
        If modbusport_txt_bx.Text = "" And ipaddress_txt_bx.Text = "" Then
            connect_btn.Enabled = False
            connect_btn.Update()
        Else
            connect_btn.Enabled = True
            connect_btn.Update()
        End If
    End Sub

    Private Sub tx_holding_btn_Click(sender As Object, e As EventArgs) Handles tx_holding_btn.Click
        If holding_reg_addr_txt_bx.Text = "" Or holding_value_txt_bx.Text = "" Then
            MessageBox.Show("Enter all holding register values first!")
            Return
        End If
        If ModbusClient.Connected = False Then
            MessageBox.Show("Connect to Modbus server first!")
            Return
        End If

        Try
            ModbusClient.WriteSingleRegister(holding_reg_addr_txt_bx.Text, holding_value_txt_bx.Text)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub

    Private Sub rx_holding_btn_Click(sender As Object, e As EventArgs) Handles rx_holding_btn.Click
        If holding_reg_addr_txt_bx.Text = "" Then
            MessageBox.Show("Enter all holding register address first!")
            Return
        End If
        If ModbusClient.Connected = False Then
            MessageBox.Show("Connect to Modbus server first!")
            Return
        End If

        Try
            Dim rxdvalue() As Integer = ModbusClient.ReadHoldingRegisters(holding_reg_addr_txt_bx.Text, 1)
            holding_value_txt_bx.Text = rxdvalue(0).ToString
            holding_reg_addr_txt_bx.Update()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub send_coil_btn_Click(sender As Object, e As EventArgs) Handles send_coil_btn.Click
        If coil_reg_address_txt_bx.Text = "" Then
            MessageBox.Show("Enter all coil register address first!")
            Return
        End If
        If ModbusClient.Connected = False Then
            MessageBox.Show("Connect to Modbus server first!")
            Return
        End If

        Try
            ModbusClient.WriteSingleCoil(coil_reg_address_txt_bx.Text, server_coil_value_chk_bx.Checked)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub rx_coil_btn_Click(sender As Object, e As EventArgs) Handles rx_coil_btn.Click
        If coil_reg_address_txt_bx.Text = "" Then
            MessageBox.Show("Enter all coil register address first!")
            Return
        End If
        If ModbusClient.Connected = False Then
            MessageBox.Show("Connect to Modbus server first!")
            Return
        End If

        Try
            Dim rxdcoil() As Boolean = ModbusClient.ReadCoils(coil_reg_address_txt_bx.Text, 1)
            server_coil_value_chk_bx.Checked = rxdcoil(0)
            server_coil_value_chk_bx.Update()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
