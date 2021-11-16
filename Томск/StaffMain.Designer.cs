
namespace Томск
{
    partial class StaffMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ActiveWashing = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DoneWashing = new System.Windows.Forms.TabPage();
            this.Report = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.ActiveWashing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ActiveWashing);
            this.tabControl1.Controls.Add(this.DoneWashing);
            this.tabControl1.Controls.Add(this.Report);
            this.tabControl1.Location = new System.Drawing.Point(46, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1227, 402);
            this.tabControl1.TabIndex = 1;
            // 
            // ActiveWashing
            // 
            this.ActiveWashing.Controls.Add(this.dataGridView1);
            this.ActiveWashing.Location = new System.Drawing.Point(4, 29);
            this.ActiveWashing.Name = "ActiveWashing";
            this.ActiveWashing.Padding = new System.Windows.Forms.Padding(3);
            this.ActiveWashing.Size = new System.Drawing.Size(1219, 369);
            this.ActiveWashing.TabIndex = 0;
            this.ActiveWashing.Text = "Активные стрики";
            this.ActiveWashing.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1207, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // DoneWashing
            // 
            this.DoneWashing.Location = new System.Drawing.Point(4, 29);
            this.DoneWashing.Name = "DoneWashing";
            this.DoneWashing.Padding = new System.Windows.Forms.Padding(3);
            this.DoneWashing.Size = new System.Drawing.Size(819, 369);
            this.DoneWashing.TabIndex = 1;
            this.DoneWashing.Text = "Заверешенные стирки";
            this.DoneWashing.UseVisualStyleBackColor = true;
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(4, 29);
            this.Report.Name = "Report";
            this.Report.Padding = new System.Windows.Forms.Padding(3);
            this.Report.Size = new System.Drawing.Size(510, 369);
            this.Report.TabIndex = 2;
            this.Report.Text = "Кассовый отчет";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // StaffMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 653);
            this.Controls.Add(this.tabControl1);
            this.Name = "StaffMain";
            this.Text = "StaffMain";
            this.Load += new System.EventHandler(this.StaffMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.ActiveWashing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ActiveWashing;
        private System.Windows.Forms.TabPage DoneWashing;
        private System.Windows.Forms.TabPage Report;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}