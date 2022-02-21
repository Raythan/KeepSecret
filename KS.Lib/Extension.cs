using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace KS.Lib
{
    public static class Extension
    {
        private static readonly string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
            fileConfig = "f0fa8b1b85c3d69145a410aad5ef6594e27b9fc8.txt", // jsonConfig (sha1)
            fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
        private static readonly string combinedConfigPath = $"{assemblyPath}\\{fileConfig}";
        private static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }
        private static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
        public static void CarregarArquivoConfiguracao(this Configuracao configuracao)
        {
            if (File.Exists(combinedConfigPath))
                using (var sr = new StreamReader(combinedConfigPath))
                    configuracao = JsonConvert.DeserializeObject<Configuracao>(Base64Decode(sr.ReadToEnd()));
        }
        public static void SalvarConfiguracao(this Configuracao configuracao)
        {
            if (!File.Exists(combinedConfigPath))
            {
                File.Create(combinedConfigPath).Dispose();
                configuracao.SalvarConfiguracao();
            }
            else
                using (StreamWriter sw = new(combinedConfigPath))
                    sw.Write(Base64Encode(JsonConvert.SerializeObject(configuracao)));
        }
    }
}
