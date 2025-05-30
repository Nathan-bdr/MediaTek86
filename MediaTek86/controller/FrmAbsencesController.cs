using MediaTek86.dal;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.controller
{
    /// <summary>
    /// contrôleur de FrmAbsence
    /// </summary>
    public class FrmAbsencesController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Absence
        /// </summary>
        private readonly AbsenceAccess absenceAccess;

        /// <summary>
        /// objet d'accès aux opérations possibles sur Motif
        /// </summary>
        private readonly MotifAccess motifAccess;

        /// <summary>
        /// récupère les accès aux données
        /// </summary>
        public FrmAbsencesController()
        {
            absenceAccess = new AbsenceAccess();
            motifAccess = new MotifAccess();
        }

        /// <summary>
        /// récupère et retourne les infos des absences
        /// </summary>
        /// <returns>liste des absences</returns>
        public List<Absence> GetLesAbsences(int id)
        {
            return absenceAccess.GetLesAbsences(id);
        }

        /// <summary>
        /// récupère et retourne les infos des motifs
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        /// <summary>
        /// demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }

        /// <summary>
        /// demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }

        /// <summary>
        /// demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            absenceAccess.UpdateAbsence(absence);
        }

        public void StockageDates(DateTime dateDebut, DateTime dateFin)
        {
            absenceAccess.StockageDates(dateDebut, dateFin);
        }
    }
}
