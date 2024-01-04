namespace SpeedrunnersStats
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
            itemStatsButton = new Button();
            mapStatsButton = new Button();
            settingsButton = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // itemStatsButton
            // 
            itemStatsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemStatsButton.Location = new Point(12, 374);
            itemStatsButton.Name = "itemStatsButton";
            itemStatsButton.Size = new Size(150, 64);
            itemStatsButton.TabIndex = 0;
            itemStatsButton.Text = "Item Stats";
            itemStatsButton.UseVisualStyleBackColor = true;
            // 
            // mapStatsButton
            // 
            mapStatsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mapStatsButton.Location = new Point(231, 374);
            mapStatsButton.Name = "mapStatsButton";
            mapStatsButton.Size = new Size(150, 64);
            mapStatsButton.TabIndex = 1;
            mapStatsButton.Text = "Map Picks";
            mapStatsButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            settingsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            settingsButton.Location = new Point(450, 374);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(150, 64);
            settingsButton.TabIndex = 2;
            settingsButton.Text = "Settings";
            settingsButton.UseVisualStyleBackColor = true;
            settingsButton.Click += settingsButton_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(588, 356);
            listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 450);
            Controls.Add(listBox1);
            Controls.Add(settingsButton);
            Controls.Add(mapStatsButton);
            Controls.Add(itemStatsButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button itemStatsButton;
        private Button mapStatsButton;
        private Button settingsButton;
        private ListBox listBox1;
    }
}