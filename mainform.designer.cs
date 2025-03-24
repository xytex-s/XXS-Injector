namespace DLLInjector
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox processNameTextBox;
        private System.Windows.Forms.TextBox dllPathTextBox;
        private System.Windows.Forms.Button injectButton;
        private System.Windows.Forms.Label processNameLabel;
        private System.Windows.Forms.Label dllPathLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.processNameTextBox = new System.Windows.Forms.TextBox();
            this.dllPathTextBox = new System.Windows.Forms.TextBox();
            this.injectButton = new System.Windows.Forms.Button();
            this.processNameLabel = new System.Windows.Forms.Label();
            this.dllPathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processNameTextBox
            // 
            this.processNameTextBox.Location = new System.Drawing.Point(120, 20);
            this.processNameTextBox.Name = "processNameTextBox";
            this.processNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.processNameTextBox.TabIndex = 0;
            // 
            // dllPathTextBox
            // 
            this.dllPathTextBox.Location = new System.Drawing.Point(120, 60);
            this.dllPathTextBox.Name = "dllPathTextBox";
            this.dllPathTextBox.Size = new System.Drawing.Size(200, 20);
            this.dllPathTextBox.TabIndex = 1;
            // 
            // injectButton
            // 
            this.injectButton.Location = new System.Drawing.Point(120, 100);
            this.injectButton.Name = "injectButton";
            this.injectButton.Size = new System.Drawing.Size(75, 23);
            this.injectButton.TabIndex = 2;
            this.injectButton.Text = "Inject";
            this.injectButton.UseVisualStyleBackColor = true;
            this.injectButton.Click += new System.EventHandler(this.injectButton_Click);
            // 
            // processNameLabel
            // 
            this.processNameLabel.AutoSize = true;
            this.processNameLabel.Location = new System.Drawing.Point(20, 23);
            this.processNameLabel.Name = "processNameLabel";
            this.processNameLabel.Size = new System.Drawing.Size(78, 13);
            this.processNameLabel.TabIndex = 3;
            this.processNameLabel.Text = "Process Name:";
            // 
            // dllPathLabel
            // 
            this.dllPathLabel.AutoSize = true;
            this.dllPathLabel.Location = new System.Drawing.Point(20, 63);
            this.dllPathLabel.Name = "dllPathLabel";
            this.dllPathLabel.Size = new System.Drawing.Size(50, 13);
            this.dllPathLabel.TabIndex = 4;
            this.dllPathLabel.Text = "DLL Path:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 150);
            this.Controls.Add(this.dllPathLabel);
            this.Controls.Add(this.processNameLabel);
            this.Controls.Add(this.injectButton);
            this.Controls.Add(this.dllPathTextBox);
            this.Controls.Add(this.processNameTextBox);
            this.Name = "MainForm";
            this.Text = "DLL Injector";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
