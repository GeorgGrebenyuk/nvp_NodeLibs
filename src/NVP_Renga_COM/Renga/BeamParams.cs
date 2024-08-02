using NVP.API.Nodes;

namespace Renga.BeamParams 
{
		[NodeInput("dynamic", typeof(object))]
		public class BeamParams_Constructor : INode 
		{
		public Renga.IBeamParams _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IBeamParams;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class BeamParams_ConstructorCast : INode 
		{
		public Renga.IBeamParams _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IBeamParams;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("BeamParams", typeof(object))]
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
		[NodeInput("BeamParams", typeof(object))]
		public class StyleId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.StyleId);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("BeamParams", typeof(object))]
		public class GetProfilePlacement : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetProfilePlacement);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("BeamParams", typeof(object))]
		[NodeInput("param", typeof(System.Double))]
		public class GetProfilePlacementOnBaseline : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetProfilePlacementOnBaseline(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("BeamParams", typeof(object))]
		public class VerticalOffset : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.VerticalOffset);

			}
		}
}
