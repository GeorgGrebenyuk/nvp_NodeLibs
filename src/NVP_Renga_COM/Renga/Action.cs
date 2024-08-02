using NVP.API.Nodes;

namespace Renga.Action 
{
	[NodeInput("dynamic", typeof(object))]
	public class Action_Constructor : INode 
	{
		public Renga.IAction _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IAction;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class Action_ConstructorCast : INode 
	{
		public Renga.IAction _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IAction;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Action", typeof(object))]
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
	[NodeInput("Action", typeof(object))]
	public class DisplayName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DisplayName);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Action", typeof(object))]
	[NodeInput("pName", typeof(System.String))]
	public class Set_DisplayName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DisplayName = inputs[1];
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Action", typeof(object))]
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
	[NodeInput("Action", typeof(object))]
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
	[NodeInput("Action", typeof(object))]
	public class Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Enabled);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Action", typeof(object))]
	[NodeInput("Enabled", typeof(System.Object))]
	public class Set_Enabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Enabled = inputs[1];
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Action", typeof(object))]
	public class Checkable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Checkable);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Action", typeof(object))]
	[NodeInput("pCheckable", typeof(System.Object))]
	public class Set_Checkable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Checkable = inputs[1];
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Action", typeof(object))]
	public class Checked : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Checked);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Action", typeof(object))]
	[NodeInput("pChecked", typeof(System.Object))]
	public class Set_Checked : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Checked = inputs[1];
			return null;
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Action", typeof(object))]
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
	[NodeInput("Action", typeof(object))]
	public class Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Visible);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("Action", typeof(object))]
	[NodeInput("pVisible", typeof(System.Object))]
	public class Set_Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Visible = inputs[1];
			return null;
		}
	}
}
