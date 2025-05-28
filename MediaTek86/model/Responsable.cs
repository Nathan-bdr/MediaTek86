using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// classe métier interne pour mémoriser les informations d'authentification du responsable
    /// </summary>
    public class Responsable
    {
        public string Login { get; }
        public string Pwd { get; }

        /// <summary>
        /// valorise les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable(string login, string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }
    }
}
