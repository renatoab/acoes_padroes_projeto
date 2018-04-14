namespace Acoes
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textBoxAsset = new System.Windows.Forms.TextBox();
            this.checkBoxAllAsset = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.checkBoxLastYear = new System.Windows.Forms.CheckBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(37, 35);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(120, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "1 - Carregar arquivo";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // textBoxAsset
            // 
            this.textBoxAsset.Location = new System.Drawing.Point(185, 35);
            this.textBoxAsset.Name = "textBoxAsset";
            this.textBoxAsset.Size = new System.Drawing.Size(134, 20);
            this.textBoxAsset.TabIndex = 1;
            // 
            // checkBoxAllAsset
            // 
            this.checkBoxAllAsset.AutoSize = true;
            this.checkBoxAllAsset.Enabled = false;
            this.checkBoxAllAsset.Location = new System.Drawing.Point(345, 35);
            this.checkBoxAllAsset.Name = "checkBoxAllAsset";
            this.checkBoxAllAsset.Size = new System.Drawing.Size(101, 17);
            this.checkBoxAllAsset.TabIndex = 2;
            this.checkBoxAllAsset.Text = "Todos os ativos";
            this.checkBoxAllAsset.UseVisualStyleBackColor = true;
            this.checkBoxAllAsset.Visible = false;
            this.checkBoxAllAsset.CheckedChanged += new System.EventHandler(this.checkBoxAllAsset_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "2 - Nome do ativo (deixe em branco para todos)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(37, 64);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(120, 23);
            this.buttonProcess.TabIndex = 0;
            this.buttonProcess.Text = "3 - Consultar";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // checkBoxLastYear
            // 
            this.checkBoxLastYear.AutoSize = true;
            this.checkBoxLastYear.Checked = true;
            this.checkBoxLastYear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLastYear.Location = new System.Drawing.Point(345, 58);
            this.checkBoxLastYear.Name = "checkBoxLastYear";
            this.checkBoxLastYear.Size = new System.Drawing.Size(76, 17);
            this.checkBoxLastYear.TabIndex = 2;
            this.checkBoxLastYear.Text = "Último ano";
            this.checkBoxLastYear.UseVisualStyleBackColor = true;
            this.checkBoxLastYear.Visible = false;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(37, 130);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(409, 145);
            this.textBoxResult.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(185, 81);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(134, 20);
            this.textBoxData.TabIndex = 1;
            this.textBoxData.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data base";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(325, 81);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(121, 43);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "4 - Recuperar busca anterior";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 302);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxLastYear);
            this.Controls.Add(this.checkBoxAllAsset);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.textBoxAsset);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.buttonOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox textBoxAsset;
        private System.Windows.Forms.CheckBox checkBoxAllAsset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.CheckBox checkBoxLastYear;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBack;
    }
}

