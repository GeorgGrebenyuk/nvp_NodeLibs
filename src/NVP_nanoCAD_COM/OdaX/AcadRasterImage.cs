using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///or raster) of small squares or dots known as pixels
///</summary>
namespace OdaX.AcadRasterImage 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "Specifies the current brightness value of the raster image", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the current brightness value of the raster image
	///</summary>
	public class Brightness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Brightness);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the current brightness value of the raster image", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("Brightness", typeof(System.Object))]

	///<summary>
	///Specifies the current brightness value of the raster image
	///</summary>
	public class Set_Brightness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Brightness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the current contrast value of the raster image", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the current contrast value of the raster image
	///</summary>
	public class Contrast : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Contrast);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the current contrast value of the raster image", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("Contrast", typeof(System.Object))]

	///<summary>
	///Specifies the current contrast value of the raster image
	///</summary>
	public class Set_Contrast : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Contrast = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the current fade value of the raster image", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the current fade value of the raster image
	///</summary>
	public class Fade : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Fade);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the current fade value of the raster image", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("Fade", typeof(System.Object))]

	///<summary>
	///Specifies the current fade value of the raster image
	///</summary>
	public class Set_Fade : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Fade = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "lower left corner) of the raster image", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///lower left corner) of the raster image
	///</summary>
	public class Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Origin);

		}
	}


	[NVP_Manifest(
		Text = "lower left corner) of the raster image", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("Origin", typeof(System.Object))]

	///<summary>
	///lower left corner) of the raster image
	///</summary>
	public class Set_Origin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Origin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the rotation angle of the raster image", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the rotation angle of the raster image
	///</summary>
	public class Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rotation);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the rotation angle of the raster image", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("rotAngle", typeof(System.Object))]

	///<summary>
	///Specifies the rotation angle of the raster image
	///</summary>
	public class Set_Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the width of the raster image", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the width of the raster image
	///</summary>
	public class ImageWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ImageWidth);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the width of the raster image", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies the width of the raster image
	///</summary>
	public class Set_ImageWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ImageWidth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the height of the raster image", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the height of the raster image
	///</summary>
	public class ImageHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ImageHeight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the height of the raster image", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies the height of the raster image
	///</summary>
	public class Set_ImageHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ImageHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the name of the image file", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the name of the image file
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the name of the image file", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies the name of the image file
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the path to the image file", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("imageFileName", typeof(System.String))]

	///<summary>
	///Specifies the path to the image file
	///</summary>
	public class Set_ImageFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ImageFile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the path to the image file", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the path to the image file
	///</summary>
	public class ImageFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ImageFile);

		}
	}


	[NVP_Manifest(
		Text = "Determines whether image is visible or not", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Determines whether image is visible or not
	///</summary>
	public class ImageVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ImageVisibility);

		}
	}


	[NVP_Manifest(
		Text = "Determines whether image is visible or not", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("fVisible", typeof(System.Object))]

	///<summary>
	///Determines whether image is visible or not
	///</summary>
	public class Set_ImageVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ImageVisibility = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Enables or disables the clipping boundary of the image", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Enables or disables the clipping boundary of the image
	///</summary>
	public class ClippingEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ClippingEnabled);

		}
	}


	[NVP_Manifest(
		Text = "Enables or disables the clipping boundary of the image", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("kClip", typeof(System.Object))]

	///<summary>
	///Enables or disables the clipping boundary of the image
	///</summary>
	public class Set_ClippingEnabled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClippingEnabled = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Determines whether transparency for a bitonal image is On or Off", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Determines whether transparency for a bitonal image is On or Off
	///</summary>
	public class Transparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Transparency);

		}
	}


	[NVP_Manifest(
		Text = "Determines whether transparency for a bitonal image is On or Off", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("bTransp", typeof(System.Object))]

	///<summary>
	///Determines whether transparency for a bitonal image is On or Off
	///</summary>
	public class Set_Transparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Transparency = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Set clipping boundary", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("boundry", typeof(System.Object))]

	///<summary>
	///Set clipping boundary
	///</summary>
	public class ClipBoundary : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ClipBoundary(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Height of the attribute, shape, text, or view toolbar or the main application window", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the width of the text boundary, view, image, toolbar, or main application window", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the width of the text boundary, view, image, toolbar, or main application window
	///</summary>
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	[NVP_Manifest(
		Text = "Determines if a raster image is displayed at its rotation value", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Determines if a raster image is displayed at its rotation value
	///</summary>
	public class ShowRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShowRotation);

		}
	}


	[NVP_Manifest(
		Text = "Determines if a raster image is displayed at its rotation value", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("bShow", typeof(System.Object))]

	///<summary>
	///Determines if a raster image is displayed at its rotation value
	///</summary>
	public class Set_ShowRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShowRotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the scale factor of the raster image", 
		ViewType = "Data")]
	[NodeInput("AcadRasterImage", typeof(object))]

	///<summary>
	///Specifies the scale factor of the raster image
	///</summary>
	public class ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleFactor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the scale factor of the raster image", 
		ViewType = "Modifier")]
	[NodeInput("AcadRasterImage", typeof(object))]
	[NodeInput("ScaleFactor", typeof(System.Object))]

	///<summary>
	///Specifies the scale factor of the raster image
	///</summary>
	public class Set_ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleFactor = inputs[1].Value;
			return null;
		}
	}
}
