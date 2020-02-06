namespace Database_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label class_GroupLabel;
            System.Windows.Forms.Label summer_MarkLabel;
            System.Windows.Forms.Label christmas_MarkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.student_DetailsDataSet = new Database_Project.Student_DetailsDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new Database_Project.Student_DetailsDataSetTableAdapters.StudentsTableAdapter();
            this.tableAdapterManager = new Database_Project.Student_DetailsDataSetTableAdapters.TableAdapterManager();
            this.studentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.studentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.class_GroupTextBox = new System.Windows.Forms.TextBox();
            this.summer_MarkTextBox = new System.Windows.Forms.TextBox();
            this.christmas_MarkTextBox = new System.Windows.Forms.TextBox();
            this.dundalkToolStrip = new System.Windows.Forms.ToolStrip();
            this.dundalkToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.summer_Pass_GradeToolStrip = new System.Windows.Forms.ToolStrip();
            this.summer_Pass_GradeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dundalk_or_DroghedaToolStrip = new System.Windows.Forms.ToolStrip();
            this.dundalk_or_DroghedaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.summer_FailToolStrip = new System.Windows.Forms.ToolStrip();
            this.summer_FailToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Results = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SearchWord = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            class_GroupLabel = new System.Windows.Forms.Label();
            summer_MarkLabel = new System.Windows.Forms.Label();
            christmas_MarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.student_DetailsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).BeginInit();
            this.studentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.dundalkToolStrip.SuspendLayout();
            this.summer_Pass_GradeToolStrip.SuspendLayout();
            this.dundalk_or_DroghedaToolStrip.SuspendLayout();
            this.summer_FailToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(9, 188);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(9, 214);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(80, 13);
            phoneNumberLabel.TabIndex = 4;
            phoneNumberLabel.Text = "phone Number:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(9, 240);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 6;
            addressLabel.Text = "Address:";
            // 
            // class_GroupLabel
            // 
            class_GroupLabel.AutoSize = true;
            class_GroupLabel.Location = new System.Drawing.Point(9, 266);
            class_GroupLabel.Name = "class_GroupLabel";
            class_GroupLabel.Size = new System.Drawing.Size(67, 13);
            class_GroupLabel.TabIndex = 8;
            class_GroupLabel.Text = "Class Group:";
            // 
            // summer_MarkLabel
            // 
            summer_MarkLabel.AutoSize = true;
            summer_MarkLabel.Location = new System.Drawing.Point(9, 292);
            summer_MarkLabel.Name = "summer_MarkLabel";
            summer_MarkLabel.Size = new System.Drawing.Size(75, 13);
            summer_MarkLabel.TabIndex = 10;
            summer_MarkLabel.Text = "Summer Mark:";
            // 
            // christmas_MarkLabel
            // 
            christmas_MarkLabel.AutoSize = true;
            christmas_MarkLabel.Location = new System.Drawing.Point(9, 318);
            christmas_MarkLabel.Name = "christmas_MarkLabel";
            christmas_MarkLabel.Size = new System.Drawing.Size(82, 13);
            christmas_MarkLabel.TabIndex = 12;
            christmas_MarkLabel.Text = "Christmas Mark:";
            // 
            // student_DetailsDataSet
            // 
            this.student_DetailsDataSet.DataSetName = "Student_DetailsDataSet";
            this.student_DetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.student_DetailsDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Database_Project.Student_DetailsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentsBindingNavigator
            // 
            this.studentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentsBindingNavigator.BindingSource = this.studentsBindingSource;
            this.studentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.studentsBindingNavigatorSaveItem});
            this.studentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentsBindingNavigator.Name = "studentsBindingNavigator";
            this.studentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentsBindingNavigator.Size = new System.Drawing.Size(758, 25);
            this.studentsBindingNavigator.TabIndex = 0;
            this.studentsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // studentsBindingNavigatorSaveItem
            // 
            this.studentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentsBindingNavigatorSaveItem.Image")));
            this.studentsBindingNavigatorSaveItem.Name = "studentsBindingNavigatorSaveItem";
            this.studentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.studentsBindingNavigatorSaveItem.Text = "Save Data";
            this.studentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentsBindingNavigatorSaveItem_Click);
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AutoGenerateColumns = false;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Result});
            this.studentsDataGridView.DataSource = this.studentsBindingSource;
            this.studentsDataGridView.Location = new System.Drawing.Point(9, 28);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.Size = new System.Drawing.Size(743, 150);
            this.studentsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "phoneNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "phoneNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Class Group";
            this.dataGridViewTextBoxColumn4.HeaderText = "Class Group";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Summer Mark";
            this.dataGridViewTextBoxColumn5.HeaderText = "Summer Mark";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Christmas Mark";
            this.dataGridViewTextBoxColumn6.HeaderText = "Christmas Mark";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(97, 185);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "phoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(97, 211);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextBox.TabIndex = 5;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(97, 237);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 7;
            // 
            // class_GroupTextBox
            // 
            this.class_GroupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Class Group", true));
            this.class_GroupTextBox.Location = new System.Drawing.Point(97, 263);
            this.class_GroupTextBox.Name = "class_GroupTextBox";
            this.class_GroupTextBox.Size = new System.Drawing.Size(100, 20);
            this.class_GroupTextBox.TabIndex = 9;
            // 
            // summer_MarkTextBox
            // 
            this.summer_MarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Summer Mark", true));
            this.summer_MarkTextBox.Location = new System.Drawing.Point(97, 289);
            this.summer_MarkTextBox.Name = "summer_MarkTextBox";
            this.summer_MarkTextBox.Size = new System.Drawing.Size(100, 20);
            this.summer_MarkTextBox.TabIndex = 11;
            // 
            // christmas_MarkTextBox
            // 
            this.christmas_MarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Christmas Mark", true));
            this.christmas_MarkTextBox.Location = new System.Drawing.Point(97, 315);
            this.christmas_MarkTextBox.Name = "christmas_MarkTextBox";
            this.christmas_MarkTextBox.Size = new System.Drawing.Size(100, 20);
            this.christmas_MarkTextBox.TabIndex = 13;
            // 
            // dundalkToolStrip
            // 
            this.dundalkToolStrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dundalkToolStrip.AutoSize = false;
            this.dundalkToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.dundalkToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dundalkToolStripButton});
            this.dundalkToolStrip.Location = new System.Drawing.Point(249, -41);
            this.dundalkToolStrip.Name = "dundalkToolStrip";
            this.dundalkToolStrip.Size = new System.Drawing.Size(82, 25);
            this.dundalkToolStrip.TabIndex = 14;
            this.dundalkToolStrip.Text = "dundalkToolStrip";
            // 
            // dundalkToolStripButton
            // 
            this.dundalkToolStripButton.AutoSize = false;
            this.dundalkToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dundalkToolStripButton.Name = "dundalkToolStripButton";
            this.dundalkToolStripButton.Size = new System.Drawing.Size(55, 22);
            this.dundalkToolStripButton.Text = "Dundalk";
            this.dundalkToolStripButton.Click += new System.EventHandler(this.dundalkToolStripButton_Click);
            // 
            // summer_Pass_GradeToolStrip
            // 
            this.summer_Pass_GradeToolStrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.summer_Pass_GradeToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.summer_Pass_GradeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summer_Pass_GradeToolStripButton});
            this.summer_Pass_GradeToolStrip.Location = new System.Drawing.Point(471, -41);
            this.summer_Pass_GradeToolStrip.Name = "summer_Pass_GradeToolStrip";
            this.summer_Pass_GradeToolStrip.Size = new System.Drawing.Size(132, 25);
            this.summer_Pass_GradeToolStrip.TabIndex = 15;
            this.summer_Pass_GradeToolStrip.Text = "summer_Pass_GradeToolStrip";
            // 
            // summer_Pass_GradeToolStripButton
            // 
            this.summer_Pass_GradeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.summer_Pass_GradeToolStripButton.Name = "summer_Pass_GradeToolStripButton";
            this.summer_Pass_GradeToolStripButton.Size = new System.Drawing.Size(120, 22);
            this.summer_Pass_GradeToolStripButton.Text = "Summer_Pass_Grade";
            this.summer_Pass_GradeToolStripButton.Click += new System.EventHandler(this.summer_Pass_GradeToolStripButton_Click);
            // 
            // dundalk_or_DroghedaToolStrip
            // 
            this.dundalk_or_DroghedaToolStrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dundalk_or_DroghedaToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.dundalk_or_DroghedaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dundalk_or_DroghedaToolStripButton});
            this.dundalk_or_DroghedaToolStrip.Location = new System.Drawing.Point(331, -41);
            this.dundalk_or_DroghedaToolStrip.Name = "dundalk_or_DroghedaToolStrip";
            this.dundalk_or_DroghedaToolStrip.Size = new System.Drawing.Size(140, 25);
            this.dundalk_or_DroghedaToolStrip.TabIndex = 16;
            this.dundalk_or_DroghedaToolStrip.Text = "dundalk_or_DroghedaToolStrip";
            // 
            // dundalk_or_DroghedaToolStripButton
            // 
            this.dundalk_or_DroghedaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dundalk_or_DroghedaToolStripButton.Name = "dundalk_or_DroghedaToolStripButton";
            this.dundalk_or_DroghedaToolStripButton.Size = new System.Drawing.Size(128, 22);
            this.dundalk_or_DroghedaToolStripButton.Text = "Dundalk_or_Drogheda";
            this.dundalk_or_DroghedaToolStripButton.Click += new System.EventHandler(this.dundalk_or_DroghedaToolStripButton_Click);
            // 
            // summer_FailToolStrip
            // 
            this.summer_FailToolStrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.summer_FailToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.summer_FailToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summer_FailToolStripButton});
            this.summer_FailToolStrip.Location = new System.Drawing.Point(603, -41);
            this.summer_FailToolStrip.Name = "summer_FailToolStrip";
            this.summer_FailToolStrip.Size = new System.Drawing.Size(91, 25);
            this.summer_FailToolStrip.TabIndex = 17;
            this.summer_FailToolStrip.Text = "summer_FailToolStrip";
            this.summer_FailToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.summer_FailToolStrip_ItemClicked);
            // 
            // summer_FailToolStripButton
            // 
            this.summer_FailToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.summer_FailToolStripButton.Name = "summer_FailToolStripButton";
            this.summer_FailToolStripButton.Size = new System.Drawing.Size(79, 22);
            this.summer_FailToolStripButton.Text = "Summer_Fail";
            this.summer_FailToolStripButton.Click += new System.EventHandler(this.summer_FailToolStripButton_Click);
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(256, 185);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(75, 23);
            this.Results.TabIndex = 18;
            this.Results.Text = "Results";
            this.Results.UseVisualStyleBackColor = true;
            this.Results.Click += new System.EventHandler(this.Results_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(256, 215);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 19;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SearchWord
            // 
            this.SearchWord.Location = new System.Drawing.Point(337, 218);
            this.SearchWord.Name = "SearchWord";
            this.SearchWord.Size = new System.Drawing.Size(166, 20);
            this.SearchWord.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 339);
            this.Controls.Add(this.SearchWord);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.summer_FailToolStrip);
            this.Controls.Add(this.dundalk_or_DroghedaToolStrip);
            this.Controls.Add(this.summer_Pass_GradeToolStrip);
            this.Controls.Add(this.dundalkToolStrip);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(class_GroupLabel);
            this.Controls.Add(this.class_GroupTextBox);
            this.Controls.Add(summer_MarkLabel);
            this.Controls.Add(this.summer_MarkTextBox);
            this.Controls.Add(christmas_MarkLabel);
            this.Controls.Add(this.christmas_MarkTextBox);
            this.Controls.Add(this.studentsDataGridView);
            this.Controls.Add(this.studentsBindingNavigator);
            this.Name = "Form1";
            this.Text = " 4od";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.student_DetailsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingNavigator)).EndInit();
            this.studentsBindingNavigator.ResumeLayout(false);
            this.studentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.dundalkToolStrip.ResumeLayout(false);
            this.dundalkToolStrip.PerformLayout();
            this.summer_Pass_GradeToolStrip.ResumeLayout(false);
            this.summer_Pass_GradeToolStrip.PerformLayout();
            this.dundalk_or_DroghedaToolStrip.ResumeLayout(false);
            this.dundalk_or_DroghedaToolStrip.PerformLayout();
            this.summer_FailToolStrip.ResumeLayout(false);
            this.summer_FailToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Student_DetailsDataSet student_DetailsDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private Student_DetailsDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private Student_DetailsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton studentsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox class_GroupTextBox;
        private System.Windows.Forms.TextBox summer_MarkTextBox;
        private System.Windows.Forms.TextBox christmas_MarkTextBox;
        private System.Windows.Forms.ToolStrip dundalkToolStrip;
        private System.Windows.Forms.ToolStripButton dundalkToolStripButton;
        private System.Windows.Forms.ToolStrip summer_Pass_GradeToolStrip;
        private System.Windows.Forms.ToolStripButton summer_Pass_GradeToolStripButton;
        private System.Windows.Forms.ToolStrip dundalk_or_DroghedaToolStrip;
        private System.Windows.Forms.ToolStripButton dundalk_or_DroghedaToolStripButton;
        private System.Windows.Forms.ToolStrip summer_FailToolStrip;
        private System.Windows.Forms.ToolStripButton summer_FailToolStripButton;
        private System.Windows.Forms.Button Results;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox SearchWord;
    }
}

