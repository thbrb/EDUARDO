﻿namespace SisClinica.Forms
{
    partial class userControlPesquisarSessoes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtbxNomePesquisa = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.cbData = new System.Windows.Forms.CheckBox();
            this.cbTratamentos = new System.Windows.Forms.CheckBox();
            this.cbConsultas = new System.Windows.Forms.CheckBox();
            this.cbMedico = new System.Windows.Forms.CheckBox();
            this.cbCliente = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnFullInfo = new System.Windows.Forms.Button();
            this.dtgSessoes = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbDados.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSessoes)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gbDados, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.18826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(672, 186);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.label1);
            this.gbDados.Controls.Add(this.dtpData);
            this.gbDados.Controls.Add(this.btnPesquisar);
            this.gbDados.Controls.Add(this.txtbxNomePesquisa);
            this.gbDados.Controls.Add(this.lblNome);
            this.gbDados.Controls.Add(this.gbFiltro);
            this.gbDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDados.Location = new System.Drawing.Point(3, 3);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(666, 179);
            this.gbDados.TabIndex = 1;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados da pesquisa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(97, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Data:";
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Location = new System.Drawing.Point(155, 145);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 27);
            this.dtpData.TabIndex = 15;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Enabled = false;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = global::SisClinica.Properties.Resources.btnPesquisarResp1;
            this.btnPesquisar.Location = new System.Drawing.Point(497, 118);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(72, 54);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtbxNomePesquisa
            // 
            this.txtbxNomePesquisa.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNomePesquisa.Location = new System.Drawing.Point(155, 116);
            this.txtbxNomePesquisa.Name = "txtbxNomePesquisa";
            this.txtbxNomePesquisa.Size = new System.Drawing.Size(336, 23);
            this.txtbxNomePesquisa.TabIndex = 13;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(97, 118);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 21);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome:";
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.cbData);
            this.gbFiltro.Controls.Add(this.cbTratamentos);
            this.gbFiltro.Controls.Add(this.cbConsultas);
            this.gbFiltro.Controls.Add(this.cbMedico);
            this.gbFiltro.Controls.Add(this.cbCliente);
            this.gbFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFiltro.Location = new System.Drawing.Point(3, 23);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(660, 84);
            this.gbFiltro.TabIndex = 0;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtros:";
            // 
            // cbData
            // 
            this.cbData.AutoSize = true;
            this.cbData.Location = new System.Drawing.Point(570, 38);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(70, 25);
            this.cbData.TabIndex = 11;
            this.cbData.Text = "Data";
            this.cbData.UseVisualStyleBackColor = true;
            this.cbData.CheckedChanged += new System.EventHandler(this.cbData_CheckedChanged);
            // 
            // cbTratamentos
            // 
            this.cbTratamentos.AutoSize = true;
            this.cbTratamentos.Location = new System.Drawing.Point(266, 51);
            this.cbTratamentos.Name = "cbTratamentos";
            this.cbTratamentos.Size = new System.Drawing.Size(129, 25);
            this.cbTratamentos.TabIndex = 10;
            this.cbTratamentos.Text = "Tratamentos";
            this.cbTratamentos.UseVisualStyleBackColor = true;
            this.cbTratamentos.CheckedChanged += new System.EventHandler(this.cbTratamentos_CheckedChanged);
            // 
            // cbConsultas
            // 
            this.cbConsultas.AutoSize = true;
            this.cbConsultas.Location = new System.Drawing.Point(266, 24);
            this.cbConsultas.Name = "cbConsultas";
            this.cbConsultas.Size = new System.Drawing.Size(105, 25);
            this.cbConsultas.TabIndex = 9;
            this.cbConsultas.Text = "Consultas";
            this.cbConsultas.UseVisualStyleBackColor = true;
            this.cbConsultas.CheckedChanged += new System.EventHandler(this.cbConsultas_CheckedChanged);
            // 
            // cbMedico
            // 
            this.cbMedico.AutoSize = true;
            this.cbMedico.Location = new System.Drawing.Point(31, 51);
            this.cbMedico.Name = "cbMedico";
            this.cbMedico.Size = new System.Drawing.Size(94, 25);
            this.cbMedico.TabIndex = 8;
            this.cbMedico.Text = "Médicos";
            this.cbMedico.UseVisualStyleBackColor = true;
            this.cbMedico.CheckedChanged += new System.EventHandler(this.cbMedico_CheckedChanged);
            // 
            // cbCliente
            // 
            this.cbCliente.AutoSize = true;
            this.cbCliente.Location = new System.Drawing.Point(31, 24);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(91, 25);
            this.cbCliente.TabIndex = 7;
            this.cbCliente.Text = "Clientes";
            this.cbCliente.UseVisualStyleBackColor = true;
            this.cbCliente.CheckedChanged += new System.EventHandler(this.cbCliente_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAlter);
            this.panel1.Controls.Add(this.btnFullInfo);
            this.panel1.Controls.Add(this.dtgSessoes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 223);
            this.panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::SisClinica.Properties.Resources.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(463, 113);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 107);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAlter
            // 
            this.btnAlter.Enabled = false;
            this.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlter.Image = global::SisClinica.Properties.Resources.btnPencil;
            this.btnAlter.Location = new System.Drawing.Point(81, 113);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(140, 107);
            this.btnAlter.TabIndex = 6;
            this.btnAlter.UseVisualStyleBackColor = true;
            // 
            // btnFullInfo
            // 
            this.btnFullInfo.Enabled = false;
            this.btnFullInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullInfo.Image = global::SisClinica.Properties.Resources.btnFullInfo;
            this.btnFullInfo.Location = new System.Drawing.Point(272, 113);
            this.btnFullInfo.Name = "btnFullInfo";
            this.btnFullInfo.Size = new System.Drawing.Size(140, 107);
            this.btnFullInfo.TabIndex = 5;
            this.btnFullInfo.UseVisualStyleBackColor = true;
            // 
            // dtgSessoes
            // 
            this.dtgSessoes.AllowUserToAddRows = false;
            this.dtgSessoes.AllowUserToDeleteRows = false;
            this.dtgSessoes.AllowUserToOrderColumns = true;
            this.dtgSessoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSessoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSessoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgSessoes.Location = new System.Drawing.Point(0, 0);
            this.dtgSessoes.Name = "dtgSessoes";
            this.dtgSessoes.ReadOnly = true;
            this.dtgSessoes.Size = new System.Drawing.Size(672, 107);
            this.dtgSessoes.TabIndex = 0;
            this.dtgSessoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSessoes_CellClick);
            // 
            // userControlPesquisarSessoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(217)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "userControlPesquisarSessoes";
            this.Size = new System.Drawing.Size(672, 409);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSessoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.CheckBox cbData;
        private System.Windows.Forms.CheckBox cbTratamentos;
        private System.Windows.Forms.CheckBox cbConsultas;
        private System.Windows.Forms.CheckBox cbMedico;
        private System.Windows.Forms.CheckBox cbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtbxNomePesquisa;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgSessoes;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnFullInfo;
    }
}