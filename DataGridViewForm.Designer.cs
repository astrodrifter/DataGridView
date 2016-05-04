namespace DataViewGrid_Example {
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
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.showValuesButton = new System.Windows.Forms.Button();
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
            // DataGridViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.showValuesButton);
            this.Controls.Add(this.addPlayerButton);
            this.Name = "DataGridViewForm";
            this.Text = "DataGridView Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button showValuesButton;
    }
}

