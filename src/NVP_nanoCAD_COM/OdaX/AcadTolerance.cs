using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a geometric tolerance contained in a feature control frame
///</summary>
namespace OdaX.AcadTolerance 
{

	[NVP_Manifest(
		Id = "0FBB48B1-6709-47D8-97FF-BEAE0F415034", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.AcadTolerance_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "_AcadTolerance_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadTolerance_Constructor : INode 
	{
		public OdaX.IAcadTolerance _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadTolerance;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "0168CD91-A816-4BED-AE82-890162347203", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.AcadTolerance_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "_AcadTolerance_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadTolerance_ConstructorCast : INode 
	{
		public OdaX.IAcadTolerance _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadTolerance;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "6BE9CAAF-A89C-4173-8C4A-8AE62D124846", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.DirectionVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "DirectionVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the direction for the ray, tolerance, or xline through a vector", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specifies the direction for the ray, tolerance, or xline through a vector
	///</summary>
	public class DirectionVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DirectionVector);

		}
	}


	[NVP_Manifest(
		Id = "B17CC8F1-644A-4030-A3E7-BC0CA9708067", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.Set_DirectionVector", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "Set_DirectionVector", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the direction for the ray, tolerance, or xline through a vector", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("dirVector", typeof(System.Object))]

	///<summary>
	///Specifies the direction for the ray, tolerance, or xline through a vector
	///</summary>
	public class Set_DirectionVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DirectionVector = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "40ACD90E-ED1E-4DDD-B5E9-45F133AACAAF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.InsertionPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "InsertionPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specify the X, Y, Z coordinate for insertion point of the tolerance", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specify the X, Y, Z coordinate for insertion point of the tolerance
	///</summary>
	public class InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InsertionPoint);

		}
	}


	[NVP_Manifest(
		Id = "C73F7338-A2FE-453C-9732-88DDB452A42B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.Set_InsertionPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "Set_InsertionPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specify the X, Y, Z coordinate for insertion point of the tolerance", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("insPoint", typeof(System.Object))]

	///<summary>
	///Specify the X, Y, Z coordinate for insertion point of the tolerance
	///</summary>
	public class Set_InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertionPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "44A53B6C-E138-4DB2-BCF7-420F2497E8BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the three-dimensional normal unit vector for the entity", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specifies the three-dimensional normal unit vector for the entity
	///</summary>
	public class Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Normal);

		}
	}


	[NVP_Manifest(
		Id = "13BDA930-97E3-4134-ACCD-7BBB411F0EB1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.Set_Normal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "Set_Normal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the three-dimensional normal unit vector for the entity", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("Normal", typeof(System.Object))]

	///<summary>
	///Specifies the three-dimensional normal unit vector for the entity
	///</summary>
	public class Set_Normal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Normal = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C73D9923-4F8D-4628-921A-1EB23A7BB090", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.StyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "StyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the style name of the tolerance", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specifies the style name of the tolerance
	///</summary>
	public class StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StyleName);

		}
	}


	[NVP_Manifest(
		Id = "7392E32A-27FC-45E2-A925-C3FA1D577B4E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.Set_StyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "Set_StyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the style name of the tolerance", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies the style name of the tolerance
	///</summary>
	public class Set_StyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "391DBB3E-18FF-4B08-ADA4-B6DAC48BA9E3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.TextColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "TextColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the color of the dimension text", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specifies the color of the dimension text
	///</summary>
	public class TextColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextColor);

		}
	}


	[NVP_Manifest(
		Id = "0E410735-CAF6-46FE-A777-1D0110682AEE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.Set_TextColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "Set_TextColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the color of the dimension text", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Specifies the color of the dimension text
	///</summary>
	public class Set_TextColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F6BE7D2D-474F-4312-BFB6-B9F7360FAC72", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.TextString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "TextString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text string of the tolerance", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specifies the text string of the tolerance
	///</summary>
	public class TextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextString);

		}
	}


	[NVP_Manifest(
		Id = "D8A8855F-7887-4BFA-AB3C-F8696CCFB4AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.Set_TextString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "Set_TextString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text string of the tolerance", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("bstrText", typeof(System.String))]

	///<summary>
	///Specifies the text string of the tolerance
	///</summary>
	public class Set_TextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextString = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0370EC8F-41D7-40DE-A237-726DA928260B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.TextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "TextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text style of the tolerance", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specifies the text style of the tolerance
	///</summary>
	public class TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyle);

		}
	}


	[NVP_Manifest(
		Id = "B8498A49-9C81-445A-B8B8-DF840A95CFDB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.Set_TextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "Set_TextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text style of the tolerance", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("style", typeof(System.String))]

	///<summary>
	///Specifies the text style of the tolerance
	///</summary>
	public class Set_TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E400B31B-9282-4D97-A5D3-BAD2B4DAECEF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text height of the tolerance", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specifies the text height of the tolerance
	///</summary>
	public class TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextHeight);

		}
	}


	[NVP_Manifest(
		Id = "2AAC6319-CC40-48F2-92AA-967FFF59F834", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.Set_TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "Set_TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the text height of the tolerance", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies the text height of the tolerance
	///</summary>
	public class Set_TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E9023D3E-4554-4BF8-BE85-6773B3BC39F3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.ScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "ScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the overall scale factor applied to properties that specify sizes, distances, or offsets", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specifies the overall scale factor applied to properties that specify sizes, distances, or offsets
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
		Id = "EA1AB5DF-5BA0-4D05-A692-AD284F4DBC97", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.Set_ScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "Set_ScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the overall scale factor applied to properties that specify sizes, distances, or offsets", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("factor", typeof(System.Object))]

	///<summary>
	///Specifies the overall scale factor applied to properties that specify sizes, distances, or offsets
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


	[NVP_Manifest(
		Id = "E62E15DF-08F9-417B-B10D-C0D5446A0614", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.DimensionLineColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "DimensionLineColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the color of the dimension lines", 
		ViewType = "Data")]
	[NodeInput("AcadTolerance", typeof(object))]

	///<summary>
	///Specifies the color of the dimension lines
	///</summary>
	public class DimensionLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimensionLineColor);

		}
	}


	[NVP_Manifest(
		Id = "F0532B59-E96C-4E43-A81B-49B54250FFE2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadTolerance.Set_DimensionLineColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadTolerance", 
		NodeName = "Set_DimensionLineColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the color of the dimension lines", 
		ViewType = "Modifier")]
	[NodeInput("AcadTolerance", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]

	///<summary>
	///Specifies the color of the dimension lines
	///</summary>
	public class Set_DimensionLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DimensionLineColor = inputs[1].Value;
			return null;
		}
	}
}
