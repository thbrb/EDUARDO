﻿namespace SisClinica.Forms
{
    partial class userControlMenuPesquisar
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
            this.btnPessoa = new System.Windows.Forms.Button();
            this.btnSessoes = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnPessoa, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSessoes, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(605, 409);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPessoa
            // 
            this.btnPessoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPessoa.Image = global::SisClinica.Properties.Resources.btnPesqPessoas;
            this.btnPessoa.Location = new System.Drawing.Point(3, 3);
            this.btnPessoa.Name = "btnPessoa";
            this.btnPessoa.Size = new System.Drawing.Size(296, 403);
            this.btnPessoa.TabIndex = 0;
            this.btnPessoa.UseVisualStyleBackColor = true;
            // 
            // btnSessoes
            // 
            this.btnSessoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSessoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSessoes.Image = global::SisClinica.Properties.Resources.btnPesqSessoes;
            this.btnSessoes.Location = new System.Drawing.Point(305, 3);
            this.btnSessoes.Name = "btnSessoes";
            this.btnSessoes.Size = new System.Drawing.Size(297, 403);
            this.btnSessoes.TabIndex = 1;
            this.btnSessoes.UseVisualStyleBackColor = true;
            // 
            // userControlMenuPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(217)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "userControlMenuPesquisar";
            this.Size = new System.Drawing.Size(605, 409);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPessoa;
        private System.Windows.Forms.Button btnSessoes;
    }
}