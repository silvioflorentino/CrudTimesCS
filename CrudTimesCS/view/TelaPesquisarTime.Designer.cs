
namespace CrudTimesCS.view
{
    partial class TelaPesquisarTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPesquisarTime));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbxBuscaCodigo = new System.Windows.Forms.GroupBox();
            this.btnAlterarImagem = new System.Windows.Forms.Button();
            this.btnDeletarTimes = new System.Windows.Forms.Button();
            this.btnAlterarTime = new System.Windows.Forms.Button();
            this.lblCodigoTimeAtual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tbxFraseTimes = new System.Windows.Forms.TextBox();
            this.tbxNomeTimes = new System.Windows.Forms.TextBox();
            this.lblFraseTimes = new System.Windows.Forms.Label();
            this.lblNomeTime = new System.Windows.Forms.Label();
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.tbxCodigoTime = new System.Windows.Forms.TextBox();
            this.lblCodigoTime = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewNome = new System.Windows.Forms.DataGridView();
            this.btnBuscarNomeTime = new System.Windows.Forms.Button();
            this.tbxNomeTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialogLogo = new System.Windows.Forms.OpenFileDialog();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxBuscaCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNome)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(31, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbxBuscaCodigo);
            this.tabPage1.Controls.Add(this.btnBuscarCodigo);
            this.tabPage1.Controls.Add(this.tbxCodigoTime);
            this.tabPage1.Controls.Add(this.lblCodigoTime);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(631, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisa por Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbxBuscaCodigo
            // 
            this.gbxBuscaCodigo.Controls.Add(this.btnAlterarImagem);
            this.gbxBuscaCodigo.Controls.Add(this.btnDeletarTimes);
            this.gbxBuscaCodigo.Controls.Add(this.btnAlterarTime);
            this.gbxBuscaCodigo.Controls.Add(this.lblCodigoTimeAtual);
            this.gbxBuscaCodigo.Controls.Add(this.label2);
            this.gbxBuscaCodigo.Controls.Add(this.pictureBoxLogo);
            this.gbxBuscaCodigo.Controls.Add(this.tbxFraseTimes);
            this.gbxBuscaCodigo.Controls.Add(this.tbxNomeTimes);
            this.gbxBuscaCodigo.Controls.Add(this.lblFraseTimes);
            this.gbxBuscaCodigo.Controls.Add(this.lblNomeTime);
            this.gbxBuscaCodigo.Location = new System.Drawing.Point(33, 79);
            this.gbxBuscaCodigo.Name = "gbxBuscaCodigo";
            this.gbxBuscaCodigo.Size = new System.Drawing.Size(563, 244);
            this.gbxBuscaCodigo.TabIndex = 3;
            this.gbxBuscaCodigo.TabStop = false;
            this.gbxBuscaCodigo.Text = "Informações";
            // 
            // btnAlterarImagem
            // 
            this.btnAlterarImagem.Location = new System.Drawing.Point(397, 164);
            this.btnAlterarImagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterarImagem.Name = "btnAlterarImagem";
            this.btnAlterarImagem.Size = new System.Drawing.Size(135, 20);
            this.btnAlterarImagem.TabIndex = 14;
            this.btnAlterarImagem.Text = "Alterar Imagem";
            this.btnAlterarImagem.UseVisualStyleBackColor = true;
            this.btnAlterarImagem.Click += new System.EventHandler(this.btnAlterarImagem_Click);
            // 
            // btnDeletarTimes
            // 
            this.btnDeletarTimes.FlatAppearance.BorderSize = 0;
            this.btnDeletarTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletarTimes.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletarTimes.Image")));
            this.btnDeletarTimes.Location = new System.Drawing.Point(371, 190);
            this.btnDeletarTimes.Name = "btnDeletarTimes";
            this.btnDeletarTimes.Size = new System.Drawing.Size(75, 54);
            this.btnDeletarTimes.TabIndex = 13;
            this.btnDeletarTimes.UseVisualStyleBackColor = true;
            this.btnDeletarTimes.Click += new System.EventHandler(this.btnDeletarTimes_Click);
            // 
            // btnAlterarTime
            // 
            this.btnAlterarTime.FlatAppearance.BorderSize = 0;
            this.btnAlterarTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarTime.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarTime.Image")));
            this.btnAlterarTime.Location = new System.Drawing.Point(452, 190);
            this.btnAlterarTime.Name = "btnAlterarTime";
            this.btnAlterarTime.Size = new System.Drawing.Size(65, 48);
            this.btnAlterarTime.TabIndex = 12;
            this.btnAlterarTime.UseVisualStyleBackColor = true;
            this.btnAlterarTime.Click += new System.EventHandler(this.btnAlterarTime_Click);
            // 
            // lblCodigoTimeAtual
            // 
            this.lblCodigoTimeAtual.BackColor = System.Drawing.Color.Silver;
            this.lblCodigoTimeAtual.Location = new System.Drawing.Point(25, 44);
            this.lblCodigoTimeAtual.Name = "lblCodigoTimeAtual";
            this.lblCodigoTimeAtual.Size = new System.Drawing.Size(142, 21);
            this.lblCodigoTimeAtual.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Código:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(382, 22);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(164, 135);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // tbxFraseTimes
            // 
            this.tbxFraseTimes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxFraseTimes.Location = new System.Drawing.Point(20, 156);
            this.tbxFraseTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxFraseTimes.Name = "tbxFraseTimes";
            this.tbxFraseTimes.Size = new System.Drawing.Size(347, 32);
            this.tbxFraseTimes.TabIndex = 8;
            // 
            // tbxNomeTimes
            // 
            this.tbxNomeTimes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxNomeTimes.Location = new System.Drawing.Point(20, 98);
            this.tbxNomeTimes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxNomeTimes.Name = "tbxNomeTimes";
            this.tbxNomeTimes.Size = new System.Drawing.Size(275, 32);
            this.tbxNomeTimes.TabIndex = 7;
            // 
            // lblFraseTimes
            // 
            this.lblFraseTimes.AutoSize = true;
            this.lblFraseTimes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFraseTimes.Location = new System.Drawing.Point(20, 139);
            this.lblFraseTimes.Name = "lblFraseTimes";
            this.lblFraseTimes.Size = new System.Drawing.Size(39, 15);
            this.lblFraseTimes.TabIndex = 6;
            this.lblFraseTimes.Text = "Frase:";
            // 
            // lblNomeTime
            // 
            this.lblNomeTime.AutoSize = true;
            this.lblNomeTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeTime.Location = new System.Drawing.Point(20, 80);
            this.lblNomeTime.Name = "lblNomeTime";
            this.lblNomeTime.Size = new System.Drawing.Size(38, 15);
            this.lblNomeTime.TabIndex = 5;
            this.lblNomeTime.Text = "Time:";
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.Location = new System.Drawing.Point(415, 27);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(135, 32);
            this.btnBuscarCodigo.TabIndex = 2;
            this.btnBuscarCodigo.Text = "Buscar";
            this.btnBuscarCodigo.UseVisualStyleBackColor = true;
            this.btnBuscarCodigo.Click += new System.EventHandler(this.btnBuscarCodigo_Click);
            // 
            // tbxCodigoTime
            // 
            this.tbxCodigoTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxCodigoTime.Location = new System.Drawing.Point(239, 30);
            this.tbxCodigoTime.Name = "tbxCodigoTime";
            this.tbxCodigoTime.Size = new System.Drawing.Size(147, 29);
            this.tbxCodigoTime.TabIndex = 1;
            this.tbxCodigoTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigoTime
            // 
            this.lblCodigoTime.AutoSize = true;
            this.lblCodigoTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoTime.Location = new System.Drawing.Point(33, 30);
            this.lblCodigoTime.Name = "lblCodigoTime";
            this.lblCodigoTime.Size = new System.Drawing.Size(200, 21);
            this.lblCodigoTime.TabIndex = 0;
            this.lblCodigoTime.Text = "Digite o Código do Time:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewNome);
            this.tabPage2.Controls.Add(this.btnBuscarNomeTime);
            this.tabPage2.Controls.Add(this.tbxNomeTime);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(631, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa por Time";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNome
            // 
            this.dataGridViewNome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNome.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNome.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewNome.Location = new System.Drawing.Point(33, 119);
            this.dataGridViewNome.Name = "dataGridViewNome";
            this.dataGridViewNome.RowTemplate.Height = 25;
            this.dataGridViewNome.Size = new System.Drawing.Size(562, 180);
            this.dataGridViewNome.TabIndex = 8;
            // 
            // btnBuscarNomeTime
            // 
            this.btnBuscarNomeTime.Location = new System.Drawing.Point(428, 29);
            this.btnBuscarNomeTime.Name = "btnBuscarNomeTime";
            this.btnBuscarNomeTime.Size = new System.Drawing.Size(135, 32);
            this.btnBuscarNomeTime.TabIndex = 7;
            this.btnBuscarNomeTime.Text = "Buscar";
            this.btnBuscarNomeTime.UseVisualStyleBackColor = true;
            this.btnBuscarNomeTime.Click += new System.EventHandler(this.btnBuscarNomeTime_Click);
            // 
            // tbxNomeTime
            // 
            this.tbxNomeTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxNomeTime.Location = new System.Drawing.Point(252, 32);
            this.tbxNomeTime.Name = "tbxNomeTime";
            this.tbxNomeTime.Size = new System.Drawing.Size(149, 29);
            this.tbxNomeTime.TabIndex = 6;
            this.tbxNomeTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(46, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Digite o Nome do Time:";
            // 
            // openFileDialogLogo
            // 
            this.openFileDialogLogo.FileName = "openFileDialogLogo";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 43.47826F;
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 128.2609F;
            this.Column2.HeaderText = "Times";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.HeaderText = "Logo";
            this.Column4.Name = "Column4";
            this.Column4.Width = 59;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 128.2609F;
            this.Column3.HeaderText = "Frase";
            this.Column3.Name = "Column3";
            // 
            // TelaPesquisarTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(722, 401);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaPesquisarTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerenciador de Jogos ";
            this.Load += new System.EventHandler(this.TelaPesquisarTime_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbxBuscaCodigo.ResumeLayout(false);
            this.gbxBuscaCodigo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbxBuscaCodigo;
        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.TextBox tbxCodigoTime;
        private System.Windows.Forms.Label lblCodigoTime;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbxFraseTimes;
        private System.Windows.Forms.TextBox tbxNomeTimes;
        private System.Windows.Forms.Label lblFraseTimes;
        private System.Windows.Forms.Label lblNomeTime;
        private System.Windows.Forms.Button btnDeletarTimes;
        private System.Windows.Forms.Button btnAlterarTime;
        private System.Windows.Forms.Label lblCodigoTimeAtual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnBuscarNomeTime;
        private System.Windows.Forms.TextBox tbxNomeTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAlterarImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialogLogo;
        private System.Windows.Forms.DataGridView dataGridViewNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}