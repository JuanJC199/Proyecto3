using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net.NetworkInformation;
namespace Sqlite
{
    static class Program
    {
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


    }

    [SQLiteFunction(Name = "ping", Arguments = 1, FuncType = FunctionType.Scalar)]
    public class pingSQLiteFunction : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            String url = args[0].ToString();
            Ping pingS = new Ping();
            //PingOptions options = new PingOptions();


            try
            {
                var result = pingS.Send(url);
                if (result.Status == IPStatus.Success)
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
            }
            return 0;

        }
    }

    [SQLiteFunction(Name = "pmt", Arguments = 3, FuncType = FunctionType.Scalar)]
    public class PmtSQLiteFunction : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            double tasa_interes = Double.Parse(args[0].ToString());
            int numero_periodos = int.Parse(args[1].ToString());
            double prestamo = Double.Parse(args[2].ToString());
            double v = (1 + (tasa_interes / 12));
            double t = (-(numero_periodos ));
            double result = (prestamo * ((tasa_interes / 12)) / (1 - Math.Pow(v, t)));
            return result;
        }

    }

    [SQLiteFunction(Name = "binadec", Arguments = 1, FuncType = FunctionType.Scalar)]
    public class BinaDecSQLiteFunction : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            String binario = args[0].ToString();
            return Convert.ToInt32(binario, 2);
        }
    }

    [SQLiteFunction(Name = "decabin", Arguments = 1, FuncType = FunctionType.Scalar)]
    public class DecaBinSQLiteFunction : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            int numero = int.Parse(args[0].ToString());
            return Convert.ToString(numero, 2);
        }
    }

    [SQLiteFunction(Name = "CelsaFar", Arguments = 1, FuncType = FunctionType.Scalar)]
    public class CelaFarSQLiteFunction : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            double tempcels = Convert.ToDouble(args[0].ToString());
            return (9 * tempcels / 5) + 32;
        }
    }

    [SQLiteFunction(Name = "FaraCels", Arguments = 1, FuncType = FunctionType.Scalar)]
    public class FaraCelsSQLiteFunction : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            double tempFar = Convert.ToDouble(args[0].ToString());
            return (tempFar-32) / (1.8);
        }
    }

    [SQLiteFunction(Name = "Fact", Arguments = 1, FuncType = FunctionType.Scalar)]
    public class Factorial : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            int num, res = 1;
            num = int.Parse(args[0].ToString());
            for(int i = 1; i <= num; i++)
            {
                res = res * i;
            }
            return res;
        }
    }

    [SQLiteFunction(Name = "decAHex", Arguments = 1, FuncType = FunctionType.Scalar)]
    public class decAHex : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            int decVal = int.Parse(args[0].ToString());
            string hex = decVal.ToString("X");
            return hex;
        }
    }

    [SQLiteFunction(Name = "HexaDec", Arguments = 1, FuncType = FunctionType.Scalar)]
    public class HexaDec : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            string HexVal = args[0].ToString();
            int decVal = Convert.ToInt32(HexVal, 16);
            return decVal;
            
        }
    }

    [SQLiteFunction(Name = "CompareString", Arguments = 2, FuncType = FunctionType.Scalar)]
    public class CompareString : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            string string1 = args[0].ToString();
            string string2 = args[1].ToString();
            int t = 0;
            if (string1.Length==string2.Length)
            {
                return Convert.ToString(t);
            }
            else if(string1.Length < string2.Length)
            {
                t = -1;
                return Convert.ToString(t);
            }
            else
            {
                t = 1;
                return Convert.ToString(t);
            }
        }
    }

    [SQLiteFunction(Name = "trim", Arguments = 2, FuncType = FunctionType.Scalar)]
    public class trimF : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            String cadena = args[0].ToString();
            char caracter = args[1].ToString()[0];
            String temporal = "";
            String resultante = "";
            bool t = true;

            for (int i = 0; i < cadena.Length; i++)
            {
                if (t && cadena[i] == caracter)
                    continue;
                temporal += cadena[i];
                t = false;
            }
            resultante = temporal;

            for (int i = temporal.Length - 1; i >= 0; i--)
            {
                if (temporal[i] == caracter)
                {
                    resultante = resultante.Substring(0, i);
                    continue;
                }
                break;
            }
            return resultante;
        }
    }

    [SQLiteFunction(Name = "Repeat", Arguments = 2, FuncType = FunctionType.Scalar)]
    public class repeatFunc : SQLiteFunction
    {
        public override object Invoke(object[] args)
        {
            string sVal = args[0].ToString();
            int cant = int.Parse(args[1].ToString());
            string[] array = new string[cant];
            IEnumerable<string> strings =Enumerable.Repeat(sVal, cant);
            foreach (String str in strings)
            {
                Console.WriteLine(str);
            }

            return sVal;

        }
    }



}
