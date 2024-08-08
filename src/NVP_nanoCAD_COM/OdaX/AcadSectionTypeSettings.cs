using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of the settings that apply to the various types of sections
///</summary>
namespace OdaX.AcadSectionTypeSettings 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSectionTypeSettings_Constructor : INode 
	{
		public OdaX.IAcadSectionTypeSettings _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSectionTypeSettings;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSectionTypeSettings_ConstructorCast : INode 
	{
		public OdaX.IAcadSectionTypeSettings _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSectionTypeSettings;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the options used to generate a section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the options used to generate a section.
	///</summary>
	public class GenerationOptions : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GenerationOptions);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the options used to generate a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("OdaX.AcSectionGeneration", typeof(System.Object))]

	///<summary>
	///Specifies or returns the options used to generate a section.
	///</summary>
	public class Set_GenerationOptions : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GenerationOptions = ((OdaX.AcSectionGeneration)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the objects used to generate a section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the objects used to generate a section.
	///</summary>
	public class SourceObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SourceObjects);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the objects used to generate a section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the objects used to generate a section.
	///</summary>
	public class Set_SourceObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SourceObjects = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the block used for the output of section generation.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the block used for the output of section generation.
	///</summary>
	public class DestinationBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DestinationBlock);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the block used for the output of section generation.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the block used for the output of section generation.
	///</summary>
	public class Set_DestinationBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DestinationBlock = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the file used for the output of section generation.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the file used for the output of section generation.
	///</summary>
	public class DestinationFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DestinationFile);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the file used for the output of section generation.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Specifies or returns the file used for the output of section generation.
	///</summary>
	public class Set_DestinationFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DestinationFile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of an intersection boundary section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the color of an intersection boundary section.
	///</summary>
	public class IntersectionBoundaryColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of an intersection boundary section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of an intersection boundary section.
	///</summary>
	public class Set_IntersectionBoundaryColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the layer of an intersection boundary section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the layer of an intersection boundary section.
	///</summary>
	public class IntersectionBoundaryLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryLayer);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the layer of an intersection boundary section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Layer", typeof(System.String))]

	///<summary>
	///Specifies or returns the layer of an intersection boundary section.
	///</summary>
	public class Set_IntersectionBoundaryLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype of an intersection boundary section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of an intersection boundary section.
	///</summary>
	public class IntersectionBoundaryLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryLinetype);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype of an intersection boundary section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies or returns the linetype of an intersection boundary section.
	///</summary>
	public class Set_IntersectionBoundaryLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryLinetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype scale of an intersection boundary section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype scale of an intersection boundary section.
	///</summary>
	public class IntersectionBoundaryLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryLinetypeScale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype scale of an intersection boundary section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("ltScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the linetype scale of an intersection boundary section.
	///</summary>
	public class Set_IntersectionBoundaryLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryLinetypeScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the plot style name of an intersection boundary section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the plot style name of an intersection boundary section.
	///</summary>
	public class IntersectionBoundaryPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryPlotStyleName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the plot style name of an intersection boundary section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]

	///<summary>
	///Specifies or returns the plot style name of an intersection boundary section.
	///</summary>
	public class Set_IntersectionBoundaryPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryPlotStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of an intersection boundary section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of an intersection boundary section.
	///</summary>
	public class IntersectionBoundaryLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryLineweight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of an intersection boundary section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of an intersection boundary section.
	///</summary>
	public class Set_IntersectionBoundaryLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryLineweight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether division lines are shown for an intersection boundary section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns whether division lines are shown for an intersection boundary section.
	///</summary>
	public class IntersectionBoundaryDivisionLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryDivisionLines);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether division lines are shown for an intersection boundary section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether division lines are shown for an intersection boundary section.
	///</summary>
	public class Set_IntersectionBoundaryDivisionLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryDivisionLines = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether an intersection fill section is visible.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns whether an intersection fill section is visible.
	///</summary>
	public class IntersectionFillVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillVisible);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether an intersection fill section is visible.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether an intersection fill section is visible.
	///</summary>
	public class Set_IntersectionFillVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillVisible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the hatch pattern type of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the hatch pattern type of an intersection fill section.
	///</summary>
	public class IntersectionFillHatchPatternType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillHatchPatternType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the hatch pattern type of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("OdaX.AcPatternType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the hatch pattern type of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillHatchPatternType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillHatchPatternType = ((OdaX.AcPatternType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the hatch pattern name of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the hatch pattern name of an intersection fill section.
	///</summary>
	public class IntersectionFillHatchPatternName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillHatchPatternName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the hatch pattern name of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Specifies or returns the hatch pattern name of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillHatchPatternName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillHatchPatternName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the hatch angle of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the hatch angle of an intersection fill section.
	///</summary>
	public class IntersectionFillHatchAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillHatchAngle);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the hatch angle of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the hatch angle of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillHatchAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillHatchAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the hatch scale of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the hatch scale of an intersection fill section.
	///</summary>
	public class IntersectionFillHatchScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillHatchScale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the hatch scale of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the hatch scale of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillHatchScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillHatchScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the hatch spacing of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the hatch spacing of an intersection fill section.
	///</summary>
	public class IntersectionFillHatchSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillHatchSpacing);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the hatch spacing of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///Specifies or returns the hatch spacing of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillHatchSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillHatchSpacing = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the color of an intersection fill section.
	///</summary>
	public class IntersectionFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the layer of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the layer of an intersection fill section.
	///</summary>
	public class IntersectionFillLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillLayer);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the layer of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Layer", typeof(System.String))]

	///<summary>
	///Specifies or returns the layer of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of an intersection fill section.
	///</summary>
	public class IntersectionFillLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillLinetype);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies or returns the linetype of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillLinetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype scale of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype scale of an intersection fill section.
	///</summary>
	public class IntersectionFillLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillLinetypeScale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype scale of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("ltScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the linetype scale of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillLinetypeScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the plot style name of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the plot style name of an intersection fill section.
	///</summary>
	public class IntersectionFillPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillPlotStyleName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the plot style name of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]

	///<summary>
	///Specifies or returns the plot style name of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillPlotStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of an intersection fill section.
	///</summary>
	public class IntersectionFillLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillLineweight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillLineweight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the face transparency value of an intersection fill section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the face transparency value of an intersection fill section.
	///</summary>
	public class IntersectionFillFaceTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillFaceTransparency);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the face transparency value of an intersection fill section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the face transparency value of an intersection fill section.
	///</summary>
	public class Set_IntersectionFillFaceTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillFaceTransparency = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a background geometry section is visible.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns whether a background geometry section is visible.
	///</summary>
	public class BackgroundLinesVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesVisible);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a background geometry section is visible.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a background geometry section is visible.
	///</summary>
	public class Set_BackgroundLinesVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesVisible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether hidden lines are visble for a background geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns whether hidden lines are visble for a background geometry section.
	///</summary>
	public class BackgroundLinesHiddenLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesHiddenLine);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether hidden lines are visble for a background geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether hidden lines are visble for a background geometry section.
	///</summary>
	public class Set_BackgroundLinesHiddenLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesHiddenLine = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of a background geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the color of a background geometry section.
	///</summary>
	public class BackgroundLinesColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of a background geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of a background geometry section.
	///</summary>
	public class Set_BackgroundLinesColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the layer of a background geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the layer of a background geometry section.
	///</summary>
	public class BackgroundLinesLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesLayer);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the layer of a background geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Layer", typeof(System.String))]

	///<summary>
	///Specifies or returns the layer of a background geometry section.
	///</summary>
	public class Set_BackgroundLinesLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype of a background geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of a background geometry section.
	///</summary>
	public class BackgroundLinesLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesLinetype);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype of a background geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies or returns the linetype of a background geometry section.
	///</summary>
	public class Set_BackgroundLinesLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesLinetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype scale of a background geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype scale of a background geometry section.
	///</summary>
	public class BackgroundLinesLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesLinetypeScale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype scale of a background geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("ltScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the linetype scale of a background geometry section.
	///</summary>
	public class Set_BackgroundLinesLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesLinetypeScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the plot style name of a background geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the plot style name of a background geometry section.
	///</summary>
	public class BackgroundLinesPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesPlotStyleName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the plot style name of a background geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]

	///<summary>
	///Specifies or returns the plot style name of a background geometry section.
	///</summary>
	public class Set_BackgroundLinesPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesPlotStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of a background geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of a background geometry section.
	///</summary>
	public class BackgroundLinesLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesLineweight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of a background geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of a background geometry section.
	///</summary>
	public class Set_BackgroundLinesLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesLineweight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a foreground geometry section is visible.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns whether a foreground geometry section is visible.
	///</summary>
	public class ForegroundLinesVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesVisible);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a foreground geometry section is visible.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a foreground geometry section is visible.
	///</summary>
	public class Set_ForegroundLinesVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesVisible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether hidden lines are visble for a foreground geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns whether hidden lines are visble for a foreground geometry section.
	///</summary>
	public class ForegroundLinesHiddenLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesHiddenLine);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether hidden lines are visble for a foreground geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether hidden lines are visble for a foreground geometry section.
	///</summary>
	public class Set_ForegroundLinesHiddenLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesHiddenLine = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of a foreground geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the color of a foreground geometry section.
	///</summary>
	public class ForegroundLinesColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of a foreground geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of a foreground geometry section.
	///</summary>
	public class Set_ForegroundLinesColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the layer of a foreground geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the layer of a foreground geometry section.
	///</summary>
	public class ForegroundLinesLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesLayer);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the layer of a foreground geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Layer", typeof(System.String))]

	///<summary>
	///Specifies or returns the layer of a foreground geometry section.
	///</summary>
	public class Set_ForegroundLinesLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype of a foreground geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of a foreground geometry section.
	///</summary>
	public class ForegroundLinesLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesLinetype);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype of a foreground geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies or returns the linetype of a foreground geometry section.
	///</summary>
	public class Set_ForegroundLinesLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesLinetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype scale of a foreground geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype scale of a foreground geometry section.
	///</summary>
	public class ForegroundLinesLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesLinetypeScale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype scale of a foreground geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("ltScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the linetype scale of a foreground geometry section.
	///</summary>
	public class Set_ForegroundLinesLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesLinetypeScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the plot style name of a foreground geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the plot style name of a foreground geometry section.
	///</summary>
	public class ForegroundLinesPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesPlotStyleName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the plot style name of a foreground geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]

	///<summary>
	///Specifies or returns the plot style name of a foreground geometry section.
	///</summary>
	public class Set_ForegroundLinesPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesPlotStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of a foreground geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of a foreground geometry section.
	///</summary>
	public class ForegroundLinesLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesLineweight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of a foreground geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of a foreground geometry section.
	///</summary>
	public class Set_ForegroundLinesLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesLineweight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the face transparency value of a foreground geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the face transparency value of a foreground geometry section.
	///</summary>
	public class ForegroundLinesFaceTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesFaceTransparency);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the face transparency value of a foreground geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the face transparency value of a foreground geometry section.
	///</summary>
	public class Set_ForegroundLinesFaceTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesFaceTransparency = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the edge transparency value of a foreground geometry section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the edge transparency value of a foreground geometry section.
	///</summary>
	public class ForegroundLinesEdgeTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesEdgeTransparency);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the edge transparency value of a foreground geometry section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the edge transparency value of a foreground geometry section.
	///</summary>
	public class Set_ForegroundLinesEdgeTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesEdgeTransparency = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a curve tangency line section is visible.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns whether a curve tangency line section is visible.
	///</summary>
	public class CurveTangencyLinesVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesVisible);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns whether a curve tangency line section is visible.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a curve tangency line section is visible.
	///</summary>
	public class Set_CurveTangencyLinesVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesVisible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of a curve tangency line section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the color of a curve tangency line section.
	///</summary>
	public class CurveTangencyLinesColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the color of a curve tangency line section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of a curve tangency line section.
	///</summary>
	public class Set_CurveTangencyLinesColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the layer of a curve tangency line section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the layer of a curve tangency line section.
	///</summary>
	public class CurveTangencyLinesLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesLayer);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the layer of a curve tangency line section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Layer", typeof(System.String))]

	///<summary>
	///Specifies or returns the layer of a curve tangency line section.
	///</summary>
	public class Set_CurveTangencyLinesLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesLayer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype of a curve tangency line section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of a curve tangency line section.
	///</summary>
	public class CurveTangencyLinesLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesLinetype);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype of a curve tangency line section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]

	///<summary>
	///Specifies or returns the linetype of a curve tangency line section.
	///</summary>
	public class Set_CurveTangencyLinesLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesLinetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype scale of a curve tangency line section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the linetype scale of a curve tangency line section.
	///</summary>
	public class CurveTangencyLinesLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesLinetypeScale);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the linetype scale of a curve tangency line section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("ltScale", typeof(System.Object))]

	///<summary>
	///Specifies or returns the linetype scale of a curve tangency line section.
	///</summary>
	public class Set_CurveTangencyLinesLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesLinetypeScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the plot style name of a curve tangency line section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies the plot style name of a curve tangency line section.
	///</summary>
	public class CurveTangencyLinesPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesPlotStyleName);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the plot style name of a curve tangency line section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]

	///<summary>
	///Specifies the plot style name of a curve tangency line section.
	///</summary>
	public class Set_CurveTangencyLinesPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesPlotStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of a curve tangency line section.", 
		ViewType = "Data")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of a curve tangency line section.
	///</summary>
	public class CurveTangencyLinesLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesLineweight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the lineweight of a curve tangency line section.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of a curve tangency line section.
	///</summary>
	public class Set_CurveTangencyLinesLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesLineweight = inputs[1].Value;
			return null;
		}
	}
}
