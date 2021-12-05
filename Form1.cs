using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercice_formulaire_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstPersonnes = new List<personne>();
        }
        // creation d'une liste de type personne 

        List<personne> lstPersonnes;

        //creation des variables de types booleean pour gerer le comportement
        //de button confirmer apres le click sur chacqune de ces 3 boutons
      
        private bool ajouterBtnWasClicked = false;
        private bool supprimerBtnWasClicked = false;
        private bool modifierBtnWasClicked = false;

        //mise de toutes les boutons inclickable sauf le bouton ajouter lors de chargement du formulaire ( etat initial)
        //mise de possibilite de selectionner un personne deja existant dans la liste et manipuler ses donnnees
        private void Form1_Load(object sender, EventArgs e)
        {
            ajouterBTN.Enabled = true;
            modifierBTN.Enabled = false;
            supprimerBTN.Enabled = false;
            confirmerBTN.Enabled = false;
            annulerBTN.Enabled = false;
            nomTextbox.Enabled = false;
            prenomTextBox.Enabled = false;
            ageTextBox.Enabled = false;
            personneComboBox.Enabled = true;

            personne p1 = new personne();
            p1.nom = "el bakkouri";
            p1.prenom = "salma";
            p1.age = "18";
            lstPersonnes.Add(p1);
            personneComboBox.Items.Add(p1.nom + " " + p1.prenom + " " + p1.age);

            personne p2 = new personne();
            p2.nom = "amrani";
            p2.prenom = "karim";
            p2.age = "19";
            lstPersonnes.Add(p2);
            personneComboBox.Items.Add(p2.nom + " " + p2.prenom + " " + p2.age);

            personne p3 = new personne();
            p3.nom = "alami";
            p3.prenom = "amine";
            p3.age = "18";
            lstPersonnes.Add(p3);
            personneComboBox.Items.Add(p3.nom + " " + p3.prenom + " " + p3.age);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            ajouterBtnWasClicked = true;
            supprimerBTN.Enabled = false;
            nomTextbox.Enabled = true;
            prenomTextBox.Enabled = true;
            ageTextBox.Enabled = true;
            personneComboBox.Enabled = true;
        }

        // methode qui verifie un groupe d'expressions booleeans et stocke le resultat dans la permission
        // de click des buttons confirmer et modifier
        private void SetButton()
        {
            ajouterBTN.Enabled = false;
            confirmerBTN.Enabled = (nomTextbox.Text != "") && (prenomTextBox.Text != "") && (ageTextBox.Text != "");
            annulerBTN.Enabled = (nomTextbox.Text != "") && (prenomTextBox.Text != "") && (ageTextBox.Text != "");
        }

        // l'execution de la methode ci dessus lors du remplissage  des champs des donnees
        private void nomTextbox_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void prenomTextBox_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {
            SetButton();
        }


        private void annulerBTN_Click(object sender, EventArgs e)
        {
            nomTextbox.Text = "";
            prenomTextBox.Text = "";
            ageTextBox.Text = "";
            ajouterBTN.Enabled = true;
            personneComboBox.Enabled = true;
            if (personneComboBox.SelectedItem != null)
            {
                modifierBTN.Enabled = true;
                supprimerBTN.Enabled = true;
            }
        }

        // creation de trois conditions qui verifient quel button a ete clicke avant le bouton confirmer 
        private void confirmerBTN_Click(object sender, EventArgs e)
        {
            if (ajouterBtnWasClicked == true)
            {
                personneComboBox.Enabled = true;
                personne p = new personne();
                p.nom = nomTextbox.Text;
                p.prenom = prenomTextBox.Text;
                p.age = ageTextBox.Text;
                lstPersonnes.Add(p);
                personneComboBox.Items.Add(p.nom + " " + p.prenom + " " + p.age);
                ajouterBtnWasClicked = false;
                ajouterBTN.Enabled = true;

            }
            else if (supprimerBtnWasClicked == true)
            {
                personneComboBox.Items.Remove(personneComboBox.SelectedItem);
                nomTextbox.Text = "";
                prenomTextBox.Text = "";
                ageTextBox.Text = "";
                ajouterBTN.Enabled = true;
                supprimerBtnWasClicked = false;

            }
            else if (modifierBtnWasClicked == true)
            {
                personneComboBox.Items.Remove(personneComboBox.SelectedItem);
                personne p = new personne();
                p.nom = nomTextbox.Text;
                p.prenom = prenomTextBox.Text;
                p.age = ageTextBox.Text;
                lstPersonnes.Add(p);
                personneComboBox.Items.Add(p.nom + " " + p.prenom + " " + p.age);
                ajouterBTN.Enabled = true;
                modifierBtnWasClicked = false;
            }

        }

        //remplissage des champs de donnnes par les donnees selectionne dans la combobox
        private void etudiantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            personne prsSelectionne = lstPersonnes[personneComboBox.SelectedIndex];
            nomTextbox.Text = prsSelectionne.nom;
            prenomTextBox.Text = prsSelectionne.prenom;
            ageTextBox.Text = prsSelectionne.age;
            modifierBTN.Enabled = true;
            supprimerBTN.Enabled = true;
            nomTextbox.Enabled = true;
            prenomTextBox.Enabled = true;
            ageTextBox.Enabled = true;
            confirmerBTN.Enabled = false;
            annulerBTN.Enabled = false;

        }

        private void modifierBTN_Click(object sender, EventArgs e)
        {
            modifierBtnWasClicked = true;
            supprimerBTN.Enabled = false;
            modifierBTN.Enabled = false;
            confirmerBTN.Enabled = true;
            annulerBTN.Enabled = true;
        }

        private void supprimerBTN_Click(object sender, EventArgs e)
        {
            supprimerBtnWasClicked = true;
            modifierBTN.Enabled = false;
            supprimerBTN.Enabled = false;
            confirmerBTN.Enabled = true;
            annulerBTN.Enabled = true;
        }
    }
}
