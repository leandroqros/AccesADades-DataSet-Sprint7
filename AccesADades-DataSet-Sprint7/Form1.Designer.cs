
namespace AccesADades_DataSet_Sprint7
{
    partial class Password
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbPass = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.bntVT = new System.Windows.Forms.Button();
            this.dtgMain = new System.Windows.Forms.DataGridView();
            this.txtbNom = new System.Windows.Forms.TextBox();
            this.bntAtt = new System.Windows.Forms.Button();
            this.lblTabla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbPass
            // 
            this.txtbPass.Location = new System.Drawing.Point(315, 108);
            this.txtbPass.Name = "txtbPass";
            this.txtbPass.Size = new System.Drawing.Size(170, 20);
            this.txtbPass.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(116, 85);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(84, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Tipo de Especie";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(312, 85);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(119, 13);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Descripcion de Especie";
            // 
            // bntVT
            // 
            this.bntVT.Location = new System.Drawing.Point(119, 27);
            this.bntVT.Name = "bntVT";
            this.bntVT.Size = new System.Drawing.Size(108, 34);
            this.bntVT.TabIndex = 4;
            this.bntVT.Text = "Vizualizar";
            this.bntVT.UseVisualStyleBackColor = true;
            this.bntVT.Click += new System.EventHandler(this.bntVT_Click);
            // 
            // dtgMain
            // 
            this.dtgMain.AllowUserToAddRows = false;
            this.dtgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMain.Location = new System.Drawing.Point(12, 140);
            this.dtgMain.Name = "dtgMain";
            this.dtgMain.ReadOnly = true;
            this.dtgMain.Size = new System.Drawing.Size(776, 298);
            this.dtgMain.TabIndex = 5;
            // 
            // txtbNom
            // 
            this.txtbNom.Location = new System.Drawing.Point(119, 111);
            this.txtbNom.Name = "txtbNom";
            this.txtbNom.Size = new System.Drawing.Size(170, 20);
            this.txtbNom.TabIndex = 6;
            // 
            // bntAtt
            // 
            this.bntAtt.Location = new System.Drawing.Point(233, 27);
            this.bntAtt.Name = "bntAtt";
            this.bntAtt.Size = new System.Drawing.Size(108, 34);
            this.bntAtt.TabIndex = 7;
            this.bntAtt.Text = "Actualizar";
            this.bntAtt.UseVisualStyleBackColor = true;
            this.bntAtt.Click += new System.EventHandler(this.bntAtt_Click);
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Location = new System.Drawing.Point(19, 38);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(94, 13);
            this.lblTabla.TabIndex = 8;
            this.lblTabla.Text = "Botones de Tabla:";
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.bntAtt);
            this.Controls.Add(this.dtgMain);
            this.Controls.Add(this.txtbNom);
            this.Controls.Add(this.bntVT);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtbPass);
            this.Name = "Password";
            this.Text = "lblPass";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbPass;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button bntVT;
        private System.Windows.Forms.DataGridView dtgMain;
        private System.Windows.Forms.TextBox txtbNom;
        private System.Windows.Forms.Button bntAtt;
        private System.Windows.Forms.Label lblTabla;
    }
}

