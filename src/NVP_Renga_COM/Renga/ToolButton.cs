using NVP.API.Nodes;

namespace Renga.ToolButton 
{
	[NodeInput("dynamic", typeof(object))]
	public class ToolButton_Constructor : INode 
	{
		public Renga.IToolButton _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IToolButton;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class ToolButton_ConstructorCast : INode 
	{
		public Renga.IToolButton _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IToolButton;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ToolButton", typeof(object))]
	public class Action : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Action);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ToolButton", typeof(object))]
	[NodeInput("ppAction", typeof(System.Object))]
	public class Set_Action : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Action = inputs[1];
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ToolButton", typeof(object))]
	public class Id : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Id);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("ToolButton", typeof(object))]
	public class IdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IdS);

		}
	}
}
