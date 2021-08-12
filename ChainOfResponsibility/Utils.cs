namespace ChainOfResponsibility
{
    public class Utils
    {
        public static string ConcatenaObjeto(object obj, char separador)
        {
            if (obj == null) { return string.Empty; }
            string valores = string.Empty;
            foreach (var item in obj.GetType().GetProperties())
            {
                valores += $"{item.GetValue(obj)}{separador}";
            }

            return valores.Remove(valores.Length - 1);
        }
    }
}
