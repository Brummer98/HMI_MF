﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
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
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.QuickStartLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDB = New System.Windows.Forms.Label()
        Me.btnSendTagData = New System.Windows.Forms.Button()
        Me.btnUpdateTag = New System.Windows.Forms.Button()
        Me.btnRetrieveData = New System.Windows.Forms.Button()
        Me.AnalogValueDisplay1 = New AdvancedHMIControls.AnalogValueDisplay()
        Me.EthernetIPforCLXCom1 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.kbiTag = New AdvancedHMIControls.KeyboardInput()
        Me.DPMTag = New AdvancedHMIControls.DigitalPanelMeter()
        Me.EthernetIPforCLXCom2 = New AdvancedHMIDrivers.EthernetIPforCLXCom(Me.components)
        Me.lblTagText = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EthernetIPforCLXCom2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 662)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 13)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "www.advancedhmi.com"
        Me.Label7.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 13)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "6) Run the application (F5)"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(235, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "5) Set one of the PLCAddress properties"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(273, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "4) Add a visual control (e.g. DigitalPanelMeter)"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(218, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "3) Set properties of driver component"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "2) Add a driver component from the Toolbox"
        Me.Label2.Visible = False
        '
        'QuickStartLabel
        '
        Me.QuickStartLabel.AutoSize = True
        Me.QuickStartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.QuickStartLabel.ForeColor = System.Drawing.Color.White
        Me.QuickStartLabel.Location = New System.Drawing.Point(12, 10)
        Me.QuickStartLabel.Name = "QuickStartLabel"
        Me.QuickStartLabel.Size = New System.Drawing.Size(194, 13)
        Me.QuickStartLabel.TabIndex = 62
        Me.QuickStartLabel.Text = "1) Build the project (Ctrl+Shift+B)"
        Me.QuickStartLabel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.AdvancedHMILogoBR
        Me.PictureBox1.Location = New System.Drawing.Point(615, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'lblDB
        '
        Me.lblDB.AutoSize = True
        Me.lblDB.ForeColor = System.Drawing.Color.White
        Me.lblDB.Location = New System.Drawing.Point(474, 104)
        Me.lblDB.Name = "lblDB"
        Me.lblDB.Size = New System.Drawing.Size(20, 18)
        Me.lblDB.TabIndex = 72
        Me.lblDB.Text = "..."
        '
        'btnSendTagData
        '
        Me.btnSendTagData.Location = New System.Drawing.Point(12, 328)
        Me.btnSendTagData.Name = "btnSendTagData"
        Me.btnSendTagData.Size = New System.Drawing.Size(134, 51)
        Me.btnSendTagData.TabIndex = 73
        Me.btnSendTagData.Text = "Save Tag to DB"
        Me.btnSendTagData.UseVisualStyleBackColor = True
        '
        'btnUpdateTag
        '
        Me.btnUpdateTag.Location = New System.Drawing.Point(12, 385)
        Me.btnUpdateTag.Name = "btnUpdateTag"
        Me.btnUpdateTag.Size = New System.Drawing.Size(134, 51)
        Me.btnUpdateTag.TabIndex = 74
        Me.btnUpdateTag.Text = "Update tag in DB"
        Me.btnUpdateTag.UseVisualStyleBackColor = True
        '
        'btnRetrieveData
        '
        Me.btnRetrieveData.Location = New System.Drawing.Point(12, 442)
        Me.btnRetrieveData.Name = "btnRetrieveData"
        Me.btnRetrieveData.Size = New System.Drawing.Size(134, 51)
        Me.btnRetrieveData.TabIndex = 78
        Me.btnRetrieveData.Text = "Retrieve data BD"
        Me.btnRetrieveData.UseVisualStyleBackColor = True
        '
        'AnalogValueDisplay1
        '
        Me.AnalogValueDisplay1.AutoSize = True
        Me.AnalogValueDisplay1.ComComponent = Me.EthernetIPforCLXCom1
        Me.AnalogValueDisplay1.ForeColor = System.Drawing.Color.White
        Me.AnalogValueDisplay1.ForeColorInLimits = System.Drawing.Color.White
        Me.AnalogValueDisplay1.ForeColorOverLimit = System.Drawing.Color.Red
        Me.AnalogValueDisplay1.ForeColorUnderLimit = System.Drawing.Color.Yellow
        Me.AnalogValueDisplay1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.AnalogValueDisplay1.KeypadMaxValue = 0R
        Me.AnalogValueDisplay1.KeypadMinValue = 0R
        Me.AnalogValueDisplay1.KeypadPasscode = Nothing
        Me.AnalogValueDisplay1.KeypadScaleFactor = 1.0R
        Me.AnalogValueDisplay1.KeypadText = Nothing
        Me.AnalogValueDisplay1.KeypadWidth = 300
        Me.AnalogValueDisplay1.Location = New System.Drawing.Point(723, 104)
        Me.AnalogValueDisplay1.Name = "AnalogValueDisplay1"
        Me.AnalogValueDisplay1.NumericFormat = Nothing
        Me.AnalogValueDisplay1.PLCAddressKeypad = ""
        Me.AnalogValueDisplay1.PLCAddressValue = CType(resources.GetObject("AnalogValueDisplay1.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.AnalogValueDisplay1.PLCAddressValueLimitLower = Nothing
        Me.AnalogValueDisplay1.PLCAddressValueLimitUpper = Nothing
        Me.AnalogValueDisplay1.PLCAddressVisible = Nothing
        Me.AnalogValueDisplay1.ShowValue = True
        Me.AnalogValueDisplay1.Size = New System.Drawing.Size(44, 18)
        Me.AnalogValueDisplay1.TabIndex = 77
        Me.AnalogValueDisplay1.Text = "0000"
        Me.AnalogValueDisplay1.Value = "0000"
        Me.AnalogValueDisplay1.ValueLimitLower = -999999.0R
        Me.AnalogValueDisplay1.ValueLimitUpper = 999999.0R
        Me.AnalogValueDisplay1.ValuePrefix = Nothing
        Me.AnalogValueDisplay1.ValueSuffix = Nothing
        Me.AnalogValueDisplay1.VisibleControl = AdvancedHMIControls.AnalogValueDisplay.VisibleControlEnum.Always
        '
        'EthernetIPforCLXCom1
        '
        Me.EthernetIPforCLXCom1.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom1.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom1.DisableSubscriptions = False
        Me.EthernetIPforCLXCom1.IniFileName = ""
        Me.EthernetIPforCLXCom1.IniFileSection = Nothing
        Me.EthernetIPforCLXCom1.IPAddress = "192.168.8.50"
        Me.EthernetIPforCLXCom1.PollRateOverride = 500
        Me.EthernetIPforCLXCom1.Port = 44818
        Me.EthernetIPforCLXCom1.ProcessorSlot = 1
        Me.EthernetIPforCLXCom1.RoutePath = Nothing
        Me.EthernetIPforCLXCom1.Timeout = 4000
        '
        'kbiTag
        '
        Me.kbiTag.ClearAfterEnterKey = True
        Me.kbiTag.ComComponent = Me.EthernetIPforCLXCom1
        Me.kbiTag.GetFocusMatchValue = 1
        Me.kbiTag.GetFocusValue = 0
        Me.kbiTag.Location = New System.Drawing.Point(336, 398)
        Me.kbiTag.Name = "kbiTag"
        Me.kbiTag.PLCAddressGetFocusValue = Nothing
        Me.kbiTag.PLCAddressWriteValue = CType(resources.GetObject("kbiTag.PLCAddressWriteValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.kbiTag.Size = New System.Drawing.Size(295, 26)
        Me.kbiTag.TabIndex = 71
        '
        'DPMTag
        '
        Me.DPMTag.BackColor = System.Drawing.Color.Transparent
        Me.DPMTag.ComComponent = Me.EthernetIPforCLXCom1
        Me.DPMTag.DecimalPosition = 0
        Me.DPMTag.ForeColor = System.Drawing.Color.LightGray
        Me.DPMTag.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DPMTag.KeypadMaxValue = 0R
        Me.DPMTag.KeypadMinValue = 0R
        Me.DPMTag.KeypadScaleFactor = 1.0R
        Me.DPMTag.KeypadText = Nothing
        Me.DPMTag.KeypadWidth = 300
        Me.DPMTag.Location = New System.Drawing.Point(336, 219)
        Me.DPMTag.Name = "DPMTag"
        Me.DPMTag.NumberOfDigits = 5
        Me.DPMTag.PLCAddressKeypad = ""
        Me.DPMTag.PLCAddressText = "TestTagInt"
        Me.DPMTag.PLCAddressValue = "TestTagInt"
        Me.DPMTag.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DPMTag.Size = New System.Drawing.Size(295, 128)
        Me.DPMTag.TabIndex = 70
        Me.DPMTag.Text = "DPMTag"
        Me.DPMTag.Value = 0R
        Me.DPMTag.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DPMTag.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'EthernetIPforCLXCom2
        '
        Me.EthernetIPforCLXCom2.CIPConnectionSize = 508
        Me.EthernetIPforCLXCom2.DisableMultiServiceRequest = False
        Me.EthernetIPforCLXCom2.DisableSubscriptions = False
        Me.EthernetIPforCLXCom2.IniFileName = ""
        Me.EthernetIPforCLXCom2.IniFileSection = Nothing
        Me.EthernetIPforCLXCom2.IPAddress = "192.168.0.10"
        Me.EthernetIPforCLXCom2.PollRateOverride = 500
        Me.EthernetIPforCLXCom2.Port = 44818
        Me.EthernetIPforCLXCom2.ProcessorSlot = 0
        Me.EthernetIPforCLXCom2.RoutePath = Nothing
        Me.EthernetIPforCLXCom2.Timeout = 4000
        '
        'lblTagText
        '
        Me.lblTagText.AutoSize = True
        Me.lblTagText.ForeColor = System.Drawing.Color.White
        Me.lblTagText.Location = New System.Drawing.Point(400, 361)
        Me.lblTagText.Name = "lblTagText"
        Me.lblTagText.Size = New System.Drawing.Size(171, 18)
        Me.lblTagText.TabIndex = 79
        Me.lblTagText.Text = "Tag: TestTagInt ( TEST )"
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(949, 561)
        Me.Controls.Add(Me.lblTagText)
        Me.Controls.Add(Me.btnRetrieveData)
        Me.Controls.Add(Me.btnUpdateTag)
        Me.Controls.Add(Me.btnSendTagData)
        Me.Controls.Add(Me.lblDB)
        Me.Controls.Add(Me.kbiTag)
        Me.Controls.Add(Me.DPMTag)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.QuickStartLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AdvancedHMI v3.99x"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EthernetIPforCLXCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EthernetIPforCLXCom2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents QuickStartLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EthernetIPforCLXCom1 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents DPMTag As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents kbiTag As AdvancedHMIControls.KeyboardInput
    Friend WithEvents lblDB As Label
    Friend WithEvents btnSendTagData As Button
    Friend WithEvents btnUpdateTag As Button
    Friend WithEvents EthernetIPforCLXCom2 As AdvancedHMIDrivers.EthernetIPforCLXCom
    Friend WithEvents AnalogValueDisplay1 As AdvancedHMIControls.AnalogValueDisplay
    Friend WithEvents btnRetrieveData As Button
    Friend WithEvents lblTagText As Label
End Class
