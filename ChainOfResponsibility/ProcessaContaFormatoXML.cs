using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ChainOfResponsibility
{
    public class ProcessaContaFormatoXML : IProcessaFormato
    {
        public IProcessaFormato ProximoProcesso { get; private set; }
        public ProcessaContaFormatoXML(IProcessaFormato proximo)
        {
            ProximoProcesso = proximo;
        }
        public string FormataConta(Conta conta, Formato formato)
        {
            if (formato == Formato.XML)
            {
                var xmlserializer = new XmlSerializer(typeof(Conta));
                var stringWriter = new StringWriter();
                using var writer = XmlWriter.Create(stringWriter);
                xmlserializer.Serialize(writer, conta);
                return stringWriter.ToString();
            }

            return ProximoProcesso.FormataConta(conta, formato);
        }
    }
}
