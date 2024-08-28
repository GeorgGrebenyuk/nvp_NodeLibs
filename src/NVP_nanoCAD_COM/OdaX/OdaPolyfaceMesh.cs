using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Polyface mesh extended interface
///</summary>
namespace NVP_nanoCAD_COM._OdaX.OdaPolyfaceMesh 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaPolyfaceMesh_Constructor : INode 
	{
		public OdaX.IOdaPolyfaceMesh _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaPolyfaceMesh;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaPolyfaceMesh_ConstructorCast : INode 
	{
		public OdaX.IOdaPolyfaceMesh _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaPolyfaceMesh;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaPolyfaceMesh", typeof(object))]
	[NodeInput("__MIDL__IOdaPolyfaceMesh0000", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetFaces : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetFaces(inputs[1].Value);
			return null;
		}
	}
}
