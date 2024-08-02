using NVP.API.Nodes;

namespace OdaX.AcadPViewport 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadPViewport_Constructor : INode 
		{
		public OdaX.IAcadPViewport _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadPViewport;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadPViewport_ConstructorCast : INode 
		{
		public OdaX.IAcadPViewport _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadPViewport;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns the x, y, and z coordinates of a paperspace viewports's center point.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class Center : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Center);

			}
		}


		///<summary>
		///Specifies or returns the x, y, and z coordinates of a paperspace viewports's center point.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("CenterPoint", typeof(System.Object))]
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
		///Specifies or returns the viewing direction fof a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class Direction : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Direction);

			}
		}


		///<summary>
		///Specifies or returns the viewing direction fof a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("dirVector", typeof(System.Object))]
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
		///Specifies or returns whether the grid is on for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class GridOn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GridOn);

			}
		}


		///<summary>
		///Specifies or returns whether the grid is on for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
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
		///Specifies or returns the height of a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class Height : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Height);

			}
		}


		///<summary>
		///Specifies or returns the height of a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
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
		///Specifies or returns the width of a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class Width : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Width);

			}
		}


		///<summary>
		///Specifies or returns the width of a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
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
		///Specifies or returns whether a paperspace viewport is on.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class ViewportOn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ViewportOn);

			}
		}


		///<summary>
		///Specifies or returns whether a paperspace viewport is on.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("bOn", typeof(System.Object))]
		public class Set_ViewportOn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ViewportOn = inputs[1];
				return null;
			}
		}


		///<summary>
		///Returns whether a paperspace viewport is clipped.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class Clipped : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Clipped);

			}
		}


		///<summary>
		///Specifies or returns whether a paperspace viewport is locked.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class DisplayLocked : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DisplayLocked);

			}
		}


		///<summary>
		///Specifies or returns whether a paperspace viewport is locked.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("bLocked", typeof(System.Object))]
		public class Set_DisplayLocked : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DisplayLocked = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the standard scale of a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class StandardScale : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.StandardScale);

			}
		}


		///<summary>
		///Specifies or returns the standard scale of a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("scale", typeof(System.Object))]
		public class Set_StandardScale : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.StandardScale = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns a custom scale for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class CustomScale : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CustomScale);

			}
		}


		///<summary>
		///Specifies or returns a custom scale for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("scale", typeof(System.Double))]
		public class Set_CustomScale : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.CustomScale = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the style sheet to use for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class StyleSheet : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.StyleSheet);

			}
		}


		///<summary>
		///Specifies or returns the style sheet to use for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("pName", typeof(System.String))]
		public class Set_StyleSheet : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.StyleSheet = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether the UCS is saved with a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class UCSPerViewport : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UCSPerViewport);

			}
		}


		///<summary>
		///Specifies or returns whether the UCS is saved with a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("UCSSaved", typeof(System.Object))]
		public class Set_UCSPerViewport : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.UCSPerViewport = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the snap base point for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class SnapBasePoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SnapBasePoint);

			}
		}


		///<summary>
		///Specifies or returns the snap base point for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
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
		///Specifies or returns whether the snap is turned on for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class SnapOn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SnapOn);

			}
		}


		///<summary>
		///Specifies or returns whether the snap is turned on for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
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
		///Specifies or returns the snap rotation angle of a paperspace viewport relative to the current UCS.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class SnapRotationAngle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SnapRotationAngle);

			}
		}


		///<summary>
		///Specifies or returns the snap rotation angle of a paperspace viewport relative to the current UCS.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("Angle", typeof(System.Double))]
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
		///Specifies or returns whether the UCS icon is turned on for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class UCSIconOn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UCSIconOn);

			}
		}


		///<summary>
		///Specifies or returns whether the UCS icon is turned on for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
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
		///Specifies or returns whether the UCS icon displays at the origin for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class UCSIconAtOrigin : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UCSIconAtOrigin);

			}
		}


		///<summary>
		///Specifies or returns whether the UCS icon displays at the origin for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
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
		///Specifies or returns the grid spacing for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
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
		///Specifies or returns the grid spacing for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
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
		///Specifies or returns the snap spacing for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
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
		///Specifies or returns the snap spacing for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
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
		///Turns the display of a paperspace viewport on or off.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("bStatus", typeof(System.Object))]
		public class Display : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Display(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Specifies or returns the twist angle, in radians, for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class TwistAngle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TwistAngle);

			}
		}


		///<summary>
		///Specifies or returns the twist angle, in radians, for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("Angle", typeof(System.Object))]
		public class Set_TwistAngle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TwistAngle = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the lens length used in perspective viewing for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class LensLength : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LensLength);

			}
		}


		///<summary>
		///Specifies or returns the lens length used in perspective viewing for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("Length", typeof(System.Double))]
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
		///Specifies or returns whether hidden line removal is turned on for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class RemoveHiddenLines : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.RemoveHiddenLines);

			}
		}


		///<summary>
		///Specifies or returns whether hidden line removal is turned on for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("bRemoval", typeof(System.Object))]
		public class Set_RemoveHiddenLines : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.RemoveHiddenLines = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the target point for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class Target : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Target);

			}
		}


		///<summary>
		///Specifies or returns the target point for a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
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
		///Specifies or returns the smoothness of circles, arcs, and ellipses that display in a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class ArcSmoothness : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ArcSmoothness);

			}
		}


		///<summary>
		///Specifies or returns the smoothness of circles, arcs, and ellipses that display in a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
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


		///<summary>
		///Not implemented. Specifies or returns the visual style of a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class VisualStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.VisualStyle);

			}
		}


		///<summary>
		///Not implemented. Specifies or returns the visual style of a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("pVisualStyleIndex", typeof(System.Int32))]
		public class Set_VisualStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.VisualStyle = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the shade plot mode of a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class ShadePlot : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShadePlot);

			}
		}


		///<summary>
		///Specifies or returns the shade plot mode of a paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("pShadePlotIndex", typeof(System.Int32))]
		public class Set_ShadePlot : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShadePlot = inputs[1];
				return null;
			}
		}


		///<summary>
		///Not implemented. Specifies or returns the model view associated with the paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class ModelView : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ModelView);

			}
		}


		///<summary>
		///Not implemented. Specifies or returns the model view associated with the paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("View", typeof(System.Object))]
		public class Set_ModelView : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ModelView = inputs[1];
				return null;
			}
		}


		///<summary>
		///Not implemented. Specifies or returns the sheet view associated with the paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class SheetView : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SheetView);

			}
		}


		///<summary>
		///Not implemented. Specifies or returns the sheet view associated with the paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("View", typeof(System.Object))]
		public class Set_SheetView : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SheetView = inputs[1];
				return null;
			}
		}


		///<summary>
		///Not implemented. Specifies or returns the label block ID associated with the paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class LabelBlockId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LabelBlockId);

			}
		}


		///<summary>
		///Not implemented. Specifies or returns the label block ID associated with the paperspace viewport.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("ObjectID", typeof(System.Object))]
		public class Set_LabelBlockId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LabelBlockId = inputs[1];
				return null;
			}
		}


		///<summary>
		///Not implemented. Specifies whether the paperspace viewport is linked to a corresponding sheet view.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class HasSheetView : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HasSheetView);

			}
		}


		///<summary>
		///Not implemented. Updates the paperspace viewport parameters with the parameters in the associated model view.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class SyncModelView : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SyncModelView();
				return null;
			}
		}


		///<summary>
		///Specifies the standard scale for the viewport
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class StandardScale2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.StandardScale2);

			}
		}


		///<summary>
		///Specifies the standard scale for the viewport
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		[NodeInput("scale", typeof(System.Int32))]
		public class Set_StandardScale2 : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.StandardScale2 = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies whether the viewport has layer property overrides.
		///</summary>
		[NodeInput("AcadPViewport", typeof(object))]
		public class LayerPropertyOverrides : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LayerPropertyOverrides);

			}
		}
}
