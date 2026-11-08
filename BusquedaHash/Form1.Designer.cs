namespace BusquedaHash
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabExperimento = new System.Windows.Forms.TabPage();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.lblEstado = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.grpParametros = new System.Windows.Forms.GroupBox();
            this.nudFactor = new System.Windows.Forms.NumericUpDown();
            this.lblFactor = new System.Windows.Forms.Label();
            this.cmbFuncion = new System.Windows.Forms.ComboBox();
            this.lblFuncion = new System.Windows.Forms.Label();
            this.nudSemilla = new System.Windows.Forms.NumericUpDown();
            this.lblSemilla = new System.Windows.Forms.Label();
            this.nudExito = new System.Windows.Forms.NumericUpDown();
            this.lblExito = new System.Windows.Forms.Label();
            this.nudBusquedas = new System.Windows.Forms.NumericUpDown();
            this.lblBusquedas = new System.Windows.Forms.Label();
            this.txtTamanos = new System.Windows.Forms.TextBox();
            this.lblTamanos = new System.Windows.Forms.Label();
            this.tabIndividual = new System.Windows.Forms.TabPage();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscarInd = new System.Windows.Forms.Button();
            this.nudClave = new System.Windows.Forms.NumericUpDown();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.grpGenerar = new System.Windows.Forms.GroupBox();
            this.lblNotaInd = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.nudNInd = new System.Windows.Forms.NumericUpDown();
            this.lblNInd = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabExperimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.grpParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSemilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBusquedas)).BeginInit();
            this.tabIndividual.SuspendLayout();
            this.grpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClave)).BeginInit();
            this.grpGenerar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNInd)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabExperimento);
            this.tabControl1.Controls.Add(this.tabIndividual);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1060, 660);
            this.tabControl1.TabIndex = 0;
            // 
            // tabExperimento
            // 
            this.tabExperimento.Controls.Add(this.dgvResultados);
            this.tabExperimento.Controls.Add(this.lblEstado);
            this.tabExperimento.Controls.Add(this.progressBar);
            this.tabExperimento.Controls.Add(this.btnLimpiar);
            this.tabExperimento.Controls.Add(this.btnExportar);
            this.tabExperimento.Controls.Add(this.btnEjecutar);
            this.tabExperimento.Controls.Add(this.grpParametros);
            this.tabExperimento.Location = new System.Drawing.Point(4, 22);
            this.tabExperimento.Name = "tabExperimento";
            this.tabExperimento.Padding = new System.Windows.Forms.Padding(8);
            this.tabExperimento.Size = new System.Drawing.Size(1052, 634);
            this.tabExperimento.TabIndex = 0;
            this.tabExperimento.Text = "Experimento";
            this.tabExperimento.UseVisualStyleBackColor = true;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultados.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResultados.Location = new System.Drawing.Point(8, 168);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersVisible = false;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultados.Size = new System.Drawing.Size(1036, 458);
            this.dgvResultados.TabIndex = 6;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(800, 136);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(90, 13);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Listo para ejecutar.";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(480, 131);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(300, 22);
            this.progressBar.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(348, 125);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 34);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar tabla";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(188, 125);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(150, 34);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Exportar a CSV";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(8, 125);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(170, 34);
            this.btnEjecutar.TabIndex = 1;
            this.btnEjecutar.Text = "Ejecutar experimento";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // grpParametros
            // 
            this.grpParametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpParametros.Controls.Add(this.nudFactor);
            this.grpParametros.Controls.Add(this.lblFactor);
            this.grpParametros.Controls.Add(this.cmbFuncion);
            this.grpParametros.Controls.Add(this.lblFuncion);
            this.grpParametros.Controls.Add(this.nudSemilla);
            this.grpParametros.Controls.Add(this.lblSemilla);
            this.grpParametros.Controls.Add(this.nudExito);
            this.grpParametros.Controls.Add(this.lblExito);
            this.grpParametros.Controls.Add(this.nudBusquedas);
            this.grpParametros.Controls.Add(this.lblBusquedas);
            this.grpParametros.Controls.Add(this.txtTamanos);
            this.grpParametros.Controls.Add(this.lblTamanos);
            this.grpParametros.Location = new System.Drawing.Point(8, 8);
            this.grpParametros.Name = "grpParametros";
            this.grpParametros.Size = new System.Drawing.Size(1036, 105);
            this.grpParametros.TabIndex = 0;
            this.grpParametros.TabStop = false;
            this.grpParametros.Text = "Parámetros del experimento";
            // 
            // nudFactor
            // 
            this.nudFactor.DecimalPlaces = 1;
            this.nudFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudFactor.Location = new System.Drawing.Point(905, 63);
            this.nudFactor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFactor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudFactor.Name = "nudFactor";
            this.nudFactor.Size = new System.Drawing.Size(70, 20);
            this.nudFactor.TabIndex = 11;
            this.nudFactor.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // lblFactor
            // 
            this.lblFactor.AutoSize = true;
            this.lblFactor.Location = new System.Drawing.Point(790, 67);
            this.lblFactor.Name = "lblFactor";
            this.lblFactor.Size = new System.Drawing.Size(105, 13);
            this.lblFactor.TabIndex = 10;
            this.lblFactor.Text = "Factor de carga (α):";
            // 
            // cmbFuncion
            // 
            this.cmbFuncion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncion.FormattingEnabled = true;
            this.cmbFuncion.Items.AddRange(new object[] {
            "División: h(k) = k mod M",
            "Multiplicación (Knuth)"});
            this.cmbFuncion.Location = new System.Drawing.Point(535, 63);
            this.cmbFuncion.Name = "cmbFuncion";
            this.cmbFuncion.Size = new System.Drawing.Size(230, 21);
            this.cmbFuncion.TabIndex = 9;
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(450, 67);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(79, 13);
            this.lblFuncion.TabIndex = 8;
            this.lblFuncion.Text = "Función hash:";
            // 
            // nudSemilla
            // 
            this.nudSemilla.Location = new System.Drawing.Point(315, 63);
            this.nudSemilla.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudSemilla.Name = "nudSemilla";
            this.nudSemilla.Size = new System.Drawing.Size(110, 20);
            this.nudSemilla.TabIndex = 7;
            this.nudSemilla.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // lblSemilla
            // 
            this.lblSemilla.AutoSize = true;
            this.lblSemilla.Location = new System.Drawing.Point(260, 67);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(47, 13);
            this.lblSemilla.TabIndex = 6;
            this.lblSemilla.Text = "Semilla:";
            // 
            // nudExito
            // 
            this.nudExito.Location = new System.Drawing.Point(160, 63);
            this.nudExito.Name = "nudExito";
            this.nudExito.Size = new System.Drawing.Size(70, 20);
            this.nudExito.TabIndex = 5;
            this.nudExito.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblExito
            // 
            this.lblExito.AutoSize = true;
            this.lblExito.Location = new System.Drawing.Point(12, 67);
            this.lblExito.Name = "lblExito";
            this.lblExito.Size = new System.Drawing.Size(137, 13);
            this.lblExito.TabIndex = 4;
            this.lblExito.Text = "% de búsquedas exitosas:";
            // 
            // nudBusquedas
            // 
            this.nudBusquedas.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudBusquedas.Location = new System.Drawing.Point(790, 27);
            this.nudBusquedas.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudBusquedas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBusquedas.Name = "nudBusquedas";
            this.nudBusquedas.Size = new System.Drawing.Size(90, 20);
            this.nudBusquedas.TabIndex = 3;
            this.nudBusquedas.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblBusquedas
            // 
            this.lblBusquedas.AutoSize = true;
            this.lblBusquedas.Location = new System.Drawing.Point(650, 30);
            this.lblBusquedas.Name = "lblBusquedas";
            this.lblBusquedas.Size = new System.Drawing.Size(127, 13);
            this.lblBusquedas.TabIndex = 2;
            this.lblBusquedas.Text = "Búsquedas por tamaño:";
            // 
            // txtTamanos
            // 
            this.txtTamanos.Location = new System.Drawing.Point(210, 27);
            this.txtTamanos.Name = "txtTamanos";
            this.txtTamanos.Size = new System.Drawing.Size(420, 20);
            this.txtTamanos.TabIndex = 1;
            this.txtTamanos.Text = "1000, 5000, 10000, 50000, 100000, 500000";
            // 
            // lblTamanos
            // 
            this.lblTamanos.AutoSize = true;
            this.lblTamanos.Location = new System.Drawing.Point(12, 30);
            this.lblTamanos.Name = "lblTamanos";
            this.lblTamanos.Size = new System.Drawing.Size(188, 13);
            this.lblTamanos.TabIndex = 0;
            this.lblTamanos.Text = "Tamaños N (separados por coma):";
            // 
            // tabIndividual
            // 
            this.tabIndividual.Controls.Add(this.txtSalida);
            this.tabIndividual.Controls.Add(this.grpBuscar);
            this.tabIndividual.Controls.Add(this.txtDatos);
            this.tabIndividual.Controls.Add(this.grpGenerar);
            this.tabIndividual.Location = new System.Drawing.Point(4, 22);
            this.tabIndividual.Name = "tabIndividual";
            this.tabIndividual.Padding = new System.Windows.Forms.Padding(8);
            this.tabIndividual.Size = new System.Drawing.Size(1052, 634);
            this.tabIndividual.TabIndex = 1;
            this.tabIndividual.Text = "Búsqueda individual";
            this.tabIndividual.UseVisualStyleBackColor = true;
            // 
            // txtSalida
            // 
            this.txtSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalida.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.Location = new System.Drawing.Point(8, 448);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ReadOnly = true;
            this.txtSalida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSalida.Size = new System.Drawing.Size(1036, 178);
            this.txtSalida.TabIndex = 3;
            this.txtSalida.WordWrap = false;
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.btnBuscarInd);
            this.grpBuscar.Controls.Add(this.nudClave);
            this.grpBuscar.Controls.Add(this.lblClave);
            this.grpBuscar.Location = new System.Drawing.Point(8, 370);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(1036, 68);
            this.grpBuscar.TabIndex = 2;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar una clave con las tres técnicas";
            // 
            // btnBuscarInd
            // 
            this.btnBuscarInd.Location = new System.Drawing.Point(260, 24);
            this.btnBuscarInd.Name = "btnBuscarInd";
            this.btnBuscarInd.Size = new System.Drawing.Size(200, 30);
            this.btnBuscarInd.TabIndex = 2;
            this.btnBuscarInd.Text = "Buscar con los 3 métodos";
            this.btnBuscarInd.UseVisualStyleBackColor = true;
            this.btnBuscarInd.Click += new System.EventHandler(this.btnBuscarInd_Click);
            // 
            // nudClave
            // 
            this.nudClave.Location = new System.Drawing.Point(110, 29);
            this.nudClave.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.nudClave.Name = "nudClave";
            this.nudClave.Size = new System.Drawing.Size(130, 20);
            this.nudClave.TabIndex = 1;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(12, 32);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(86, 13);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave a buscar:";
            // 
            // txtDatos
            // 
            this.txtDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatos.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatos.Location = new System.Drawing.Point(8, 88);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.ReadOnly = true;
            this.txtDatos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDatos.Size = new System.Drawing.Size(1036, 270);
            this.txtDatos.TabIndex = 1;
            this.txtDatos.WordWrap = false;
            // 
            // grpGenerar
            // 
            this.grpGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGenerar.Controls.Add(this.lblNotaInd);
            this.grpGenerar.Controls.Add(this.btnGenerar);
            this.grpGenerar.Controls.Add(this.nudNInd);
            this.grpGenerar.Controls.Add(this.lblNInd);
            this.grpGenerar.Location = new System.Drawing.Point(8, 8);
            this.grpGenerar.Name = "grpGenerar";
            this.grpGenerar.Size = new System.Drawing.Size(1036, 68);
            this.grpGenerar.TabIndex = 0;
            this.grpGenerar.TabStop = false;
            this.grpGenerar.Text = "Datos de ejemplo";
            // 
            // lblNotaInd
            // 
            this.lblNotaInd.AutoSize = true;
            this.lblNotaInd.Location = new System.Drawing.Point(480, 32);
            this.lblNotaInd.Name = "lblNotaInd";
            this.lblNotaInd.Size = new System.Drawing.Size(368, 13);
            this.lblNotaInd.TabIndex = 3;
            this.lblNotaInd.Text = "Usa la semilla, la función hash y el factor de carga de la pestaña Experimento.";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(240, 24);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(220, 30);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar datos y estructuras";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // nudNInd
            // 
            this.nudNInd.Location = new System.Drawing.Point(150, 29);
            this.nudNInd.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNInd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNInd.Name = "nudNInd";
            this.nudNInd.Size = new System.Drawing.Size(70, 20);
            this.nudNInd.TabIndex = 1;
            this.nudNInd.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblNInd
            // 
            this.lblNInd.AutoSize = true;
            this.lblNInd.Location = new System.Drawing.Point(12, 32);
            this.lblNInd.Name = "lblNInd";
            this.lblNInd.Size = new System.Drawing.Size(128, 13);
            this.lblNInd.TabIndex = 0;
            this.lblNInd.Text = "Cantidad de datos (N):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 660);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda secuencial, binaria y tabla Hash - Experimento de eficiencia";
            this.tabControl1.ResumeLayout(false);
            this.tabExperimento.ResumeLayout(false);
            this.tabExperimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.grpParametros.ResumeLayout(false);
            this.grpParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSemilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBusquedas)).EndInit();
            this.tabIndividual.ResumeLayout(false);
            this.tabIndividual.PerformLayout();
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClave)).EndInit();
            this.grpGenerar.ResumeLayout(false);
            this.grpGenerar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNInd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabExperimento;
        private System.Windows.Forms.TabPage tabIndividual;
        private System.Windows.Forms.GroupBox grpParametros;
        private System.Windows.Forms.Label lblTamanos;
        private System.Windows.Forms.TextBox txtTamanos;
        private System.Windows.Forms.Label lblBusquedas;
        private System.Windows.Forms.NumericUpDown nudBusquedas;
        private System.Windows.Forms.Label lblExito;
        private System.Windows.Forms.NumericUpDown nudExito;
        private System.Windows.Forms.Label lblSemilla;
        private System.Windows.Forms.NumericUpDown nudSemilla;
        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.ComboBox cmbFuncion;
        private System.Windows.Forms.Label lblFactor;
        private System.Windows.Forms.NumericUpDown nudFactor;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.GroupBox grpGenerar;
        private System.Windows.Forms.Label lblNInd;
        private System.Windows.Forms.NumericUpDown nudNInd;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblNotaInd;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.NumericUpDown nudClave;
        private System.Windows.Forms.Button btnBuscarInd;
        private System.Windows.Forms.TextBox txtSalida;
    }
}
