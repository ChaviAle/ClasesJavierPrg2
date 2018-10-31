namespace EjerciciosClase
{
    partial class FormAdmProv
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
            this.txcodigo = new System.Windows.Forms.TextBox();
            this.txnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbmensaje = new System.Windows.Forms.Label();
            this.btgrabar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txcodigo
            // 
            this.txcodigo.Location = new System.Drawing.Point(145, 56);
            this.txcodigo.Name = "txcodigo";
            this.txcodigo.Size = new System.Drawing.Size(100, 20);
            this.txcodigo.TabIndex = 0;
            // 
            // txnombre
            // 
            this.txnombre.Location = new System.Drawing.Point(145, 95);
            this.txnombre.Name = "txnombre";
            this.txnombre.Size = new System.Drawing.Size(100, 20);
            this.txnombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // lbmensaje
            // 
            this.lbmensaje.AutoSize = true;
            this.lbmensaje.Location = new System.Drawing.Point(35, 301);
            this.lbmensaje.Name = "lbmensaje";
            this.lbmensaje.Size = new System.Drawing.Size(0, 13);
            this.lbmensaje.TabIndex = 4;
            // 
            // btgrabar
            // 
            this.btgrabar.Location = new System.Drawing.Point(48, 174);
            this.btgrabar.Name = "btgrabar";
            this.btgrabar.Size = new System.Drawing.Size(75, 23);
            this.btgrabar.TabIndex = 5;
            this.btgrabar.Text = "Grabar";
            this.btgrabar.UseVisualStyleBackColor = true;
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(156, 174);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 6;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(307, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(309, 336);
            this.dataGridView1.TabIndex = 7;
            // 
            // FormAdmProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 465);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.btgrabar);
            this.Controls.Add(this.lbmensaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txnombre);
            this.Controls.Add(this.txcodigo);
            this.Name = "FormAdmProv";
            this.Text = "FormAdmProv";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txcodigo;
        private System.Windows.Forms.TextBox txnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbmensaje;
        private System.Windows.Forms.Button btgrabar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}