namespace ENV.UI
{
    partial class CustomOrderByDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AscDesc = new System.Windows.Forms.Button();
            this.SelectedColumns = new ENV.UI.myListBox();
            this.Down = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.ColumnsList = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.Ok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(7, 324);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 34);
            this.panel1.TabIndex = 9;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.Location = new System.Drawing.Point(387, 5);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 28);
            this.Cancel.TabIndex = 9;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.Location = new System.Drawing.Point(495, 5);
            this.Ok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(100, 28);
            this.Ok.TabIndex = 8;
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.AscDesc, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.SelectedColumns, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Down, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Add, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Up, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Remove, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ColumnsList, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(592, 314);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // AscDesc
            // 
            this.AscDesc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AscDesc.Location = new System.Drawing.Point(273, 252);
            this.AscDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AscDesc.Name = "AscDesc";
            this.AscDesc.Size = new System.Drawing.Size(44, 28);
            this.AscDesc.TabIndex = 23;
            this.AscDesc.Text = "D";
            this.AscDesc.UseVisualStyleBackColor = true;
            this.AscDesc.Click += new System.EventHandler(this.AscDesc_Click);
            // 
            // SelectedColumns
            // 
            this.SelectedColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedColumns.FormattingEnabled = true;
            this.SelectedColumns.ItemHeight = 16;
            this.SelectedColumns.Location = new System.Drawing.Point(326, 4);
            this.SelectedColumns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectedColumns.Name = "SelectedColumns";
            this.tableLayoutPanel1.SetRowSpan(this.SelectedColumns, 9);
            this.SelectedColumns.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.SelectedColumns.Size = new System.Drawing.Size(262, 292);
            this.SelectedColumns.TabIndex = 18;
            this.SelectedColumns.SelectedIndexChanged += new System.EventHandler(this.SelectedColumns_SelectedIndexChanged);
            this.SelectedColumns.DoubleClick += new System.EventHandler(this.SelectedColumns_DoubleClick);
            // 
            // Down
            // 
            this.Down.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Down.Location = new System.Drawing.Point(273, 66);
            this.Down.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(44, 28);
            this.Down.TabIndex = 22;
            this.Down.Text = "Down";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Add.Location = new System.Drawing.Point(273, 141);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(44, 28);
            this.Add.TabIndex = 19;
            this.Add.Text = ">";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Up
            // 
            this.Up.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Up.Location = new System.Drawing.Point(273, 29);
            this.Up.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(44, 28);
            this.Up.TabIndex = 21;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Remove
            // 
            this.Remove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Remove.Location = new System.Drawing.Point(273, 178);
            this.Remove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(44, 28);
            this.Remove.TabIndex = 20;
            this.Remove.Text = "<";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // ColumnsList
            // 
            this.ColumnsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnsList.FormattingEnabled = true;
            this.ColumnsList.ItemHeight = 16;
            this.ColumnsList.Location = new System.Drawing.Point(4, 4);
            this.ColumnsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ColumnsList.Name = "ColumnsList";
            this.tableLayoutPanel1.SetRowSpan(this.ColumnsList, 9);
            this.ColumnsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ColumnsList.Size = new System.Drawing.Size(261, 292);
            this.ColumnsList.TabIndex = 17;
            this.ColumnsList.SelectedIndexChanged += new System.EventHandler(this.ColumnsList_SelectedIndexChanged);
            this.ColumnsList.DoubleClick += new System.EventHandler(this.ColumnsList_DoubleClick);
            // 
            // CustomOrderByDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 364);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(618, 395);
            this.Name = "CustomOrderByDialog";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private myListBox SelectedColumns;
        private System.Windows.Forms.ListBox ColumnsList;
        private System.Windows.Forms.Button AscDesc;
    }
}