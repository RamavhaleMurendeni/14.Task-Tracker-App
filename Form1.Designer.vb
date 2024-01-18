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
        btnAddTask = New Button()
        txtTaskName = New TextBox()
        txtDescription = New TextBox()
        dtpDueDate = New DateTimePicker()
        DataGridView1 = New DataGridView()
        btnEditTask = New Button()
        btnDeleteTask = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAddTask
        ' 
        btnAddTask.BackColor = Color.Chartreuse
        btnAddTask.Location = New Point(155, 361)
        btnAddTask.Name = "btnAddTask"
        btnAddTask.Size = New Size(118, 38)
        btnAddTask.TabIndex = 0
        btnAddTask.Text = "Add Task"
        btnAddTask.UseVisualStyleBackColor = False
        ' 
        ' txtTaskName
        ' 
        txtTaskName.Location = New Point(373, 36)
        txtTaskName.Name = "txtTaskName"
        txtTaskName.Size = New Size(200, 23)
        txtTaskName.TabIndex = 1
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(373, 78)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(200, 23)
        txtDescription.TabIndex = 2
        ' 
        ' dtpDueDate
        ' 
        dtpDueDate.Location = New Point(373, 133)
        dtpDueDate.Name = "dtpDueDate"
        dtpDueDate.Size = New Size(200, 23)
        dtpDueDate.TabIndex = 3
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(254, 173)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(335, 150)
        DataGridView1.TabIndex = 4
        ' 
        ' btnEditTask
        ' 
        btnEditTask.BackColor = Color.Yellow
        btnEditTask.Location = New Point(370, 359)
        btnEditTask.Name = "btnEditTask"
        btnEditTask.Size = New Size(101, 38)
        btnEditTask.TabIndex = 5
        btnEditTask.Text = "Edit Task"
        btnEditTask.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteTask
        ' 
        btnDeleteTask.BackColor = Color.Crimson
        btnDeleteTask.Location = New Point(559, 359)
        btnDeleteTask.Name = "btnDeleteTask"
        btnDeleteTask.Size = New Size(102, 40)
        btnDeleteTask.TabIndex = 6
        btnDeleteTask.Text = "Delete Task"
        btnDeleteTask.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(254, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 15)
        Label1.TabIndex = 7
        Label1.Text = "Enter The task Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(254, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 15)
        Label2.TabIndex = 8
        Label2.Text = "Enter Description"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(261, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 15)
        Label3.TabIndex = 9
        Label3.Text = "Choose Date"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(800, 424)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnDeleteTask)
        Controls.Add(btnEditTask)
        Controls.Add(DataGridView1)
        Controls.Add(dtpDueDate)
        Controls.Add(txtDescription)
        Controls.Add(txtTaskName)
        Controls.Add(btnAddTask)
        Name = "Form1"
        Text = "Task Tracker"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAddTask As Button
    Friend WithEvents txtTaskName As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnEditTask As Button
    Friend WithEvents btnDeleteTask As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
