using System.ComponentModel.DataAnnotations;

namespace IKProjesiAPI.Application.Extensions
{
    public class IdentificationNumberValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            int toplam = 0, ciftToplam = 0, tekToplam = 0;

            if (value == null)
                return false;

            string id = value.ToString();
            if (id.Length != 11 || id[0] == '0') 
                return false;

            

            for (int i = 0; i <= 9; i++) 
            {

                toplam += Convert.ToInt32(id[i].ToString());

                if (i % 2 == 0) 
                    tekToplam += Convert.ToInt32(id[i].ToString());
                else if (i % 2 != 0 && i <= 7) 
                    ciftToplam += Convert.ToInt32(id[i].ToString());
            }

            if ((7 * tekToplam - ciftToplam) % 10 != Convert.ToInt32(id[9].ToString())) 

                return false;


            if (toplam % 10 != Convert.ToInt32(id[10].ToString())) 
                return false;

            return true; 
        }
    }
}

