﻿Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D
Imports LOGICA
Public Class modalEliminarEmpleado
    Public idEmpleado As Integer
    'Fields
    Private borderRadius As Integer = 20
    Private borderSize As Integer = 2
    Private borderColor As Color = Color.FromArgb(43, 87, 152)
    'Constructor
    Public Sub New()
        ' Esta llamada es requerida por el diseñador.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Padding = New Padding(borderSize)
        Me.PanelTitleBar.BackColor = borderColor
        Me.BackColor = Color.FromArgb(11, 7, 47)
    End Sub

    'Métodos para poder arrastrar el formulario con el ratón
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub panelTitleBar_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, PanelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    'Minimize borderless form from taskbar
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.Style = cp.Style Or &H20000 '<--- Minimize borderless form from taskbar
            Return cp
        End Get
    End Property
    'Ruta redondeada
    Private Function GetRoundedPath(rect As Rectangle, radius As Single) As GraphicsPath
        Dim path As GraphicsPath = New GraphicsPath()
        Dim curveSize As Single = radius * 2.0F
        path.StartFigure()
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90)
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90)
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90)
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90)
        path.CloseFigure()
        Return path
    End Function
    'Establecer Región y Borde Redondeado – Formulario
    Private Sub FormRegionAndBorder(form As Form, radius As Single, graph As Graphics, borderColor As Color, borderSize As Single)
        If Me.WindowState <> FormWindowState.Minimized Then
            Using roundPath As GraphicsPath = GetRoundedPath(form.ClientRectangle, radius)
                Using penBorder As Pen = New Pen(borderColor, borderSize)
                    Using transform As Matrix = New Matrix()

                        graph.SmoothingMode = SmoothingMode.AntiAlias
                        form.Region = New Region(roundPath)
                        If borderSize >= 1 Then
                            Dim rect As Rectangle = form.ClientRectangle
                            Dim scaleX As Single = 1.0F - ((borderSize + 1) / rect.Width)
                            Dim scaleY As Single = 1.0F - ((borderSize + 1) / rect.Height)
                            transform.Scale(scaleX, scaleY)
                            transform.Translate(borderSize / 1.6F, borderSize / 1.6F)
                            graph.Transform = transform
                            graph.DrawPath(penBorder, roundPath)
                        End If

                    End Using
                End Using
            End Using
        End If
    End Sub
    'Establecer Región y Borde Redondeado – Panel Contenedor
    Private Sub ControlRegionAndBorder(control As Control, radius As Single, graph As Graphics, borderColor As Color)
        Using roundPath As GraphicsPath = GetRoundedPath(control.ClientRectangle, radius)

            Using penBorder As Pen = New Pen(borderColor, 1)
                graph.SmoothingMode = SmoothingMode.AntiAlias
                control.Region = New Region(roundPath)
                graph.DrawPath(penBorder, roundPath)
            End Using
        End Using
    End Sub
    'Dibujar Rutas – Esquinas del Formulario
    Private Sub DrawPath(rectForm As Rectangle, graphics As Graphics, color As Color)
        Using roundPath As GraphicsPath = GetRoundedPath(rectForm, borderRadius)
            Using penBorder As Pen = New Pen(color, 3)
                graphics.DrawPath(penBorder, roundPath)
            End Using
        End Using
    End Sub
    'Obtener Colores de los Limites Exteriores del Formulario
    Private Structure FormBoundsColors
        Public TopLeftColor As Color
        Public TopRightColor As Color
        Public BottomLeftColor As Color
        Public BottomRightColor As Color
    End Structure
    Private Function GetFormBoundsColors() As FormBoundsColors
        Dim fbColor = New FormBoundsColors()
        Using bmp = New Bitmap(1, 1)
            Using graph As Graphics = Graphics.FromImage(bmp)
                Dim rectBmp As New Rectangle(0, 0, 1, 1)
                'Top Left
                rectBmp.X = Me.Bounds.X - 1
                rectBmp.Y = Me.Bounds.Y
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size)
                fbColor.TopLeftColor = bmp.GetPixel(0, 0)
                'Top Right
                rectBmp.X = Me.Bounds.Right
                rectBmp.Y = Me.Bounds.Y
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size)
                fbColor.TopRightColor = bmp.GetPixel(0, 0)
                'Bottom Left
                rectBmp.X = Me.Bounds.X
                rectBmp.Y = Me.Bounds.Bottom
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size)
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0)
                'Bottom Right
                rectBmp.X = Me.Bounds.Right
                rectBmp.Y = Me.Bounds.Bottom
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size)
                fbColor.BottomRightColor = bmp.GetPixel(0, 0)
            End Using
        End Using
        Return fbColor
    End Function
    'Establecer Región Redondeado y Dibujar Borde + Suavizado (Formulario)
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        '-> Smooth Outer Border
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Dim rectForm As Rectangle = Me.ClientRectangle
        Dim mWidht As Integer = rectForm.Width / 2
        Dim mHeight As Integer = rectForm.Height / 2
        Dim fbColor = GetFormBoundsColors()

        'Top Left
        DrawPath(rectForm, e.Graphics, fbColor.TopLeftColor)

        'Top Right
        Dim rectTopRight As New Rectangle(rectForm.Right - mWidht, rectForm.Y, mWidht, mHeight)
        DrawPath(rectTopRight, e.Graphics, fbColor.TopRightColor)

        'Bottom Left
        Dim rectBottomLeft As New Rectangle(rectForm.X, rectForm.Bottom - mHeight, mWidht, mHeight)
        DrawPath(rectBottomLeft, e.Graphics, fbColor.BottomLeftColor)

        'Bottom Right
        Dim rectBottomRight As New Rectangle(rectForm.Right - mWidht, rectForm.Bottom - mHeight, mWidht, mHeight)
        DrawPath(rectBottomRight, e.Graphics, fbColor.BottomRightColor)

        '-> Set Rounded Region and Border
        FormRegionAndBorder(Me, borderRadius, e.Graphics, borderColor, borderSize)
    End Sub
    'Establecer Región Redondeado y Dibujar Borde Fino (Panel Contenedor)
    Private Sub PanelContainer_Paint(sender As Object, e As PaintEventArgs) Handles PanelContainer.Paint
        ControlRegionAndBorder(PanelContainer, borderRadius - (borderSize / 2.0F), e.Graphics, borderColor)
    End Sub
    'Actualizar Región y Borde
    Private Sub Form1_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        Me.Invalidate()
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Me.Invalidate()
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Invalidate()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        BLLempleados.eliminarEmpleado(idEmpleado)
        Me.Close()
    End Sub
End Class