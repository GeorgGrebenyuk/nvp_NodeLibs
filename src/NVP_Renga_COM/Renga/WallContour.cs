using NVP.API.Nodes;

namespace Renga.WallContour 
{
		[NodeInput("dynamic", typeof(object))]
		public class WallContour_Constructor : INode 
		{
		public Renga.IWallContour _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IWallContour;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class WallContour_ConstructorCast : INode 
		{
		public Renga.IWallContour _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IWallContour;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("WallContour", typeof(object))]
		public class GetCenterLine : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetCenterLine);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("WallContour", typeof(object))]
		public class GetBaseline : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetBaseline);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("WallContour", typeof(object))]
		public class GetLeftCurve : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetLeftCurve);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("WallContour", typeof(object))]
		public class GetRightCurve : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetRightCurve);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("WallContour", typeof(object))]
		public class GetBeginCurve : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetBeginCurve);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("WallContour", typeof(object))]
		public class GetEndCurve : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetEndCurve);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("WallContour", typeof(object))]
		public class GetContour : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetContour);

			}
		}
}
