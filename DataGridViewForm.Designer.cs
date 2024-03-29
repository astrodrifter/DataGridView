﻿namespace DataViewGrid_Example {
    partial class DataGridViewForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.showValuesButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerTokenImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gamePointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highestPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(2, 211);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(86, 29);
            this.addPlayerButton.TabIndex = 1;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.addPlayerButton_Click);
            // 
            // showValuesButton
            // 
            this.showValuesButton.Location = new System.Drawing.Point(89, 211);
            this.showValuesButton.Name = "showValuesButton";
            this.showValuesButton.Size = new System.Drawing.Size(195, 29);
            this.showValuesButton.TabIndex = 2;
            this.showValuesButton.Text = "Show Values from players BindingList";
            this.showValuesButton.UseVisualStyleBackColor = true;
            this.showValuesButton.Click += new System.EventHandler(this.showValuesButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerTokenImageDataGridViewImageColumn,
            this.nameDataGridViewTextBoxColumn,
            this.gamePointsDataGridViewTextBoxColumn,
            this.highestPointsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.playerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(282, 213);
            this.dataGridView1.TabIndex = 3;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(DataViewGrid_Example.Player);
            // 
            // playerTokenImageDataGridViewImageColumn
            // 
            this.playerTokenImageDataGridViewImageColumn.DataPropertyName = "PlayerTokenImage";
            this.playerTokenImageDataGridViewImageColumn.HeaderText = "Colour";
            this.playerTokenImageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.playerTokenImageDataGridViewImageColumn.Name = "playerTokenImageDataGridViewImageColumn";
            this.playerTokenImageDataGridViewImageColumn.ReadOnly = true;
            this.playerTokenImageDataGridViewImageColumn.Width = 60;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // gamePointsDataGridViewTextBoxColumn
            // 
            this.gamePointsDataGridViewTextBoxColumn.DataPropertyName = "GamePoints";
            this.gamePointsDataGridViewTextBoxColumn.HeaderText = "Current Score";
            this.gamePointsDataGridViewTextBoxColumn.Name = "gamePointsDataGridViewTextBoxColumn";
            this.gamePointsDataGridViewTextBoxColumn.ReadOnly = true;
            this.gamePointsDataGridViewTextBoxColumn.Width = 50;
            // 
            // highestPointsDataGridViewTextBoxColumn
            // 
            this.highestPointsDataGridViewTextBoxColumn.DataPropertyName = "HighestPoints";
            this.highestPointsDataGridViewTextBoxColumn.HeaderText = "Best Score";
            this.highestPointsDataGridViewTextBoxColumn.Name = "highestPointsDataGridViewTextBoxColumn";
            this.highestPointsDataGridViewTextBoxColumn.ReadOnly = true;
            this.highestPointsDataGridViewTextBoxColumn.Width = 50;
            // 
            // DataGridViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showValuesButton);
            this.Controls.Add(this.addPlayerButton);
            this.Name = "DataGridViewForm";
            this.Text = "DataGridView Example";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button showValuesButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn playerTokenImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gamePointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highestPointsDataGridViewTextBoxColumn;
    }
}

