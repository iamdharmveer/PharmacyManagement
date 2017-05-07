Imports System.Data.SqlClient

Public Class Form6
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
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
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(46, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 224)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Salary Details"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(640, 168)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(200, 23)
        Me.TextBox7.TabIndex = 24
        Me.TextBox7.Text = ""
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(640, 128)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(200, 23)
        Me.TextBox6.TabIndex = 23
        Me.TextBox6.Text = ""
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(640, 88)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(200, 23)
        Me.TextBox5.TabIndex = 22
        Me.TextBox5.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(640, 48)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(200, 23)
        Me.TextBox4.TabIndex = 21
        Me.TextBox4.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(216, 128)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 23)
        Me.TextBox3.TabIndex = 20
        Me.TextBox3.Text = ""
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(472, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 23)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Total Salary"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(472, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Salary Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(216, 88)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 23)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(216, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 23)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Salary Amount"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(472, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Salary HRF"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Salary Advance"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(472, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Salary DA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(192, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(536, 72)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "SALARY DETAILS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(144, 411)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(568, 64)
        Me.Panel1.TabIndex = 11
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button5.Location = New System.Drawing.Point(392, 24)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "EXIT"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(240, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "DELETE"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(88, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "INSERT"
        '
        'Form6
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(952, 486)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form6"
        Me.Text = "Form6"
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

            cmdstr = "INSERT INTO SalaryDetails VALUES(" & TextBox1.Text & "," & TextBox2.Text & "," & TextBox3.Text & "," & TextBox4.Text & "," & TextBox5.Text & ",convert(datetime,'" & TextBox6.Text & "')," & TextBox7.Text & ")"
            cmd.CommandText = cmdstr

            cmd.ExecuteNonQuery()
            MessageBox.Show("Salary is added successfully", "Feedback")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim r As DialogResult
        r = MessageBox.Show("Do you really want to delete current Employee Salary details along with all the details ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If r = DialogResult.No Then
            Return
        End If

        con = New SqlConnection
        con.ConnectionString = "data source=VB;initial catalog=Pharmacy;user id=Dharm;pwd=1212"
        con.Open()
        cmd = New SqlCommand
        cmd.Connection = con

        Dim s As String
        s = "delete from SalaryDetails where eid =" + TextBox1.Text
        cmd.CommandText = s



        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Salary Details successfully deleted")
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
End Class
