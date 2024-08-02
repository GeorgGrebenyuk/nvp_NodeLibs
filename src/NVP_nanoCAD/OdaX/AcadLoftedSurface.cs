using NVP.API.Nodes;

namespace OdaX.AcadLoftedSurface 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadLoftedSurface_Constructor : INode 
		{
		public OdaX.IAcadLoftedSurface _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadLoftedSurface;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadLoftedSurface_ConstructorCast : INode 
		{
		public OdaX.IAcadLoftedSurface _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadLoftedSurface;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Returns the number of cross-sections used to create a lofted surface.
		///</summary>
		[NodeInput("AcadLoftedSurface", typeof(object))]
		public class NumCrossSections : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.NumCrossSections);

			}
		}


		///<summary>
		///Returns the number of guide paths used to create a lofted surface.
		///</summary>
		[NodeInput("AcadLoftedSurface", typeof(object))]
		public class NumGuidePaths : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.NumGuidePaths);

			}
		}


		///<summary>
		///Specifies or returns which curves are normal to the cross-sections.
		///</summary>
		[NodeInput("AcadLoftedSurface", typeof(object))]
		public class SurfaceNormals : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SurfaceNormals);

			}
		}


		///<summary>
		///Specifies or returns which curves are normal to the cross-sections.
		///</summary>
		[NodeInput("AcadLoftedSurface", typeof(object))]
		[NodeInput("surfaceNormal", typeof(System.Object))]
		public class Set_SurfaceNormals : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SurfaceNormals = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the angle of the first cross-section surface.
		///</summary>
		[NodeInput("AcadLoftedSurface", typeof(object))]
		public class StartDraftAngle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.StartDraftAngle);

			}
		}


		///<summary>
		///Specifies or returns the angle of the first cross-section surface.
		///</summary>
		[NodeInput("AcadLoftedSurface", typeof(object))]
		[NodeInput("StartDraftAngle", typeof(System.Object))]
		public class Set_StartDraftAngle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.StartDraftAngle = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the magnitude of the first cross-section surface.
		///</summary>
		[NodeInput("AcadLoftedSurface", typeof(object))]
		public class StartDraftMagnitude : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.StartDraftMagnitude);

			}
		}


		///<summary>
		///Specifies or returns the magnitude of the first cross-section surface.
		///</summary>
		[NodeInput("AcadLoftedSurface", typeof(object))]
		[NodeInput("startDraftMag", typeof(System.Double))]
		public class Set_StartDraftMagnitude : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.StartDraftMagnitude = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the angle of the last cross-section surface.
		///</summary>
		[NodeInput("AcadLoftedSurface", typeof(object))]
		public class EndDraftAngle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.EndDraftAngle);

			}
		}


		///<summary>
		///Specifies or returns the angle of the last cross-section surface.
		///</summary>
		[NodeInput("AcadLoftedSurface", typeof(object))]
		[NodeInput("EndDraftAngle", typeof(System.Object))]
		public class Set_EndDraftAngle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.EndDraftAngle = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the magnitude of the last cross-section surface.
		///</summary>
		[NodeInput("AcadLoftedSurface", typeof(object))]
		public class EndDraftMagnitude : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.EndDraftMagnitude);

			}
		}


		///<summary>
		///Specifies or returns the magnitude of the last cross-section surface.
		///</summary>
		[NodeInput("AcadLoftedSurface", typeof(object))]
		[NodeInput("endDraftMag", typeof(System.Double))]
		public class Set_EndDraftMagnitude : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.EndDraftMagnitude = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specfies or returns whether the lofted surface is open or closed.
		///</summary>
		[NodeInput("AcadLoftedSurface", typeof(object))]
		public class Closed : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Closed);

			}
		}


		///<summary>
		///Specfies or returns whether the lofted surface is open or closed.
		///</summary>
		[NodeInput("AcadLoftedSurface", typeof(object))]
		[NodeInput("bClosed", typeof(System.Object))]
		public class Set_Closed : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Closed = inputs[1];
				return null;
			}
		}
}
