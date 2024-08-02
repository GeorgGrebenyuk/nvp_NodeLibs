using NVP.API.Nodes;

namespace Renga.LevelObject 
{
		[NodeInput("dynamic", typeof(object))]
		public class LevelObject_Constructor : INode 
		{
		public Renga.ILevelObject _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.ILevelObject;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class LevelObject_ConstructorCast : INode 
		{
		public Renga.ILevelObject _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.ILevelObject;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("LevelObject", typeof(object))]
		public class LevelId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LevelId);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("LevelObject", typeof(object))]
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
		[NodeInput("LevelObject", typeof(object))]
		public class PlacementElevation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PlacementElevation);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("LevelObject", typeof(object))]
		public class ElevationAboveLevel : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ElevationAboveLevel);

			}
		}
}
