using NVP.API.Nodes;

namespace Renga.UIPanelExtension 
{
		[NodeInput("dynamic", typeof(object))]
		public class UIPanelExtension_Constructor : INode 
		{
		public Renga.IUIPanelExtension _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IUIPanelExtension;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class UIPanelExtension_ConstructorCast : INode 
		{
		public Renga.IUIPanelExtension _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IUIPanelExtension;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UIPanelExtension", typeof(object))]
		[NodeInput("pAction", typeof(System.Object))]
		public class AddToolButton : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AddToolButton(inputs[1]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UIPanelExtension", typeof(object))]
		[NodeInput("pSplitButton", typeof(System.Object))]
		public class AddSplitButton : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AddSplitButton(inputs[1]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UIPanelExtension", typeof(object))]
		[NodeInput("pDropDownButton", typeof(System.Object))]
		public class AddDropDownButton : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AddDropDownButton(inputs[1]);
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("UIPanelExtension", typeof(object))]
		[NodeInput("pToolButton", typeof(System.Object))]
		public class AddToolButton2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AddToolButton2(inputs[1]);
				return null;
			}
		}
}
