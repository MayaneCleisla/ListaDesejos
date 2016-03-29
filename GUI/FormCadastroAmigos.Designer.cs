namespace Model
{
    partial class FormCadastroAmigos
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
            this.textBoxAmigo = new System.Windows.Forms.TextBox();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.dataGridViewAmigo = new System.Windows.Forms.DataGridView();
            this.labelData = new System.Windows.Forms.Label();
            this.dateTimePickerAmigo = new System.Windows.Forms.DateTimePicker();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAmigo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // textBoxAmigo
            // 
            this.textBoxAmigo.Location = new System.Drawing.Point(58, 27);
            this.textBoxAmigo.Name = "textBoxAmigo";
            this.textBoxAmigo.Size = new System.Drawing.Size(287, 20);
            this.textBoxAmigo.TabIndex = 1;
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(28, 140);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(131, 23);
            this.buttonGravar.TabIndex = 2;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(209, 140);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(136, 23);
            this.buttonExcluir.TabIndex = 3;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAmigo
            // 
            this.dataGridViewAmigo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAmigo.Location = new System.Drawing.Point(28, 178);
            this.dataGridViewAmigo.Name = "dataGridViewAmigo";
            this.dataGridViewAmigo.Size = new System.Drawing.Size(317, 150);
            this.dataGridViewAmigo.TabIndex = 4;
            this.dataGridViewAmigo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(16, 64);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 5;
            this.labelData.Text = "Data:";
            // 
            // dateTimePickerAmigo
            // 
            this.dateTimePickerAmigo.Location = new System.Drawing.Point(58, 64);
            this.dateTimePickerAmigo.Name = "dateTimePickerAmigo";
            this.dateTimePickerAmigo.Size = new System.Drawing.Size(208, 20);
            this.dateTimePickerAmigo.TabIndex = 6;
            this.dateTimePickerAmigo.ValueChanged += new System.EventHandler(this.dateTimePickerAmigo_ValueChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(16, 99);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email:";
            this.labelEmail.Click += new System.EventHandler(this.labelEmail_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(58, 99);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(288, 20);
            this.textBoxEmail.TabIndex = 8;
            // 
            // FormCadastroAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 340);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.dateTimePickerAmigo);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.dataGridViewAmigo);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.textBoxAmigo);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroAmigos";
            this.Text = "FormCadastroAmigos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAmigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAmigo;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.DataGridView dataGridViewAmigo;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.DateTimePicker dateTimePickerAmigo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
    }
}