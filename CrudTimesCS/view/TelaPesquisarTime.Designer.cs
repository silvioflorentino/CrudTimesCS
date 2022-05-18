
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.gbxBuscaCodigo.Controls.Add(this.button2);
            this.gbxBuscaCodigo.Controls.Add(this.button1);
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
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(371, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 54);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(452, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 48);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
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
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(631, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisa por Time";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(428, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 32);
            this.button5.TabIndex = 7;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(252, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 29);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCodigoTimeAtual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
    }
}