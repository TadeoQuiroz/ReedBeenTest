﻿Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Pantalla_Administracion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        Dim Box = New Registro_de_Ventas()
        Me.Hide()
        Box.Show()

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs)
        Dim Box = New Registro_de_Articulos

        Box.Show()
        Box.MdiParent = Me

        Box.Location = New Point(241, 63)

    End Sub
End Class
