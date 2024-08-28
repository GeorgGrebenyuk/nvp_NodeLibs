using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrAECArcSurface Interface
///</summary>
namespace NVP_ModelStudio_COM._ironObjComLib.WrAECArcSurface 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECArcSurface_Constructor : INode 
	{
		public ironObjComLib.IWrAECArcSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrAECArcSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECArcSurface_ConstructorCast : INode 
	{
		public ironObjComLib.IWrAECArcSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrAECArcSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "property DIM_RADIUS", 
		ViewType = "Data")]
	[NodeInput("WrAECArcSurface", typeof(object))]

	///<summary>
	///property DIM_RADIUS
	///</summary>
	public class Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Radius);

		}
	}


	[NVP_Manifest(
		Text = "property DIM_RADIUS", 
		ViewType = "Modifier")]
	[NodeInput("WrAECArcSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property DIM_RADIUS
	///</summary>
	public class Set_Radius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Radius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property DIM_ANGLE", 
		ViewType = "Data")]
	[NodeInput("WrAECArcSurface", typeof(object))]

	///<summary>
	///property DIM_ANGLE
	///</summary>
	public class Angle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Angle);

		}
	}


	[NVP_Manifest(
		Text = "property DIM_ANGLE", 
		ViewType = "Modifier")]
	[NodeInput("WrAECArcSurface", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property DIM_ANGLE
	///</summary>
	public class Set_Angle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Angle = inputs[1].Value;
			return null;
		}
	}
}
