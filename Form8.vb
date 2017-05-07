Imports System.Data.SqlClient

Public Class Form8
    Inherits System.Windows.Forms.Form
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim ds As DataSet

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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(58, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 152)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Details"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(640, 88)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(200, 23)
        Me.TextBox4.TabIndex = 9
        Me.TextBox4.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(216, 88)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 23)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(640, 48)
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
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(472, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Medicine ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stock Date"
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
        Me.Label2.Text = "Stock Unit"
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
        Me.Label1.Text = "Stock ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(200, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(536, 72)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "STOCK DETAILS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(216, 411)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(536, 64)
        Me.Panel1.TabIndex = 11
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button5.Location = New System.Drawing.Point(440, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "EXIT"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(192, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "DELETE"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(40, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "INSERT"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(240, 320)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(472, 80)
        Me.DataGrid1.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(320, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "SHOW"
        '
        'Form8
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(976, 486)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form8"
        Me.Text = "Form8"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
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

            cmdstr = "INSERT INTO StockDetails VALUES(" & TextBox1.Text & "," & TextBox2.Text & ",convert(datetime,'" & TextBox3.Text & "'),'" & TextBox4.Text & "')"
            cmd.CommandText = cmdstr

            cmd.ExecuteNonQuery()
            MessageBox.Show("Stock is added successfully", "Feedback")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim r As DialogResult
        r = MessageBox.Show("Do you really want to delete current Stock details along with all the details ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If r = DialogResult.No Then
            Return
        End If

        con = New SqlConnection
        con.ConnectionString = "data source=VB;initial catalog=Pharmacy;user id=Dharm;pwd=1212"
        con.Open()
        cmd = New SqlCommand
        cmd.Connection = con

        Dim s As String
        s = "delete from StockDetails where stid =" + TextBox1.Text
        cmd.CommandText = s



        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Stock Details successfully deleted")
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con = New SqlConnection
        con.ConnectionString = "data source=VB;initial catalog=Pharmacy;user id=Dharm;pwd=1212"
        con.Open()
        cmd = New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "select * from StockDetails"
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        ds = New DataSet

        da.Fill(ds, "StockDetails")

        DataGrid1.DataSource() = ds


    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub
End Class
