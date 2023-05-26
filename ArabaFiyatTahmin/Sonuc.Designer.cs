namespace ArabaFiyatTahmin
{
    partial class Sonuc
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
            cikis = new Button();
            anaSayfayaDon = new Button();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            enUygunTextBox = new TextBox();
            piyasaFiyatiTextBox = new TextBox();
            pahaliFiyatiTextBox = new TextBox();
            SuspendLayout();
            // 
            // cikis
            // 
            cikis.Location = new Point(478, 208);
            cikis.Name = "cikis";
            cikis.Size = new Size(75, 23);
            cikis.TabIndex = 0;
            cikis.Text = "cikis";
            cikis.UseVisualStyleBackColor = true;
            cikis.Click += cikis_Click;
            // 
            // anaSayfayaDon
            // 
            anaSayfayaDon.Location = new Point(232, 208);
            anaSayfayaDon.Name = "anaSayfayaDon";
            anaSayfayaDon.Size = new Size(114, 23);
            anaSayfayaDon.TabIndex = 1;
            anaSayfayaDon.Text = "Ana Sayfaya Don";
            anaSayfayaDon.UseVisualStyleBackColor = true;
            anaSayfayaDon.Click += anaSayfayaDon_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(752, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(752, 24);
            menuStrip2.TabIndex = 3;
            menuStrip2.Text = "menuStrip2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(566, 60);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 5;
            label1.Text = "en pahali kaca gider";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 60);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 6;
            label2.Text = "piyasa fiyati";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 60);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 7;
            label3.Text = "en uyguna kaca gider";
            // 
            // enUygunTextBox
            // 
            enUygunTextBox.Location = new Point(132, 102);
            enUygunTextBox.Name = "enUygunTextBox";
            enUygunTextBox.Size = new Size(100, 23);
            enUygunTextBox.TabIndex = 12;
            enUygunTextBox.TextChanged += enUygunTextBox_TextChanged;
            // 
            // piyasaFiyatiTextBox
            // 
            piyasaFiyatiTextBox.Location = new Point(337, 102);
            piyasaFiyatiTextBox.Name = "piyasaFiyatiTextBox";
            piyasaFiyatiTextBox.Size = new Size(100, 23);
            piyasaFiyatiTextBox.TabIndex = 13;
            piyasaFiyatiTextBox.TextChanged += piyasaFiyatiTextBox_TextChanged;
            // 
            // pahaliFiyatiTextBox
            // 
            pahaliFiyatiTextBox.Location = new Point(566, 102);
            pahaliFiyatiTextBox.Name = "pahaliFiyatiTextBox";
            pahaliFiyatiTextBox.Size = new Size(100, 23);
            pahaliFiyatiTextBox.TabIndex = 14;
            pahaliFiyatiTextBox.TextChanged += pahaliFiyatiTextBox_TextChanged;
            // 
            // Sonuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 303);
            Controls.Add(pahaliFiyatiTextBox);
            Controls.Add(piyasaFiyatiTextBox);
            Controls.Add(enUygunTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(anaSayfayaDon);
            Controls.Add(cikis);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Sonuc";
            Text = "Arabanizin Tamini Degeri";
            FormClosed += Sonuc_FormClosed;
            Load += Sonuc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cikis;
        private Button anaSayfayaDon;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox enUygunTextBox;
        private TextBox piyasaFiyatiTextBox;
        private TextBox pahaliFiyatiTextBox;
    }
}