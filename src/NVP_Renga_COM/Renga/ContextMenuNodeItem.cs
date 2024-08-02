using NVP.API.Nodes;

namespace Renga.ContextMenuNodeItem 
{
		[NodeInput("dynamic", typeof(object))]
		public class ContextMenuNodeItem_Constructor : INode 
		{
		public Renga.IContextMenuNodeItem _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IContextMenuNodeItem;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class ContextMenuNodeItem_ConstructorCast : INode 
		{
		public Renga.IContextMenuNodeItem _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IContextMenuNodeItem;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ContextMenuNodeItem", typeof(object))]
		[NodeInput("displayName_", typeof(System.String))]
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
		[NodeInput("ContextMenuNodeItem", typeof(object))]
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
		[NodeInput("ContextMenuNodeItem", typeof(object))]
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
		[NodeInput("ContextMenuNodeItem", typeof(object))]
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
		[NodeInput("ContextMenuNodeItem", typeof(object))]
		public class DisplayName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DisplayName);

			}
		}
}
