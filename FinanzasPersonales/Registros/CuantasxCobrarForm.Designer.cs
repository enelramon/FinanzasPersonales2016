﻿namespace FinanzasPersonales.Registros
{
    partial class CuantasxCobrarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuantasxCobrarForm));
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.CxcIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelFecha = new System.Windows.Forms.Label();
            this.dateTimePickerCuentasxCobrar = new System.Windows.Forms.DateTimePicker();
            this.LabelCuentaId = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LabelConcepto = new System.Windows.Forms.Label();
            this.LabelMonto = new System.Windows.Forms.Label();
            this.LabelBalance = new System.Windows.Forms.Label();
            this.textBoxConcepto = new System.Windows.Forms.TextBox();
            this.TextBoxMonto = new System.Windows.Forms.TextBox();
            this.TextBoxBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.Location = new System.Drawing.Point(41, 243);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(64, 51);
            this.NuevoButton.TabIndex = 4;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Enabled = false;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.Location = new System.Drawing.Point(222, 243);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(68, 51);
            this.GuardarButton.TabIndex = 5;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Enabled = false;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.Location = new System.Drawing.Point(406, 243);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(72, 51);
            this.EliminarButton.TabIndex = 6;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.BuscarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BuscarButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.Location = new System.Drawing.Point(250, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(56, 51);
            this.BuscarButton.TabIndex = 7;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // CxcIdTextBox
            // 
            this.CxcIdTextBox.Location = new System.Drawing.Point(163, 28);
            this.CxcIdTextBox.MaxLength = 5;
            this.CxcIdTextBox.Name = "CxcIdTextBox";
            this.CxcIdTextBox.Size = new System.Drawing.Size(81, 20);
            this.CxcIdTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID:";
            // 
            // LabelFecha
            // 
            this.LabelFecha.AutoSize = true;
            this.LabelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFecha.Location = new System.Drawing.Point(324, 28);
            this.LabelFecha.Name = "LabelFecha";
            this.LabelFecha.Size = new System.Drawing.Size(55, 16);
            this.LabelFecha.TabIndex = 10;
            this.LabelFecha.Text = "Fecha:";
            // 
            // dateTimePickerCuentasxCobrar
            // 
            this.dateTimePickerCuentasxCobrar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCuentasxCobrar.Location = new System.Drawing.Point(406, 25);
            this.dateTimePickerCuentasxCobrar.Name = "dateTimePickerCuentasxCobrar";
            this.dateTimePickerCuentasxCobrar.Size = new System.Drawing.Size(87, 20);
            this.dateTimePickerCuentasxCobrar.TabIndex = 11;
            // 
            // LabelCuentaId
            // 
            this.LabelCuentaId.AutoSize = true;
            this.LabelCuentaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCuentaId.Location = new System.Drawing.Point(54, 90);
            this.LabelCuentaId.Name = "LabelCuentaId";
            this.LabelCuentaId.Size = new System.Drawing.Size(73, 16);
            this.LabelCuentaId.TabIndex = 12;
            this.LabelCuentaId.Text = "CuentaId:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // LabelConcepto
            // 
            this.LabelConcepto.AutoSize = true;
            this.LabelConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConcepto.Location = new System.Drawing.Point(54, 127);
            this.LabelConcepto.Name = "LabelConcepto";
            this.LabelConcepto.Size = new System.Drawing.Size(78, 16);
            this.LabelConcepto.TabIndex = 14;
            this.LabelConcepto.Text = "Concepto:";
            // 
            // LabelMonto
            // 
            this.LabelMonto.AutoSize = true;
            this.LabelMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMonto.Location = new System.Drawing.Point(54, 160);
            this.LabelMonto.Name = "LabelMonto";
            this.LabelMonto.Size = new System.Drawing.Size(54, 16);
            this.LabelMonto.TabIndex = 15;
            this.LabelMonto.Text = "Monto:";
            // 
            // LabelBalance
            // 
            this.LabelBalance.AutoSize = true;
            this.LabelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBalance.Location = new System.Drawing.Point(54, 199);
            this.LabelBalance.Name = "LabelBalance";
            this.LabelBalance.Size = new System.Drawing.Size(69, 16);
            this.LabelBalance.TabIndex = 16;
            this.LabelBalance.Text = "Balance:";
            // 
            // textBoxConcepto
            // 
            this.textBoxConcepto.Location = new System.Drawing.Point(163, 122);
            this.textBoxConcepto.Name = "textBoxConcepto";
            this.textBoxConcepto.Size = new System.Drawing.Size(221, 20);
            this.textBoxConcepto.TabIndex = 17;
            // 
            // TextBoxMonto
            // 
            this.TextBoxMonto.Location = new System.Drawing.Point(163, 159);
            this.TextBoxMonto.Name = "TextBoxMonto";
            this.TextBoxMonto.Size = new System.Drawing.Size(143, 20);
            this.TextBoxMonto.TabIndex = 18;
            // 
            // TextBoxBalance
            // 
            this.TextBoxBalance.Location = new System.Drawing.Point(163, 198);
            this.TextBoxBalance.Name = "TextBoxBalance";
            this.TextBoxBalance.Size = new System.Drawing.Size(143, 20);
            this.TextBoxBalance.TabIndex = 19;
            // 
            // CuantasxCobrarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 325);
            this.Controls.Add(this.TextBoxBalance);
            this.Controls.Add(this.TextBoxMonto);
            this.Controls.Add(this.textBoxConcepto);
            this.Controls.Add(this.LabelBalance);
            this.Controls.Add(this.LabelMonto);
            this.Controls.Add(this.LabelConcepto);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LabelCuentaId);
            this.Controls.Add(this.dateTimePickerCuentasxCobrar);
            this.Controls.Add(this.LabelFecha);
            this.Controls.Add(this.CxcIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CuantasxCobrarForm";
            this.Text = "Resgistro Cuentas por Cobrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox CxcIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelFecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerCuentasxCobrar;
        private System.Windows.Forms.Label LabelCuentaId;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LabelConcepto;
        private System.Windows.Forms.Label LabelMonto;
        private System.Windows.Forms.Label LabelBalance;
        private System.Windows.Forms.TextBox textBoxConcepto;
        private System.Windows.Forms.TextBox TextBoxMonto;
        private System.Windows.Forms.TextBox TextBoxBalance;
    }
}