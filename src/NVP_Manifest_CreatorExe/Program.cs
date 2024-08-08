using System.Reflection;
using System;
using System.Xml.Linq;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace NVP_Manifest_Creator
{
    public class Auxiliary_Guids_Map_Item
    {
        public string Path { get; set; }
        public string Id { get; set; }
    }
    public class Auxiliary_Guids_Map
    {
        [XmlIgnore]
        public Dictionary<string, string> ElementsMap2 { get; set; }

        public List<Auxiliary_Guids_Map_Item> ElementsMap;

        public Auxiliary_Guids_Map()
        {
            this.ElementsMap = new List<Auxiliary_Guids_Map_Item>();
            this.ElementsMap2 = new Dictionary<string, string>();
        }

        public static Auxiliary_Guids_Map LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath)) return new Auxiliary_Guids_Map();

            Auxiliary_Guids_Map data;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Auxiliary_Guids_Map));

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                data = xmlSerializer.Deserialize(fs) as Auxiliary_Guids_Map;
            }

            foreach (var item in data.ElementsMap)
            {
                if (!data.ElementsMap2.ContainsKey(item.Path)) data.ElementsMap2.Add(item.Path, item.Id);
            }

            return data;
        }

        public void Save(string savePath)
        {
            ElementsMap = new List<Auxiliary_Guids_Map_Item>();
            foreach (var item in ElementsMap2)
            {
                Auxiliary_Guids_Map_Item def = new Auxiliary_Guids_Map_Item();
                def.Path = item.Key;
                def.Id = item.Value;
                ElementsMap.Add(def);
            }
            XmlSerializer formatter = new XmlSerializer(typeof(Auxiliary_Guids_Map));
            // сохранение массива в файл
            if (File.Exists(savePath)) File.Delete(savePath);
            using (FileStream fs = new FileStream(savePath, FileMode.CreateNew))
            {
                formatter.Serialize(fs, this);
            }
        }
    }
    public class AppExe
    {
        private const string _CoderName = "GeorgGrebenyuk";
        public static void Main(string[] args)
        {
            string sade_directory = AppDomain.CurrentDomain.BaseDirectory;
            string root_repo_path = new DirectoryInfo(sade_directory).Parent.Parent.Parent.FullName;
            foreach (string dll_path in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll", SearchOption.TopDirectoryOnly))
            {
                bool is_any_nodes = false;
                //List<NVP_Manifest> nodeitems = new List<NVP_Manifest>();
                string dll_name = Path.GetFileNameWithoutExtension(dll_path);
                string dll_nameDLL = Path.GetFileName(dll_path);
                string guids_map_path = Path.Combine(root_repo_path, "src", dll_name, dll_name + "_guids_map.xml");
                Auxiliary_Guids_Map guids_map = Auxiliary_Guids_Map.LoadFromFile(guids_map_path);

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
                        string nvp_node_path = type.Namespace + "." + type.Name;
                        if (cs_path.Contains("."))
                        {
                            cs_path = cs_path.Substring(0, cs_path.IndexOf("."));
                        }


                        NVP_Manifest_attrs_need.PathAssembly = dll_nameDLL;
                        NVP_Manifest_attrs_need.PathExecuteClass = nvp_node_path;
                        NVP_Manifest_attrs_need.Folder = dll_name + "." + type.Namespace;
                        NVP_Manifest_attrs_need.CoderName = _CoderName;

                        if (guids_map.ElementsMap2.ContainsKey(nvp_node_path)) NVP_Manifest_attrs_need.Id = guids_map.ElementsMap2[nvp_node_path];
                        else
                        {
                            if (NVP_Manifest_attrs_need.Id != null) 
                            {
                                guids_map.ElementsMap2.Add(nvp_node_path, NVP_Manifest_attrs_need.Id);
                            }
                            else
                            {
                                NVP_Manifest_attrs_need.Id = Guid.NewGuid().ToString("D").ToUpper();
                                guids_map.ElementsMap2.Add(nvp_node_path, NVP_Manifest_attrs_need.Id);
                            }
                        }

                        if (NVP_Manifest_attrs_need.CADType == null) NVP_Manifest_attrs_need.CADType = "None";
                        if (NVP_Manifest_attrs_need.NodeType == null) NVP_Manifest_attrs_need.NodeType = "Loaded";
                        if (NVP_Manifest_attrs_need.ViewType == null) NVP_Manifest_attrs_need.ViewType = "Modifier";
                        if (NVP_Manifest_attrs_need.Text == null) NVP_Manifest_attrs_need.Text = "";


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

                    guids_map.Save(guids_map_path);
                    Console.WriteLine("guids map SAVE " + guids_map_path);
                }
            }

            Console.WriteLine("\nEnd!");
#if DEBUG
            //Console.ReadKey();
#endif
        }
    }
}