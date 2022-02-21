using System.Collections.Generic;

namespace KS.Desktop
{
    public class Configuracao
    {
        public Dictionary<string, Identificacao> Parametros { get; set; }
        public Configuracao() => Parametros = new Dictionary<string, Identificacao>();
    }

    public class Identificacao
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
    }
}
