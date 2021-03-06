﻿namespace FinanzasPersonales.Consultas
{
    partial class ConsultaEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEntradas));
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CamposcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConteotextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Location = new System.Drawing.Point(236, 90);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(226, 20);
            this.FiltrotextBox.TabIndex = 17;
            this.FiltrotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FiltrotextBox_KeyPress);
            this.FiltrotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FiltrotextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Filtrar Por";
            // 
            // CamposcomboBox
            // 
            this.CamposcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CamposcomboBox.FormattingEnabled = true;
            this.CamposcomboBox.Items.AddRange(new object[] {
            "EntradaId",
            "CuentaId",
            "CategoriaId"});
            this.CamposcomboBox.Location = new System.Drawing.Point(98, 89);
            this.CamposcomboBox.Name = "CamposcomboBox";
            this.CamposcomboBox.Size = new System.Drawing.Size(121, 21);
            this.CamposcomboBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Conteo:";
            // 
            // ConteotextBox
            // 
            this.ConteotextBox.Location = new System.Drawing.Point(67, 393);
            this.ConteotextBox.Name = "ConteotextBox";
            this.ConteotextBox.ReadOnly = true;
            this.ConteotextBox.Size = new System.Drawing.Size(100, 20);
            this.ConteotextBox.TabIndex = 13;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(468, 69);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(95, 41);
            this.BuscarButton.TabIndex = 12;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.AllowUserToAddRows = false;
            this.ConsultadataGridView.AllowUserToDeleteRows = false;
            this.ConsultadataGridView.AllowUserToOrderColumns = true;
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(12, 116);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.ReadOnly = true;
            this.ConsultadataGridView.Size = new System.Drawing.Size(551, 274);
            this.ConsultadataGridView.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Consulta de Entradas";
            // 
            // ConsultaEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 425);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CamposcomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConteotextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ConsultadataGridView);
            this.Name = "ConsultaEntradas";
            this.Text = "ConsultaEntradas";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CamposcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConteotextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.Label label3;
    }
}