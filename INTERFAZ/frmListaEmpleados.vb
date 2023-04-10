Imports LOGICA
Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Properties
Imports iText.IO.Image
Imports iText.Kernel.Colors

Public Class frmListaEmpleados
    Private Sub frmListaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EmpleadosSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter1.Fill(Me.EmpleadosSet.Empleados)
        'TODO: esta línea de código carga datos en la tabla 'EmpleadosDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.EmpleadosDataSet.Empleados)

    End Sub
    Private Sub cargarListadoEmpleados()
        Try
            Me.DataGridView1.DataSource = BLLempleados.listarEmpleados(Me.nombreTextBox.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al cargar lista", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub nombreTextBox_TextChanged(sender As Object, e As EventArgs) Handles nombreTextBox.TextChanged
        cargarListadoEmpleados()
    End Sub

    Private Sub btnPdf_Click(sender As Object, e As EventArgs) Handles btnPdf.Click
        ' Crear un objeto SaveFileDialog para que el usuario seleccione la ubicación y el nombre del archivo PDF
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
        saveFileDialog.Title = "Guardar archivo PDF"
        saveFileDialog.ShowDialog()

        ' Si el usuario hace clic en el botón "Guardar" del SaveFileDialog, llamar a la función ExportarDataGridViewAPDF para exportar el DataGridView a un archivo PDF
        If saveFileDialog.FileName <> "" And DialogResult.OK Then
            ExportarDataGridViewAPDF(DataGridView1, saveFileDialog.FileName)
            MessageBox.Show("El DataGridView se ha exportado correctamente a un archivo PDF en la ubicación seleccionada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub ExportarDataGridViewAPDF(dataGridView As DataGridView, nombreArchivo As String)
        ' Crear el documento con un tamaño de página personalizado
        Dim pageSize As New iText.Kernel.Geom.PageSize(800, 600)

        ' Crear un objeto PdfWriter a partir del nombre de archivo especificado
        Dim pdfWriter As New PdfWriter(nombreArchivo)

        ' Crear un objeto PdfDocument a partir del objeto PdfWriter
        Dim pdfDocument As New PdfDocument(pdfWriter)
        pdfDocument.SetDefaultPageSize(pageSize)

        ' Crear un objeto Document a partir del objeto PdfDocument
        Dim document As New Document(pdfDocument)

        'Agregar una imagen al documento PDF
        Dim imageFile As String = "C:\Proyectos Visual\WindowsAppCrud\INTERFAZ\Resources\logoItea.png"
        Dim imagen As Image = New Image(ImageDataFactory.Create(imageFile))
        imagen.SetWidth(142)
        imagen.SetHeight(55)
        document.Add(imagen)

        ' Agregar un encabezado al PDF
        Dim encabezado As New Paragraph()
        encabezado.Add(New Paragraph("Lista de Empleados :"))
        document.Add(encabezado)

        ' Crear una tabla iText a partir de los datos del DataGridView
        Dim tabla As New Table(dataGridView.Columns.Count)
        tabla.SetWidth(UnitValue.CreatePercentValue(100))

        ' Agregar las celdas de encabezado a la tabla
        For Each columna As DataGridViewColumn In dataGridView.Columns
            Dim celdaEncabezado As New Cell()
            celdaEncabezado.Add(New Paragraph(columna.HeaderText)).SetTextAlignment(TextAlignment.CENTER)
            celdaEncabezado.SetBackgroundColor(New DeviceRgb(200, 200, 200))
            tabla.AddHeaderCell(celdaEncabezado)
        Next

        ' Agregar las filas de datos a la tabla
        For Each fila As DataGridViewRow In dataGridView.Rows
            For Each celda As DataGridViewCell In fila.Cells
                tabla.AddCell(New Cell().Add(New Paragraph(celda.Value.ToString())))
            Next
        Next

        ' Agregar la tabla al objeto Document
        document.Add(tabla)

        ' Agregar un pie de página al PDF
        Dim piePagina As New Paragraph()
        piePagina.Add(New Paragraph(System.DateTime.Now))
        document.Add(piePagina)

        ' Cerrar el objeto Document y guardar el PDF
        document.Close()
    End Sub


End Class