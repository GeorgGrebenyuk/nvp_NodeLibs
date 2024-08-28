using System.Reflection;
using System;
using System.Xml.Linq;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using NVP.API.Nodes;

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
        private static void Run()
        {
            string sade_directory = AppDomain.CurrentDomain.BaseDirectory;
            string root_repo_path = new DirectoryInfo(sade_directory).Parent.Parent.Parent.FullName;

            string help_md_path = Path.Combine(root_repo_path, "docs", "help");
            //if (Directory.Exists(help_md_path)) Directory.Delete(help_md_path, true);
            Directory.CreateDirectory(help_md_path);

            foreach (string dll_path in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll", SearchOption.TopDirectoryOnly))
            {
                bool is_any_nodes = false;
                //List<NVP_Manifest> nodeitems = new List<NVP_Manifest>();
                string dll_name = Path.GetFileNameWithoutExtension(dll_path);
                string dll_nameDLL = Path.GetFileName(dll_path);
                string guids_map_path = Path.Combine(root_repo_path, "src", dll_name, dll_name + "_guids_map.xml");
                string help_mdFile_path = Path.Combine(help_md_path, dll_name + "_help.md");

                Auxiliary_Guids_Map guids_map = Auxiliary_Guids_Map.LoadFromFile(guids_map_path);

                Dictionary<string, List<NVP_Manifest>> nodeitems = new Dictionary<string, List<NVP_Manifest>>();

                //Тоже самое, что и в nodeitems, только сортировка идет по папкам (NVP_Manifest.Folder)
                Dictionary<string, List<NVP_Manifest>> folder2nodes = new Dictionary<string, List<NVP_Manifest>>();

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
                    var NVP_NodeInput_attrs = (NVP.API.Nodes.NodeInputAttribute[])type.GetCustomAttributes(typeof(NodeInputAttribute), true);
                    if (NVP_Manifest_attrs.Length > 0)
                    {
                        NVP_Manifest NVP_Manifest_attrs_need = NVP_Manifest_attrs[0];
                        is_any_nodes = true;

                        /*Если Namespace содержит имя dll, то оставляем. Если не содержит,*/

                        //Получаем индекс нода от текущего полного пути класса, объявляющего нод в данной dll. Это значение равное namespace за минусом последней подгруппы
                        string cs_path_index = type.Namespace;
                        if (cs_path_index.Contains(".")) cs_path_index = cs_path_index.Substring(0, cs_path_index.LastIndexOf("."));
                        else cs_path_index = dll_name;

                        string nvp_node_path = type.Namespace + "." + type.Name;


                        NVP_Manifest_attrs_need.PathAssembly = dll_nameDLL;
                        NVP_Manifest_attrs_need.PathExecuteClass = nvp_node_path;
                        NVP_Manifest_attrs_need.Folder = type.Namespace.Replace("._", ".");
                        NVP_Manifest_attrs_need.CoderName = _CoderName;
                        NVP_Manifest_attrs_need.NodeName = type.Name;
                        //исключение для нодов-конструкторов, делаем им префикс "_"
                        if (NVP_Manifest_attrs_need.NodeName.Contains("_Constructor") && NVP_Manifest_attrs_need.NodeName[0] != '_') NVP_Manifest_attrs_need.NodeName = "_" + NVP_Manifest_attrs_need.NodeName;


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
                        if (NVP_Manifest_attrs_need.ViewType == null) NVP_Manifest_attrs_need.ViewType = "Default";
                        if (NVP_Manifest_attrs_need.Text == null) NVP_Manifest_attrs_need.Text = "";

                        if (NVP_NodeInput_attrs.Length > 0)
                        {
                            NVP_Manifest_attrs_need.Arguments = new string[NVP_NodeInput_attrs.Length];
                            int arg_counter = 0;
                            foreach (NVP.API.Nodes.NodeInputAttribute NVP_NodeInput_attrs_need in NVP_NodeInput_attrs)
                            {
                                NVP_Manifest_attrs_need.Arguments[arg_counter] = $"({NVP_NodeInput_attrs_need.InputType}){NVP_NodeInput_attrs_need.Name}";
                                arg_counter++;
                            }
                        }
                        else NVP_Manifest_attrs_need.Arguments = new string[0];


                        if (nodeitems.ContainsKey(cs_path_index)) nodeitems[cs_path_index].Add(NVP_Manifest_attrs_need);
                        else nodeitems.Add(cs_path_index, new List<NVP_Manifest> { NVP_Manifest_attrs_need });

                        if (folder2nodes.ContainsKey(NVP_Manifest_attrs_need.Folder)) folder2nodes[NVP_Manifest_attrs_need.Folder].Add(NVP_Manifest_attrs_need);
                        else folder2nodes.Add(NVP_Manifest_attrs_need.Folder, new List<NVP_Manifest> { NVP_Manifest_attrs_need });


                        //nodeitems.Add(NVP_Manifest_attrs_need);
                    }
                }

                if (is_any_nodes)
                {
                    string base_dir = Path.Combine(Path.GetDirectoryName(dll_path), "NVP_Data");
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

                        //Сохраняем сразу во вложенной папке NVP_Data
                        string file_name = nodeitem_File.Key + ".nodeitem";
                        if (nodeitem_File.Key == dll_name) file_name = dll_name + ".nodeitem";

                        string nodeitemPath = Path.Combine(Path.GetDirectoryName(dll_path), file_name);

                        _doc.Add(_doc_nodeitem_Nodes);
                        _doc.Save(nodeitemPath);

                        Console.WriteLine(nodeitemPath);
                    }

                    //Сохраняем справку
                    StringBuilder lib_md_doc = new StringBuilder();
                    lib_md_doc.AppendLine("# " + dll_name + Environment.NewLine);
                    foreach (var folder_nodes in folder2nodes)
                    {
                        lib_md_doc.AppendLine("## Группа " + folder_nodes.Key + Environment.NewLine);

                        foreach (var node in folder_nodes.Value)
                        {
                            lib_md_doc.AppendLine("### Нод " + node.NodeName + Environment.NewLine);
                            lib_md_doc.AppendLine("**Имя нода** = " + node.NodeName + ";");
                            if (node.Text != "") lib_md_doc.AppendLine("**Описание** = " + node.Text + ";");

                            //lib_md_doc.AppendLine("Id = " + node.Id + ";");
                            //lib_md_doc.AppendLine("* PathAssembly = " + node.PathAssembly);
                            //lib_md_doc.AppendLine("* PathExecuteClass = " + node.PathExecuteClass); 
                            lib_md_doc.AppendLine("**Автор** = " + node.CoderName + ";");
                            lib_md_doc.AppendLine("**Папка** = " + node.Folder + ";");
                            
                            //lib_md_doc.AppendLine("* NodeType = " + node.NodeType);
                            //lib_md_doc.AppendLine("**CADType** = " + node.CADType + ";");
                            //lib_md_doc.AppendLine("* ViewType = " + node.ViewType);
                            

                            if (node.Arguments.Length > 0)
                            {
                                lib_md_doc.AppendLine("**Входные данные**:");
                                foreach (var arg in node.Arguments)
                                {
                                    lib_md_doc.AppendLine("* " + arg + ";");
                                }
                            }
                            lib_md_doc.AppendLine("");
                        }
                    }

                    File.WriteAllText(help_mdFile_path, lib_md_doc.ToString(), Encoding.UTF8);

                    guids_map.Save(guids_map_path);
                    Console.WriteLine("guids map SAVE " + guids_map_path);
                }
            }
        }

        private static void CleanManifestAttrs()
        {
            foreach (string cs_path in Directory.GetFiles(@"C:\Users\Georg\Documents\GitHub\nvp_NodeLibs_ActiveX\src", "*.cs", SearchOption.AllDirectories))
            {
                StringBuilder cs = new StringBuilder();

                foreach (string cs_data in File.ReadLines(cs_path))
                {
                    if (
                        cs_data.Contains("Id = \"") |
                        cs_data.Contains("PathAssembly = \"") |
                        cs_data.Contains("PathExecuteClass = \"") |
                        cs_data.Contains("CoderName = \"") |
                        cs_data.Contains("Folder = \"") |
                        cs_data.Contains("NodeName = \"") |
                        cs_data.Contains("NodeType = \"Loaded\"") |
                        cs_data.Contains("CADType = \"None\"")|
                        cs_data.Contains("Text = \"\"")) continue;
                    else cs.AppendLine(cs_data);
                }
                File.WriteAllText(cs_path, cs.ToString(), Encoding.UTF8);
            }
        }
        public static void Main(string[] args)
        {
            Run();
            //CleanManifestAttrs();


            Console.WriteLine("\nEnd!");
#if DEBUG
            //Console.ReadKey();
#endif
        }
    }
}