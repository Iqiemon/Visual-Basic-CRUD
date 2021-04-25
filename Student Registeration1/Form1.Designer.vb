<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.PictureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TableRegBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.DatabaseReg1DataSet = New Student_Registeration1.DatabaseReg1DataSet()
		Me.Button10 = New System.Windows.Forms.Button()
		Me.Button9 = New System.Windows.Forms.Button()
		Me.Button8 = New System.Windows.Forms.Button()
		Me.Button7 = New System.Windows.Forms.Button()
		Me.Button6 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TableRegTableAdapter = New Student_Registeration1.DatabaseReg1DataSetTableAdapters.TableRegTableAdapter()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.NameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
		Me.NameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
		Me.SearchToolStripButton = New System.Windows.Forms.ToolStripButton()
		Me.SearchToolStrip = New System.Windows.Forms.ToolStrip()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TableRegBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DatabaseReg1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SearchToolStrip.SuspendLayout()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.PictureBox1.Image = Global.Student_Registeration1.My.Resources.Resources.Logo_POU
		Me.PictureBox1.Location = New System.Drawing.Point(610, 39)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(79, 87)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 43
		Me.PictureBox1.TabStop = False
		'
		'DataGridView1
		'
		Me.DataGridView1.AutoGenerateColumns = False
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PhoneDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PictureDataGridViewTextBoxColumn})
		Me.DataGridView1.DataSource = Me.TableRegBindingSource
		Me.DataGridView1.Location = New System.Drawing.Point(103, 429)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(533, 243)
		Me.DataGridView1.TabIndex = 42
		'
		'IDDataGridViewTextBoxColumn
		'
		Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
		Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
		Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
		'
		'NameDataGridViewTextBoxColumn
		'
		Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
		Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
		Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
		'
		'PhoneDataGridViewTextBoxColumn
		'
		Me.PhoneDataGridViewTextBoxColumn.DataPropertyName = "Phone"
		Me.PhoneDataGridViewTextBoxColumn.HeaderText = "Phone"
		Me.PhoneDataGridViewTextBoxColumn.Name = "PhoneDataGridViewTextBoxColumn"
		'
		'AddressDataGridViewTextBoxColumn
		'
		Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
		Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
		Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
		'
		'PictureDataGridViewTextBoxColumn
		'
		Me.PictureDataGridViewTextBoxColumn.DataPropertyName = "Picture"
		Me.PictureDataGridViewTextBoxColumn.HeaderText = "Picture"
		Me.PictureDataGridViewTextBoxColumn.Name = "PictureDataGridViewTextBoxColumn"
		'
		'TableRegBindingSource
		'
		Me.TableRegBindingSource.DataMember = "TableReg"
		Me.TableRegBindingSource.DataSource = Me.DatabaseReg1DataSet
		'
		'DatabaseReg1DataSet
		'
		Me.DatabaseReg1DataSet.DataSetName = "DatabaseReg1DataSet"
		Me.DatabaseReg1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'Button10
		'
		Me.Button10.Location = New System.Drawing.Point(511, 370)
		Me.Button10.Name = "Button10"
		Me.Button10.Size = New System.Drawing.Size(96, 35)
		Me.Button10.TabIndex = 41
		Me.Button10.Text = "Close"
		Me.Button10.UseVisualStyleBackColor = True
		'
		'Button9
		'
		Me.Button9.Location = New System.Drawing.Point(409, 370)
		Me.Button9.Name = "Button9"
		Me.Button9.Size = New System.Drawing.Size(96, 35)
		Me.Button9.TabIndex = 40
		Me.Button9.Text = "Last"
		Me.Button9.UseVisualStyleBackColor = True
		'
		'Button8
		'
		Me.Button8.Location = New System.Drawing.Point(307, 370)
		Me.Button8.Name = "Button8"
		Me.Button8.Size = New System.Drawing.Size(96, 35)
		Me.Button8.TabIndex = 39
		Me.Button8.Text = "First"
		Me.Button8.UseVisualStyleBackColor = True
		'
		'Button7
		'
		Me.Button7.Location = New System.Drawing.Point(205, 370)
		Me.Button7.Name = "Button7"
		Me.Button7.Size = New System.Drawing.Size(96, 35)
		Me.Button7.TabIndex = 38
		Me.Button7.Text = "Next"
		Me.Button7.UseVisualStyleBackColor = True
		'
		'Button6
		'
		Me.Button6.Location = New System.Drawing.Point(103, 370)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(96, 35)
		Me.Button6.TabIndex = 37
		Me.Button6.Text = "Previous"
		Me.Button6.UseVisualStyleBackColor = True
		'
		'Button5
		'
		Me.Button5.Location = New System.Drawing.Point(511, 329)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(96, 35)
		Me.Button5.TabIndex = 36
		Me.Button5.Text = "Browse"
		Me.Button5.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Location = New System.Drawing.Point(409, 329)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(96, 35)
		Me.Button4.TabIndex = 35
		Me.Button4.Text = "Remove"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(307, 329)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(96, 35)
		Me.Button3.TabIndex = 34
		Me.Button3.Text = "Search"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(205, 329)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(96, 35)
		Me.Button2.TabIndex = 33
		Me.Button2.Text = "Save"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(103, 329)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(96, 35)
		Me.Button1.TabIndex = 32
		Me.Button1.Text = "New"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label6.Location = New System.Drawing.Point(552, 140)
		Me.Label6.Name = "Label6"
		Me.Label6.Padding = New System.Windows.Forms.Padding(50)
		Me.Label6.Size = New System.Drawing.Size(172, 128)
		Me.Label6.TabIndex = 31
		Me.Label6.Text = "PHOTO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Not Available"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBox4
		'
		Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableRegBindingSource, "Picture", True))
		Me.TextBox4.Location = New System.Drawing.Point(191, 264)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(305, 20)
		Me.TextBox4.TabIndex = 30
		'
		'TextBox3
		'
		Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableRegBindingSource, "Address", True))
		Me.TextBox3.Location = New System.Drawing.Point(191, 230)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(305, 20)
		Me.TextBox3.TabIndex = 29
		'
		'TextBox2
		'
		Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableRegBindingSource, "Phone", True))
		Me.TextBox2.Location = New System.Drawing.Point(191, 195)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(305, 20)
		Me.TextBox2.TabIndex = 28
		'
		'TextBox1
		'
		Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TableRegBindingSource, "Name", True))
		Me.TextBox1.Location = New System.Drawing.Point(191, 156)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(305, 20)
		Me.TextBox1.TabIndex = 27
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(100, 267)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(40, 13)
		Me.Label5.TabIndex = 26
		Me.Label5.Text = "Picture"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(100, 233)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(45, 13)
		Me.Label4.TabIndex = 25
		Me.Label4.Text = "Address"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(100, 198)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(78, 13)
		Me.Label3.TabIndex = 24
		Me.Label3.Text = "Phone Number"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(100, 159)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(35, 13)
		Me.Label2.TabIndex = 23
		Me.Label2.Text = "Name"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(128, 39)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(465, 37)
		Me.Label1.TabIndex = 22
		Me.Label1.Text = "Student Registeration System"
		'
		'TableRegTableAdapter
		'
		Me.TableRegTableAdapter.ClearBeforeFill = True
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'PictureBox2
		'
		Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.PictureBox2.Location = New System.Drawing.Point(552, 140)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(172, 179)
		Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox2.TabIndex = 45
		Me.PictureBox2.TabStop = False
		'
		'NameToolStripLabel
		'
		Me.NameToolStripLabel.Name = "NameToolStripLabel"
		Me.NameToolStripLabel.Size = New System.Drawing.Size(42, 22)
		Me.NameToolStripLabel.Text = "Name:"
		'
		'NameToolStripTextBox
		'
		Me.NameToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.NameToolStripTextBox.Name = "NameToolStripTextBox"
		Me.NameToolStripTextBox.Size = New System.Drawing.Size(100, 25)
		'
		'SearchToolStripButton
		'
		Me.SearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
		Me.SearchToolStripButton.Name = "SearchToolStripButton"
		Me.SearchToolStripButton.Size = New System.Drawing.Size(46, 22)
		Me.SearchToolStripButton.Text = "Search"
		'
		'SearchToolStrip
		'
		Me.SearchToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameToolStripLabel, Me.NameToolStripTextBox, Me.SearchToolStripButton})
		Me.SearchToolStrip.Location = New System.Drawing.Point(0, 0)
		Me.SearchToolStrip.Name = "SearchToolStrip"
		Me.SearchToolStrip.Size = New System.Drawing.Size(777, 25)
		Me.SearchToolStrip.TabIndex = 44
		Me.SearchToolStrip.Text = "SearchToolStrip"
		'
		'Form1
		'
		Me.AcceptButton = Me.Button1
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Khaki
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.ClientSize = New System.Drawing.Size(777, 684)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.SearchToolStrip)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Button10)
		Me.Controls.Add(Me.Button9)
		Me.Controls.Add(Me.Button8)
		Me.Controls.Add(Me.Button7)
		Me.Controls.Add(Me.Button6)
		Me.Controls.Add(Me.Button5)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.TextBox4)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.DoubleBuffered = True
		Me.Name = "Form1"
		Me.Text = "Student Registration Form"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TableRegBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DatabaseReg1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SearchToolStrip.ResumeLayout(False)
		Me.SearchToolStrip.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DatabaseReg1DataSet As DatabaseReg1DataSet
    Friend WithEvents TableRegBindingSource As BindingSource
    Friend WithEvents TableRegTableAdapter As DatabaseReg1DataSetTableAdapters.TableRegTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PictureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents NameToolStripLabel As ToolStripLabel
    Friend WithEvents NameToolStripTextBox As ToolStripTextBox
    Friend WithEvents SearchToolStripButton As ToolStripButton
    Friend WithEvents SearchToolStrip As ToolStrip
End Class
