namespace Northwind.ViewsShowProducts.Views
{
    partial class ShowProductsView
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
            this.gridShowProducTest = new Northwind.Shared.Theme.Controls.Grid();
            this.gcProductName = new Northwind.Shared.Theme.Controls.GridColumn();
            this.txtProductName = new Northwind.Shared.Theme.Controls.TextBox();
            this.gridShowProducTest.SuspendLayout();
            this.gcProductName.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridShowProducTest
            // 
            this.gridShowProducTest.Controls.Add(this.gcProductName);
            this.gridShowProducTest.Location = new System.Drawing.Point(3, 3);
            this.gridShowProducTest.Name = "gridShowProducTest";
            this.gridShowProducTest.Size = new System.Drawing.Size(394, 319);
            this.gridShowProducTest.Text = "Show Produc - Test";
            // 
            // gcProductName
            // 
            this.gcProductName.Controls.Add(this.txtProductName);
            this.gcProductName.Name = "gcProductName";
            this.gcProductName.Text = "ProductName";
            this.gcProductName.Width = 285;
            // 
            // txtProductName
            // 
            this.txtProductName.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.txtProductName.Location = new System.Drawing.Point(2, 1);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(279, 21);
            this.txtProductName.Style = Firefly.Box.UI.ControlStyle.Flat;
            this.txtProductName.Data = this._controller.products.ProductName;
            // 
            // ShowProductsView
            // 
            this.Controls.Add(this.gridShowProducTest);
            this.HorizontalExpressionFactor = 1D;
            this.Name = "ShowProductsView";
            this.Text = "Show Products - Test";
            this.VerticalExpressionFactor = 1D;
            this.gridShowProducTest.ResumeLayout(false);
            this.gcProductName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Shared.Theme.Controls.Grid gridShowProducTest;
        private Shared.Theme.Controls.GridColumn gcProductName;
        private Shared.Theme.Controls.TextBox txtProductName;
    }
}