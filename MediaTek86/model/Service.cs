using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// classe métier interne pour mémoriser les informations sur les services
    /// </summary>
    public class Service
    {
        public int Idservice { get; }
        public string Nom {  get; }

        /// <summary>
        /// valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.Idservice = idservice;
            this.Nom = nom;
        }

        public override string ToString()
        {
            return this.Nom;
        }
    }
}
