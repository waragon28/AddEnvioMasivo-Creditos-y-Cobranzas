using Forxap.Framework.ServiceLayer;
using SAPbobsCOM;
using SAPbouiCOM.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistony.Masivo.DAL;

namespace Vistony.Distribucion.Win
{
    public class ApplicationEvent
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="EventType"></param>

        Idioma GetIdioma = new Idioma();
        public void SB1_Application_AppEvent(SAPbouiCOM.BoAppEventTypes EventType)
        {
            switch (EventType)
            {
                case SAPbouiCOM.BoAppEventTypes.aet_ShutDown:
                    //Exit Add-On
                    System.Windows.Forms.Application.Exit();
                    break;
                case SAPbouiCOM.BoAppEventTypes.aet_CompanyChanged:
                    // deberia inicializar el addon quizas???? 
                    break;
                case SAPbouiCOM.BoAppEventTypes.aet_FontChanged:
                    break;
                case SAPbouiCOM.BoAppEventTypes.aet_LanguageChanged:
                    SAPbobsCOM.Recordset oRS = (SAPbobsCOM.Recordset)Sb1Globals.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
                
                    Sb1Globals.Idioma = GetIdioma.GetIdiomaSAP(oRS, Sb1Globals.UserName);
                    break;
                case SAPbouiCOM.BoAppEventTypes.aet_ServerTerminition:
                    break;

                    /*IDIOMA*/
               // case SAPbouiCOM.BoAppEventTypes.aet_LanguageChanged:
                   // log.Info("aet_LanguageChanged - init addin");
                    
                  //  Globals.CultureInfo = GetCulture(Application.Language)
                   //     break;


                default:
                    break;
            }
        }




    }// fin de la clase

}// fin del namespace
