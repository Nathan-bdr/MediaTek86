using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// classe métier interne pour mémoriser les motifs d'absences
    /// </summary>
    public class Motif
    {
        public int Idmotif { get; }
        public string Libelle { get; }

        /// <summary>
        /// valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.Idmotif = idmotif;
            this.Libelle = libelle;
        }

        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
