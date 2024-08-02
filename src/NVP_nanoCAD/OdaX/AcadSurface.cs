using NVP.API.Nodes;

namespace OdaX.AcadSurface 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadSurface_Constructor : INode 
		{
		public OdaX.IAcadSurface _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadSurface;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadSurface_ConstructorCast : INode 
		{
		public OdaX.IAcadSurface _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadSurface;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Returns the type of a surface.
		///</summary>
		[NodeInput("AcadSurface", typeof(object))]
		public class SurfaceType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SurfaceType);

			}
		}


		///<summary>
		///Specifies or returns the number of U isolines per surface that display.
		///</summary>
		[NodeInput("AcadSurface", typeof(object))]
		public class UIsolineDensity : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UIsolineDensity);

			}
		}


		///<summary>
		///Specifies or returns the number of U isolines per surface that display.
		///</summary>
		[NodeInput("AcadSurface", typeof(object))]
		[NodeInput("density", typeof(System.Object))]
		public class Set_UIsolineDensity : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.UIsolineDensity = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the number of V isolines per surface that display.
		///</summary>
		[NodeInput("AcadSurface", typeof(object))]
		public class VIsolineDensity : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.VIsolineDensity);

			}
		}


		///<summary>
		///Specifies or returns the number of V isolines per surface that display.
		///</summary>
		[NodeInput("AcadSurface", typeof(object))]
		[NodeInput("density", typeof(System.Object))]
		public class Set_VIsolineDensity : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.VIsolineDensity = inputs[1];
				return null;
			}
		}
}
