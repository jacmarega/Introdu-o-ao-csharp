using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CriptoStringMD5
{
    class CripoMD5
    {
        public string RetornarMD5(string Senha)
        {
            using (MD5 md5hash = MD5.Create())
            {
                return RetornarHash(md5hash, Senha);
            }
        }
        public bool compararMD5(string senhaentrada, string senhaMD5)
        {
            string senha = RetornarMD5(senhaentrada);
            if (VerificarHash(senhaMD5, senha))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private string RetornarHash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder(); 

            for(int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("X2"));

            }
            return sBuilder.ToString();
        }
        
        private bool VerificarHash(string md5Hash, string hash)
        {
            StringComparer comparar = StringComparer.OrdinalIgnoreCase;
            if(comparar.Compare(md5Hash, hash) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
