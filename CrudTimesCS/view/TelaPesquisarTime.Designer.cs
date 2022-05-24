
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
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialogLogo = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbxBuscaCodigo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(35, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 503);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbxBuscaCodigo);
            this.tabPage1.Controls.Add(this.btnBuscarCodigo);
            this.tabPage1.Controls.Add(this.tbxCodigoTime);
            this.tabPage1.Controls.Add(this.lblCodigoTime);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(722, 470);
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
            this.gbxBuscaCodigo.Location = new System.Drawing.Point(38, 105);
            this.gbxBuscaCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxBuscaCodigo.Name = "gbxBuscaCodigo";
            this.gbxBuscaCodigo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxBuscaCodigo.Size = new System.Drawing.Size(643, 325);
            this.gbxBuscaCodigo.TabIndex = 3;
            this.gbxBuscaCodigo.TabStop = false;
            this.gbxBuscaCodigo.Text = "Informações";
            // 
            // btnAlterarImagem
            // 
            this.btnAlterarImagem.Location = new System.Drawing.Point(454, 219);
            this.btnAlterarImagem.Name = "btnAlterarImagem";
            this.btnAlterarImagem.Size = new System.Drawing.Size(154, 27);
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
            this.btnDeletarTimes.Location = new System.Drawing.Point(424, 253);
            this.btnDeletarTimes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeletarTimes.Name = "btnDeletarTimes";
            this.btnDeletarTimes.Size = new System.Drawing.Size(86, 72);
            this.btnDeletarTimes.TabIndex = 13;
            this.btnDeletarTimes.UseVisualStyleBackColor = true;
            this.btnDeletarTimes.Click += new System.EventHandler(this.btnDeletarTimes_Click);
            // 
            // btnAlterarTime
            // 
            this.btnAlterarTime.FlatAppearance.BorderSize = 0;
            this.btnAlterarTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarTime.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarTime.Image")));
            this.btnAlterarTime.Location = new System.Drawing.Point(517, 253);
            this.btnAlterarTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlterarTime.Name = "btnAlterarTime";
            this.btnAlterarTime.Size = new System.Drawing.Size(74, 64);
            this.btnAlterarTime.TabIndex = 12;
            this.btnAlterarTime.UseVisualStyleBackColor = true;
            this.btnAlterarTime.Click += new System.EventHandler(this.btnAlterarTime_Click);
            // 
            // lblCodigoTimeAtual
            // 
            this.lblCodigoTimeAtual.BackColor = System.Drawing.Color.Silver;
            this.lblCodigoTimeAtual.Location = new System.Drawing.Point(29, 59);
            this.lblCodigoTimeAtual.Name = "lblCodigoTimeAtual";
            this.lblCodigoTimeAtual.Size = new System.Drawing.Size(162, 28);
            this.lblCodigoTimeAtual.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Código:";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(437, 29);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(187, 180);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // tbxFraseTimes
            // 
            this.tbxFraseTimes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxFraseTimes.Location = new System.Drawing.Point(23, 208);
            this.tbxFraseTimes.Name = "tbxFraseTimes";
            this.tbxFraseTimes.Size = new System.Drawing.Size(396, 38);
            this.tbxFraseTimes.TabIndex = 8;
            // 
            // tbxNomeTimes
            // 
            this.tbxNomeTimes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxNomeTimes.Location = new System.Drawing.Point(23, 131);
            this.tbxNomeTimes.Name = "tbxNomeTimes";
            this.tbxNomeTimes.Size = new System.Drawing.Size(314, 38);
            this.tbxNomeTimes.TabIndex = 7;
            // 
            // lblFraseTimes
            // 
            this.lblFraseTimes.AutoSize = true;
            this.lblFraseTimes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFraseTimes.Location = new System.Drawing.Point(23, 185);
            this.lblFraseTimes.Name = "lblFraseTimes";
            this.lblFraseTimes.Size = new System.Drawing.Size(50, 20);
            this.lblFraseTimes.TabIndex = 6;
            this.lblFraseTimes.Text = "Frase:";
            // 
            // lblNomeTime
            // 
            this.lblNomeTime.AutoSize = true;
            this.lblNomeTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeTime.Location = new System.Drawing.Point(23, 107);
            this.lblNomeTime.Name = "lblNomeTime";
            this.lblNomeTime.Size = new System.Drawing.Size(48, 20);
            this.lblNomeTime.TabIndex = 5;
            this.lblNomeTime.Text = "Time:";
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.Location = new System.Drawing.Point(474, 36);
            this.btnBuscarCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(154, 43);
            this.btnBuscarCodigo.TabIndex = 2;
            this.btnBuscarCodigo.Text = "Buscar";
            this.btnBuscarCodigo.UseVisualStyleBackColor = true;
            this.btnBuscarCodigo.Click += new System.EventHandler(this.btnBuscarCodigo_Click);
            // 
            // tbxCodigoTime
            // 
            this.tbxCodigoTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxCodigoTime.Location = new System.Drawing.Point(273, 40);
            this.tbxCodigoTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxCodigoTime.Name = "tbxCodigoTime";
            this.tbxCodigoTime.Size = new System.Drawing.Size(167, 34);
            this.tbxCodigoTime.TabIndex = 1;
            this.tbxCodigoTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigoTime
            // 
            this.lblCodigoTime.AutoSize = true;
            this.lblCodigoTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoTime.Location = new System.Drawing.Point(38, 40);
            this.lblCodigoTime.Name = "lblCodigoTime";
            this.lblCodigoTime.Size = new System.Drawing.Size(248, 28);
            this.lblCodigoTime.TabIndex = 0;
            this.lblCodigoTime.Text = "Digite o Código do Time:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(722, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa por Time";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(489, 39);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 43);
            this.button5.TabIndex = 7;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(288, 43);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 34);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(53, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Digite o Nome do Time:";
            // 
            // openFileDialogLogo
            // 
            this.openFileDialogLogo.FileName = "openFileDialogLogo";
            // 
            // TelaPesquisarTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(825, 535);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAlterarImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialogLogo;
    }
}