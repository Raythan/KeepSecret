using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace KS.Lib
{
    public class Configuracao
    {
        public Dictionary<string, string> Parametros { get; set; }
        public Configuracao() => Parametros = new Dictionary<string, string>();
    }
}
