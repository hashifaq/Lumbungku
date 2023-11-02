namespace WFA_Lumbungku
{
    partial class Inventory
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.tbTipe = new System.Windows.Forms.TextBox();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReadHasil = new System.Windows.Forms.Button();
            this.btnReadBibit = new System.Windows.Forms.Button();
            this.btnReadAlat = new System.Windows.Forms.Button();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(375, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manajemen Inventaris";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(44, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(43, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unit    :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(44, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipe   :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(44, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stok   :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(427, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Search :";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(114, 112);
            this.tbNama.Margin = new System.Windows.Forms.Padding(2);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(249, 20);
            this.tbNama.TabIndex = 6;
            // 
            // tbUnit
            // 
            this.tbUnit.Location = new System.Drawing.Point(114, 157);
            this.tbUnit.Margin = new System.Windows.Forms.Padding(2);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.Size = new System.Drawing.Size(249, 20);
            this.tbUnit.TabIndex = 7;
            // 
            // tbTipe
            // 
            this.tbTipe.Location = new System.Drawing.Point(114, 205);
            this.tbTipe.Margin = new System.Windows.Forms.Padding(2);
            this.tbTipe.Name = "tbTipe";
            this.tbTipe.Size = new System.Drawing.Size(249, 20);
            this.tbTipe.TabIndex = 8;
            // 
            // tbStok
            // 
            this.tbStok.Location = new System.Drawing.Point(114, 258);
            this.tbStok.Margin = new System.Windows.Forms.Padding(2);
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(249, 20);
            this.tbStok.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(511, 107);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(469, 20);
            this.textBox5.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(70, 490);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 31);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(175, 490);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(71, 31);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(277, 490);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 31);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReadHasil
            // 
            this.btnReadHasil.BackColor = System.Drawing.Color.White;
            this.btnReadHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadHasil.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReadHasil.Location = new System.Drawing.Point(750, 497);
            this.btnReadHasil.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadHasil.Name = "btnReadHasil";
            this.btnReadHasil.Size = new System.Drawing.Size(82, 25);
            this.btnReadHasil.TabIndex = 14;
            this.btnReadHasil.Text = "Hasil";
            this.btnReadHasil.UseVisualStyleBackColor = false;
            this.btnReadHasil.Click += new System.EventHandler(this.btnReadHasil_Click);
            // 
            // btnReadBibit
            // 
            this.btnReadBibit.BackColor = System.Drawing.Color.White;
            this.btnReadBibit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadBibit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReadBibit.Location = new System.Drawing.Point(852, 497);
            this.btnReadBibit.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadBibit.Name = "btnReadBibit";
            this.btnReadBibit.Size = new System.Drawing.Size(82, 25);
            this.btnReadBibit.TabIndex = 15;
            this.btnReadBibit.Text = "Bibit";
            this.btnReadBibit.UseVisualStyleBackColor = false;
            this.btnReadBibit.Click += new System.EventHandler(this.btnReadBibit_Click);
            // 
            // btnReadAlat
            // 
            this.btnReadAlat.BackColor = System.Drawing.Color.White;
            this.btnReadAlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadAlat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReadAlat.Location = new System.Drawing.Point(951, 497);
            this.btnReadAlat.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadAlat.Name = "btnReadAlat";
            this.btnReadAlat.Size = new System.Drawing.Size(82, 25);
            this.btnReadAlat.TabIndex = 16;
            this.btnReadAlat.Text = "Peralatan";
            this.btnReadAlat.UseVisualStyleBackColor = false;
            this.btnReadAlat.Click += new System.EventHandler(this.btnReadAlat_Click);
            // 
            // dgvBarang
            // 
            this.dgvBarang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Location = new System.Drawing.Point(430, 140);
            this.dgvBarang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.RowHeadersWidth = 62;
            this.dgvBarang.RowTemplate.Height = 28;
            this.dgvBarang.Size = new System.Drawing.Size(609, 339);
            this.dgvBarang.TabIndex = 17;
            this.dgvBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBarang_CellContentClick);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(982, 105);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(51, 20);
            this.btnFind.TabIndex = 18;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(45, 316);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Foto   :";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxFoto.Location = new System.Drawing.Point(114, 316);
            this.pictureBoxFoto.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(248, 101);
            this.pictureBoxFoto.TabIndex = 20;
            this.pictureBoxFoto.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.White;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpload.Location = new System.Drawing.Point(114, 429);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(248, 25);
            this.btnUpload.TabIndex = 21;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.White;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLoad.Location = new System.Drawing.Point(430, 496);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(131, 25);
            this.btnLoad.TabIndex = 22;
            this.btnLoad.Text = "Tampilkan Semua";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1064, 559);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dgvBarang);
            this.Controls.Add(this.btnReadAlat);
            this.Controls.Add(this.btnReadBibit);
            this.Controls.Add(this.btnReadHasil);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tbStok);
            this.Controls.Add(this.tbTipe);
            this.Controls.Add(this.tbUnit);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.TextBox tbTipe;
        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReadHasil;
        private System.Windows.Forms.Button btnReadBibit;
        private System.Windows.Forms.Button btnReadAlat;
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnLoad;
    }
}