using System.ComponentModel.DataAnnotations;

namespace CascaApi.Models.Validation
{
    public class UfValidation : ValidationAttribute

    {
        public override bool IsValid(object? value)
        {
            string uf = Convert.ToBase64String(value);
            if (uf == "MG")
            {
                return true;
            }
            else if(uf == "SP")
            {
                return true;
            }
            else if (uf == "RJ")
            {
                return true;
            }
            else if (uf == "ES")
            {
                return true;
            }
            return false;

        }
    }
}
