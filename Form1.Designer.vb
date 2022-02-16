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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.manualPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.toggle5 = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.indicator5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.toggle4 = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.indicator4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.toggle3 = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.indicator3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.toggle_all = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.toggle2 = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.indicator2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.toggle1 = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.indicator1 = New System.Windows.Forms.Label()
        Me.autoPanel = New Bunifu.UI.WinForms.BunifuPanel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.toggle7 = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.indicator7 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.toggle8 = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.indicator8 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.toggle6 = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.indicator6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.comLabel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.turn_off_all = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.sp = New System.IO.Ports.SerialPort(Me.components)
        Me.snackbar1 = New Bunifu.UI.WinForms.BunifuSnackbar(Me.components)
        Me.manualPanel.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.autoPanel.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LED 1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'manualPanel
        '
        Me.manualPanel.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.manualPanel.BackgroundImage = CType(resources.GetObject("manualPanel.BackgroundImage"), System.Drawing.Image)
        Me.manualPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.manualPanel.BorderColor = System.Drawing.Color.Transparent
        Me.manualPanel.BorderRadius = 18
        Me.manualPanel.BorderThickness = 1
        Me.manualPanel.Controls.Add(Me.Panel6)
        Me.manualPanel.Controls.Add(Me.Panel5)
        Me.manualPanel.Controls.Add(Me.Panel4)
        Me.manualPanel.Controls.Add(Me.Panel3)
        Me.manualPanel.Controls.Add(Me.Panel2)
        Me.manualPanel.Controls.Add(Me.Panel1)
        Me.manualPanel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.manualPanel.Location = New System.Drawing.Point(23, 116)
        Me.manualPanel.Name = "manualPanel"
        Me.manualPanel.ShowBorders = True
        Me.manualPanel.Size = New System.Drawing.Size(370, 290)
        Me.manualPanel.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.toggle5)
        Me.Panel6.Controls.Add(Me.indicator5)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Location = New System.Drawing.Point(0, 234)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(370, 45)
        Me.Panel6.TabIndex = 7
        '
        'toggle5
        '
        Me.toggle5.Animated = True
        Me.toggle5.AutoRoundedCorners = True
        Me.toggle5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggle5.CheckedState.BorderRadius = 8
        Me.toggle5.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggle5.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle5.CheckedState.InnerBorderRadius = 4
        Me.toggle5.CheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle5.CheckedState.Parent = Me.toggle5
        Me.toggle5.Location = New System.Drawing.Point(308, 13)
        Me.toggle5.Name = "toggle5"
        Me.toggle5.ShadowDecoration.Parent = Me.toggle5
        Me.toggle5.Size = New System.Drawing.Size(32, 18)
        Me.toggle5.TabIndex = 8
        Me.toggle5.UncheckedState.BorderColor = System.Drawing.Color.Gray
        Me.toggle5.UncheckedState.BorderRadius = 8
        Me.toggle5.UncheckedState.FillColor = System.Drawing.Color.Gray
        Me.toggle5.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle5.UncheckedState.InnerBorderRadius = 4
        Me.toggle5.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle5.UncheckedState.Parent = Me.toggle5
        '
        'indicator5
        '
        Me.indicator5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.indicator5.BackColor = System.Drawing.Color.DarkGray
        Me.indicator5.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.indicator5.Location = New System.Drawing.Point(25, 15)
        Me.indicator5.Name = "indicator5"
        Me.indicator5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.indicator5.Size = New System.Drawing.Size(22, 15)
        Me.indicator5.TabIndex = 1
        Me.indicator5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(66, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 24)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "LED 5"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.toggle4)
        Me.Panel5.Controls.Add(Me.indicator4)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Location = New System.Drawing.Point(0, 189)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(370, 45)
        Me.Panel5.TabIndex = 6
        '
        'toggle4
        '
        Me.toggle4.Animated = True
        Me.toggle4.AutoRoundedCorners = True
        Me.toggle4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggle4.CheckedState.BorderRadius = 8
        Me.toggle4.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggle4.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle4.CheckedState.InnerBorderRadius = 4
        Me.toggle4.CheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle4.CheckedState.Parent = Me.toggle4
        Me.toggle4.Location = New System.Drawing.Point(308, 13)
        Me.toggle4.Name = "toggle4"
        Me.toggle4.ShadowDecoration.Parent = Me.toggle4
        Me.toggle4.Size = New System.Drawing.Size(32, 18)
        Me.toggle4.TabIndex = 8
        Me.toggle4.UncheckedState.BorderColor = System.Drawing.Color.Gray
        Me.toggle4.UncheckedState.BorderRadius = 8
        Me.toggle4.UncheckedState.FillColor = System.Drawing.Color.Gray
        Me.toggle4.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle4.UncheckedState.InnerBorderRadius = 4
        Me.toggle4.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle4.UncheckedState.Parent = Me.toggle4
        '
        'indicator4
        '
        Me.indicator4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.indicator4.BackColor = System.Drawing.Color.DarkGray
        Me.indicator4.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.indicator4.Location = New System.Drawing.Point(25, 15)
        Me.indicator4.Name = "indicator4"
        Me.indicator4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.indicator4.Size = New System.Drawing.Size(22, 15)
        Me.indicator4.TabIndex = 1
        Me.indicator4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(66, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 24)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "LED 4"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.toggle3)
        Me.Panel4.Controls.Add(Me.indicator3)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Location = New System.Drawing.Point(0, 144)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(370, 45)
        Me.Panel4.TabIndex = 5
        '
        'toggle3
        '
        Me.toggle3.Animated = True
        Me.toggle3.AutoRoundedCorners = True
        Me.toggle3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggle3.CheckedState.BorderRadius = 8
        Me.toggle3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggle3.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle3.CheckedState.InnerBorderRadius = 4
        Me.toggle3.CheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle3.CheckedState.Parent = Me.toggle3
        Me.toggle3.Location = New System.Drawing.Point(308, 13)
        Me.toggle3.Name = "toggle3"
        Me.toggle3.ShadowDecoration.Parent = Me.toggle3
        Me.toggle3.Size = New System.Drawing.Size(32, 18)
        Me.toggle3.TabIndex = 8
        Me.toggle3.UncheckedState.BorderColor = System.Drawing.Color.Gray
        Me.toggle3.UncheckedState.BorderRadius = 8
        Me.toggle3.UncheckedState.FillColor = System.Drawing.Color.Gray
        Me.toggle3.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle3.UncheckedState.InnerBorderRadius = 4
        Me.toggle3.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle3.UncheckedState.Parent = Me.toggle3
        '
        'indicator3
        '
        Me.indicator3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.indicator3.BackColor = System.Drawing.Color.DarkGray
        Me.indicator3.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.indicator3.Location = New System.Drawing.Point(25, 15)
        Me.indicator3.Name = "indicator3"
        Me.indicator3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.indicator3.Size = New System.Drawing.Size(22, 15)
        Me.indicator3.TabIndex = 1
        Me.indicator3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(66, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "LED 3"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.toggle_all)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(0, 9)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(370, 45)
        Me.Panel3.TabIndex = 4
        '
        'toggle_all
        '
        Me.toggle_all.Animated = True
        Me.toggle_all.AutoRoundedCorners = True
        Me.toggle_all.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggle_all.CheckedState.BorderRadius = 8
        Me.toggle_all.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggle_all.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle_all.CheckedState.InnerBorderRadius = 4
        Me.toggle_all.CheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle_all.CheckedState.Parent = Me.toggle_all
        Me.toggle_all.Location = New System.Drawing.Point(308, 16)
        Me.toggle_all.Name = "toggle_all"
        Me.toggle_all.ShadowDecoration.Parent = Me.toggle_all
        Me.toggle_all.Size = New System.Drawing.Size(32, 18)
        Me.toggle_all.TabIndex = 6
        Me.toggle_all.UncheckedState.BorderColor = System.Drawing.Color.Gray
        Me.toggle_all.UncheckedState.BorderRadius = 8
        Me.toggle_all.UncheckedState.FillColor = System.Drawing.Color.Gray
        Me.toggle_all.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle_all.UncheckedState.InnerBorderRadius = 4
        Me.toggle_all.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle_all.UncheckedState.Parent = Me.toggle_all
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(185, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Toggle All"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.toggle2)
        Me.Panel2.Controls.Add(Me.indicator2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(0, 99)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(370, 45)
        Me.Panel2.TabIndex = 3
        '
        'toggle2
        '
        Me.toggle2.Animated = True
        Me.toggle2.AutoRoundedCorners = True
        Me.toggle2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggle2.CheckedState.BorderRadius = 8
        Me.toggle2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggle2.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle2.CheckedState.InnerBorderRadius = 4
        Me.toggle2.CheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle2.CheckedState.Parent = Me.toggle2
        Me.toggle2.Location = New System.Drawing.Point(308, 13)
        Me.toggle2.Name = "toggle2"
        Me.toggle2.ShadowDecoration.Parent = Me.toggle2
        Me.toggle2.Size = New System.Drawing.Size(32, 18)
        Me.toggle2.TabIndex = 8
        Me.toggle2.UncheckedState.BorderColor = System.Drawing.Color.Gray
        Me.toggle2.UncheckedState.BorderRadius = 8
        Me.toggle2.UncheckedState.FillColor = System.Drawing.Color.Gray
        Me.toggle2.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle2.UncheckedState.InnerBorderRadius = 4
        Me.toggle2.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle2.UncheckedState.Parent = Me.toggle2
        '
        'indicator2
        '
        Me.indicator2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.indicator2.BackColor = System.Drawing.Color.DarkGray
        Me.indicator2.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.indicator2.Location = New System.Drawing.Point(25, 15)
        Me.indicator2.Name = "indicator2"
        Me.indicator2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.indicator2.Size = New System.Drawing.Size(22, 15)
        Me.indicator2.TabIndex = 1
        Me.indicator2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(66, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "LED 2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.toggle1)
        Me.Panel1.Controls.Add(Me.indicator1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 54)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 45)
        Me.Panel1.TabIndex = 0
        '
        'toggle1
        '
        Me.toggle1.Animated = True
        Me.toggle1.AutoRoundedCorners = True
        Me.toggle1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggle1.CheckedState.BorderRadius = 8
        Me.toggle1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggle1.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle1.CheckedState.InnerBorderRadius = 4
        Me.toggle1.CheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle1.CheckedState.Parent = Me.toggle1
        Me.toggle1.Location = New System.Drawing.Point(308, 13)
        Me.toggle1.Name = "toggle1"
        Me.toggle1.ShadowDecoration.Parent = Me.toggle1
        Me.toggle1.Size = New System.Drawing.Size(32, 18)
        Me.toggle1.TabIndex = 7
        Me.toggle1.UncheckedState.BorderColor = System.Drawing.Color.Gray
        Me.toggle1.UncheckedState.BorderRadius = 8
        Me.toggle1.UncheckedState.FillColor = System.Drawing.Color.Gray
        Me.toggle1.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle1.UncheckedState.InnerBorderRadius = 4
        Me.toggle1.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle1.UncheckedState.Parent = Me.toggle1
        '
        'indicator1
        '
        Me.indicator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.indicator1.BackColor = System.Drawing.Color.DarkGray
        Me.indicator1.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.indicator1.Location = New System.Drawing.Point(25, 15)
        Me.indicator1.Name = "indicator1"
        Me.indicator1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.indicator1.Size = New System.Drawing.Size(22, 15)
        Me.indicator1.TabIndex = 1
        Me.indicator1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'autoPanel
        '
        Me.autoPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.autoPanel.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.autoPanel.BackgroundImage = CType(resources.GetObject("autoPanel.BackgroundImage"), System.Drawing.Image)
        Me.autoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.autoPanel.BorderColor = System.Drawing.Color.Transparent
        Me.autoPanel.BorderRadius = 18
        Me.autoPanel.BorderThickness = 1
        Me.autoPanel.Controls.Add(Me.Panel9)
        Me.autoPanel.Controls.Add(Me.Panel10)
        Me.autoPanel.Controls.Add(Me.Panel8)
        Me.autoPanel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.autoPanel.Location = New System.Drawing.Point(410, 116)
        Me.autoPanel.Name = "autoPanel"
        Me.autoPanel.ShowBorders = True
        Me.autoPanel.Size = New System.Drawing.Size(250, 165)
        Me.autoPanel.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Panel9.Controls.Add(Me.toggle7)
        Me.Panel9.Controls.Add(Me.indicator7)
        Me.Panel9.Controls.Add(Me.Label19)
        Me.Panel9.Location = New System.Drawing.Point(0, 64)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(247, 45)
        Me.Panel9.TabIndex = 3
        '
        'toggle7
        '
        Me.toggle7.Animated = True
        Me.toggle7.AutoRoundedCorners = True
        Me.toggle7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggle7.CheckedState.BorderRadius = 8
        Me.toggle7.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggle7.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle7.CheckedState.InnerBorderRadius = 4
        Me.toggle7.CheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle7.CheckedState.Parent = Me.toggle7
        Me.toggle7.Location = New System.Drawing.Point(185, 13)
        Me.toggle7.Name = "toggle7"
        Me.toggle7.ShadowDecoration.Parent = Me.toggle7
        Me.toggle7.Size = New System.Drawing.Size(32, 18)
        Me.toggle7.TabIndex = 8
        Me.toggle7.UncheckedState.BorderColor = System.Drawing.Color.Gray
        Me.toggle7.UncheckedState.BorderRadius = 8
        Me.toggle7.UncheckedState.FillColor = System.Drawing.Color.Gray
        Me.toggle7.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle7.UncheckedState.InnerBorderRadius = 4
        Me.toggle7.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle7.UncheckedState.Parent = Me.toggle7
        '
        'indicator7
        '
        Me.indicator7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.indicator7.BackColor = System.Drawing.Color.DarkGray
        Me.indicator7.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.indicator7.Location = New System.Drawing.Point(25, 15)
        Me.indicator7.Name = "indicator7"
        Me.indicator7.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.indicator7.Size = New System.Drawing.Size(22, 15)
        Me.indicator7.TabIndex = 1
        Me.indicator7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(66, 10)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(113, 24)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Sequence 2"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel10
        '
        Me.Panel10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel10.BackColor = System.Drawing.Color.Transparent
        Me.Panel10.Controls.Add(Me.toggle8)
        Me.Panel10.Controls.Add(Me.indicator8)
        Me.Panel10.Controls.Add(Me.Label21)
        Me.Panel10.Location = New System.Drawing.Point(0, 109)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(247, 45)
        Me.Panel10.TabIndex = 4
        '
        'toggle8
        '
        Me.toggle8.Animated = True
        Me.toggle8.AutoRoundedCorners = True
        Me.toggle8.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggle8.CheckedState.BorderRadius = 8
        Me.toggle8.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggle8.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle8.CheckedState.InnerBorderRadius = 4
        Me.toggle8.CheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle8.CheckedState.Parent = Me.toggle8
        Me.toggle8.Location = New System.Drawing.Point(185, 13)
        Me.toggle8.Name = "toggle8"
        Me.toggle8.ShadowDecoration.Parent = Me.toggle8
        Me.toggle8.Size = New System.Drawing.Size(32, 18)
        Me.toggle8.TabIndex = 8
        Me.toggle8.UncheckedState.BorderColor = System.Drawing.Color.Gray
        Me.toggle8.UncheckedState.BorderRadius = 8
        Me.toggle8.UncheckedState.FillColor = System.Drawing.Color.Gray
        Me.toggle8.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle8.UncheckedState.InnerBorderRadius = 4
        Me.toggle8.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle8.UncheckedState.Parent = Me.toggle8
        '
        'indicator8
        '
        Me.indicator8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.indicator8.BackColor = System.Drawing.Color.DarkGray
        Me.indicator8.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.indicator8.Location = New System.Drawing.Point(25, 15)
        Me.indicator8.Name = "indicator8"
        Me.indicator8.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.indicator8.Size = New System.Drawing.Size(22, 15)
        Me.indicator8.TabIndex = 1
        Me.indicator8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(66, 10)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(113, 24)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Sequence 3"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.Controls.Add(Me.toggle6)
        Me.Panel8.Controls.Add(Me.indicator6)
        Me.Panel8.Controls.Add(Me.Label17)
        Me.Panel8.Location = New System.Drawing.Point(0, 19)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(247, 45)
        Me.Panel8.TabIndex = 1
        '
        'toggle6
        '
        Me.toggle6.Animated = True
        Me.toggle6.AutoRoundedCorners = True
        Me.toggle6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggle6.CheckedState.BorderRadius = 8
        Me.toggle6.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.toggle6.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle6.CheckedState.InnerBorderRadius = 4
        Me.toggle6.CheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle6.CheckedState.Parent = Me.toggle6
        Me.toggle6.Location = New System.Drawing.Point(185, 13)
        Me.toggle6.Name = "toggle6"
        Me.toggle6.ShadowDecoration.Parent = Me.toggle6
        Me.toggle6.Size = New System.Drawing.Size(32, 18)
        Me.toggle6.TabIndex = 8
        Me.toggle6.UncheckedState.BorderColor = System.Drawing.Color.Gray
        Me.toggle6.UncheckedState.BorderRadius = 8
        Me.toggle6.UncheckedState.FillColor = System.Drawing.Color.Gray
        Me.toggle6.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.toggle6.UncheckedState.InnerBorderRadius = 4
        Me.toggle6.UncheckedState.InnerColor = System.Drawing.Color.White
        Me.toggle6.UncheckedState.Parent = Me.toggle6
        '
        'indicator6
        '
        Me.indicator6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.indicator6.BackColor = System.Drawing.Color.DarkGray
        Me.indicator6.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.indicator6.Location = New System.Drawing.Point(25, 15)
        Me.indicator6.Name = "indicator6"
        Me.indicator6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.indicator6.Size = New System.Drawing.Size(22, 15)
        Me.indicator6.TabIndex = 1
        Me.indicator6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(66, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(113, 24)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Sequence 1"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.PictureBox1)
        Me.Panel7.Controls.Add(Me.Title)
        Me.Panel7.Controls.Add(Me.comLabel)
        Me.Panel7.Location = New System.Drawing.Point(-8, -2)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(700, 60)
        Me.Panel7.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Control5LED_GUI.My.Resources.Resources._3488675961640851887_128
        Me.PictureBox1.Location = New System.Drawing.Point(147, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Title
        '
        Me.Title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Title.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.Black
        Me.Title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Title.Location = New System.Drawing.Point(27, 0)
        Me.Title.Name = "Title"
        Me.Title.Padding = New System.Windows.Forms.Padding(10, 10, 0, 0)
        Me.Title.Size = New System.Drawing.Size(370, 59)
        Me.Title.TabIndex = 5
        Me.Title.Text = "CONTROL LED"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'comLabel
        '
        Me.comLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comLabel.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.comLabel.Location = New System.Drawing.Point(421, 0)
        Me.comLabel.Name = "comLabel"
        Me.comLabel.Size = New System.Drawing.Size(247, 59)
        Me.comLabel.TabIndex = 4
        Me.comLabel.Text = "COM"
        Me.comLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(370, 45)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Manual"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(410, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(250, 45)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Auto"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'turn_off_all
        '
        Me.turn_off_all.AllowAnimations = True
        Me.turn_off_all.AllowMouseEffects = True
        Me.turn_off_all.AllowToggling = False
        Me.turn_off_all.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.turn_off_all.AnimationSpeed = 80
        Me.turn_off_all.AutoGenerateColors = False
        Me.turn_off_all.AutoRoundBorders = False
        Me.turn_off_all.AutoSizeLeftIcon = True
        Me.turn_off_all.AutoSizeRightIcon = True
        Me.turn_off_all.BackColor = System.Drawing.Color.Transparent
        Me.turn_off_all.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.turn_off_all.BackgroundImage = CType(resources.GetObject("turn_off_all.BackgroundImage"), System.Drawing.Image)
        Me.turn_off_all.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.turn_off_all.ButtonText = "Turn Off All"
        Me.turn_off_all.ButtonTextMarginLeft = 0
        Me.turn_off_all.ColorContrastOnClick = 45
        Me.turn_off_all.ColorContrastOnHover = 20
        Me.turn_off_all.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = False
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = False
        Me.turn_off_all.CustomizableEdges = BorderEdges1
        Me.turn_off_all.DialogResult = System.Windows.Forms.DialogResult.None
        Me.turn_off_all.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.turn_off_all.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.turn_off_all.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.turn_off_all.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle
        Me.turn_off_all.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.turn_off_all.ForeColor = System.Drawing.Color.White
        Me.turn_off_all.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.turn_off_all.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.turn_off_all.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.turn_off_all.IconMarginLeft = 11
        Me.turn_off_all.IconPadding = 10
        Me.turn_off_all.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.turn_off_all.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.turn_off_all.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.turn_off_all.IconSize = 25
        Me.turn_off_all.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.turn_off_all.IdleBorderRadius = 18
        Me.turn_off_all.IdleBorderThickness = 1
        Me.turn_off_all.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.turn_off_all.IdleIconLeftImage = Nothing
        Me.turn_off_all.IdleIconRightImage = Nothing
        Me.turn_off_all.IndicateFocus = False
        Me.turn_off_all.Location = New System.Drawing.Point(410, 315)
        Me.turn_off_all.Name = "turn_off_all"
        Me.turn_off_all.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.turn_off_all.OnDisabledState.BorderRadius = 18
        Me.turn_off_all.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.turn_off_all.OnDisabledState.BorderThickness = 1
        Me.turn_off_all.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.turn_off_all.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.turn_off_all.OnDisabledState.IconLeftImage = Nothing
        Me.turn_off_all.OnDisabledState.IconRightImage = Nothing
        Me.turn_off_all.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.turn_off_all.onHoverState.BorderRadius = 18
        Me.turn_off_all.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.turn_off_all.onHoverState.BorderThickness = 1
        Me.turn_off_all.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.turn_off_all.onHoverState.ForeColor = System.Drawing.Color.White
        Me.turn_off_all.onHoverState.IconLeftImage = Nothing
        Me.turn_off_all.onHoverState.IconRightImage = Nothing
        Me.turn_off_all.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.turn_off_all.OnIdleState.BorderRadius = 18
        Me.turn_off_all.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.turn_off_all.OnIdleState.BorderThickness = 1
        Me.turn_off_all.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.turn_off_all.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.turn_off_all.OnIdleState.IconLeftImage = Nothing
        Me.turn_off_all.OnIdleState.IconRightImage = Nothing
        Me.turn_off_all.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.turn_off_all.OnPressedState.BorderRadius = 18
        Me.turn_off_all.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.turn_off_all.OnPressedState.BorderThickness = 1
        Me.turn_off_all.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.turn_off_all.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.turn_off_all.OnPressedState.IconLeftImage = Nothing
        Me.turn_off_all.OnPressedState.IconRightImage = Nothing
        Me.turn_off_all.Size = New System.Drawing.Size(250, 50)
        Me.turn_off_all.TabIndex = 5
        Me.turn_off_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.turn_off_all.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.turn_off_all.TextMarginLeft = 0
        Me.turn_off_all.TextPadding = New System.Windows.Forms.Padding(0)
        Me.turn_off_all.UseDefaultRadiusAndThickness = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'sp
        '
        '
        'snackbar1
        '
        Me.snackbar1.AllowDragging = False
        Me.snackbar1.AllowMultipleViews = True
        Me.snackbar1.ClickToClose = True
        Me.snackbar1.DoubleClickToClose = False
        Me.snackbar1.DurationAfterIdle = 2000
        Me.snackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar1.ErrorOptions.ActionBorderRadius = 1
        Me.snackbar1.ErrorOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.snackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black
        Me.snackbar1.ErrorOptions.BackColor = System.Drawing.Color.White
        Me.snackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White
        Me.snackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.snackbar1.ErrorOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.snackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black
        Me.snackbar1.ErrorOptions.Icon = CType(resources.GetObject("resource.Icon"), System.Drawing.Image)
        Me.snackbar1.ErrorOptions.IconLeftMargin = 12
        Me.snackbar1.FadeCloseIcon = False
        Me.snackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner
        Me.snackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar1.InformationOptions.ActionBorderRadius = 1
        Me.snackbar1.InformationOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.snackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black
        Me.snackbar1.InformationOptions.BackColor = System.Drawing.Color.White
        Me.snackbar1.InformationOptions.BorderColor = System.Drawing.Color.White
        Me.snackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar1.InformationOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.snackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black
        Me.snackbar1.InformationOptions.Icon = CType(resources.GetObject("resource.Icon1"), System.Drawing.Image)
        Me.snackbar1.InformationOptions.IconLeftMargin = 12
        Me.snackbar1.Margin = 10
        Me.snackbar1.MaximumSize = New System.Drawing.Size(0, 0)
        Me.snackbar1.MaximumViews = 7
        Me.snackbar1.MessageRightMargin = 15
        Me.snackbar1.MinimumSize = New System.Drawing.Size(0, 0)
        Me.snackbar1.ShowBorders = False
        Me.snackbar1.ShowCloseIcon = False
        Me.snackbar1.ShowIcon = True
        Me.snackbar1.ShowShadows = True
        Me.snackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar1.SuccessOptions.ActionBorderRadius = 1
        Me.snackbar1.SuccessOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.snackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black
        Me.snackbar1.SuccessOptions.BackColor = System.Drawing.Color.White
        Me.snackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White
        Me.snackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.snackbar1.SuccessOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.snackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black
        Me.snackbar1.SuccessOptions.Icon = CType(resources.GetObject("resource.Icon2"), System.Drawing.Image)
        Me.snackbar1.SuccessOptions.IconLeftMargin = 12
        Me.snackbar1.ViewsMargin = 7
        Me.snackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.snackbar1.WarningOptions.ActionBorderRadius = 1
        Me.snackbar1.WarningOptions.ActionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.snackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black
        Me.snackbar1.WarningOptions.BackColor = System.Drawing.Color.White
        Me.snackbar1.WarningOptions.BorderColor = System.Drawing.Color.White
        Me.snackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.snackbar1.WarningOptions.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.snackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black
        Me.snackbar1.WarningOptions.Icon = CType(resources.GetObject("resource.Icon3"), System.Drawing.Image)
        Me.snackbar1.WarningOptions.IconLeftMargin = 12
        Me.snackbar1.ZoomCloseIcon = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 431)
        Me.Controls.Add(Me.turn_off_all)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.autoPanel)
        Me.Controls.Add(Me.manualPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.manualPanel.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.autoPanel.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents manualPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuToggleSwitch1 As Bunifu.UI.WinForms.BunifuToggleSwitch
    Friend WithEvents indicator1 As Label
    Friend WithEvents autoPanel As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents BunifuToggleSwitch2 As Bunifu.UI.WinForms.BunifuToggleSwitch
    Friend WithEvents Panel2 As Panel
    Friend WithEvents indicator2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents indicator5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents indicator4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents indicator3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Title As Label
    Friend WithEvents comLabel As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents indicator7 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents indicator8 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents indicator6 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents turn_off_all As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents sp As IO.Ports.SerialPort
    Friend WithEvents snackbar1 As Bunifu.UI.WinForms.BunifuSnackbar
    Friend WithEvents toggle_all As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents toggle1 As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents toggle5 As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents toggle4 As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents toggle3 As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents toggle2 As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents toggle6 As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents toggle7 As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents toggle8 As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents PictureBox1 As PictureBox
End Class
