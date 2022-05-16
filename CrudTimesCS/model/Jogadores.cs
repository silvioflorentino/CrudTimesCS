using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudTimesCS.model
{
    public class Jogadores
    {
       private static int codJogadores;
       private static string nomeJogadores;
       private static string emailJogadores;
       private static string foneJogadores;
       private static string retorno;

        public static int CodJogadores { get => codJogadores; set => codJogadores = value; }
        public static string NomeJogadores { get => nomeJogadores; set => nomeJogadores = value; }
        public static string EmailJogadores { get => emailJogadores; set => emailJogadores = value; }
        public static string FoneJogadores { get => foneJogadores; set => foneJogadores = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
