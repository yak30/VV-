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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TSexBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New vb_NN.DataSet1()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TAgeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EthnicityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TEthnicityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuildDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TBuildBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EducationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TEducationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CitizenshipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TCitizenshipBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HobbiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.THobbiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinancialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TFinancialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FamilyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.TFamilyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LikeIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBoxYSex = New System.Windows.Forms.ComboBox()
        Me.TSexBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxMSex = New System.Windows.Forms.ComboBox()
        Me.TSexBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonTwoWay = New System.Windows.Forms.Button()
        Me.ButtonOneWay = New System.Windows.Forms.Button()
        Me.ComboBoxYFamily = New System.Windows.Forms.ComboBox()
        Me.TFamilyBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxMEthnic = New System.Windows.Forms.ComboBox()
        Me.TEthnicityBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxMFamily = New System.Windows.Forms.ComboBox()
        Me.TFamilyBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxMFinancial = New System.Windows.Forms.ComboBox()
        Me.TFinancialBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelYou = New System.Windows.Forms.Label()
        Me.ComboBoxMHobbies = New System.Windows.Forms.ComboBox()
        Me.THobbiesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelMatch = New System.Windows.Forms.Label()
        Me.ComboBoxMCitizen = New System.Windows.Forms.ComboBox()
        Me.TCitizenshipBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxYAge = New System.Windows.Forms.ComboBox()
        Me.TAgeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxMEdu = New System.Windows.Forms.ComboBox()
        Me.TEducationBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxYEthnic = New System.Windows.Forms.ComboBox()
        Me.TEthnicityBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxMBuild = New System.Windows.Forms.ComboBox()
        Me.TBuildBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxYBuild = New System.Windows.Forms.ComboBox()
        Me.TBuildBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxYEdu = New System.Windows.Forms.ComboBox()
        Me.TEducationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxMAge = New System.Windows.Forms.ComboBox()
        Me.TAgeBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxYCitizen = New System.Windows.Forms.ComboBox()
        Me.TCitizenshipBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxYHobbies = New System.Windows.Forms.ComboBox()
        Me.THobbiesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxYFinancial = New System.Windows.Forms.ComboBox()
        Me.TFinancialBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TSexTableAdapter = New vb_NN.DataSet1TableAdapters.TSexTableAdapter()
        Me.TAgeTableAdapter = New vb_NN.DataSet1TableAdapters.TAgeTableAdapter()
        Me.TFinancialTableAdapter = New vb_NN.DataSet1TableAdapters.TFinancialTableAdapter()
        Me.TEducationTableAdapter = New vb_NN.DataSet1TableAdapters.TEducationTableAdapter()
        Me.TEthnicityTableAdapter = New vb_NN.DataSet1TableAdapters.TEthnicityTableAdapter()
        Me.THobbiesTableAdapter = New vb_NN.DataSet1TableAdapters.THobbiesTableAdapter()
        Me.TCitizenshipTableAdapter = New vb_NN.DataSet1TableAdapters.TCitizenshipTableAdapter()
        Me.TFamilyTableAdapter = New vb_NN.DataSet1TableAdapters.TFamilyTableAdapter()
        Me.TBuildTableAdapter = New vb_NN.DataSet1TableAdapters.TBuildTableAdapter()
        Me.ProfileTableAdapter = New vb_NN.DataSet1TableAdapters.ProfileTableAdapter()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSexBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAgeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEthnicityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBuildBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEducationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TCitizenshipBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.THobbiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFinancialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFamilyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.TSexBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TSexBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFamilyBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEthnicityBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFamilyBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFinancialBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.THobbiesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TCitizenshipBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAgeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEducationBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEthnicityBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBuildBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBuildBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEducationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAgeBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TCitizenshipBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.THobbiesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TFinancialBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DGV)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1108, 317)
        Me.Panel1.TabIndex = 0
        '
        'DGV
        '
        Me.DGV.AllowUserToResizeColumns = False
        Me.DGV.AllowUserToResizeRows = False
        Me.DGV.AutoGenerateColumns = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.EthnicityDataGridViewTextBoxColumn, Me.BuildDataGridViewTextBoxColumn, Me.EducationDataGridViewTextBoxColumn, Me.CitizenshipDataGridViewTextBoxColumn, Me.HobbiesDataGridViewTextBoxColumn, Me.FinancialDataGridViewTextBoxColumn, Me.FamilyDataGridViewTextBoxColumn, Me.LikeIdDataGridViewTextBoxColumn})
        Me.DGV.DataSource = Me.ProfileBindingSource
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(0, 0)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(1106, 315)
        Me.DGV.TabIndex = 22
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 50
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.DataSource = Me.TSexBindingSource
        Me.SexDataGridViewTextBoxColumn.DisplayMember = "Sex"
        Me.SexDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        Me.SexDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SexDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SexDataGridViewTextBoxColumn.ValueMember = "Sex"
        '
        'TSexBindingSource
        '
        Me.TSexBindingSource.DataMember = "TSex"
        Me.TSexBindingSource.DataSource = Me.DataSetBindingSource
        '
        'DataSetBindingSource
        '
        Me.DataSetBindingSource.DataSource = Me.DataSet1
        Me.DataSetBindingSource.Position = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.DataSource = Me.TAgeBindingSource
        Me.AgeDataGridViewTextBoxColumn.DisplayMember = "Age"
        Me.AgeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AgeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.AgeDataGridViewTextBoxColumn.ValueMember = "Age"
        '
        'TAgeBindingSource
        '
        Me.TAgeBindingSource.DataMember = "TAge"
        Me.TAgeBindingSource.DataSource = Me.DataSetBindingSource
        '
        'EthnicityDataGridViewTextBoxColumn
        '
        Me.EthnicityDataGridViewTextBoxColumn.DataPropertyName = "Ethnicity"
        Me.EthnicityDataGridViewTextBoxColumn.DataSource = Me.TEthnicityBindingSource
        Me.EthnicityDataGridViewTextBoxColumn.DisplayMember = "Ethnicity"
        Me.EthnicityDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.EthnicityDataGridViewTextBoxColumn.HeaderText = "Ethnicity"
        Me.EthnicityDataGridViewTextBoxColumn.Name = "EthnicityDataGridViewTextBoxColumn"
        Me.EthnicityDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EthnicityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EthnicityDataGridViewTextBoxColumn.ValueMember = "Ethnicity"
        '
        'TEthnicityBindingSource
        '
        Me.TEthnicityBindingSource.DataMember = "TEthnicity"
        Me.TEthnicityBindingSource.DataSource = Me.DataSetBindingSource
        '
        'BuildDataGridViewTextBoxColumn
        '
        Me.BuildDataGridViewTextBoxColumn.DataPropertyName = "Build"
        Me.BuildDataGridViewTextBoxColumn.DataSource = Me.TBuildBindingSource
        Me.BuildDataGridViewTextBoxColumn.DisplayMember = "Build"
        Me.BuildDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.BuildDataGridViewTextBoxColumn.HeaderText = "Build"
        Me.BuildDataGridViewTextBoxColumn.Name = "BuildDataGridViewTextBoxColumn"
        Me.BuildDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BuildDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BuildDataGridViewTextBoxColumn.ValueMember = "Build"
        '
        'TBuildBindingSource
        '
        Me.TBuildBindingSource.DataMember = "TBuild"
        Me.TBuildBindingSource.DataSource = Me.DataSetBindingSource
        '
        'EducationDataGridViewTextBoxColumn
        '
        Me.EducationDataGridViewTextBoxColumn.DataPropertyName = "Education"
        Me.EducationDataGridViewTextBoxColumn.DataSource = Me.TEducationBindingSource
        Me.EducationDataGridViewTextBoxColumn.DisplayMember = "Education"
        Me.EducationDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.EducationDataGridViewTextBoxColumn.HeaderText = "Education"
        Me.EducationDataGridViewTextBoxColumn.Name = "EducationDataGridViewTextBoxColumn"
        Me.EducationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EducationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EducationDataGridViewTextBoxColumn.ValueMember = "Education"
        '
        'TEducationBindingSource
        '
        Me.TEducationBindingSource.DataMember = "TEducation"
        Me.TEducationBindingSource.DataSource = Me.DataSetBindingSource
        '
        'CitizenshipDataGridViewTextBoxColumn
        '
        Me.CitizenshipDataGridViewTextBoxColumn.DataPropertyName = "Citizenship"
        Me.CitizenshipDataGridViewTextBoxColumn.DataSource = Me.TCitizenshipBindingSource
        Me.CitizenshipDataGridViewTextBoxColumn.DisplayMember = "Citizenship"
        Me.CitizenshipDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.CitizenshipDataGridViewTextBoxColumn.HeaderText = "Citizenship"
        Me.CitizenshipDataGridViewTextBoxColumn.Name = "CitizenshipDataGridViewTextBoxColumn"
        Me.CitizenshipDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CitizenshipDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CitizenshipDataGridViewTextBoxColumn.ValueMember = "Citizenship"
        '
        'TCitizenshipBindingSource
        '
        Me.TCitizenshipBindingSource.DataMember = "TCitizenship"
        Me.TCitizenshipBindingSource.DataSource = Me.DataSetBindingSource
        '
        'HobbiesDataGridViewTextBoxColumn
        '
        Me.HobbiesDataGridViewTextBoxColumn.DataPropertyName = "Hobbies"
        Me.HobbiesDataGridViewTextBoxColumn.DataSource = Me.THobbiesBindingSource
        Me.HobbiesDataGridViewTextBoxColumn.DisplayMember = "Hobbies"
        Me.HobbiesDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.HobbiesDataGridViewTextBoxColumn.FillWeight = 140.0!
        Me.HobbiesDataGridViewTextBoxColumn.HeaderText = "Hobbies"
        Me.HobbiesDataGridViewTextBoxColumn.Name = "HobbiesDataGridViewTextBoxColumn"
        Me.HobbiesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HobbiesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.HobbiesDataGridViewTextBoxColumn.ValueMember = "Hobbies"
        Me.HobbiesDataGridViewTextBoxColumn.Width = 140
        '
        'THobbiesBindingSource
        '
        Me.THobbiesBindingSource.DataMember = "THobbies"
        Me.THobbiesBindingSource.DataSource = Me.DataSetBindingSource
        '
        'FinancialDataGridViewTextBoxColumn
        '
        Me.FinancialDataGridViewTextBoxColumn.DataPropertyName = "Financial"
        Me.FinancialDataGridViewTextBoxColumn.DataSource = Me.TFinancialBindingSource
        Me.FinancialDataGridViewTextBoxColumn.DisplayMember = "Financial"
        Me.FinancialDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.FinancialDataGridViewTextBoxColumn.HeaderText = "Financial"
        Me.FinancialDataGridViewTextBoxColumn.Name = "FinancialDataGridViewTextBoxColumn"
        Me.FinancialDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FinancialDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FinancialDataGridViewTextBoxColumn.ValueMember = "Financial"
        '
        'TFinancialBindingSource
        '
        Me.TFinancialBindingSource.DataMember = "TFinancial"
        Me.TFinancialBindingSource.DataSource = Me.DataSetBindingSource
        '
        'FamilyDataGridViewTextBoxColumn
        '
        Me.FamilyDataGridViewTextBoxColumn.DataPropertyName = "Family"
        Me.FamilyDataGridViewTextBoxColumn.DataSource = Me.TFamilyBindingSource
        Me.FamilyDataGridViewTextBoxColumn.DisplayMember = "Family"
        Me.FamilyDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.FamilyDataGridViewTextBoxColumn.HeaderText = "Family"
        Me.FamilyDataGridViewTextBoxColumn.Name = "FamilyDataGridViewTextBoxColumn"
        Me.FamilyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FamilyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FamilyDataGridViewTextBoxColumn.ValueMember = "Family"
        '
        'TFamilyBindingSource
        '
        Me.TFamilyBindingSource.DataMember = "TFamily"
        Me.TFamilyBindingSource.DataSource = Me.DataSetBindingSource
        '
        'LikeIdDataGridViewTextBoxColumn
        '
        Me.LikeIdDataGridViewTextBoxColumn.DataPropertyName = "LikeId"
        Me.LikeIdDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.LikeIdDataGridViewTextBoxColumn.HeaderText = "Likes"
        Me.LikeIdDataGridViewTextBoxColumn.Name = "LikeIdDataGridViewTextBoxColumn"
        Me.LikeIdDataGridViewTextBoxColumn.Width = 50
        '
        'ProfileBindingSource
        '
        Me.ProfileBindingSource.DataMember = "Profile"
        Me.ProfileBindingSource.DataSource = Me.DataSetBindingSource
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ComboBoxYSex)
        Me.Panel2.Controls.Add(Me.ComboBoxMSex)
        Me.Panel2.Controls.Add(Me.ButtonTwoWay)
        Me.Panel2.Controls.Add(Me.ButtonOneWay)
        Me.Panel2.Controls.Add(Me.ComboBoxYFamily)
        Me.Panel2.Controls.Add(Me.ComboBoxMEthnic)
        Me.Panel2.Controls.Add(Me.ComboBoxMFamily)
        Me.Panel2.Controls.Add(Me.ComboBoxMFinancial)
        Me.Panel2.Controls.Add(Me.LabelYou)
        Me.Panel2.Controls.Add(Me.ComboBoxMHobbies)
        Me.Panel2.Controls.Add(Me.LabelMatch)
        Me.Panel2.Controls.Add(Me.ComboBoxMCitizen)
        Me.Panel2.Controls.Add(Me.ComboBoxYAge)
        Me.Panel2.Controls.Add(Me.ComboBoxMEdu)
        Me.Panel2.Controls.Add(Me.ComboBoxYEthnic)
        Me.Panel2.Controls.Add(Me.ComboBoxMBuild)
        Me.Panel2.Controls.Add(Me.ComboBoxYBuild)
        Me.Panel2.Controls.Add(Me.ComboBoxYEdu)
        Me.Panel2.Controls.Add(Me.ComboBoxMAge)
        Me.Panel2.Controls.Add(Me.ComboBoxYCitizen)
        Me.Panel2.Controls.Add(Me.ComboBoxYHobbies)
        Me.Panel2.Controls.Add(Me.ComboBoxYFinancial)
        Me.Panel2.Location = New System.Drawing.Point(12, 335)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1108, 55)
        Me.Panel2.TabIndex = 1
        '
        'ComboBoxYSex
        '
        Me.ComboBoxYSex.DataSource = Me.TSexBindingSource1
        Me.ComboBoxYSex.DisplayMember = "Sex"
        Me.ComboBoxYSex.FormattingEnabled = True
        Me.ComboBoxYSex.Location = New System.Drawing.Point(45, 2)
        Me.ComboBoxYSex.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxYSex.Name = "ComboBoxYSex"
        Me.ComboBoxYSex.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxYSex.TabIndex = 47
        Me.ComboBoxYSex.ValueMember = "Id"
        '
        'TSexBindingSource1
        '
        Me.TSexBindingSource1.DataMember = "TSex"
        Me.TSexBindingSource1.DataSource = Me.DataSet1
        '
        'ComboBoxMSex
        '
        Me.ComboBoxMSex.DataSource = Me.TSexBindingSource2
        Me.ComboBoxMSex.DisplayMember = "Sex"
        Me.ComboBoxMSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBoxMSex.Enabled = False
        Me.ComboBoxMSex.FormattingEnabled = True
        Me.ComboBoxMSex.Location = New System.Drawing.Point(45, 27)
        Me.ComboBoxMSex.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxMSex.Name = "ComboBoxMSex"
        Me.ComboBoxMSex.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxMSex.TabIndex = 46
        Me.ComboBoxMSex.ValueMember = "Id"
        '
        'TSexBindingSource2
        '
        Me.TSexBindingSource2.DataMember = "TSex"
        Me.TSexBindingSource2.DataSource = Me.DataSet1
        '
        'ButtonTwoWay
        '
        Me.ButtonTwoWay.Location = New System.Drawing.Point(1007, 27)
        Me.ButtonTwoWay.Name = "ButtonTwoWay"
        Me.ButtonTwoWay.Size = New System.Drawing.Size(96, 21)
        Me.ButtonTwoWay.TabIndex = 45
        Me.ButtonTwoWay.Text = "Two-way match"
        Me.ButtonTwoWay.UseVisualStyleBackColor = True
        '
        'ButtonOneWay
        '
        Me.ButtonOneWay.Location = New System.Drawing.Point(1007, 2)
        Me.ButtonOneWay.Name = "ButtonOneWay"
        Me.ButtonOneWay.Size = New System.Drawing.Size(96, 21)
        Me.ButtonOneWay.TabIndex = 44
        Me.ButtonOneWay.Text = "One-way match"
        Me.ButtonOneWay.UseVisualStyleBackColor = True
        '
        'ComboBoxYFamily
        '
        Me.ComboBoxYFamily.DataSource = Me.TFamilyBindingSource1
        Me.ComboBoxYFamily.DisplayMember = "Family"
        Me.ComboBoxYFamily.FormattingEnabled = True
        Me.ComboBoxYFamily.Location = New System.Drawing.Point(900, 2)
        Me.ComboBoxYFamily.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxYFamily.Name = "ComboBoxYFamily"
        Me.ComboBoxYFamily.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxYFamily.TabIndex = 34
        Me.ComboBoxYFamily.ValueMember = "Id"
        '
        'TFamilyBindingSource1
        '
        Me.TFamilyBindingSource1.DataMember = "TFamily"
        Me.TFamilyBindingSource1.DataSource = Me.DataSet1
        '
        'ComboBoxMEthnic
        '
        Me.ComboBoxMEthnic.DataSource = Me.TEthnicityBindingSource2
        Me.ComboBoxMEthnic.DisplayMember = "Ethnicity"
        Me.ComboBoxMEthnic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBoxMEthnic.Enabled = False
        Me.ComboBoxMEthnic.FormattingEnabled = True
        Me.ComboBoxMEthnic.Location = New System.Drawing.Point(256, 27)
        Me.ComboBoxMEthnic.Name = "ComboBoxMEthnic"
        Me.ComboBoxMEthnic.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxMEthnic.TabIndex = 36
        Me.ComboBoxMEthnic.ValueMember = "Id"
        '
        'TEthnicityBindingSource2
        '
        Me.TEthnicityBindingSource2.DataMember = "TEthnicity"
        Me.TEthnicityBindingSource2.DataSource = Me.DataSet1
        '
        'ComboBoxMFamily
        '
        Me.ComboBoxMFamily.DataSource = Me.TFamilyBindingSource2
        Me.ComboBoxMFamily.DisplayMember = "Family"
        Me.ComboBoxMFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBoxMFamily.Enabled = False
        Me.ComboBoxMFamily.FormattingEnabled = True
        Me.ComboBoxMFamily.Location = New System.Drawing.Point(900, 27)
        Me.ComboBoxMFamily.Name = "ComboBoxMFamily"
        Me.ComboBoxMFamily.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxMFamily.TabIndex = 42
        Me.ComboBoxMFamily.ValueMember = "Id"
        '
        'TFamilyBindingSource2
        '
        Me.TFamilyBindingSource2.DataMember = "TFamily"
        Me.TFamilyBindingSource2.DataSource = Me.DataSet1
        '
        'ComboBoxMFinancial
        '
        Me.ComboBoxMFinancial.DataSource = Me.TFinancialBindingSource2
        Me.ComboBoxMFinancial.DisplayMember = "Financial"
        Me.ComboBoxMFinancial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBoxMFinancial.Enabled = False
        Me.ComboBoxMFinancial.FormattingEnabled = True
        Me.ComboBoxMFinancial.Location = New System.Drawing.Point(792, 27)
        Me.ComboBoxMFinancial.Name = "ComboBoxMFinancial"
        Me.ComboBoxMFinancial.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxMFinancial.TabIndex = 41
        Me.ComboBoxMFinancial.ValueMember = "Id"
        '
        'TFinancialBindingSource2
        '
        Me.TFinancialBindingSource2.DataMember = "TFinancial"
        Me.TFinancialBindingSource2.DataSource = Me.DataSet1
        '
        'LabelYou
        '
        Me.LabelYou.AutoSize = True
        Me.LabelYou.Location = New System.Drawing.Point(3, 5)
        Me.LabelYou.Name = "LabelYou"
        Me.LabelYou.Size = New System.Drawing.Size(26, 13)
        Me.LabelYou.TabIndex = 25
        Me.LabelYou.Text = "You"
        '
        'ComboBoxMHobbies
        '
        Me.ComboBoxMHobbies.DataSource = Me.THobbiesBindingSource2
        Me.ComboBoxMHobbies.DisplayMember = "Hobbies"
        Me.ComboBoxMHobbies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBoxMHobbies.Enabled = False
        Me.ComboBoxMHobbies.FormattingEnabled = True
        Me.ComboBoxMHobbies.Location = New System.Drawing.Point(684, 27)
        Me.ComboBoxMHobbies.Name = "ComboBoxMHobbies"
        Me.ComboBoxMHobbies.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxMHobbies.TabIndex = 40
        Me.ComboBoxMHobbies.ValueMember = "Id"
        '
        'THobbiesBindingSource2
        '
        Me.THobbiesBindingSource2.DataMember = "THobbies"
        Me.THobbiesBindingSource2.DataSource = Me.DataSet1
        '
        'LabelMatch
        '
        Me.LabelMatch.AutoSize = True
        Me.LabelMatch.Location = New System.Drawing.Point(3, 30)
        Me.LabelMatch.Name = "LabelMatch"
        Me.LabelMatch.Size = New System.Drawing.Size(37, 13)
        Me.LabelMatch.TabIndex = 26
        Me.LabelMatch.Text = "Match"
        '
        'ComboBoxMCitizen
        '
        Me.ComboBoxMCitizen.DataSource = Me.TCitizenshipBindingSource2
        Me.ComboBoxMCitizen.DisplayMember = "Citizenship"
        Me.ComboBoxMCitizen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBoxMCitizen.Enabled = False
        Me.ComboBoxMCitizen.FormattingEnabled = True
        Me.ComboBoxMCitizen.Location = New System.Drawing.Point(576, 27)
        Me.ComboBoxMCitizen.Name = "ComboBoxMCitizen"
        Me.ComboBoxMCitizen.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxMCitizen.TabIndex = 39
        Me.ComboBoxMCitizen.ValueMember = "Id"
        '
        'TCitizenshipBindingSource2
        '
        Me.TCitizenshipBindingSource2.DataMember = "TCitizenship"
        Me.TCitizenshipBindingSource2.DataSource = Me.DataSet1
        '
        'ComboBoxYAge
        '
        Me.ComboBoxYAge.DataSource = Me.TAgeBindingSource1
        Me.ComboBoxYAge.DisplayMember = "Age"
        Me.ComboBoxYAge.FormattingEnabled = True
        Me.ComboBoxYAge.Location = New System.Drawing.Point(150, 2)
        Me.ComboBoxYAge.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxYAge.Name = "ComboBoxYAge"
        Me.ComboBoxYAge.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxYAge.TabIndex = 27
        Me.ComboBoxYAge.ValueMember = "Id"
        '
        'TAgeBindingSource1
        '
        Me.TAgeBindingSource1.DataMember = "TAge"
        Me.TAgeBindingSource1.DataSource = Me.DataSet1
        '
        'ComboBoxMEdu
        '
        Me.ComboBoxMEdu.DataSource = Me.TEducationBindingSource2
        Me.ComboBoxMEdu.DisplayMember = "Education"
        Me.ComboBoxMEdu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBoxMEdu.Enabled = False
        Me.ComboBoxMEdu.FormattingEnabled = True
        Me.ComboBoxMEdu.Location = New System.Drawing.Point(468, 27)
        Me.ComboBoxMEdu.Name = "ComboBoxMEdu"
        Me.ComboBoxMEdu.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxMEdu.TabIndex = 38
        Me.ComboBoxMEdu.ValueMember = "Id"
        '
        'TEducationBindingSource2
        '
        Me.TEducationBindingSource2.DataMember = "TEducation"
        Me.TEducationBindingSource2.DataSource = Me.DataSet1
        '
        'ComboBoxYEthnic
        '
        Me.ComboBoxYEthnic.DataSource = Me.TEthnicityBindingSource1
        Me.ComboBoxYEthnic.DisplayMember = "Ethnicity"
        Me.ComboBoxYEthnic.FormattingEnabled = True
        Me.ComboBoxYEthnic.Location = New System.Drawing.Point(256, 2)
        Me.ComboBoxYEthnic.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxYEthnic.Name = "ComboBoxYEthnic"
        Me.ComboBoxYEthnic.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxYEthnic.TabIndex = 28
        Me.ComboBoxYEthnic.ValueMember = "Id"
        '
        'TEthnicityBindingSource1
        '
        Me.TEthnicityBindingSource1.DataMember = "TEthnicity"
        Me.TEthnicityBindingSource1.DataSource = Me.DataSet1
        '
        'ComboBoxMBuild
        '
        Me.ComboBoxMBuild.DataSource = Me.TBuildBindingSource2
        Me.ComboBoxMBuild.DisplayMember = "Build"
        Me.ComboBoxMBuild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBoxMBuild.Enabled = False
        Me.ComboBoxMBuild.FormattingEnabled = True
        Me.ComboBoxMBuild.Location = New System.Drawing.Point(362, 27)
        Me.ComboBoxMBuild.Name = "ComboBoxMBuild"
        Me.ComboBoxMBuild.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxMBuild.TabIndex = 37
        Me.ComboBoxMBuild.ValueMember = "Id"
        '
        'TBuildBindingSource2
        '
        Me.TBuildBindingSource2.DataMember = "TBuild"
        Me.TBuildBindingSource2.DataSource = Me.DataSet1
        '
        'ComboBoxYBuild
        '
        Me.ComboBoxYBuild.DataSource = Me.TBuildBindingSource1
        Me.ComboBoxYBuild.DisplayMember = "Build"
        Me.ComboBoxYBuild.FormattingEnabled = True
        Me.ComboBoxYBuild.Location = New System.Drawing.Point(362, 2)
        Me.ComboBoxYBuild.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxYBuild.Name = "ComboBoxYBuild"
        Me.ComboBoxYBuild.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxYBuild.TabIndex = 29
        Me.ComboBoxYBuild.ValueMember = "Id"
        '
        'TBuildBindingSource1
        '
        Me.TBuildBindingSource1.DataMember = "TBuild"
        Me.TBuildBindingSource1.DataSource = Me.DataSet1
        '
        'ComboBoxYEdu
        '
        Me.ComboBoxYEdu.DataSource = Me.TEducationBindingSource1
        Me.ComboBoxYEdu.DisplayMember = "Education"
        Me.ComboBoxYEdu.FormattingEnabled = True
        Me.ComboBoxYEdu.Location = New System.Drawing.Point(468, 2)
        Me.ComboBoxYEdu.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxYEdu.Name = "ComboBoxYEdu"
        Me.ComboBoxYEdu.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxYEdu.TabIndex = 30
        Me.ComboBoxYEdu.ValueMember = "Id"
        '
        'TEducationBindingSource1
        '
        Me.TEducationBindingSource1.DataMember = "TEducation"
        Me.TEducationBindingSource1.DataSource = Me.DataSet1
        '
        'ComboBoxMAge
        '
        Me.ComboBoxMAge.DataSource = Me.TAgeBindingSource2
        Me.ComboBoxMAge.DisplayMember = "Age"
        Me.ComboBoxMAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBoxMAge.Enabled = False
        Me.ComboBoxMAge.FormattingEnabled = True
        Me.ComboBoxMAge.Location = New System.Drawing.Point(150, 27)
        Me.ComboBoxMAge.Name = "ComboBoxMAge"
        Me.ComboBoxMAge.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxMAge.TabIndex = 35
        Me.ComboBoxMAge.ValueMember = "Id"
        '
        'TAgeBindingSource2
        '
        Me.TAgeBindingSource2.DataMember = "TAge"
        Me.TAgeBindingSource2.DataSource = Me.DataSet1
        '
        'ComboBoxYCitizen
        '
        Me.ComboBoxYCitizen.DataSource = Me.TCitizenshipBindingSource1
        Me.ComboBoxYCitizen.DisplayMember = "Citizenship"
        Me.ComboBoxYCitizen.FormattingEnabled = True
        Me.ComboBoxYCitizen.Location = New System.Drawing.Point(576, 2)
        Me.ComboBoxYCitizen.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxYCitizen.Name = "ComboBoxYCitizen"
        Me.ComboBoxYCitizen.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxYCitizen.TabIndex = 31
        Me.ComboBoxYCitizen.ValueMember = "Id"
        '
        'TCitizenshipBindingSource1
        '
        Me.TCitizenshipBindingSource1.DataMember = "TCitizenship"
        Me.TCitizenshipBindingSource1.DataSource = Me.DataSet1
        '
        'ComboBoxYHobbies
        '
        Me.ComboBoxYHobbies.DataSource = Me.THobbiesBindingSource1
        Me.ComboBoxYHobbies.DisplayMember = "Hobbies"
        Me.ComboBoxYHobbies.FormattingEnabled = True
        Me.ComboBoxYHobbies.Location = New System.Drawing.Point(684, 2)
        Me.ComboBoxYHobbies.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxYHobbies.Name = "ComboBoxYHobbies"
        Me.ComboBoxYHobbies.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxYHobbies.TabIndex = 32
        Me.ComboBoxYHobbies.ValueMember = "Id"
        '
        'THobbiesBindingSource1
        '
        Me.THobbiesBindingSource1.DataMember = "THobbies"
        Me.THobbiesBindingSource1.DataSource = Me.DataSet1
        '
        'ComboBoxYFinancial
        '
        Me.ComboBoxYFinancial.DataSource = Me.TFinancialBindingSource1
        Me.ComboBoxYFinancial.DisplayMember = "Financial"
        Me.ComboBoxYFinancial.FormattingEnabled = True
        Me.ComboBoxYFinancial.Location = New System.Drawing.Point(792, 2)
        Me.ComboBoxYFinancial.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxYFinancial.Name = "ComboBoxYFinancial"
        Me.ComboBoxYFinancial.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxYFinancial.TabIndex = 33
        Me.ComboBoxYFinancial.ValueMember = "Id"
        '
        'TFinancialBindingSource1
        '
        Me.TFinancialBindingSource1.DataMember = "TFinancial"
        Me.TFinancialBindingSource1.DataSource = Me.DataSet1
        '
        'TSexTableAdapter
        '
        Me.TSexTableAdapter.ClearBeforeFill = True
        '
        'TAgeTableAdapter
        '
        Me.TAgeTableAdapter.ClearBeforeFill = True
        '
        'TFinancialTableAdapter
        '
        Me.TFinancialTableAdapter.ClearBeforeFill = True
        '
        'TEducationTableAdapter
        '
        Me.TEducationTableAdapter.ClearBeforeFill = True
        '
        'TEthnicityTableAdapter
        '
        Me.TEthnicityTableAdapter.ClearBeforeFill = True
        '
        'THobbiesTableAdapter
        '
        Me.THobbiesTableAdapter.ClearBeforeFill = True
        '
        'TCitizenshipTableAdapter
        '
        Me.TCitizenshipTableAdapter.ClearBeforeFill = True
        '
        'TFamilyTableAdapter
        '
        Me.TFamilyTableAdapter.ClearBeforeFill = True
        '
        'TBuildTableAdapter
        '
        Me.TBuildTableAdapter.ClearBeforeFill = True
        '
        'ProfileTableAdapter
        '
        Me.ProfileTableAdapter.ClearBeforeFill = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 393)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1124, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = Global.vb_NN.My.Resources.Resources.database
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ReloadToolStripMenuItem.Text = "Reload"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = Global.vb_NN.My.Resources.Resources.save
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(97, 17)
        Me.ToolStripStatusLabel1.Text = "Database loaded."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 415)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Neural Networks Project"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSexBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAgeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEthnicityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBuildBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEducationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TCitizenshipBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.THobbiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFinancialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFamilyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TSexBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TSexBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFamilyBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEthnicityBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFamilyBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFinancialBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.THobbiesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TCitizenshipBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAgeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEducationBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEthnicityBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBuildBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBuildBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEducationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAgeBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TCitizenshipBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.THobbiesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TFinancialBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ButtonTwoWay As System.Windows.Forms.Button
    Friend WithEvents ButtonOneWay As System.Windows.Forms.Button
    Friend WithEvents LabelYou As System.Windows.Forms.Label
    Friend WithEvents LabelMatch As System.Windows.Forms.Label
    Friend WithEvents ComboBoxYAge As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxYEthnic As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxYBuild As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxYEdu As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxYCitizen As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxYFamily As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxYHobbies As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxYFinancial As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet1 As vb_NN.DataSet1
    Friend WithEvents TSexBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TSexTableAdapter As vb_NN.DataSet1TableAdapters.TSexTableAdapter
    Friend WithEvents TAgeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TAgeTableAdapter As vb_NN.DataSet1TableAdapters.TAgeTableAdapter
    Friend WithEvents TFinancialBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TFinancialTableAdapter As vb_NN.DataSet1TableAdapters.TFinancialTableAdapter
    Friend WithEvents TEducationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TEducationTableAdapter As vb_NN.DataSet1TableAdapters.TEducationTableAdapter
    Friend WithEvents TEthnicityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TEthnicityTableAdapter As vb_NN.DataSet1TableAdapters.TEthnicityTableAdapter
    Friend WithEvents THobbiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents THobbiesTableAdapter As vb_NN.DataSet1TableAdapters.THobbiesTableAdapter
    Friend WithEvents TCitizenshipBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TCitizenshipTableAdapter As vb_NN.DataSet1TableAdapters.TCitizenshipTableAdapter
    Friend WithEvents TFamilyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TFamilyTableAdapter As vb_NN.DataSet1TableAdapters.TFamilyTableAdapter
    Friend WithEvents TBuildBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TBuildTableAdapter As vb_NN.DataSet1TableAdapters.TBuildTableAdapter
    Friend WithEvents DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents ProfileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfileTableAdapter As vb_NN.DataSet1TableAdapters.ProfileTableAdapter
    Friend WithEvents ComboBoxMEthnic As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxMFamily As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxMFinancial As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxMHobbies As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxMCitizen As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxMEdu As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxMBuild As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxMAge As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxMSex As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxYSex As System.Windows.Forms.ComboBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TSexBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TSexBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TAgeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TFamilyBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TEthnicityBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TFamilyBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TFinancialBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents THobbiesBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TCitizenshipBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TEducationBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TEthnicityBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TBuildBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TBuildBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TEducationBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TAgeBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TCitizenshipBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents THobbiesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TFinancialBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents EthnicityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents BuildDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents EducationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CitizenshipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents HobbiesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FinancialDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FamilyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents LikeIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ReloadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
