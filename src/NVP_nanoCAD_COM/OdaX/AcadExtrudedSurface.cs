using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a surface created by extruding an object or a planar face a specified distance and direction
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadExtrudedSurface 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadExtrudedSurface_Constructor : INode 
	{
		public OdaX.IAcadExtrudedSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadExtrudedSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadExtrudedSurface_ConstructorCast : INode 
	{
		public OdaX.IAcadExtrudedSurface _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadExtrudedSurface;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the height of the extruded surface.", 
		ViewType = "Data")]
	[NodeInput("AcadExtrudedSurface", typeof(object))]

	///<summary>
	///Specifies or returns the height of the extruded surface.
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the height of the extruded surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadExtrudedSurface", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies or returns the height of the extruded surface.
	///</summary>
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the taper angle of the extruded surface.", 
		ViewType = "Data")]
	[NodeInput("AcadExtrudedSurface", typeof(object))]

	///<summary>
	///Specifies or returns the taper angle of the extruded surface.
	///</summary>
	public class TaperAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TaperAngle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the taper angle of the extruded surface.", 
		ViewType = "Modifier")]
	[NodeInput("AcadExtrudedSurface", typeof(object))]
	[NodeInput("TaperAngle", typeof(System.Object))]

	///<summary>
	///Specifies or returns the taper angle of the extruded surface.
	///</summary>
	public class Set_TaperAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TaperAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the direction of the extruded surface.", 
		ViewType = "Data")]
	[NodeInput("AcadExtrudedSurface", typeof(object))]

	///<summary>
	///Returns the direction of the extruded surface.
	///</summary>
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}
}
