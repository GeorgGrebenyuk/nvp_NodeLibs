using NVP.API.Nodes;

namespace nanoCAD.nanoCADPlotArea2 
{
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADPlotArea2_Constructor : INode 
		{
		public nanoCAD.InanoCADPlotArea2 _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as nanoCAD.InanoCADPlotArea2;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class nanoCADPlotArea2_ConstructorCast : INode 
		{
		public nanoCAD.InanoCADPlotArea2 _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as nanoCAD.InanoCADPlotArea2;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Retrieves position val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		public class Position : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Position);

			}
		}


		///<summary>
		///Retrieves position val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_Position : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Position = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves target val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		public class Target : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Target);

			}
		}


		///<summary>
		///Retrieves target val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_Target : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Target = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves upVector val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		public class UpVector : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UpVector);

			}
		}


		///<summary>
		///Retrieves upVector val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_UpVector : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.UpVector = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves field val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		public class Field : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Field);

			}
		}


		///<summary>
		///Retrieves field val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_Field : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Field = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves Perspective val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		public class Perspective : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Perspective);

			}
		}


		///<summary>
		///Retrieves Perspective val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_Perspective : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Perspective = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves lensLength val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		public class LensLength : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LensLength);

			}
		}


		///<summary>
		///Retrieves lensLength val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		[NodeInput("val", typeof(System.Double))]
		public class Set_LensLength : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LensLength = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves elevation val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		public class Elevation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Elevation);

			}
		}


		///<summary>
		///Retrieves elevation val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		[NodeInput("val", typeof(System.Double))]
		public class Set_Elevation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Elevation = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves viewOffset val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		public class ViewOffset : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ViewOffset);

			}
		}


		///<summary>
		///Retrieves viewOffset val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_ViewOffset : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ViewOffset = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves ptWindow1 val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		public class ptWindow1 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ptWindow1);

			}
		}


		///<summary>
		///Retrieves ptWindow1 val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_ptWindow1 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ptWindow1 = inputs[1];
				return null;
			}
		}


		///<summary>
		///Retrieves ptWindow2 val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		public class ptWindow2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ptWindow2);

			}
		}


		///<summary>
		///Retrieves ptWindow2 val
		///</summary>
		[NodeInput("nanoCADPlotArea2", typeof(object))]
		[NodeInput("val", typeof(System.Object))]
		public class Set_ptWindow2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ptWindow2 = inputs[1];
				return null;
			}
		}
}
