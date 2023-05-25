namespace AppVeterinaria
{
    partial class Principal
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDueños = new System.Windows.Forms.TabPage();
            this.btnCancelarDueño = new System.Windows.Forms.Button();
            this.btnGuardarDueño = new System.Windows.Forms.Button();
            this.txtTelefonoDueño = new System.Windows.Forms.TextBox();
            this.txtDireccionDueño = new System.Windows.Forms.TextBox();
            this.txtNombreDueño = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageMascotas = new System.Windows.Forms.TabPage();
            this.cbDueños = new System.Windows.Forms.ComboBox();
            this.btnCancelarRegistro = new System.Windows.Forms.Button();
            this.btnRegistrarMascota = new System.Windows.Forms.Button();
            this.txtRazaMascota = new System.Windows.Forms.TextBox();
            this.txtEdadMascota = new System.Windows.Forms.TextBox();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageBusqueda = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPageListDueños = new System.Windows.Forms.TabPage();
            this.tabPageListMascotas = new System.Windows.Forms.TabPage();
            this.listViewDueños = new System.Windows.Forms.ListView();
            this.chNombreDueño = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDireccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTelefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewMascotas = new System.Windows.Forms.ListView();
            this.chNombreMascota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEdadMascota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRazaMascota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDueñoMascota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label12 = new System.Windows.Forms.Label();
            this.txtMostrarNombreDueño = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMostrarDireccion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMostrarTelefono = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMostrarNombreMascota = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMostrarEdad = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMostrarRaza = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageDueños.SuspendLayout();
            this.tabPageMascotas.SuspendLayout();
            this.tabPageBusqueda.SuspendLayout();
            this.tabPageListDueños.SuspendLayout();
            this.tabPageListMascotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageDueños);
            this.tabControl.Controls.Add(this.tabPageMascotas);
            this.tabControl.Controls.Add(this.tabPageBusqueda);
            this.tabControl.Controls.Add(this.tabPageListDueños);
            this.tabControl.Controls.Add(this.tabPageListMascotas);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(445, 328);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageDueños
            // 
            this.tabPageDueños.Controls.Add(this.btnCancelarDueño);
            this.tabPageDueños.Controls.Add(this.btnGuardarDueño);
            this.tabPageDueños.Controls.Add(this.txtTelefonoDueño);
            this.tabPageDueños.Controls.Add(this.txtDireccionDueño);
            this.tabPageDueños.Controls.Add(this.txtNombreDueño);
            this.tabPageDueños.Controls.Add(this.label5);
            this.tabPageDueños.Controls.Add(this.label4);
            this.tabPageDueños.Controls.Add(this.label3);
            this.tabPageDueños.Controls.Add(this.label1);
            this.tabPageDueños.Location = new System.Drawing.Point(4, 22);
            this.tabPageDueños.Name = "tabPageDueños";
            this.tabPageDueños.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDueños.Size = new System.Drawing.Size(437, 302);
            this.tabPageDueños.TabIndex = 0;
            this.tabPageDueños.Text = "Dueños";
            this.tabPageDueños.UseVisualStyleBackColor = true;
            // 
            // btnCancelarDueño
            // 
            this.btnCancelarDueño.Location = new System.Drawing.Point(223, 189);
            this.btnCancelarDueño.Name = "btnCancelarDueño";
            this.btnCancelarDueño.Size = new System.Drawing.Size(94, 23);
            this.btnCancelarDueño.TabIndex = 8;
            this.btnCancelarDueño.Text = "Cancelar";
            this.btnCancelarDueño.UseVisualStyleBackColor = true;
            // 
            // btnGuardarDueño
            // 
            this.btnGuardarDueño.Location = new System.Drawing.Point(126, 189);
            this.btnGuardarDueño.Name = "btnGuardarDueño";
            this.btnGuardarDueño.Size = new System.Drawing.Size(91, 23);
            this.btnGuardarDueño.TabIndex = 7;
            this.btnGuardarDueño.Text = "Guardar";
            this.btnGuardarDueño.UseVisualStyleBackColor = true;
            this.btnGuardarDueño.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTelefonoDueño
            // 
            this.txtTelefonoDueño.Location = new System.Drawing.Point(183, 148);
            this.txtTelefonoDueño.Name = "txtTelefonoDueño";
            this.txtTelefonoDueño.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoDueño.TabIndex = 6;
            // 
            // txtDireccionDueño
            // 
            this.txtDireccionDueño.Location = new System.Drawing.Point(183, 119);
            this.txtDireccionDueño.Name = "txtDireccionDueño";
            this.txtDireccionDueño.Size = new System.Drawing.Size(122, 20);
            this.txtDireccionDueño.TabIndex = 5;
            // 
            // txtNombreDueño
            // 
            this.txtNombreDueño.Location = new System.Drawing.Point(183, 92);
            this.txtNombreDueño.Name = "txtNombreDueño";
            this.txtNombreDueño.Size = new System.Drawing.Size(134, 20);
            this.txtNombreDueño.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro del dueño";
            // 
            // tabPageMascotas
            // 
            this.tabPageMascotas.Controls.Add(this.cbDueños);
            this.tabPageMascotas.Controls.Add(this.btnCancelarRegistro);
            this.tabPageMascotas.Controls.Add(this.btnRegistrarMascota);
            this.tabPageMascotas.Controls.Add(this.txtRazaMascota);
            this.tabPageMascotas.Controls.Add(this.txtEdadMascota);
            this.tabPageMascotas.Controls.Add(this.txtNombreMascota);
            this.tabPageMascotas.Controls.Add(this.label9);
            this.tabPageMascotas.Controls.Add(this.label8);
            this.tabPageMascotas.Controls.Add(this.label7);
            this.tabPageMascotas.Controls.Add(this.label6);
            this.tabPageMascotas.Controls.Add(this.label2);
            this.tabPageMascotas.Location = new System.Drawing.Point(4, 22);
            this.tabPageMascotas.Name = "tabPageMascotas";
            this.tabPageMascotas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMascotas.Size = new System.Drawing.Size(437, 302);
            this.tabPageMascotas.TabIndex = 1;
            this.tabPageMascotas.Text = "Mascotas";
            this.tabPageMascotas.UseVisualStyleBackColor = true;
            this.tabPageMascotas.Enter += new System.EventHandler(this.tabPageMascotas_FocusEnter);
            // 
            // cbDueños
            // 
            this.cbDueños.FormattingEnabled = true;
            this.cbDueños.Location = new System.Drawing.Point(177, 160);
            this.cbDueños.Name = "cbDueños";
            this.cbDueños.Size = new System.Drawing.Size(136, 21);
            this.cbDueños.TabIndex = 11;
            // 
            // btnCancelarRegistro
            // 
            this.btnCancelarRegistro.Location = new System.Drawing.Point(224, 197);
            this.btnCancelarRegistro.Name = "btnCancelarRegistro";
            this.btnCancelarRegistro.Size = new System.Drawing.Size(89, 23);
            this.btnCancelarRegistro.TabIndex = 10;
            this.btnCancelarRegistro.Text = "Cancelar";
            this.btnCancelarRegistro.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarMascota
            // 
            this.btnRegistrarMascota.Location = new System.Drawing.Point(126, 197);
            this.btnRegistrarMascota.Name = "btnRegistrarMascota";
            this.btnRegistrarMascota.Size = new System.Drawing.Size(92, 23);
            this.btnRegistrarMascota.TabIndex = 9;
            this.btnRegistrarMascota.Text = "Registrar";
            this.btnRegistrarMascota.UseVisualStyleBackColor = true;
            this.btnRegistrarMascota.Click += new System.EventHandler(this.btnRegistrarMascota_Click);
            // 
            // txtRazaMascota
            // 
            this.txtRazaMascota.Location = new System.Drawing.Point(177, 133);
            this.txtRazaMascota.Name = "txtRazaMascota";
            this.txtRazaMascota.Size = new System.Drawing.Size(100, 20);
            this.txtRazaMascota.TabIndex = 7;
            // 
            // txtEdadMascota
            // 
            this.txtEdadMascota.Location = new System.Drawing.Point(177, 106);
            this.txtEdadMascota.Name = "txtEdadMascota";
            this.txtEdadMascota.Size = new System.Drawing.Size(34, 20);
            this.txtEdadMascota.TabIndex = 6;
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Location = new System.Drawing.Point(177, 79);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(136, 20);
            this.txtNombreMascota.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Dueño";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Raza";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Edad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registro de mascota";
            // 
            // tabPageBusqueda
            // 
            this.tabPageBusqueda.Controls.Add(this.btnBuscar);
            this.tabPageBusqueda.Controls.Add(this.txtMostrarRaza);
            this.tabPageBusqueda.Controls.Add(this.label17);
            this.tabPageBusqueda.Controls.Add(this.txtMostrarEdad);
            this.tabPageBusqueda.Controls.Add(this.label16);
            this.tabPageBusqueda.Controls.Add(this.txtMostrarNombreMascota);
            this.tabPageBusqueda.Controls.Add(this.label15);
            this.tabPageBusqueda.Controls.Add(this.txtMostrarTelefono);
            this.tabPageBusqueda.Controls.Add(this.label14);
            this.tabPageBusqueda.Controls.Add(this.txtMostrarDireccion);
            this.tabPageBusqueda.Controls.Add(this.label13);
            this.tabPageBusqueda.Controls.Add(this.txtMostrarNombreDueño);
            this.tabPageBusqueda.Controls.Add(this.label12);
            this.tabPageBusqueda.Controls.Add(this.label11);
            this.tabPageBusqueda.Controls.Add(this.label10);
            this.tabPageBusqueda.Location = new System.Drawing.Point(4, 22);
            this.tabPageBusqueda.Name = "tabPageBusqueda";
            this.tabPageBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBusqueda.Size = new System.Drawing.Size(437, 302);
            this.tabPageBusqueda.TabIndex = 2;
            this.tabPageBusqueda.Text = "Busqueda...";
            this.tabPageBusqueda.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Datos de la mascota...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Datos generales...";
            // 
            // tabPageListDueños
            // 
            this.tabPageListDueños.Controls.Add(this.listViewDueños);
            this.tabPageListDueños.Location = new System.Drawing.Point(4, 22);
            this.tabPageListDueños.Name = "tabPageListDueños";
            this.tabPageListDueños.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListDueños.Size = new System.Drawing.Size(437, 302);
            this.tabPageListDueños.TabIndex = 3;
            this.tabPageListDueños.Text = "Lista de dueños...";
            this.tabPageListDueños.UseVisualStyleBackColor = true;
            // 
            // tabPageListMascotas
            // 
            this.tabPageListMascotas.Controls.Add(this.listViewMascotas);
            this.tabPageListMascotas.Location = new System.Drawing.Point(4, 22);
            this.tabPageListMascotas.Name = "tabPageListMascotas";
            this.tabPageListMascotas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListMascotas.Size = new System.Drawing.Size(437, 302);
            this.tabPageListMascotas.TabIndex = 4;
            this.tabPageListMascotas.Text = "Lista de mascotas...";
            this.tabPageListMascotas.UseVisualStyleBackColor = true;
            // 
            // listViewDueños
            // 
            this.listViewDueños.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNombreDueño,
            this.chDireccion,
            this.chTelefono});
            this.listViewDueños.FullRowSelect = true;
            this.listViewDueños.GridLines = true;
            this.listViewDueños.HideSelection = false;
            this.listViewDueños.Location = new System.Drawing.Point(7, 7);
            this.listViewDueños.Name = "listViewDueños";
            this.listViewDueños.Size = new System.Drawing.Size(424, 289);
            this.listViewDueños.TabIndex = 0;
            this.listViewDueños.UseCompatibleStateImageBehavior = false;
            this.listViewDueños.View = System.Windows.Forms.View.Details;
            // 
            // chNombreDueño
            // 
            this.chNombreDueño.Text = "Nombre";
            this.chNombreDueño.Width = 164;
            // 
            // chDireccion
            // 
            this.chDireccion.Text = "Dirección";
            this.chDireccion.Width = 172;
            // 
            // chTelefono
            // 
            this.chTelefono.Text = "Teléfono";
            this.chTelefono.Width = 84;
            // 
            // listViewMascotas
            // 
            this.listViewMascotas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNombreMascota,
            this.chEdadMascota,
            this.chRazaMascota,
            this.chDueñoMascota});
            this.listViewMascotas.FullRowSelect = true;
            this.listViewMascotas.GridLines = true;
            this.listViewMascotas.HideSelection = false;
            this.listViewMascotas.Location = new System.Drawing.Point(7, 7);
            this.listViewMascotas.Name = "listViewMascotas";
            this.listViewMascotas.Size = new System.Drawing.Size(424, 289);
            this.listViewMascotas.TabIndex = 0;
            this.listViewMascotas.UseCompatibleStateImageBehavior = false;
            this.listViewMascotas.View = System.Windows.Forms.View.Details;
            // 
            // chNombreMascota
            // 
            this.chNombreMascota.Text = "Nombre";
            this.chNombreMascota.Width = 138;
            // 
            // chEdadMascota
            // 
            this.chEdadMascota.Text = "Edad";
            // 
            // chRazaMascota
            // 
            this.chRazaMascota.Text = "Raza";
            this.chRazaMascota.Width = 82;
            // 
            // chDueñoMascota
            // 
            this.chDueñoMascota.Text = "Nombre del dueño";
            this.chDueñoMascota.Width = 138;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Nombre del dueño";
            // 
            // txtMostrarNombreDueño
            // 
            this.txtMostrarNombreDueño.Location = new System.Drawing.Point(152, 43);
            this.txtMostrarNombreDueño.Name = "txtMostrarNombreDueño";
            this.txtMostrarNombreDueño.ReadOnly = true;
            this.txtMostrarNombreDueño.Size = new System.Drawing.Size(234, 20);
            this.txtMostrarNombreDueño.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(98, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Direccion";
            // 
            // txtMostrarDireccion
            // 
            this.txtMostrarDireccion.Location = new System.Drawing.Point(152, 69);
            this.txtMostrarDireccion.Name = "txtMostrarDireccion";
            this.txtMostrarDireccion.ReadOnly = true;
            this.txtMostrarDireccion.Size = new System.Drawing.Size(234, 20);
            this.txtMostrarDireccion.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(101, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Teléfono";
            // 
            // txtMostrarTelefono
            // 
            this.txtMostrarTelefono.Location = new System.Drawing.Point(152, 95);
            this.txtMostrarTelefono.Name = "txtMostrarTelefono";
            this.txtMostrarTelefono.ReadOnly = true;
            this.txtMostrarTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtMostrarTelefono.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 166);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Nombre de la mascota";
            // 
            // txtMostrarNombreMascota
            // 
            this.txtMostrarNombreMascota.Location = new System.Drawing.Point(152, 163);
            this.txtMostrarNombreMascota.Name = "txtMostrarNombreMascota";
            this.txtMostrarNombreMascota.Size = new System.Drawing.Size(153, 20);
            this.txtMostrarNombreMascota.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(118, 192);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Edad";
            // 
            // txtMostrarEdad
            // 
            this.txtMostrarEdad.Location = new System.Drawing.Point(152, 189);
            this.txtMostrarEdad.Name = "txtMostrarEdad";
            this.txtMostrarEdad.ReadOnly = true;
            this.txtMostrarEdad.Size = new System.Drawing.Size(50, 20);
            this.txtMostrarEdad.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(118, 219);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Raza";
            // 
            // txtMostrarRaza
            // 
            this.txtMostrarRaza.Location = new System.Drawing.Point(152, 216);
            this.txtMostrarRaza.Name = "txtMostrarRaza";
            this.txtMostrarRaza.ReadOnly = true;
            this.txtMostrarRaza.Size = new System.Drawing.Size(148, 20);
            this.txtMostrarRaza.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(311, 161);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 355);
            this.Controls.Add(this.tabControl);
            this.Name = "Principal";
            this.Text = "Principal";
            this.tabControl.ResumeLayout(false);
            this.tabPageDueños.ResumeLayout(false);
            this.tabPageDueños.PerformLayout();
            this.tabPageMascotas.ResumeLayout(false);
            this.tabPageMascotas.PerformLayout();
            this.tabPageBusqueda.ResumeLayout(false);
            this.tabPageBusqueda.PerformLayout();
            this.tabPageListDueños.ResumeLayout(false);
            this.tabPageListMascotas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDueños;
        private System.Windows.Forms.TabPage tabPageMascotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreDueño;
        private System.Windows.Forms.TextBox txtTelefonoDueño;
        private System.Windows.Forms.TextBox txtDireccionDueño;
        private System.Windows.Forms.Button btnGuardarDueño;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRazaMascota;
        private System.Windows.Forms.TextBox txtEdadMascota;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.Button btnCancelarRegistro;
        private System.Windows.Forms.Button btnRegistrarMascota;
        private System.Windows.Forms.Button btnCancelarDueño;
        private System.Windows.Forms.ComboBox cbDueños;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPageListDueños;
        private System.Windows.Forms.TabPage tabPageListMascotas;
        private System.Windows.Forms.ListView listViewDueños;
        private System.Windows.Forms.ColumnHeader chNombreDueño;
        private System.Windows.Forms.ColumnHeader chDireccion;
        private System.Windows.Forms.ColumnHeader chTelefono;
        private System.Windows.Forms.ListView listViewMascotas;
        private System.Windows.Forms.ColumnHeader chNombreMascota;
        private System.Windows.Forms.ColumnHeader chEdadMascota;
        private System.Windows.Forms.ColumnHeader chRazaMascota;
        private System.Windows.Forms.ColumnHeader chDueñoMascota;
        private System.Windows.Forms.TextBox txtMostrarNombreDueño;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMostrarRaza;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMostrarEdad;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMostrarNombreMascota;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMostrarTelefono;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMostrarDireccion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBuscar;
    }
}

