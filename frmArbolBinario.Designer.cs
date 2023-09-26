namespace pryEDArmanini
{
    partial class frmArbolBinario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArbolBinario));
            this.mrcListados = new System.Windows.Forms.GroupBox();
            this.optPostOrden = new System.Windows.Forms.RadioButton();
            this.optPreOrden = new System.Windows.Forms.RadioButton();
            this.optInOrden = new System.Windows.Forms.RadioButton();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcEliminado = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.mrcNuevo = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.trvCuadro = new System.Windows.Forms.TreeView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.mrcListados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.mrcEliminado.SuspendLayout();
            this.mrcNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcListados
            // 
            this.mrcListados.BackColor = System.Drawing.Color.Transparent;
            this.mrcListados.Controls.Add(this.btnExportar);
            this.mrcListados.Controls.Add(this.optPostOrden);
            this.mrcListados.Controls.Add(this.optPreOrden);
            this.mrcListados.Controls.Add(this.optInOrden);
            this.mrcListados.Controls.Add(this.dgvTabla);
            this.mrcListados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mrcListados.Location = new System.Drawing.Point(16, 240);
            this.mrcListados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcListados.Name = "mrcListados";
            this.mrcListados.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcListados.Size = new System.Drawing.Size(883, 267);
            this.mrcListados.TabIndex = 19;
            this.mrcListados.TabStop = false;
            this.mrcListados.Text = "Listado en una Lista y una Grilla";
            // 
            // optPostOrden
            // 
            this.optPostOrden.AutoSize = true;
            this.optPostOrden.Location = new System.Drawing.Point(41, 130);
            this.optPostOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optPostOrden.Name = "optPostOrden";
            this.optPostOrden.Size = new System.Drawing.Size(96, 20);
            this.optPostOrden.TabIndex = 4;
            this.optPostOrden.Text = "Post-Orden";
            this.optPostOrden.UseVisualStyleBackColor = true;
            this.optPostOrden.CheckedChanged += new System.EventHandler(this.optPostOrden_CheckedChanged);
            // 
            // optPreOrden
            // 
            this.optPreOrden.AutoSize = true;
            this.optPreOrden.Location = new System.Drawing.Point(41, 82);
            this.optPreOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optPreOrden.Name = "optPreOrden";
            this.optPreOrden.Size = new System.Drawing.Size(90, 20);
            this.optPreOrden.TabIndex = 3;
            this.optPreOrden.Text = "Pre-Orden";
            this.optPreOrden.UseVisualStyleBackColor = true;
            this.optPreOrden.CheckedChanged += new System.EventHandler(this.optPreOrden_CheckedChanged);
            // 
            // optInOrden
            // 
            this.optInOrden.AutoSize = true;
            this.optInOrden.Checked = true;
            this.optInOrden.Location = new System.Drawing.Point(41, 34);
            this.optInOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.optInOrden.Name = "optInOrden";
            this.optInOrden.Size = new System.Drawing.Size(79, 20);
            this.optInOrden.TabIndex = 2;
            this.optInOrden.TabStop = true;
            this.optInOrden.Text = "In-Orden";
            this.optInOrden.UseVisualStyleBackColor = true;
            this.optInOrden.CheckedChanged += new System.EventHandler(this.optInOrden_CheckedChanged);
            // 
            // dgvTabla
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabla.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTabla.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvTabla.Location = new System.Drawing.Point(304, 22);
            this.dgvTabla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTabla.Name = "dgvTabla";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTabla.RowHeadersWidth = 51;
            this.dgvTabla.Size = new System.Drawing.Size(571, 214);
            this.dgvTabla.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.MinimumWidth = 6;
            this.Tramite.Name = "Tramite";
            this.Tramite.Width = 125;
            // 
            // mrcEliminado
            // 
            this.mrcEliminado.BackColor = System.Drawing.Color.Transparent;
            this.mrcEliminado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mrcEliminado.Controls.Add(this.cmbCodigo);
            this.mrcEliminado.Controls.Add(this.btnEliminar);
            this.mrcEliminado.Controls.Add(this.lblCodigo1);
            this.mrcEliminado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mrcEliminado.Location = new System.Drawing.Point(636, 15);
            this.mrcEliminado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcEliminado.Name = "mrcEliminado";
            this.mrcEliminado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcEliminado.Size = new System.Drawing.Size(263, 126);
            this.mrcEliminado.TabIndex = 17;
            this.mrcEliminado.TabStop = false;
            this.mrcEliminado.Text = "Elemento Elminado";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(83, 33);
            this.cmbCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(140, 24);
            this.cmbCodigo.TabIndex = 4;
            this.cmbCodigo.SelectedIndexChanged += new System.EventHandler(this.cmbCodigo_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(8, 69);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(243, 43);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Location = new System.Drawing.Point(15, 42);
            this.lblCodigo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo1.TabIndex = 0;
            this.lblCodigo1.Text = "Codigo:";
            // 
            // mrcNuevo
            // 
            this.mrcNuevo.BackColor = System.Drawing.Color.Transparent;
            this.mrcNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mrcNuevo.Controls.Add(this.txtTramite);
            this.mrcNuevo.Controls.Add(this.txtNombre);
            this.mrcNuevo.Controls.Add(this.txtCodigo);
            this.mrcNuevo.Controls.Add(this.btnAgregar);
            this.mrcNuevo.Controls.Add(this.lblTramite);
            this.mrcNuevo.Controls.Add(this.lblNombre);
            this.mrcNuevo.Controls.Add(this.lblCodigo);
            this.mrcNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mrcNuevo.Location = new System.Drawing.Point(337, 15);
            this.mrcNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcNuevo.Name = "mrcNuevo";
            this.mrcNuevo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcNuevo.Size = new System.Drawing.Size(264, 215);
            this.mrcNuevo.TabIndex = 18;
            this.mrcNuevo.TabStop = false;
            this.mrcNuevo.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Enabled = false;
            this.txtTramite.Location = new System.Drawing.Point(97, 123);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(145, 22);
            this.txtTramite.TabIndex = 6;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(97, 82);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 22);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(97, 39);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(145, 22);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(13, 160);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(243, 43);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(28, 127);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(56, 16);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 82);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(24, 43);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(636, 169);
            this.btnEquilibrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(263, 49);
            this.btnEquilibrar.TabIndex = 20;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // trvCuadro
            // 
            this.trvCuadro.Location = new System.Drawing.Point(16, 15);
            this.trvCuadro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trvCuadro.Name = "trvCuadro";
            this.trvCuadro.Size = new System.Drawing.Size(303, 214);
            this.trvCuadro.TabIndex = 21;
            // 
            // btnExportar
            // 
            this.btnExportar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExportar.Location = new System.Drawing.Point(18, 183);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(231, 52);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryEDArmanini.Properties.Resources.fin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 522);
            this.Controls.Add(this.trvCuadro);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.mrcListados);
            this.Controls.Add(this.mrcEliminado);
            this.Controls.Add(this.mrcNuevo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbol Binario";
            this.mrcListados.ResumeLayout(false);
            this.mrcListados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.mrcEliminado.ResumeLayout(false);
            this.mrcEliminado.PerformLayout();
            this.mrcNuevo.ResumeLayout(false);
            this.mrcNuevo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcListados;
        private System.Windows.Forms.RadioButton optPostOrden;
        private System.Windows.Forms.RadioButton optPreOrden;
        private System.Windows.Forms.RadioButton optInOrden;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.GroupBox mrcEliminado;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.GroupBox mrcNuevo;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.TreeView trvCuadro;
        private System.Windows.Forms.Button btnExportar;
    }
}