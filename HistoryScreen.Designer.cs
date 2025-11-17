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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            HistoryTable = new System.Windows.Forms.DataGridView();
            BackStartScreenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)HistoryTable).BeginInit();
            SuspendLayout();
            // 
            // HistoryTable
            // 
            HistoryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            HistoryTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)224)), ((int)((byte)192)));
            HistoryTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            HistoryTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)0)));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)224)), ((int)((byte)192)));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)((byte)64)), ((int)((byte)64)), ((int)((byte)64)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            HistoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            HistoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HistoryTable.GridColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)224)), ((int)((byte)192)));
            HistoryTable.Location = new System.Drawing.Point(43, 12);
            HistoryTable.Name = "HistoryTable";
            HistoryTable.RowHeadersVisible = false;
            HistoryTable.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)224)), ((int)((byte)192)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)128)), ((int)((byte)128)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)192)), ((int)((byte)128)));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            HistoryTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            HistoryTable.Size = new System.Drawing.Size(700, 350);
            HistoryTable.TabIndex = 0;
            // 
            // BackStartScreenButton
            // 
            BackStartScreenButton.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)255)), ((int)((byte)128)));
            BackStartScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            BackStartScreenButton.Location = new System.Drawing.Point(643, 388);
            BackStartScreenButton.Name = "BackStartScreenButton";
            BackStartScreenButton.Size = new System.Drawing.Size(100, 50);
            BackStartScreenButton.TabIndex = 1;
            BackStartScreenButton.Text = "Start Screen";
            BackStartScreenButton.UseVisualStyleBackColor = false;
            // 
            // HistoryScreen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)192)), ((int)((byte)255)), ((int)((byte)192)));
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(BackStartScreenButton);
            Controls.Add(HistoryTable);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "HistoryScreen";
            ((System.ComponentModel.ISupportInitialize)HistoryTable).EndInit();
            ResumeLayout(false);

            StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion

        private DataGridView HistoryTable;
        private Button BackStartScreenButton;
    }
}