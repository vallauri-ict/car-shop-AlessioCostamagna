using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace VenditaVeicoliDllProject
{
    [Serializable]
    public class SerializableBindingList<T> : BindingList<T> { }

    public class Utils
    {
        public static IEnumerable<string> ToCsv<T>(IEnumerable<T> objectlist, string separator = "|")
        {
            foreach (var o in objectlist)
            {
                FieldInfo[] fields = o.GetType().GetFields();
                PropertyInfo[] properties = o.GetType().GetProperties();

                yield return string.Join(separator, fields.Select(f => (f.GetValue(o) ?? "").ToString())
                    .Concat(properties.Select(p => (p.GetValue(o, null) ?? "").ToString())).ToArray());
            }
        }

        public static string ToCsvString<T>(IEnumerable<T> objectlist, string separator = "|")
        {
            StringBuilder csvdata = new StringBuilder();
            foreach (var o in objectlist)
            {
                FieldInfo[] fields = o.GetType().GetFields();
                PropertyInfo[] properties = o.GetType().GetProperties();

                csvdata.AppendLine(string.Join(separator, fields.Select(f => (f.GetValue(o) ?? "").ToString())
                    .Concat(properties.Select(p => (p.GetValue(o, null) ?? "").ToString())).ToArray()));
            }
            return csvdata.ToString();
        }

        public static void SerializeToCsv<T>(IEnumerable<T> objectlist, string pathName, string separator = "|")
        {
            IEnumerable<string> dataToSave = Utils.ToCsv(objectlist, separator);
            File.WriteAllLines(pathName, dataToSave);
        }

        public static void SerializeToXml<T>(SerializableBindingList<T> objectlist, string pathName)
        {
            XmlSerializer x = new XmlSerializer(typeof(SerializableBindingList<T>));
            TextWriter writer = new StreamWriter(pathName);
            x.Serialize(writer, objectlist);
        }

        //public static void SerializeToJson<T>(IEnumerable<T> objectlist, string pathName)
        //{
        //    string json = JsonConvert.SerializeObject(objectlist, Formatting.Indented);
        //    File.WriteAllText(pathName, json);
        //}

        public static void CreateHtml(SerializableBindingList<Veicolo> l, string index = ".\\www\\index.html", string index_skeleton = ".\\www\\indexSkeleton.html")
        {
            string html = File.ReadAllText(index_skeleton);
            string newElements = "";
            foreach (Veicolo v in l)
            {
                newElements += $"<tr><td>{v.Targa}</td><td>{v.Marca}</td><td>{v.Modello}</td></tr>";
            }
            html = html.Replace("{{mainContent}}", newElements);
            html = html.Replace("{{mainTitle}}", "carShop");
            html = html.Replace("{{subTitle}}", "Cerca il tuo amico!");
            File.WriteAllText(index, html);
            System.Diagnostics.Process.Start(index);
        }
    }
}
