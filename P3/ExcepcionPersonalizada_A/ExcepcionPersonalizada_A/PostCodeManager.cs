using System;

namespace ExcepcionPersonalizada_A
{
    public class PostCodeManager
    {
        private string postCode;
    
        public PostCodeManager(){
            postCode = "";
        }
    
        public string getPostCode(){
            return postCode;
        }
    
        public void setPostCode(string pPostCode) {
            // Verifica que debe tener longitud igual a 5
            if (pPostCode.Length != 5) {
                throw new BadPostCodeException("Postcodes must have 5 digits");
            }
        
            // Verifica que cada caracter debe ser un dígito
            for (int i = 0; i < pPostCode.Length; i++) {
                if (!Char.IsDigit(pPostCode[i])) {
                    throw new BadPostCodeException("Postcodes can only contain digits");
                }
            }
        
            // Si no se ha lanzado ninguna excepción llegados a este punto
            // Entonces no hay problema, solo se almacena el nuevo código postal
            postCode = pPostCode;
        }
    }
}