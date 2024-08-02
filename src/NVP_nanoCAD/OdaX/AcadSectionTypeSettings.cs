using NVP.API.Nodes;

namespace OdaX.AcadSectionTypeSettings 
{
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


	///<summary>
	///Specifies or returns the options used to generate a section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class GenerationOptions : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GenerationOptions);

		}
	}


	///<summary>
	///Specifies or returns the options used to generate a section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_GenerationOptions : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GenerationOptions = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the objects used to generate a section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class SourceObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SourceObjects);

		}
	}


	///<summary>
	///Specifies or returns the objects used to generate a section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_SourceObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SourceObjects = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the block used for the output of section generation.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class DestinationBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DestinationBlock);

		}
	}


	///<summary>
	///Specifies or returns the block used for the output of section generation.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_DestinationBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DestinationBlock = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the file used for the output of section generation.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class DestinationFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DestinationFile);

		}
	}


	///<summary>
	///Specifies or returns the file used for the output of section generation.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]
	public class Set_DestinationFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DestinationFile = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the color of an intersection boundary section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionBoundaryColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryColor);

		}
	}


	///<summary>
	///Specifies or returns the color of an intersection boundary section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]
	public class Set_IntersectionBoundaryColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryColor = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the layer of an intersection boundary section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionBoundaryLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryLayer);

		}
	}


	///<summary>
	///Specifies or returns the layer of an intersection boundary section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Layer", typeof(System.String))]
	public class Set_IntersectionBoundaryLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryLayer = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the linetype of an intersection boundary section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionBoundaryLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryLinetype);

		}
	}


	///<summary>
	///Specifies or returns the linetype of an intersection boundary section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]
	public class Set_IntersectionBoundaryLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryLinetype = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the linetype scale of an intersection boundary section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionBoundaryLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryLinetypeScale);

		}
	}


	///<summary>
	///Specifies or returns the linetype scale of an intersection boundary section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("ltScale", typeof(System.Object))]
	public class Set_IntersectionBoundaryLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryLinetypeScale = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the plot style name of an intersection boundary section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionBoundaryPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryPlotStyleName);

		}
	}


	///<summary>
	///Specifies or returns the plot style name of an intersection boundary section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]
	public class Set_IntersectionBoundaryPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryPlotStyleName = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the lineweight of an intersection boundary section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionBoundaryLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryLineweight);

		}
	}


	///<summary>
	///Specifies or returns the lineweight of an intersection boundary section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]
	public class Set_IntersectionBoundaryLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryLineweight = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether division lines are shown for an intersection boundary section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionBoundaryDivisionLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionBoundaryDivisionLines);

		}
	}


	///<summary>
	///Specifies or returns whether division lines are shown for an intersection boundary section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_IntersectionBoundaryDivisionLines : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionBoundaryDivisionLines = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether an intersection fill section is visible.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionFillVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillVisible);

		}
	}


	///<summary>
	///Specifies or returns whether an intersection fill section is visible.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_IntersectionFillVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillVisible = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the hatch pattern type of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionFillHatchPatternType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillHatchPatternType);

		}
	}


	///<summary>
	///Specifies or returns the hatch pattern type of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_IntersectionFillHatchPatternType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillHatchPatternType = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the hatch pattern name of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionFillHatchPatternName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillHatchPatternName);

		}
	}


	///<summary>
	///Specifies or returns the hatch pattern name of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]
	public class Set_IntersectionFillHatchPatternName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillHatchPatternName = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the hatch angle of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionFillHatchAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillHatchAngle);

		}
	}


	///<summary>
	///Specifies or returns the hatch angle of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_IntersectionFillHatchAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillHatchAngle = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the hatch scale of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionFillHatchScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillHatchScale);

		}
	}


	///<summary>
	///Specifies or returns the hatch scale of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_IntersectionFillHatchScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillHatchScale = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the hatch spacing of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionFillHatchSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillHatchSpacing);

		}
	}


	///<summary>
	///Specifies or returns the hatch spacing of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]
	public class Set_IntersectionFillHatchSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillHatchSpacing = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the color of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillColor);

		}
	}


	///<summary>
	///Specifies or returns the color of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]
	public class Set_IntersectionFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillColor = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the layer of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionFillLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillLayer);

		}
	}


	///<summary>
	///Specifies or returns the layer of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Layer", typeof(System.String))]
	public class Set_IntersectionFillLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillLayer = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the linetype of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionFillLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillLinetype);

		}
	}


	///<summary>
	///Specifies or returns the linetype of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]
	public class Set_IntersectionFillLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillLinetype = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the linetype scale of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionFillLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillLinetypeScale);

		}
	}


	///<summary>
	///Specifies or returns the linetype scale of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("ltScale", typeof(System.Object))]
	public class Set_IntersectionFillLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillLinetypeScale = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the plot style name of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionFillPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillPlotStyleName);

		}
	}


	///<summary>
	///Specifies or returns the plot style name of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]
	public class Set_IntersectionFillPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillPlotStyleName = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the lineweight of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionFillLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillLineweight);

		}
	}


	///<summary>
	///Specifies or returns the lineweight of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]
	public class Set_IntersectionFillLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillLineweight = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the face transparency value of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class IntersectionFillFaceTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IntersectionFillFaceTransparency);

		}
	}


	///<summary>
	///Specifies or returns the face transparency value of an intersection fill section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_IntersectionFillFaceTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IntersectionFillFaceTransparency = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether a background geometry section is visible.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class BackgroundLinesVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesVisible);

		}
	}


	///<summary>
	///Specifies or returns whether a background geometry section is visible.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_BackgroundLinesVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesVisible = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether hidden lines are visble for a background geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class BackgroundLinesHiddenLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesHiddenLine);

		}
	}


	///<summary>
	///Specifies or returns whether hidden lines are visble for a background geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_BackgroundLinesHiddenLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesHiddenLine = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the color of a background geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class BackgroundLinesColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesColor);

		}
	}


	///<summary>
	///Specifies or returns the color of a background geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]
	public class Set_BackgroundLinesColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesColor = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the layer of a background geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class BackgroundLinesLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesLayer);

		}
	}


	///<summary>
	///Specifies or returns the layer of a background geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Layer", typeof(System.String))]
	public class Set_BackgroundLinesLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesLayer = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the linetype of a background geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class BackgroundLinesLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesLinetype);

		}
	}


	///<summary>
	///Specifies or returns the linetype of a background geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]
	public class Set_BackgroundLinesLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesLinetype = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the linetype scale of a background geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class BackgroundLinesLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesLinetypeScale);

		}
	}


	///<summary>
	///Specifies or returns the linetype scale of a background geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("ltScale", typeof(System.Object))]
	public class Set_BackgroundLinesLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesLinetypeScale = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the plot style name of a background geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class BackgroundLinesPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesPlotStyleName);

		}
	}


	///<summary>
	///Specifies or returns the plot style name of a background geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]
	public class Set_BackgroundLinesPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesPlotStyleName = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the lineweight of a background geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class BackgroundLinesLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackgroundLinesLineweight);

		}
	}


	///<summary>
	///Specifies or returns the lineweight of a background geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]
	public class Set_BackgroundLinesLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackgroundLinesLineweight = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether a foreground geometry section is visible.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class ForegroundLinesVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesVisible);

		}
	}


	///<summary>
	///Specifies or returns whether a foreground geometry section is visible.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_ForegroundLinesVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesVisible = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether hidden lines are visble for a foreground geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class ForegroundLinesHiddenLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesHiddenLine);

		}
	}


	///<summary>
	///Specifies or returns whether hidden lines are visble for a foreground geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_ForegroundLinesHiddenLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesHiddenLine = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the color of a foreground geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class ForegroundLinesColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesColor);

		}
	}


	///<summary>
	///Specifies or returns the color of a foreground geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]
	public class Set_ForegroundLinesColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesColor = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the layer of a foreground geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class ForegroundLinesLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesLayer);

		}
	}


	///<summary>
	///Specifies or returns the layer of a foreground geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Layer", typeof(System.String))]
	public class Set_ForegroundLinesLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesLayer = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the linetype of a foreground geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class ForegroundLinesLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesLinetype);

		}
	}


	///<summary>
	///Specifies or returns the linetype of a foreground geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]
	public class Set_ForegroundLinesLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesLinetype = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the linetype scale of a foreground geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class ForegroundLinesLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesLinetypeScale);

		}
	}


	///<summary>
	///Specifies or returns the linetype scale of a foreground geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("ltScale", typeof(System.Object))]
	public class Set_ForegroundLinesLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesLinetypeScale = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the plot style name of a foreground geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class ForegroundLinesPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesPlotStyleName);

		}
	}


	///<summary>
	///Specifies or returns the plot style name of a foreground geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]
	public class Set_ForegroundLinesPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesPlotStyleName = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the lineweight of a foreground geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class ForegroundLinesLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesLineweight);

		}
	}


	///<summary>
	///Specifies or returns the lineweight of a foreground geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]
	public class Set_ForegroundLinesLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesLineweight = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the face transparency value of a foreground geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class ForegroundLinesFaceTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesFaceTransparency);

		}
	}


	///<summary>
	///Specifies or returns the face transparency value of a foreground geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_ForegroundLinesFaceTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesFaceTransparency = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the edge transparency value of a foreground geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class ForegroundLinesEdgeTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ForegroundLinesEdgeTransparency);

		}
	}


	///<summary>
	///Specifies or returns the edge transparency value of a foreground geometry section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_ForegroundLinesEdgeTransparency : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ForegroundLinesEdgeTransparency = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether a curve tangency line section is visible.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class CurveTangencyLinesVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesVisible);

		}
	}


	///<summary>
	///Specifies or returns whether a curve tangency line section is visible.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]
	public class Set_CurveTangencyLinesVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesVisible = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the color of a curve tangency line section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class CurveTangencyLinesColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesColor);

		}
	}


	///<summary>
	///Specifies or returns the color of a curve tangency line section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("pColor", typeof(System.Object))]
	public class Set_CurveTangencyLinesColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesColor = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the layer of a curve tangency line section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class CurveTangencyLinesLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesLayer);

		}
	}


	///<summary>
	///Specifies or returns the layer of a curve tangency line section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Layer", typeof(System.String))]
	public class Set_CurveTangencyLinesLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesLayer = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the linetype of a curve tangency line section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class CurveTangencyLinesLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesLinetype);

		}
	}


	///<summary>
	///Specifies or returns the linetype of a curve tangency line section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Linetype", typeof(System.String))]
	public class Set_CurveTangencyLinesLinetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesLinetype = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the linetype scale of a curve tangency line section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class CurveTangencyLinesLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesLinetypeScale);

		}
	}


	///<summary>
	///Specifies or returns the linetype scale of a curve tangency line section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("ltScale", typeof(System.Object))]
	public class Set_CurveTangencyLinesLinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesLinetypeScale = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the plot style name of a curve tangency line section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class CurveTangencyLinesPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesPlotStyleName);

		}
	}


	///<summary>
	///Specifies the plot style name of a curve tangency line section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("plotStyle", typeof(System.String))]
	public class Set_CurveTangencyLinesPlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesPlotStyleName = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the lineweight of a curve tangency line section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	public class CurveTangencyLinesLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CurveTangencyLinesLineweight);

		}
	}


	///<summary>
	///Specifies or returns the lineweight of a curve tangency line section.
	///</summary>
	[NodeInput("AcadSectionTypeSettings", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]
	public class Set_CurveTangencyLinesLineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CurveTangencyLinesLineweight = inputs[1];
			return null;
		}
	}
}
