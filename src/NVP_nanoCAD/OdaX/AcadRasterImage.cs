using NVP.API.Nodes;

namespace OdaX.AcadRasterImage 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadRasterImage_Constructor : INode 
		{
		public OdaX.IAcadRasterImage _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadRasterImage;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadRasterImage_ConstructorCast : INode 
		{
		public OdaX.IAcadRasterImage _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadRasterImage;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies the current brightness value of the raster image
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		public class Brightness : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Brightness);

			}
		}


		///<summary>
		///Specifies the current brightness value of the raster image
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		[NodeInput("Brightness", typeof(System.Object))]
		public class Set_Brightness : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Brightness = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the current contrast value of the raster image
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		public class Contrast : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Contrast);

			}
		}


		///<summary>
		///Specifies the current contrast value of the raster image
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
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
		///Specifies the current fade value of the raster image
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		public class Fade : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Fade);

			}
		}


		///<summary>
		///Specifies the current fade value of the raster image
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
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
		///lower left corner) of the raster image
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		public class Origin : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Origin);

			}
		}


		///<summary>
		///lower left corner) of the raster image
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		[NodeInput("Origin", typeof(System.Object))]
		public class Set_Origin : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Origin = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the rotation angle of the raster image
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		public class Rotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Rotation);

			}
		}


		///<summary>
		///Specifies the rotation angle of the raster image
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
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
		///Specifies the width of the raster image
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		public class ImageWidth : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ImageWidth);

			}
		}


		///<summary>
		///Specifies the width of the raster image
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		[NodeInput("Width", typeof(System.Double))]
		public class Set_ImageWidth : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ImageWidth = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the height of the raster image
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		public class ImageHeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ImageHeight);

			}
		}


		///<summary>
		///Specifies the height of the raster image
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		[NodeInput("Height", typeof(System.Double))]
		public class Set_ImageHeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ImageHeight = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the name of the image file
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///Specifies the name of the image file
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		[NodeInput("Name", typeof(System.String))]
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
		///Specifies the path to the image file
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		[NodeInput("imageFileName", typeof(System.String))]
		public class Set_ImageFile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ImageFile = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the path to the image file
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		public class ImageFile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ImageFile);

			}
		}


		///<summary>
		///Determines whether image is visible or not
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		public class ImageVisibility : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ImageVisibility);

			}
		}


		///<summary>
		///Determines whether image is visible or not
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		[NodeInput("fVisible", typeof(System.Object))]
		public class Set_ImageVisibility : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ImageVisibility = inputs[1];
				return null;
			}
		}


		///<summary>
		///Enables or disables the clipping boundary of the image
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		public class ClippingEnabled : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ClippingEnabled);

			}
		}


		///<summary>
		///Enables or disables the clipping boundary of the image
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
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
		///Determines whether transparency for a bitonal image is On or Off
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		public class Transparency : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Transparency);

			}
		}


		///<summary>
		///Determines whether transparency for a bitonal image is On or Off
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		[NodeInput("bTransp", typeof(System.Object))]
		public class Set_Transparency : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Transparency = inputs[1];
				return null;
			}
		}


		///<summary>
		///Set clipping boundary
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
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
		///Height of the attribute, shape, text, or view toolbar or the main application window
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		public class Height : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Height);

			}
		}


		///<summary>
		///Specifies the width of the text boundary, view, image, toolbar, or main application window
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		public class Width : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Width);

			}
		}


		///<summary>
		///Determines if a raster image is displayed at its rotation value
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		public class ShowRotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShowRotation);

			}
		}


		///<summary>
		///Determines if a raster image is displayed at its rotation value
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		[NodeInput("bShow", typeof(System.Object))]
		public class Set_ShowRotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShowRotation = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the scale factor of the raster image
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
		public class ScaleFactor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ScaleFactor);

			}
		}


		///<summary>
		///Specifies the scale factor of the raster image
		///</summary>
		[NodeInput("AcadRasterImage", typeof(object))]
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
}
