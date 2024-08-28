using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface for an additional Ole functionality
///</summary>
namespace NVP_nanoCAD_COM._OdaX.OdaOle 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaOle_Constructor : INode 
	{
		public OdaX.IOdaOle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaOle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaOle_ConstructorCast : INode 
	{
		public OdaX.IOdaOle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaOle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Filename and item to which this OLE object is linked", 
		ViewType = "Data")]
	[NodeInput("OdaOle", typeof(object))]

	///<summary>
	///Filename and item to which this OLE object is linked
	///</summary>
	public class LinkName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinkName);

		}
	}


	[NVP_Manifest(
		Text = "Filename to which this OLE object is linked", 
		ViewType = "Data")]
	[NodeInput("OdaOle", typeof(object))]

	///<summary>
	///Filename to which this OLE object is linked
	///</summary>
	public class LinkPath : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LinkPath);

		}
	}
}
