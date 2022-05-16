
namespace CrudTimesCS.view
{
    partial class TelaCadastrarTimes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrarTimes));
            this.lblTituloTimes = new System.Windows.Forms.Label();
            this.lblNomeTime = new System.Windows.Forms.Label();
            this.lblFraseTimes = new System.Windows.Forms.Label();
            this.tbxNomeTimes = new System.Windows.Forms.TextBox();
            this.tbxFraseTimes = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastrarTimes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloTimes
            // 
            this.lblTituloTimes.AutoSize = true;
            this.lblTituloTimes.Font = new System.Drawing.Font("Times New Roman", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloTimes.ForeColor = System.Drawing.Color.Tomato;
            this.lblTituloTimes.Location = new System.Drawing.Point(192, 36);
            this.lblTituloTimes.Name = "lblTituloTimes";
            this.lblTituloTimes.Size = new System.Drawing.Size(269, 36);
            this.lblTituloTimes.TabIndex = 0;
            this.lblTituloTimes.Text = "Cadastro de Times";
            // 
            // lblNomeTime
            // 
            this.lblNomeTime.AutoSize = true;
            this.lblNomeTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNomeTime.Location = new System.Drawing.Point(12, 94);
            this.lblNomeTime.Name = "lblNomeTime";
            this.lblNomeTime.Size = new System.Drawing.Size(48, 20);
            this.lblNomeTime.TabIndex = 1;
            this.lblNomeTime.Text = "Time:";
            // 
            // lblFraseTimes
            // 
            this.lblFraseTimes.AutoSize = true;
            this.lblFraseTimes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFraseTimes.Location = new System.Drawing.Point(12, 178);
            this.lblFraseTimes.Name = "lblFraseTimes";
            this.lblFraseTimes.Size = new System.Drawing.Size(50, 20);
            this.lblFraseTimes.TabIndex = 2;
            this.lblFraseTimes.Text = "Frase:";
            // 
            // tbxNomeTimes
            // 
            this.tbxNomeTimes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxNomeTimes.Location = new System.Drawing.Point(12, 117);
            this.tbxNomeTimes.Name = "tbxNomeTimes";
            this.tbxNomeTimes.Size = new System.Drawing.Size(380, 38);
            this.tbxNomeTimes.TabIndex = 3;
            // 
            // tbxFraseTimes
            // 
            this.tbxFraseTimes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbxFraseTimes.Location = new System.Drawing.Point(12, 201);
            this.tbxFraseTimes.Name = "tbxFraseTimes";
            this.tbxFraseTimes.Size = new System.Drawing.Size(594, 38);
            this.tbxFraseTimes.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 121);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastrarTimes
            // 
            this.btnCadastrarTimes.Location = new System.Drawing.Point(466, 341);
            this.btnCadastrarTimes.Name = "btnCadastrarTimes";
            this.btnCadastrarTimes.Size = new System.Drawing.Size(140, 51);
            this.btnCadastrarTimes.TabIndex = 6;
            this.btnCadastrarTimes.Text = "Cadastrar";
            this.btnCadastrarTimes.UseVisualStyleBackColor = true;
            this.btnCadastrarTimes.Click += new System.EventHandler(this.btnCadastrarTimes_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TelaCadastrarTimes
            // 
            this.AcceptButton = this.btnCadastrarTimes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(641, 424);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCadastrarTimes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxFraseTimes);
            this.Controls.Add(this.tbxNomeTimes);
            this.Controls.Add(this.lblFraseTimes);
            this.Controls.Add(this.lblNomeTime);
            this.Controls.Add(this.lblTituloTimes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "TelaCadastrarTimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerenciador de Jogos ";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaCadastrarTimes_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloTimes;
        private System.Windows.Forms.Label lblNomeTime;
        private System.Windows.Forms.Label lblFraseTimes;
        private System.Windows.Forms.TextBox tbxNomeTimes;
        private System.Windows.Forms.TextBox tbxFraseTimes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastrarTimes;
        private System.Windows.Forms.Button button2;
    }
}