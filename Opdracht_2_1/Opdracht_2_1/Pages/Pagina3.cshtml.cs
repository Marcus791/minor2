using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Opdracht_2_1.Pages
{
    public class Pagina3Model : PageModel
    {
        //Zet hier een public variabele voor de uitkomst

        public void OnGet()
        {
            //lees de twee meegestuurde parameters in
            if (....)   //controleer of de parameters gevuld zijn
            {
                int getal1 = ....  //bepaal de waarde voor getal 1
                //doe hetzelfde voor getal 2
                //bereken de uitkomst
            }
        }
    }
}
