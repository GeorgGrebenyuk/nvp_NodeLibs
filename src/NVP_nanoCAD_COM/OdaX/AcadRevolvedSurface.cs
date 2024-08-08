using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a surface created by revolving one or more 2D objects about an axis
///</summary>
namespace OdaX.AcadRevolvedSurface 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadRevolvedSurface_Constructor : INode 
	{
		public OdaX.IAcadRevolvedSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadRevolvedSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadRevolvedSurface_ConstructorCast : INode 
	{
		public OdaX.IAcadRevolvedSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadRevolvedSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the angle of revolution for a revolved surface.", 
		ViewType = "Data")]
	[NodeInput("AcadRevolvedSurface", typeof(object))]

	///<summary>
	///Specifies or returns the angle of revolution for a revolved surface.
	///</summary>
	public class RevolutionAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RevolutionAngle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the angle of revolution for a revolved surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadRevolvedSurface", typeof(object))]
	[NodeInput("revAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the angle of revolution for a revolved surface.
	///</summary>
	public class Set_RevolutionAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RevolutionAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the start point of the revolution axis for a revolved surface.", 
		ViewType = "Data")]
	[NodeInput("AcadRevolvedSurface", typeof(object))]

	///<summary>
	///Specifies or returns the start point of the revolution axis for a revolved surface.
	///</summary>
	public class AxisPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxisPosition);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the start point of the revolution axis for a revolved surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadRevolvedSurface", typeof(object))]
	[NodeInput("AxisPosition", typeof(System.Object))]

	///<summary>
	///Specifies or returns the start point of the revolution axis for a revolved surface.
	///</summary>
	public class Set_AxisPosition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AxisPosition = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the direction of the revolution axis for a revolved surface.", 
		ViewType = "Data")]
	[NodeInput("AcadRevolvedSurface", typeof(object))]

	///<summary>
	///Returns the direction of the revolution axis for a revolved surface.
	///</summary>
	public class AxisDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AxisDirection);

		}
	}
}
