using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///ODA extended spline interface, for roundtrip purposes
///</summary>
namespace NVP_nanoCAD_COM._OdaX.OdaSpline 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaSpline_Constructor : INode 
	{
		public OdaX.IOdaSpline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaSpline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaSpline_ConstructorCast : INode 
	{
		public OdaX.IOdaSpline _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaSpline;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Set all nurbs data to the spline", 
		ViewType = "Modifier")]
	[NodeInput("OdaSpline", typeof(object))]
	[NodeInput("Degree", typeof(System.Int32))]
	[NodeInput("ControlPoints", typeof(System.Object))]
	[NodeInput("Knots", typeof(System.Object))]
	[NodeInput("Weights", typeof(System.Object))]
	[NodeInput("controlPtTolerance", typeof(System.Double))]
	[NodeInput("knotTolerance", typeof(System.Double))]
	[NodeInput("periodic", typeof(System.Object))]

	///<summary>
	///Set all nurbs data to the spline
	///</summary>
	public class SetNurbsData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetNurbsData(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value,inputs[6].Value,inputs[7].Value);
			return null;
		}
	}
}
