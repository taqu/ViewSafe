namespace ViewSafe
{
    partial class FormMain
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
			StatusStripMain = new StatusStrip();
			ToolStripStatusMain = new ToolStripStatusLabel();
			PanelDropFile = new Panel();
			LabelDrop = new Label();
			ListViewMetadata = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			GroupBoxMetadata = new GroupBox();
			TableLayoutTop = new TableLayoutPanel();
			GroupBoxTensors = new GroupBox();
			ListViewTensors = new ListView();
			ColumnName = new ColumnHeader();
			ColumnDType = new ColumnHeader();
			ColumnShape = new ColumnHeader();
			StatusStripMain.SuspendLayout();
			PanelDropFile.SuspendLayout();
			GroupBoxMetadata.SuspendLayout();
			TableLayoutTop.SuspendLayout();
			GroupBoxTensors.SuspendLayout();
			SuspendLayout();
			// 
			// StatusStripMain
			// 
			StatusStripMain.Items.AddRange(new ToolStripItem[] { ToolStripStatusMain });
			StatusStripMain.Location = new Point(0, 569);
			StatusStripMain.Name = "StatusStripMain";
			StatusStripMain.Size = new Size(456, 22);
			StatusStripMain.TabIndex = 1;
			StatusStripMain.Text = "statusStrip1";
			// 
			// ToolStripStatusMain
			// 
			ToolStripStatusMain.Name = "ToolStripStatusMain";
			ToolStripStatusMain.Size = new Size(0, 17);
			// 
			// PanelDropFile
			// 
			PanelDropFile.AllowDrop = true;
			PanelDropFile.BorderStyle = BorderStyle.FixedSingle;
			PanelDropFile.Controls.Add(LabelDrop);
			PanelDropFile.Dock = DockStyle.Fill;
			PanelDropFile.Location = new Point(3, 3);
			PanelDropFile.Name = "PanelDropFile";
			PanelDropFile.Size = new Size(450, 44);
			PanelDropFile.TabIndex = 2;
			PanelDropFile.DragDrop += OnDragDrop;
			PanelDropFile.DragEnter += OnDragEnter;
			// 
			// LabelDrop
			// 
			LabelDrop.AutoSize = true;
			LabelDrop.ImageAlign = ContentAlignment.TopLeft;
			LabelDrop.Location = new Point(3, 5);
			LabelDrop.Name = "LabelDrop";
			LabelDrop.Size = new Size(97, 15);
			LabelDrop.TabIndex = 0;
			LabelDrop.Text = "Drop SafeTensors";
			LabelDrop.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// ListViewMetadata
			// 
			ListViewMetadata.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
			ListViewMetadata.Dock = DockStyle.Fill;
			ListViewMetadata.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			ListViewMetadata.Location = new Point(3, 19);
			ListViewMetadata.MultiSelect = false;
			ListViewMetadata.Name = "ListViewMetadata";
			ListViewMetadata.Size = new Size(444, 127);
			ListViewMetadata.TabIndex = 3;
			ListViewMetadata.UseCompatibleStateImageBehavior = false;
			ListViewMetadata.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Key";
			columnHeader1.Width = 140;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Value";
			columnHeader2.Width = 300;
			// 
			// GroupBoxMetadata
			// 
			GroupBoxMetadata.Controls.Add(ListViewMetadata);
			GroupBoxMetadata.Dock = DockStyle.Fill;
			GroupBoxMetadata.Location = new Point(3, 53);
			GroupBoxMetadata.Name = "GroupBoxMetadata";
			GroupBoxMetadata.Size = new Size(450, 149);
			GroupBoxMetadata.TabIndex = 4;
			GroupBoxMetadata.TabStop = false;
			GroupBoxMetadata.Text = "Metadata";
			// 
			// TableLayoutTop
			// 
			TableLayoutTop.ColumnCount = 1;
			TableLayoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			TableLayoutTop.Controls.Add(GroupBoxTensors, 0, 2);
			TableLayoutTop.Controls.Add(PanelDropFile, 0, 0);
			TableLayoutTop.Controls.Add(GroupBoxMetadata, 0, 1);
			TableLayoutTop.Dock = DockStyle.Fill;
			TableLayoutTop.Location = new Point(0, 0);
			TableLayoutTop.Name = "TableLayoutTop";
			TableLayoutTop.RowCount = 3;
			TableLayoutTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			TableLayoutTop.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
			TableLayoutTop.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
			TableLayoutTop.Size = new Size(456, 569);
			TableLayoutTop.TabIndex = 5;
			// 
			// GroupBoxTensors
			// 
			GroupBoxTensors.Controls.Add(ListViewTensors);
			GroupBoxTensors.Dock = DockStyle.Fill;
			GroupBoxTensors.Location = new Point(3, 208);
			GroupBoxTensors.Name = "GroupBoxTensors";
			GroupBoxTensors.Size = new Size(450, 358);
			GroupBoxTensors.TabIndex = 6;
			GroupBoxTensors.TabStop = false;
			GroupBoxTensors.Text = "Tensors";
			// 
			// ListViewTensors
			// 
			ListViewTensors.Columns.AddRange(new ColumnHeader[] { ColumnName, ColumnDType, ColumnShape });
			ListViewTensors.Dock = DockStyle.Fill;
			ListViewTensors.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			ListViewTensors.Location = new Point(3, 19);
			ListViewTensors.MultiSelect = false;
			ListViewTensors.Name = "ListViewTensors";
			ListViewTensors.Size = new Size(444, 336);
			ListViewTensors.TabIndex = 5;
			ListViewTensors.UseCompatibleStateImageBehavior = false;
			ListViewTensors.View = View.Details;
			// 
			// ColumnName
			// 
			ColumnName.Text = "Name";
			ColumnName.Width = 200;
			// 
			// ColumnDType
			// 
			ColumnDType.Text = "DType";
			ColumnDType.Width = 80;
			// 
			// ColumnShape
			// 
			ColumnShape.Text = "Shape";
			ColumnShape.Width = 160;
			// 
			// FormMain
			// 
			AllowDrop = true;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(456, 591);
			Controls.Add(TableLayoutTop);
			Controls.Add(StatusStripMain);
			Name = "FormMain";
			Text = "ViewSafe";
			StatusStripMain.ResumeLayout(false);
			StatusStripMain.PerformLayout();
			PanelDropFile.ResumeLayout(false);
			PanelDropFile.PerformLayout();
			GroupBoxMetadata.ResumeLayout(false);
			TableLayoutTop.ResumeLayout(false);
			GroupBoxTensors.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private StatusStrip StatusStripMain;
		private ToolStripStatusLabel ToolStripStatusMain;
		private Panel PanelDropFile;
		private Label LabelDrop;
		private ListView ListViewMetadata;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private GroupBox GroupBoxMetadata;
		private TableLayoutPanel TableLayoutTop;
		private ListView ListViewTensors;
		private ColumnHeader ColumnName;
		private ColumnHeader ColumnDType;
		private ColumnHeader ColumnShape;
		private GroupBox GroupBoxTensors;
	}
}
