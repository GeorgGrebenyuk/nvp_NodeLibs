using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Provides an interface to the database resident objects in an TeighaX document
///</summary>
namespace OdaX.AcadDatabase 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDatabase_Constructor : INode 
	{
		public OdaX.IAcadDatabase _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDatabase;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDatabase_ConstructorCast : INode 
	{
		public OdaX.IAcadDatabase _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDatabase;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns the ModelSpace collection for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the ModelSpace collection for a document.
	///</summary>
	public class ModelSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ModelSpace);

		}
	}


	[NVP_Manifest(
		Text = "Returns the PaperSpace collection for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the PaperSpace collection for a document.
	///</summary>
	public class PaperSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PaperSpace);

		}
	}


	[NVP_Manifest(
		Text = "Returns the Blocks collection for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Blocks collection for a document.
	///</summary>
	public class Blocks : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Blocks);

		}
	}


	[NVP_Manifest(
		Text = "Duplicates multiple objects.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]
	[NodeInput("Owner", typeof(System.Object))]
	[NodeInput("IdPairs", typeof(System.Object))]

	///<summary>
	///Duplicates multiple objects.
	///</summary>
	public class CopyObjects : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CopyObjects(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Text = "Returns the Groups Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Groups Collection object for a document.
	///</summary>
	public class Groups : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Groups);

		}
	}


	[NVP_Manifest(
		Text = "Returns the DimStyles Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the DimStyles Collection object for a document.
	///</summary>
	public class DimStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DimStyles);

		}
	}


	[NVP_Manifest(
		Text = "Returns the Layers Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Layers Collection object for a document.
	///</summary>
	public class Layers : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Layers);

		}
	}


	[NVP_Manifest(
		Text = "Returns the Linetypes Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Linetypes Collection object for a document.
	///</summary>
	public class Linetypes : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Linetypes);

		}
	}


	[NVP_Manifest(
		Text = "Returns the Dictionaries Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Dictionaries Collection object for a document.
	///</summary>
	public class Dictionaries : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Dictionaries);

		}
	}


	[NVP_Manifest(
		Text = "Returns the RegisteredApplications Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the RegisteredApplications Collection object for a document.
	///</summary>
	public class RegisteredApplications : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RegisteredApplications);

		}
	}


	[NVP_Manifest(
		Text = "Returns the TextStyles Collection object of a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the TextStyles Collection object of a document.
	///</summary>
	public class TextStyles : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyles);

		}
	}


	[NVP_Manifest(
		Text = "Returns the UCSs Collection object of a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the UCSs Collection object of a document.
	///</summary>
	public class UserCoordinateSystems : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UserCoordinateSystems);

		}
	}


	[NVP_Manifest(
		Text = "Returns the Views Collection object of a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Views Collection object of a document.
	///</summary>
	public class Views : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Views);

		}
	}


	[NVP_Manifest(
		Text = "Returns the Viewports Collection object of a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Viewports Collection object of a document.
	///</summary>
	public class Viewports : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Viewports);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the elevation in modelspace.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Specifies or returns the elevation in modelspace.
	///</summary>
	public class ElevationModelSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElevationModelSpace);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the elevation in modelspace.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabase", typeof(object))]
	[NodeInput("Elevation", typeof(System.Double))]

	///<summary>
	///Specifies or returns the elevation in modelspace.
	///</summary>
	public class Set_ElevationModelSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ElevationModelSpace = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the elevation in paperspace.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Specifies or returns the elevation in paperspace.
	///</summary>
	public class ElevationPaperSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ElevationPaperSpace);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the elevation in paperspace.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabase", typeof(object))]
	[NodeInput("Elevation", typeof(System.Double))]

	///<summary>
	///Specifies or returns the elevation in paperspace.
	///</summary>
	public class Set_ElevationPaperSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ElevationPaperSpace = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the drawing limits of a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Specifies or returns the drawing limits of a document.
	///</summary>
	public class Limits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Limits);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the drawing limits of a document.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDatabase", typeof(object))]
	[NodeInput("Limits", typeof(System.Object))]

	///<summary>
	///Specifies or returns the drawing limits of a document.
	///</summary>
	public class Set_Limits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Limits = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the object that corresponds with a specified handle.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]
	[NodeInput("Handle", typeof(System.String))]

	///<summary>
	///Returns the object that corresponds with a specified handle.
	///</summary>
	public class HandleToObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HandleToObject(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Returns the object that corresponds with a specified object ID.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]
	[NodeInput("ObjectID", typeof(System.Object))]

	///<summary>
	///Returns the object that corresponds with a specified object ID.
	///</summary>
	public class ObjectIdToObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectIdToObject(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Returns the Layouts Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Layouts Collection object for a document.
	///</summary>
	public class Layouts : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Layouts);

		}
	}


	[NVP_Manifest(
		Text = "Returns the PlotConfigurations Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the PlotConfigurations Collection object for a document.
	///</summary>
	public class PlotConfigurations : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotConfigurations);

		}
	}


	[NVP_Manifest(
		Text = "Returns the Preferences object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Preferences object for a document.
	///</summary>
	public class Preferences : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Preferences);

		}
	}


	[NVP_Manifest(
		Text = "Returns the FileDependencies Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the FileDependencies Collection object for a document.
	///</summary>
	public class FileDependencies : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FileDependencies);

		}
	}


	[NVP_Manifest(
		Text = "Returns the SummaryInfo object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the SummaryInfo object for a document.
	///</summary>
	public class SummaryInfo : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SummaryInfo);

		}
	}


	[NVP_Manifest(
		Text = "Returns the SectionManager Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the SectionManager Collection object for a document.
	///</summary>
	public class SectionManager : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SectionManager);

		}
	}


	[NVP_Manifest(
		Text = "Returns the Materials Collection object for a document.", 
		ViewType = "Data")]
	[NodeInput("AcadDatabase", typeof(object))]

	///<summary>
	///Returns the Materials Collection object for a document.
	///</summary>
	public class Materials : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Materials);

		}
	}
}
