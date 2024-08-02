using NVP.API.Nodes;

namespace Renga.ObjectWithMark 
{
		[NodeInput("dynamic", typeof(object))]
		public class ObjectWithMark_Constructor : INode 
		{
		public Renga.IObjectWithMark _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IObjectWithMark;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class ObjectWithMark_ConstructorCast : INode 
		{
		public Renga.IObjectWithMark _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IObjectWithMark;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ObjectWithMark", typeof(object))]
		public class Mark : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Mark);

			}
		}
}
