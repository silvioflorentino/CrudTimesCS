using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudTimesCS.model
{
    public class Times
    {
       private static int codTimes;
       private static string nomeTimes;
       private static Array logoTimes;
       private static string fraseTimes;
       private static string retorno;

        public static int CodTimes { get => codTimes; set => codTimes = value; }
        public static string NomeTimes { get => nomeTimes; set => nomeTimes = value; }
        public static string FraseTimes { get => fraseTimes; set => fraseTimes = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
        public static Array LogoTimes { get => logoTimes; set => logoTimes = value; }
    }
}
