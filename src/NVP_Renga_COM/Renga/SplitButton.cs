using NVP.API.Nodes;

namespace Renga.SplitButton 
{
	[NodeInput("dynamic", typeof(object))]
	public class SplitButton_Constructor : INode 
	{
		public Renga.ISplitButton _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ISplitButton;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class SplitButton_ConstructorCast : INode 
	{
		public Renga.ISplitButton _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ISplitButton;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("SplitButton", typeof(object))]
	[NodeInput("pAction", typeof(System.Object))]
	public class AddAction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddAction(inputs[1]);
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("SplitButton", typeof(object))]
	public class AddSeparator : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddSeparator();
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("SplitButton", typeof(object))]
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
	[NodeInput("SplitButton", typeof(object))]
	public class IdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IdS);

		}
	}
}
