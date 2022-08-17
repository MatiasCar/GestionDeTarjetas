using System.Text;

namespace GestionDeTarjetas.Models.Encryption
{
    public class PlataformaSecure
    {
        /**
         * @brief Codifica la contraseña pasada por parametro y la devuelve ya codificada.
         * 
         * @details Se utiliza posteriormente para verificar si el usuario existe en el sistema.
         * **/
        public string Encode(string password)
        {
            try
            {
                int i;
                string sVlCadenaAux = String.Empty;
                string sVlCadenaPares = String.Empty;
                string sVlCadenaImpares = String.Empty;
                string sVlCadenaFinal = String.Empty;

                string hex = String.Empty;
                foreach (char c in password)
                {
                    int tmp = c;
                    hex += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
                }
                sVlCadenaAux = hex.ToUpper();

                for (i = 0; i < sVlCadenaAux.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        sVlCadenaPares += sVlCadenaAux.Substring(i, 1);
                    }
                    else
                    {
                        sVlCadenaImpares += sVlCadenaAux.Substring(i, 1);
                    }

                }

                sVlCadenaAux = sVlCadenaPares + sVlCadenaImpares;

                //'Finalmente la cadena se invierte.
                //'Ej.: 28A15444
                sVlCadenaFinal = "";
                for (i = sVlCadenaAux.Length - 1; i >= 0; i--)
                {
                    sVlCadenaFinal += sVlCadenaAux.Substring(i, 1);
                }

                return sVlCadenaFinal;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /** @brief Algoritmo de desencriptación usado por Plataforma para cifrar las claves de conexión a base de datos
         * */
        public string Decode(string password)
        {
            try
            {
                int i;
                string sVlCadenaAux = String.Empty;
                string sVlCadenaPares = String.Empty;
                string sVlCadenaImpares = String.Empty;
                string sVlCadenaFinal = String.Empty;

                string cadenaAux2 = String.Empty;

                sVlCadenaAux = password;

                //invierto la cadena
                for (i = sVlCadenaAux.Length - 1; i >= 0; i--)
                {
                    cadenaAux2 += sVlCadenaAux.Substring(i, 1);
                }
                //SEPARO EN DOS LA CADENA
                sVlCadenaPares = cadenaAux2.Substring(0, (cadenaAux2.Length / 2));
                sVlCadenaImpares = cadenaAux2.Substring((cadenaAux2.Length / 2));
                //SE UNIFICAN LAS DOS CADENAS EN 1
                i = 0;
                cadenaAux2 = String.Empty;

                while (i < sVlCadenaPares.Length)
                {
                    cadenaAux2 += sVlCadenaPares[i].ToString() + sVlCadenaImpares[i].ToString();
                    i++;
                }

                //SE TRADUCE DE HEXA A STRING   
                int numberChars = cadenaAux2.Length;
                byte[] bytes = new byte[numberChars / 2];
                for (int ind = 0; ind < numberChars; ind += 2)
                {
                    bytes[ind / 2] = Convert.ToByte(cadenaAux2.Substring(ind, 2), 16);
                }

                //sVlCadenaFinal = Encoding.GetEncoding("ISO-8859-1").GetString(bytes, 0, bytes.Length);

                sVlCadenaFinal = Encoding.GetEncoding("us-ascii").GetString(bytes, 0, bytes.Length);
                return sVlCadenaFinal;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
