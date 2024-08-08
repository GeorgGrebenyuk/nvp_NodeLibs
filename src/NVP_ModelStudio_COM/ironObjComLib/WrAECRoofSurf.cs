using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///IWrAECRoofSurf Interface
///</summary>
namespace ironObjComLib.WrAECRoofSurf 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECRoofSurf_Constructor : INode 
	{
		public ironObjComLib.IWrAECRoofSurf _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as ironObjComLib.IWrAECRoofSurf;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class WrAECRoofSurf_ConstructorCast : INode 
	{
		public ironObjComLib.IWrAECRoofSurf _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as ironObjComLib.IWrAECRoofSurf;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Data")]
	[NodeInput("WrAECRoofSurf", typeof(object))]

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


	[NVP_Manifest(
		Text = "Параметры", 
		ViewType = "Modifier")]
	[NodeInput("WrAECRoofSurf", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Параметры
	///</summary>
	public class Set_Element : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Element = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property UnitPosition", 
		ViewType = "Data")]
	[NodeInput("WrAECRoofSurf", typeof(object))]

	///<summary>
	///property UnitPosition
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		Text = "property UnitPosition", 
		ViewType = "Modifier")]
	[NodeInput("WrAECRoofSurf", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///property UnitPosition
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ROOF_ANGLE", 
		ViewType = "Data")]
	[NodeInput("WrAECRoofSurf", typeof(object))]

	///<summary>
	///property ROOF_ANGLE
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
		Text = "property ROOF_ANGLE", 
		ViewType = "Modifier")]
	[NodeInput("WrAECRoofSurf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ROOF_ANGLE
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


	[NVP_Manifest(
		Text = "property AEC_PART_THICKNESS", 
		ViewType = "Data")]
	[NodeInput("WrAECRoofSurf", typeof(object))]

	///<summary>
	///property AEC_PART_THICKNESS
	///</summary>
	public class Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Thickness);

		}
	}


	[NVP_Manifest(
		Text = "property AEC_PART_THICKNESS", 
		ViewType = "Modifier")]
	[NodeInput("WrAECRoofSurf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property AEC_PART_THICKNESS
	///</summary>
	public class Set_Thickness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Thickness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ROOF_BOTTOM_OFFSET", 
		ViewType = "Data")]
	[NodeInput("WrAECRoofSurf", typeof(object))]

	///<summary>
	///property ROOF_BOTTOM_OFFSET
	///</summary>
	public class BottomOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BottomOffset);

		}
	}


	[NVP_Manifest(
		Text = "property ROOF_BOTTOM_OFFSET", 
		ViewType = "Modifier")]
	[NodeInput("WrAECRoofSurf", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///property ROOF_BOTTOM_OFFSET
	///</summary>
	public class Set_BottomOffset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BottomOffset = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "property ROOF_SIDE_VERT", 
		ViewType = "Data")]
	[NodeInput("WrAECRoofSurf", typeof(object))]

	///<summary>
	///property ROOF_SIDE_VERT
	///</summary>
	public class VetrSide : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VetrSide);

		}
	}


	[NVP_Manifest(
		Text = "property ROOF_SIDE_VERT", 
		ViewType = "Modifier")]
	[NodeInput("WrAECRoofSurf", typeof(object))]
	[NodeInput("pVal", typeof(System.Int32))]

	///<summary>
	///property ROOF_SIDE_VERT
	///</summary>
	public class Set_VetrSide : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.VetrSide = inputs[1].Value;
			return null;
		}
	}
}
