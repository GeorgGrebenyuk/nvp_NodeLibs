using NVP.API.Nodes;
using System;
using System.Collections.Generic;
using NVP_Manifest_Creator;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIds
{
    #region ModelStudio CS
    [NVP_Manifest(
    Text = "The id of LibManager.CADLibrary (Библиотека стандартных компонентов)",
    ViewType = "Data")]
    public class ProgID_LibManager_CADLibrary : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("LibManager.CADLibrary.1");
        }
    }

    #endregion
    #region nanoCAD
    [NVP_Manifest(
    Text = "The id of McCOM2.Server (nanoCAD SPDS, Mechanica)",
    ViewType = "Data")]
    public class ProgID_McCOM2 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("McCOM2.Server");
        }
    }

    [NVP_Manifest(
    Text = "The id of nanoCAD",
    ViewType = "Data")]
    public class ProgID_nanoCAD_Universal : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application");
        }
    }

    [NVP_Manifest(
    Text = "The id of nanoCAD 3.5",
    ViewType = "Data")]
    public class ProgID_nanoCAD_3_5 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.3.5");
        }
    }

    [NVP_Manifest(
    Text = "The id of nanoCAD 9.0",
    ViewType = "Data")]
    public class ProgID_nanoCAD_9_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.9.0");
        }
    }

    [NVP_Manifest(
    Text = "The id of nanoCAD 10.0",
    ViewType = "Data")]
    public class ProgID_nanoCAD_10_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.10.0");
        }
    }

    [NVP_Manifest(
    Text = "The id of nanoCAD 11.0",
    ViewType = "Data")]
    public class ProgID_nanoCAD_11_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.11.0");
        }
    }

    [NVP_Manifest(
    Text = "The id of nanoCAD 12.0",
    ViewType = "Data")]
    public class ProgID_nanoCAD_12_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.12.0");
        }
    }

    [NVP_Manifest(
    Text = "The id of nanoCAD 21.0",
    ViewType = "Data")]
    public class ProgID_nanoCAD_21_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.21.0");
        }
    }

    [NVP_Manifest(
    Text = "The id of nanoCAD 22.0",
    ViewType = "Data")]
    public class ProgID_nanoCAD_22_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.22.0");
        }
    }

    [NVP_Manifest(
    Text = "The id of nanoCAD 23.0",
    ViewType = "Data")]
    public class ProgID_nanoCAD_23_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.23.0");
        }
    }

    [NVP_Manifest(
    Text = "The id of nanoCAD 24.0",
    ViewType = "Data")]
    public class ProgID_nanoCAD_24_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.24.0");
        }
    }

    [NVP_Manifest(
    Text = "The id of nanoCAD 24.1",
    ViewType = "Data")]
    public class ProgID_nanoCAD_24_1 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.24.1");
        }
    }

    #endregion

    

    [NVP_Manifest(
    Text = "The id of Renga",
    ViewType = "Data")]
    public class ProgID_Renga : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("Renga.Application.1");
        }
    }

}
