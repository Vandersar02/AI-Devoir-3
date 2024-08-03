namespace Devoir3
{
    partial class MazeForm
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
            btnSave = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(603, 600);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save to PNG";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // MazeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 639);
            Controls.Add(btnSave);
            MaximizeBox = false;
            Name = "MazeForm";
            Text = "Devoir3_StCyr";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
    }
}
