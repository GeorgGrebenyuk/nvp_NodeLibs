using NVP.API.Nodes;

namespace Renga.DropDownButton 
{
	[NodeInput("dynamic", typeof(object))]
	public class DropDownButton_Constructor : INode 
	{
		public Renga.IDropDownButton _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IDropDownButton;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class DropDownButton_ConstructorCast : INode 
	{
		public Renga.IDropDownButton _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IDropDownButton;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("DropDownButton", typeof(object))]
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
	[NodeInput("DropDownButton", typeof(object))]
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
	[NodeInput("DropDownButton", typeof(object))]
	[NodeInput("rhs", typeof(System.Object))]
	public class Set_Icon : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Icon = inputs[1];
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("DropDownButton", typeof(object))]
	[NodeInput("pToolTip", typeof(System.String))]
	public class Set_ToolTip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToolTip = inputs[1];
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("DropDownButton", typeof(object))]
	public class ToolTip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToolTip);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("DropDownButton", typeof(object))]
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
	[NodeInput("DropDownButton", typeof(object))]
	public class IdS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IdS);

		}
	}
}
