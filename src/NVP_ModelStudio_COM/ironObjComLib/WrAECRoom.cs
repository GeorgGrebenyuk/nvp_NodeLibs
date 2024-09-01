using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IIrnDiaProp Interface
///</summary>
namespace NVP_ModelStudio_COM._ironObjComLib.WrAECRoom
{

    [NVP_Manifest(
        ViewType = "Modifier")]
    [NodeInput("dynamic", typeof(object))]
    public class WrAECRoom_Constructor : INode
    {
        public ironObjComLib.WrAECRoom _i;
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            this._i = _input0 as ironObjComLib.WrAECRoom;
            if (this._i == null) throw new Exception("Invalid casting");
            return new NodeResult(this);
        }
    }

    [NVP_Manifest(
        ViewType = "Modifier")]
    [NodeInput("dynamic", typeof(object))]
    public class WrAECRoom_ConstructorCast : INode
    {
        public ironObjComLib.WrAECRoom _i;
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            this._i = _input0._i as ironObjComLib.WrAECRoom;
            if (this._i == null) throw new Exception("Invalid casting");
            return new NodeResult(this);
        }
    }

    [NVP_Manifest(
        Text = "Параметры",
        ViewType = "Data")]
    [NodeInput("WrAECRoom", typeof(object))]

    ///<summary>
    ///Параметры
    ///</summary>
    public class Element : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            dynamic _input0 = inputs[0].Value;
            return new NodeResult(_input0._i.Element);

        }
    }
}
