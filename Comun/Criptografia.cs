using System;
using System.Configuration;
using System.Text;
using System.Security.Cryptography;

namespace Comun
{
    public class Criptografia
    {
        private static readonly Criptografia instancia = new Criptografia();
        public static Criptografia Get => instancia;
        private Criptografia()
        {
        }


        // /// <summary>
        // /// Hashes a text using MD5 algorithm
        // /// </summary>
        // /// <param name="value">text to hash</param>
        // /// <returns>hashed text (Base64String)</returns>
        public string GetHashMD5(string value)
        {
            UnicodeEncoding Ue = new UnicodeEncoding();
            byte[] ByteSourceText = Ue.GetBytes(value);
            MD5CryptoServiceProvider Md5 = new MD5CryptoServiceProvider();
            // //obtener el valor del hash value desde el origen (byteSurceText)
            byte[] ByteHash = Md5.ComputeHash(ByteSourceText);
            Md5.Clear();
            // //retornarlo como un string
            return Convert.ToBase64String(ByteHash);
        }

        // /// <summary>
        // /// Compares a Hash agains a non hashed value
        // /// </summary>
        // /// <param name="value">value to evaluate</param>
        // /// <param name="hash">hash to evaluate against</param>
        // /// <returns>True if the hash matches</returns>
        public bool CompareHashMD5(string value, string hash)
        {
            return (hash.Equals(GetHashMD5(value)));
        }

        // /// <summary>
        // /// Cypher a text with TripleDES algorithm
        // /// </summary>
        // /// <param name="toEncrypt">text to cypher</param>
        // /// <param name="key">key to cypher</param>
        // /// <param name="useHashing">true if the key must be hashed (more secure)</param>
        // /// <returns>cypher text</returns>
        public string CypherTripleDES(string toEncrypt, string key, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);

            AppSettingsReader settingsReader = new AppSettingsReader();

            // //System.Windows.Forms.MessageBox.Show(key);
            // //If hashing use get hashcode regards to your key
            if ((useHashing))
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));
                // //Always release the resources and flush data
                // // of the Cryptographic service provide. Best Practice
                hashmd5.Clear();
            }
            else
                keyArray = Encoding.UTF8.GetBytes(key);
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            // //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            // //mode of operation. there are other 4 modes.
            // //We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;
            // //padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateEncryptor();
            // //transform the specified region of bytes array to resultArray
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            // //Release resources held by TripleDes Encryptor
            tdes.Clear();
            // //Return the encrypted data into unreadable string format
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        // /// <summary>
        // /// Decypher a text using the TripleDES algorithm
        // /// </summary>
        // /// <param name="toEncrypt">text to decypher</param>
        // /// <param name="key">key to decypher</param>
        // /// <param name="useHashing">true if the key must be hashed (more secure)</param>
        // /// <returns>clear text</returns>
        public string DecypherTripleDES(string cipherString, string key, bool useHashing)
        {
            string strResult = cipherString;
            try
            {
                byte[] keyArray;
                // //get the byte code of the string
                byte[] toEncryptArray = Convert.FromBase64String(cipherString);
                if (useHashing)
                {

                    // //if hashing was used get the hash code with regards to your key
                    MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));
                    // //release any resource held by the MD5CryptoServiceProvider
                    hashmd5.Clear();
                }
                else

                    // //if hashing was not implemented get the byte code of the key
                    keyArray = Encoding.UTF8.GetBytes(key);
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                // //set the secret key for the tripleDES algorithm
                tdes.Key = keyArray;
                // //mode of operation. there are other 4 modes. 
                // //We choose ECB(Electronic code Book)
                tdes.Mode = CipherMode.ECB;
                // //padding mode(if any extra byte added)
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                // //Release resources held by TripleDes Encryptor                
                tdes.Clear();
                // //return the Clear decrypted TEXT
                strResult = Encoding.UTF8.GetString(resultArray);
            }
            catch(Exception ex)
            {
                throw ex; 
            }
            return strResult;
        }
    }
}
