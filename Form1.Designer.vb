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
        PanelListado = New Panel()
        Button2 = New Button()
        DataGridView1 = New DataGridView()
        PanelFormulario = New Panel()
        TxtEdad = New NumericUpDown()
        TxtId = New NumericUpDown()
        Label2 = New Label()
        Label1 = New Label()
        Nombre = New Label()
        LabelId = New Label()
        Button1 = New Button()
        TxtApellido = New TextBox()
        TxtNombre = New TextBox()
        MenuStrip1 = New MenuStrip()
        ListarClientesToolStripMenuItem = New ToolStripMenuItem()
        PanelEditar = New Panel()
        TxtEditarEdad = New NumericUpDown()
        TxtEditarID = New NumericUpDown()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button3 = New Button()
        TxtEditarApellido = New TextBox()
        TxtEditarNombre = New TextBox()
        Editar = New DataGridViewButtonColumn()
        Borrar = New DataGridViewButtonColumn()
        PanelListado.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        PanelFormulario.SuspendLayout()
        CType(TxtEdad, ComponentModel.ISupportInitialize).BeginInit()
        CType(TxtId, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        PanelEditar.SuspendLayout()
        CType(TxtEditarEdad, ComponentModel.ISupportInitialize).BeginInit()
        CType(TxtEditarID, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelListado
        ' 
        PanelListado.Controls.Add(Button2)
        PanelListado.Controls.Add(DataGridView1)
        PanelListado.Dock = DockStyle.Fill
        PanelListado.Location = New Point(0, 28)
        PanelListado.Name = "PanelListado"
        PanelListado.Size = New Size(800, 464)
        PanelListado.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(12, 423)
        Button2.Name = "Button2"
        Button2.Size = New Size(240, 29)
        Button2.TabIndex = 1
        Button2.Text = "Agregar Cliente"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Editar, Borrar})
        DataGridView1.Location = New Point(12, 14)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(776, 403)
        DataGridView1.TabIndex = 0
        ' 
        ' PanelFormulario
        ' 
        PanelFormulario.Controls.Add(TxtEdad)
        PanelFormulario.Controls.Add(TxtId)
        PanelFormulario.Controls.Add(Label2)
        PanelFormulario.Controls.Add(Label1)
        PanelFormulario.Controls.Add(Nombre)
        PanelFormulario.Controls.Add(LabelId)
        PanelFormulario.Controls.Add(Button1)
        PanelFormulario.Controls.Add(TxtApellido)
        PanelFormulario.Controls.Add(TxtNombre)
        PanelFormulario.Dock = DockStyle.Fill
        PanelFormulario.Location = New Point(0, 28)
        PanelFormulario.Name = "PanelFormulario"
        PanelFormulario.Size = New Size(800, 464)
        PanelFormulario.TabIndex = 1
        PanelFormulario.Visible = False
        ' 
        ' TxtEdad
        ' 
        TxtEdad.Location = New Point(127, 144)
        TxtEdad.Name = "TxtEdad"
        TxtEdad.Size = New Size(150, 27)
        TxtEdad.TabIndex = 10
        ' 
        ' TxtId
        ' 
        TxtId.Location = New Point(127, 34)
        TxtId.Name = "TxtId"
        TxtId.Size = New Size(150, 27)
        TxtId.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 20)
        Label2.TabIndex = 8
        Label2.Text = "Edad"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 111)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 20)
        Label1.TabIndex = 7
        Label1.Text = "Apellido"
        ' 
        ' Nombre
        ' 
        Nombre.AutoSize = True
        Nombre.Location = New Point(48, 74)
        Nombre.Name = "Nombre"
        Nombre.Size = New Size(64, 20)
        Nombre.TabIndex = 6
        Nombre.Text = "Nombre"
        ' 
        ' LabelId
        ' 
        LabelId.AutoSize = True
        LabelId.Location = New Point(48, 41)
        LabelId.Name = "LabelId"
        LabelId.Size = New Size(22, 20)
        LabelId.TabIndex = 5
        LabelId.Text = "Id"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(127, 179)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 4
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TxtApellido
        ' 
        TxtApellido.Location = New Point(127, 108)
        TxtApellido.Name = "TxtApellido"
        TxtApellido.Size = New Size(125, 27)
        TxtApellido.TabIndex = 2
        ' 
        ' TxtNombre
        ' 
        TxtNombre.Location = New Point(127, 72)
        TxtNombre.Name = "TxtNombre"
        TxtNombre.Size = New Size(125, 27)
        TxtNombre.TabIndex = 1
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ListarClientesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ListarClientesToolStripMenuItem
        ' 
        ListarClientesToolStripMenuItem.Name = "ListarClientesToolStripMenuItem"
        ListarClientesToolStripMenuItem.Size = New Size(114, 24)
        ListarClientesToolStripMenuItem.Text = "Listar Clientes"
        ' 
        ' PanelEditar
        ' 
        PanelEditar.Controls.Add(TxtEditarEdad)
        PanelEditar.Controls.Add(TxtEditarID)
        PanelEditar.Controls.Add(Label3)
        PanelEditar.Controls.Add(Label4)
        PanelEditar.Controls.Add(Label5)
        PanelEditar.Controls.Add(Label6)
        PanelEditar.Controls.Add(Button3)
        PanelEditar.Controls.Add(TxtEditarApellido)
        PanelEditar.Controls.Add(TxtEditarNombre)
        PanelEditar.Dock = DockStyle.Fill
        PanelEditar.Location = New Point(0, 28)
        PanelEditar.Name = "PanelEditar"
        PanelEditar.Size = New Size(800, 464)
        PanelEditar.TabIndex = 2
        PanelEditar.Visible = False
        ' 
        ' TxtEditarEdad
        ' 
        TxtEditarEdad.Location = New Point(114, 144)
        TxtEditarEdad.Name = "TxtEditarEdad"
        TxtEditarEdad.Size = New Size(150, 27)
        TxtEditarEdad.TabIndex = 19
        ' 
        ' TxtEditarID
        ' 
        TxtEditarID.Location = New Point(114, 34)
        TxtEditarID.Name = "TxtEditarID"
        TxtEditarID.Size = New Size(150, 27)
        TxtEditarID.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(35, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 20)
        Label3.TabIndex = 17
        Label3.Text = "Edad"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(35, 111)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 20)
        Label4.TabIndex = 16
        Label4.Text = "Apellido"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(35, 74)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 20)
        Label5.TabIndex = 15
        Label5.Text = "Nombre"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(35, 41)
        Label6.Name = "Label6"
        Label6.Size = New Size(22, 20)
        Label6.TabIndex = 14
        Label6.Text = "Id"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(114, 179)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 13
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TxtEditarApellido
        ' 
        TxtEditarApellido.Location = New Point(114, 108)
        TxtEditarApellido.Name = "TxtEditarApellido"
        TxtEditarApellido.Size = New Size(125, 27)
        TxtEditarApellido.TabIndex = 12
        ' 
        ' TxtEditarNombre
        ' 
        TxtEditarNombre.Location = New Point(114, 72)
        TxtEditarNombre.Name = "TxtEditarNombre"
        TxtEditarNombre.Size = New Size(125, 27)
        TxtEditarNombre.TabIndex = 11
        ' 
        ' Editar
        ' 
        Editar.HeaderText = "Editar"
        Editar.MinimumWidth = 6
        Editar.Name = "Editar"
        Editar.Text = "Editar"
        Editar.UseColumnTextForButtonValue = True
        Editar.Width = 125
        ' 
        ' Borrar
        ' 
        Borrar.HeaderText = "Borrar"
        Borrar.MinimumWidth = 6
        Borrar.Name = "Borrar"
        Borrar.Resizable = DataGridViewTriState.True
        Borrar.SortMode = DataGridViewColumnSortMode.Automatic
        Borrar.Text = "Borrar"
        Borrar.UseColumnTextForButtonValue = True
        Borrar.Width = 125
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 492)
        Controls.Add(PanelListado)
        Controls.Add(PanelEditar)
        Controls.Add(PanelFormulario)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        PanelListado.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        PanelFormulario.ResumeLayout(False)
        PanelFormulario.PerformLayout()
        CType(TxtEdad, ComponentModel.ISupportInitialize).EndInit()
        CType(TxtId, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        PanelEditar.ResumeLayout(False)
        PanelEditar.PerformLayout()
        CType(TxtEditarEdad, ComponentModel.ISupportInitialize).EndInit()
        CType(TxtEditarID, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PanelListado As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PanelFormulario As Panel
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Nombre As Label
    Friend WithEvents LabelId As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtEdad As NumericUpDown
    Friend WithEvents TxtId As NumericUpDown
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ListarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button
    Friend WithEvents PanelEditar As Panel
    Friend WithEvents TxtEditarEdad As NumericUpDown
    Friend WithEvents TxtEditarID As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TxtEditarApellido As TextBox
    Friend WithEvents TxtEditarNombre As TextBox
    Friend WithEvents Editar As DataGridViewButtonColumn
    Friend WithEvents Borrar As DataGridViewButtonColumn
End Class
