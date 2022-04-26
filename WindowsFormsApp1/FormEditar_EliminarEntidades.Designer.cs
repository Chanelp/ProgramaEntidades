
namespace WindowsFormsApp1
{
    partial class FormEditar_EliminarEntidades
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
            this.DgvEntidades = new System.Windows.Forms.DataGridView();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLocalidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbEntidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.TxtNumDoc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtLimite = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbRol = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CkbYes = new System.Windows.Forms.CheckBox();
            this.CkbNo = new System.Windows.Forms.CheckBox();
            this.TxtPaginaWeb = new System.Windows.Forms.TextBox();
            this.TxtTikTok = new System.Windows.Forms.TextBox();
            this.TxtTwitter = new System.Windows.Forms.TextBox();
            this.TxtInstagram = new System.Windows.Forms.TextBox();
            this.TxtFacebook = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtComentarios = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEntidades)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvEntidades
            // 
            this.DgvEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEntidades.Location = new System.Drawing.Point(16, 15);
            this.DgvEntidades.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvEntidades.Name = "DgvEntidades";
            this.DgvEntidades.RowHeadersWidth = 51;
            this.DgvEntidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEntidades.Size = new System.Drawing.Size(617, 526);
            this.DgvEntidades.TabIndex = 0;
            this.DgvEntidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEntidades_CellClick);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.Location = new System.Drawing.Point(981, 483);
            this.BtnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(184, 58);
            this.BtnEditar.TabIndex = 1;
            this.BtnEditar.Text = "Actualizar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(686, 483);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(199, 58);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripcion";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(725, 17);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(160, 22);
            this.TxtDescripcion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Direccion";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(725, 56);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(160, 22);
            this.TxtDireccion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Localidad";
            // 
            // TxtLocalidad
            // 
            this.TxtLocalidad.Location = new System.Drawing.Point(725, 88);
            this.TxtLocalidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtLocalidad.Name = "TxtLocalidad";
            this.TxtLocalidad.Size = new System.Drawing.Size(160, 22);
            this.TxtLocalidad.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(661, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Entidad";
            // 
            // CmbEntidad
            // 
            this.CmbEntidad.FormattingEnabled = true;
            this.CmbEntidad.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.CmbEntidad.Location = new System.Drawing.Point(725, 126);
            this.CmbEntidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbEntidad.Name = "CmbEntidad";
            this.CmbEntidad.Size = new System.Drawing.Size(160, 24);
            this.CmbEntidad.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(638, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Documento";
            // 
            // CmbTipoDoc
            // 
            this.CmbTipoDoc.FormattingEnabled = true;
            this.CmbTipoDoc.Items.AddRange(new object[] {
            "RNC",
            "Cédula",
            "Pasaporte"});
            this.CmbTipoDoc.Location = new System.Drawing.Point(722, 166);
            this.CmbTipoDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbTipoDoc.Name = "CmbTipoDoc";
            this.CmbTipoDoc.Size = new System.Drawing.Size(61, 24);
            this.CmbTipoDoc.TabIndex = 12;
            // 
            // TxtNumDoc
            // 
            this.TxtNumDoc.Location = new System.Drawing.Point(791, 166);
            this.TxtNumDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNumDoc.Name = "TxtNumDoc";
            this.TxtNumDoc.Size = new System.Drawing.Size(106, 22);
            this.TxtNumDoc.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(663, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Usuario";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(725, 205);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(160, 22);
            this.TxtUsuario.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(641, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Contraseña";
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(725, 250);
            this.TxtPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(160, 22);
            this.TxtPass.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(675, 296);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Limite";
            // 
            // TxtLimite
            // 
            this.TxtLimite.Location = new System.Drawing.Point(725, 290);
            this.TxtLimite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtLimite.Name = "TxtLimite";
            this.TxtLimite.Size = new System.Drawing.Size(160, 22);
            this.TxtLimite.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(686, 336);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Rol";
            // 
            // CmbRol
            // 
            this.CmbRol.FormattingEnabled = true;
            this.CmbRol.Items.AddRange(new object[] {
            "Admin",
            "Supervisor",
            "User"});
            this.CmbRol.Location = new System.Drawing.Point(725, 328);
            this.CmbRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbRol.Name = "CmbRol";
            this.CmbRol.Size = new System.Drawing.Size(160, 24);
            this.CmbRol.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(670, 377);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Status";
            // 
            // CmbStatus
            // 
            this.CmbStatus.FormattingEnabled = true;
            this.CmbStatus.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.CmbStatus.Location = new System.Drawing.Point(725, 377);
            this.CmbStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbStatus.Name = "CmbStatus";
            this.CmbStatus.Size = new System.Drawing.Size(160, 24);
            this.CmbStatus.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(644, 417);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Eliminable";
            // 
            // CkbYes
            // 
            this.CkbYes.AutoSize = true;
            this.CkbYes.Location = new System.Drawing.Point(730, 418);
            this.CkbYes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CkbYes.Name = "CkbYes";
            this.CkbYes.Size = new System.Drawing.Size(41, 20);
            this.CkbYes.TabIndex = 41;
            this.CkbYes.Text = "Si";
            this.CkbYes.UseVisualStyleBackColor = true;
            this.CkbYes.CheckedChanged += new System.EventHandler(this.CkbYes_CheckedChanged);
            // 
            // CkbNo
            // 
            this.CkbNo.AutoSize = true;
            this.CkbNo.Location = new System.Drawing.Point(779, 418);
            this.CkbNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CkbNo.Name = "CkbNo";
            this.CkbNo.Size = new System.Drawing.Size(47, 20);
            this.CkbNo.TabIndex = 42;
            this.CkbNo.Text = "No";
            this.CkbNo.UseVisualStyleBackColor = true;
            this.CkbNo.CheckedChanged += new System.EventHandler(this.CkbNo_CheckedChanged);
            // 
            // TxtPaginaWeb
            // 
            this.TxtPaginaWeb.Location = new System.Drawing.Point(1005, 17);
            this.TxtPaginaWeb.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPaginaWeb.Name = "TxtPaginaWeb";
            this.TxtPaginaWeb.Size = new System.Drawing.Size(160, 22);
            this.TxtPaginaWeb.TabIndex = 43;
            // 
            // TxtTikTok
            // 
            this.TxtTikTok.Location = new System.Drawing.Point(1005, 166);
            this.TxtTikTok.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTikTok.Name = "TxtTikTok";
            this.TxtTikTok.Size = new System.Drawing.Size(160, 22);
            this.TxtTikTok.TabIndex = 44;
            // 
            // TxtTwitter
            // 
            this.TxtTwitter.Location = new System.Drawing.Point(1005, 126);
            this.TxtTwitter.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTwitter.Name = "TxtTwitter";
            this.TxtTwitter.Size = new System.Drawing.Size(160, 22);
            this.TxtTwitter.TabIndex = 45;
            // 
            // TxtInstagram
            // 
            this.TxtInstagram.Location = new System.Drawing.Point(1005, 91);
            this.TxtInstagram.Margin = new System.Windows.Forms.Padding(4);
            this.TxtInstagram.Name = "TxtInstagram";
            this.TxtInstagram.Size = new System.Drawing.Size(160, 22);
            this.TxtInstagram.TabIndex = 46;
            // 
            // TxtFacebook
            // 
            this.TxtFacebook.Location = new System.Drawing.Point(1005, 59);
            this.TxtFacebook.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFacebook.Name = "TxtFacebook";
            this.TxtFacebook.Size = new System.Drawing.Size(160, 22);
            this.TxtFacebook.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(905, 205);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 48;
            this.label12.Text = "Comentarios";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(905, 169);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 49;
            this.label13.Text = "TikTok";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(905, 129);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 16);
            this.label14.TabIndex = 50;
            this.label14.Text = "Twitter";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(905, 94);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 16);
            this.label15.TabIndex = 51;
            this.label15.Text = "Instagram";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(905, 62);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 16);
            this.label16.TabIndex = 52;
            this.label16.Text = "Facebook";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(905, 17);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 16);
            this.label17.TabIndex = 53;
            this.label17.Text = "Pagina Web";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // TxtComentarios
            // 
            this.TxtComentarios.Location = new System.Drawing.Point(1005, 202);
            this.TxtComentarios.Name = "TxtComentarios";
            this.TxtComentarios.Size = new System.Drawing.Size(160, 166);
            this.TxtComentarios.TabIndex = 54;
            this.TxtComentarios.Text = "";
            // 
            // FormEditar_EliminarEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 554);
            this.Controls.Add(this.TxtComentarios);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtFacebook);
            this.Controls.Add(this.TxtInstagram);
            this.Controls.Add(this.TxtTwitter);
            this.Controls.Add(this.TxtTikTok);
            this.Controls.Add(this.TxtPaginaWeb);
            this.Controls.Add(this.CkbNo);
            this.Controls.Add(this.CkbYes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CmbStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CmbRol);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtLimite);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtNumDoc);
            this.Controls.Add(this.CmbTipoDoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbEntidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtLocalidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.DgvEntidades);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEditar_EliminarEntidades";
            this.Text = "FormEditar_EliminarEntidades";
            this.Load += new System.EventHandler(this.FormEditar_EliminarEntidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEntidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEntidades;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtLocalidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbEntidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbTipoDoc;
        private System.Windows.Forms.MaskedTextBox TxtNumDoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtLimite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbRol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox CkbYes;
        private System.Windows.Forms.CheckBox CkbNo;
        private System.Windows.Forms.TextBox TxtPaginaWeb;
        private System.Windows.Forms.TextBox TxtTikTok;
        private System.Windows.Forms.TextBox TxtTwitter;
        private System.Windows.Forms.TextBox TxtInstagram;
        private System.Windows.Forms.TextBox TxtFacebook;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox TxtComentarios;
    }
}