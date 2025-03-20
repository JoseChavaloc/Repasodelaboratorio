namespace Repasodelaboratorio
{
    partial class FormAsistencia
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
            this.buttoncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttoncerrar
            // 
            this.buttoncerrar.Location = new System.Drawing.Point(611, 59);
            this.buttoncerrar.Name = "buttoncerrar";
            this.buttoncerrar.Size = new System.Drawing.Size(97, 32);
            this.buttoncerrar.TabIndex = 0;
            this.buttoncerrar.Text = "Cerrar";
            this.buttoncerrar.UseVisualStyleBackColor = true;
            this.buttoncerrar.Click += new System.EventHandler(this.buttoncerrar_Click);
            // 
            // FormAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttoncerrar);
            this.Name = "FormAsistencia";
            this.Text = "FormAsistencia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttoncerrar;
    }
}