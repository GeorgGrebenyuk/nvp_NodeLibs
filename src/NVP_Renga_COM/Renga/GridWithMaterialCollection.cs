using NVP.API.Nodes;

namespace Renga.GridWithMaterialCollection 
{
		[NodeInput("dynamic", typeof(object))]
		public class GridWithMaterialCollection_Constructor : INode 
		{
		public Renga.IGridWithMaterialCollection _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IGridWithMaterialCollection;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class GridWithMaterialCollection_ConstructorCast : INode 
		{
		public Renga.IGridWithMaterialCollection _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IGridWithMaterialCollection;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("GridWithMaterialCollection", typeof(object))]
		[NodeInput("index", typeof(System.Int32))]
		public class Get : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Get(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("GridWithMaterialCollection", typeof(object))]
		public class Count : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Count);

			}
		}
}
