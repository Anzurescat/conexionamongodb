namespace Formulario_addmario
{
    partial class Fcalificacion
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dbnombremateria = new TextBox();
            dbparcial1 = new TextBox();
            dbparcial2 = new TextBox();
            dbparcial3 = new TextBox();
            alumno = new TextBox();
            registrar = new Button();
            modificar = new Button();
            eliminar = new Button();
            dgbcalificaciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgbcalificaciones).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 94);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre de la materia";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 130);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 1;
            label2.Text = "calificacion parcial 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 164);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 2;
            label3.Text = "calificacion parcial 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 193);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 3;
            label4.Text = "calificacion parcial 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 223);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 4;
            label5.Text = "nombre del alumno";
            // 
            // dbnombremateria
            // 
            dbnombremateria.Location = new Point(188, 94);
            dbnombremateria.Name = "dbnombremateria";
            dbnombremateria.Size = new Size(147, 27);
            dbnombremateria.TabIndex = 5;
            // 
            // dbparcial1
            // 
            dbparcial1.Location = new Point(188, 130);
            dbparcial1.Name = "dbparcial1";
            dbparcial1.Size = new Size(147, 27);
            dbparcial1.TabIndex = 6;
            // 
            // dbparcial2
            // 
            dbparcial2.Location = new Point(188, 164);
            dbparcial2.Name = "dbparcial2";
            dbparcial2.Size = new Size(147, 27);
            dbparcial2.TabIndex = 7;
            // 
            // dbparcial3
            // 
            dbparcial3.Location = new Point(188, 197);
            dbparcial3.Name = "dbparcial3";
            dbparcial3.Size = new Size(147, 27);
            dbparcial3.TabIndex = 8;
            // 
            // alumno
            // 
            alumno.Location = new Point(188, 230);
            alumno.Name = "alumno";
            alumno.Size = new Size(147, 27);
            alumno.TabIndex = 9;
            // 
            // registrar
            // 
            registrar.Location = new Point(26, 305);
            registrar.Name = "registrar";
            registrar.Size = new Size(135, 34);
            registrar.TabIndex = 10;
            registrar.Text = "registrar";
            registrar.UseVisualStyleBackColor = true;
            // 
            // modificar
            // 
            modificar.Location = new Point(210, 305);
            modificar.Name = "modificar";
            modificar.Size = new Size(135, 34);
            modificar.TabIndex = 11;
            modificar.Text = "modificar";
            modificar.UseVisualStyleBackColor = true;
            // 
            // eliminar
            // 
            eliminar.Location = new Point(398, 305);
            eliminar.Name = "eliminar";
            eliminar.Size = new Size(135, 34);
            eliminar.TabIndex = 12;
            eliminar.Text = "eliminar";
            eliminar.UseVisualStyleBackColor = true;
            // 
            // dgbcalificaciones
            // 
            dgbcalificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbcalificaciones.Location = new Point(664, 27);
            dgbcalificaciones.Name = "dgbcalificaciones";
            dgbcalificaciones.RowHeadersWidth = 51;
            dgbcalificaciones.RowTemplate.Height = 29;
            dgbcalificaciones.Size = new Size(391, 368);
            dgbcalificaciones.TabIndex = 13;
            // 
            // Fcalificacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 553);
            Controls.Add(dgbcalificaciones);
            Controls.Add(eliminar);
            Controls.Add(modificar);
            Controls.Add(registrar);
            Controls.Add(alumno);
            Controls.Add(dbparcial3);
            Controls.Add(dbparcial2);
            Controls.Add(dbparcial1);
            Controls.Add(dbnombremateria);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Fcalificacion";
            Text = "Fcalificacion";
            ((System.ComponentModel.ISupportInitialize)dgbcalificaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox dbnombremateria;
        private TextBox dbparcial1;
        private TextBox dbparcial2;
        private TextBox dbparcial3;
        private TextBox alumno;
        private Button registrar;
        private Button modificar;
        private Button eliminar;
        private DataGridView dgbcalificaciones;
    }
}