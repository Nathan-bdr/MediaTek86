using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// classe métier interne pour mémoriser les absences
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        public Absence(int idpersonnel, DateTime datedebut, DateTime datefin, Motif motif)
        {
            this.Idpersonnel = idpersonnel;
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.Motif = motif;
        }

        public int Idpersonnel { get; }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }
        public Motif Motif { get; set; }
    }
}
