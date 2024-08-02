using NVP.API.Nodes;

namespace Renga.ObjectWithLayeredMaterial 
{
		[NodeInput("dynamic", typeof(object))]
		public class ObjectWithLayeredMaterial_Constructor : INode 
		{
		public Renga.IObjectWithLayeredMaterial _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IObjectWithLayeredMaterial;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class ObjectWithLayeredMaterial_ConstructorCast : INode 
		{
		public Renga.IObjectWithLayeredMaterial _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IObjectWithLayeredMaterial;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ObjectWithLayeredMaterial", typeof(object))]
		public class GetLayeredMaterialIdGroupPair : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetLayeredMaterialIdGroupPair);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ObjectWithLayeredMaterial", typeof(object))]
		public class HasLayeredMaterial : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HasLayeredMaterial);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ObjectWithLayeredMaterial", typeof(object))]
		public class GetLayers : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetLayers);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ObjectWithLayeredMaterial", typeof(object))]
		public class LayeredMaterialId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LayeredMaterialId);

			}
		}
}
