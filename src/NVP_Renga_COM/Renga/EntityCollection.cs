using NVP.API.Nodes;

namespace Renga.EntityCollection 
{
		[NodeInput("dynamic", typeof(object))]
		public class EntityCollection_Constructor : INode 
		{
		public Renga.IEntityCollection _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IEntityCollection;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class EntityCollection_ConstructorCast : INode 
		{
		public Renga.IEntityCollection _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IEntityCollection;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("EntityCollection", typeof(object))]
		[NodeInput("Id", typeof(System.Int32))]
		public class GetById : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetById(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("EntityCollection", typeof(object))]
		public class GetIds : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetIds();
				return null;
			}
		}
}
