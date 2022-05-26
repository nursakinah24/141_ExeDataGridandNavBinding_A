
namespace ExerciseDataGridandNavBinding
{
    partial class MenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExitMenu = new System.Windows.Forms.Button();
            this.btnNavi = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Staatliches", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(147, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 78);
            this.label1.TabIndex = 12;
            this.label1.Text = "Main Menu";
            // 
            // btnExitMenu
            // 
            this.btnExitMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitMenu.Image = global::ExerciseDataGridandNavBinding.Properties.Resources.log_out__1_;
            this.btnExitMenu.Location = new System.Drawing.Point(475, 364);
            this.btnExitMenu.Name = "btnExitMenu";
            this.btnExitMenu.Size = new System.Drawing.Size(59, 64);
            this.btnExitMenu.TabIndex = 15;
            this.btnExitMenu.UseVisualStyleBackColor = true;
            // 
            // btnNavi
            // 
            this.btnNavi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNavi.Image = global::ExerciseDataGridandNavBinding.Properties.Resources.bracket__1_;
            this.btnNavi.Location = new System.Drawing.Point(312, 155);
            this.btnNavi.Name = "btnNavi";
            this.btnNavi.Size = new System.Drawing.Size(165, 150);
            this.btnNavi.TabIndex = 14;
            this.btnNavi.Text = "Binding Navigation";
            this.btnNavi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNavi.UseVisualStyleBackColor = true;
            // 
            // btnData
            // 
            this.btnData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnData.Image = global::ExerciseDataGridandNavBinding.Properties.Resources.grid__1_;
            this.btnData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnData.Location = new System.Drawing.Point(69, 155);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(165, 150);
            this.btnData.TabIndex = 13;
            this.btnData.Text = "DataGridView";
            this.btnData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnData.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 461);
            this.Controls.Add(this.btnExitMenu);
            this.Controls.Add(this.btnNavi);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitMenu;
        private System.Windows.Forms.Button btnNavi;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Label label1;
    }
}