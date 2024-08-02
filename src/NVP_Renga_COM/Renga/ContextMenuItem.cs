using NVP.API.Nodes;

namespace Renga.ContextMenuItem 
{
		[NodeInput("dynamic", typeof(object))]
		public class ContextMenuItem_Constructor : INode 
		{
		public Renga.IContextMenuItem _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IContextMenuItem;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class ContextMenuItem_ConstructorCast : INode 
		{
		public Renga.IContextMenuItem _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IContextMenuItem;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
}
