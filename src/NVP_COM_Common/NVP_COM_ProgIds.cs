using NVP.API.Nodes;
using NVP_Manifest_Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVP_COM_Common.NVP_COM_ProgIds
{
    #region nanoCAD
    [NVP_Manifest(
    Id = "308B52DD-E4CD-4E1B-9AEA-14EC6432B6FA",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.NVP_COM_ProgIds.NVP_COM_ProgID_nanoCAD_Universal",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common.ProgID",
    NodeName = "ProgID_nanoCAD_Universal",
    NodeType = "Loaded",
    CADType = "None",
    Text = "The id of nanoCAD",
    ViewType = "Data")]
    public class NVP_COM_ProgID_nanoCAD_Universal : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application");
        }
    }

    [NVP_Manifest(
    Id = "4A566A5E-A238-450F-B5DC-1C0693DB3535",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.NVP_COM_ProgIds.NVP_COM_ProgID_nanoCAD_3_5",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common.ProgID",
    NodeName = "ProgID_nanoCAD_3_5",
    NodeType = "Loaded",
    CADType = "None",
    Text = "The id of nanoCAD 3.5",
    ViewType = "Data")]
    public class NVP_COM_ProgID_nanoCAD_3_5 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.3.5");
        }
    }

    [NVP_Manifest(
    Id = "D96D5B16-AD70-470E-8EB0-4C4F51CB65DF",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.NVP_COM_ProgIds.NVP_COM_ProgID_nanoCAD_9_0",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common.ProgID",
    NodeName = "ProgID_nanoCAD_9_0",
    NodeType = "Loaded",
    CADType = "None",
    Text = "The id of nanoCAD 9.0",
    ViewType = "Data")]
    public class NVP_COM_ProgID_nanoCAD_9_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.9.0");
        }
    }

    [NVP_Manifest(
    Id = "1CFA7A11-F3C9-4F6F-B4FA-7B9CA5F72E55",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.NVP_COM_ProgIds.NVP_COM_ProgID_nanoCAD_10_0",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common.ProgID",
    NodeName = "ProgID_nanoCAD_10_0",
    NodeType = "Loaded",
    CADType = "None",
    Text = "The id of nanoCAD 10.0",
    ViewType = "Data")]
    public class NVP_COM_ProgID_nanoCAD_10_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.10.0");
        }
    }

    [NVP_Manifest(
    Id = "53B844D2-EB56-4DCE-B2BE-C80CC16FCD82",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.NVP_COM_ProgIds.NVP_COM_ProgID_nanoCAD_11_0",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common.ProgID",
    NodeName = "ProgID_nanoCAD_11_0",
    NodeType = "Loaded",
    CADType = "None",
    Text = "The id of nanoCAD 11.0",
    ViewType = "Data")]
    public class NVP_COM_ProgID_nanoCAD_11_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.11.0");
        }
    }

    [NVP_Manifest(
    Id = "97697CBF-152B-4ABB-920D-9DEA9FFDEBCC",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.NVP_COM_ProgIds.NVP_COM_ProgID_nanoCAD_12_0",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common.ProgID",
    NodeName = "ProgID_nanoCAD_12_0",
    NodeType = "Loaded",
    CADType = "None",
    Text = "The id of nanoCAD 12.0",
    ViewType = "Data")]
    public class NVP_COM_ProgID_nanoCAD_12_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.12.0");
        }
    }

    [NVP_Manifest(
    Id = "0BDB6C5B-5D21-4B48-BE5A-C0127C90B2E1",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.NVP_COM_ProgIds.NVP_COM_ProgID_nanoCAD_21_0",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common.ProgID",
    NodeName = "ProgID_nanoCAD_21_0",
    NodeType = "Loaded",
    CADType = "None",
    Text = "The id of nanoCAD 21.0",
    ViewType = "Data")]
    public class NVP_COM_ProgID_nanoCAD_21_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.21.0");
        }
    }

    [NVP_Manifest(
    Id = "0E0A1C95-2BD8-4895-BC7E-DEF9694146B3",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.NVP_COM_ProgIds.NVP_COM_ProgID_nanoCAD_22_0",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common.ProgID",
    NodeName = "ProgID_nanoCAD_22_0",
    NodeType = "Loaded",
    CADType = "None",
    Text = "The id of nanoCAD 22.0",
    ViewType = "Data")]
    public class NVP_COM_ProgID_nanoCAD_22_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.22.0");
        }
    }

    [NVP_Manifest(
    Id = "D5F46567-ACF6-4C76-BBD0-B5A2EBCEE59E",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.NVP_COM_ProgIds.NVP_COM_ProgID_nanoCAD_23_0",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common.ProgID",
    NodeName = "ProgID_nanoCAD_23_0",
    NodeType = "Loaded",
    CADType = "None",
    Text = "The id of nanoCAD 23.0",
    ViewType = "Data")]
    public class NVP_COM_ProgID_nanoCAD_23_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.23.0");
        }
    }

    [NVP_Manifest(
    Id = "AFCBDF8F-E1A6-45AC-B8E8-9B121E004374",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.NVP_COM_ProgIds.NVP_COM_ProgID_nanoCAD_24_0",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common.ProgID",
    NodeName = "ProgID_nanoCAD_24_0",
    NodeType = "Loaded",
    CADType = "None",
    Text = "The id of nanoCAD 24.0",
    ViewType = "Data")]
    public class NVP_COM_ProgID_nanoCAD_24_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.24.0");
        }
    }

    [NVP_Manifest(
    Id = "1DB8227C-3EE4-41A5-AF92-AE126990DD44",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.NVP_COM_ProgIds.NVP_COM_ProgID_nanoCAD_24_1",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common.ProgID",
    NodeName = "ProgID_nanoCAD_24_1",
    NodeType = "Loaded",
    CADType = "None",
    Text = "The id of nanoCAD 24.1",
    ViewType = "Data")]
    public class NVP_COM_ProgID_nanoCAD_24_1 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.24.1");
        }
    }

    #endregion

    [NVP_Manifest(
    Id = "EB58B46D-B47E-4E4C-933E-3BE0B30361F1",
    PathAssembly = "NVP_COM_Common.dll",
    PathExecuteClass = "NVP_COM_Common.NVP_COM_ProgIds.NVP_COM_ProgID_Renga",
    CoderName = "GeorgGrebenyuk",
    Folder = "NVP_COM_Common.ProgID",
    NodeName = "ProgID_Renga",
    NodeType = "Loaded",
    CADType = "None",
    Text = "The id of Renga",
    ViewType = "Data")]
    public class NVP_COM_ProgID_Renga : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("Renga.Application.1");
        }
    }

}
