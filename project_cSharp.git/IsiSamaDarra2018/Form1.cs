using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsiSamaDarra2018
{
    public partial class frmTuteur : Form
    {
        public frmTuteur()
        {
            InitializeComponent();
        }

        bd_samadaraEntities db = new bd_samadaraEntities();

        private void frmTuteur_Load(object sender, EventArgs e)
        {
            dgTuteur.DataSource = db.tuteur.ToList();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            tuteur t = new tuteur();
            t.nom = txtNom.Text;
            t.prenom = txtPrenom.Text;
            t.adresse = txtAdresse.Text;
            t.email = txtEmail.Text;
            t.civilite = cbbCivilite.Text;
            t.tel = txtTel.Text;
            t.parente = txtParente.Text;
            t.cni = txtCni.Text;
            db.tuteur.Add(t);
            db.SaveChanges();
            effacer();
        }

        private void effacer()
        {
            txtCni.Clear();
            txtAdresse.Clear();
            txtEmail.Clear();
            txtNom.Clear();
            txtParente.Clear();
            txtPrenom.Clear();
            txtTel.Clear();
            cbbCivilite.Text = string.Empty;
            dgTuteur.DataSource = db.tuteur.ToList();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtNom.Text = dgTuteur.CurrentRow.Cells[1].Value.ToString();
            txtPrenom.Text = dgTuteur.CurrentRow.Cells[2].Value.ToString();
            txtAdresse.Text = dgTuteur.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgTuteur.CurrentRow.Cells[4].Value.ToString();
            txtTel.Text = dgTuteur.CurrentRow.Cells[5].Value.ToString();
            cbbCivilite.Text = dgTuteur.CurrentRow.Cells[6].Value.ToString();
            txtParente.Text = dgTuteur.CurrentRow.Cells[7].Value.ToString();
            txtCni.Text = dgTuteur.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? i = int.Parse(dgTuteur.CurrentRow.Cells[0].Value.ToString());
            tuteur t = db.tuteur.Find(i);
            t.nom = txtNom.Text;
            t.prenom = txtPrenom.Text;
            t.adresse = txtAdresse.Text;
            t.email = txtEmail.Text;
            t.civilite = cbbCivilite.Text;
            t.tel = txtTel.Text;
            t.parente = txtParente.Text;
            t.cni = txtCni.Text;
            db.SaveChanges();
            effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? i = int.Parse(dgTuteur.CurrentRow.Cells[0].Value.ToString());
            tuteur t = db.tuteur.Find(i);
            db.tuteur.Remove(t);
            db.SaveChanges();
            effacer();
        }
    }
}
