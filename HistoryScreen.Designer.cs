namespace BTLT04
{
    partial class HistoryScreen
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            HistoryTable = new DataGridView();
            BackStartScreenButton = new Button();
            ((System.ComponentModel.ISupportInitialize)HistoryTable).BeginInit();
            SuspendLayout();
            // 
            // HistoryTable
            // 
            HistoryTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HistoryTable.BackgroundColor = Color.FromArgb(255, 224, 192);
            HistoryTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            HistoryTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            HistoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            HistoryTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HistoryTable.GridColor = Color.FromArgb(255, 224, 192);
            HistoryTable.Location = new Point(43, 12);
            HistoryTable.Name = "HistoryTable";
            HistoryTable.RowHeadersVisible = false;
            HistoryTable.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle2.SelectionForeColor = Color.Gray;
            HistoryTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            HistoryTable.Size = new Size(700, 350);
            HistoryTable.TabIndex = 0;
            // 
            // BackStartScreenButton
            // 
            BackStartScreenButton.BackColor = Color.FromArgb(255, 255, 128);
            BackStartScreenButton.Font = new Font("Sesame", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackStartScreenButton.Location = new Point(643, 388);
            BackStartScreenButton.Name = "BackStartScreenButton";
            BackStartScreenButton.Size = new Size(100, 50);
            BackStartScreenButton.TabIndex = 1;
            BackStartScreenButton.Text = "Start Screen";
            BackStartScreenButton.UseVisualStyleBackColor = false;
            // 
            // HistoryScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(BackStartScreenButton);
            Controls.Add(HistoryTable);
            Name = "HistoryScreen";
            Text = "HistoryScreen";
            ((System.ComponentModel.ISupportInitialize)HistoryTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView HistoryTable;
        private Button BackStartScreenButton;
    }
}