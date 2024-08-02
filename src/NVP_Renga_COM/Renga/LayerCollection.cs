using NVP.API.Nodes;

namespace Renga.LayerCollection 
{
		[NodeInput("dynamic", typeof(object))]
		public class LayerCollection_Constructor : INode 
		{
		public Renga.ILayerCollection _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.ILayerCollection;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class LayerCollection_ConstructorCast : INode 
		{
		public Renga.ILayerCollection _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.ILayerCollection;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("LayerCollection", typeof(object))]
		public class Count : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Count);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("LayerCollection", typeof(object))]
		[NodeInput("index", typeof(System.Int32))]
		public class Get : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Get(inputs[1]));

			}
		}
}
