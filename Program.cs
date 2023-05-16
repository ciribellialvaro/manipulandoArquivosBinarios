using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace manipulandoArquivosBinarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 119;
            string nome = "hadouken";
            float casasDecimais = 12.2f;


            FileStream stream = new FileStream("meuarquivo.alvaro",FileMode.OpenOrCreate);
            //precisamos o serializador. Ele pega qualquer formato de dado, e converte para uma cadeia de Bytes
            BinaryFormatter encoder = new BinaryFormatter();

            //encoder.Serialize(stream, 120);
            //encoder.Serialize(stream, "alvaro super inteligente e rico pra cacete");
            //encoder.Serialize(stream, true);


            encoder.Serialize(stream, numero1);
            encoder.Serialize(stream, nome);
            encoder.Serialize(stream, casasDecimais);

            stream.Close();

            //======================= agora trabalhando com listas nos arquivos binários ===============

            List<string> langs = new List<string>();
            langs.Add("C#");
            langs.Add("JS");
            langs.Add("Razor");
            langs.Add("Sql");

            FileStream streamLista = new FileStream("ListaLinguagens", FileMode.OpenOrCreate);
            //precisamos o serializador. Ele pega qualquer formato de dado, e converte para uma cadeia de Bytes
            BinaryFormatter encoderLista = new BinaryFormatter();

            encoderLista.Serialize(streamLista, langs);

            streamLista.Close();


        }
    }
}
