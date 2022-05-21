﻿namespace Kursa4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TableTabControl = new System.Windows.Forms.TabControl();
            this.EmployeeTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ClearEmployeeData = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EmployeeSalary = new System.Windows.Forms.NumericUpDown();
            this.CreateButton = new System.Windows.Forms.Button();
            this.EmployeeSaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.EmployeeBirthDate = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeePhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmployeeSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.EmployeeGrid = new DevExpress.XtraGrid.GridControl();
            this.emploeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ConsumerTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ClearConsumerData = new System.Windows.Forms.Button();
            this.ConsumerSaveButton = new System.Windows.Forms.Button();
            this.ConsumerCreateButton = new System.Windows.Forms.Button();
            this.ConsumerDeleteButton = new System.Windows.Forms.Button();
            this.ConsumerBIrthdate = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ConsumerPhoneNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ConsumerSurname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ConsumerName = new System.Windows.Forms.TextBox();
            this.ConsumersGrid = new DevExpress.XtraGrid.GridControl();
            this.consumerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductTab = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.ClearProductData = new System.Windows.Forms.Button();
            this.ProductStockCountUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProductPriceUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveProduct = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.CreateProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ProductDescription = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.ProductGrid = new DevExpress.XtraGrid.GridControl();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PurchaseProductsTab = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.PurchaseProductSourceProduct = new System.Windows.Forms.ComboBox();
            this.SourceProduct = new System.Windows.Forms.Label();
            this.PurcahseProductOrder = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.ConsumerPurchaseProduct = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.PurchaseProductCount = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.ClearPurchaseProduct = new System.Windows.Forms.Button();
            this.SavePurchaseProduct = new System.Windows.Forms.Button();
            this.DeletePurchaseProduct = new System.Windows.Forms.Button();
            this.CreatePurchaseProduct = new System.Windows.Forms.Button();
            this.PurchaseProductsGrid = new DevExpress.XtraGrid.GridControl();
            this.purchaseProductBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConsumer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrdersTab = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.EmployeeInOrder = new System.Windows.Forms.ComboBox();
            this.OrderStatus = new System.Windows.Forms.ComboBox();
            this.ConsumerInOrder = new System.Windows.Forms.ComboBox();
            this.ClearOrderData = new System.Windows.Forms.Button();
            this.SaveOrder = new System.Windows.Forms.Button();
            this.DeleteOrder = new System.Windows.Forms.Button();
            this.CreateOrder = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.OrdersGrid = new DevExpress.XtraGrid.GridControl();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConsumer1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchaseProducts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmploee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ExportTab = new System.Windows.Forms.TabPage();
            this.ExportButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.ExportPeriod = new System.Windows.Forms.MonthCalendar();
            this.label15 = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableTabControl.SuspendLayout();
            this.EmployeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.ConsumerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsumersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.ProductTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductStockCountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.PurchaseProductsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseProductCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseProductsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseProductBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.OrdersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.ExportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseProductBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableTabControl
            // 
            this.TableTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableTabControl.Controls.Add(this.EmployeeTab);
            this.TableTabControl.Controls.Add(this.ConsumerTab);
            this.TableTabControl.Controls.Add(this.ProductTab);
            this.TableTabControl.Controls.Add(this.PurchaseProductsTab);
            this.TableTabControl.Controls.Add(this.OrdersTab);
            this.TableTabControl.Controls.Add(this.ExportTab);
            this.TableTabControl.Location = new System.Drawing.Point(12, 27);
            this.TableTabControl.Name = "TableTabControl";
            this.TableTabControl.SelectedIndex = 0;
            this.TableTabControl.Size = new System.Drawing.Size(1206, 644);
            this.TableTabControl.TabIndex = 0;
            // 
            // EmployeeTab
            // 
            this.EmployeeTab.Controls.Add(this.splitContainer1);
            this.EmployeeTab.Location = new System.Drawing.Point(4, 24);
            this.EmployeeTab.Name = "EmployeeTab";
            this.EmployeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeTab.Size = new System.Drawing.Size(1198, 616);
            this.EmployeeTab.TabIndex = 0;
            this.EmployeeTab.Text = "Employee";
            this.EmployeeTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ClearEmployeeData);
            this.splitContainer1.Panel1.Controls.Add(this.DeleteButton);
            this.splitContainer1.Panel1.Controls.Add(this.EmployeeSalary);
            this.splitContainer1.Panel1.Controls.Add(this.CreateButton);
            this.splitContainer1.Panel1.Controls.Add(this.EmployeeSaveButton);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.EmployeeBirthDate);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.EmployeePhone);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.EmployeeSurname);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.EmployeeName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.EmployeeGrid);
            this.splitContainer1.Size = new System.Drawing.Size(1192, 610);
            this.splitContainer1.SplitterDistance = 327;
            this.splitContainer1.TabIndex = 0;
            // 
            // ClearEmployeeData
            // 
            this.ClearEmployeeData.Location = new System.Drawing.Point(3, 143);
            this.ClearEmployeeData.Name = "ClearEmployeeData";
            this.ClearEmployeeData.Size = new System.Drawing.Size(75, 23);
            this.ClearEmployeeData.TabIndex = 15;
            this.ClearEmployeeData.Text = "Clear";
            this.ClearEmployeeData.UseVisualStyleBackColor = true;
            this.ClearEmployeeData.Click += new System.EventHandler(this.ClearEmployeeData_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(246, 584);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 14;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EmployeeSalary
            // 
            this.EmployeeSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeSalary.Location = new System.Drawing.Point(47, 90);
            this.EmployeeSalary.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.EmployeeSalary.Name = "EmployeeSalary";
            this.EmployeeSalary.Size = new System.Drawing.Size(274, 23);
            this.EmployeeSalary.TabIndex = 13;
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateButton.Location = new System.Drawing.Point(3, 584);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 12;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // EmployeeSaveButton
            // 
            this.EmployeeSaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EmployeeSaveButton.Location = new System.Drawing.Point(130, 584);
            this.EmployeeSaveButton.Name = "EmployeeSaveButton";
            this.EmployeeSaveButton.Size = new System.Drawing.Size(75, 23);
            this.EmployeeSaveButton.TabIndex = 11;
            this.EmployeeSaveButton.Text = "Save";
            this.EmployeeSaveButton.UseVisualStyleBackColor = true;
            this.EmployeeSaveButton.Click += new System.EventHandler(this.EmployeeSaveButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salary";
            // 
            // EmployeeBirthDate
            // 
            this.EmployeeBirthDate.Location = new System.Drawing.Point(99, 125);
            this.EmployeeBirthDate.MaxSelectionCount = 1;
            this.EmployeeBirthDate.Name = "EmployeeBirthDate";
            this.EmployeeBirthDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone";
            // 
            // EmployeePhone
            // 
            this.EmployeePhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeePhone.Location = new System.Drawing.Point(50, 61);
            this.EmployeePhone.Name = "EmployeePhone";
            this.EmployeePhone.Size = new System.Drawing.Size(271, 23);
            this.EmployeePhone.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // EmployeeSurname
            // 
            this.EmployeeSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeSurname.Location = new System.Drawing.Point(63, 32);
            this.EmployeeSurname.Name = "EmployeeSurname";
            this.EmployeeSurname.Size = new System.Drawing.Size(258, 23);
            this.EmployeeSurname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // EmployeeName
            // 
            this.EmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeName.Location = new System.Drawing.Point(47, 3);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(274, 23);
            this.EmployeeName.TabIndex = 0;
            // 
            // EmployeeGrid
            // 
            this.EmployeeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeGrid.DataSource = this.emploeeBindingSource;
            this.EmployeeGrid.Location = new System.Drawing.Point(7, 3);
            this.EmployeeGrid.MainView = this.gridView1;
            this.EmployeeGrid.Name = "EmployeeGrid";
            this.EmployeeGrid.Size = new System.Drawing.Size(851, 604);
            this.EmployeeGrid.TabIndex = 0;
            this.EmployeeGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSalary,
            this.colName,
            this.colSurname,
            this.colBirthDate,
            this.colPhoneNumber});
            this.gridView1.GridControl = this.EmployeeGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colId, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colSalary
            // 
            this.colSalary.FieldName = "Salary";
            this.colSalary.Name = "colSalary";
            this.colSalary.Visible = true;
            this.colSalary.VisibleIndex = 5;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colSurname
            // 
            this.colSurname.FieldName = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 2;
            // 
            // colBirthDate
            // 
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 3;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 4;
            // 
            // ConsumerTab
            // 
            this.ConsumerTab.Controls.Add(this.splitContainer2);
            this.ConsumerTab.Location = new System.Drawing.Point(4, 24);
            this.ConsumerTab.Name = "ConsumerTab";
            this.ConsumerTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConsumerTab.Size = new System.Drawing.Size(1198, 616);
            this.ConsumerTab.TabIndex = 1;
            this.ConsumerTab.Text = "Consumer";
            this.ConsumerTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ClearConsumerData);
            this.splitContainer2.Panel1.Controls.Add(this.ConsumerSaveButton);
            this.splitContainer2.Panel1.Controls.Add(this.ConsumerCreateButton);
            this.splitContainer2.Panel1.Controls.Add(this.ConsumerDeleteButton);
            this.splitContainer2.Panel1.Controls.Add(this.ConsumerBIrthdate);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            this.splitContainer2.Panel1.Controls.Add(this.ConsumerPhoneNumber);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.ConsumerSurname);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.ConsumerName);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ConsumersGrid);
            this.splitContainer2.Size = new System.Drawing.Size(1192, 610);
            this.splitContainer2.SplitterDistance = 343;
            this.splitContainer2.TabIndex = 1;
            // 
            // ClearConsumerData
            // 
            this.ClearConsumerData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearConsumerData.Location = new System.Drawing.Point(259, 308);
            this.ClearConsumerData.Name = "ClearConsumerData";
            this.ClearConsumerData.Size = new System.Drawing.Size(75, 23);
            this.ClearConsumerData.TabIndex = 12;
            this.ClearConsumerData.Text = "Clear";
            this.ClearConsumerData.UseVisualStyleBackColor = true;
            this.ClearConsumerData.Click += new System.EventHandler(this.ClearConsumerData_Click);
            // 
            // ConsumerSaveButton
            // 
            this.ConsumerSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ConsumerSaveButton.Location = new System.Drawing.Point(3, 584);
            this.ConsumerSaveButton.Name = "ConsumerSaveButton";
            this.ConsumerSaveButton.Size = new System.Drawing.Size(75, 23);
            this.ConsumerSaveButton.TabIndex = 11;
            this.ConsumerSaveButton.Text = "Save";
            this.ConsumerSaveButton.UseVisualStyleBackColor = true;
            this.ConsumerSaveButton.Click += new System.EventHandler(this.ConsumerSaveButton_Click);
            // 
            // ConsumerCreateButton
            // 
            this.ConsumerCreateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConsumerCreateButton.Location = new System.Drawing.Point(135, 584);
            this.ConsumerCreateButton.Name = "ConsumerCreateButton";
            this.ConsumerCreateButton.Size = new System.Drawing.Size(75, 23);
            this.ConsumerCreateButton.TabIndex = 10;
            this.ConsumerCreateButton.Text = "Create";
            this.ConsumerCreateButton.UseVisualStyleBackColor = true;
            this.ConsumerCreateButton.Click += new System.EventHandler(this.ConsumerCreateButton_Click);
            // 
            // ConsumerDeleteButton
            // 
            this.ConsumerDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsumerDeleteButton.Location = new System.Drawing.Point(265, 584);
            this.ConsumerDeleteButton.Name = "ConsumerDeleteButton";
            this.ConsumerDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ConsumerDeleteButton.TabIndex = 9;
            this.ConsumerDeleteButton.Text = "Delete";
            this.ConsumerDeleteButton.UseVisualStyleBackColor = true;
            this.ConsumerDeleteButton.Click += new System.EventHandler(this.ConsumerDeleteButton_Click);
            // 
            // ConsumerBIrthdate
            // 
            this.ConsumerBIrthdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsumerBIrthdate.Location = new System.Drawing.Point(99, 96);
            this.ConsumerBIrthdate.MaxSelectionCount = 1;
            this.ConsumerBIrthdate.Name = "ConsumerBIrthdate";
            this.ConsumerBIrthdate.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Phone";
            // 
            // ConsumerPhoneNumber
            // 
            this.ConsumerPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsumerPhoneNumber.Location = new System.Drawing.Point(50, 61);
            this.ConsumerPhoneNumber.Name = "ConsumerPhoneNumber";
            this.ConsumerPhoneNumber.Size = new System.Drawing.Size(290, 23);
            this.ConsumerPhoneNumber.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Surname";
            // 
            // ConsumerSurname
            // 
            this.ConsumerSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsumerSurname.Location = new System.Drawing.Point(63, 32);
            this.ConsumerSurname.Name = "ConsumerSurname";
            this.ConsumerSurname.Size = new System.Drawing.Size(277, 23);
            this.ConsumerSurname.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Name";
            // 
            // ConsumerName
            // 
            this.ConsumerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsumerName.Location = new System.Drawing.Point(47, 3);
            this.ConsumerName.Name = "ConsumerName";
            this.ConsumerName.Size = new System.Drawing.Size(293, 23);
            this.ConsumerName.TabIndex = 0;
            // 
            // ConsumersGrid
            // 
            this.ConsumersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsumersGrid.DataSource = this.consumerBindingSource;
            this.ConsumersGrid.Location = new System.Drawing.Point(3, 3);
            this.ConsumersGrid.MainView = this.gridView2;
            this.ConsumersGrid.Name = "ConsumersGrid";
            this.ConsumersGrid.Size = new System.Drawing.Size(839, 604);
            this.ConsumersGrid.TabIndex = 0;
            this.ConsumersGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName1,
            this.colSurname1,
            this.colBirthDate1,
            this.colId1});
            this.gridView2.GridControl = this.ConsumersGrid;
            this.gridView2.Name = "gridView2";
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 1;
            // 
            // colSurname1
            // 
            this.colSurname1.FieldName = "Surname";
            this.colSurname1.Name = "colSurname1";
            this.colSurname1.Visible = true;
            this.colSurname1.VisibleIndex = 2;
            // 
            // colBirthDate1
            // 
            this.colBirthDate1.FieldName = "BirthDate";
            this.colBirthDate1.Name = "colBirthDate1";
            this.colBirthDate1.Visible = true;
            this.colBirthDate1.VisibleIndex = 3;
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            this.colId1.Visible = true;
            this.colId1.VisibleIndex = 0;
            // 
            // ProductTab
            // 
            this.ProductTab.Controls.Add(this.splitContainer3);
            this.ProductTab.Location = new System.Drawing.Point(4, 24);
            this.ProductTab.Name = "ProductTab";
            this.ProductTab.Size = new System.Drawing.Size(1198, 616);
            this.ProductTab.TabIndex = 2;
            this.ProductTab.Text = "Product";
            this.ProductTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.ClearProductData);
            this.splitContainer3.Panel1.Controls.Add(this.ProductStockCountUpDown);
            this.splitContainer3.Panel1.Controls.Add(this.ProductPriceUpDown);
            this.splitContainer3.Panel1.Controls.Add(this.SaveProduct);
            this.splitContainer3.Panel1.Controls.Add(this.DeleteProduct);
            this.splitContainer3.Panel1.Controls.Add(this.CreateProduct);
            this.splitContainer3.Panel1.Controls.Add(this.label6);
            this.splitContainer3.Panel1.Controls.Add(this.label11);
            this.splitContainer3.Panel1.Controls.Add(this.label12);
            this.splitContainer3.Panel1.Controls.Add(this.ProductDescription);
            this.splitContainer3.Panel1.Controls.Add(this.label13);
            this.splitContainer3.Panel1.Controls.Add(this.ProductName);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.ProductGrid);
            this.splitContainer3.Size = new System.Drawing.Size(1198, 616);
            this.splitContainer3.SplitterDistance = 333;
            this.splitContainer3.TabIndex = 2;
            // 
            // ClearProductData
            // 
            this.ClearProductData.Location = new System.Drawing.Point(257, 142);
            this.ClearProductData.Name = "ClearProductData";
            this.ClearProductData.Size = new System.Drawing.Size(75, 23);
            this.ClearProductData.TabIndex = 14;
            this.ClearProductData.Text = "Clear";
            this.ClearProductData.UseVisualStyleBackColor = true;
            this.ClearProductData.Click += new System.EventHandler(this.ClearProductData_Click);
            // 
            // ProductStockCountUpDown
            // 
            this.ProductStockCountUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductStockCountUpDown.Location = new System.Drawing.Point(80, 92);
            this.ProductStockCountUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ProductStockCountUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProductStockCountUpDown.Name = "ProductStockCountUpDown";
            this.ProductStockCountUpDown.Size = new System.Drawing.Size(225, 23);
            this.ProductStockCountUpDown.TabIndex = 13;
            this.ProductStockCountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ProductPriceUpDown
            // 
            this.ProductPriceUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPriceUpDown.Location = new System.Drawing.Point(42, 63);
            this.ProductPriceUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.ProductPriceUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProductPriceUpDown.Name = "ProductPriceUpDown";
            this.ProductPriceUpDown.Size = new System.Drawing.Size(263, 23);
            this.ProductPriceUpDown.TabIndex = 12;
            this.ProductPriceUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SaveProduct
            // 
            this.SaveProduct.Location = new System.Drawing.Point(3, 590);
            this.SaveProduct.Name = "SaveProduct";
            this.SaveProduct.Size = new System.Drawing.Size(75, 23);
            this.SaveProduct.TabIndex = 11;
            this.SaveProduct.Text = "Save";
            this.SaveProduct.UseVisualStyleBackColor = true;
            this.SaveProduct.Click += new System.EventHandler(this.SaveProduct_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Location = new System.Drawing.Point(255, 590);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.DeleteProduct.TabIndex = 10;
            this.DeleteProduct.Text = "Delete";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // CreateProduct
            // 
            this.CreateProduct.Location = new System.Drawing.Point(145, 590);
            this.CreateProduct.Name = "CreateProduct";
            this.CreateProduct.Size = new System.Drawing.Size(75, 23);
            this.CreateProduct.TabIndex = 9;
            this.CreateProduct.Text = "Create";
            this.CreateProduct.UseVisualStyleBackColor = true;
            this.CreateProduct.Click += new System.EventHandler(this.CreateProduct_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "StockCount";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Price";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Description";
            // 
            // ProductDescription
            // 
            this.ProductDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductDescription.Location = new System.Drawing.Point(76, 32);
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.Size = new System.Drawing.Size(229, 23);
            this.ProductDescription.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Name";
            // 
            // ProductName
            // 
            this.ProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductName.Location = new System.Drawing.Point(47, 3);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(258, 23);
            this.ProductName.TabIndex = 0;
            // 
            // ProductGrid
            // 
            this.ProductGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductGrid.DataSource = this.productBindingSource1;
            this.ProductGrid.Location = new System.Drawing.Point(3, 3);
            this.ProductGrid.MainView = this.gridView3;
            this.ProductGrid.Name = "ProductGrid";
            this.ProductGrid.Size = new System.Drawing.Size(826, 610);
            this.ProductGrid.TabIndex = 0;
            this.ProductGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName2,
            this.colDescription,
            this.colPrice,
            this.colStockCount,
            this.colId2});
            this.gridView3.GridControl = this.ProductGrid;
            this.gridView3.Name = "gridView3";
            // 
            // colName2
            // 
            this.colName2.FieldName = "Name";
            this.colName2.Name = "colName2";
            this.colName2.Visible = true;
            this.colName2.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            // 
            // colStockCount
            // 
            this.colStockCount.FieldName = "StockCount";
            this.colStockCount.Name = "colStockCount";
            this.colStockCount.Visible = true;
            this.colStockCount.VisibleIndex = 4;
            // 
            // colId2
            // 
            this.colId2.FieldName = "Id";
            this.colId2.Name = "colId2";
            this.colId2.Visible = true;
            this.colId2.VisibleIndex = 0;
            // 
            // PurchaseProductsTab
            // 
            this.PurchaseProductsTab.Controls.Add(this.splitContainer4);
            this.PurchaseProductsTab.Location = new System.Drawing.Point(4, 24);
            this.PurchaseProductsTab.Name = "PurchaseProductsTab";
            this.PurchaseProductsTab.Size = new System.Drawing.Size(1198, 616);
            this.PurchaseProductsTab.TabIndex = 3;
            this.PurchaseProductsTab.Text = "PurchaseProducts";
            this.PurchaseProductsTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.PurchaseProductSourceProduct);
            this.splitContainer4.Panel1.Controls.Add(this.SourceProduct);
            this.splitContainer4.Panel1.Controls.Add(this.PurcahseProductOrder);
            this.splitContainer4.Panel1.Controls.Add(this.label23);
            this.splitContainer4.Panel1.Controls.Add(this.ConsumerPurchaseProduct);
            this.splitContainer4.Panel1.Controls.Add(this.label22);
            this.splitContainer4.Panel1.Controls.Add(this.PurchaseProductCount);
            this.splitContainer4.Panel1.Controls.Add(this.label14);
            this.splitContainer4.Panel1.Controls.Add(this.ClearPurchaseProduct);
            this.splitContainer4.Panel1.Controls.Add(this.SavePurchaseProduct);
            this.splitContainer4.Panel1.Controls.Add(this.DeletePurchaseProduct);
            this.splitContainer4.Panel1.Controls.Add(this.CreatePurchaseProduct);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.PurchaseProductsGrid);
            this.splitContainer4.Size = new System.Drawing.Size(1198, 616);
            this.splitContainer4.SplitterDistance = 344;
            this.splitContainer4.TabIndex = 5;
            // 
            // PurchaseProductSourceProduct
            // 
            this.PurchaseProductSourceProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PurchaseProductSourceProduct.FormattingEnabled = true;
            this.PurchaseProductSourceProduct.Location = new System.Drawing.Point(99, 7);
            this.PurchaseProductSourceProduct.Name = "PurchaseProductSourceProduct";
            this.PurchaseProductSourceProduct.Size = new System.Drawing.Size(242, 23);
            this.PurchaseProductSourceProduct.TabIndex = 29;
            // 
            // SourceProduct
            // 
            this.SourceProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceProduct.AutoSize = true;
            this.SourceProduct.Location = new System.Drawing.Point(5, 9);
            this.SourceProduct.Name = "SourceProduct";
            this.SourceProduct.Size = new System.Drawing.Size(88, 15);
            this.SourceProduct.TabIndex = 28;
            this.SourceProduct.Text = "Source Product";
            // 
            // PurcahseProductOrder
            // 
            this.PurcahseProductOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PurcahseProductOrder.FormattingEnabled = true;
            this.PurcahseProductOrder.Location = new System.Drawing.Point(48, 94);
            this.PurcahseProductOrder.Name = "PurcahseProductOrder";
            this.PurcahseProductOrder.Size = new System.Drawing.Size(293, 23);
            this.PurcahseProductOrder.TabIndex = 27;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(5, 97);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 15);
            this.label23.TabIndex = 26;
            this.label23.Text = "Order";
            // 
            // ConsumerPurchaseProduct
            // 
            this.ConsumerPurchaseProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsumerPurchaseProduct.FormattingEnabled = true;
            this.ConsumerPurchaseProduct.Location = new System.Drawing.Point(82, 65);
            this.ConsumerPurchaseProduct.Name = "ConsumerPurchaseProduct";
            this.ConsumerPurchaseProduct.Size = new System.Drawing.Size(259, 23);
            this.ConsumerPurchaseProduct.TabIndex = 25;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(5, 68);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 15);
            this.label22.TabIndex = 24;
            this.label22.Text = "ConsumerId";
            // 
            // PurchaseProductCount
            // 
            this.PurchaseProductCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PurchaseProductCount.Location = new System.Drawing.Point(99, 36);
            this.PurchaseProductCount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.PurchaseProductCount.Name = "PurchaseProductCount";
            this.PurchaseProductCount.Size = new System.Drawing.Size(242, 23);
            this.PurchaseProductCount.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "PurchaseCount";
            // 
            // ClearPurchaseProduct
            // 
            this.ClearPurchaseProduct.Location = new System.Drawing.Point(260, 123);
            this.ClearPurchaseProduct.Name = "ClearPurchaseProduct";
            this.ClearPurchaseProduct.Size = new System.Drawing.Size(75, 23);
            this.ClearPurchaseProduct.TabIndex = 14;
            this.ClearPurchaseProduct.Text = "Clear";
            this.ClearPurchaseProduct.UseVisualStyleBackColor = true;
            // 
            // SavePurchaseProduct
            // 
            this.SavePurchaseProduct.Location = new System.Drawing.Point(5, 590);
            this.SavePurchaseProduct.Name = "SavePurchaseProduct";
            this.SavePurchaseProduct.Size = new System.Drawing.Size(75, 23);
            this.SavePurchaseProduct.TabIndex = 11;
            this.SavePurchaseProduct.Text = "Save";
            this.SavePurchaseProduct.UseVisualStyleBackColor = true;
            // 
            // DeletePurchaseProduct
            // 
            this.DeletePurchaseProduct.Location = new System.Drawing.Point(266, 590);
            this.DeletePurchaseProduct.Name = "DeletePurchaseProduct";
            this.DeletePurchaseProduct.Size = new System.Drawing.Size(75, 23);
            this.DeletePurchaseProduct.TabIndex = 10;
            this.DeletePurchaseProduct.Text = "Delete";
            this.DeletePurchaseProduct.UseVisualStyleBackColor = true;
            this.DeletePurchaseProduct.Click += new System.EventHandler(this.DeletePurchaseProduct_Click);
            // 
            // CreatePurchaseProduct
            // 
            this.CreatePurchaseProduct.Location = new System.Drawing.Point(126, 590);
            this.CreatePurchaseProduct.Name = "CreatePurchaseProduct";
            this.CreatePurchaseProduct.Size = new System.Drawing.Size(75, 23);
            this.CreatePurchaseProduct.TabIndex = 9;
            this.CreatePurchaseProduct.Text = "Create";
            this.CreatePurchaseProduct.UseVisualStyleBackColor = true;
            this.CreatePurchaseProduct.Click += new System.EventHandler(this.CreatePurchaseProduct_Click);
            // 
            // PurchaseProductsGrid
            // 
            this.PurchaseProductsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PurchaseProductsGrid.DataSource = this.purchaseProductBindingSource1;
            this.PurchaseProductsGrid.Location = new System.Drawing.Point(3, 3);
            this.PurchaseProductsGrid.MainView = this.gridView4;
            this.PurchaseProductsGrid.Name = "PurchaseProductsGrid";
            this.PurchaseProductsGrid.Size = new System.Drawing.Size(844, 610);
            this.PurchaseProductsGrid.TabIndex = 0;
            this.PurchaseProductsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName3,
            this.colDescription1,
            this.colPrice1,
            this.colPurchaseCount,
            this.colConsumer,
            this.colOrder,
            this.colId3});
            this.gridView4.GridControl = this.PurchaseProductsGrid;
            this.gridView4.Name = "gridView4";
            // 
            // colName3
            // 
            this.colName3.FieldName = "Name";
            this.colName3.Name = "colName3";
            this.colName3.Visible = true;
            this.colName3.VisibleIndex = 1;
            // 
            // colDescription1
            // 
            this.colDescription1.FieldName = "Description";
            this.colDescription1.Name = "colDescription1";
            this.colDescription1.Visible = true;
            this.colDescription1.VisibleIndex = 2;
            // 
            // colPrice1
            // 
            this.colPrice1.FieldName = "Price";
            this.colPrice1.Name = "colPrice1";
            this.colPrice1.Visible = true;
            this.colPrice1.VisibleIndex = 3;
            // 
            // colPurchaseCount
            // 
            this.colPurchaseCount.FieldName = "PurchaseCount";
            this.colPurchaseCount.Name = "colPurchaseCount";
            this.colPurchaseCount.Visible = true;
            this.colPurchaseCount.VisibleIndex = 4;
            // 
            // colConsumer
            // 
            this.colConsumer.FieldName = "Consumer";
            this.colConsumer.Name = "colConsumer";
            this.colConsumer.Visible = true;
            this.colConsumer.VisibleIndex = 5;
            // 
            // colOrder
            // 
            this.colOrder.FieldName = "Order";
            this.colOrder.Name = "colOrder";
            this.colOrder.Visible = true;
            this.colOrder.VisibleIndex = 6;
            // 
            // colId3
            // 
            this.colId3.FieldName = "Id";
            this.colId3.Name = "colId3";
            this.colId3.Visible = true;
            this.colId3.VisibleIndex = 0;
            // 
            // OrdersTab
            // 
            this.OrdersTab.Controls.Add(this.splitContainer5);
            this.OrdersTab.Location = new System.Drawing.Point(4, 24);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.Size = new System.Drawing.Size(1198, 616);
            this.OrdersTab.TabIndex = 4;
            this.OrdersTab.Text = "Orders";
            this.OrdersTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.EmployeeInOrder);
            this.splitContainer5.Panel1.Controls.Add(this.OrderStatus);
            this.splitContainer5.Panel1.Controls.Add(this.ConsumerInOrder);
            this.splitContainer5.Panel1.Controls.Add(this.ClearOrderData);
            this.splitContainer5.Panel1.Controls.Add(this.SaveOrder);
            this.splitContainer5.Panel1.Controls.Add(this.DeleteOrder);
            this.splitContainer5.Panel1.Controls.Add(this.CreateOrder);
            this.splitContainer5.Panel1.Controls.Add(this.label19);
            this.splitContainer5.Panel1.Controls.Add(this.label20);
            this.splitContainer5.Panel1.Controls.Add(this.label21);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.OrdersGrid);
            this.splitContainer5.Size = new System.Drawing.Size(1198, 616);
            this.splitContainer5.SplitterDistance = 334;
            this.splitContainer5.TabIndex = 4;
            // 
            // EmployeeInOrder
            // 
            this.EmployeeInOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeInOrder.FormattingEnabled = true;
            this.EmployeeInOrder.Location = new System.Drawing.Point(80, 64);
            this.EmployeeInOrder.Name = "EmployeeInOrder";
            this.EmployeeInOrder.Size = new System.Drawing.Size(251, 23);
            this.EmployeeInOrder.TabIndex = 17;
            // 
            // OrderStatus
            // 
            this.OrderStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderStatus.FormattingEnabled = true;
            this.OrderStatus.Location = new System.Drawing.Point(80, 34);
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.Size = new System.Drawing.Size(251, 23);
            this.OrderStatus.TabIndex = 16;
            // 
            // ConsumerInOrder
            // 
            this.ConsumerInOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsumerInOrder.FormattingEnabled = true;
            this.ConsumerInOrder.Location = new System.Drawing.Point(80, 3);
            this.ConsumerInOrder.Name = "ConsumerInOrder";
            this.ConsumerInOrder.Size = new System.Drawing.Size(251, 23);
            this.ConsumerInOrder.TabIndex = 15;
            // 
            // ClearOrderData
            // 
            this.ClearOrderData.Location = new System.Drawing.Point(3, 93);
            this.ClearOrderData.Name = "ClearOrderData";
            this.ClearOrderData.Size = new System.Drawing.Size(75, 23);
            this.ClearOrderData.TabIndex = 14;
            this.ClearOrderData.Text = "Clear";
            this.ClearOrderData.UseVisualStyleBackColor = true;
            // 
            // SaveOrder
            // 
            this.SaveOrder.Location = new System.Drawing.Point(3, 590);
            this.SaveOrder.Name = "SaveOrder";
            this.SaveOrder.Size = new System.Drawing.Size(75, 23);
            this.SaveOrder.TabIndex = 11;
            this.SaveOrder.Text = "Save";
            this.SaveOrder.UseVisualStyleBackColor = true;
            this.SaveOrder.Click += new System.EventHandler(this.SaveOrder_Click);
            // 
            // DeleteOrder
            // 
            this.DeleteOrder.Location = new System.Drawing.Point(256, 590);
            this.DeleteOrder.Name = "DeleteOrder";
            this.DeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.DeleteOrder.TabIndex = 10;
            this.DeleteOrder.Text = "Delete";
            this.DeleteOrder.UseVisualStyleBackColor = true;
            // 
            // CreateOrder
            // 
            this.CreateOrder.Location = new System.Drawing.Point(141, 590);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(75, 23);
            this.CreateOrder.TabIndex = 9;
            this.CreateOrder.Text = "Create";
            this.CreateOrder.UseVisualStyleBackColor = true;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 15);
            this.label19.TabIndex = 5;
            this.label19.Text = "EmployeeId";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 15);
            this.label20.TabIndex = 3;
            this.label20.Text = "Order status";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 15);
            this.label21.TabIndex = 1;
            this.label21.Text = "ConsumerId";
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersGrid.DataSource = this.orderBindingSource1;
            this.OrdersGrid.Location = new System.Drawing.Point(3, 3);
            this.OrdersGrid.MainView = this.gridView5;
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.Size = new System.Drawing.Size(854, 610);
            this.OrdersGrid.TabIndex = 0;
            this.OrdersGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCreateDate,
            this.colConsumer1,
            this.colPurchaseProducts,
            this.colOrderStatus,
            this.colEmploee,
            this.colId4});
            this.gridView5.GridControl = this.OrdersGrid;
            this.gridView5.Name = "gridView5";
            // 
            // colCreateDate
            // 
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 1;
            // 
            // colConsumer1
            // 
            this.colConsumer1.FieldName = "Consumer";
            this.colConsumer1.Name = "colConsumer1";
            this.colConsumer1.Visible = true;
            this.colConsumer1.VisibleIndex = 2;
            // 
            // colPurchaseProducts
            // 
            this.colPurchaseProducts.FieldName = "PurchaseProducts";
            this.colPurchaseProducts.Name = "colPurchaseProducts";
            // 
            // colOrderStatus
            // 
            this.colOrderStatus.FieldName = "OrderStatus";
            this.colOrderStatus.Name = "colOrderStatus";
            this.colOrderStatus.Visible = true;
            this.colOrderStatus.VisibleIndex = 3;
            // 
            // colEmploee
            // 
            this.colEmploee.FieldName = "Emploee";
            this.colEmploee.Name = "colEmploee";
            this.colEmploee.Visible = true;
            this.colEmploee.VisibleIndex = 4;
            // 
            // colId4
            // 
            this.colId4.FieldName = "Id";
            this.colId4.Name = "colId4";
            this.colId4.Visible = true;
            this.colId4.VisibleIndex = 0;
            // 
            // ExportTab
            // 
            this.ExportTab.Controls.Add(this.ExportButton);
            this.ExportTab.Controls.Add(this.label16);
            this.ExportTab.Controls.Add(this.ExportPeriod);
            this.ExportTab.Controls.Add(this.label15);
            this.ExportTab.Location = new System.Drawing.Point(4, 24);
            this.ExportTab.Name = "ExportTab";
            this.ExportTab.Size = new System.Drawing.Size(1198, 616);
            this.ExportTab.TabIndex = 5;
            this.ExportTab.Text = "Export";
            this.ExportTab.UseVisualStyleBackColor = true;
            // 
            // ExportButton
            // 
            this.ExportButton.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExportButton.Location = new System.Drawing.Point(382, 96);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(784, 501);
            this.ExportButton.TabIndex = 3;
            this.ExportButton.Text = "EXPORT";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(12, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "Period:";
            // 
            // ExportPeriod
            // 
            this.ExportPeriod.Location = new System.Drawing.Point(105, 96);
            this.ExportPeriod.MaxSelectionCount = 31;
            this.ExportPeriod.Name = "ExportPeriod";
            this.ExportPeriod.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(12, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1131, 111);
            this.label15.TabIndex = 0;
            this.label15.Text = resources.GetString("label15.Text");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1230, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pdfToolStripMenuItem,
            this.exelToolStripMenuItem,
            this.wordToolStripMenuItem,
            this.rtfToolStripMenuItem,
            this.htmlToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // pdfToolStripMenuItem
            // 
            this.pdfToolStripMenuItem.Name = "pdfToolStripMenuItem";
            this.pdfToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pdfToolStripMenuItem.Text = "Pdf";
            this.pdfToolStripMenuItem.Click += new System.EventHandler(this.pdfToolStripMenuItem_Click);
            // 
            // exelToolStripMenuItem
            // 
            this.exelToolStripMenuItem.Name = "exelToolStripMenuItem";
            this.exelToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exelToolStripMenuItem.Text = "Exel";
            this.exelToolStripMenuItem.Click += new System.EventHandler(this.exelToolStripMenuItem_Click);
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.wordToolStripMenuItem.Text = "Word";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.wordToolStripMenuItem_Click);
            // 
            // rtfToolStripMenuItem
            // 
            this.rtfToolStripMenuItem.Name = "rtfToolStripMenuItem";
            this.rtfToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.rtfToolStripMenuItem.Text = "Rtf";
            this.rtfToolStripMenuItem.Click += new System.EventHandler(this.rtfToolStripMenuItem_Click);
            // 
            // htmlToolStripMenuItem
            // 
            this.htmlToolStripMenuItem.Name = "htmlToolStripMenuItem";
            this.htmlToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.htmlToolStripMenuItem.Text = "Html";
            this.htmlToolStripMenuItem.Click += new System.EventHandler(this.htmlToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 683);
            this.Controls.Add(this.TableTabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " ";
            this.TableTabControl.ResumeLayout(false);
            this.EmployeeTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emploeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ConsumerTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConsumersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ProductTab.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductStockCountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPriceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.PurchaseProductsTab.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseProductCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseProductsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseProductBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.OrdersTab.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ExportTab.ResumeLayout(false);
            this.ExportTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseProductBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl TableTabControl;
        private TabPage EmployeeTab;
        private TabPage ConsumerTab;
        private SplitContainer splitContainer1;
        private Label label4;
        private Label label3;
        private TextBox EmployeePhone;
        private Label label2;
        private TextBox EmployeeSurname;
        private Label label1;
        private TextBox EmployeeName;
        private Label label5;
        private MonthCalendar EmployeeBirthDate;
        private Button EmployeeSaveButton;
        private Button CreateButton;
        private NumericUpDown EmployeeSalary;
        private Button DeleteButton;
        private SplitContainer splitContainer2;
        private MonthCalendar ConsumerBIrthdate;
        private Label label7;
        private Label label8;
        private TextBox ConsumerPhoneNumber;
        private Label label9;
        private TextBox ConsumerSurname;
        private Label label10;
        private TextBox ConsumerName;
        private Button ConsumerDeleteButton;
        private Button ConsumerSaveButton;
        private Button ConsumerCreateButton;
        private TabPage ProductTab;
        private SplitContainer splitContainer3;
        private Button SaveProduct;
        private Button DeleteProduct;
        private Button CreateProduct;
        private Label label6;
        private Label label11;
        private Label label12;
        private TextBox ProductDescription;
        private Label label13;
        private TextBox ProductName;
        private NumericUpDown ProductStockCountUpDown;
        private NumericUpDown ProductPriceUpDown;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockCountDataGridViewTextBoxColumn;
        private Button ClearEmployeeData;
        private Button ClearConsumerData;
        private Button ClearProductData;
        private TabPage PurchaseProductsTab;
        private TabPage OrdersTab;
        private SplitContainer splitContainer4;
        private Button ClearPurchaseProduct;
        private Button SavePurchaseProduct;
        private Button DeletePurchaseProduct;
        private Button CreatePurchaseProduct;
        private SplitContainer splitContainer5;
        private ComboBox EmployeeInOrder;
        private ComboBox OrderStatus;
        private ComboBox ConsumerInOrder;
        private Button ClearOrderData;
        private Button SaveOrder;
        private Button DeleteOrder;
        private Button CreateOrder;
        private Label label19;
        private Label label20;
        private Label label21;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn consumerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn purchaseProductsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emploeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private ComboBox ConsumerPurchaseProduct;
        private Label label22;
        private NumericUpDown PurchaseProductCount;
        private Label label14;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn purchaseCountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn consumerDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
        private ComboBox PurcahseProductOrder;
        private Label label23;
        private ComboBox PurchaseProductSourceProduct;
        private Label SourceProduct;
        private TabPage ExportTab;
        private Button ExportButton;
        private Label label16;
        private MonthCalendar ExportPeriod;
        private Label label15;
        private DevExpress.XtraGrid.GridControl EmployeeGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSalary;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.GridControl ConsumersGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BindingSource emploeeBindingSource;
        private BindingSource productBindingSource;
        private BindingSource orderBindingSource;
        private BindingSource purchaseProductBindingSource;
        private BindingSource consumerBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname1;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.GridControl ProductGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private BindingSource productBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colName2;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colStockCount;
        private DevExpress.XtraGrid.Columns.GridColumn colId2;
        private DevExpress.XtraGrid.GridControl PurchaseProductsGrid;
        private BindingSource purchaseProductBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colName3;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseCount;
        private DevExpress.XtraGrid.Columns.GridColumn colConsumer;
        private DevExpress.XtraGrid.Columns.GridColumn colOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colId3;
        private DevExpress.XtraGrid.GridControl OrdersGrid;
        private BindingSource orderBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colConsumer1;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseProducts;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colEmploee;
        private DevExpress.XtraGrid.Columns.GridColumn colId4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem pdfToolStripMenuItem;
        private ToolStripMenuItem exelToolStripMenuItem;
        private ToolStripMenuItem wordToolStripMenuItem;
        private ToolStripMenuItem rtfToolStripMenuItem;
        private ToolStripMenuItem htmlToolStripMenuItem;
    }
}