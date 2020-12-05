namespace Proyecto_Integrador
{
    partial class ResultClasification
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
            this.classificationList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // classificationList
            // 
            this.classificationList.HideSelection = false;
            this.classificationList.Location = new System.Drawing.Point(161, 47);
            this.classificationList.Name = "classificationList";
            this.classificationList.Size = new System.Drawing.Size(445, 326);
            this.classificationList.TabIndex = 0;
            this.classificationList.UseCompatibleStateImageBehavior = false;
            // 
            // ClassificationResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.classificationList);
            this.Name = "ClassificationResult";
            this.Text = "ClassificationResult";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView classificationList;
    }
}