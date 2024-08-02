using NVP.API.Nodes;

namespace Renga.RouteParams 
{
		[NodeInput("dynamic", typeof(object))]
		public class RouteParams_Constructor : INode 
		{
		public Renga.IRouteParams _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IRouteParams;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class RouteParams_ConstructorCast : INode 
		{
		public Renga.IRouteParams _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IRouteParams;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("RouteParams", typeof(object))]
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
		[NodeInput("RouteParams", typeof(object))]
		public class SourceModelObjectId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SourceModelObjectId);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("RouteParams", typeof(object))]
		public class TargetModelObjectId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TargetModelObjectId);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("RouteParams", typeof(object))]
		public class SystemStyleId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SystemStyleId);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("RouteParams", typeof(object))]
		public class GetJointCount : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetJointCount);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("RouteParams", typeof(object))]
		public class GetJointParams : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetJointParams);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("RouteParams", typeof(object))]
		public class GetObjectOnRouteCount : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetObjectOnRouteCount);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("RouteParams", typeof(object))]
		public class GetObjectOnRoutePlacement : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetObjectOnRoutePlacement);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("RouteParams", typeof(object))]
		public class GetFlowSegmentCount : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetFlowSegmentCount);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("RouteParams", typeof(object))]
		public class GetFlowSegmentPlacement : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetFlowSegmentPlacement);

			}
		}
}
