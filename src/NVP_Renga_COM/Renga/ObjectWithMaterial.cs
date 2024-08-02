using NVP.API.Nodes;

namespace Renga.ObjectWithMaterial 
{
		[NodeInput("dynamic", typeof(object))]
		public class ObjectWithMaterial_Constructor : INode 
		{
		public Renga.IObjectWithMaterial _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IObjectWithMaterial;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class ObjectWithMaterial_ConstructorCast : INode 
		{
		public Renga.IObjectWithMaterial _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IObjectWithMaterial;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ObjectWithMaterial", typeof(object))]
		public class MaterialId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MaterialId);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ObjectWithMaterial", typeof(object))]
		public class HasMaterial : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HasMaterial);

			}
		}
}
