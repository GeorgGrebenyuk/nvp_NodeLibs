using NVP.API.Nodes;

namespace Renga.Camera3D 
{
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


	///<summary>
	///
	///</summary>
	[NodeInput("Camera3D", typeof(object))]
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Camera3D", typeof(object))]
	public class FocusPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FocusPoint);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Camera3D", typeof(object))]
	public class FovHorizontal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FovHorizontal);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Camera3D", typeof(object))]
	public class FovVertical : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FovVertical);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Camera3D", typeof(object))]
	[NodeInput("focusPoint_", typeof(System.Object))]
	[NodeInput("position_", typeof(System.Object))]
	[NodeInput("upVector_", typeof(System.Object))]
	public class LookAt : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LookAt(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Camera3D", typeof(object))]
	public class UpVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UpVector);

		}
	}
}
