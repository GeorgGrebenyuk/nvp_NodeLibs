using NVP.API.Nodes;

namespace Renga.GridMaterial 
{
		[NodeInput("dynamic", typeof(object))]
		public class GridMaterial_Constructor : INode 
		{
		public Renga.IGridMaterial _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IGridMaterial;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class GridMaterial_ConstructorCast : INode 
		{
		public Renga.IGridMaterial _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IGridMaterial;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("GridMaterial", typeof(object))]
		public class Id : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Id);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("GridMaterial", typeof(object))]
		public class Color : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Color);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("GridMaterial", typeof(object))]
		[NodeInput("short*", typeof(System.Object))]
		[NodeInput("short*", typeof(System.Object))]
		[NodeInput("short*", typeof(System.Object))]
		[NodeInput("short*", typeof(System.Object))]
		public class GetColorComponents : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetColorComponents(inputs[1],inputs[2],inputs[3],inputs[4]);
				return null;
			}
		}
}
