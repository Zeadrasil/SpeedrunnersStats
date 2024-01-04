namespace SpeedrunnersStats
{
    partial class SettingsPage
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
            itemCheckbox = new CheckBox();
            playerCheckbox = new CheckBox();
            loadingCheckBox = new CheckBox();
            changeDumpButton = new Button();
            dumpLabel = new Label();
            dataLabel = new Label();
            ChageDataButton = new Button();
            saveButton = new Button();
            exitButton = new Button();
            revertButton = new Button();
            SuspendLayout();
            // 
            // itemCheckbox
            // 
            itemCheckbox.AutoSize = true;
            itemCheckbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemCheckbox.Location = new Point(12, 12);
            itemCheckbox.Name = "itemCheckbox";
            itemCheckbox.Size = new Size(246, 36);
            itemCheckbox.TabIndex = 0;
            itemCheckbox.Text = "Complex Item Stats";
            itemCheckbox.UseVisualStyleBackColor = true;
            itemCheckbox.CheckedChanged += itemCheckbox_CheckedChanged;
            // 
            // playerCheckbox
            // 
            playerCheckbox.AutoSize = true;
            playerCheckbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            playerCheckbox.Location = new Point(12, 54);
            playerCheckbox.Name = "playerCheckbox";
            playerCheckbox.Size = new Size(262, 36);
            playerCheckbox.TabIndex = 1;
            playerCheckbox.Text = "Complex Player Stats";
            playerCheckbox.UseVisualStyleBackColor = true;
            playerCheckbox.CheckedChanged += playerCheckbox_CheckedChanged;
            // 
            // loadingCheckBox
            // 
            loadingCheckBox.AutoSize = true;
            loadingCheckBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loadingCheckBox.Location = new Point(12, 96);
            loadingCheckBox.Name = "loadingCheckBox";
            loadingCheckBox.Size = new Size(257, 36);
            loadingCheckBox.TabIndex = 2;
            loadingCheckBox.Text = "Foreground Loading";
            loadingCheckBox.UseVisualStyleBackColor = true;
            loadingCheckBox.CheckedChanged += loadingCheckBox_CheckedChanged;
            // 
            // changeDumpButton
            // 
            changeDumpButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            changeDumpButton.Location = new Point(548, 277);
            changeDumpButton.Name = "changeDumpButton";
            changeDumpButton.Size = new Size(170, 73);
            changeDumpButton.TabIndex = 3;
            changeDumpButton.Text = "Change Dump Source";
            changeDumpButton.UseVisualStyleBackColor = true;
            // 
            // dumpLabel
            // 
            dumpLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dumpLabel.Location = new Point(368, 9);
            dumpLabel.Name = "dumpLabel";
            dumpLabel.Size = new Size(350, 265);
            dumpLabel.TabIndex = 4;
            dumpLabel.Text = "Dump Source:";
            dumpLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataLabel
            // 
            dataLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataLabel.Location = new Point(12, 151);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new Size(350, 265);
            dataLabel.TabIndex = 5;
            dataLabel.Text = "Data Path:";
            dataLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ChageDataButton
            // 
            ChageDataButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ChageDataButton.Location = new Point(368, 277);
            ChageDataButton.Name = "ChageDataButton";
            ChageDataButton.Size = new Size(170, 73);
            ChageDataButton.TabIndex = 6;
            ChageDataButton.Text = "Change Data Path";
            ChageDataButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(368, 356);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 57);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.Location = new Point(606, 356);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(112, 57);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // revertButton
            // 
            revertButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            revertButton.Location = new Point(488, 356);
            revertButton.Name = "revertButton";
            revertButton.Size = new Size(112, 57);
            revertButton.TabIndex = 9;
            revertButton.Text = "Revert";
            revertButton.UseVisualStyleBackColor = true;
            revertButton.Click += revertButton_Click;
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 425);
            Controls.Add(revertButton);
            Controls.Add(exitButton);
            Controls.Add(saveButton);
            Controls.Add(ChageDataButton);
            Controls.Add(dataLabel);
            Controls.Add(dumpLabel);
            Controls.Add(changeDumpButton);
            Controls.Add(loadingCheckBox);
            Controls.Add(playerCheckbox);
            Controls.Add(itemCheckbox);
            Name = "SettingsPage";
            Text = "SettingsPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox itemCheckbox;
        private CheckBox playerCheckbox;
        private CheckBox loadingCheckBox;
        private Button changeDumpButton;
        private Label dumpLabel;
        private Label dataLabel;
        private Button ChageDataButton;
        private Button saveButton;
        private Button exitButton;
        private Button revertButton;
    }
}