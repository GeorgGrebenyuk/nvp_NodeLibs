using NVP.API.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVP_COM_Common.NVP_COM_ProgIds
{
    #region nanoCAD
    public class NVP_COM_ProgID_nanoCAD_Universal : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application");
        }
    }

    public class NVP_COM_ProgID_nanoCAD_3_5 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.3.5");
        }
    }
    public class NVP_COM_ProgID_nanoCAD_9_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.9.0");
        }
    }

    public class NVP_COM_ProgID_nanoCAD_10_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.10.0");
        }
    }

    public class NVP_COM_ProgID_nanoCAD_11_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.11.0");
        }
    }

    public class NVP_COM_ProgID_nanoCAD_12_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.12.0");
        }
    }

    public class NVP_COM_ProgID_nanoCAD_21_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.21.0");
        }
    }

    public class NVP_COM_ProgID_nanoCAD_22_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.22.0");
        }
    }
    public class NVP_COM_ProgID_nanoCAD_23_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.23.0");
        }
    }
    public class NVP_COM_ProgID_nanoCAD_24_0 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.24.0");
        }
    }

    public class NVP_COM_ProgID_nanoCAD_24_1 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("nanoCAD.Application.24.1");
        }
    }

    #endregion

    public class NVP_COM_ProgID_Renga : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult("Renga.Application.1");
        }
    }

}
