using System.Reflection.Metadata;

namespace BT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            object data = "gg driver";
            document.Read();
            document.Write(data);
            string encryptedText = document.Encrypt(plainText, key);
            Console.WriteLine("encrypted:" + encryptedText);
            string decryptedText = document.Decrypt(encryptedText, key);
            Console.WriteLine("decrypted:" + decryptedText);


        }
    }
}