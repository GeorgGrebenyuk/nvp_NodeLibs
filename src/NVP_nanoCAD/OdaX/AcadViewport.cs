using NVP.API.Nodes;

namespace OdaX.AcadViewport 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadViewport_Constructor : INode 
		{
		public OdaX.IAcadViewport _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadViewport;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadViewport_ConstructorCast : INode 
		{
		public OdaX.IAcadViewport _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadViewport;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies the center of an arc, circle, ellipse, view, or viewport
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		public class Center : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Center);

			}
		}


		///<summary>
		///Specifies the center of an arc, circle, ellipse, view, or viewport
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("Center", typeof(System.Object))]
		public class Set_Center : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Center = inputs[1];
				return null;
			}
		}


		///<summary>
		///Height of the attribute, shape, text, or view toolbar or the main application window
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		public class Height : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Height);

			}
		}


		///<summary>
		///Height of the attribute, shape, text, or view toolbar or the main application window
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("Height", typeof(System.Double))]
		public class Set_Height : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Height = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the width of the text boundary, view, image, toolbar, or main application window
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		public class Width : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Width);

			}
		}


		///<summary>
		///Specifies the width of the text boundary, view, image, toolbar, or main application window
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("Width", typeof(System.Double))]
		public class Set_Width : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Width = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the target point for the view or viewport
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		public class Target : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Target);

			}
		}


		///<summary>
		///Specifies the target point for the view or viewport
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("targetPoint", typeof(System.Object))]
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
		///Specifies the viewing direction for a 3D visualization of the drawing
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		public class Direction : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Direction);

			}
		}


		///<summary>
		///Specifies the viewing direction for a 3D visualization of the drawing
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("dirVec", typeof(System.Object))]
		public class Set_Direction : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Direction = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the name of the object
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///Specifies the name of the object
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("bstrName", typeof(System.String))]
		public class Set_Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Name = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the status of the viewport grid
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		public class GridOn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GridOn);

			}
		}


		///<summary>
		///Specifies the status of the viewport grid
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("bGridOn", typeof(System.Object))]
		public class Set_GridOn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GridOn = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the status of the Ortho mode for the viewport
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		public class OrthoOn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.OrthoOn);

			}
		}


		///<summary>
		///Specifies the status of the Ortho mode for the viewport
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("bOrthoOn", typeof(System.Object))]
		public class Set_OrthoOn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.OrthoOn = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the snap base point for the viewport
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		public class SnapBasePoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SnapBasePoint);

			}
		}


		///<summary>
		///Specifies the snap base point for the viewport
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("lowLeft", typeof(System.Object))]
		public class Set_SnapBasePoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SnapBasePoint = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the status of snap
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		public class SnapOn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SnapOn);

			}
		}


		///<summary>
		///Specifies the status of snap
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("bSnapOn", typeof(System.Object))]
		public class Set_SnapOn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SnapOn = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the snap rotation angle of the viewport relative to the current UCS
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		public class SnapRotationAngle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SnapRotationAngle);

			}
		}


		///<summary>
		///Specifies the snap rotation angle of the viewport relative to the current UCS
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("Angle", typeof(System.Object))]
		public class Set_SnapRotationAngle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SnapRotationAngle = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies if the UCS icon is on
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		public class UCSIconOn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UCSIconOn);

			}
		}


		///<summary>
		///Specifies if the UCS icon is on
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("bIconOn", typeof(System.Object))]
		public class Set_UCSIconOn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.UCSIconOn = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies if the UCS icon is displayed at the origin
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		public class UCSIconAtOrigin : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UCSIconAtOrigin);

			}
		}


		///<summary>
		///Specifies if the UCS icon is displayed at the origin
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("bIconAtOrigin", typeof(System.Object))]
		public class Set_UCSIconAtOrigin : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.UCSIconAtOrigin = inputs[1];
				return null;
			}
		}


		///<summary>
		///Gets the lower-left corner of the current active viewport
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		public class LowerLeftCorner : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LowerLeftCorner);

			}
		}


		///<summary>
		///Gets the upper-right corner of the current active viewport
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		public class UpperRightCorner : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UpperRightCorner);

			}
		}


		///<summary>
		///Splits a viewport into the given number of views
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("NumWins", typeof(System.Object))]
		public class Split : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Split(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Gets the grid spacing for the viewport
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("XSpacing", typeof(System.Double))]
		[NodeInput("YSpacing", typeof(System.Double))]
		public class GetGridSpacing : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetGridSpacing(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Sets the grid spacing for the viewport
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("XSpacing", typeof(System.Double))]
		[NodeInput("YSpacing", typeof(System.Double))]
		public class SetGridSpacing : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetGridSpacing(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Gets the snap spacing for the viewport
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("XSpacing", typeof(System.Double))]
		[NodeInput("YSpacing", typeof(System.Double))]
		public class GetSnapSpacing : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetSnapSpacing(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Sets the snap spacing for the viewport
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("XSpacing", typeof(System.Double))]
		[NodeInput("YSpacing", typeof(System.Double))]
		public class SetSnapSpacing : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetSnapSpacing(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Sets the view in a viewport to a saved view in the Views Collection object
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("View", typeof(System.Object))]
		public class SetView : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetView(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Specifies the smoothness of circles, arcs, and ellipses
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		public class ArcSmoothness : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ArcSmoothness);

			}
		}


		///<summary>
		///Specifies the smoothness of circles, arcs, and ellipses
		///</summary>
		[NodeInput("AcadViewport", typeof(object))]
		[NodeInput("arcSmooth", typeof(System.Object))]
		public class Set_ArcSmoothness : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ArcSmoothness = inputs[1];
				return null;
			}
		}
}
