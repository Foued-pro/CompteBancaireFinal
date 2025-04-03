namespace GUICompteBancaire
{
    partial class GestionCompte
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
            listeTransactions = new ListView();
            columnDate = new ColumnHeader();
            columnMontant = new ColumnHeader();
            columnNotes = new ColumnHeader();
            label1 = new Label();
            pickerDate = new DateTimePicker();
            label2 = new Label();
            textBoxMontant = new TextBox();
            label3 = new Label();
            textNotes = new TextBox();
            statusStrip1 = new StatusStrip();
            abelSolde = new ToolStripStatusLabel();
            panelZoom = new Panel();
            buttonSupprimer = new Button();
            buttonAjouter = new Button();
            buttonValider = new Button();
            statusStrip1.SuspendLayout();
            panelZoom.SuspendLayout();
            SuspendLayout();
            // 
            // listeTransactions
            // 
            listeTransactions.Columns.AddRange(new ColumnHeader[] { columnDate, columnMontant, columnNotes });
            listeTransactions.FullRowSelect = true;
            listeTransactions.GridLines = true;
            listeTransactions.Location = new Point(44, 82);
            listeTransactions.MultiSelect = false;
            listeTransactions.Name = "listeTransactions";
            listeTransactions.Size = new Size(446, 317);
            listeTransactions.TabIndex = 0;
            listeTransactions.UseCompatibleStateImageBehavior = false;
            listeTransactions.View = View.Details;
            listeTransactions.SelectedIndexChanged += listeTransactions_SelectedIndexChanged;
            // 
            // columnDate
            // 
            columnDate.Text = "Date";
            columnDate.Width = 120;
            // 
            // columnMontant
            // 
            columnMontant.Text = "Montant";
            columnMontant.TextAlign = HorizontalAlignment.Right;
            columnMontant.Width = 160;
            // 
            // columnNotes
            // 
            columnNotes.Text = "Notes";
            columnNotes.Width = 250;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 50);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Date";
            // 
            // pickerDate
            // 
            pickerDate.Location = new Point(3, 77);
            pickerDate.Name = "pickerDate";
            pickerDate.Size = new Size(179, 23);
            pickerDate.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 115);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 4;
            label2.Text = "Montant";
            label2.Click += label2_Click;
            // 
            // textBoxMontant
            // 
            textBoxMontant.Location = new Point(3, 145);
            textBoxMontant.Name = "textBoxMontant";
            textBoxMontant.Size = new Size(68, 23);
            textBoxMontant.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 198);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Notes";
            // 
            // textNotes
            // 
            textNotes.Location = new Point(3, 216);
            textNotes.Multiline = true;
            textNotes.Name = "textNotes";
            textNotes.Size = new Size(199, 61);
            textNotes.TabIndex = 7;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { abelSolde });
            statusStrip1.Location = new Point(0, 496);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1106, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // abelSolde
            // 
            abelSolde.Name = "abelSolde";
            abelSolde.Size = new Size(0, 17);
            // 
            // panelZoom
            // 
            panelZoom.Controls.Add(pickerDate);
            panelZoom.Controls.Add(label1);
            panelZoom.Controls.Add(textNotes);
            panelZoom.Controls.Add(label2);
            panelZoom.Controls.Add(label3);
            panelZoom.Controls.Add(textBoxMontant);
            panelZoom.Enabled = false;
            panelZoom.Location = new Point(519, 82);
            panelZoom.Name = "panelZoom";
            panelZoom.Size = new Size(217, 317);
            panelZoom.TabIndex = 9;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.Location = new Point(522, 424);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(95, 47);
            buttonSupprimer.TabIndex = 10;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = true;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // buttonAjouter
            // 
            buttonAjouter.Location = new Point(641, 424);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(95, 47);
            buttonAjouter.TabIndex = 11;
            buttonAjouter.Text = "Ajouter";
            buttonAjouter.UseVisualStyleBackColor = true;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // buttonValider
            // 
            buttonValider.Location = new Point(641, 424);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(95, 47);
            buttonValider.TabIndex = 12;
            buttonValider.Text = "Ajouter";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Visible = false;
            buttonValider.Click += buttonValider_Click;
            // 
            // GestionCompte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 518);
            Controls.Add(buttonValider);
            Controls.Add(buttonAjouter);
            Controls.Add(buttonSupprimer);
            Controls.Add(panelZoom);
            Controls.Add(statusStrip1);
            Controls.Add(listeTransactions);
            Name = "GestionCompte";
            Text = "GestionCompte";
            Load += GestionCompte_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panelZoom.ResumeLayout(false);
            panelZoom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listeTransactions;
        private ColumnHeader columnDate;
        private ColumnHeader columnMontant;
        private ColumnHeader columnNotes;
        private Label label1;
        private DateTimePicker pickerDate;
        private Label label2;
        private TextBox textBoxMontant;
        private Label label3;
        private TextBox textNotes;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel abelSolde;
        private Panel panelZoom;
        private Button buttonSupprimer;
        private Button buttonAjouter;
        private Button buttonValider;
    }
}