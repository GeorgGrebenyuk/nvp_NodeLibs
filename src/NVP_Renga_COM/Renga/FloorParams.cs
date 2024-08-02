using NVP.API.Nodes;

namespace Renga.FloorParams 
{
		[NodeInput("dynamic", typeof(object))]
		public class FloorParams_Constructor : INode 
		{
		public Renga.IFloorParams _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IFloorParams;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class FloorParams_ConstructorCast : INode 
		{
		public Renga.IFloorParams _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IFloorParams;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("FloorParams", typeof(object))]
		public class GetContour : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetContour);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("FloorParams", typeof(object))]
		public class Thickness : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Thickness);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("FloorParams", typeof(object))]
		public class VerticalOffset : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.VerticalOffset);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("FloorParams", typeof(object))]
		public class GetDependentObjectIds : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetDependentObjectIds();
				return null;
			}
		}
}
