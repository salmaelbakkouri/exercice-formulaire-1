
namespace exercice_formulaire_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ajouterBTN = new System.Windows.Forms.Button();
            this.modifierBTN = new System.Windows.Forms.Button();
            this.supprimerBTN = new System.Windows.Forms.Button();
            this.confirmerBTN = new System.Windows.Forms.Button();
            this.annulerBTN = new System.Windows.Forms.Button();
            this.nomLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.personneLabel = new System.Windows.Forms.Label();
            this.nomTextbox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.personneComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ajouterBTN
            // 
            this.ajouterBTN.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ajouterBTN.Location = new System.Drawing.Point(145, 284);
            this.ajouterBTN.Name = "ajouterBTN";
            this.ajouterBTN.Size = new System.Drawing.Size(144, 38);
            this.ajouterBTN.TabIndex = 0;
            this.ajouterBTN.Text = "Ajouter";
            this.ajouterBTN.UseVisualStyleBackColor = true;
            this.ajouterBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // modifierBTN
            // 
            this.modifierBTN.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.modifierBTN.Location = new System.Drawing.Point(299, 284);
            this.modifierBTN.Name = "modifierBTN";
            this.modifierBTN.Size = new System.Drawing.Size(144, 38);
            this.modifierBTN.TabIndex = 1;
            this.modifierBTN.Text = "Modifier";
            this.modifierBTN.UseVisualStyleBackColor = true;
            this.modifierBTN.Click += new System.EventHandler(this.modifierBTN_Click);
            // 
            // supprimerBTN
            // 
            this.supprimerBTN.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.supprimerBTN.Location = new System.Drawing.Point(456, 284);
            this.supprimerBTN.Name = "supprimerBTN";
            this.supprimerBTN.Size = new System.Drawing.Size(144, 38);
            this.supprimerBTN.TabIndex = 2;
            this.supprimerBTN.Text = "Supprimer";
            this.supprimerBTN.UseVisualStyleBackColor = true;
            this.supprimerBTN.Click += new System.EventHandler(this.supprimerBTN_Click);
            // 
            // confirmerBTN
            // 
            this.confirmerBTN.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmerBTN.Location = new System.Drawing.Point(228, 336);
            this.confirmerBTN.Name = "confirmerBTN";
            this.confirmerBTN.Size = new System.Drawing.Size(144, 38);
            this.confirmerBTN.TabIndex = 3;
            this.confirmerBTN.Text = "Confirmer";
            this.confirmerBTN.UseVisualStyleBackColor = true;
            this.confirmerBTN.Click += new System.EventHandler(this.confirmerBTN_Click);
            // 
            // annulerBTN
            // 
            this.annulerBTN.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.annulerBTN.Location = new System.Drawing.Point(380, 336);
            this.annulerBTN.Name = "annulerBTN";
            this.annulerBTN.Size = new System.Drawing.Size(144, 38);
            this.annulerBTN.TabIndex = 4;
            this.annulerBTN.Text = "Annuler";
            this.annulerBTN.UseVisualStyleBackColor = true;
            this.annulerBTN.Click += new System.EventHandler(this.annulerBTN_Click);
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomLabel.Location = new System.Drawing.Point(209, 112);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(48, 21);
            this.nomLabel.TabIndex = 5;
            this.nomLabel.Text = "Nom";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ageLabel.Location = new System.Drawing.Point(209, 195);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(40, 21);
            this.ageLabel.TabIndex = 6;
            this.ageLabel.Text = "Age";
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prenomLabel.Location = new System.Drawing.Point(209, 153);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(71, 21);
            this.prenomLabel.TabIndex = 7;
            this.prenomLabel.Text = "Prenom";
            // 
            // personneLabel
            // 
            this.personneLabel.AutoSize = true;
            this.personneLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personneLabel.Location = new System.Drawing.Point(209, 236);
            this.personneLabel.Name = "personneLabel";
            this.personneLabel.Size = new System.Drawing.Size(83, 21);
            this.personneLabel.TabIndex = 8;
            this.personneLabel.Text = "Personne";
            // 
            // nomTextbox
            // 
            this.nomTextbox.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomTextbox.Location = new System.Drawing.Point(299, 109);
            this.nomTextbox.Name = "nomTextbox";
            this.nomTextbox.Size = new System.Drawing.Size(205, 27);
            this.nomTextbox.TabIndex = 9;
            this.nomTextbox.TextChanged += new System.EventHandler(this.nomTextbox_TextChanged);
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prenomTextBox.Location = new System.Drawing.Point(299, 150);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(205, 27);
            this.prenomTextBox.TabIndex = 10;
            this.prenomTextBox.TextChanged += new System.EventHandler(this.prenomTextBox_TextChanged);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ageTextBox.Location = new System.Drawing.Point(299, 196);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(205, 27);
            this.ageTextBox.TabIndex = 11;
            this.ageTextBox.TextChanged += new System.EventHandler(this.ageTextBox_TextChanged);
            // 
            // personneComboBox
            // 
            this.personneComboBox.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.personneComboBox.FormattingEnabled = true;
            this.personneComboBox.Location = new System.Drawing.Point(299, 237);
            this.personneComboBox.Name = "personneComboBox";
            this.personneComboBox.Size = new System.Drawing.Size(205, 28);
            this.personneComboBox.TabIndex = 12;
            this.personneComboBox.SelectedIndexChanged += new System.EventHandler(this.etudiantComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.personneComboBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(this.nomTextbox);
            this.Controls.Add(this.personneLabel);
            this.Controls.Add(this.prenomLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.annulerBTN);
            this.Controls.Add(this.confirmerBTN);
            this.Controls.Add(this.supprimerBTN);
            this.Controls.Add(this.modifierBTN);
            this.Controls.Add(this.ajouterBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajouterBTN;
        private System.Windows.Forms.Button modifierBTN;
        private System.Windows.Forms.Button supprimerBTN;
        private System.Windows.Forms.Button confirmerBTN;
        private System.Windows.Forms.Button annulerBTN;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label personneLabel;
        private System.Windows.Forms.TextBox nomTextbox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.ComboBox personneComboBox;
    }
}

