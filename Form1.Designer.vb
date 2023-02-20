<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.connect_btn = New System.Windows.Forms.Button()
        Me.disconnect_btn = New System.Windows.Forms.Button()
        Me.ipaddress_txt_bx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.modbusport_txt_bx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.holding_reg_addr_txt_bx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.coil_reg_address_txt_bx = New System.Windows.Forms.TextBox()
        Me.server_coil_value_chk_bx = New System.Windows.Forms.CheckBox()
        Me.send_coil_btn = New System.Windows.Forms.Button()
        Me.rx_coil_btn = New System.Windows.Forms.Button()
        Me.holding_value_txt_bx = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tx_holding_btn = New System.Windows.Forms.Button()
        Me.rx_holding_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'connect_btn
        '
        Me.connect_btn.Enabled = False
        Me.connect_btn.Location = New System.Drawing.Point(118, 29)
        Me.connect_btn.Name = "connect_btn"
        Me.connect_btn.Size = New System.Drawing.Size(75, 23)
        Me.connect_btn.TabIndex = 0
        Me.connect_btn.Text = "&Connect"
        Me.connect_btn.UseVisualStyleBackColor = True
        '
        'disconnect_btn
        '
        Me.disconnect_btn.Enabled = False
        Me.disconnect_btn.Location = New System.Drawing.Point(199, 29)
        Me.disconnect_btn.Name = "disconnect_btn"
        Me.disconnect_btn.Size = New System.Drawing.Size(75, 23)
        Me.disconnect_btn.TabIndex = 1
        Me.disconnect_btn.Text = "&Disconnect"
        Me.disconnect_btn.UseVisualStyleBackColor = True
        '
        'ipaddress_txt_bx
        '
        Me.ipaddress_txt_bx.Location = New System.Drawing.Point(12, 29)
        Me.ipaddress_txt_bx.Name = "ipaddress_txt_bx"
        Me.ipaddress_txt_bx.Size = New System.Drawing.Size(100, 23)
        Me.ipaddress_txt_bx.TabIndex = 2
        Me.ipaddress_txt_bx.Text = "192.168.1.77"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "IP Address:"
        '
        'modbusport_txt_bx
        '
        Me.modbusport_txt_bx.Location = New System.Drawing.Point(12, 73)
        Me.modbusport_txt_bx.Name = "modbusport_txt_bx"
        Me.modbusport_txt_bx.Size = New System.Drawing.Size(100, 23)
        Me.modbusport_txt_bx.TabIndex = 4
        Me.modbusport_txt_bx.Text = "502"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Port:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Modbus Holding Register:"
        '
        'holding_reg_addr_txt_bx
        '
        Me.holding_reg_addr_txt_bx.Location = New System.Drawing.Point(12, 141)
        Me.holding_reg_addr_txt_bx.Name = "holding_reg_addr_txt_bx"
        Me.holding_reg_addr_txt_bx.Size = New System.Drawing.Size(100, 23)
        Me.holding_reg_addr_txt_bx.TabIndex = 7
        Me.holding_reg_addr_txt_bx.Text = "400001"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Modbus Coil Register:"
        '
        'coil_reg_address_txt_bx
        '
        Me.coil_reg_address_txt_bx.Location = New System.Drawing.Point(12, 216)
        Me.coil_reg_address_txt_bx.Name = "coil_reg_address_txt_bx"
        Me.coil_reg_address_txt_bx.Size = New System.Drawing.Size(100, 23)
        Me.coil_reg_address_txt_bx.TabIndex = 9
        Me.coil_reg_address_txt_bx.Text = "1"
        '
        'server_coil_value_chk_bx
        '
        Me.server_coil_value_chk_bx.AutoSize = True
        Me.server_coil_value_chk_bx.Location = New System.Drawing.Point(12, 254)
        Me.server_coil_value_chk_bx.Name = "server_coil_value_chk_bx"
        Me.server_coil_value_chk_bx.Size = New System.Drawing.Size(89, 19)
        Me.server_coil_value_chk_bx.TabIndex = 10
        Me.server_coil_value_chk_bx.Text = "Server Value"
        Me.server_coil_value_chk_bx.UseVisualStyleBackColor = True
        '
        'send_coil_btn
        '
        Me.send_coil_btn.Location = New System.Drawing.Point(118, 216)
        Me.send_coil_btn.Name = "send_coil_btn"
        Me.send_coil_btn.Size = New System.Drawing.Size(75, 23)
        Me.send_coil_btn.TabIndex = 11
        Me.send_coil_btn.Text = "TX Coil"
        Me.send_coil_btn.UseVisualStyleBackColor = True
        '
        'rx_coil_btn
        '
        Me.rx_coil_btn.Location = New System.Drawing.Point(199, 216)
        Me.rx_coil_btn.Name = "rx_coil_btn"
        Me.rx_coil_btn.Size = New System.Drawing.Size(75, 23)
        Me.rx_coil_btn.TabIndex = 12
        Me.rx_coil_btn.Text = "RX Coil"
        Me.rx_coil_btn.UseVisualStyleBackColor = True
        '
        'holding_value_txt_bx
        '
        Me.holding_value_txt_bx.Location = New System.Drawing.Point(174, 141)
        Me.holding_value_txt_bx.Name = "holding_value_txt_bx"
        Me.holding_value_txt_bx.Size = New System.Drawing.Size(100, 23)
        Me.holding_value_txt_bx.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(174, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Holding Register Value:"
        '
        'tx_holding_btn
        '
        Me.tx_holding_btn.Location = New System.Drawing.Point(280, 141)
        Me.tx_holding_btn.Name = "tx_holding_btn"
        Me.tx_holding_btn.Size = New System.Drawing.Size(75, 23)
        Me.tx_holding_btn.TabIndex = 15
        Me.tx_holding_btn.Text = "TX Holding"
        Me.tx_holding_btn.UseVisualStyleBackColor = True
        '
        'rx_holding_btn
        '
        Me.rx_holding_btn.Location = New System.Drawing.Point(361, 141)
        Me.rx_holding_btn.Name = "rx_holding_btn"
        Me.rx_holding_btn.Size = New System.Drawing.Size(75, 23)
        Me.rx_holding_btn.TabIndex = 16
        Me.rx_holding_btn.Text = "RX Holding"
        Me.rx_holding_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rx_holding_btn)
        Me.Controls.Add(Me.tx_holding_btn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.holding_value_txt_bx)
        Me.Controls.Add(Me.rx_coil_btn)
        Me.Controls.Add(Me.send_coil_btn)
        Me.Controls.Add(Me.server_coil_value_chk_bx)
        Me.Controls.Add(Me.coil_reg_address_txt_bx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.holding_reg_addr_txt_bx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.modbusport_txt_bx)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ipaddress_txt_bx)
        Me.Controls.Add(Me.disconnect_btn)
        Me.Controls.Add(Me.connect_btn)
        Me.Name = "Form1"
        Me.Text = "EasyModbus Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents connect_btn As Button
    Friend WithEvents disconnect_btn As Button
    Friend WithEvents ipaddress_txt_bx As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents modbusport_txt_bx As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents holding_reg_addr_txt_bx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents coil_reg_address_txt_bx As TextBox
    Friend WithEvents server_coil_value_chk_bx As CheckBox
    Friend WithEvents send_coil_btn As Button
    Friend WithEvents rx_coil_btn As Button
    Friend WithEvents holding_value_txt_bx As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tx_holding_btn As Button
    Friend WithEvents rx_holding_btn As Button
End Class
