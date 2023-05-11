using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);

            //Noun.IsNoun("בית שמש");
            //splitSentens.DivisionIntoWords("מירי אלופה אחת אני גם רוצה שתכיני עוגה ");
            //semanticField.findSemanticField("");
            //SendEmail s = new SendEmail();
            //RemovalOfDuplicates.duplicates(Noun.nounsToList(splitSentens.DivisionIntoWords(" מירי זהו שמי ואני שמחה וששון שמחה")));
            //BusinessOwners.listBusinessOners("ירושלים", "זמר");
            //Translate.TranslateWord("ירושלים");

            //List<string> a = RemovalOfDuplicates.duplicates(Noun.nounsToList(splitSentens.DivisionIntoWords("אולם מנות לשמונים איש צלם אני צריכה איזה כיף שצריך לשכור שמלות ולעשות תסרוקות")));
            //for(int i = 0; i < a.Count(); i++)
            //{
            //    BusinessOwners.listBusinessOners("ירושלים", a[i]);
            //}
            //SendEmail.Sendmail("miri053310@gmail.com");
            //SendEmail.Sendmail("g0548545395@gmail.com");
        }
    }
}
