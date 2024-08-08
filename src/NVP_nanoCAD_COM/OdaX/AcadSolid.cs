using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a solid-filled polygon entity
///</summary>
namespace OdaX.AcadSolid 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSolid_Constructor : INode 
	{
		public OdaX.IAcadSolid _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSolid;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSolid_ConstructorCast : INode 
	{
		public OdaX.IAcadSolid _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSolid;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the current vertex of a solid.", 
		ViewType = "Data")]
	[NodeInput("AcadSolid", typeof(object))]

	///<summary>
	///Specifies or returns the current vertex of a solid.
	///</summary>
	public class Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Coordinates);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the current vertex of a solid.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSolid", typeof(object))]
	[NodeInput("corners", typeof(System.Object))]

	///<summary>
	///Specifies or returns the current vertex of a solid.
	///</summary>
	public class Set_Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Coordinates = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the x, y, and z coordinates of the normal direction vector.", 
		ViewType = "Data")]
	[NodeInput("AcadSolid", typeof(object))]

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
	[NodeInput("AcadSolid", typeof(object))]
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
		Text = "z-direction value) of a solid.", 
		ViewType = "Data")]
	[NodeInput("AcadSolid", typeof(object))]

	///<summary>
	///z-direction value) of a solid.
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
		Text = "z-direction value) of a solid.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSolid", typeof(object))]
	[NodeInput("Thickness", typeof(System.Double))]

	///<summary>
	///z-direction value) of a solid.
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
		Text = "Specifies or returns the coordinates of a single vertex in a solid.", 
		ViewType = "Data")]
	[NodeInput("AcadSolid", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the coordinates of a single vertex in a solid.
	///</summary>
	public class Coordinate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Coordinate(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the coordinates of a single vertex in a solid.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSolid", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the coordinates of a single vertex in a solid.
	///</summary>
	public class Set_Coordinate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Coordinate[inputs[1]] = inputs[2];
			return null;
		}
	}
}
