using System.Reflection;
using System;
using System.Xml.Linq;
using System.IO;
using System.Collections.Generic;

namespace NVP_Manifest_Creator
{

    public class AppExe
    {
        public static void Main(string[] args)
        {
            foreach (string dll_path in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll", SearchOption.TopDirectoryOnly))
            {
                Assembly assembly = Assembly.LoadFrom(dll_path);
                bool is_any_nodes = false;
                List<NVP_Manifest> nodeitems = new List<NVP_Manifest>();

                foreach (Type type in assembly.GetTypes())
                {
                    var NVP_Manifest_attrs = (NVP_Manifest[])type.GetCustomAttributes(typeof(NVP_Manifest), true);
                    if (NVP_Manifest_attrs.Length > 0)
                    {
                        NVP_Manifest NVP_Manifest_attrs_need = NVP_Manifest_attrs[0];
                        is_any_nodes = true;
                        nodeitems.Add(NVP_Manifest_attrs_need);
                    }
                }

                if (is_any_nodes)
                {
                    //Создаем файл nodeitem с перезаписью
                    var _doc = new XDocument();
                    var _doc_nodeitem_Nodes = new XElement("ArrayOfNodeInfo",
                        new XAttribute("xsd", "http://www.w3.org/2001/XMLSchema"),
                        new XAttribute("xsi", "http://www.w3.org/2001/XMLSchema-instance"));

                    foreach (var nodeitem in nodeitems) 
                    {
                        XElement el_NodeInfo = new XElement("NodeInfo");
                        el_NodeInfo.Add(new XElement("Id", nodeitem.Id));
                        el_NodeInfo.Add(new XElement("PathAssembly", nodeitem.PathAssembly));
                        el_NodeInfo.Add(new XElement("PathExecuteClass", nodeitem.PathExecuteClass));
                        el_NodeInfo.Add(new XElement("CoderName", nodeitem.CoderName));
                        el_NodeInfo.Add(new XElement("Folder", nodeitem.Folder));
                        el_NodeInfo.Add(new XElement("NodeName", nodeitem.NodeName));
                        el_NodeInfo.Add(new XElement("NodeType", nodeitem.NodeType));
                        el_NodeInfo.Add(new XElement("CADType", nodeitem.CADType));
                        el_NodeInfo.Add(new XElement("ViewType", nodeitem.ViewType));
                        el_NodeInfo.Add(new XElement("Text", nodeitem.Text));
                        _doc_nodeitem_Nodes.Add(el_NodeInfo);
                    }

                    string nodeitemPath = dll_path.Replace(".dll", ".nodeitem");

                    _doc.Add(_doc_nodeitem_Nodes);
                    _doc.Save(nodeitemPath);

                    Console.WriteLine(nodeitemPath);
                }
            }

            Console.WriteLine("\nEnd!");
#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}