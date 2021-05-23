
namespace Calculadora_de_Reserva_Mineral
{
	partial class Form1
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
			this.txtBoxMinerais = new System.Windows.Forms.TextBox();
			this.txtGrau = new System.Windows.Forms.TextBox();
			this.txtLogReservas = new System.Windows.Forms.TextBox();
			this.lblMinerais = new System.Windows.Forms.Label();
			this.lblGrau = new System.Windows.Forms.Label();
			this.btnConverter = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.rdBtnToneladasMetricas = new System.Windows.Forms.RadioButton();
			this.gpBoxUnidadeMinerais = new System.Windows.Forms.GroupBox();
			this.rdBtnOncasTroy = new System.Windows.Forms.RadioButton();
			this.rdBtnMegatons = new System.Windows.Forms.RadioButton();
			this.rdBtnToneladasImperais = new System.Windows.Forms.RadioButton();
			this.rdBtnToneladasCurtas = new System.Windows.Forms.RadioButton();
			this.rdBtnOncas = new System.Windows.Forms.RadioButton();
			this.rdBtnLibras = new System.Windows.Forms.RadioButton();
			this.gpBoxGrauMineral = new System.Windows.Forms.GroupBox();
			this.rdBtnGramasOncaTroy = new System.Windows.Forms.RadioButton();
			this.rdBtnGramasOnca = new System.Windows.Forms.RadioButton();
			this.rdBtnGramasToneladasCurtas = new System.Windows.Forms.RadioButton();
			this.rdBtnGramasToneladaPPM = new System.Windows.Forms.RadioButton();
			this.rdBtnPorcentagem = new System.Windows.Forms.RadioButton();
			this.gpBoxUnidadeMinerais.SuspendLayout();
			this.gpBoxGrauMineral.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtBoxMinerais
			// 
			this.txtBoxMinerais.Location = new System.Drawing.Point(50, 226);
			this.txtBoxMinerais.Name = "txtBoxMinerais";
			this.txtBoxMinerais.Size = new System.Drawing.Size(152, 20);
			this.txtBoxMinerais.TabIndex = 0;
			this.txtBoxMinerais.TextChanged += new System.EventHandler(this.txtBoxMinerais_TextChanged);
			// 
			// txtGrau
			// 
			this.txtGrau.Location = new System.Drawing.Point(215, 226);
			this.txtGrau.Name = "txtGrau";
			this.txtGrau.Size = new System.Drawing.Size(75, 20);
			this.txtGrau.TabIndex = 1;
			// 
			// txtLogReservas
			// 
			this.txtLogReservas.Location = new System.Drawing.Point(9, 285);
			this.txtLogReservas.Multiline = true;
			this.txtLogReservas.Name = "txtLogReservas";
			this.txtLogReservas.Size = new System.Drawing.Size(399, 109);
			this.txtLogReservas.TabIndex = 2;
			// 
			// lblMinerais
			// 
			this.lblMinerais.AutoSize = true;
			this.lblMinerais.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMinerais.Location = new System.Drawing.Point(50, 207);
			this.lblMinerais.Name = "lblMinerais";
			this.lblMinerais.Size = new System.Drawing.Size(61, 16);
			this.lblMinerais.TabIndex = 4;
			this.lblMinerais.Text = "Minerais";
			// 
			// lblGrau
			// 
			this.lblGrau.AutoSize = true;
			this.lblGrau.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGrau.Location = new System.Drawing.Point(212, 207);
			this.lblGrau.Name = "lblGrau";
			this.lblGrau.Size = new System.Drawing.Size(40, 16);
			this.lblGrau.TabIndex = 10;
			this.lblGrau.Text = "Grau";
			// 
			// btnConverter
			// 
			this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConverter.Location = new System.Drawing.Point(127, 252);
			this.btnConverter.Name = "btnConverter";
			this.btnConverter.Size = new System.Drawing.Size(75, 23);
			this.btnConverter.TabIndex = 11;
			this.btnConverter.Text = "Converter";
			this.btnConverter.UseVisualStyleBackColor = true;
			this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(215, 252);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpar.TabIndex = 13;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// rdBtnToneladasMetricas
			// 
			this.rdBtnToneladasMetricas.AutoSize = true;
			this.rdBtnToneladasMetricas.Checked = true;
			this.rdBtnToneladasMetricas.Location = new System.Drawing.Point(6, 18);
			this.rdBtnToneladasMetricas.Name = "rdBtnToneladasMetricas";
			this.rdBtnToneladasMetricas.Size = new System.Drawing.Size(130, 17);
			this.rdBtnToneladasMetricas.TabIndex = 14;
			this.rdBtnToneladasMetricas.TabStop = true;
			this.rdBtnToneladasMetricas.Text = "Toneladas Métricas/T";
			this.rdBtnToneladasMetricas.UseVisualStyleBackColor = true;
			this.rdBtnToneladasMetricas.CheckedChanged += new System.EventHandler(this.rdBtnToneladasMetricas_CheckedChanged);
			// 
			// gpBoxUnidadeMinerais
			// 
			this.gpBoxUnidadeMinerais.Controls.Add(this.rdBtnOncasTroy);
			this.gpBoxUnidadeMinerais.Controls.Add(this.rdBtnMegatons);
			this.gpBoxUnidadeMinerais.Controls.Add(this.rdBtnToneladasImperais);
			this.gpBoxUnidadeMinerais.Controls.Add(this.rdBtnToneladasCurtas);
			this.gpBoxUnidadeMinerais.Controls.Add(this.rdBtnOncas);
			this.gpBoxUnidadeMinerais.Controls.Add(this.rdBtnLibras);
			this.gpBoxUnidadeMinerais.Controls.Add(this.rdBtnToneladasMetricas);
			this.gpBoxUnidadeMinerais.Location = new System.Drawing.Point(9, 10);
			this.gpBoxUnidadeMinerais.Name = "gpBoxUnidadeMinerais";
			this.gpBoxUnidadeMinerais.Size = new System.Drawing.Size(193, 194);
			this.gpBoxUnidadeMinerais.TabIndex = 15;
			this.gpBoxUnidadeMinerais.TabStop = false;
			this.gpBoxUnidadeMinerais.Text = "Unidade dos Minerais";
			this.gpBoxUnidadeMinerais.Enter += new System.EventHandler(this.gpBoxUnidadeMinerais_Enter);
			// 
			// rdBtnOncasTroy
			// 
			this.rdBtnOncasTroy.AutoSize = true;
			this.rdBtnOncasTroy.Location = new System.Drawing.Point(7, 87);
			this.rdBtnOncasTroy.Name = "rdBtnOncasTroy";
			this.rdBtnOncasTroy.Size = new System.Drawing.Size(108, 17);
			this.rdBtnOncasTroy.TabIndex = 20;
			this.rdBtnOncasTroy.TabStop = true;
			this.rdBtnOncasTroy.Text = "Onças Troy/Oz T";
			this.rdBtnOncasTroy.UseVisualStyleBackColor = true;
			// 
			// rdBtnMegatons
			// 
			this.rdBtnMegatons.AutoSize = true;
			this.rdBtnMegatons.Location = new System.Drawing.Point(6, 156);
			this.rdBtnMegatons.Name = "rdBtnMegatons";
			this.rdBtnMegatons.Size = new System.Drawing.Size(93, 17);
			this.rdBtnMegatons.TabIndex = 19;
			this.rdBtnMegatons.TabStop = true;
			this.rdBtnMegatons.Text = "Megatons/MT\t";
			this.rdBtnMegatons.UseVisualStyleBackColor = true;
			// 
			// rdBtnToneladasImperais
			// 
			this.rdBtnToneladasImperais.AutoSize = true;
			this.rdBtnToneladasImperais.Location = new System.Drawing.Point(7, 133);
			this.rdBtnToneladasImperais.Name = "rdBtnToneladasImperais";
			this.rdBtnToneladasImperais.Size = new System.Drawing.Size(144, 17);
			this.rdBtnToneladasImperais.TabIndex = 18;
			this.rdBtnToneladasImperais.TabStop = true;
			this.rdBtnToneladasImperais.Text = "Toneladas Imperais/UKT";
			this.rdBtnToneladasImperais.UseVisualStyleBackColor = true;
			this.rdBtnToneladasImperais.CheckedChanged += new System.EventHandler(this.rdBtnToneladasImperais_CheckedChanged);
			// 
			// rdBtnToneladasCurtas
			// 
			this.rdBtnToneladasCurtas.AutoSize = true;
			this.rdBtnToneladasCurtas.Location = new System.Drawing.Point(7, 110);
			this.rdBtnToneladasCurtas.Name = "rdBtnToneladasCurtas";
			this.rdBtnToneladasCurtas.Size = new System.Drawing.Size(123, 17);
			this.rdBtnToneladasCurtas.TabIndex = 17;
			this.rdBtnToneladasCurtas.TabStop = true;
			this.rdBtnToneladasCurtas.Text = "Toneladas Curtas/St";
			this.rdBtnToneladasCurtas.UseVisualStyleBackColor = true;
			// 
			// rdBtnOncas
			// 
			this.rdBtnOncas.AutoSize = true;
			this.rdBtnOncas.Location = new System.Drawing.Point(6, 64);
			this.rdBtnOncas.Name = "rdBtnOncas";
			this.rdBtnOncas.Size = new System.Drawing.Size(74, 17);
			this.rdBtnOncas.TabIndex = 16;
			this.rdBtnOncas.TabStop = true;
			this.rdBtnOncas.Text = "Onças/Oz";
			this.rdBtnOncas.UseVisualStyleBackColor = true;
			// 
			// rdBtnLibras
			// 
			this.rdBtnLibras.AutoSize = true;
			this.rdBtnLibras.Location = new System.Drawing.Point(6, 41);
			this.rdBtnLibras.Name = "rdBtnLibras";
			this.rdBtnLibras.Size = new System.Drawing.Size(75, 17);
			this.rdBtnLibras.TabIndex = 15;
			this.rdBtnLibras.TabStop = true;
			this.rdBtnLibras.Text = "Libras/Lbs";
			this.rdBtnLibras.UseVisualStyleBackColor = true;
			// 
			// gpBoxGrauMineral
			// 
			this.gpBoxGrauMineral.Controls.Add(this.rdBtnGramasOncaTroy);
			this.gpBoxGrauMineral.Controls.Add(this.rdBtnGramasOnca);
			this.gpBoxGrauMineral.Controls.Add(this.rdBtnGramasToneladasCurtas);
			this.gpBoxGrauMineral.Controls.Add(this.rdBtnGramasToneladaPPM);
			this.gpBoxGrauMineral.Controls.Add(this.rdBtnPorcentagem);
			this.gpBoxGrauMineral.Location = new System.Drawing.Point(215, 10);
			this.gpBoxGrauMineral.Name = "gpBoxGrauMineral";
			this.gpBoxGrauMineral.Size = new System.Drawing.Size(193, 194);
			this.gpBoxGrauMineral.TabIndex = 20;
			this.gpBoxGrauMineral.TabStop = false;
			this.gpBoxGrauMineral.Text = "Grau dos Minerais";
			// 
			// rdBtnGramasOncaTroy
			// 
			this.rdBtnGramasOncaTroy.AutoSize = true;
			this.rdBtnGramasOncaTroy.Location = new System.Drawing.Point(7, 133);
			this.rdBtnGramasOncaTroy.Name = "rdBtnGramasOncaTroy";
			this.rdBtnGramasOncaTroy.Size = new System.Drawing.Size(169, 17);
			this.rdBtnGramasOncaTroy.TabIndex = 18;
			this.rdBtnGramasOncaTroy.TabStop = true;
			this.rdBtnGramasOncaTroy.Text = "Gramas por Onça Troy (g/oz t)";
			this.rdBtnGramasOncaTroy.UseVisualStyleBackColor = true;
			// 
			// rdBtnGramasOnca
			// 
			this.rdBtnGramasOnca.AutoSize = true;
			this.rdBtnGramasOnca.Location = new System.Drawing.Point(7, 110);
			this.rdBtnGramasOnca.Name = "rdBtnGramasOnca";
			this.rdBtnGramasOnca.Size = new System.Drawing.Size(139, 17);
			this.rdBtnGramasOnca.TabIndex = 17;
			this.rdBtnGramasOnca.TabStop = true;
			this.rdBtnGramasOnca.Text = "Gramas por Onça (g/oz)";
			this.rdBtnGramasOnca.UseVisualStyleBackColor = true;
			this.rdBtnGramasOnca.CheckedChanged += new System.EventHandler(this.rdBtnGramasOnca_CheckedChanged);
			// 
			// rdBtnGramasToneladasCurtas
			// 
			this.rdBtnGramasToneladasCurtas.AutoSize = true;
			this.rdBtnGramasToneladasCurtas.Location = new System.Drawing.Point(7, 87);
			this.rdBtnGramasToneladasCurtas.Name = "rdBtnGramasToneladasCurtas";
			this.rdBtnGramasToneladasCurtas.Size = new System.Drawing.Size(180, 17);
			this.rdBtnGramasToneladasCurtas.TabIndex = 16;
			this.rdBtnGramasToneladasCurtas.TabStop = true;
			this.rdBtnGramasToneladasCurtas.Text = "Gramas por Tonelada Curta(g/st)";
			this.rdBtnGramasToneladasCurtas.UseVisualStyleBackColor = true;
			// 
			// rdBtnGramasToneladaPPM
			// 
			this.rdBtnGramasToneladaPPM.Location = new System.Drawing.Point(6, 41);
			this.rdBtnGramasToneladaPPM.Name = "rdBtnGramasToneladaPPM";
			this.rdBtnGramasToneladaPPM.Size = new System.Drawing.Size(181, 40);
			this.rdBtnGramasToneladaPPM.TabIndex = 15;
			this.rdBtnGramasToneladaPPM.TabStop = true;
			this.rdBtnGramasToneladaPPM.Text = "Gramas por Tonelada (g/t) ou Partes por Milhão (ppm)";
			this.rdBtnGramasToneladaPPM.UseVisualStyleBackColor = true;
			this.rdBtnGramasToneladaPPM.CheckedChanged += new System.EventHandler(this.rdBtnGramasTonelada_CheckedChanged);
			// 
			// rdBtnPorcentagem
			// 
			this.rdBtnPorcentagem.AutoSize = true;
			this.rdBtnPorcentagem.Checked = true;
			this.rdBtnPorcentagem.Location = new System.Drawing.Point(6, 18);
			this.rdBtnPorcentagem.Name = "rdBtnPorcentagem";
			this.rdBtnPorcentagem.Size = new System.Drawing.Size(105, 17);
			this.rdBtnPorcentagem.TabIndex = 14;
			this.rdBtnPorcentagem.TabStop = true;
			this.rdBtnPorcentagem.Text = "Porcentagem (%)";
			this.rdBtnPorcentagem.UseVisualStyleBackColor = true;
			this.rdBtnPorcentagem.CheckedChanged += new System.EventHandler(this.rdBtnPorcentagem_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(420, 406);
			this.Controls.Add(this.gpBoxGrauMineral);
			this.Controls.Add(this.gpBoxUnidadeMinerais);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnConverter);
			this.Controls.Add(this.lblGrau);
			this.Controls.Add(this.lblMinerais);
			this.Controls.Add(this.txtLogReservas);
			this.Controls.Add(this.txtGrau);
			this.Controls.Add(this.txtBoxMinerais);
			this.Name = "Form1";
			this.Text = "Form1";
			this.gpBoxUnidadeMinerais.ResumeLayout(false);
			this.gpBoxUnidadeMinerais.PerformLayout();
			this.gpBoxGrauMineral.ResumeLayout(false);
			this.gpBoxGrauMineral.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBoxMinerais;
		private System.Windows.Forms.TextBox txtGrau;
		private System.Windows.Forms.TextBox txtLogReservas;
		private System.Windows.Forms.Label lblMinerais;
		private System.Windows.Forms.Label lblGrau;
		private System.Windows.Forms.Button btnConverter;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.RadioButton rdBtnToneladasMetricas;
		private System.Windows.Forms.GroupBox gpBoxUnidadeMinerais;
		private System.Windows.Forms.RadioButton rdBtnToneladasImperais;
		private System.Windows.Forms.RadioButton rdBtnToneladasCurtas;
		private System.Windows.Forms.RadioButton rdBtnOncas;
		private System.Windows.Forms.RadioButton rdBtnLibras;
		private System.Windows.Forms.RadioButton rdBtnMegatons;
		private System.Windows.Forms.GroupBox gpBoxGrauMineral;
		private System.Windows.Forms.RadioButton rdBtnGramasToneladasCurtas;
		private System.Windows.Forms.RadioButton rdBtnGramasToneladaPPM;
		private System.Windows.Forms.RadioButton rdBtnPorcentagem;
		private System.Windows.Forms.RadioButton rdBtnGramasOnca;
		private System.Windows.Forms.RadioButton rdBtnOncasTroy;
		private System.Windows.Forms.RadioButton rdBtnGramasOncaTroy;
	}
}

