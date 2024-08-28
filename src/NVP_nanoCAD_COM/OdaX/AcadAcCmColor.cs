using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///An interface for a TeighaX true color object
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadAcCmColor 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadAcCmColor_Constructor : INode 
	{
		public OdaX.IAcadAcCmColor _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadAcCmColor;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadAcCmColor_ConstructorCast : INode 
	{
		public OdaX.IAcadAcCmColor _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadAcCmColor;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the AcCmEntityColor of a true color.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAcCmColor", typeof(object))]
	[NodeInput("eColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the AcCmEntityColor of a true color.
	///</summary>
	public class Set_EntityColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EntityColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the AcCmEntityColor of a true color.", 
		ViewType = "Data")]
	[NodeInput("AcadAcCmColor", typeof(object))]

	///<summary>
	///Specifies or returns the AcCmEntityColor of a true color.
	///</summary>
	public class EntityColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EntityColor);

		}
	}


	[NVP_Manifest(
		Text = "Returns the name of a color.", 
		ViewType = "Data")]
	[NodeInput("AcadAcCmColor", typeof(object))]

	///<summary>
	///Returns the name of a color.
	///</summary>
	public class ColorName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColorName);

		}
	}


	[NVP_Manifest(
		Text = "Returns the book name of a color.", 
		ViewType = "Data")]
	[NodeInput("AcadAcCmColor", typeof(object))]

	///<summary>
	///Returns the book name of a color.
	///</summary>
	public class BookName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BookName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the color name and book name of a color.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAcCmColor", typeof(object))]
	[NodeInput("ColorName", typeof(System.String))]
	[NodeInput("BookName", typeof(System.String))]

	///<summary>
	///Specifies the color name and book name of a color.
	///</summary>
	public class SetNames : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetNames(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Deletes a true color.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAcCmColor", typeof(object))]

	///<summary>
	///Deletes a true color.
	///</summary>
	public class Delete : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Delete();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the red component of a true color.", 
		ViewType = "Data")]
	[NodeInput("AcadAcCmColor", typeof(object))]

	///<summary>
	///Returns the red component of a true color.
	///</summary>
	public class Red : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Red);

		}
	}


	[NVP_Manifest(
		Text = "Returns the blue component of a true color.", 
		ViewType = "Data")]
	[NodeInput("AcadAcCmColor", typeof(object))]

	///<summary>
	///Returns the blue component of a true color.
	///</summary>
	public class Blue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Blue);

		}
	}


	[NVP_Manifest(
		Text = "Returns the green component of a true color.", 
		ViewType = "Data")]
	[NodeInput("AcadAcCmColor", typeof(object))]

	///<summary>
	///Returns the green component of a true color.
	///</summary>
	public class Green : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Green);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the RGB values of a true color.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAcCmColor", typeof(object))]
	[NodeInput("Red", typeof(System.Object))]
	[NodeInput("Green", typeof(System.Object))]
	[NodeInput("Blue", typeof(System.Object))]

	///<summary>
	///Specifies the RGB values of a true color.
	///</summary>
	public class SetRGB : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetRGB(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color method.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAcCmColor", typeof(object))]
	[NodeInput("OdaX.AcColorMethod", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color method.
	///</summary>
	public class Set_ColorMethod : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColorMethod = ((OdaX.AcColorMethod)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color method.", 
		ViewType = "Data")]
	[NodeInput("AcadAcCmColor", typeof(object))]

	///<summary>
	///Specifies or returns the color method.
	///</summary>
	public class ColorMethod : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColorMethod);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color index of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadAcCmColor", typeof(object))]

	///<summary>
	///Specifies or returns the color index of an object.
	///</summary>
	public class ColorIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColorIndex);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color index of an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAcCmColor", typeof(object))]
	[NodeInput("OdaX.AcColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color index of an object.
	///</summary>
	public class Set_ColorIndex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColorIndex = ((OdaX.AcColor)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Sets the color to a color from a color book.", 
		ViewType = "Modifier")]
	[NodeInput("AcadAcCmColor", typeof(object))]
	[NodeInput("BookName", typeof(System.String))]
	[NodeInput("ColorName", typeof(System.String))]

	///<summary>
	///Sets the color to a color from a color book.
	///</summary>
	public class SetColorBookColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetColorBookColor(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}
}
