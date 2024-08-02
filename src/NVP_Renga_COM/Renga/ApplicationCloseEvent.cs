using NVP.API.Nodes;

namespace Renga.ApplicationCloseEvent 
{
		[NodeInput("dynamic", typeof(object))]
		public class ApplicationCloseEvent_Constructor : INode 
		{
		public Renga.IApplicationCloseEvent _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IApplicationCloseEvent;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class ApplicationCloseEvent_ConstructorCast : INode 
		{
		public Renga.IApplicationCloseEvent _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IApplicationCloseEvent;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ApplicationCloseEvent", typeof(object))]
		public class Prevent : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Prevent();
				return null;
			}
		}
}
