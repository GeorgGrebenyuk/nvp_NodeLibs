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
                bool is_any_nodes = false;
                //List<NVP_Manifest> nodeitems = new List<NVP_Manifest>();

                Dictionary<string, List<NVP_Manifest>> nodeitems = new Dictionary<string, List<NVP_Manifest>>();

                Assembly assembly = Assembly.LoadFrom(dll_path);
                Type[] types = new Type[] { };
                try
                {
                    types = assembly.GetTypes();
                }
                catch { }
//#if NET6_0 
//                assembly = Assembly.LoadFrom(dll_path);
//                types = assembly.GetTypes();
//#elif NET48
//                assembly = Assembly.ReflectionOnlyLoadFrom(dll_path);
//                types = assembly.GetTypes();
                
//#endif

                foreach (Type type in types)
                {
                    var NVP_Manifest_attrs = (NVP_Manifest[])type.GetCustomAttributes(typeof(NVP_Manifest), true);
                    if (NVP_Manifest_attrs.Length > 0)
                    {
                        NVP_Manifest NVP_Manifest_attrs_need = NVP_Manifest_attrs[0];
                        is_any_nodes = true;

                        //get fill path
                        string cs_path = type.Namespace;
                        if (cs_path.Contains("."))
                        {
                            cs_path = cs_path.Substring(0, cs_path.IndexOf("."));
                        }

                        if (nodeitems.ContainsKey(cs_path)) nodeitems[cs_path].Add(NVP_Manifest_attrs_need);
                        else nodeitems.Add(cs_path, new List<NVP_Manifest> { NVP_Manifest_attrs_need });
                        //nodeitems.Add(NVP_Manifest_attrs_need);
                    }
                }

                if (is_any_nodes)
                {
                    string base_dir = Path.Combine(Path.GetDirectoryName(dll_path), "NPV_Data");
                    if (!Directory.Exists(base_dir)) Directory.CreateDirectory(base_dir);

                    foreach (var nodeitem_File in nodeitems)
                    {
                        //Создаем файл nodeitem с перезаписью
                        var _doc = new XDocument();
                        var _doc_nodeitem_Nodes = new XElement("ArrayOfNodeInfo",
                            new XAttribute("xsd", "http://www.w3.org/2001/XMLSchema"),
                            new XAttribute("xsi", "http://www.w3.org/2001/XMLSchema-instance"));

                        foreach (var nodeitem_Element in nodeitem_File.Value)
                        {
                            XElement el_NodeInfo = new XElement("NodeInfo");
                            el_NodeInfo.Add(new XElement("Id", nodeitem_Element.Id));
                            el_NodeInfo.Add(new XElement("PathAssembly", nodeitem_Element.PathAssembly));
                            el_NodeInfo.Add(new XElement("PathExecuteClass", nodeitem_Element.PathExecuteClass));
                            el_NodeInfo.Add(new XElement("CoderName", nodeitem_Element.CoderName));
                            el_NodeInfo.Add(new XElement("Folder", nodeitem_Element.Folder));
                            el_NodeInfo.Add(new XElement("NodeName", nodeitem_Element.NodeName));
                            el_NodeInfo.Add(new XElement("NodeType", nodeitem_Element.NodeType));
                            el_NodeInfo.Add(new XElement("CADType", nodeitem_Element.CADType));
                            el_NodeInfo.Add(new XElement("ViewType", nodeitem_Element.ViewType));
                            el_NodeInfo.Add(new XElement("Text", nodeitem_Element.Text));
                            _doc_nodeitem_Nodes.Add(el_NodeInfo);
                        }

                        //Сохраняем сразу во вложенной папке NPV_Data
                        string nodeitemPath = Path.Combine(Path.GetDirectoryName(dll_path), 
                            Path.GetFileNameWithoutExtension(dll_path) + "_" + nodeitem_File.Key + ".nodeitem");

                        _doc.Add(_doc_nodeitem_Nodes);
                        _doc.Save(nodeitemPath);

                        Console.WriteLine(nodeitemPath);
                    }
                    
                }
            }

            Console.WriteLine("\nEnd!");
#if DEBUG
            //Console.ReadKey();
#endif
        }
    }
}