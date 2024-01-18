Public Class Form1

    ' DataTable to store tasks
    Dim tasksTable As New DataTable

    ' Index of the selected task
    Dim selectedTaskIndex As Integer = -1

    ' variables as needed for task details
    Dim taskName As String
    Dim taskDescription As String
    Dim dueDate As Date

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up the DataGridView
        tasksTable.Columns.Add("Task Name", GetType(String))
        tasksTable.Columns.Add("Description", GetType(String))
        tasksTable.Columns.Add("Due Date", GetType(Date))

        DataGridView1.DataSource = tasksTable
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddTask.Click

        ' Add a new task to the DataTable
        tasksTable.Rows.Add(txtTaskName.Text, txtDescription.Text, dtpDueDate.Value)

        ' Clear input fields
        txtTaskName.Clear()
        txtDescription.Clear()
        dtpDueDate.Value = Date.Now

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTaskName.TextChanged

    End Sub

    Private Sub btnEditTask_Click(sender As Object, e As EventArgs) Handles btnEditTask.Click

        ' Check if a row is selected
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Update the selected task
            Dim selectedRow = DataGridView1.SelectedRows(0)
            selectedRow.Cells("Task Name").Value = txtTaskName.Text
            selectedRow.Cells("Description").Value = txtDescription.Text
            selectedRow.Cells("Due Date").Value = dtpDueDate.Value

            ' Clear input fields
            txtTaskName.Clear()
            txtDescription.Clear()
            dtpDueDate.Value = Date.Now
        End If

    End Sub

    Private Sub btnDeleteTask_Click(sender As Object, e As EventArgs) Handles btnDeleteTask.Click

        ' Check if a row is selected
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Remove the selected task
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        End If

    End Sub
End Class



