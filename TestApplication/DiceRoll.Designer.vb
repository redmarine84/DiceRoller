<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DiceRoll
    Inherits Telerik.WinControls.UI.RadForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiceRoll))
        Me.roll1d4Btn = New Telerik.WinControls.UI.RadButton()
        Me.roll1d6Btn = New Telerik.WinControls.UI.RadButton()
        Me.roll1d8Btn = New Telerik.WinControls.UI.RadButton()
        Me.roll1d10Btn = New Telerik.WinControls.UI.RadButton()
        Me.rollPercentageBtn = New Telerik.WinControls.UI.RadButton()
        Me.roll1d20Btn = New Telerik.WinControls.UI.RadButton()
        Me.rbtnClose = New Telerik.WinControls.UI.RadButton()
        Me.rpanDiceNum = New Telerik.WinControls.UI.RadPanel()
        Me.rtxtRoll = New Telerik.WinControls.UI.RadTextBox()
        Me.rpanLogo = New Telerik.WinControls.UI.RadPanel()
        Me.rbtnTotalRoll = New Telerik.WinControls.UI.RadButton()
        Me.rTxtTotalRoll = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.rpanTotalDiceRoll = New Telerik.WinControls.UI.RadPanel()
        Me.rtxtDiceRolled = New Telerik.WinControls.UI.RadTextBox()
        Me.rlabDiceRolled = New Telerik.WinControls.UI.RadLabel()
        Me.rollAdvantageBtn = New Telerik.WinControls.UI.RadButton()
        Me.rollDisadvantageBtn = New Telerik.WinControls.UI.RadButton()
        Me.d4ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.d6ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.d8ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.d10ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.PercentileImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.d20ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.rlabDice = New Telerik.WinControls.UI.RadLabel()
        Me.tmrDice = New System.Windows.Forms.Timer(Me.components)
        CType(Me.roll1d4Btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.roll1d6Btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.roll1d8Btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.roll1d10Btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rollPercentageBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.roll1d20Btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpanDiceNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rpanDiceNum.SuspendLayout()
        CType(Me.rtxtRoll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpanLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbtnTotalRoll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rTxtTotalRoll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpanTotalDiceRoll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rpanTotalDiceRoll.SuspendLayout()
        CType(Me.rtxtDiceRolled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rlabDiceRolled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rollAdvantageBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rollDisadvantageBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rlabDice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'roll1d4Btn
        '
        Me.roll1d4Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roll1d4Btn.Location = New System.Drawing.Point(200, 57)
        Me.roll1d4Btn.Name = "roll1d4Btn"
        Me.roll1d4Btn.Size = New System.Drawing.Size(110, 24)
        Me.roll1d4Btn.TabIndex = 0
        Me.roll1d4Btn.Text = "1 d 4"
        '
        'roll1d6Btn
        '
        Me.roll1d6Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roll1d6Btn.Location = New System.Drawing.Point(200, 96)
        Me.roll1d6Btn.Name = "roll1d6Btn"
        Me.roll1d6Btn.Size = New System.Drawing.Size(110, 24)
        Me.roll1d6Btn.TabIndex = 1
        Me.roll1d6Btn.Text = "1 d 6"
        '
        'roll1d8Btn
        '
        Me.roll1d8Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roll1d8Btn.Location = New System.Drawing.Point(200, 135)
        Me.roll1d8Btn.Name = "roll1d8Btn"
        Me.roll1d8Btn.Size = New System.Drawing.Size(110, 24)
        Me.roll1d8Btn.TabIndex = 2
        Me.roll1d8Btn.Text = "1 d 8"
        '
        'roll1d10Btn
        '
        Me.roll1d10Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roll1d10Btn.Location = New System.Drawing.Point(200, 174)
        Me.roll1d10Btn.Name = "roll1d10Btn"
        Me.roll1d10Btn.Size = New System.Drawing.Size(110, 24)
        Me.roll1d10Btn.TabIndex = 2
        Me.roll1d10Btn.Text = "1 d 10"
        '
        'rollPercentageBtn
        '
        Me.rollPercentageBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rollPercentageBtn.Location = New System.Drawing.Point(200, 252)
        Me.rollPercentageBtn.Name = "rollPercentageBtn"
        Me.rollPercentageBtn.Size = New System.Drawing.Size(110, 24)
        Me.rollPercentageBtn.TabIndex = 2
        Me.rollPercentageBtn.Text = "Percentage"
        '
        'roll1d20Btn
        '
        Me.roll1d20Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roll1d20Btn.Location = New System.Drawing.Point(200, 213)
        Me.roll1d20Btn.Name = "roll1d20Btn"
        Me.roll1d20Btn.Size = New System.Drawing.Size(110, 24)
        Me.roll1d20Btn.TabIndex = 2
        Me.roll1d20Btn.Text = "1 d 20"
        '
        'rbtnClose
        '
        Me.rbtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbtnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnClose.ForeColor = System.Drawing.Color.White
        Me.rbtnClose.Location = New System.Drawing.Point(201, 12)
        Me.rbtnClose.Name = "rbtnClose"
        Me.rbtnClose.Size = New System.Drawing.Size(110, 24)
        Me.rbtnClose.TabIndex = 5
        Me.rbtnClose.Text = "CLOSE"
        '
        'rpanDiceNum
        '
        Me.rpanDiceNum.Controls.Add(Me.rtxtRoll)
        Me.rpanDiceNum.Location = New System.Drawing.Point(12, 192)
        Me.rpanDiceNum.Name = "rpanDiceNum"
        Me.rpanDiceNum.Size = New System.Drawing.Size(173, 95)
        Me.rpanDiceNum.TabIndex = 6
        Me.rpanDiceNum.Visible = False
        '
        'rtxtRoll
        '
        Me.rtxtRoll.BackColor = System.Drawing.Color.Black
        Me.rtxtRoll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtxtRoll.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtRoll.ForeColor = System.Drawing.Color.White
        Me.rtxtRoll.Location = New System.Drawing.Point(0, 0)
        Me.rtxtRoll.Name = "rtxtRoll"
        Me.rtxtRoll.ReadOnly = True
        Me.rtxtRoll.Size = New System.Drawing.Size(173, 95)
        Me.rtxtRoll.TabIndex = 5
        Me.rtxtRoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rpanLogo
        '
        Me.rpanLogo.BackColor = System.Drawing.Color.Transparent
        Me.rpanLogo.BackgroundImage = CType(resources.GetObject("rpanLogo.BackgroundImage"), System.Drawing.Image)
        Me.rpanLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rpanLogo.ForeColor = System.Drawing.Color.Transparent
        Me.rpanLogo.Location = New System.Drawing.Point(333, 12)
        Me.rpanLogo.Name = "rpanLogo"
        Me.rpanLogo.Size = New System.Drawing.Size(502, 473)
        Me.rpanLogo.TabIndex = 7
        '
        'rbtnTotalRoll
        '
        Me.rbtnTotalRoll.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnTotalRoll.Location = New System.Drawing.Point(201, 430)
        Me.rbtnTotalRoll.Name = "rbtnTotalRoll"
        Me.rbtnTotalRoll.Size = New System.Drawing.Size(110, 24)
        Me.rbtnTotalRoll.TabIndex = 8
        Me.rbtnTotalRoll.Text = "Dice Total"
        '
        'rTxtTotalRoll
        '
        Me.rTxtTotalRoll.BackColor = System.Drawing.Color.Black
        Me.rTxtTotalRoll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rTxtTotalRoll.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rTxtTotalRoll.ForeColor = System.Drawing.Color.White
        Me.rTxtTotalRoll.Location = New System.Drawing.Point(0, 0)
        Me.rTxtTotalRoll.Name = "rTxtTotalRoll"
        Me.rTxtTotalRoll.Size = New System.Drawing.Size(173, 94)
        Me.rTxtTotalRoll.TabIndex = 9
        Me.rTxtTotalRoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rpanTotalDiceRoll
        '
        Me.rpanTotalDiceRoll.BackColor = System.Drawing.Color.Black
        Me.rpanTotalDiceRoll.Controls.Add(Me.rTxtTotalRoll)
        Me.rpanTotalDiceRoll.Location = New System.Drawing.Point(12, 390)
        Me.rpanTotalDiceRoll.Name = "rpanTotalDiceRoll"
        Me.rpanTotalDiceRoll.Size = New System.Drawing.Size(173, 94)
        Me.rpanTotalDiceRoll.TabIndex = 10
        '
        'rtxtDiceRolled
        '
        Me.rtxtDiceRolled.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtDiceRolled.Location = New System.Drawing.Point(270, 387)
        Me.rtxtDiceRolled.Name = "rtxtDiceRolled"
        Me.rtxtDiceRolled.Size = New System.Drawing.Size(35, 31)
        Me.rtxtDiceRolled.TabIndex = 11
        Me.rtxtDiceRolled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rlabDiceRolled
        '
        Me.rlabDiceRolled.ForeColor = System.Drawing.Color.White
        Me.rlabDiceRolled.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.rlabDiceRolled.Location = New System.Drawing.Point(201, 392)
        Me.rlabDiceRolled.Name = "rlabDiceRolled"
        Me.rlabDiceRolled.Size = New System.Drawing.Size(63, 18)
        Me.rlabDiceRolled.TabIndex = 12
        Me.rlabDiceRolled.Text = "Dice Rolled"
        Me.rlabDiceRolled.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'rollAdvantageBtn
        '
        Me.rollAdvantageBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rollAdvantageBtn.Location = New System.Drawing.Point(188, 291)
        Me.rollAdvantageBtn.Name = "rollAdvantageBtn"
        Me.rollAdvantageBtn.Size = New System.Drawing.Size(122, 24)
        Me.rollAdvantageBtn.TabIndex = 13
        Me.rollAdvantageBtn.Text = "Advantage"
        '
        'rollDisadvantageBtn
        '
        Me.rollDisadvantageBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rollDisadvantageBtn.Location = New System.Drawing.Point(188, 330)
        Me.rollDisadvantageBtn.Name = "rollDisadvantageBtn"
        Me.rollDisadvantageBtn.Size = New System.Drawing.Size(122, 24)
        Me.rollDisadvantageBtn.TabIndex = 3
        Me.rollDisadvantageBtn.Text = "Disadvantage"
        '
        'd4ImageList
        '
        Me.d4ImageList.ImageStream = CType(resources.GetObject("d4ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.d4ImageList.TransparentColor = System.Drawing.Color.Black
        Me.d4ImageList.Images.SetKeyName(0, "d4Side1.png")
        Me.d4ImageList.Images.SetKeyName(1, "d4Side2.png")
        Me.d4ImageList.Images.SetKeyName(2, "d4Side3.png")
        Me.d4ImageList.Images.SetKeyName(3, "d4Side4.png")
        '
        'd6ImageList
        '
        Me.d6ImageList.ImageStream = CType(resources.GetObject("d6ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.d6ImageList.TransparentColor = System.Drawing.Color.Black
        Me.d6ImageList.Images.SetKeyName(0, "d6Side1.png")
        Me.d6ImageList.Images.SetKeyName(1, "d6Side2.png")
        Me.d6ImageList.Images.SetKeyName(2, "d6Side3.png")
        Me.d6ImageList.Images.SetKeyName(3, "d6Side4.png")
        Me.d6ImageList.Images.SetKeyName(4, "d6Side5.png")
        Me.d6ImageList.Images.SetKeyName(5, "d6Side6.png")
        '
        'd8ImageList
        '
        Me.d8ImageList.ImageStream = CType(resources.GetObject("d8ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.d8ImageList.TransparentColor = System.Drawing.Color.Black
        Me.d8ImageList.Images.SetKeyName(0, "d8Side1.png")
        Me.d8ImageList.Images.SetKeyName(1, "d8Side2.png")
        Me.d8ImageList.Images.SetKeyName(2, "d8Side3.png")
        Me.d8ImageList.Images.SetKeyName(3, "d8Side4.png")
        Me.d8ImageList.Images.SetKeyName(4, "d8Side5.png")
        Me.d8ImageList.Images.SetKeyName(5, "d8Side6.png")
        Me.d8ImageList.Images.SetKeyName(6, "d8Side7.png")
        Me.d8ImageList.Images.SetKeyName(7, "d8Side8.png")
        '
        'd10ImageList
        '
        Me.d10ImageList.ImageStream = CType(resources.GetObject("d10ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.d10ImageList.TransparentColor = System.Drawing.Color.Black
        Me.d10ImageList.Images.SetKeyName(0, "d10Side1.png")
        Me.d10ImageList.Images.SetKeyName(1, "d10Side2.png")
        Me.d10ImageList.Images.SetKeyName(2, "d10Side3.png")
        Me.d10ImageList.Images.SetKeyName(3, "d10Side4.png")
        Me.d10ImageList.Images.SetKeyName(4, "d10Side5.png")
        Me.d10ImageList.Images.SetKeyName(5, "d10Side6.png")
        Me.d10ImageList.Images.SetKeyName(6, "d10Side7.png")
        Me.d10ImageList.Images.SetKeyName(7, "d10Side8.png")
        Me.d10ImageList.Images.SetKeyName(8, "d10Side9.png")
        Me.d10ImageList.Images.SetKeyName(9, "d10Side10.png")
        '
        'PercentileImageList
        '
        Me.PercentileImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.PercentileImageList.ImageSize = New System.Drawing.Size(128, 128)
        Me.PercentileImageList.TransparentColor = System.Drawing.Color.Black
        '
        'd20ImageList
        '
        Me.d20ImageList.ImageStream = CType(resources.GetObject("d20ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.d20ImageList.TransparentColor = System.Drawing.Color.Black
        Me.d20ImageList.Images.SetKeyName(0, "d20Side1.png")
        Me.d20ImageList.Images.SetKeyName(1, "d20Side2.png")
        Me.d20ImageList.Images.SetKeyName(2, "d20Side3.png")
        Me.d20ImageList.Images.SetKeyName(3, "d20Side4.png")
        Me.d20ImageList.Images.SetKeyName(4, "d20Side5.png")
        Me.d20ImageList.Images.SetKeyName(5, "d20Side6.png")
        Me.d20ImageList.Images.SetKeyName(6, "d20Side7.png")
        Me.d20ImageList.Images.SetKeyName(7, "d20Side8.png")
        Me.d20ImageList.Images.SetKeyName(8, "d20Side9.png")
        Me.d20ImageList.Images.SetKeyName(9, "d20Side10.png")
        Me.d20ImageList.Images.SetKeyName(10, "d20Side11.png")
        Me.d20ImageList.Images.SetKeyName(11, "d20Side12.png")
        Me.d20ImageList.Images.SetKeyName(12, "d20Side13.png")
        Me.d20ImageList.Images.SetKeyName(13, "d20Side14.png")
        Me.d20ImageList.Images.SetKeyName(14, "d20Side15.png")
        Me.d20ImageList.Images.SetKeyName(15, "d20Side16.png")
        Me.d20ImageList.Images.SetKeyName(16, "d20Side17.png")
        Me.d20ImageList.Images.SetKeyName(17, "d20Side18.png")
        Me.d20ImageList.Images.SetKeyName(18, "d20Side19.png")
        Me.d20ImageList.Images.SetKeyName(19, "d20Side20.png")
        '
        'rlabDice
        '
        Me.rlabDice.AutoSize = False
        Me.rlabDice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rlabDice.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.rlabDice.Location = New System.Drawing.Point(12, 125)
        Me.rlabDice.Name = "rlabDice"
        Me.rlabDice.Size = New System.Drawing.Size(173, 162)
        Me.rlabDice.TabIndex = 14
        '
        'tmrDice
        '
        '
        'DiceRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(844, 497)
        Me.Controls.Add(Me.rlabDice)
        Me.Controls.Add(Me.rollDisadvantageBtn)
        Me.Controls.Add(Me.rollAdvantageBtn)
        Me.Controls.Add(Me.rlabDiceRolled)
        Me.Controls.Add(Me.rtxtDiceRolled)
        Me.Controls.Add(Me.rpanTotalDiceRoll)
        Me.Controls.Add(Me.rbtnTotalRoll)
        Me.Controls.Add(Me.rpanLogo)
        Me.Controls.Add(Me.rpanDiceNum)
        Me.Controls.Add(Me.rbtnClose)
        Me.Controls.Add(Me.roll1d20Btn)
        Me.Controls.Add(Me.rollPercentageBtn)
        Me.Controls.Add(Me.roll1d10Btn)
        Me.Controls.Add(Me.roll1d8Btn)
        Me.Controls.Add(Me.roll1d6Btn)
        Me.Controls.Add(Me.roll1d4Btn)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DiceRoll"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DnD Dice Roll"
        CType(Me.roll1d4Btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.roll1d6Btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.roll1d8Btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.roll1d10Btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rollPercentageBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.roll1d20Btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpanDiceNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rpanDiceNum.ResumeLayout(False)
        Me.rpanDiceNum.PerformLayout()
        CType(Me.rtxtRoll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpanLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbtnTotalRoll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rTxtTotalRoll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpanTotalDiceRoll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rpanTotalDiceRoll.ResumeLayout(False)
        Me.rpanTotalDiceRoll.PerformLayout()
        CType(Me.rtxtDiceRolled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rlabDiceRolled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rollAdvantageBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rollDisadvantageBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rlabDice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents roll1d4Btn As Telerik.WinControls.UI.RadButton
    Friend WithEvents roll1d6Btn As Telerik.WinControls.UI.RadButton
    Friend WithEvents roll1d8Btn As Telerik.WinControls.UI.RadButton
    Friend WithEvents roll1d10Btn As Telerik.WinControls.UI.RadButton
    Friend WithEvents rollPercentageBtn As Telerik.WinControls.UI.RadButton
    Friend WithEvents roll1d20Btn As Telerik.WinControls.UI.RadButton
    Friend WithEvents rbtnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents rpanDiceNum As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rtxtRoll As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents rpanLogo As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rbtnTotalRoll As Telerik.WinControls.UI.RadButton
    Friend WithEvents rTxtTotalRoll As Telerik.WinControls.UI.RadButtonTextBox
    Friend WithEvents rpanTotalDiceRoll As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rtxtDiceRolled As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents rlabDiceRolled As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rollAdvantageBtn As Telerik.WinControls.UI.RadButton
    Friend WithEvents rollDisadvantageBtn As Telerik.WinControls.UI.RadButton
    Friend WithEvents d4ImageList As ImageList
    Friend WithEvents d6ImageList As ImageList
    Friend WithEvents d8ImageList As ImageList
    Friend WithEvents d10ImageList As ImageList
    Friend WithEvents PercentileImageList As ImageList
    Friend WithEvents d20ImageList As ImageList
    Friend WithEvents rlabDice As Telerik.WinControls.UI.RadLabel
    Friend WithEvents tmrDice As Timer
End Class
