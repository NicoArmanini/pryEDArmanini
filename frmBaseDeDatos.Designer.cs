namespace pryEDArmanini
{
    partial class frmBaseDeDatos
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
            this.mecAlg = new System.Windows.Forms.GroupBox();
            this.btnInter = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.mecWhere = new System.Windows.Forms.GroupBox();
            this.btnSelecConv = new System.Windows.Forms.Button();
            this.btnSelecMulti = new System.Windows.Forms.Button();
            this.btnSelecSimple = new System.Windows.Forms.Button();
            this.mrcSelect = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnSimple = new System.Windows.Forms.Button();
            this.dgvBD = new System.Windows.Forms.DataGridView();
            this.mecAlg.SuspendLayout();
            this.mecWhere.SuspendLayout();
            this.mrcSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).BeginInit();
            this.SuspendLayout();
            // 
            // mecAlg
            // 
            this.mecAlg.Controls.Add(this.btnInter);
            this.mecAlg.Controls.Add(this.btnDiferencia);
            this.mecAlg.Controls.Add(this.btnUnion);
            this.mecAlg.Location = new System.Drawing.Point(711, 389);
            this.mecAlg.Margin = new System.Windows.Forms.Padding(4);
            this.mecAlg.Name = "mecAlg";
            this.mecAlg.Padding = new System.Windows.Forms.Padding(4);
            this.mecAlg.Size = new System.Drawing.Size(339, 219);
            this.mecAlg.TabIndex = 7;
            this.mecAlg.TabStop = false;
            this.mecAlg.Text = "Operaciones Algebraicas";
            // 
            // btnInter
            // 
            this.btnInter.Location = new System.Drawing.Point(8, 101);
            this.btnInter.Margin = new System.Windows.Forms.Padding(4);
            this.btnInter.Name = "btnInter";
            this.btnInter.Size = new System.Drawing.Size(309, 42);
            this.btnInter.TabIndex = 7;
            this.btnInter.Text = "Intersección";
            this.btnInter.UseVisualStyleBackColor = true;
            this.btnInter.Click += new System.EventHandler(this.btnInter_Click);
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(8, 165);
            this.btnDiferencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(309, 42);
            this.btnDiferencia.TabIndex = 3;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(8, 39);
            this.btnUnion.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(309, 42);
            this.btnUnion.TabIndex = 8;
            this.btnUnion.Text = "Union";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // mecWhere
            // 
            this.mecWhere.Controls.Add(this.btnSelecConv);
            this.mecWhere.Controls.Add(this.btnSelecMulti);
            this.mecWhere.Controls.Add(this.btnSelecSimple);
            this.mecWhere.Location = new System.Drawing.Point(363, 389);
            this.mecWhere.Margin = new System.Windows.Forms.Padding(4);
            this.mecWhere.Name = "mecWhere";
            this.mecWhere.Padding = new System.Windows.Forms.Padding(4);
            this.mecWhere.Size = new System.Drawing.Size(339, 219);
            this.mecWhere.TabIndex = 6;
            this.mecWhere.TabStop = false;
            this.mecWhere.Text = "Operaciones de Selección - WHERE";
            // 
            // btnSelecConv
            // 
            this.btnSelecConv.Location = new System.Drawing.Point(8, 165);
            this.btnSelecConv.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecConv.Name = "btnSelecConv";
            this.btnSelecConv.Size = new System.Drawing.Size(309, 42);
            this.btnSelecConv.TabIndex = 6;
            this.btnSelecConv.Text = "Seleccion por convolucion";
            this.btnSelecConv.UseVisualStyleBackColor = true;
            this.btnSelecConv.Click += new System.EventHandler(this.btnSelecConv_Click);
            // 
            // btnSelecMulti
            // 
            this.btnSelecMulti.Location = new System.Drawing.Point(8, 101);
            this.btnSelecMulti.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecMulti.Name = "btnSelecMulti";
            this.btnSelecMulti.Size = new System.Drawing.Size(309, 42);
            this.btnSelecMulti.TabIndex = 4;
            this.btnSelecMulti.Text = "Seleccion multiatributo";
            this.btnSelecMulti.UseVisualStyleBackColor = true;
            this.btnSelecMulti.Click += new System.EventHandler(this.btnSelecMulti_Click);
            // 
            // btnSelecSimple
            // 
            this.btnSelecSimple.Location = new System.Drawing.Point(8, 39);
            this.btnSelecSimple.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelecSimple.Name = "btnSelecSimple";
            this.btnSelecSimple.Size = new System.Drawing.Size(309, 42);
            this.btnSelecSimple.TabIndex = 5;
            this.btnSelecSimple.Text = "Seleccion Simple";
            this.btnSelecSimple.UseVisualStyleBackColor = true;
            this.btnSelecSimple.Click += new System.EventHandler(this.btnSelecSimple_Click);
            // 
            // mrcSelect
            // 
            this.mrcSelect.Controls.Add(this.btnJuntar);
            this.mrcSelect.Controls.Add(this.btnMulti);
            this.mrcSelect.Controls.Add(this.btnSimple);
            this.mrcSelect.Location = new System.Drawing.Point(16, 389);
            this.mrcSelect.Margin = new System.Windows.Forms.Padding(4);
            this.mrcSelect.Name = "mrcSelect";
            this.mrcSelect.Padding = new System.Windows.Forms.Padding(4);
            this.mrcSelect.Size = new System.Drawing.Size(339, 219);
            this.mrcSelect.TabIndex = 5;
            this.mrcSelect.TabStop = false;
            this.mrcSelect.Text = "Operaciones de Proyectos - SELECT";
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(21, 165);
            this.btnJuntar.Margin = new System.Windows.Forms.Padding(4);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(309, 42);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(21, 101);
            this.btnMulti.Margin = new System.Windows.Forms.Padding(4);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(309, 42);
            this.btnMulti.TabIndex = 1;
            this.btnMulti.Text = "Proyeccion multiatributo";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnSimple
            // 
            this.btnSimple.Location = new System.Drawing.Point(21, 39);
            this.btnSimple.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimple.Name = "btnSimple";
            this.btnSimple.Size = new System.Drawing.Size(309, 42);
            this.btnSimple.TabIndex = 0;
            this.btnSimple.Text = "Proyeccion Simple";
            this.btnSimple.UseVisualStyleBackColor = true;
            this.btnSimple.Click += new System.EventHandler(this.btnSimple_Click);
            // 
            // dgvBD
            // 
            this.dgvBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBD.Location = new System.Drawing.Point(17, 15);
            this.dgvBD.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBD.Name = "dgvBD";
            this.dgvBD.RowHeadersWidth = 51;
            this.dgvBD.Size = new System.Drawing.Size(1033, 366);
            this.dgvBD.TabIndex = 4;
            // 
            // frmBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 623);
            this.Controls.Add(this.mecAlg);
            this.Controls.Add(this.mecWhere);
            this.Controls.Add(this.mrcSelect);
            this.Controls.Add(this.dgvBD);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBaseDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaseDeDatos";
            this.mecAlg.ResumeLayout(false);
            this.mecWhere.ResumeLayout(false);
            this.mrcSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mecAlg;
        private System.Windows.Forms.Button btnInter;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.GroupBox mecWhere;
        private System.Windows.Forms.Button btnSelecConv;
        private System.Windows.Forms.Button btnSelecMulti;
        private System.Windows.Forms.Button btnSelecSimple;
        private System.Windows.Forms.GroupBox mrcSelect;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnSimple;
        private System.Windows.Forms.DataGridView dgvBD;
    }
}