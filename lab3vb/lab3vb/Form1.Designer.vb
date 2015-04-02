<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovieNight
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpBxMatTics = New System.Windows.Forms.GroupBox()
        Me.LblMatSen = New System.Windows.Forms.Label()
        Me.LblMatAdult = New System.Windows.Forms.Label()
        Me.LblMatChild = New System.Windows.Forms.Label()
        Me.txtBxTtlMat = New System.Windows.Forms.TextBox()
        Me.btnTtlMat = New System.Windows.Forms.Button()
        Me.grpBxEvenTics = New System.Windows.Forms.GroupBox()
        Me.LblEvenSen = New System.Windows.Forms.Label()
        Me.LblEvenAdult = New System.Windows.Forms.Label()
        Me.LblEvenChild = New System.Windows.Forms.Label()
        Me.txtBxTtlEven = New System.Windows.Forms.TextBox()
        Me.btnTtlEven = New System.Windows.Forms.Button()
        Me.grpBxConcessStnd = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBxCandyAmt = New System.Windows.Forms.TextBox()
        Me.txtBxPopcornAmt = New System.Windows.Forms.TextBox()
        Me.txtBxHotDogAmt = New System.Windows.Forms.TextBox()
        Me.txtBxLrglSodaAmt = New System.Windows.Forms.TextBox()
        Me.txtBxSmlSodaAmt = New System.Windows.Forms.TextBox()
        Me.txtBxConcessTtl = New System.Windows.Forms.TextBox()
        Me.btnTtlConcess = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FinalTotal = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.grpBxMatOrEven = New System.Windows.Forms.GroupBox()
        Me.radBtnEven = New System.Windows.Forms.RadioButton()
        Me.radBtnMat = New System.Windows.Forms.RadioButton()
        Me.lblChild = New System.Windows.Forms.Label()
        Me.lblAdult = New System.Windows.Forms.Label()
        Me.lblSen = New System.Windows.Forms.Label()
        Me.txtBxChildTicAmt = New System.Windows.Forms.TextBox()
        Me.txtBxAdultTicAmt = New System.Windows.Forms.TextBox()
        Me.txtBxSenTicAmt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grpBxMatTics.SuspendLayout()
        Me.grpBxEvenTics.SuspendLayout()
        Me.grpBxConcessStnd.SuspendLayout()
        Me.grpBxMatOrEven.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBxMatTics
        '
        Me.grpBxMatTics.Controls.Add(Me.LblMatSen)
        Me.grpBxMatTics.Controls.Add(Me.LblMatAdult)
        Me.grpBxMatTics.Controls.Add(Me.LblMatChild)
        Me.grpBxMatTics.Controls.Add(Me.txtBxTtlMat)
        Me.grpBxMatTics.Controls.Add(Me.btnTtlMat)
        Me.grpBxMatTics.Location = New System.Drawing.Point(162, 54)
        Me.grpBxMatTics.Name = "grpBxMatTics"
        Me.grpBxMatTics.Size = New System.Drawing.Size(115, 234)
        Me.grpBxMatTics.TabIndex = 0
        Me.grpBxMatTics.TabStop = False
        Me.grpBxMatTics.Text = "Prices"
        Me.grpBxMatTics.Visible = False
        '
        'LblMatSen
        '
        Me.LblMatSen.AutoSize = True
        Me.LblMatSen.Location = New System.Drawing.Point(10, 102)
        Me.LblMatSen.Name = "LblMatSen"
        Me.LblMatSen.Size = New System.Drawing.Size(34, 13)
        Me.LblMatSen.TabIndex = 4
        Me.LblMatSen.Text = "$4.50"
        '
        'LblMatAdult
        '
        Me.LblMatAdult.AutoSize = True
        Me.LblMatAdult.Location = New System.Drawing.Point(10, 67)
        Me.LblMatAdult.Name = "LblMatAdult"
        Me.LblMatAdult.Size = New System.Drawing.Size(34, 13)
        Me.LblMatAdult.TabIndex = 3
        Me.LblMatAdult.Text = "$5.99"
        '
        'LblMatChild
        '
        Me.LblMatChild.AutoSize = True
        Me.LblMatChild.Location = New System.Drawing.Point(7, 31)
        Me.LblMatChild.Name = "LblMatChild"
        Me.LblMatChild.Size = New System.Drawing.Size(34, 13)
        Me.LblMatChild.TabIndex = 2
        Me.LblMatChild.Text = "$3.99"
        '
        'txtBxTtlMat
        '
        Me.txtBxTtlMat.Location = New System.Drawing.Point(6, 198)
        Me.txtBxTtlMat.Name = "txtBxTtlMat"
        Me.txtBxTtlMat.ReadOnly = True
        Me.txtBxTtlMat.Size = New System.Drawing.Size(100, 20)
        Me.txtBxTtlMat.TabIndex = 1
        '
        'btnTtlMat
        '
        Me.btnTtlMat.Location = New System.Drawing.Point(19, 169)
        Me.btnTtlMat.Name = "btnTtlMat"
        Me.btnTtlMat.Size = New System.Drawing.Size(75, 23)
        Me.btnTtlMat.TabIndex = 0
        Me.btnTtlMat.Text = "Total"
        Me.btnTtlMat.UseVisualStyleBackColor = True
        '
        'grpBxEvenTics
        '
        Me.grpBxEvenTics.Controls.Add(Me.LblEvenSen)
        Me.grpBxEvenTics.Controls.Add(Me.LblEvenAdult)
        Me.grpBxEvenTics.Controls.Add(Me.LblEvenChild)
        Me.grpBxEvenTics.Controls.Add(Me.txtBxTtlEven)
        Me.grpBxEvenTics.Controls.Add(Me.btnTtlEven)
        Me.grpBxEvenTics.Location = New System.Drawing.Point(283, 54)
        Me.grpBxEvenTics.Name = "grpBxEvenTics"
        Me.grpBxEvenTics.Size = New System.Drawing.Size(112, 234)
        Me.grpBxEvenTics.TabIndex = 1
        Me.grpBxEvenTics.TabStop = False
        Me.grpBxEvenTics.Text = "Prices"
        Me.grpBxEvenTics.Visible = False
        '
        'LblEvenSen
        '
        Me.LblEvenSen.AutoSize = True
        Me.LblEvenSen.Location = New System.Drawing.Point(13, 102)
        Me.LblEvenSen.Name = "LblEvenSen"
        Me.LblEvenSen.Size = New System.Drawing.Size(34, 13)
        Me.LblEvenSen.TabIndex = 4
        Me.LblEvenSen.Text = "$8.50"
        '
        'LblEvenAdult
        '
        Me.LblEvenAdult.AutoSize = True
        Me.LblEvenAdult.Location = New System.Drawing.Point(10, 67)
        Me.LblEvenAdult.Name = "LblEvenAdult"
        Me.LblEvenAdult.Size = New System.Drawing.Size(40, 13)
        Me.LblEvenAdult.TabIndex = 3
        Me.LblEvenAdult.Text = "$10.99"
        '
        'LblEvenChild
        '
        Me.LblEvenChild.AutoSize = True
        Me.LblEvenChild.Location = New System.Drawing.Point(7, 30)
        Me.LblEvenChild.Name = "LblEvenChild"
        Me.LblEvenChild.Size = New System.Drawing.Size(34, 13)
        Me.LblEvenChild.TabIndex = 2
        Me.LblEvenChild.Text = "$6.99"
        '
        'txtBxTtlEven
        '
        Me.txtBxTtlEven.Location = New System.Drawing.Point(7, 198)
        Me.txtBxTtlEven.Name = "txtBxTtlEven"
        Me.txtBxTtlEven.ReadOnly = True
        Me.txtBxTtlEven.Size = New System.Drawing.Size(100, 20)
        Me.txtBxTtlEven.TabIndex = 1
        '
        'btnTtlEven
        '
        Me.btnTtlEven.Location = New System.Drawing.Point(7, 169)
        Me.btnTtlEven.Name = "btnTtlEven"
        Me.btnTtlEven.Size = New System.Drawing.Size(75, 23)
        Me.btnTtlEven.TabIndex = 0
        Me.btnTtlEven.Text = "Total"
        Me.btnTtlEven.UseVisualStyleBackColor = True
        '
        'grpBxConcessStnd
        '
        Me.grpBxConcessStnd.Controls.Add(Me.Label10)
        Me.grpBxConcessStnd.Controls.Add(Me.Label9)
        Me.grpBxConcessStnd.Controls.Add(Me.Label8)
        Me.grpBxConcessStnd.Controls.Add(Me.Label7)
        Me.grpBxConcessStnd.Controls.Add(Me.Label6)
        Me.grpBxConcessStnd.Controls.Add(Me.txtBxCandyAmt)
        Me.grpBxConcessStnd.Controls.Add(Me.txtBxPopcornAmt)
        Me.grpBxConcessStnd.Controls.Add(Me.txtBxHotDogAmt)
        Me.grpBxConcessStnd.Controls.Add(Me.txtBxLrglSodaAmt)
        Me.grpBxConcessStnd.Controls.Add(Me.txtBxSmlSodaAmt)
        Me.grpBxConcessStnd.Controls.Add(Me.txtBxConcessTtl)
        Me.grpBxConcessStnd.Controls.Add(Me.btnTtlConcess)
        Me.grpBxConcessStnd.Controls.Add(Me.Label5)
        Me.grpBxConcessStnd.Controls.Add(Me.Label4)
        Me.grpBxConcessStnd.Controls.Add(Me.Label3)
        Me.grpBxConcessStnd.Controls.Add(Me.Label2)
        Me.grpBxConcessStnd.Controls.Add(Me.Label1)
        Me.grpBxConcessStnd.Location = New System.Drawing.Point(401, 47)
        Me.grpBxConcessStnd.Name = "grpBxConcessStnd"
        Me.grpBxConcessStnd.Size = New System.Drawing.Size(255, 241)
        Me.grpBxConcessStnd.TabIndex = 2
        Me.grpBxConcessStnd.TabStop = False
        Me.grpBxConcessStnd.Text = "Concession Stand"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(165, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "$1.99"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(162, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "$4.50"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(162, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "$3.99"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(162, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "$5.99"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(159, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "$3.50"
        '
        'txtBxCandyAmt
        '
        Me.txtBxCandyAmt.Location = New System.Drawing.Point(67, 134)
        Me.txtBxCandyAmt.Name = "txtBxCandyAmt"
        Me.txtBxCandyAmt.Size = New System.Drawing.Size(72, 20)
        Me.txtBxCandyAmt.TabIndex = 11
        '
        'txtBxPopcornAmt
        '
        Me.txtBxPopcornAmt.Location = New System.Drawing.Point(67, 100)
        Me.txtBxPopcornAmt.Name = "txtBxPopcornAmt"
        Me.txtBxPopcornAmt.Size = New System.Drawing.Size(72, 20)
        Me.txtBxPopcornAmt.TabIndex = 10
        '
        'txtBxHotDogAmt
        '
        Me.txtBxHotDogAmt.Location = New System.Drawing.Point(68, 76)
        Me.txtBxHotDogAmt.Name = "txtBxHotDogAmt"
        Me.txtBxHotDogAmt.Size = New System.Drawing.Size(71, 20)
        Me.txtBxHotDogAmt.TabIndex = 9
        '
        'txtBxLrglSodaAmt
        '
        Me.txtBxLrglSodaAmt.Location = New System.Drawing.Point(69, 54)
        Me.txtBxLrglSodaAmt.Name = "txtBxLrglSodaAmt"
        Me.txtBxLrglSodaAmt.Size = New System.Drawing.Size(70, 20)
        Me.txtBxLrglSodaAmt.TabIndex = 8
        '
        'txtBxSmlSodaAmt
        '
        Me.txtBxSmlSodaAmt.Location = New System.Drawing.Point(69, 32)
        Me.txtBxSmlSodaAmt.Name = "txtBxSmlSodaAmt"
        Me.txtBxSmlSodaAmt.Size = New System.Drawing.Size(70, 20)
        Me.txtBxSmlSodaAmt.TabIndex = 7
        '
        'txtBxConcessTtl
        '
        Me.txtBxConcessTtl.Location = New System.Drawing.Point(16, 205)
        Me.txtBxConcessTtl.Name = "txtBxConcessTtl"
        Me.txtBxConcessTtl.ReadOnly = True
        Me.txtBxConcessTtl.Size = New System.Drawing.Size(100, 20)
        Me.txtBxConcessTtl.TabIndex = 6
        '
        'btnTtlConcess
        '
        Me.btnTtlConcess.Location = New System.Drawing.Point(27, 176)
        Me.btnTtlConcess.Name = "btnTtlConcess"
        Me.btnTtlConcess.Size = New System.Drawing.Size(75, 23)
        Me.btnTtlConcess.TabIndex = 5
        Me.btnTtlConcess.Text = "Total"
        Me.btnTtlConcess.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Candy"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Popcorn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hot Dog"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Large Soda"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Small Soda"
        '
        'FinalTotal
        '
        Me.FinalTotal.Location = New System.Drawing.Point(401, 374)
        Me.FinalTotal.Name = "FinalTotal"
        Me.FinalTotal.Size = New System.Drawing.Size(75, 23)
        Me.FinalTotal.TabIndex = 3
        Me.FinalTotal.Text = "Grand Total"
        Me.FinalTotal.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(499, 376)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'grpBxMatOrEven
        '
        Me.grpBxMatOrEven.Controls.Add(Me.radBtnEven)
        Me.grpBxMatOrEven.Controls.Add(Me.radBtnMat)
        Me.grpBxMatOrEven.Location = New System.Drawing.Point(55, 12)
        Me.grpBxMatOrEven.Name = "grpBxMatOrEven"
        Me.grpBxMatOrEven.Size = New System.Drawing.Size(273, 36)
        Me.grpBxMatOrEven.TabIndex = 5
        Me.grpBxMatOrEven.TabStop = False
        Me.grpBxMatOrEven.Text = "Matinee or Evening Show?"
        '
        'radBtnEven
        '
        Me.radBtnEven.AutoSize = True
        Me.radBtnEven.Location = New System.Drawing.Point(142, 13)
        Me.radBtnEven.Name = "radBtnEven"
        Me.radBtnEven.Size = New System.Drawing.Size(64, 17)
        Me.radBtnEven.TabIndex = 1
        Me.radBtnEven.TabStop = True
        Me.radBtnEven.Text = "Evening"
        Me.radBtnEven.UseVisualStyleBackColor = True
        '
        'radBtnMat
        '
        Me.radBtnMat.AutoSize = True
        Me.radBtnMat.Location = New System.Drawing.Point(7, 13)
        Me.radBtnMat.Name = "radBtnMat"
        Me.radBtnMat.Size = New System.Drawing.Size(63, 17)
        Me.radBtnMat.TabIndex = 0
        Me.radBtnMat.TabStop = True
        Me.radBtnMat.Text = "Matinee"
        Me.radBtnMat.UseVisualStyleBackColor = True
        '
        'lblChild
        '
        Me.lblChild.AutoSize = True
        Me.lblChild.Location = New System.Drawing.Point(29, 79)
        Me.lblChild.Name = "lblChild"
        Me.lblChild.Size = New System.Drawing.Size(30, 13)
        Me.lblChild.TabIndex = 6
        Me.lblChild.Text = "Child"
        '
        'lblAdult
        '
        Me.lblAdult.AutoSize = True
        Me.lblAdult.Location = New System.Drawing.Point(29, 115)
        Me.lblAdult.Name = "lblAdult"
        Me.lblAdult.Size = New System.Drawing.Size(31, 13)
        Me.lblAdult.TabIndex = 7
        Me.lblAdult.Text = "Adult"
        '
        'lblSen
        '
        Me.lblSen.AutoSize = True
        Me.lblSen.Location = New System.Drawing.Point(29, 150)
        Me.lblSen.Name = "lblSen"
        Me.lblSen.Size = New System.Drawing.Size(37, 13)
        Me.lblSen.TabIndex = 8
        Me.lblSen.Text = "Senior"
        '
        'txtBxChildTicAmt
        '
        Me.txtBxChildTicAmt.Location = New System.Drawing.Point(79, 79)
        Me.txtBxChildTicAmt.Name = "txtBxChildTicAmt"
        Me.txtBxChildTicAmt.Size = New System.Drawing.Size(62, 20)
        Me.txtBxChildTicAmt.TabIndex = 9
        '
        'txtBxAdultTicAmt
        '
        Me.txtBxAdultTicAmt.Location = New System.Drawing.Point(79, 115)
        Me.txtBxAdultTicAmt.Name = "txtBxAdultTicAmt"
        Me.txtBxAdultTicAmt.Size = New System.Drawing.Size(62, 20)
        Me.txtBxAdultTicAmt.TabIndex = 10
        '
        'txtBxSenTicAmt
        '
        Me.txtBxSenTicAmt.Location = New System.Drawing.Point(79, 150)
        Me.txtBxSenTicAmt.Name = "txtBxSenTicAmt"
        Me.txtBxSenTicAmt.Size = New System.Drawing.Size(62, 20)
        Me.txtBxSenTicAmt.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 314)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(463, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Individuals who purchase a popcorn and a large soda recieve a $2 discount on thei" & _
    "r movie ticket"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 346)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(460, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "If three or more people purchase tickets to an evening show, they can get 1 free " & _
    "bag of popcorn"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 383)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(244, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "For each 3 candies you buy, the 4th would be free"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 286)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(130, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Discounts and Promotions"
        '
        'frmMovieNight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 428)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtBxSenTicAmt)
        Me.Controls.Add(Me.txtBxAdultTicAmt)
        Me.Controls.Add(Me.txtBxChildTicAmt)
        Me.Controls.Add(Me.lblSen)
        Me.Controls.Add(Me.lblAdult)
        Me.Controls.Add(Me.lblChild)
        Me.Controls.Add(Me.grpBxMatOrEven)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.FinalTotal)
        Me.Controls.Add(Me.grpBxConcessStnd)
        Me.Controls.Add(Me.grpBxEvenTics)
        Me.Controls.Add(Me.grpBxMatTics)
        Me.Name = "frmMovieNight"
        Me.Text = "A Night at the Movies"
        Me.grpBxMatTics.ResumeLayout(False)
        Me.grpBxMatTics.PerformLayout()
        Me.grpBxEvenTics.ResumeLayout(False)
        Me.grpBxEvenTics.PerformLayout()
        Me.grpBxConcessStnd.ResumeLayout(False)
        Me.grpBxConcessStnd.PerformLayout()
        Me.grpBxMatOrEven.ResumeLayout(False)
        Me.grpBxMatOrEven.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpBxMatTics As System.Windows.Forms.GroupBox
    Friend WithEvents LblMatSen As System.Windows.Forms.Label
    Friend WithEvents LblMatAdult As System.Windows.Forms.Label
    Friend WithEvents LblMatChild As System.Windows.Forms.Label
    Friend WithEvents txtBxTtlMat As System.Windows.Forms.TextBox
    Friend WithEvents btnTtlMat As System.Windows.Forms.Button
    Friend WithEvents grpBxEvenTics As System.Windows.Forms.GroupBox
    Friend WithEvents LblEvenSen As System.Windows.Forms.Label
    Friend WithEvents LblEvenAdult As System.Windows.Forms.Label
    Friend WithEvents LblEvenChild As System.Windows.Forms.Label
    Friend WithEvents txtBxTtlEven As System.Windows.Forms.TextBox
    Friend WithEvents btnTtlEven As System.Windows.Forms.Button
    Friend WithEvents grpBxConcessStnd As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBxCandyAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtBxPopcornAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtBxHotDogAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtBxLrglSodaAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtBxSmlSodaAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtBxConcessTtl As System.Windows.Forms.TextBox
    Friend WithEvents btnTtlConcess As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FinalTotal As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents grpBxMatOrEven As System.Windows.Forms.GroupBox
    Friend WithEvents radBtnEven As System.Windows.Forms.RadioButton
    Friend WithEvents radBtnMat As System.Windows.Forms.RadioButton
    Friend WithEvents lblChild As System.Windows.Forms.Label
    Friend WithEvents lblAdult As System.Windows.Forms.Label
    Friend WithEvents lblSen As System.Windows.Forms.Label
    Friend WithEvents txtBxChildTicAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtBxAdultTicAmt As System.Windows.Forms.TextBox
    Friend WithEvents txtBxSenTicAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label

End Class
