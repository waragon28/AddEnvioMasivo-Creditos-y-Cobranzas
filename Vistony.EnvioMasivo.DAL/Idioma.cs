using Forxap.Framework.ServiceLayer;
using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vistony.Masivo.DAL
{
    public class Idioma
    {
        public string GetIdiomaSAP(Recordset recordset,string UserLoging)
        {
            string StrHANA = string.Empty;
            StrHANA = string.Format("SELECT FX_LENGUAGE_SAP(TO_INT(\"Language\")) AS \"Idioma\" "+
                                    "FROM \"OUSR\" where \"USER_CODE\" = '{0}'", UserLoging);

            recordset.DoQuery(StrHANA);
            string Idioma = recordset.Fields.Item("Idioma").Value.ToString();
            return  Idioma;
        }
    }
}
