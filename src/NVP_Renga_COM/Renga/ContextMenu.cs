using NVP.API.Nodes;

namespace Renga.ContextMenu 
{
		[NodeInput("dynamic", typeof(object))]
		public class ContextMenu_Constructor : INode 
		{
		public Renga.IContextMenu _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IContextMenu;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class ContextMenu_ConstructorCast : INode 
		{
		public Renga.IContextMenu _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IContextMenu;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ContextMenu", typeof(object))]
		[NodeInput("pAction", typeof(System.Object))]
		public class AddActionItem : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AddActionItem(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ContextMenu", typeof(object))]
		public class AddNodeItem : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AddNodeItem);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ContextMenu", typeof(object))]
		public class AddSeparator : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AddSeparator();
				return null;
			}
		}
}
