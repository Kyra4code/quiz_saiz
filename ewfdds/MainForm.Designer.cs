/*
 * Created by SharpDevelop.
 * User: aluno
 * Date: 14/05/2024
 * Time: 19:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ewfdds
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelPontos;
		private System.Windows.Forms.Button buttomReiniciar;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelPergunta;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonB;
		private System.Windows.Forms.Button buttonC;
		private System.Windows.Forms.Button buttonD;
		private System.Windows.Forms.Label labelD;
		private System.Windows.Forms.Label labelC;
		private System.Windows.Forms.Label labelB;
		private System.Windows.Forms.Label labelA;
		private System.Windows.Forms.Button buttonA;
		private System.Windows.Forms.Button buttonfinalizar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelPontos = new System.Windows.Forms.Label();
			this.buttomReiniciar = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelPergunta = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonB = new System.Windows.Forms.Button();
			this.buttonC = new System.Windows.Forms.Button();
			this.buttonD = new System.Windows.Forms.Button();
			this.labelD = new System.Windows.Forms.Label();
			this.labelC = new System.Windows.Forms.Label();
			this.labelB = new System.Windows.Forms.Label();
			this.labelA = new System.Windows.Forms.Label();
			this.buttonA = new System.Windows.Forms.Button();
			this.buttonfinalizar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelPontos
			// 
			this.labelPontos.AutoSize = true;
			this.labelPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPontos.Location = new System.Drawing.Point(669, 334);
			this.labelPontos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPontos.Name = "labelPontos";
			this.labelPontos.Size = new System.Drawing.Size(64, 17);
			this.labelPontos.TabIndex = 29;
			this.labelPontos.Text = "Pontos:0";
			// 
			// buttomReiniciar
			// 
			this.buttomReiniciar.Enabled = false;
			this.buttomReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttomReiniciar.Location = new System.Drawing.Point(753, 344);
			this.buttomReiniciar.Margin = new System.Windows.Forms.Padding(2);
			this.buttomReiniciar.Name = "buttomReiniciar";
			this.buttomReiniciar.Size = new System.Drawing.Size(94, 29);
			this.buttomReiniciar.TabIndex = 27;
			this.buttomReiniciar.Text = "Reiniciar";
			this.buttomReiniciar.UseVisualStyleBackColor = true;
			this.buttomReiniciar.Click += new System.EventHandler(this.ButtomReiniciarClick);
			// 
			// button10
			// 
			this.button10.Enabled = false;
			this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button10.Location = new System.Drawing.Point(578, 318);
			this.button10.Margin = new System.Windows.Forms.Padding(2);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(55, 46);
			this.button10.TabIndex = 26;
			this.button10.Text = "10";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// button9
			// 
			this.button9.Enabled = false;
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(519, 318);
			this.button9.Margin = new System.Windows.Forms.Padding(2);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(55, 46);
			this.button9.TabIndex = 25;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// button8
			// 
			this.button8.Enabled = false;
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(459, 318);
			this.button8.Margin = new System.Windows.Forms.Padding(2);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(55, 46);
			this.button8.TabIndex = 24;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button7
			// 
			this.button7.Enabled = false;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(400, 318);
			this.button7.Margin = new System.Windows.Forms.Padding(2);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(55, 46);
			this.button7.TabIndex = 23;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button6
			// 
			this.button6.Enabled = false;
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(341, 318);
			this.button6.Margin = new System.Windows.Forms.Padding(2);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(55, 46);
			this.button6.TabIndex = 22;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button5
			// 
			this.button5.Enabled = false;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(276, 318);
			this.button5.Margin = new System.Windows.Forms.Padding(2);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(61, 46);
			this.button5.TabIndex = 21;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button4
			// 
			this.button4.Enabled = false;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(217, 318);
			this.button4.Margin = new System.Windows.Forms.Padding(2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(55, 46);
			this.button4.TabIndex = 20;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.Enabled = false;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(157, 318);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(55, 46);
			this.button3.TabIndex = 19;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(98, 318);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(55, 46);
			this.button2.TabIndex = 18;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(39, 318);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(55, 46);
			this.button1.TabIndex = 17;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.labelPergunta);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.buttonB);
			this.panel1.Controls.Add(this.buttonC);
			this.panel1.Controls.Add(this.buttonD);
			this.panel1.Controls.Add(this.labelD);
			this.panel1.Controls.Add(this.labelC);
			this.panel1.Controls.Add(this.labelB);
			this.panel1.Controls.Add(this.labelA);
			this.panel1.Controls.Add(this.buttonA);
			this.panel1.Enabled = false;
			this.panel1.Location = new System.Drawing.Point(36, 9);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(811, 278);
			this.panel1.TabIndex = 28;
			// 
			// labelPergunta
			// 
			this.labelPergunta.AutoSize = true;
			this.labelPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPergunta.Location = new System.Drawing.Point(27, 13);
			this.labelPergunta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPergunta.Name = "labelPergunta";
			this.labelPergunta.Size = new System.Drawing.Size(20, 17);
			this.labelPergunta.TabIndex = 17;
			this.labelPergunta.Text = "1.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(541, 46);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(228, 208);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// buttonB
			// 
			this.buttonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonB.Location = new System.Drawing.Point(8, 108);
			this.buttonB.Margin = new System.Windows.Forms.Padding(2);
			this.buttonB.Name = "buttonB";
			this.buttonB.Size = new System.Drawing.Size(55, 46);
			this.buttonB.TabIndex = 11;
			this.buttonB.Text = "B";
			this.buttonB.UseVisualStyleBackColor = true;
			this.buttonB.Click += new System.EventHandler(this.ButtonBClick);
			// 
			// buttonC
			// 
			this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonC.Location = new System.Drawing.Point(8, 158);
			this.buttonC.Margin = new System.Windows.Forms.Padding(2);
			this.buttonC.Name = "buttonC";
			this.buttonC.Size = new System.Drawing.Size(55, 46);
			this.buttonC.TabIndex = 12;
			this.buttonC.Text = "C";
			this.buttonC.UseVisualStyleBackColor = true;
			this.buttonC.Click += new System.EventHandler(this.ButtonCClick);
			// 
			// buttonD
			// 
			this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonD.Location = new System.Drawing.Point(8, 208);
			this.buttonD.Margin = new System.Windows.Forms.Padding(2);
			this.buttonD.Name = "buttonD";
			this.buttonD.Size = new System.Drawing.Size(55, 46);
			this.buttonD.TabIndex = 13;
			this.buttonD.Text = "D";
			this.buttonD.UseVisualStyleBackColor = true;
			this.buttonD.Click += new System.EventHandler(this.ButtonDClick);
			// 
			// labelD
			// 
			this.labelD.AutoSize = true;
			this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelD.Location = new System.Drawing.Point(76, 224);
			this.labelD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelD.Name = "labelD";
			this.labelD.Size = new System.Drawing.Size(16, 17);
			this.labelD.TabIndex = 4;
			this.labelD.Text = "?";
			// 
			// labelC
			// 
			this.labelC.AutoSize = true;
			this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelC.Location = new System.Drawing.Point(76, 174);
			this.labelC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelC.Name = "labelC";
			this.labelC.Size = new System.Drawing.Size(16, 17);
			this.labelC.TabIndex = 3;
			this.labelC.Text = "?";
			// 
			// labelB
			// 
			this.labelB.AutoSize = true;
			this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelB.Location = new System.Drawing.Point(76, 124);
			this.labelB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelB.Name = "labelB";
			this.labelB.Size = new System.Drawing.Size(16, 17);
			this.labelB.TabIndex = 2;
			this.labelB.Text = "?";
			// 
			// labelA
			// 
			this.labelA.AutoSize = true;
			this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelA.Location = new System.Drawing.Point(76, 68);
			this.labelA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelA.Name = "labelA";
			this.labelA.Size = new System.Drawing.Size(16, 17);
			this.labelA.TabIndex = 0;
			this.labelA.Text = "?";
			// 
			// buttonA
			// 
			this.buttonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonA.Location = new System.Drawing.Point(8, 58);
			this.buttonA.Margin = new System.Windows.Forms.Padding(2);
			this.buttonA.Name = "buttonA";
			this.buttonA.Size = new System.Drawing.Size(55, 46);
			this.buttonA.TabIndex = 10;
			this.buttonA.Text = "A";
			this.buttonA.UseVisualStyleBackColor = true;
			this.buttonA.Click += new System.EventHandler(this.ButtonAClick);
			// 
			// buttonfinalizar
			// 
			this.buttonfinalizar.Enabled = false;
			this.buttonfinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonfinalizar.Location = new System.Drawing.Point(753, 305);
			this.buttonfinalizar.Margin = new System.Windows.Forms.Padding(2);
			this.buttonfinalizar.Name = "buttonfinalizar";
			this.buttonfinalizar.Size = new System.Drawing.Size(94, 29);
			this.buttonfinalizar.TabIndex = 30;
			this.buttonfinalizar.Text = "Finalizar";
			this.buttonfinalizar.UseVisualStyleBackColor = true;
			this.buttonfinalizar.Click += new System.EventHandler(this.ButtonfinalizarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(927, 381);
			this.Controls.Add(this.buttonfinalizar);
			this.Controls.Add(this.labelPontos);
			this.Controls.Add(this.buttomReiniciar);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "Quiz da História dos computadores";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
