using NVP.API.Nodes;

namespace OdaX.AcadUnderlay 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadUnderlay_Constructor : INode 
		{
		public OdaX.IAcadUnderlay _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadUnderlay;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadUnderlay_ConstructorCast : INode 
		{
		public OdaX.IAcadUnderlay _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadUnderlay;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns the contrast of the underlay.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		public class Contrast : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Contrast);

			}
		}


		///<summary>
		///Specifies or returns the contrast of the underlay.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		[NodeInput("Contrast", typeof(System.Object))]
		public class Set_Contrast : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Contrast = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the fade of the underlay.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		public class Fade : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Fade);

			}
		}


		///<summary>
		///Specifies or returns the fade of the underlay.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		[NodeInput("Fade", typeof(System.Object))]
		public class Set_Fade : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Fade = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the lower left point of the underlay position.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		public class Position : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Position);

			}
		}


		///<summary>
		///Specifies or returns the lower left point of the underlay position.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		[NodeInput("pos", typeof(System.Object))]
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
		///Specifies or returns the rotation of the underlay.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		public class Rotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Rotation);

			}
		}


		///<summary>
		///Specifies or returns the rotation of the underlay.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		[NodeInput("rotAngle", typeof(System.Object))]
		public class Set_Rotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Rotation = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the width of the underlay.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		public class Width : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Width);

			}
		}


		///<summary>
		///Specifies or returns the width of the underlay.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
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
		///Specifies or returns the height of the underlay.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		public class Height : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Height);

			}
		}


		///<summary>
		///Specifies or returns the height of the underlay.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
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
		///Specifies or returns the name of the underlay file.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		public class UnderlayName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UnderlayName);

			}
		}


		///<summary>
		///Specifies or returns the name of the underlay file.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		[NodeInput("Name", typeof(System.String))]
		public class Set_UnderlayName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.UnderlayName = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the item name of the underlay file.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		[NodeInput("sheetName", typeof(System.String))]
		public class Set_ItemName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ItemName = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the item name of the underlay file.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		public class ItemName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ItemName);

			}
		}


		///<summary>
		///Specifies or returns whether the underlay displays in monochrome.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		public class Monochrome : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Monochrome);

			}
		}


		///<summary>
		///Specifies or returns whether the underlay displays in monochrome.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		[NodeInput("bMono", typeof(System.Object))]
		public class Set_Monochrome : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Monochrome = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether underlay colors are adjusted according to the background color.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		public class AdjustForBackground : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AdjustForBackground);

			}
		}


		///<summary>
		///Specifies or returns whether underlay colors are adjusted according to the background color.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		[NodeInput("Value", typeof(System.Object))]
		public class Set_AdjustForBackground : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AdjustForBackground = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies an area for displaying and printing the underlay.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		[NodeInput("boundry", typeof(System.Object))]
		public class ClipBoundary : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ClipBoundary(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Specifies or returns the scale factor of the underlay.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		public class ScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ScaleFactor);

			}
		}


		///<summary>
		///Specifies or returns the scale factor of the underlay.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		[NodeInput("ScaleFactor", typeof(System.Object))]
		public class Set_ScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ScaleFactor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the path to the underlay file.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		public class File : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.File);

			}
		}


		///<summary>
		///Specifies or returns the path to the underlay file.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		[NodeInput("Name", typeof(System.String))]
		public class Set_File : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.File = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether underlay displays in the drawing.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		public class UnderlayVisibility : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UnderlayVisibility);

			}
		}


		///<summary>
		///Specifies or returns whether underlay displays in the drawing.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		[NodeInput("fVisible", typeof(System.Object))]
		public class Set_UnderlayVisibility : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.UnderlayVisibility = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether the clipping boundary of the underlay is turned on.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		public class ClippingEnabled : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ClippingEnabled);

			}
		}


		///<summary>
		///Specifies or returns whether the clipping boundary of the underlay is turned on.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		[NodeInput("kClip", typeof(System.Object))]
		public class Set_ClippingEnabled : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ClippingEnabled = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether the layers of a DWF underlay are applied.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		public class UnderlayLayerOverrideApplied : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UnderlayLayerOverrideApplied);

			}
		}


		///<summary>
		///Specifies or returns whether the layers of a DWF underlay are applied.
		///</summary>
		[NodeInput("AcadUnderlay", typeof(object))]
		[NodeInput("bOverride", typeof(System.Object))]
		public class Set_UnderlayLayerOverrideApplied : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.UnderlayLayerOverrideApplied = inputs[1];
				return null;
			}
		}
}
