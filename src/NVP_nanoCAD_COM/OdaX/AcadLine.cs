using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a single line segment
///</summary>
namespace OdaX.AcadLine 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLine_Constructor : INode 
	{
		public OdaX.IAcadLine _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadLine;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadLine_ConstructorCast : INode 
	{
		public OdaX.IAcadLine _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadLine;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, z coordinates of the start point of a line.", 
		ViewType = "Data")]
	[NodeInput("AcadLine", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates of the start point of a line.
	///</summary>
	public class StartPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartPoint);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, z coordinates of the start point of a line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLine", typeof(object))]
	[NodeInput("StartPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates of the start point of a line.
	///</summary>
	public class Set_StartPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, z coordinates of the end point of a line.", 
		ViewType = "Data")]
	[NodeInput("AcadLine", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates of the end point of a line.
	///</summary>
	public class EndPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndPoint);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, z coordinates of the end point of a line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLine", typeof(object))]
	[NodeInput("EndPoint", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, z coordinates of the end point of a line.
	///</summary>
	public class Set_EndPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadLine", typeof(object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLine", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the x, y, and z coordinates of the normal direction vector.
	///</summary>
	public class Set_Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Normal = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "z-direction value) of a line.", 
		ViewType = "Data")]
	[NodeInput("AcadLine", typeof(object))]

	///<summary>
	///z-direction value) of a line.
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
		Text = "z-direction value) of a line.", 
		ViewType = "Modifier")]
	[NodeInput("AcadLine", typeof(object))]
	[NodeInput("Thickness", typeof(System.Double))]

	///<summary>
	///z-direction value) of a line.
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
		Text = "Not implemented. Copies an existing line and places the copy at a specified distance from the existing line.", 
		ViewType = "Data")]
	[NodeInput("AcadLine", typeof(object))]
	[NodeInput("Distance", typeof(System.Double))]

	///<summary>
	///Not implemented. Copies an existing line and places the copy at a specified distance from the existing line.
	///</summary>
	public class Offset : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Offset(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Specifies the x, y, z, delta values of a line.", 
		ViewType = "Data")]
	[NodeInput("AcadLine", typeof(object))]

	///<summary>
	///Specifies the x, y, z, delta values of a line.
	///</summary>
	public class Delta : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Delta);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the length of a line.", 
		ViewType = "Data")]
	[NodeInput("AcadLine", typeof(object))]

	///<summary>
	///Specifies the length of a line.
	///</summary>
	public class Length : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Length);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the angle of a line.", 
		ViewType = "Data")]
	[NodeInput("AcadLine", typeof(object))]

	///<summary>
	///Specifies the angle of a line.
	///</summary>
	public class Angle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Angle);

		}
	}
}
