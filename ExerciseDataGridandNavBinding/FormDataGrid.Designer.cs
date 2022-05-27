
namespace ExerciseDataGridandNavBinding
{
    partial class FormDataGrid
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodiTIDataSet = new ExerciseDataGridandNavBinding.ProdiTIDataSet();
            this.labelTelepon = new System.Windows.Forms.Label();
            this.labelJK = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelNomorMhs = new System.Windows.Forms.Label();
            this.mahasiswaTableAdapter = new ExerciseDataGridandNavBinding.ProdiTIDataSetTableAdapters.MahasiswaTableAdapter();
            this.btnExitFDG = new System.Windows.Forms.Button();
            this.labelNIM = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPhone);
            this.groupBox1.Controls.Add(this.labelAddress);
            this.groupBox1.Controls.Add(this.labelSex);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.labelNIM);
            this.groupBox1.Controls.Add(this.labelTelepon);
            this.groupBox1.Controls.Add(this.labelJK);
            this.groupBox1.Controls.Add(this.labelAlamat);
            this.groupBox1.Controls.Add(this.labelNama);
            this.groupBox1.Controls.Add(this.labelNomorMhs);
            this.groupBox1.Location = new System.Drawing.Point(49, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 314);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Mahasiswa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.prodiTIDataSet;
            // 
            // prodiTIDataSet
            // 
            this.prodiTIDataSet.DataSetName = "ProdiTIDataSet";
            this.prodiTIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelTelepon
            // 
            this.labelTelepon.AutoSize = true;
            this.labelTelepon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelepon.Location = new System.Drawing.Point(42, 253);
            this.labelTelepon.Name = "labelTelepon";
            this.labelTelepon.Size = new System.Drawing.Size(98, 20);
            this.labelTelepon.TabIndex = 4;
            this.labelTelepon.Text = "No. Telepon";
            // 
            // labelJK
            // 
            this.labelJK.AutoSize = true;
            this.labelJK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJK.Location = new System.Drawing.Point(42, 160);
            this.labelJK.Name = "labelJK";
            this.labelJK.Size = new System.Drawing.Size(114, 20);
            this.labelJK.TabIndex = 3;
            this.labelJK.Text = "Jenis Kelamin";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlamat.Location = new System.Drawing.Point(42, 210);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(150, 20);
            this.labelAlamat.TabIndex = 2;
            this.labelAlamat.Text = "Alamat Mahasiswa";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(42, 111);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(142, 20);
            this.labelNama.TabIndex = 1;
            this.labelNama.Text = "Nama Mahasiswa";
            // 
            // labelNomorMhs
            // 
            this.labelNomorMhs.AutoSize = true;
            this.labelNomorMhs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomorMhs.Location = new System.Drawing.Point(42, 67);
            this.labelNomorMhs.Name = "labelNomorMhs";
            this.labelNomorMhs.Size = new System.Drawing.Size(123, 20);
            this.labelNomorMhs.TabIndex = 0;
            this.labelNomorMhs.Text = "No. Mahasiswa";
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // btnExitFDG
            // 
            this.btnExitFDG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitFDG.Image = global::ExerciseDataGridandNavBinding.Properties.Resources.arrow_left;
            this.btnExitFDG.Location = new System.Drawing.Point(12, 387);
            this.btnExitFDG.Name = "btnExitFDG";
            this.btnExitFDG.Size = new System.Drawing.Size(59, 62);
            this.btnExitFDG.TabIndex = 3;
            this.btnExitFDG.UseVisualStyleBackColor = true;
            this.btnExitFDG.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNIM
            // 
            this.labelNIM.AutoSize = true;
            this.labelNIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNIM.Location = new System.Drawing.Point(232, 67);
            this.labelNIM.Name = "labelNIM";
            this.labelNIM.Size = new System.Drawing.Size(39, 20);
            this.labelNIM.TabIndex = 5;
            this.labelNIM.Text = "NIM";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(232, 111);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(53, 20);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Nama";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSex.Location = new System.Drawing.Point(232, 160);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(37, 20);
            this.labelSex.TabIndex = 7;
            this.labelSex.Text = "Sex";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(232, 210);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(71, 20);
            this.labelAddress.TabIndex = 8;
            this.labelAddress.Text = "Address";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(232, 253);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(56, 20);
            this.labelPhone.TabIndex = 9;
            this.labelPhone.Text = "Phone";
            // 
            // FormDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 461);
            this.Controls.Add(this.btnExitFDG);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDataGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDataGrid";
            this.Load += new System.EventHandler(this.FormDataGrid_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExitFDG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTelepon;
        private System.Windows.Forms.Label labelJK;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelNomorMhs;
        private ProdiTIDataSet prodiTIDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private ProdiTIDataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Label labelNIM;
        public System.Windows.Forms.Label labelPhone;
        public System.Windows.Forms.Label labelAddress;
        public System.Windows.Forms.Label labelSex;
    }
}