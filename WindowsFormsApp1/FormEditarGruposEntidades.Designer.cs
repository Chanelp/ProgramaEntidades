
namespace WindowsFormsApp1
{
    partial class FormEditarGruposEntidades
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
            this.DgvGruposEntidades = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtComentario = new System.Windows.Forms.TextBox();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGruposEntidades)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvGruposEntidades
            // 
            this.DgvGruposEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvGruposEntidades.Location = new System.Drawing.Point(16, 15);
            this.DgvGruposEntidades.Margin = new System.Windows.Forms.Padding(4);
            this.DgvGruposEntidades.Name = "DgvGruposEntidades";
            this.DgvGruposEntidades.RowHeadersWidth = 51;
            this.DgvGruposEntidades.Size = new System.Drawing.Size(547, 502);
            this.DgvGruposEntidades.TabIndex = 0;
            this.DgvGruposEntidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGruposEntidades_CellClick);
            this.DgvGruposEntidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGruposEntidades_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Comentario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(571, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Status";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(658, 75);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(132, 22);
            this.TxtDescripcion.TabIndex = 6;
            // 
            // TxtComentario
            // 
            this.TxtComentario.Location = new System.Drawing.Point(658, 105);
            this.TxtComentario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtComentario.Name = "TxtComentario";
            this.TxtComentario.Size = new System.Drawing.Size(132, 22);
            this.TxtComentario.TabIndex = 8;
            // 
            // CmbStatus
            // 
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.CmbStatus.Location = new System.Drawing.Point(630, 135);
            this.CmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(160, 24);
            this.CmbStatus.TabIndex = 9;
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(574, 210);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(103, 39);
            this.BtnEditar.TabIndex = 10;
            this.BtnEditar.Text = "Actualizar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEditarGruposEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.CmbStatus);
            this.Controls.Add(this.TxtComentario);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvGruposEntidades);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEditarGruposEntidades";
            this.Text = "FormEditarGruposEntidades";
            this.Load += new System.EventHandler(this.FormEditarGruposEntidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGruposEntidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvGruposEntidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtComentario;
        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button button1;
    }
}