﻿namespace TP7
{
    partial class Tp7
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_actual = new System.Windows.Forms.GroupBox();
            this.txt_evento = new System.Windows.Forms.TextBox();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.lbl_evento = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.btn_detener = new System.Windows.Forms.Button();
            this.dg_simulaciones = new System.Windows.Forms.DataGridView();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxima_llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_recepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_recepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_recepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_balanza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_balanza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_balanza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_darsenas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_darsena_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_darsena_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendidos_darsena_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_darsena_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proximo_fin_darsena_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendidos_darsena_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_atendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sin_atender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_simular = new System.Windows.Forms.Button();
            this.gb_cantidades = new System.Windows.Forms.GroupBox();
            this.txt_hasta = new System.Windows.Forms.TextBox();
            this.txt_desde = new System.Windows.Forms.TextBox();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.gb_resultados = new System.Windows.Forms.GroupBox();
            this.txt_permanencia_a = new System.Windows.Forms.TextBox();
            this.lbl_permanencia = new System.Windows.Forms.Label();
            this.txt_no_atendidos_a = new System.Windows.Forms.TextBox();
            this.lbl_no_atendidos = new System.Windows.Forms.Label();
            this.txt_atendidos_a = new System.Windows.Forms.TextBox();
            this.lbl_atendidos = new System.Windows.Forms.Label();
            this.gb_comida = new System.Windows.Forms.GroupBox();
            this.txt_comida_varianza = new System.Windows.Forms.TextBox();
            this.lbl_comida_varianza = new System.Windows.Forms.Label();
            this.txt_comida_media = new System.Windows.Forms.TextBox();
            this.lbl_comida_media = new System.Windows.Forms.Label();
            this.gb_mozo = new System.Windows.Forms.GroupBox();
            this.txt_pedido = new System.Windows.Forms.TextBox();
            this.lbl_pedido = new System.Windows.Forms.Label();
            this.txt_carta = new System.Windows.Forms.TextBox();
            this.lbl_carta = new System.Windows.Forms.Label();
            this.gb_menus = new System.Windows.Forms.GroupBox();
            this.txt_menu_2 = new System.Windows.Forms.TextBox();
            this.lbl_prob_menu_2 = new System.Windows.Forms.Label();
            this.txt_menu_1 = new System.Windows.Forms.TextBox();
            this.lbl_prob_menu_1 = new System.Windows.Forms.Label();
            this.gb_grupos = new System.Windows.Forms.GroupBox();
            this.txt_grupos_4 = new System.Windows.Forms.TextBox();
            this.lbl_grupos_4 = new System.Windows.Forms.Label();
            this.txt_grupos_2 = new System.Windows.Forms.TextBox();
            this.lbl_grupos_2 = new System.Windows.Forms.Label();
            this.gb_llegadas = new System.Windows.Forms.GroupBox();
            this.txt_llegadas = new System.Windows.Forms.TextBox();
            this.lbl_llegadas = new System.Windows.Forms.Label();
            this.txt_cola_max = new System.Windows.Forms.TextBox();
            this.lbl_cola_max = new System.Windows.Forms.Label();
            this.txt_demora_menu_2 = new System.Windows.Forms.TextBox();
            this.lbl_demora_menu_2 = new System.Windows.Forms.Label();
            this.txt_demora_menu_1 = new System.Windows.Forms.TextBox();
            this.lbl_demora_menu_1 = new System.Windows.Forms.Label();
            this.gb_horarios = new System.Windows.Forms.GroupBox();
            this.txt_cierre = new System.Windows.Forms.TextBox();
            this.lbl_cierre = new System.Windows.Forms.Label();
            this.txt_apertura = new System.Windows.Forms.TextBox();
            this.lbl_apertura = new System.Windows.Forms.Label();
            this.gb_actual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_simulaciones)).BeginInit();
            this.gb_cantidades.SuspendLayout();
            this.gb_resultados.SuspendLayout();
            this.gb_comida.SuspendLayout();
            this.gb_mozo.SuspendLayout();
            this.gb_menus.SuspendLayout();
            this.gb_grupos.SuspendLayout();
            this.gb_llegadas.SuspendLayout();
            this.gb_horarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_actual
            // 
            this.gb_actual.Controls.Add(this.txt_evento);
            this.gb_actual.Controls.Add(this.txt_hora);
            this.gb_actual.Controls.Add(this.lbl_evento);
            this.gb_actual.Controls.Add(this.lbl_hora);
            this.gb_actual.Location = new System.Drawing.Point(627, 12);
            this.gb_actual.Name = "gb_actual";
            this.gb_actual.Size = new System.Drawing.Size(237, 85);
            this.gb_actual.TabIndex = 25;
            this.gb_actual.TabStop = false;
            this.gb_actual.Text = "Simulación actual:";
            // 
            // txt_evento
            // 
            this.txt_evento.CausesValidation = false;
            this.txt_evento.Location = new System.Drawing.Point(111, 52);
            this.txt_evento.Name = "txt_evento";
            this.txt_evento.ReadOnly = true;
            this.txt_evento.Size = new System.Drawing.Size(89, 20);
            this.txt_evento.TabIndex = 5;
            // 
            // txt_hora
            // 
            this.txt_hora.CausesValidation = false;
            this.txt_hora.Location = new System.Drawing.Point(21, 52);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.ReadOnly = true;
            this.txt_hora.Size = new System.Drawing.Size(84, 20);
            this.txt_hora.TabIndex = 4;
            // 
            // lbl_evento
            // 
            this.lbl_evento.AutoSize = true;
            this.lbl_evento.Location = new System.Drawing.Point(108, 26);
            this.lbl_evento.Name = "lbl_evento";
            this.lbl_evento.Size = new System.Drawing.Size(44, 13);
            this.lbl_evento.TabIndex = 2;
            this.lbl_evento.Text = "Evento:";
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Location = new System.Drawing.Point(18, 26);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(33, 13);
            this.lbl_hora.TabIndex = 1;
            this.lbl_hora.Text = "Hora:";
            // 
            // btn_detener
            // 
            this.btn_detener.Enabled = false;
            this.btn_detener.Location = new System.Drawing.Point(870, 62);
            this.btn_detener.Name = "btn_detener";
            this.btn_detener.Size = new System.Drawing.Size(75, 23);
            this.btn_detener.TabIndex = 18;
            this.btn_detener.Text = "Detener";
            this.btn_detener.UseVisualStyleBackColor = true;
            this.btn_detener.Click += new System.EventHandler(this.btn_detener_Click);
            // 
            // dg_simulaciones
            // 
            this.dg_simulaciones.AllowUserToAddRows = false;
            this.dg_simulaciones.AllowUserToDeleteRows = false;
            this.dg_simulaciones.AllowUserToResizeColumns = false;
            this.dg_simulaciones.AllowUserToResizeRows = false;
            this.dg_simulaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_simulaciones.CausesValidation = false;
            this.dg_simulaciones.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_simulaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_simulaciones.ColumnHeadersHeight = 41;
            this.dg_simulaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_simulaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reloj,
            this.evento,
            this.proxima_llegada,
            this.cola_recepcion,
            this.estado_recepcion,
            this.proximo_fin_recepcion,
            this.cola_balanza,
            this.estado_balanza,
            this.proximo_fin_balanza,
            this.cola_darsenas,
            this.estado_darsena_1,
            this.proximo_fin_darsena_1,
            this.atendidos_darsena_1,
            this.estado_darsena_2,
            this.proximo_fin_darsena_2,
            this.atendidos_darsena_2,
            this.total_atendidos,
            this.sin_atender,
            this.permanencia});
            this.dg_simulaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dg_simulaciones.EnableHeadersVisualStyles = false;
            this.dg_simulaciones.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dg_simulaciones.Location = new System.Drawing.Point(143, 103);
            this.dg_simulaciones.Name = "dg_simulaciones";
            this.dg_simulaciones.ReadOnly = true;
            this.dg_simulaciones.RowHeadersVisible = false;
            this.dg_simulaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dg_simulaciones.RowTemplate.ReadOnly = true;
            this.dg_simulaciones.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_simulaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_simulaciones.ShowCellErrors = false;
            this.dg_simulaciones.ShowCellToolTips = false;
            this.dg_simulaciones.ShowEditingIcon = false;
            this.dg_simulaciones.ShowRowErrors = false;
            this.dg_simulaciones.Size = new System.Drawing.Size(801, 510);
            this.dg_simulaciones.TabIndex = 23;
            // 
            // reloj
            // 
            this.reloj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.reloj.FillWeight = 1F;
            this.reloj.Frozen = true;
            this.reloj.HeaderText = "Reloj";
            this.reloj.Name = "reloj";
            this.reloj.ReadOnly = true;
            this.reloj.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.reloj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.reloj.Width = 55;
            // 
            // evento
            // 
            this.evento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.evento.FillWeight = 1F;
            this.evento.Frozen = true;
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            this.evento.ReadOnly = true;
            this.evento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.evento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.evento.Width = 80;
            // 
            // proxima_llegada
            // 
            this.proxima_llegada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proxima_llegada.FillWeight = 1F;
            this.proxima_llegada.HeaderText = "Próxima Llegada";
            this.proxima_llegada.Name = "proxima_llegada";
            this.proxima_llegada.ReadOnly = true;
            this.proxima_llegada.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proxima_llegada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proxima_llegada.Width = 60;
            // 
            // cola_recepcion
            // 
            this.cola_recepcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cola_recepcion.FillWeight = 1F;
            this.cola_recepcion.HeaderText = "Cola Recepción";
            this.cola_recepcion.Name = "cola_recepcion";
            this.cola_recepcion.ReadOnly = true;
            this.cola_recepcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cola_recepcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cola_recepcion.Width = 70;
            // 
            // estado_recepcion
            // 
            this.estado_recepcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_recepcion.FillWeight = 1F;
            this.estado_recepcion.HeaderText = "Estado Recepción";
            this.estado_recepcion.Name = "estado_recepcion";
            this.estado_recepcion.ReadOnly = true;
            this.estado_recepcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_recepcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_recepcion.Width = 140;
            // 
            // proximo_fin_recepcion
            // 
            this.proximo_fin_recepcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_recepcion.FillWeight = 1F;
            this.proximo_fin_recepcion.HeaderText = "Próximo Fin Recepción";
            this.proximo_fin_recepcion.Name = "proximo_fin_recepcion";
            this.proximo_fin_recepcion.ReadOnly = true;
            this.proximo_fin_recepcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_recepcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_recepcion.Width = 85;
            // 
            // cola_balanza
            // 
            this.cola_balanza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cola_balanza.FillWeight = 1F;
            this.cola_balanza.HeaderText = "Cola Balanza";
            this.cola_balanza.Name = "cola_balanza";
            this.cola_balanza.ReadOnly = true;
            this.cola_balanza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cola_balanza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cola_balanza.Width = 60;
            // 
            // estado_balanza
            // 
            this.estado_balanza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_balanza.FillWeight = 1F;
            this.estado_balanza.HeaderText = "Estado Balanza";
            this.estado_balanza.Name = "estado_balanza";
            this.estado_balanza.ReadOnly = true;
            this.estado_balanza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_balanza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_balanza.Width = 140;
            // 
            // proximo_fin_balanza
            // 
            this.proximo_fin_balanza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_balanza.FillWeight = 1F;
            this.proximo_fin_balanza.HeaderText = "Próximo Fin Balanza";
            this.proximo_fin_balanza.Name = "proximo_fin_balanza";
            this.proximo_fin_balanza.ReadOnly = true;
            this.proximo_fin_balanza.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_balanza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_balanza.Width = 85;
            // 
            // cola_darsenas
            // 
            this.cola_darsenas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cola_darsenas.FillWeight = 1F;
            this.cola_darsenas.HeaderText = "Cola Dársenas";
            this.cola_darsenas.Name = "cola_darsenas";
            this.cola_darsenas.ReadOnly = true;
            this.cola_darsenas.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cola_darsenas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cola_darsenas.Width = 70;
            // 
            // estado_darsena_1
            // 
            this.estado_darsena_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_darsena_1.FillWeight = 1F;
            this.estado_darsena_1.HeaderText = "Estado Dársena 1";
            this.estado_darsena_1.Name = "estado_darsena_1";
            this.estado_darsena_1.ReadOnly = true;
            this.estado_darsena_1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_darsena_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_darsena_1.Width = 140;
            // 
            // proximo_fin_darsena_1
            // 
            this.proximo_fin_darsena_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_darsena_1.FillWeight = 1F;
            this.proximo_fin_darsena_1.HeaderText = "Próximo Fin Dársena 1";
            this.proximo_fin_darsena_1.Name = "proximo_fin_darsena_1";
            this.proximo_fin_darsena_1.ReadOnly = true;
            this.proximo_fin_darsena_1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_darsena_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_darsena_1.Width = 85;
            // 
            // atendidos_darsena_1
            // 
            this.atendidos_darsena_1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.atendidos_darsena_1.FillWeight = 1F;
            this.atendidos_darsena_1.HeaderText = "Atendidos Dársena 1";
            this.atendidos_darsena_1.Name = "atendidos_darsena_1";
            this.atendidos_darsena_1.ReadOnly = true;
            this.atendidos_darsena_1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.atendidos_darsena_1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.atendidos_darsena_1.Width = 80;
            // 
            // estado_darsena_2
            // 
            this.estado_darsena_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.estado_darsena_2.FillWeight = 1F;
            this.estado_darsena_2.HeaderText = "Estado Dársena 2";
            this.estado_darsena_2.Name = "estado_darsena_2";
            this.estado_darsena_2.ReadOnly = true;
            this.estado_darsena_2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado_darsena_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado_darsena_2.Width = 140;
            // 
            // proximo_fin_darsena_2
            // 
            this.proximo_fin_darsena_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.proximo_fin_darsena_2.FillWeight = 1F;
            this.proximo_fin_darsena_2.HeaderText = "Próximo Fin Dársena 2";
            this.proximo_fin_darsena_2.Name = "proximo_fin_darsena_2";
            this.proximo_fin_darsena_2.ReadOnly = true;
            this.proximo_fin_darsena_2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proximo_fin_darsena_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.proximo_fin_darsena_2.Width = 85;
            // 
            // atendidos_darsena_2
            // 
            this.atendidos_darsena_2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.atendidos_darsena_2.FillWeight = 1F;
            this.atendidos_darsena_2.HeaderText = "Atendidos Dársena 2";
            this.atendidos_darsena_2.Name = "atendidos_darsena_2";
            this.atendidos_darsena_2.ReadOnly = true;
            this.atendidos_darsena_2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.atendidos_darsena_2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.atendidos_darsena_2.Width = 80;
            // 
            // total_atendidos
            // 
            this.total_atendidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.total_atendidos.FillWeight = 1F;
            this.total_atendidos.HeaderText = "Total Atendidos";
            this.total_atendidos.Name = "total_atendidos";
            this.total_atendidos.ReadOnly = true;
            this.total_atendidos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.total_atendidos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.total_atendidos.Width = 70;
            // 
            // sin_atender
            // 
            this.sin_atender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sin_atender.FillWeight = 1F;
            this.sin_atender.HeaderText = "Total Sin Atender";
            this.sin_atender.Name = "sin_atender";
            this.sin_atender.ReadOnly = true;
            this.sin_atender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sin_atender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sin_atender.Width = 70;
            // 
            // permanencia
            // 
            this.permanencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.permanencia.FillWeight = 1F;
            this.permanencia.HeaderText = "Permanencia Promedio";
            this.permanencia.Name = "permanencia";
            this.permanencia.ReadOnly = true;
            this.permanencia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.permanencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.permanencia.Width = 90;
            // 
            // btn_simular
            // 
            this.btn_simular.Enabled = false;
            this.btn_simular.Location = new System.Drawing.Point(870, 28);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(75, 23);
            this.btn_simular.TabIndex = 17;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.btn_simular_Click);
            // 
            // gb_cantidades
            // 
            this.gb_cantidades.Controls.Add(this.txt_hasta);
            this.gb_cantidades.Controls.Add(this.txt_desde);
            this.gb_cantidades.Controls.Add(this.lbl_hasta);
            this.gb_cantidades.Controls.Add(this.lbl_desde);
            this.gb_cantidades.Location = new System.Drawing.Point(12, 12);
            this.gb_cantidades.Name = "gb_cantidades";
            this.gb_cantidades.Size = new System.Drawing.Size(179, 85);
            this.gb_cantidades.TabIndex = 20;
            this.gb_cantidades.TabStop = false;
            this.gb_cantidades.Text = "Cantidades:";
            // 
            // txt_hasta
            // 
            this.txt_hasta.Location = new System.Drawing.Point(120, 48);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(37, 20);
            this.txt_hasta.TabIndex = 2;
            this.txt_hasta.Text = "100";
            // 
            // txt_desde
            // 
            this.txt_desde.Location = new System.Drawing.Point(120, 23);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(37, 20);
            this.txt_desde.TabIndex = 1;
            this.txt_desde.Text = "1";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.Location = new System.Drawing.Point(17, 50);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(74, 13);
            this.lbl_hasta.TabIndex = 1;
            this.lbl_hasta.Text = "Mostrar hasta:";
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.Location = new System.Drawing.Point(17, 26);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(77, 13);
            this.lbl_desde.TabIndex = 0;
            this.lbl_desde.Text = "Mostrar desde:";
            // 
            // gb_resultados
            // 
            this.gb_resultados.Controls.Add(this.txt_permanencia_a);
            this.gb_resultados.Controls.Add(this.lbl_permanencia);
            this.gb_resultados.Controls.Add(this.txt_no_atendidos_a);
            this.gb_resultados.Controls.Add(this.lbl_no_atendidos);
            this.gb_resultados.Controls.Add(this.txt_atendidos_a);
            this.gb_resultados.Controls.Add(this.lbl_atendidos);
            this.gb_resultados.Location = new System.Drawing.Point(328, 12);
            this.gb_resultados.Name = "gb_resultados";
            this.gb_resultados.Size = new System.Drawing.Size(293, 85);
            this.gb_resultados.TabIndex = 19;
            this.gb_resultados.TabStop = false;
            this.gb_resultados.Text = "Resultados:";
            // 
            // txt_permanencia_a
            // 
            this.txt_permanencia_a.Enabled = false;
            this.txt_permanencia_a.Location = new System.Drawing.Point(210, 52);
            this.txt_permanencia_a.Name = "txt_permanencia_a";
            this.txt_permanencia_a.ReadOnly = true;
            this.txt_permanencia_a.Size = new System.Drawing.Size(64, 20);
            this.txt_permanencia_a.TabIndex = 11;
            // 
            // lbl_permanencia
            // 
            this.lbl_permanencia.Location = new System.Drawing.Point(201, 16);
            this.lbl_permanencia.Name = "lbl_permanencia";
            this.lbl_permanencia.Size = new System.Drawing.Size(81, 33);
            this.lbl_permanencia.TabIndex = 10;
            this.lbl_permanencia.Text = "Espera promedio:";
            this.lbl_permanencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_no_atendidos_a
            // 
            this.txt_no_atendidos_a.Enabled = false;
            this.txt_no_atendidos_a.Location = new System.Drawing.Point(116, 52);
            this.txt_no_atendidos_a.Name = "txt_no_atendidos_a";
            this.txt_no_atendidos_a.ReadOnly = true;
            this.txt_no_atendidos_a.Size = new System.Drawing.Size(64, 20);
            this.txt_no_atendidos_a.TabIndex = 8;
            // 
            // lbl_no_atendidos
            // 
            this.lbl_no_atendidos.Location = new System.Drawing.Point(113, 16);
            this.lbl_no_atendidos.Name = "lbl_no_atendidos";
            this.lbl_no_atendidos.Size = new System.Drawing.Size(74, 33);
            this.lbl_no_atendidos.TabIndex = 7;
            this.lbl_no_atendidos.Text = "No atendidos:";
            this.lbl_no_atendidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_atendidos_a
            // 
            this.txt_atendidos_a.Enabled = false;
            this.txt_atendidos_a.Location = new System.Drawing.Point(20, 52);
            this.txt_atendidos_a.Name = "txt_atendidos_a";
            this.txt_atendidos_a.ReadOnly = true;
            this.txt_atendidos_a.Size = new System.Drawing.Size(64, 20);
            this.txt_atendidos_a.TabIndex = 5;
            // 
            // lbl_atendidos
            // 
            this.lbl_atendidos.Location = new System.Drawing.Point(17, 16);
            this.lbl_atendidos.Name = "lbl_atendidos";
            this.lbl_atendidos.Size = new System.Drawing.Size(67, 33);
            this.lbl_atendidos.TabIndex = 4;
            this.lbl_atendidos.Text = "Atendidos:";
            this.lbl_atendidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_comida
            // 
            this.gb_comida.Controls.Add(this.txt_comida_varianza);
            this.gb_comida.Controls.Add(this.lbl_comida_varianza);
            this.gb_comida.Controls.Add(this.txt_comida_media);
            this.gb_comida.Controls.Add(this.lbl_comida_media);
            this.gb_comida.Location = new System.Drawing.Point(12, 530);
            this.gb_comida.Name = "gb_comida";
            this.gb_comida.Size = new System.Drawing.Size(125, 85);
            this.gb_comida.TabIndex = 18;
            this.gb_comida.TabStop = false;
            this.gb_comida.Text = "Comida:";
            // 
            // txt_comida_varianza
            // 
            this.txt_comida_varianza.Location = new System.Drawing.Point(82, 48);
            this.txt_comida_varianza.Name = "txt_comida_varianza";
            this.txt_comida_varianza.Size = new System.Drawing.Size(37, 20);
            this.txt_comida_varianza.TabIndex = 16;
            this.txt_comida_varianza.Text = "20";
            // 
            // lbl_comida_varianza
            // 
            this.lbl_comida_varianza.AutoSize = true;
            this.lbl_comida_varianza.Location = new System.Drawing.Point(17, 51);
            this.lbl_comida_varianza.Name = "lbl_comida_varianza";
            this.lbl_comida_varianza.Size = new System.Drawing.Size(51, 13);
            this.lbl_comida_varianza.TabIndex = 2;
            this.lbl_comida_varianza.Text = "Varianza:";
            // 
            // txt_comida_media
            // 
            this.txt_comida_media.Location = new System.Drawing.Point(82, 22);
            this.txt_comida_media.Name = "txt_comida_media";
            this.txt_comida_media.Size = new System.Drawing.Size(37, 20);
            this.txt_comida_media.TabIndex = 15;
            this.txt_comida_media.Text = "60";
            // 
            // lbl_comida_media
            // 
            this.lbl_comida_media.AutoSize = true;
            this.lbl_comida_media.Location = new System.Drawing.Point(17, 25);
            this.lbl_comida_media.Name = "lbl_comida_media";
            this.lbl_comida_media.Size = new System.Drawing.Size(39, 13);
            this.lbl_comida_media.TabIndex = 0;
            this.lbl_comida_media.Text = "Media:";
            // 
            // gb_mozo
            // 
            this.gb_mozo.Controls.Add(this.txt_pedido);
            this.gb_mozo.Controls.Add(this.lbl_pedido);
            this.gb_mozo.Controls.Add(this.txt_carta);
            this.gb_mozo.Controls.Add(this.lbl_carta);
            this.gb_mozo.Location = new System.Drawing.Point(12, 439);
            this.gb_mozo.Name = "gb_mozo";
            this.gb_mozo.Size = new System.Drawing.Size(125, 85);
            this.gb_mozo.TabIndex = 17;
            this.gb_mozo.TabStop = false;
            this.gb_mozo.Text = "Mozo:";
            // 
            // txt_pedido
            // 
            this.txt_pedido.Location = new System.Drawing.Point(82, 48);
            this.txt_pedido.Name = "txt_pedido";
            this.txt_pedido.Size = new System.Drawing.Size(37, 20);
            this.txt_pedido.TabIndex = 14;
            this.txt_pedido.Text = "2";
            // 
            // lbl_pedido
            // 
            this.lbl_pedido.AutoSize = true;
            this.lbl_pedido.Location = new System.Drawing.Point(17, 51);
            this.lbl_pedido.Name = "lbl_pedido";
            this.lbl_pedido.Size = new System.Drawing.Size(43, 13);
            this.lbl_pedido.TabIndex = 2;
            this.lbl_pedido.Text = "Pedido:";
            // 
            // txt_carta
            // 
            this.txt_carta.Location = new System.Drawing.Point(82, 22);
            this.txt_carta.Name = "txt_carta";
            this.txt_carta.Size = new System.Drawing.Size(37, 20);
            this.txt_carta.TabIndex = 13;
            this.txt_carta.Text = "1";
            // 
            // lbl_carta
            // 
            this.lbl_carta.AutoSize = true;
            this.lbl_carta.Location = new System.Drawing.Point(17, 25);
            this.lbl_carta.Name = "lbl_carta";
            this.lbl_carta.Size = new System.Drawing.Size(35, 13);
            this.lbl_carta.TabIndex = 0;
            this.lbl_carta.Text = "Carta:";
            // 
            // gb_menus
            // 
            this.gb_menus.Controls.Add(this.txt_demora_menu_2);
            this.gb_menus.Controls.Add(this.lbl_demora_menu_2);
            this.gb_menus.Controls.Add(this.txt_demora_menu_1);
            this.gb_menus.Controls.Add(this.lbl_demora_menu_1);
            this.gb_menus.Controls.Add(this.txt_menu_2);
            this.gb_menus.Controls.Add(this.lbl_prob_menu_2);
            this.gb_menus.Controls.Add(this.txt_menu_1);
            this.gb_menus.Controls.Add(this.lbl_prob_menu_1);
            this.gb_menus.Location = new System.Drawing.Point(12, 285);
            this.gb_menus.Name = "gb_menus";
            this.gb_menus.Size = new System.Drawing.Size(125, 148);
            this.gb_menus.TabIndex = 16;
            this.gb_menus.TabStop = false;
            this.gb_menus.Text = "Menús:";
            // 
            // txt_menu_2
            // 
            this.txt_menu_2.Location = new System.Drawing.Point(82, 48);
            this.txt_menu_2.Name = "txt_menu_2";
            this.txt_menu_2.Size = new System.Drawing.Size(37, 20);
            this.txt_menu_2.TabIndex = 10;
            this.txt_menu_2.Text = "0.5";
            this.txt_menu_2.TextChanged += new System.EventHandler(this.txt_menu_2_TextChanged);
            // 
            // lbl_prob_menu_2
            // 
            this.lbl_prob_menu_2.AutoSize = true;
            this.lbl_prob_menu_2.Location = new System.Drawing.Point(17, 51);
            this.lbl_prob_menu_2.Name = "lbl_prob_menu_2";
            this.lbl_prob_menu_2.Size = new System.Drawing.Size(41, 13);
            this.lbl_prob_menu_2.TabIndex = 2;
            this.lbl_prob_menu_2.Text = "Prob 2:";
            // 
            // txt_menu_1
            // 
            this.txt_menu_1.Location = new System.Drawing.Point(82, 22);
            this.txt_menu_1.Name = "txt_menu_1";
            this.txt_menu_1.Size = new System.Drawing.Size(37, 20);
            this.txt_menu_1.TabIndex = 9;
            this.txt_menu_1.Text = "0.5";
            this.txt_menu_1.TextChanged += new System.EventHandler(this.txt_menu_1_TextChanged);
            // 
            // lbl_prob_menu_1
            // 
            this.lbl_prob_menu_1.AutoSize = true;
            this.lbl_prob_menu_1.Location = new System.Drawing.Point(17, 25);
            this.lbl_prob_menu_1.Name = "lbl_prob_menu_1";
            this.lbl_prob_menu_1.Size = new System.Drawing.Size(41, 13);
            this.lbl_prob_menu_1.TabIndex = 0;
            this.lbl_prob_menu_1.Text = "Prob 1:";
            // 
            // gb_grupos
            // 
            this.gb_grupos.Controls.Add(this.txt_grupos_4);
            this.gb_grupos.Controls.Add(this.lbl_grupos_4);
            this.gb_grupos.Controls.Add(this.txt_grupos_2);
            this.gb_grupos.Controls.Add(this.lbl_grupos_2);
            this.gb_grupos.Location = new System.Drawing.Point(12, 194);
            this.gb_grupos.Name = "gb_grupos";
            this.gb_grupos.Size = new System.Drawing.Size(125, 85);
            this.gb_grupos.TabIndex = 15;
            this.gb_grupos.TabStop = false;
            this.gb_grupos.Text = "Grupos:";
            // 
            // txt_grupos_4
            // 
            this.txt_grupos_4.Location = new System.Drawing.Point(82, 48);
            this.txt_grupos_4.Name = "txt_grupos_4";
            this.txt_grupos_4.Size = new System.Drawing.Size(37, 20);
            this.txt_grupos_4.TabIndex = 8;
            this.txt_grupos_4.Text = "0.5";
            this.txt_grupos_4.TextChanged += new System.EventHandler(this.txt_grupos_4_TextChanged);
            // 
            // lbl_grupos_4
            // 
            this.lbl_grupos_4.AutoSize = true;
            this.lbl_grupos_4.Location = new System.Drawing.Point(17, 51);
            this.lbl_grupos_4.Name = "lbl_grupos_4";
            this.lbl_grupos_4.Size = new System.Drawing.Size(62, 13);
            this.lbl_grupos_4.TabIndex = 2;
            this.lbl_grupos_4.Text = "4 personas:";
            // 
            // txt_grupos_2
            // 
            this.txt_grupos_2.Location = new System.Drawing.Point(82, 22);
            this.txt_grupos_2.Name = "txt_grupos_2";
            this.txt_grupos_2.Size = new System.Drawing.Size(37, 20);
            this.txt_grupos_2.TabIndex = 7;
            this.txt_grupos_2.Text = "0.5";
            this.txt_grupos_2.TextChanged += new System.EventHandler(this.txt_grupos_2_TextChanged);
            // 
            // lbl_grupos_2
            // 
            this.lbl_grupos_2.AutoSize = true;
            this.lbl_grupos_2.Location = new System.Drawing.Point(17, 25);
            this.lbl_grupos_2.Name = "lbl_grupos_2";
            this.lbl_grupos_2.Size = new System.Drawing.Size(62, 13);
            this.lbl_grupos_2.TabIndex = 0;
            this.lbl_grupos_2.Text = "2 personas:";
            // 
            // gb_llegadas
            // 
            this.gb_llegadas.Controls.Add(this.txt_cola_max);
            this.gb_llegadas.Controls.Add(this.lbl_cola_max);
            this.gb_llegadas.Controls.Add(this.txt_llegadas);
            this.gb_llegadas.Controls.Add(this.lbl_llegadas);
            this.gb_llegadas.Location = new System.Drawing.Point(12, 103);
            this.gb_llegadas.Name = "gb_llegadas";
            this.gb_llegadas.Size = new System.Drawing.Size(125, 85);
            this.gb_llegadas.TabIndex = 14;
            this.gb_llegadas.TabStop = false;
            this.gb_llegadas.Text = "Llegadas:";
            // 
            // txt_llegadas
            // 
            this.txt_llegadas.Location = new System.Drawing.Point(82, 22);
            this.txt_llegadas.Name = "txt_llegadas";
            this.txt_llegadas.Size = new System.Drawing.Size(37, 20);
            this.txt_llegadas.TabIndex = 5;
            this.txt_llegadas.Text = "10";
            // 
            // lbl_llegadas
            // 
            this.lbl_llegadas.AutoSize = true;
            this.lbl_llegadas.Location = new System.Drawing.Point(17, 25);
            this.lbl_llegadas.Name = "lbl_llegadas";
            this.lbl_llegadas.Size = new System.Drawing.Size(45, 13);
            this.lbl_llegadas.TabIndex = 0;
            this.lbl_llegadas.Text = "Tiempo:";
            // 
            // txt_cola_max
            // 
            this.txt_cola_max.Location = new System.Drawing.Point(82, 47);
            this.txt_cola_max.Name = "txt_cola_max";
            this.txt_cola_max.Size = new System.Drawing.Size(37, 20);
            this.txt_cola_max.TabIndex = 6;
            this.txt_cola_max.Text = "1";
            // 
            // lbl_cola_max
            // 
            this.lbl_cola_max.AutoSize = true;
            this.lbl_cola_max.Location = new System.Drawing.Point(17, 50);
            this.lbl_cola_max.Name = "lbl_cola_max";
            this.lbl_cola_max.Size = new System.Drawing.Size(53, 13);
            this.lbl_cola_max.TabIndex = 2;
            this.lbl_cola_max.Text = "Cola max:";
            // 
            // txt_demora_menu_2
            // 
            this.txt_demora_menu_2.Location = new System.Drawing.Point(82, 102);
            this.txt_demora_menu_2.Name = "txt_demora_menu_2";
            this.txt_demora_menu_2.Size = new System.Drawing.Size(37, 20);
            this.txt_demora_menu_2.TabIndex = 12;
            this.txt_demora_menu_2.Text = "15";
            // 
            // lbl_demora_menu_2
            // 
            this.lbl_demora_menu_2.AutoSize = true;
            this.lbl_demora_menu_2.Location = new System.Drawing.Point(17, 105);
            this.lbl_demora_menu_2.Name = "lbl_demora_menu_2";
            this.lbl_demora_menu_2.Size = new System.Drawing.Size(56, 13);
            this.lbl_demora_menu_2.TabIndex = 6;
            this.lbl_demora_menu_2.Text = "Demora 2:";
            // 
            // txt_demora_menu_1
            // 
            this.txt_demora_menu_1.Location = new System.Drawing.Point(82, 76);
            this.txt_demora_menu_1.Name = "txt_demora_menu_1";
            this.txt_demora_menu_1.Size = new System.Drawing.Size(37, 20);
            this.txt_demora_menu_1.TabIndex = 11;
            this.txt_demora_menu_1.Text = "10";
            // 
            // lbl_demora_menu_1
            // 
            this.lbl_demora_menu_1.AutoSize = true;
            this.lbl_demora_menu_1.Location = new System.Drawing.Point(17, 79);
            this.lbl_demora_menu_1.Name = "lbl_demora_menu_1";
            this.lbl_demora_menu_1.Size = new System.Drawing.Size(56, 13);
            this.lbl_demora_menu_1.TabIndex = 4;
            this.lbl_demora_menu_1.Text = "Demora 1:";
            // 
            // gb_horarios
            // 
            this.gb_horarios.Controls.Add(this.txt_cierre);
            this.gb_horarios.Controls.Add(this.lbl_cierre);
            this.gb_horarios.Controls.Add(this.txt_apertura);
            this.gb_horarios.Controls.Add(this.lbl_apertura);
            this.gb_horarios.Location = new System.Drawing.Point(197, 12);
            this.gb_horarios.Name = "gb_horarios";
            this.gb_horarios.Size = new System.Drawing.Size(125, 85);
            this.gb_horarios.TabIndex = 26;
            this.gb_horarios.TabStop = false;
            this.gb_horarios.Text = "Horarios:";
            // 
            // txt_cierre
            // 
            this.txt_cierre.Location = new System.Drawing.Point(82, 48);
            this.txt_cierre.Name = "txt_cierre";
            this.txt_cierre.Size = new System.Drawing.Size(37, 20);
            this.txt_cierre.TabIndex = 4;
            this.txt_cierre.Text = "22:30";
            // 
            // lbl_cierre
            // 
            this.lbl_cierre.AutoSize = true;
            this.lbl_cierre.Location = new System.Drawing.Point(17, 51);
            this.lbl_cierre.Name = "lbl_cierre";
            this.lbl_cierre.Size = new System.Drawing.Size(37, 13);
            this.lbl_cierre.TabIndex = 2;
            this.lbl_cierre.Text = "Cierre:";
            // 
            // txt_apertura
            // 
            this.txt_apertura.Location = new System.Drawing.Point(82, 22);
            this.txt_apertura.Name = "txt_apertura";
            this.txt_apertura.Size = new System.Drawing.Size(37, 20);
            this.txt_apertura.TabIndex = 3;
            this.txt_apertura.Text = "08:00";
            // 
            // lbl_apertura
            // 
            this.lbl_apertura.AutoSize = true;
            this.lbl_apertura.Location = new System.Drawing.Point(17, 25);
            this.lbl_apertura.Name = "lbl_apertura";
            this.lbl_apertura.Size = new System.Drawing.Size(50, 13);
            this.lbl_apertura.TabIndex = 0;
            this.lbl_apertura.Text = "Apertura:";
            // 
            // Tp7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 625);
            this.Controls.Add(this.gb_horarios);
            this.Controls.Add(this.gb_actual);
            this.Controls.Add(this.btn_detener);
            this.Controls.Add(this.dg_simulaciones);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.gb_cantidades);
            this.Controls.Add(this.gb_resultados);
            this.Controls.Add(this.gb_comida);
            this.Controls.Add(this.gb_mozo);
            this.Controls.Add(this.gb_menus);
            this.Controls.Add(this.gb_grupos);
            this.Controls.Add(this.gb_llegadas);
            this.Name = "Tp7";
            this.Text = "García Reyna, Facundo (63583)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gb_actual.ResumeLayout(false);
            this.gb_actual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_simulaciones)).EndInit();
            this.gb_cantidades.ResumeLayout(false);
            this.gb_cantidades.PerformLayout();
            this.gb_resultados.ResumeLayout(false);
            this.gb_resultados.PerformLayout();
            this.gb_comida.ResumeLayout(false);
            this.gb_comida.PerformLayout();
            this.gb_mozo.ResumeLayout(false);
            this.gb_mozo.PerformLayout();
            this.gb_menus.ResumeLayout(false);
            this.gb_menus.PerformLayout();
            this.gb_grupos.ResumeLayout(false);
            this.gb_grupos.PerformLayout();
            this.gb_llegadas.ResumeLayout(false);
            this.gb_llegadas.PerformLayout();
            this.gb_horarios.ResumeLayout(false);
            this.gb_horarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_actual;
        private System.Windows.Forms.TextBox txt_evento;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.Label lbl_evento;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Button btn_detener;
        private System.Windows.Forms.DataGridView dg_simulaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxima_llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_recepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_recepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_recepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_balanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_balanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_balanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_darsenas;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_darsena_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_darsena_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendidos_darsena_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_darsena_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn proximo_fin_darsena_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendidos_darsena_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_atendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn sin_atender;
        private System.Windows.Forms.DataGridViewTextBoxColumn permanencia;
        private System.Windows.Forms.Button btn_simular;
        private System.Windows.Forms.GroupBox gb_cantidades;
        private System.Windows.Forms.TextBox txt_hasta;
        private System.Windows.Forms.TextBox txt_desde;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.GroupBox gb_resultados;
        private System.Windows.Forms.TextBox txt_permanencia_a;
        private System.Windows.Forms.Label lbl_permanencia;
        private System.Windows.Forms.TextBox txt_no_atendidos_a;
        private System.Windows.Forms.Label lbl_no_atendidos;
        private System.Windows.Forms.TextBox txt_atendidos_a;
        private System.Windows.Forms.Label lbl_atendidos;
        private System.Windows.Forms.GroupBox gb_comida;
        private System.Windows.Forms.TextBox txt_comida_varianza;
        private System.Windows.Forms.Label lbl_comida_varianza;
        private System.Windows.Forms.TextBox txt_comida_media;
        private System.Windows.Forms.Label lbl_comida_media;
        private System.Windows.Forms.GroupBox gb_mozo;
        private System.Windows.Forms.TextBox txt_pedido;
        private System.Windows.Forms.Label lbl_pedido;
        private System.Windows.Forms.TextBox txt_carta;
        private System.Windows.Forms.Label lbl_carta;
        private System.Windows.Forms.GroupBox gb_menus;
        private System.Windows.Forms.TextBox txt_menu_2;
        private System.Windows.Forms.Label lbl_prob_menu_2;
        private System.Windows.Forms.TextBox txt_menu_1;
        private System.Windows.Forms.Label lbl_prob_menu_1;
        private System.Windows.Forms.GroupBox gb_grupos;
        private System.Windows.Forms.TextBox txt_grupos_4;
        private System.Windows.Forms.Label lbl_grupos_4;
        private System.Windows.Forms.TextBox txt_grupos_2;
        private System.Windows.Forms.Label lbl_grupos_2;
        private System.Windows.Forms.GroupBox gb_llegadas;
        private System.Windows.Forms.TextBox txt_llegadas;
        private System.Windows.Forms.Label lbl_llegadas;
        private System.Windows.Forms.TextBox txt_demora_menu_2;
        private System.Windows.Forms.Label lbl_demora_menu_2;
        private System.Windows.Forms.TextBox txt_demora_menu_1;
        private System.Windows.Forms.Label lbl_demora_menu_1;
        private System.Windows.Forms.TextBox txt_cola_max;
        private System.Windows.Forms.Label lbl_cola_max;
        private System.Windows.Forms.GroupBox gb_horarios;
        private System.Windows.Forms.TextBox txt_cierre;
        private System.Windows.Forms.Label lbl_cierre;
        private System.Windows.Forms.TextBox txt_apertura;
        private System.Windows.Forms.Label lbl_apertura;
    }
}

