namespace TelephoneSystem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgbMostrar = new System.Windows.Forms.DataGridView();
            this.Enlace = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblReloj = new System.Windows.Forms.Label();
            this.txtNumEnlace = new System.Windows.Forms.TextBox();
            this.txtNumLlama = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Relog = new System.Windows.Forms.Timer(this.components);
            this.Proceso = new System.Windows.Forms.Timer(this.components);
            this.Restar = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProcessed = new System.Windows.Forms.TextBox();
            this.txtCompleted = new System.Windows.Forms.TextBox();
            this.txtBlocked = new System.Windows.Forms.TextBox();
            this.txtBusy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalTime = new System.Windows.Forms.TextBox();
            this.txtOtrher = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgbMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbMostrar
            // 
            this.dgbMostrar.AllowUserToAddRows = false;
            this.dgbMostrar.AllowUserToDeleteRows = false;
            this.dgbMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Enlace,
            this.Origen,
            this.Destino,
            this.Duracion});
            this.dgbMostrar.Location = new System.Drawing.Point(46, 30);
            this.dgbMostrar.Name = "dgbMostrar";
            this.dgbMostrar.ReadOnly = true;
            this.dgbMostrar.Size = new System.Drawing.Size(449, 210);
            this.dgbMostrar.TabIndex = 0;
            // 
            // Enlace
            // 
            this.Enlace.HeaderText = "Enlace";
            this.Enlace.Name = "Enlace";
            this.Enlace.ReadOnly = true;
            // 
            // Origen
            // 
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            // 
            // Duracion
            // 
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.Location = new System.Drawing.Point(12, 9);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(0, 13);
            this.lblReloj.TabIndex = 5;
            // 
            // txtNumEnlace
            // 
            this.txtNumEnlace.Location = new System.Drawing.Point(21, 296);
            this.txtNumEnlace.Name = "txtNumEnlace";
            this.txtNumEnlace.Size = new System.Drawing.Size(75, 20);
            this.txtNumEnlace.TabIndex = 6;
            // 
            // txtNumLlama
            // 
            this.txtNumLlama.Location = new System.Drawing.Point(381, 2);
            this.txtNumLlama.Name = "txtNumLlama";
            this.txtNumLlama.Size = new System.Drawing.Size(83, 20);
            this.txtNumLlama.TabIndex = 7;
            this.txtNumLlama.Text = "100";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.DarkGray;
            this.btnPlay.Location = new System.Drawing.Point(128, 243);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(72, 23);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Comenzar";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(128, 272);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(72, 21);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Detenerse";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numero de Enlaces";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Numero de llamadas:";
            // 
            // Relog
            // 
            this.Relog.Enabled = true;
            this.Relog.Tick += new System.EventHandler(this.Relog_Tick);
            // 
            // Proceso
            // 
            this.Proceso.Interval = 1000;
            this.Proceso.Tick += new System.EventHandler(this.Proceso_Tick);
            // 
            // Restar
            // 
            this.Restar.Interval = 250;
            this.Restar.Tick += new System.EventHandler(this.Restar_Tick);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(128, 299);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(72, 23);
            this.btnPause.TabIndex = 12;
            this.btnPause.Text = "Pausa";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.Location = new System.Drawing.Point(128, 328);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(71, 22);
            this.btnContinue.TabIndex = 13;
            this.btnContinue.Text = "Continuar";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Procesadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Completadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bloqueadas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ocupadas";
            // 
            // txtProcessed
            // 
            this.txtProcessed.Location = new System.Drawing.Point(216, 259);
            this.txtProcessed.Name = "txtProcessed";
            this.txtProcessed.ReadOnly = true;
            this.txtProcessed.Size = new System.Drawing.Size(81, 20);
            this.txtProcessed.TabIndex = 18;
            // 
            // txtCompleted
            // 
            this.txtCompleted.Location = new System.Drawing.Point(216, 323);
            this.txtCompleted.Name = "txtCompleted";
            this.txtCompleted.ReadOnly = true;
            this.txtCompleted.Size = new System.Drawing.Size(81, 20);
            this.txtCompleted.TabIndex = 19;
            // 
            // txtBlocked
            // 
            this.txtBlocked.Location = new System.Drawing.Point(321, 260);
            this.txtBlocked.Name = "txtBlocked";
            this.txtBlocked.ReadOnly = true;
            this.txtBlocked.Size = new System.Drawing.Size(81, 20);
            this.txtBlocked.TabIndex = 20;
            // 
            // txtBusy
            // 
            this.txtBusy.Location = new System.Drawing.Point(321, 323);
            this.txtBusy.Name = "txtBusy";
            this.txtBusy.ReadOnly = true;
            this.txtBusy.Size = new System.Drawing.Size(80, 20);
            this.txtBusy.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tiempo por enlace";
            // 
            // txtTotalTime
            // 
            this.txtTotalTime.Location = new System.Drawing.Point(434, 280);
            this.txtTotalTime.Name = "txtTotalTime";
            this.txtTotalTime.ReadOnly = true;
            this.txtTotalTime.Size = new System.Drawing.Size(61, 20);
            this.txtTotalTime.TabIndex = 23;
            // 
            // txtOtrher
            // 
            this.txtOtrher.Location = new System.Drawing.Point(440, 330);
            this.txtOtrher.Name = "txtOtrher";
            this.txtOtrher.ReadOnly = true;
            this.txtOtrher.Size = new System.Drawing.Size(56, 20);
            this.txtOtrher.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Timpo total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(528, 355);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOtrher);
            this.Controls.Add(this.txtTotalTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBusy);
            this.Controls.Add(this.txtBlocked);
            this.Controls.Add(this.txtCompleted);
            this.Controls.Add(this.txtProcessed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtNumLlama);
            this.Controls.Add(this.txtNumEnlace);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.dgbMostrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sistema Telefonico";
            ((System.ComponentModel.ISupportInitialize)(this.dgbMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbMostrar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Enlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.TextBox txtNumEnlace;
        private System.Windows.Forms.TextBox txtNumLlama;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Relog;
        private System.Windows.Forms.Timer Proceso;
        private System.Windows.Forms.Timer Restar;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProcessed;
        private System.Windows.Forms.TextBox txtCompleted;
        private System.Windows.Forms.TextBox txtBlocked;
        private System.Windows.Forms.TextBox txtBusy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalTime;
        private System.Windows.Forms.TextBox txtOtrher;
        private System.Windows.Forms.Label label8;
    }
}

