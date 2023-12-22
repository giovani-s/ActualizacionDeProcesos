namespace Actualizacion_de_Procesos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSaveState = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnPreviousProcess = new System.Windows.Forms.Button();
            this.btnNextProcess = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.currentProcess = new System.Windows.Forms.TextBox();
            this.btnAddProcess = new System.Windows.Forms.Button();
            this.btnAddStatus = new System.Windows.Forms.Button();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnDelCurrentProcess = new System.Windows.Forms.Button();
            this.beforeStateCount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeStateCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveState
            // 
            this.btnSaveState.Location = new System.Drawing.Point(12, 102);
            this.btnSaveState.Name = "btnSaveState";
            this.btnSaveState.Size = new System.Drawing.Size(111, 23);
            this.btnSaveState.TabIndex = 0;
            this.btnSaveState.Text = "Guardar Estados";
            this.btnSaveState.UseVisualStyleBackColor = true;
            this.btnSaveState.Click += new System.EventHandler(this.btnSaveState_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Location = new System.Drawing.Point(12, 12);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(112, 23);
            this.btnImportExcel.TabIndex = 1;
            this.btnImportExcel.Text = "Seleccionar Excel";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Radicado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Demandante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Demandado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo de proceso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Juzgado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 34);
            this.textBox1.TabIndex = 15;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(264, 62);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 34);
            this.textBox2.TabIndex = 16;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(370, 62);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 34);
            this.textBox3.TabIndex = 17;
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(476, 62);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 34);
            this.textBox4.TabIndex = 18;
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(582, 62);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 34);
            this.textBox5.TabIndex = 19;
            this.textBox5.Click += new System.EventHandler(this.textBox5_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(688, 62);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 34);
            this.textBox6.TabIndex = 20;
            this.textBox6.Click += new System.EventHandler(this.textBox6_Click);
            // 
            // btnPreviousProcess
            // 
            this.btnPreviousProcess.Location = new System.Drawing.Point(158, 323);
            this.btnPreviousProcess.Name = "btnPreviousProcess";
            this.btnPreviousProcess.Size = new System.Drawing.Size(135, 23);
            this.btnPreviousProcess.TabIndex = 21;
            this.btnPreviousProcess.Text = "PROCESO ANTERIOR";
            this.btnPreviousProcess.UseVisualStyleBackColor = true;
            this.btnPreviousProcess.Click += new System.EventHandler(this.btnPreviousProcess_Click);
            // 
            // btnNextProcess
            // 
            this.btnNextProcess.Location = new System.Drawing.Point(654, 323);
            this.btnNextProcess.Name = "btnNextProcess";
            this.btnNextProcess.Size = new System.Drawing.Size(134, 23);
            this.btnNextProcess.TabIndex = 22;
            this.btnNextProcess.Text = "SIGUIENTE PROCESO";
            this.btnNextProcess.UseVisualStyleBackColor = true;
            this.btnNextProcess.Click += new System.EventHandler(this.btnNextProcess_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(159, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 204);
            this.dataGridView1.TabIndex = 23;
            // 
            // currentProcess
            // 
            this.currentProcess.Location = new System.Drawing.Point(158, 14);
            this.currentProcess.Name = "currentProcess";
            this.currentProcess.ReadOnly = true;
            this.currentProcess.Size = new System.Drawing.Size(100, 20);
            this.currentProcess.TabIndex = 25;
            // 
            // btnAddProcess
            // 
            this.btnAddProcess.Location = new System.Drawing.Point(13, 71);
            this.btnAddProcess.Name = "btnAddProcess";
            this.btnAddProcess.Size = new System.Drawing.Size(111, 23);
            this.btnAddProcess.TabIndex = 26;
            this.btnAddProcess.Text = "Agregar Proceso";
            this.btnAddProcess.UseVisualStyleBackColor = true;
            this.btnAddProcess.Click += new System.EventHandler(this.btnAddProcess_Click);
            // 
            // btnAddStatus
            // 
            this.btnAddStatus.Location = new System.Drawing.Point(411, 324);
            this.btnAddStatus.Name = "btnAddStatus";
            this.btnAddStatus.Size = new System.Drawing.Size(100, 23);
            this.btnAddStatus.TabIndex = 27;
            this.btnAddStatus.Text = "Agregar Estado";
            this.btnAddStatus.UseVisualStyleBackColor = true;
            this.btnAddStatus.Click += new System.EventHandler(this.btnAddStatus_Click);
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.Location = new System.Drawing.Point(13, 132);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(111, 23);
            this.btnSaveInfo.TabIndex = 28;
            this.btnSaveInfo.Text = "Guardar Informacion";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(264, 14);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(160, 20);
            this.textBox8.TabIndex = 29;
            // 
            // btnDelCurrentProcess
            // 
            this.btnDelCurrentProcess.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelCurrentProcess.Location = new System.Drawing.Point(12, 220);
            this.btnDelCurrentProcess.Name = "btnDelCurrentProcess";
            this.btnDelCurrentProcess.Size = new System.Drawing.Size(124, 23);
            this.btnDelCurrentProcess.TabIndex = 30;
            this.btnDelCurrentProcess.Text = "ELIMINAR PROCESO";
            this.btnDelCurrentProcess.UseVisualStyleBackColor = false;
            this.btnDelCurrentProcess.Click += new System.EventHandler(this.btnDelCurrentProcess_Click);
            // 
            // beforeStateCount
            // 
            this.beforeStateCount.Location = new System.Drawing.Point(565, 15);
            this.beforeStateCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.beforeStateCount.Name = "beforeStateCount";
            this.beforeStateCount.Size = new System.Drawing.Size(45, 20);
            this.beforeStateCount.TabIndex = 31;
            this.beforeStateCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.beforeStateCount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "N° de Estados Anteriores: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.beforeStateCount);
            this.Controls.Add(this.btnDelCurrentProcess);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.btnSaveInfo);
            this.Controls.Add(this.btnAddStatus);
            this.Controls.Add(this.btnAddProcess);
            this.Controls.Add(this.currentProcess);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNextProcess);
            this.Controls.Add(this.btnPreviousProcess);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.btnSaveState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Actualizar Procesos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeStateCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveState;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnPreviousProcess;
        private System.Windows.Forms.Button btnNextProcess;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox currentProcess;
        private System.Windows.Forms.Button btnAddProcess;
        private System.Windows.Forms.Button btnAddStatus;
        private System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnDelCurrentProcess;
        private System.Windows.Forms.NumericUpDown beforeStateCount;
        private System.Windows.Forms.Label label7;
    }
}

