﻿Public Class Setup
    Dim g As System.Drawing.Graphics
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'GroupBox2.Enabled = False
        GroupBox2.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GroupBox1.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GroupBox2.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button7.Enabled = True
        Button7.Visible = True
        Button6.Enabled = False
        Button6.Visible = False

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7.Enabled = False
        Button7.Visible = False
        Button6.Enabled = True
        Button6.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text > 20 Then
            TextBox1.Text = 40
        End If

    End Sub

    Private Sub Setup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Alarm_ManagementDataSet.Alarms_Database' table. You can move, or remove it, as needed.
        Me.Alarms_DatabaseTableAdapter.Fill(Me.Alarm_ManagementDataSet.Alarms_Database)

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Alarms_DatabaseBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Alarms_DatabaseBindingSource.Clear()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Validate()
        Me.Alarms_DatabaseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Alarm_ManagementDataSet)
    End Sub
End Class