Imports System.Data.SqlClient

Public Class Form9
    Inherits System.Windows.Forms.Form
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox1.Location = New System.Drawing.Point(40, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(872, 220)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(480, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Medicine Details"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(664, 120)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(176, 20)
        Me.TextBox7.TabIndex = 19
        Me.TextBox7.Text = ""
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(664, 80)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(176, 20)
        Me.TextBox6.TabIndex = 18
        Me.TextBox6.Text = ""
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Location = New System.Drawing.Point(480, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Alternate Address"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(664, 32)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(176, 20)
        Me.TextBox5.TabIndex = 14
        Me.TextBox5.Text = ""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(480, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Customer Address"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(208, 152)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(176, 20)
        Me.TextBox4.TabIndex = 11
        Me.TextBox4.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(24, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Customer Contact"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(208, 112)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(176, 20)
        Me.TextBox3.TabIndex = 5
        Me.TextBox3.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(24, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Customer Email"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(208, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(24, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(208, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(24, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(184, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(584, 72)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "CUSTOMER DETAILS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(208, 416)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 88)
        Me.Panel1.TabIndex = 11
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button5.Location = New System.Drawing.Point(432, 32)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "EXIT"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(264, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "DELETE"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(80, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "INSERT"
        '
        'Form9
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(952, 518)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form9"
        Me.Text = "Form9"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim con As SqlConnection
        Dim cmd As SqlCommand

        Try
            con = New SqlConnection
            con.ConnectionString = "data source=VB;initial catalog=Pharmacy;user id=Dharm;pwd=1212"
            con.Open()
            cmd = New SqlCommand
            cmd.Connection = con
            Dim cmdstr As String

            cmdstr = "INSERT INTO CustomerDetails VALUES(" & TextBox1.Text & ",'" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "',' " & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')"
            cmd.CommandText = cmdstr

            cmd.ExecuteNonQuery()
            MessageBox.Show("Customer is added successfully", "Feedback")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim r As DialogResult
        r = MessageBox.Show("Do you really want to delete current Customer details along with all the details ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If r = DialogResult.No Then
            Return
        End If

        con = New SqlConnection
        con.ConnectionString = "data source=VB;initial catalog=Pharmacy;user id=Dharm;pwd=1212"
        con.Open()
        cmd = New SqlCommand
        cmd.Connection = con

        Dim s As String
        s = "delete from CustomerDetails where cid =" + TextBox1.Text
        cmd.CommandText = s



        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Customer successfully deleted")
        Catch myexc As Exception
            MsgBox(myexc.Message)
        End Try



        ' clear all textboxes
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()

    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
