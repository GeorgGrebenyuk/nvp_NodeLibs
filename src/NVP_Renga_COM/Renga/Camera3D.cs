using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace NVP_Renga_COM._Renga.Camera3D 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Camera3D_Constructor : INode 
	{
		public Renga.ICamera3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ICamera3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Camera3D_ConstructorCast : INode 
	{
		public Renga.ICamera3D _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ICamera3D;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Camera3D", typeof(object))]

	///<summary>
	///
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
		ViewType = "Data")]
	[NodeInput("Camera3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FocusPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FocusPoint);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Camera3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FovHorizontal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FovHorizontal);

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Camera3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FovVertical : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FovVertical);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("Camera3D", typeof(object))]
	[NodeInput("focusPoint_", typeof(System.Object))]
	[NodeInput("position_", typeof(System.Object))]
	[NodeInput("upVector_", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class LookAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LookAt(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("Camera3D", typeof(object))]

	///<summary>
	///
	///</summary>
	public class UpVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UpVector);

		}
	}
}
