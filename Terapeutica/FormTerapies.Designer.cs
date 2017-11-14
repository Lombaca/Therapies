namespace Terapeutica
{
    partial class FormTerapies
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
            this.listBoxMedications = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMedName = new System.Windows.Forms.TextBox();
            this.numericUpDownQtd = new System.Windows.Forms.NumericUpDown();
            this.textBoxPosology = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMedications
            // 
            this.listBoxMedications.FormattingEnabled = true;
            this.listBoxMedications.Location = new System.Drawing.Point(12, 12);
            this.listBoxMedications.Name = "listBoxMedications";
            this.listBoxMedications.Size = new System.Drawing.Size(403, 238);
            this.listBoxMedications.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medicamento";
            // 
            // textBoxMedName
            // 
            this.textBoxMedName.Location = new System.Drawing.Point(90, 257);
            this.textBoxMedName.Name = "textBoxMedName";
            this.textBoxMedName.Size = new System.Drawing.Size(237, 20);
            this.textBoxMedName.TabIndex = 2;
            // 
            // numericUpDownQtd
            // 
            this.numericUpDownQtd.Location = new System.Drawing.Point(363, 260);
            this.numericUpDownQtd.Name = "numericUpDownQtd";
            this.numericUpDownQtd.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownQtd.TabIndex = 3;
            // 
            // textBoxPosology
            // 
            this.textBoxPosology.Location = new System.Drawing.Point(90, 286);
            this.textBoxPosology.Name = "textBoxPosology";
            this.textBoxPosology.Size = new System.Drawing.Size(325, 20);
            this.textBoxPosology.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Qtd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Posologia";
            // 
            // buttonDel
            // 
            this.buttonDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDel.Location = new System.Drawing.Point(142, 317);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(63, 23);
            this.buttonDel.TabIndex = 13;
            this.buttonDel.Text = "Apagar";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(93, 317);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(43, 23);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(16, 317);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(71, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Adicionar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(349, 317);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(66, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(284, 317);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(62, 23);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Gravar";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // FormTerapies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 343);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPosology);
            this.Controls.Add(this.numericUpDownQtd);
            this.Controls.Add(this.textBoxMedName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMedications);
            this.Name = "FormTerapies";
            this.Text = "FormTerapies";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMedications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMedName;
        private System.Windows.Forms.NumericUpDown numericUpDownQtd;
        private System.Windows.Forms.TextBox textBoxPosology;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}